<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnDesconectar = New System.Windows.Forms.Button()
        Me.txtServidor = New System.Windows.Forms.TextBox()
        Me.lblServidor = New System.Windows.Forms.Label()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.lblPuerto = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblEstadoConexion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(12, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(100, 30)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnDesconectar
        '
        Me.btnDesconectar.Enabled = False
        Me.btnDesconectar.Location = New System.Drawing.Point(118, 12)
        Me.btnDesconectar.Name = "btnDesconectar"
        Me.btnDesconectar.Size = New System.Drawing.Size(100, 30)
        Me.btnDesconectar.TabIndex = 1
        Me.btnDesconectar.Text = "Desconectar"
        Me.btnDesconectar.UseVisualStyleBackColor = True
        '
        'txtServidor
        '
        Me.txtServidor.Location = New System.Drawing.Point(280, 18)
        Me.txtServidor.Name = "txtServidor"
        Me.txtServidor.Size = New System.Drawing.Size(120, 20)
        Me.txtServidor.TabIndex = 2
        Me.txtServidor.Text = "localhost"
        '
        'lblServidor
        '
        Me.lblServidor.AutoSize = True
        Me.lblServidor.Location = New System.Drawing.Point(230, 21)
        Me.lblServidor.Name = "lblServidor"
        Me.lblServidor.Size = New System.Drawing.Size(44, 13)
        Me.lblServidor.TabIndex = 3
        Me.lblServidor.Text = "Servidor:"
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(450, 18)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(80, 20)
        Me.txtPuerto.TabIndex = 4
        Me.txtPuerto.Text = "8080"
        '
        'lblPuerto
        '
        Me.lblPuerto.AutoSize = True
        Me.lblPuerto.Location = New System.Drawing.Point(410, 21)
        Me.lblPuerto.Name = "lblPuerto"
        Me.lblPuerto.Size = New System.Drawing.Size(34, 13)
        Me.lblPuerto.TabIndex = 5
        Me.lblPuerto.Text = "Puerto:"
        '
        'txtMensaje
        '
        Me.txtMensaje.Location = New System.Drawing.Point(12, 60)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(600, 20)
        Me.txtMensaje.TabIndex = 6
        Me.txtMensaje.Text = "Hola servidor!"
        '
        'btnEnviar
        '
        Me.btnEnviar.Enabled = False
        Me.btnEnviar.Location = New System.Drawing.Point(630, 58)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 25)
        Me.btnEnviar.TabIndex = 7
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(12, 100)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(776, 338)
        Me.txtLog.TabIndex = 8
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(12, 84)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(28, 13)
        Me.lblLog.TabIndex = 9
        Me.lblLog.Text = "Log:"
        '
        'lblEstadoConexion
        '
        Me.lblEstadoConexion.AutoSize = True
        Me.lblEstadoConexion.ForeColor = System.Drawing.Color.Red
        Me.lblEstadoConexion.Location = New System.Drawing.Point(550, 21)
        Me.lblEstadoConexion.Name = "lblEstadoConexion"
        Me.lblEstadoConexion.Size = New System.Drawing.Size(89, 13)
        Me.lblEstadoConexion.TabIndex = 10
        Me.lblEstadoConexion.Text = "Estado: Desconectado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEstadoConexion)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.lblPuerto)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.lblServidor)
        Me.Controls.Add(Me.txtServidor)
        Me.Controls.Add(Me.btnDesconectar)
        Me.Controls.Add(Me.btnConectar)
        Me.Name = "Form1"
        Me.Text = "Cliente TCP - VB.NET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents btnDesconectar As Button
    Friend WithEvents txtServidor As TextBox
    Friend WithEvents lblServidor As Label
    Friend WithEvents txtPuerto As TextBox
    Friend WithEvents lblPuerto As Label
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnEnviar As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblLog As Label
    Friend WithEvents lblEstadoConexion As Label

End Class
