<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txbContrasena = New System.Windows.Forms.TextBox()
        Me.txbDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(315, 261)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(184, 38)
        Me.btnLogin.TabIndex = 9
        Me.btnLogin.Text = "Iniciar Sesion"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txbContrasena
        '
        Me.txbContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbContrasena.Location = New System.Drawing.Point(391, 209)
        Me.txbContrasena.Name = "txbContrasena"
        Me.txbContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbContrasena.Size = New System.Drawing.Size(159, 32)
        Me.txbContrasena.TabIndex = 8
        '
        'txbDni
        '
        Me.txbDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbDni.Location = New System.Drawing.Point(391, 157)
        Me.txbDni.Name = "txbDni"
        Me.txbDni.Size = New System.Drawing.Size(159, 32)
        Me.txbDni.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(242, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña :"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(310, 157)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(68, 26)
        Me.lblUsuario.TabIndex = 5
        Me.lblUsuario.Text = "DNI  :"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txbContrasena)
        Me.Controls.Add(Me.txbDni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUsuario)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txbContrasena As TextBox
    Friend WithEvents txbDni As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsuario As Label
End Class
