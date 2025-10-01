Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1
    Private tcpClient As TcpClient
    Private stream As NetworkStream
    Private conectado As Boolean = False
    Private hiloEscucha As Thread

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Try
            Dim servidor As String = txtServidor.Text
            Dim puerto As Integer = Integer.Parse(txtPuerto.Text)
            
            tcpClient = New TcpClient()
            tcpClient.Connect(servidor, puerto)
            stream = tcpClient.GetStream()
            conectado = True
            
            ' Actualizar interfaz
            btnConectar.Enabled = False
            btnDesconectar.Enabled = True
            btnEnviar.Enabled = True
            txtServidor.Enabled = False
            txtPuerto.Enabled = False
            lblEstadoConexion.Text = "Estado: Conectado"
            lblEstadoConexion.ForeColor = Color.Green
            
            ' Iniciar hilo para escuchar respuestas
            hiloEscucha = New Thread(AddressOf EscucharRespuestas)
            hiloEscucha.IsBackground = True
            hiloEscucha.Start()
            
            AgregarLog($"Conectado al servidor {servidor}:{puerto}")
            
        Catch ex As Exception
            MessageBox.Show($"Error al conectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AgregarLog($"Error al conectar: {ex.Message}")
        End Try
    End Sub

    Private Sub btnDesconectar_Click(sender As Object, e As EventArgs) Handles btnDesconectar.Click
        Try
            conectado = False
            
            If stream IsNot Nothing Then
                stream.Close()
            End If
            
            If tcpClient IsNot Nothing Then
                tcpClient.Close()
            End If
            
            ' Actualizar interfaz
            btnConectar.Enabled = True
            btnDesconectar.Enabled = False
            btnEnviar.Enabled = False
            txtServidor.Enabled = True
            txtPuerto.Enabled = True
            lblEstadoConexion.Text = "Estado: Desconectado"
            lblEstadoConexion.ForeColor = Color.Red
            
            AgregarLog("Desconectado del servidor")
            
        Catch ex As Exception
            MessageBox.Show($"Error al desconectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            If Not conectado OrElse stream Is Nothing Then
                MessageBox.Show("No hay conexión activa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            Dim mensaje As String = txtMensaje.Text.Trim()
            If String.IsNullOrEmpty(mensaje) Then
                MessageBox.Show("Por favor ingrese un mensaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            
            ' Enviar mensaje
            Dim datos As Byte() = Encoding.UTF8.GetBytes(mensaje)
            stream.Write(datos, 0, datos.Length)
            
            AgregarLog($"Mensaje enviado: {mensaje}")
            
            ' Limpiar campo de mensaje
            txtMensaje.Clear()
            
        Catch ex As Exception
            MessageBox.Show($"Error al enviar mensaje: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AgregarLog($"Error al enviar mensaje: {ex.Message}")
        End Try
    End Sub

    Private Sub EscucharRespuestas()
        Dim buffer(1023) As Byte
        
        While conectado AndAlso tcpClient.Connected
            Try
                If stream.DataAvailable Then
                    Dim bytesLeidos As Integer = stream.Read(buffer, 0, buffer.Length)
                    If bytesLeidos > 0 Then
                        Dim respuesta As String = Encoding.UTF8.GetString(buffer, 0, bytesLeidos)
                        Me.Invoke(Sub() AgregarLog($"Respuesta recibida: {respuesta}"))
                    End If
                End If
                
                Thread.Sleep(50)
                
            Catch ex As Exception
                If conectado Then
                    Me.Invoke(Sub() AgregarLog($"Error al recibir respuesta: {ex.Message}"))
                End If
                Exit While
            End Try
        End While
    End Sub

    Private Sub AgregarLog(mensaje As String)
        Dim timestamp As String = DateTime.Now.ToString("HH:mm:ss")
        txtLog.AppendText($"[{timestamp}] {mensaje}{Environment.NewLine}")
        txtLog.ScrollToCaret()
    End Sub

    Private Sub txtMensaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMensaje.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) AndAlso btnEnviar.Enabled Then
            btnEnviar_Click(sender, e)
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        conectado = False
        
        If stream IsNot Nothing Then
            Try
                stream.Close()
            Catch
                ' Ignorar errores al cerrar
            End Try
        End If
        
        If tcpClient IsNot Nothing Then
            Try
                tcpClient.Close()
            Catch
                ' Ignorar errores al cerrar
            End Try
        End If
    End Sub
End Class
