<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarHotel
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbWeb = New System.Windows.Forms.TextBox()
        Me.txbLongitud = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbLatitud = New System.Windows.Forms.TextBox()
        Me.txbPrecio = New System.Windows.Forms.TextBox()
        Me.txbCategoria = New System.Windows.Forms.TextBox()
        Me.txbCapacidad = New System.Windows.Forms.TextBox()
        Me.txbUbicacion = New System.Windows.Forms.TextBox()
        Me.txbNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.ErrorNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorUbicacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorCapacidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPrecio = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(74, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1393, 333)
        Me.DataGridView1.TabIndex = 95
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(669, 639)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 44)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "Modificar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(494, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(253, 26)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Tipo de establecimiento :"
        '
        'cmbtipo
        '
        Me.cmbtipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"alojamiento", "albergue", "camping"})
        Me.cmbtipo.Location = New System.Drawing.Point(753, 70)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(202, 33)
        Me.cmbtipo.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 98
        '
        'txbWeb
        '
        Me.txbWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbWeb.Location = New System.Drawing.Point(904, 450)
        Me.txbWeb.Name = "txbWeb"
        Me.txbWeb.Size = New System.Drawing.Size(357, 32)
        Me.txbWeb.TabIndex = 115
        '
        'txbLongitud
        '
        Me.txbLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLongitud.Location = New System.Drawing.Point(904, 580)
        Me.txbLongitud.Name = "txbLongitud"
        Me.txbLongitud.Size = New System.Drawing.Size(357, 32)
        Me.txbLongitud.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(791, 583)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 26)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Longitud :"
        '
        'txbLatitud
        '
        Me.txbLatitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbLatitud.Location = New System.Drawing.Point(904, 534)
        Me.txbLatitud.Name = "txbLatitud"
        Me.txbLatitud.Size = New System.Drawing.Size(357, 32)
        Me.txbLatitud.TabIndex = 112
        '
        'txbPrecio
        '
        Me.txbPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbPrecio.Location = New System.Drawing.Point(904, 490)
        Me.txbPrecio.Name = "txbPrecio"
        Me.txbPrecio.Size = New System.Drawing.Size(357, 32)
        Me.txbPrecio.TabIndex = 111
        '
        'txbCategoria
        '
        Me.txbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCategoria.Location = New System.Drawing.Point(416, 577)
        Me.txbCategoria.Name = "txbCategoria"
        Me.txbCategoria.Size = New System.Drawing.Size(357, 32)
        Me.txbCategoria.TabIndex = 110
        '
        'txbCapacidad
        '
        Me.txbCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCapacidad.Location = New System.Drawing.Point(416, 531)
        Me.txbCapacidad.Name = "txbCapacidad"
        Me.txbCapacidad.Size = New System.Drawing.Size(358, 32)
        Me.txbCapacidad.TabIndex = 109
        '
        'txbUbicacion
        '
        Me.txbUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbUbicacion.Location = New System.Drawing.Point(416, 491)
        Me.txbUbicacion.Name = "txbUbicacion"
        Me.txbUbicacion.Size = New System.Drawing.Size(357, 32)
        Me.txbUbicacion.TabIndex = 108
        '
        'txbNombre
        '
        Me.txbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbNombre.Location = New System.Drawing.Point(416, 453)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(357, 32)
        Me.txbNombre.TabIndex = 107
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(802, 537)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 26)
        Me.Label7.TabIndex = 106
        Me.Label7.Text = "Latitud :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(805, 493)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 26)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Precio :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(822, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 26)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Web :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 577)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 26)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Categoria :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 534)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 26)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "Capacidad :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(290, 490)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 26)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Ubicacion :"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(308, 453)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(102, 26)
        Me.lblDni.TabIndex = 100
        Me.lblDni.Text = "Nombre :"
        '
        'ErrorNombre
        '
        Me.ErrorNombre.ContainerControl = Me
        '
        'ErrorUbicacion
        '
        Me.ErrorUbicacion.ContainerControl = Me
        '
        'ErrorCapacidad
        '
        Me.ErrorCapacidad.ContainerControl = Me
        '
        'ErrorPrecio
        '
        Me.ErrorPrecio.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(69, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 26)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Label8"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(466, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(542, 39)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "MODIFICAR ESTABLECIMIENTO"
        '
        'ModificarHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1401, 735)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txbWeb)
        Me.Controls.Add(Me.txbLongitud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbLatitud)
        Me.Controls.Add(Me.txbPrecio)
        Me.Controls.Add(Me.txbCategoria)
        Me.Controls.Add(Me.txbCapacidad)
        Me.Controls.Add(Me.txbUbicacion)
        Me.Controls.Add(Me.txbNombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblDni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ModificarHotel"
        Me.Text = "ModificarHotel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCapacidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbWeb As TextBox
    Friend WithEvents txbLongitud As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txbLatitud As TextBox
    Friend WithEvents txbPrecio As TextBox
    Friend WithEvents txbCategoria As TextBox
    Friend WithEvents txbCapacidad As TextBox
    Friend WithEvents txbUbicacion As TextBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents ErrorNombre As ErrorProvider
    Friend WithEvents ErrorUbicacion As ErrorProvider
    Friend WithEvents ErrorCapacidad As ErrorProvider
    Friend WithEvents ErrorPrecio As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
End Class
