Imports MySql.Data.MySqlClient
Public Class ModificarHotel
    Dim cnn As MySqlConnection
    Dim das1 As DataSet
    Dim resultado As Integer
    Dim sql As String
    Dim tipo As String
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"

    Private Sub ModificarHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()
    End Sub
    Private Sub Cmbtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtipo.SelectedIndexChanged
        cnn = New MySqlConnection(cadenaconexion)
        tipo = cmbtipo.Text
        sql = "SELECT * from " & tipo & " ORDER BY Nombre"

        Dim cmd As New MySqlCommand(sql, cnn)


        adap1 = New MySqlDataAdapter(cmd)
        das1 = New DataSet

        adap1.Fill(das1, "alojamiento")
        Me.Label8.Text = "Numero de filas: " & das1.Tables("alojamiento").Rows.Count
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
        cnn.Open()
        txbNombre.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
        txbUbicacion.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
        txbCapacidad.Text = DataGridView1.CurrentRow.Cells.Item(3).Value
        txbCategoria.Text = DataGridView1.CurrentRow.Cells.Item(4).Value
        txbWeb.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
        txbPrecio.Text = DataGridView1.CurrentRow.Cells.Item(6).Value
        txbLatitud.Text = DataGridView1.CurrentRow.Cells.Item(7).Value
        txbLongitud.Text = DataGridView1.CurrentRow.Cells.Item(8).Value
        Dim cmd As New MySqlCommand(sql, cnn)

        cnn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnn = New MySqlConnection(cadenaconexion)


        sql = "UPDATE " & tipo & " SET Nombre=@nombre, Ubicacion=@ubicacion, Capacidad=@capacidad, Categoria=@categoria, Web=@web, Precio=@precio,Latitud=@latitud,Longitud=@longitud WHERE Nombre like '" & Me.DataGridView1.CurrentRow.Cells.Item(1).Value & "'"
        MsgBox(sql)
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@nombre", Me.txbNombre.Text)
        cmd.Parameters.AddWithValue("@ubicacion", Me.txbUbicacion.Text)
        cmd.Parameters.AddWithValue("@capacidad", Me.txbCapacidad.Text)
        cmd.Parameters.AddWithValue("@categoria", Me.txbCategoria.Text)
        cmd.Parameters.AddWithValue("@web", Me.txbWeb.Text)
        cmd.Parameters.AddWithValue("@precio", Me.txbPrecio.Text)
        cmd.Parameters.AddWithValue("@latitud", Me.txbLatitud.Text)
        cmd.Parameters.AddWithValue("@longitud", Me.txbLongitud.Text)
        Try
            cnn.Open()
            resultado = cmd.ExecuteNonQuery()
            MsgBox("Actualizadas: " & resultado & "filas")
            Fondo.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub
End Class