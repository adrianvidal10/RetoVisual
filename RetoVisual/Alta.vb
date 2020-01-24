Imports System.ComponentModel
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
        If txtContrasena.Text = txtConfirmarContrasena.Text Then

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
        Else
            MsgBox("Las contraseñas no coinciden")
            Me.txtContrasena.Text = ""
            Me.txtConfirmarContrasena.Text = ""
            Me.txtContrasena.Focus()
        End If
    End Sub
    Private Sub txbEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbEdad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbTelefono.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNombre.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbApellido.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbNombre_Validating(sender As Object, e As CancelEventArgs) Handles txbNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorNombre.SetError(sender, "")
        Else
            Me.ErrorNombre.SetError(sender, "Ingrese el nombre del usuario, este dato es obligatorio")
        End If
    End Sub

    Private Sub lblDni_Validating(sender As Object, e As CancelEventArgs) Handles lblDni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorDni.SetError(sender, "")
        Else
            Me.ErrorDni.SetError(sender, "Ingrese el Dni, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbApellido_Validating(sender As Object, e As CancelEventArgs) Handles txbApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorApellido.SetError(sender, "")
        Else
            Me.ErrorApellido.SetError(sender, "Ingrese el apellido, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbEdad_Validating(sender As Object, e As CancelEventArgs) Handles txbEdad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorEdad.SetError(sender, "")
        Else
            Me.ErrorEdad.SetError(sender, "Ingrese la edad, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbTelefono_Validating(sender As Object, e As CancelEventArgs) Handles txbTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorTlf.SetError(sender, "")
        Else
            Me.Errortlf.SetError(sender, "Ingrese un telefono, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbGmail_Validating(sender As Object, e As CancelEventArgs) Handles txbGmail.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorGmail.SetError(sender, "")
        Else
            Me.ErrorGmail.SetError(sender, "Ingrese el gmail, este dato es obligatorio")
        End If
    End Sub

    Private Sub cmbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cmbSexo.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorSexo.SetError(sender, "")
        Else
            Me.ErrorSexo.SetError(sender, "Ingrese el tipo de genero, este dato es obligatorio")
        End If
    End Sub
End Class