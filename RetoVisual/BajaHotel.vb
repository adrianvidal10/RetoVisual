Imports MySql.Data.MySqlClient
Public Class BajaHotel

    Dim cnn As MySqlConnection
    Dim das1 As DataSet
    Dim resultado As Integer
    Dim sql As String
    Dim adap1 As MySqlDataAdapter

    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        cnn = New MySqlConnection(cadenaconexion)
        Dim tipo As String
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
        Dim response As String
        cnn = New MySqlConnection(cadenaconexion)
        response = MsgBox("Desea eliminar a este establecimiento? ", vbYesNoCancel + vbCritical, "Eliminar establecimiento")
        If response = vbYes Then
            Dim tipo As String
            tipo = cmbtipo.Text
            sql = "DELETE FROM " & tipo & " WHERE Nombre like '" & Me.DataGridView1.CurrentRow.Cells.Item(1).Value & "'"
            Dim cmd As New MySqlCommand(sql, cnn)
            Try
                cnn.Open()
                resultado = cmd.ExecuteNonQuery
                MsgBox("Establecimiento eliminado")
                Dim sql As String = "SELECT * FROM " & tipo & ""
                Dim cmd1 As New MySqlCommand(sql, cnn)

                adap1 = New MySqlDataAdapter(cmd1)
                das1 = New DataSet

                adap1.Fill(das1, "establecimiento")
                Me.DataGridView1.DataSource = das1.Tables("establecimiento")
                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 100
                DataGridView1.Columns(2).Width = 60
                DataGridView1.Columns(3).Width = 60
                DataGridView1.Columns(4).Width = 60
                DataGridView1.Columns(5).Width = 60
                DataGridView1.Columns(6).Width = 100
                DataGridView1.Columns(7).Width = 200
                DataGridView1.Columns(8).Width = 200
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        End If
    End Sub
End Class