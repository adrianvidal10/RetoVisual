﻿
Imports MySql.Data.MySqlClient
Public Class Login
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txbDni.Text = "1"
        Me.txbContrasena.Text = "1"
        Dim coon As New MySqlConnection(cadenaconexion)
        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()


    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        cnn = New MySqlConnection(cadenaconexion)
        Dim cmd1 = cnn.CreateCommand()
        cmd1.CommandText = "SELECT Dni,contrasena FROM usuario WHERE Dni= @dni AND contrasena= @contrasena AND admin=1"
        cmd1.Parameters.AddWithValue("@dni", Me.txbDni.Text)
        cmd1.Parameters.AddWithValue("@contrasena", Me.txbContrasena.Text)

        Dim dr As MySqlDataReader = Nothing
        Try
            cnn.Open()

            dr = cmd1.ExecuteReader
            If dr.HasRows Then
                MsgBox("Aceptado en el sistema")
                Me.Hide()
                Padre.Show()

            Else
                MsgBox("Usuario o contraseña erronea")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                dr.Close()
            End If
        End Try
    End Sub
End Class
