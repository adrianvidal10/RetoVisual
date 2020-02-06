<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Padre
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.F2Form2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaEstablecimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F3Form3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaEstablecimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F4Form4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarEstablecimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarEstablecimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarReservaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F2Form2ToolStripMenuItem, Me.F3Form3ToolStripMenuItem, Me.F4Form4ToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 38)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'F2Form2ToolStripMenuItem
        '
        Me.F2Form2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltaClienteToolStripMenuItem, Me.AltaEstablecimientoToolStripMenuItem})
        Me.F2Form2ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.F2Form2ToolStripMenuItem.Name = "F2Form2ToolStripMenuItem"
        Me.F2Form2ToolStripMenuItem.Size = New System.Drawing.Size(62, 34)
        Me.F2Form2ToolStripMenuItem.Text = "Alta"
        '
        'AltaClienteToolStripMenuItem
        '
        Me.AltaClienteToolStripMenuItem.Name = "AltaClienteToolStripMenuItem"
        Me.AltaClienteToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.AltaClienteToolStripMenuItem.Text = "Alta Cliente"
        '
        'AltaEstablecimientoToolStripMenuItem
        '
        Me.AltaEstablecimientoToolStripMenuItem.Name = "AltaEstablecimientoToolStripMenuItem"
        Me.AltaEstablecimientoToolStripMenuItem.Size = New System.Drawing.Size(280, 34)
        Me.AltaEstablecimientoToolStripMenuItem.Text = "Alta Establecimiento"
        '
        'F3Form3ToolStripMenuItem
        '
        Me.F3Form3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaClienteToolStripMenuItem, Me.BajaEstablecimientoToolStripMenuItem, Me.BajaReservaToolStripMenuItem})
        Me.F3Form3ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.F3Form3ToolStripMenuItem.Name = "F3Form3ToolStripMenuItem"
        Me.F3Form3ToolStripMenuItem.Size = New System.Drawing.Size(65, 34)
        Me.F3Form3ToolStripMenuItem.Text = "Baja"
        '
        'BajaClienteToolStripMenuItem
        '
        Me.BajaClienteToolStripMenuItem.Name = "BajaClienteToolStripMenuItem"
        Me.BajaClienteToolStripMenuItem.Size = New System.Drawing.Size(283, 34)
        Me.BajaClienteToolStripMenuItem.Text = "Baja Cliente"
        '
        'BajaEstablecimientoToolStripMenuItem
        '
        Me.BajaEstablecimientoToolStripMenuItem.Name = "BajaEstablecimientoToolStripMenuItem"
        Me.BajaEstablecimientoToolStripMenuItem.Size = New System.Drawing.Size(283, 34)
        Me.BajaEstablecimientoToolStripMenuItem.Text = "Baja Establecimiento"
        '
        'BajaReservaToolStripMenuItem
        '
        Me.BajaReservaToolStripMenuItem.Name = "BajaReservaToolStripMenuItem"
        Me.BajaReservaToolStripMenuItem.Size = New System.Drawing.Size(283, 34)
        Me.BajaReservaToolStripMenuItem.Text = "Baja Reserva"
        '
        'F4Form4ToolStripMenuItem
        '
        Me.F4Form4ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarClienteToolStripMenuItem, Me.ModificarEstablecimientoToolStripMenuItem})
        Me.F4Form4ToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.F4Form4ToolStripMenuItem.Name = "F4Form4ToolStripMenuItem"
        Me.F4Form4ToolStripMenuItem.Size = New System.Drawing.Size(117, 34)
        Me.F4Form4ToolStripMenuItem.Text = "Modificar"
        Me.F4Form4ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ModificarClienteToolStripMenuItem
        '
        Me.ModificarClienteToolStripMenuItem.Name = "ModificarClienteToolStripMenuItem"
        Me.ModificarClienteToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ModificarClienteToolStripMenuItem.Text = "Modificar Cliente"
        '
        'ModificarEstablecimientoToolStripMenuItem
        '
        Me.ModificarEstablecimientoToolStripMenuItem.Name = "ModificarEstablecimientoToolStripMenuItem"
        Me.ModificarEstablecimientoToolStripMenuItem.Size = New System.Drawing.Size(335, 34)
        Me.ModificarEstablecimientoToolStripMenuItem.Text = "Modificar Establecimiento"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarClienteToolStripMenuItem, Me.BuscarEstablecimientoToolStripMenuItem, Me.BuscarReservaToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(88, 34)
        Me.ToolStripMenuItem1.Text = "Buscar"
        '
        'BuscarClienteToolStripMenuItem
        '
        Me.BuscarClienteToolStripMenuItem.Name = "BuscarClienteToolStripMenuItem"
        Me.BuscarClienteToolStripMenuItem.Size = New System.Drawing.Size(306, 34)
        Me.BuscarClienteToolStripMenuItem.Text = "Buscar Cliente"
        '
        'BuscarEstablecimientoToolStripMenuItem
        '
        Me.BuscarEstablecimientoToolStripMenuItem.Name = "BuscarEstablecimientoToolStripMenuItem"
        Me.BuscarEstablecimientoToolStripMenuItem.Size = New System.Drawing.Size(306, 34)
        Me.BuscarEstablecimientoToolStripMenuItem.Text = "Buscar Establecimiento"
        '
        'BuscarReservaToolStripMenuItem
        '
        Me.BuscarReservaToolStripMenuItem.Name = "BuscarReservaToolStripMenuItem"
        Me.BuscarReservaToolStripMenuItem.Size = New System.Drawing.Size(306, 34)
        Me.BuscarReservaToolStripMenuItem.Text = "Buscar Reserva"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(66, 34)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Padre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Padre"
        Me.Text = "Padre"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents F2Form2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F3Form3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F4Form4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaEstablecimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaEstablecimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaReservaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarEstablecimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarEstablecimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarReservaToolStripMenuItem As ToolStripMenuItem
End Class
