Imports MySql.Data.MySqlClient
Public Class Baja
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim das1 As DataSet
    Dim resultado As Integer
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Baja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        'Try
        '    coon.Open()

        'Catch ex As Exception
        '    MsgBox("Fallo en la conexión")
        'End Try
        'coon.Close()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        cnn = New MySqlConnection(cadenaconexion)
        sql = "DELETE * FROM cliente WHERE Dni like "
    End Sub



    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cnn = New MySqlConnection(cadenaconexion)
        sql = "SELECT * FROM cliente WHERE Nombre like '" & txbBuscar.Text & "%'"
        Dim cmd As New MySqlCommand(sql, cnn)

        Try
            cnn.Open()
            Dim resultado As MySqlDataReader
            resultado = cmd.ExecuteReader
            Me.DataGridView1.DataSource = das1.Tables("cliente")
            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(1).Width = 60
            DataGridView1.Columns(2).Width = 60
            DataGridView1.Columns(3).Width = 60
            DataGridView1.Columns(4).Width = 60
            DataGridView1.Columns(5).Width = 60
            DataGridView1.Columns(6).Width = 60
            DataGridView1.Columns(7).Width = 100


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim response As String
        cnn = New MySqlConnection(cadenaconexion)
        response = MsgBox("Desea eliminar a este usuario? ", vbYesNoCancel + vbCritical, "Eliminar usuario")
        If response = vbYes Then

            sql = "DELETE FROM cliente WHERE Dni = '" & Me.DataGridView1.CurrentRow.Cells.Item(1).Value & "'"
            Dim cmd As New MySqlCommand(sql, cnn)
            Try
                cnn.Open()
                resultado = cmd.ExecuteNonQuery
                MsgBox("Usuario eliminado")
                Dim sql As String = "SELECT * FROM cliente"
                Dim cmd1 As New MySqlCommand(sql, cnn)

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