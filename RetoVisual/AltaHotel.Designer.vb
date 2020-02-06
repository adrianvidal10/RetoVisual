<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaHotel
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
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.txbLatitud = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txbLongitud = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txbId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbWeb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ErrorNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorUbicacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorCapacidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPrecio = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxNombre = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxUbicacion = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.tx_Capacidad = New System.Windows.Forms.TextBox()
        Me.tx_Categoria = New System.Windows.Forms.TextBox()
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorUbicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorCapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"alojamiento", "albergue", "camping"})
        Me.cmbtipo.Location = New System.Drawing.Point(434, 163)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(100, 21)
        Me.cmbtipo.TabIndex = 45
        '
        'btn
        '
        Me.btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn.Location = New System.Drawing.Point(317, 407)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(160, 37)
        Me.btn.TabIndex = 44
        Me.btn.Text = "Registrar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txbLatitud
        '
        Me.txbLatitud.Location = New System.Drawing.Point(543, 310)
        Me.txbLatitud.Name = "txbLatitud"
        Me.txbLatitud.Size = New System.Drawing.Size(100, 20)
        Me.txbLatitud.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(460, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Latitud :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(465, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Precio :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(476, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Web :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Categoria :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Capacidad :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(139, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Ubicacion :"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(153, 256)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(73, 20)
        Me.lblDni.TabIndex = 31
        Me.lblDni.Text = "Nombre :"
        '
        'txbLongitud
        '
        Me.txbLongitud.Location = New System.Drawing.Point(543, 348)
        Me.txbLongitud.Name = "txbLongitud"
        Me.txbLongitud.Size = New System.Drawing.Size(100, 20)
        Me.txbLongitud.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(447, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Longitud :"
        '
        'txbId
        '
        Me.txbId.Location = New System.Drawing.Point(244, 215)
        Me.txbId.Name = "txbId"
        Me.txbId.Size = New System.Drawing.Size(100, 20)
        Me.txbId.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(195, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 20)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Id :"
        '
        'txbWeb
        '
        Me.txbWeb.Location = New System.Drawing.Point(543, 227)
        Me.txbWeb.Name = "txbWeb"
        Me.txbWeb.Size = New System.Drawing.Size(100, 20)
        Me.txbWeb.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(240, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 20)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Tipo de establecimiento :"
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
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(197, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(435, 39)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "ALTA ESTABLECIMIENTO"
        '
        'MaskedTextBoxNombre
        '
        Me.MaskedTextBoxNombre.Location = New System.Drawing.Point(244, 256)
        Me.MaskedTextBoxNombre.Name = "MaskedTextBoxNombre"
        Me.MaskedTextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxNombre.TabIndex = 54
        '
        'MaskedTextBoxUbicacion
        '
        Me.MaskedTextBoxUbicacion.Location = New System.Drawing.Point(244, 286)
        Me.MaskedTextBoxUbicacion.Name = "MaskedTextBoxUbicacion"
        Me.MaskedTextBoxUbicacion.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxUbicacion.TabIndex = 55
        '
        'MaskedTextBoxPrecio
        '
        Me.MaskedTextBoxPrecio.Location = New System.Drawing.Point(543, 268)
        Me.MaskedTextBoxPrecio.Name = "MaskedTextBoxPrecio"
        Me.MaskedTextBoxPrecio.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxPrecio.TabIndex = 58
        '
        'tx_Capacidad
        '
        Me.tx_Capacidad.Location = New System.Drawing.Point(244, 320)
        Me.tx_Capacidad.MaxLength = 3
        Me.tx_Capacidad.Name = "tx_Capacidad"
        Me.tx_Capacidad.Size = New System.Drawing.Size(100, 20)
        Me.tx_Capacidad.TabIndex = 59
        '
        'tx_Categoria
        '
        Me.tx_Categoria.Location = New System.Drawing.Point(244, 347)
        Me.tx_Categoria.MaxLength = 3
        Me.tx_Categoria.Name = "tx_Categoria"
        Me.tx_Categoria.Size = New System.Drawing.Size(100, 20)
        Me.tx_Categoria.TabIndex = 60
        '
        'AltaHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(823, 541)
        Me.Controls.Add(Me.tx_Categoria)
        Me.Controls.Add(Me.tx_Capacidad)
        Me.Controls.Add(Me.MaskedTextBoxPrecio)
        Me.Controls.Add(Me.MaskedTextBoxUbicacion)
        Me.Controls.Add(Me.MaskedTextBoxNombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txbWeb)
        Me.Controls.Add(Me.txbId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txbLongitud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.txbLatitud)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDni)
        Me.Name = "AltaHotel"
        Me.Text = "AltaHotel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ErrorNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorUbicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorCapacidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents btn As Button
    Friend WithEvents txbLatitud As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txbLongitud As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txbId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txbWeb As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ErrorNombre As ErrorProvider
    Friend WithEvents ErrorUbicacion As ErrorProvider
    Friend WithEvents ErrorCapacidad As ErrorProvider
    Friend WithEvents ErrorPrecio As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents MaskedTextBoxUbicacion As MaskedTextBox
    Friend WithEvents MaskedTextBoxNombre As MaskedTextBox
    Friend WithEvents MaskedTextBoxPrecio As MaskedTextBox
    Friend WithEvents tx_Categoria As TextBox
    Friend WithEvents tx_Capacidad As TextBox
End Class
