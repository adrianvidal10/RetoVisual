Public Class Padre
    Public f1 As New Alta
    Dim f2 As New Baja
    Dim f3 As New Modificar
    Dim f4 As New Buscar
    Private Sub Padre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        ' tb está puesto en las propiedades, para que muestre la lista de formularios abiertos

        f1.MdiParent = Me
        f2.MdiParent = Me
        f3.MdiParent = Me
        f4.MdiParent = Me

        f1.WindowState = FormWindowState.Maximized
        f2.WindowState = FormWindowState.Maximized
        f3.WindowState = FormWindowState.Maximized
        f4.WindowState = FormWindowState.Maximized

        f1.Show()
        f1.Activate()
    End Sub
    Private Sub Padre_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            Me.F2Form2ToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            Me.F3Form3ToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            Me.F4Form4ToolStripMenuItem.PerformClick()
        ElseIf e.KeyCode = Keys.F1 Then
            f1.Show()
            f1.Activate()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.SalirToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub F2Form2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2Form2ToolStripMenuItem.Click
        f1.Show()
        f1.Activate()
    End Sub

    Private Sub F3Form3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F3Form3ToolStripMenuItem.Click
        f2.Show()
        f2.Activate()
    End Sub

    Private Sub F4Form4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F4Form4ToolStripMenuItem.Click
        f3.Show()
        f3.Activate()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        f4.Show()
        f4.Activate()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class