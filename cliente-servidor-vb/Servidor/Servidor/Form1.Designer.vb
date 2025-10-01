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
        Me.btnIniciarServidor = New System.Windows.Forms.Button()
        Me.btnDetenerServidor = New System.Windows.Forms.Button()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.lblPuerto = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblClientesConectados = New System.Windows.Forms.Label()
        Me.lblEstadoServidor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnIniciarServidor
        '
        Me.btnIniciarServidor.Location = New System.Drawing.Point(12, 12)
        Me.btnIniciarServidor.Name = "btnIniciarServidor"
        Me.btnIniciarServidor.Size = New System.Drawing.Size(120, 30)
        Me.btnIniciarServidor.TabIndex = 0
        Me.btnIniciarServidor.Text = "Iniciar Servidor"
        Me.btnIniciarServidor.UseVisualStyleBackColor = True
        '
        'btnDetenerServidor
        '
        Me.btnDetenerServidor.Enabled = False
        Me.btnDetenerServidor.Location = New System.Drawing.Point(138, 12)
        Me.btnDetenerServidor.Name = "btnDetenerServidor"
        Me.btnDetenerServidor.Size = New System.Drawing.Size(120, 30)
        Me.btnDetenerServidor.TabIndex = 1
        Me.btnDetenerServidor.Text = "Detener Servidor"
        Me.btnDetenerServidor.UseVisualStyleBackColor = True
        '
        'txtPuerto
        '
        Me.txtPuerto.Location = New System.Drawing.Point(320, 18)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(80, 20)
        Me.txtPuerto.TabIndex = 2
        Me.txtPuerto.Text = "8080"
        '
        'lblPuerto
        '
        Me.lblPuerto.AutoSize = True
        Me.lblPuerto.Location = New System.Drawing.Point(280, 21)
        Me.lblPuerto.Name = "lblPuerto"
        Me.lblPuerto.Size = New System.Drawing.Size(34, 13)
        Me.lblPuerto.TabIndex = 3
        Me.lblPuerto.Text = "Puerto:"
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(12, 80)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(776, 358)
        Me.txtLog.TabIndex = 4
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(12, 64)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(28, 13)
        Me.lblLog.TabIndex = 5
        Me.lblLog.Text = "Log:"
        '
        'lblClientesConectados
        '
        Me.lblClientesConectados.AutoSize = True
        Me.lblClientesConectados.Location = New System.Drawing.Point(450, 21)
        Me.lblClientesConectados.Name = "lblClientesConectados"
        Me.lblClientesConectados.Size = New System.Drawing.Size(108, 13)
        Me.lblClientesConectados.TabIndex = 6
        Me.lblClientesConectados.Text = "Clientes conectados: 0"
        '
        'lblEstadoServidor
        '
        Me.lblEstadoServidor.AutoSize = True
        Me.lblEstadoServidor.ForeColor = System.Drawing.Color.Red
        Me.lblEstadoServidor.Location = New System.Drawing.Point(12, 48)
        Me.lblEstadoServidor.Name = "lblEstadoServidor"
        Me.lblEstadoServidor.Size = New System.Drawing.Size(89, 13)
        Me.lblEstadoServidor.TabIndex = 7
        Me.lblEstadoServidor.Text = "Estado: Detenido"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEstadoServidor)
        Me.Controls.Add(Me.lblClientesConectados)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.lblPuerto)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.btnDetenerServidor)
        Me.Controls.Add(Me.btnIniciarServidor)
        Me.Name = "Form1"
        Me.Text = "Servidor TCP - VB.NET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIniciarServidor As Button
    Friend WithEvents btnDetenerServidor As Button
    Friend WithEvents txtPuerto As TextBox
    Friend WithEvents lblPuerto As Label
    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblLog As Label
    Friend WithEvents lblClientesConectados As Label
    Friend WithEvents lblEstadoServidor As Label

End Class
