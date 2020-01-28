﻿
Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim sql2 As String
    Dim das1 As DataSet
    Dim das2 As DataSet
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)

        Dim sql As String = "SELECT * FROM cliente"
        Dim cmd1 As New MySqlCommand(sql, coon)

        adap1 = New MySqlDataAdapter(cmd1)
        das1 = New DataSet

        adap1.Fill(das1, "cliente")
        Me.Label2.Text = "Numero de filas: " & das1.Tables("cliente").Rows.Count
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

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cnn = New MySqlConnection(cadenaconexion)
        sql = "SELECT * FROM cliente WHERE Nombre like '" & txbBuscar.Text & "%'"
        Dim cmd As New MySqlCommand(sql, cnn)

        Try
            cnn.Open()
            Dim resultado As MySqlDataReader
            resultado = cmd.ExecuteReader
            Me.Label2.Text = "Numero de filas: " & das1.Tables("cliente").Rows.Count
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
        DataGridView2.Visible = True
        cnn = New MySqlConnection(cadenaconexion)
        Dim eleccion As String = Nothing
        If cmbtipo.Text = "alojamiento" Then
            eleccion = "reserva_alo"
        ElseIf cmbtipo.Text = "albergue" Then
            eleccion = "reserva_alb"
        ElseIf cmbtipo.Text = "camping" Then
            eleccion = "reserva_camp"
        End If
        sql2 = "SELECT * FROM " & eleccion & " WHERE Fk_IdCliente = " & Me.DataGridView1.CurrentRow.Cells.Item(0).Value & ""
        MsgBox(sql2)
        Dim cmd1 As New MySqlCommand(sql2, cnn)
        das2 = New DataSet

        Try
            cnn.Open()
            Dim resultado As MySqlDataReader
            resultado = cmd1.ExecuteReader

            adap1.Fill(das2, "reserva")
            Me.DataGridView2.DataSource = das2.Tables("reserva")
            DataGridView2.Columns(0).Width = 60
            DataGridView2.Columns(1).Width = 60
            DataGridView2.Columns(2).Width = 60
            DataGridView2.Columns(3).Width = 60
            DataGridView2.Columns(4).Width = 60
            DataGridView2.Columns(5).Width = 60
            DataGridView2.Columns(6).Width = 60
            DataGridView2.Columns(7).Width = 100


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub
End Class