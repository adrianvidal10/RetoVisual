Imports MySql.Data.MySqlClient
Public Class BuscarHotel
    Dim cnn As MySqlConnection
    Dim das1 As DataSet
    Dim datos As String
    Dim sql As String
    Dim tipo As String
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"

    Private Sub BuscarHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cnn = New MySqlConnection(cadenaconexion)

        tipo = cmbtipo.Text

        If txbBuscar.Text = Nothing Then
            sql = "SELECT * FROM " & tipo & " ORDER BY Nombre"
        Else
            sql = "SELECT * FROM " & tipo & " WHERE Nombre like '" & txbBuscar.Text & "%' ORDER BY Nombre"
            MsgBox(sql)
        End If

        Dim cmd As New MySqlCommand(sql, cnn)


        adap1 = New MySqlDataAdapter(cmd)
        das1 = New DataSet

        adap1.Fill(das1, "alojamiento")
        Me.Label2.Text = "Numero de filas: " & das1.Tables("alojamiento").Rows.Count
        Me.DataGridView1.DataSource = das1.Tables("alojamiento")
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 60
        DataGridView1.Columns(2).Width = 60
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 60
        DataGridView1.Columns(5).Width = 60
        DataGridView1.Columns(6).Width = 60
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cnn = New MySqlConnection(cadenaconexion)
        sql = "SELECT * FROM reserva WHERE Fk_IdEsta like " & Me.DataGridView1.CurrentRow.Cells.Item(0).Value & ""

    End Sub
End Class