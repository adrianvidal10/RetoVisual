Public Class Padre
    Public f1 As New Alta
    Dim f2 As New Baja
    Dim f3 As New Modificar
    Dim f4 As New Buscar
    Dim f5 As New AltaHotel
    Dim f6 As New BajaHotel
    Dim f7 As New BajaReserva
    Dim f8 As New ModificarHotel
    Dim f9 As New BuscarHotel
    Dim f10 As New BuscarReserva


    Private Sub Padre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        ' tb está puesto en las propiedades, para que muestre la lista de formularios abiertos

        f1.MdiParent = Me
        f2.MdiParent = Me
        f3.MdiParent = Me
        f4.MdiParent = Me
        f5.MdiParent = Me
        f6.MdiParent = Me
        f7.MdiParent = Me
        f8.MdiParent = Me
        f9.MdiParent = Me
        f10.MdiParent = Me


        f1.WindowState = FormWindowState.Maximized
        f2.WindowState = FormWindowState.Maximized
        f3.WindowState = FormWindowState.Maximized
        f4.WindowState = FormWindowState.Maximized
        f5.WindowState = FormWindowState.Maximized
        f6.WindowState = FormWindowState.Maximized
        f7.WindowState = FormWindowState.Maximized
        f8.WindowState = FormWindowState.Maximized
        f9.WindowState = FormWindowState.Maximized
        f10.WindowState = FormWindowState.Maximized


        f1.Show()
        f1.Activate()
    End Sub
    Private Sub Padre_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.AltaClienteToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.BajaClienteToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            Me.ModificarClienteToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F5 Then
            Me.AltaEstablecimientoToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F6 Then
            Me.BajaEstablecimientoToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F7 Then
            Me.BajaReservaToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F8 Then
            Me.BajaReservaToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F9 Then
            Me.BajaReservaToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F10 Then
            Me.BajaReservaToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F1 Then
            f1.Show()
            f1.Activate()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.SalirToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub AltaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaClienteToolStripMenuItem.Click
        f1.Show()
        f1.Activate()
    End Sub

    Private Sub BajaClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaClienteToolStripMenuItem.Click
        f2.Show()
        f2.Activate()
    End Sub

    Private Sub ModificarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarClienteToolStripMenuItem.Click
        f3.Show()
        f3.Activate()
    End Sub
    Private Sub BuscarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarClienteToolStripMenuItem.Click
        f4.Show()
        f4.Activate()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AltaEstablecimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaEstablecimientoToolStripMenuItem.Click
        f5.Show()
        f5.Activate()
    End Sub

    Private Sub BajaEstablecimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaEstablecimientoToolStripMenuItem.Click
        f6.Show()
        f6.Activate()
    End Sub

    Private Sub BajaReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaReservaToolStripMenuItem.Click
        f7.Show()
        f7.Activate()
    End Sub

    Private Sub ModificarEstablecimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarEstablecimientoToolStripMenuItem.Click
        f8.Show()
        f8.Activate()
    End Sub

    Private Sub BuscarEstablecimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarEstablecimientoToolStripMenuItem.Click
        f9.Show()
        f9.Activate()
    End Sub

    Private Sub BuscarReservaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarReservaToolStripMenuItem.Click
        f10.Show()
        f10.Activate()
    End Sub
End Class