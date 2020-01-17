Imports MySql.Data.MySqlClient
Public Class Alta
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()
    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        cnn = New MySqlConnection(cadenaconexion)
        sql = "INSERT INTO cliente (Dni,Nombre,Apellido,Edad,Sexo,Telefono,Gmail) values (@dni,@nombre,@apellido,@edad,@sexo,@telefono,@gmail)"
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@dni", Me.txbDni.Text)
        cmd.Parameters.AddWithValue("@nombre", Me.txbNombre.Text)
        cmd.Parameters.AddWithValue("@apellido", Me.txbApellido.Text)
        cmd.Parameters.AddWithValue("@edad", Me.txbEdad.Text)
        cmd.Parameters.AddWithValue("@sexo", Me.cmbSexo.Text)
        cmd.Parameters.AddWithValue("@telefono", Me.txbTelefono.Text)
        cmd.Parameters.AddWithValue("@gmail", Me.txbGmail.Text)

        Try
            cnn.Open()
            resultado = cmd.ExecuteNonQuery()
            MsgBox("Insertado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub
End Class