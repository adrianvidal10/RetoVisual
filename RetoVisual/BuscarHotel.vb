Imports MySql.Data.MySqlClient
Public Class BuscarHotel
    Dim cnn As MySqlConnection
    Dim das1 As DataSet
    Dim datos As String
    Dim sql As String
    Dim tipo As String
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Dim dialog As New Form With {
          .FormBorderStyle = FormBorderStyle.None,
          .BackColor = Color.White,
          .Size = New Size(800, 800)
          }
    Dim texto As New ListView() With {
            .Name = "ListView1",
            .Size = New Size(500, 500)
        }

    Dim cancelar As New Button() With {
            .Text = "Atras",
            .Location = New Point(250, 600),
            .Size = New Size(100, 100)
            }

    Private Sub BuscarHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        cmbtipo.SelectedIndex = 1
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
    Sub cerrar()
        dialog.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim extension
        If cmbtipo.Text = "alojamiento" Then
            extension = "_alo"
        ElseIf cmbtipo.Text = "albergue" Then
            extension = "_alb"
        ElseIf cmbtipo.Text = "camping" Then
            extension = "_camping"
        End If

        cnn = New MySqlConnection(cadenaconexion)
        sql = "SELECT * FROM reserva" & extension & " WHERE Fk_IdEsta like '" & Me.DataGridView1.CurrentRow.Cells.Item(0).Value & "'"
        MsgBox(sql)
        Dim cmd As New MySqlCommand(sql, cnn)



        AddHandler cancelar.Click, AddressOf cerrar

        Try
            cnn.Open()
            Dim resultado As MySqlDataReader
            resultado = cmd.ExecuteReader
            texto.Clear()
            texto.GridLines = True
            texto.View = View.Details
            texto.Columns.Add(resultado.GetName(0), 90, HorizontalAlignment.Left)
            texto.Columns.Add(resultado.GetName(1), 90, HorizontalAlignment.Left)
            texto.Columns.Add(resultado.GetName(2), 90, HorizontalAlignment.Left)
            texto.Columns.Add(resultado.GetName(3), 90, HorizontalAlignment.Left)
            texto.Columns.Add(resultado.GetName(4), 90, HorizontalAlignment.Left)
            texto.Columns.Add(resultado.GetName(5), 90, HorizontalAlignment.Left)
            texto.Columns.Add(resultado.GetName(6), 90, HorizontalAlignment.Left)
            texto.Columns.Add(resultado.GetName(7), 90, HorizontalAlignment.Left)
            Dim x As Integer
            While resultado.Read
                texto.Items.Add(resultado.Item(0))
                texto.Items(x).SubItems.Add(resultado.Item(1))
                texto.Items(x).SubItems.Add(resultado.Item(2))
                texto.Items(x).SubItems.Add(resultado.Item(3))
                texto.Items(x).SubItems.Add(resultado.Item(4))
                texto.Items(x).SubItems.Add(resultado.Item(5))
                texto.Items(x).SubItems.Add(resultado.Item(6))
                texto.Items(x).SubItems.Add(resultado.Item(7))
                x += 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
        dialog.Controls.Add(texto)
        dialog.Controls.Add(cancelar)
        dialog.ShowDialog()
    End Sub
End Class