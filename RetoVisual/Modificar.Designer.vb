<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ErrorDni = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorApellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorEdad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Errortlf = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorGmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorSexo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBoxEdad = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorDni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEdad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errortlf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorGmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSexo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 44)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(302, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "G-mail :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(409, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Telefono :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Sexo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(409, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Edad :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Apellido :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(198, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nombre :"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(198, 315)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(32, 13)
        Me.lblDni.TabIndex = 64
        Me.lblDni.Text = "Dni : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, -34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Buscar: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(279, -37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(143, 20)
        Me.TextBox1.TabIndex = 61
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(151, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(504, 221)
        Me.DataGridView1.TabIndex = 79
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
        'cmbSexo
        '
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"M", "F"})
        Me.cmbSexo.Location = New System.Drawing.Point(487, 354)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.cmbSexo.TabIndex = 80
        '
        'MaskedTextBoxEdad
        '
        Me.MaskedTextBoxEdad.Location = New System.Drawing.Point(487, 315)
        Me.MaskedTextBoxEdad.Name = "MaskedTextBoxEdad"
        Me.MaskedTextBoxEdad.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxEdad.TabIndex = 84
        '
        'MaskedTextBoxTelefono
        '
        Me.MaskedTextBoxTelefono.Location = New System.Drawing.Point(487, 388)
        Me.MaskedTextBoxTelefono.Name = "MaskedTextBoxTelefono"
        Me.MaskedTextBoxTelefono.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxTelefono.TabIndex = 85
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(254, 307)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 87
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(255, 344)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 88
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(255, 384)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 89
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(351, 437)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(148, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Label8"
        '
        'Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 556)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MaskedTextBoxTelefono)
        Me.Controls.Add(Me.MaskedTextBoxEdad)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Modificar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ErrorDni As ErrorProvider
    Friend WithEvents ErrorNombre As ErrorProvider
    Friend WithEvents ErrorApellido As ErrorProvider
    Friend WithEvents ErrorEdad As ErrorProvider
    Friend WithEvents Errortlf As ErrorProvider
    Friend WithEvents ErrorGmail As ErrorProvider
    Friend WithEvents ErrorSexo As ErrorProvider
    Friend WithEvents cmbSexo As ComboBox
    Friend WithEvents MaskedTextBoxEdad As MaskedTextBox
    Friend WithEvents MaskedTextBoxTelefono As MaskedTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
End Class
