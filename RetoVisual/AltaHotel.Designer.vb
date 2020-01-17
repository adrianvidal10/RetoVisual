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
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.btn = New System.Windows.Forms.Button()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txbLongitud = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txbId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txbWeb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbtipo
        '
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Items.AddRange(New Object() {"alojamiento", "albergue", "camping"})
        Me.cmbtipo.Location = New System.Drawing.Point(389, 60)
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(100, 21)
        Me.cmbtipo.TabIndex = 45
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(389, 422)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 44
        Me.btn.Text = "Registrar"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txbLatitud
        '
        Me.txbLatitud.Location = New System.Drawing.Point(389, 345)
        Me.txbLatitud.Name = "txbLatitud"
        Me.txbLatitud.Size = New System.Drawing.Size(100, 20)
        Me.txbLatitud.TabIndex = 43
        '
        'txbPrecio
        '
        Me.txbPrecio.Location = New System.Drawing.Point(389, 310)
        Me.txbPrecio.Name = "txbPrecio"
        Me.txbPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txbPrecio.TabIndex = 42
        '
        'txbCategoria
        '
        Me.txbCategoria.Location = New System.Drawing.Point(389, 237)
        Me.txbCategoria.Name = "txbCategoria"
        Me.txbCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txbCategoria.TabIndex = 41
        '
        'txbCapacidad
        '
        Me.txbCapacidad.Location = New System.Drawing.Point(389, 207)
        Me.txbCapacidad.Name = "txbCapacidad"
        Me.txbCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txbCapacidad.TabIndex = 40
        '
        'txbUbicacion
        '
        Me.txbUbicacion.Location = New System.Drawing.Point(389, 175)
        Me.txbUbicacion.Name = "txbUbicacion"
        Me.txbUbicacion.Size = New System.Drawing.Size(100, 20)
        Me.txbUbicacion.TabIndex = 39
        '
        'txbNombre
        '
        Me.txbNombre.Location = New System.Drawing.Point(389, 141)
        Me.txbNombre.Name = "txbNombre"
        Me.txbNombre.Size = New System.Drawing.Size(100, 20)
        Me.txbNombre.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(311, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Latitud :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(311, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Precio :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(311, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Web :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(311, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Categoria :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Capacidad :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(311, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Ubicacion :"
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(311, 141)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(50, 13)
        Me.lblDni.TabIndex = 31
        Me.lblDni.Text = "Nombre :"
        '
        'txbLongitud
        '
        Me.txbLongitud.Location = New System.Drawing.Point(389, 385)
        Me.txbLongitud.Name = "txbLongitud"
        Me.txbLongitud.Size = New System.Drawing.Size(100, 20)
        Me.txbLongitud.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Longitud :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(582, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Label8"
        '
        'txbId
        '
        Me.txbId.Location = New System.Drawing.Point(389, 102)
        Me.txbId.Name = "txbId"
        Me.txbId.Size = New System.Drawing.Size(100, 20)
        Me.txbId.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Id :"
        '
        'txbWeb
        '
        Me.txbWeb.Location = New System.Drawing.Point(389, 272)
        Me.txbWeb.Name = "txbWeb"
        Me.txbWeb.Size = New System.Drawing.Size(100, 20)
        Me.txbWeb.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(258, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Tipo de establecimiento :"
        '
        'AltaHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 541)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txbWeb)
        Me.Controls.Add(Me.txbId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txbLongitud)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbtipo)
        Me.Controls.Add(Me.btn)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDni)
        Me.Name = "AltaHotel"
        Me.Text = "AltaHotel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbtipo As ComboBox
    Friend WithEvents btn As Button
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
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDni As Label
    Friend WithEvents txbLongitud As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txbId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txbWeb As TextBox
    Friend WithEvents Label10 As Label
End Class
