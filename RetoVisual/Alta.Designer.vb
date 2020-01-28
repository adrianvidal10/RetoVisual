<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
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
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxNombre = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxApellido = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxEdad = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxGmail = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(328, 303)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(130, 30)
        Me.btn.TabIndex = 29
        Me.btn.Text = "Registrar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(454, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "G-mail :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(438, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Telefono :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(112, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Sexo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Edad :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Apellido :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Nombre :"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(122, 113)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(45, 20)
        Me.lblDni.TabIndex = 15
        Me.lblDni.Text = "Dni : "
        '
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexo.Location = New System.Drawing.Point(192, 245)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.cmbSexo.TabIndex = 30
        '
        'txtConfirmarContrasena
        '
        Me.txtConfirmarContrasena.Location = New System.Drawing.Point(553, 238)
        Me.txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        Me.txtConfirmarContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmarContrasena.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Confirmar Contraseña:"
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(553, 198)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(418, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
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
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(192, 113)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox1.TabIndex = 35
        '
        'MaskedTextBoxNombre
        '
        Me.MaskedTextBoxNombre.Location = New System.Drawing.Point(192, 147)
        Me.MaskedTextBoxNombre.Name = "MaskedTextBoxNombre"
        Me.MaskedTextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxNombre.TabIndex = 36
        '
        'MaskedTextBoxApellido
        '
        Me.MaskedTextBoxApellido.Location = New System.Drawing.Point(192, 182)
        Me.MaskedTextBoxApellido.Name = "MaskedTextBoxApellido"
        Me.MaskedTextBoxApellido.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxApellido.TabIndex = 37
        '
        'MaskedTextBoxEdad
        '
        Me.MaskedTextBoxEdad.Location = New System.Drawing.Point(192, 215)
        Me.MaskedTextBoxEdad.Name = "MaskedTextBoxEdad"
        Me.MaskedTextBoxEdad.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxEdad.TabIndex = 38
        '
        'MaskedTextBoxTelefono
        '
        Me.MaskedTextBoxTelefono.Location = New System.Drawing.Point(553, 122)
        Me.MaskedTextBoxTelefono.Name = "MaskedTextBoxTelefono"
        Me.MaskedTextBoxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxTelefono.TabIndex = 39
        '
        'MaskedTextBoxGmail
        '
        Me.MaskedTextBoxGmail.Location = New System.Drawing.Point(553, 164)
        Me.MaskedTextBoxGmail.Name = "MaskedTextBoxGmail"
        Me.MaskedTextBoxGmail.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxGmail.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(259, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(258, 39)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "ALTA CLIENTE"
        '
        'Alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MaskedTextBoxGmail)
        Me.Controls.Add(Me.MaskedTextBoxTelefono)
        Me.Controls.Add(Me.MaskedTextBoxEdad)
        Me.Controls.Add(Me.MaskedTextBoxApellido)
        Me.Controls.Add(Me.MaskedTextBoxNombre)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtConfirmarContrasena)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.btn)
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDni As Label
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
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBoxApellido As MaskedTextBox
    Friend WithEvents MaskedTextBoxNombre As MaskedTextBox
    Friend WithEvents MaskedTextBoxEdad As MaskedTextBox
    Friend WithEvents MaskedTextBoxTelefono As MaskedTextBox
    Friend WithEvents MaskedTextBoxGmail As MaskedTextBox
    Friend WithEvents Label9 As Label
End Class
