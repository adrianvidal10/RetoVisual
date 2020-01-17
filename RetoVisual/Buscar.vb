
Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sql = "SELECT * FROM cliente WHERE Nombre like '" & txbBuscar.Text & "%'"
        Dim cmd As New MySqlCommand(sql, cnn)

        Try
            cnn.Open()
            Dim resultado As MySqlDataReader
            resultado = cmd.ExecuteReader
            Me.ListView1.Clear()
            ListView1.GridLines = True
            ListView1.View = View.Details
            ListView1.Columns.Add(resultado.GetName(0), 90, HorizontalAlignment.Left)
            ListView1.Columns.Add(resultado.GetName(1), 90, HorizontalAlignment.Left)
            ListView1.Columns.Add(resultado.GetName(2), 90, HorizontalAlignment.Left)
            ListView1.Columns.Add(resultado.GetName(3), 90, HorizontalAlignment.Left)
            ListView1.Columns.Add(resultado.GetName(4), 50, HorizontalAlignment.Left)
            ListView1.Columns.Add(resultado.GetName(5), 50, HorizontalAlignment.Left)
            ListView1.Columns.Add(resultado.GetName(6), 90, HorizontalAlignment.Left)
            ListView1.Columns.Add(resultado.GetName(7), 400, HorizontalAlignment.Left)
            Dim x As Integer
            While resultado.Read
                ListView1.Items.Add(resultado.Item(0))
                ListView1.Items(x).SubItems.Add(resultado.Item(1))
                ListView1.Items(x).SubItems.Add(resultado.Item(2))
                ListView1.Items(x).SubItems.Add(resultado.Item(3))
                ListView1.Items(x).SubItems.Add(resultado.Item(4))
                ListView1.Items(x).SubItems.Add(resultado.Item(5))
                ListView1.Items(x).SubItems.Add(resultado.Item(6))
                ListView1.Items(x).SubItems.Add(resultado.Item(7))
                x += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try


    End Sub
End Class