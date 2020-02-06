Imports MySql.Data.MySqlClient
Public Class BuscarReserva
    Dim cnn As MySqlConnection
    Dim das1 As DataSet
    Dim sql As String

    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"

    Private Sub BuscarReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16)
        Dim coon As New MySqlConnection(cadenaconexion)
        cnn = New MySqlConnection(cadenaconexion)
        sql = "SELECT * FROM reservas"

        Dim cmd As New MySqlCommand(sql, cnn)

        adap1 = New MySqlDataAdapter(cmd)
        das1 = New DataSet

        adap1.Fill(das1, "alojamiento")
        Me.Label2.Text = "Numero de filas: " & das1.Tables("alojamiento").Rows.Count
        Me.DataGridView1.DataSource = das1.Tables("alojamiento")
        DataGridView1.Columns(0).Width = 100
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 100
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100

        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()
    End Sub
End Class