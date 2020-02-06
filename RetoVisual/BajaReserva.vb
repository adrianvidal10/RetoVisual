﻿Imports MySql.Data.MySqlClient
Public Class BajaReserva
    Dim cnn As MySqlConnection
    Dim das1 As DataSet
    Dim sql As String = "select * from reservas"
    Dim tipo As String
    Dim resultado As Integer
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub BajaReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16)
        cnn = New MySqlConnection(cadenaconexion)

        Dim cmd As New MySqlCommand(sql, cnn)


        adap1 = New MySqlDataAdapter(cmd)
        das1 = New DataSet

        adap1.Fill(das1, "alojamiento")
        Me.Label2.Text = "Numero de filas: " & das1.Tables("alojamiento").Rows.Count
        Me.DataGridView1.DataSource = das1.Tables("alojamiento")
        DataGridView1.Columns(0).Width = 60
        DataGridView1.Columns(1).Width = 120
        DataGridView1.Columns(2).Width = 110
        DataGridView1.Columns(3).Width = 60
        DataGridView1.Columns(4).Width = 60
        DataGridView1.Columns(5).Width = 120
        DataGridView1.Columns(6).Width = 60
        DataGridView1.Columns(7).Width = 100
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim response As String
        cnn = New MySqlConnection(cadenaconexion)
        response = MsgBox("Desea eliminar esta reserva? ", vbYesNoCancel + vbCritical, "Eliminar reserva")
        If response = vbYes Then
            Dim cmd As New MySqlCommand(sql, cnn)
            Try
                cnn.Open()
                resultado = cmd.ExecuteNonQuery
                MsgBox("Reserva eliminada")
                sql = "SELECT * FROM reservas"
                Dim cmd1 As New MySqlCommand(sql, cnn)

                adap1 = New MySqlDataAdapter(cmd1)
                das1 = New DataSet

                adap1.Fill(das1, "reserva")
                Me.DataGridView1.DataSource = das1.Tables("reserva")
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
            Padre.Show()
        End If
    End Sub
End Class