Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Private tcpListener As TcpListener
    Private servidorActivo As Boolean = False
    Private clientesConectados As Integer = 0
    Private hiloServidor As Thread

    Private Sub btnIniciarServidor_Click(sender As Object, e As EventArgs) Handles btnIniciarServidor.Click
        Try
            Dim puerto As Integer = Integer.Parse(txtPuerto.Text)
            
            tcpListener = New TcpListener(IPAddress.Any, puerto)
            tcpListener.Start()
            servidorActivo = True
            
            ' Actualizar interfaz
            btnIniciarServidor.Enabled = False
            btnDetenerServidor.Enabled = True
            txtPuerto.Enabled = False
            lblEstadoServidor.Text = "Estado: Activo"
            lblEstadoServidor.ForeColor = Color.Green
            
            ' Iniciar hilo para aceptar conexiones
            hiloServidor = New Thread(AddressOf AceptarConexiones)
            hiloServidor.IsBackground = True
            hiloServidor.Start()
            
            AgregarLog($"Servidor iniciado en puerto {puerto}")
            
        Catch ex As Exception
            MessageBox.Show($"Error al iniciar servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDetenerServidor_Click(sender As Object, e As EventArgs) Handles btnDetenerServidor.Click
        Try
            servidorActivo = False
            
            If tcpListener IsNot Nothing Then
                tcpListener.Stop()
            End If
            
            ' Actualizar interfaz
            btnIniciarServidor.Enabled = True
            btnDetenerServidor.Enabled = False
            txtPuerto.Enabled = True
            lblEstadoServidor.Text = "Estado: Detenido"
            lblEstadoServidor.ForeColor = Color.Red
            
            AgregarLog("Servidor detenido")
            
        Catch ex As Exception
            MessageBox.Show($"Error al detener servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AceptarConexiones()
        While servidorActivo
            Try
                If tcpListener.Pending() Then
                    Dim cliente As TcpClient = tcpListener.AcceptTcpClient()
                    clientesConectados += 1
                    
                    ' Actualizar contador en hilo principal
                    Me.Invoke(Sub() ActualizarContadorClientes())
                    
                    ' Iniciar hilo para manejar cliente
                    Dim hiloCliente As New Thread(Sub() ManejarCliente(cliente))
                    hiloCliente.IsBackground = True
                    hiloCliente.Start()
                    
                    Me.Invoke(Sub() AgregarLog($"Cliente conectado desde {cliente.Client.RemoteEndPoint}"))
                End If
                
                Thread.Sleep(100) ' Pequeña pausa para no sobrecargar CPU
                
            Catch ex As Exception
                If servidorActivo Then
                    Me.Invoke(Sub() AgregarLog($"Error al aceptar conexión: {ex.Message}"))
                End If
            End Try
        End While
    End Sub

    Private Sub ManejarCliente(cliente As TcpClient)
        Try
            Dim stream As NetworkStream = cliente.GetStream()
            Dim buffer(1023) As Byte
            
            While cliente.Connected And servidorActivo
                If stream.DataAvailable Then
                    Dim bytesLeidos As Integer = stream.Read(buffer, 0, buffer.Length)
                    If bytesLeidos > 0 Then
                        Dim mensaje As String = Encoding.UTF8.GetString(buffer, 0, bytesLeidos)
                        
                        ' Mostrar mensaje en log
                        Me.Invoke(Sub() AgregarLog($"Mensaje recibido: {mensaje}"))
                        
                        ' Enviar confirmación
                        Dim respuesta As String = $"Mensaje recibido: {mensaje}"
                        Dim datosRespuesta As Byte() = Encoding.UTF8.GetBytes(respuesta)
                        stream.Write(datosRespuesta, 0, datosRespuesta.Length)
                        
                        Me.Invoke(Sub() AgregarLog($"Respuesta enviada: {respuesta}"))
                    End If
                End If
                
                Thread.Sleep(50)
            End While
            
        Catch ex As Exception
            Me.Invoke(Sub() AgregarLog($"Error al manejar cliente: {ex.Message}"))
        Finally
            Try
                cliente.Close()
                clientesConectados -= 1
                Me.Invoke(Sub() ActualizarContadorClientes())
                Me.Invoke(Sub() AgregarLog($"Cliente desconectado. Clientes restantes: {clientesConectados}"))
            Catch
                ' Ignorar errores al cerrar
            End Try
        End Try
    End Sub

    Private Sub ActualizarContadorClientes()
        lblClientesConectados.Text = $"Clientes conectados: {clientesConectados}"
    End Sub

    Private Sub AgregarLog(mensaje As String)
        Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss")
        txtLog.AppendText($"[{timestamp}] {mensaje}{Environment.NewLine}")
        txtLog.ScrollToCaret()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        servidorActivo = False
        
        If tcpListener IsNot Nothing Then
            Try
                tcpListener.Stop()
            Catch
                ' Ignorar errores al cerrar
            End Try
        End If
    End Sub
End Class
