﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alta
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
        Me.components = New System.ComponentModel.Container()
        Me.btn = New System.Windows.Forms.Button()
        Me.txbTelefono = New System.Windows.Forms.TextBox()
        Me.txbEdad = New System.Windows.Forms.TextBox()
        Me.txbApellido = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.txbDni = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txbGmail = New System.Windows.Forms.TextBox()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.txtConfirmarContrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ErrorDni = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorApellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorEdad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errortlf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorGmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSexo = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorDni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errortlf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorGmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(365, 403)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 29
        Me.btn.Text = "Registrar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txbTelefono
        '
        Me.txbTelefono.Location = New System.Drawing.Point(389, 260)
        Me.txbTelefono.MaxLength = 9
        Me.txbTelefono.Name = "txbTelefono"
        Me.txbTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txbTelefono.TabIndex = 27
        '
        'txbEdad
        '
        Me.txbEdad.Location = New System.Drawing.Point(389, 187)
        Me.txbEdad.MaxLength = 3
        Me.txbEdad.Name = "txbEdad"
        Me.txbEdad.Size = New System.Drawing.Size(100, 20)
        Me.txbEdad.TabIndex = 25
        '
        'txbApellido
        '
        Me.txbApellido.Location = New System.Drawing.Point(389, 157)
        Me.txbApellido.Name = "txbApellido"
        Me.txbApellido.Size = New System.Drawing.Size(100, 20)
        Me.txbApellido.TabIndex = 24
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(389, 125)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(100, 20)
        Me.txbNombre.TabIndex = 23
        '
        'txbDni
        '
        Me.txbDni.Location = New System.Drawing.Point(389, 91)
        Me.txbDni.MaxLength = 9
        Me.txbDni.Name = "txbDni"
        Me.txbDni.Size = New System.Drawing.Size(100, 20)
        Me.txbDni.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "G-mail :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Telefono :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sexo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Edad :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Apellido :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre :"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(311, 91)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(32, 13)
        Me.lblDni.TabIndex = 15
        Me.lblDni.Text = "Dni : "
        '
        'txbGmail
        '
        Me.txbGmail.Location = New System.Drawing.Point(389, 295)
        Me.txbGmail.Name = "txbGmail"
        Me.txbGmail.Size = New System.Drawing.Size(100, 20)
        Me.txbGmail.TabIndex = 28
        '
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexo.Location = New System.Drawing.Point(389, 220)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.cmbSexo.TabIndex = 30
        '
        'txtConfirmarContrasena
        '
        Me.txtConfirmarContrasena.Location = New System.Drawing.Point(389, 355)
        Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        Me.txtConfirmarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmarContrasena.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Confirmar Contraseña:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(389, 325)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(294, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Contraseña :"
        '
        'ErrorDni
        '
        Me.ErrorDni.ContainerControl = Me
        '
        'ErrorNombre
        '
        Me.ErrorNombre.ContainerControl = Me
        '
        'ErrorApellido
        '
        Me.ErrorApellido.ContainerControl = Me
        '
        'ErrorEdad
        '
        Me.ErrorEdad.ContainerControl = Me
        '
        'Errortlf
        '
        Me.Errortlf.ContainerControl = Me
        '
        'ErrorGmail
        '
        Me.ErrorGmail.ContainerControl = Me
        '
        'ErrorSexo
        '
        Me.ErrorSexo.ContainerControl = Me
        '
        'Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtConfirmarContrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txbGmail)
        Me.Controls.Add(Me.txbTelefono)
        Me.Controls.Add(Me.txbEdad)
        Me.Controls.Add(Me.txbApellido)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.txbDni)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDni)
        Me.Name = "Alta"
        Me.Text = "Alta"
        CType(Me.ErrorDni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorApellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorEdad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errortlf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorGmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSexo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbEdad As TextBox
    Friend WithEvents txbApellido As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txbDni As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txbGmail As TextBox
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents txtConfirmarContrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorDni As ErrorProvider
    Friend WithEvents ErrorNombre As ErrorProvider
    Friend WithEvents ErrorApellido As ErrorProvider
    Friend WithEvents ErrorEdad As ErrorProvider
    Friend WithEvents Errortlf As ErrorProvider
    Friend WithEvents ErrorGmail As ErrorProvider
    Friend WithEvents ErrorSexo As ErrorProvider
End Class
