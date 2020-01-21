Imports MySql.Data.MySqlClient
Public Class Modificar
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim das1 As DataSet
    Dim resultado As Integer
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        Dim sql As String = "SELECT * FROM cliente"
        Dim cmd1 As New MySqlCommand(sql, coon)

        adap1 = New MySqlDataAdapter(cmd1)
        das1 = New DataSet

        adap1.Fill(das1, "cliente")
        Me.DataGridView1.DataSource = das1.Tables("cliente")
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 60
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 60
        DataGridView1.Columns(5).Width = 60
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 200
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnn = New MySqlConnection(cadenaconexion)


        sql = "UPDATE cliente SET Dni=@dni, Nombre=@nombre, Apellido=@apellido, Edad=@edad, Sexo=@sexo, Telefono=@telefono,Gmail=@gmail WHERE Dni = '" & Me.DataGridView1.CurrentRow.Cells.Item(1).Value & "'"
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@dni", Me.txbDni.Text)
        cmd.Parameters.AddWithValue("@nombre", Me.txbNombre.Text)
        cmd.Parameters.AddWithValue("@apellido", Me.txbApellido.Text)
        cmd.Parameters.AddWithValue("@edad", Me.txbEdad.Text)
        cmd.Parameters.AddWithValue("@sexo", Me.txbSexo.Text)
        cmd.Parameters.AddWithValue("@telefono", Me.txbTelefono.Text)
        cmd.Parameters.AddWithValue("@gmail", Me.txbGmail.Text)

        Try
            cnn.Open()
            resultado = cmd.ExecuteNonQuery()
            MsgBox("Actualizadas: " & resultado & "filas")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.close()
            End If
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cnn = New MySqlConnection(cadenaconexion)
        cnn.Open()
        txbDni.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
        txbNombre.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
        txbApellido.Text = DataGridView1.CurrentRow.Cells.Item(3).Value
        txbEdad.Text = DataGridView1.CurrentRow.Cells.Item(4).Value
        txbSexo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
        txbTelefono.Text = DataGridView1.CurrentRow.Cells.Item(6).Value
        txbGmail.Text = DataGridView1.CurrentRow.Cells.Item(7).Value

        Dim cmd As New MySqlCommand(sql, cnn)

        cnn.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class