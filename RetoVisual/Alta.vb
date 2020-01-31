Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Alta
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Me.MaskedTextBox1.Mask = "00000000?"
        Me.MaskedTextBoxNombre.Mask = "?????????????????"
        Me.MaskedTextBoxApellido.Mask = "?????????????????"
        Me.MaskedTextBoxEdad.Mask = "00"
        Me.MaskedTextBoxTelefono.Mask = "000-000-000"
        Me.MaskedTextBoxGmail.Mask = "?????????????????????"
        Me.cmbSexo.SelectedIndex = 1
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
            sql = "INSERT INTO cliente (Dni,Nombre,Apellido,Edad,Sexo,Telefono,Gmail,contrasena) values (@dni,@nombre,@apellido,@edad,@sexo,@telefono,@gmail,@contrasena)"
            Dim cmd As New MySqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@dni", Me.MaskedTextBox1.Text)
            cmd.Parameters.AddWithValue("@nombre", Me.MaskedTextBoxNombre.Text)
            cmd.Parameters.AddWithValue("@apellido", Me.MaskedTextBoxApellido.Text)
            cmd.Parameters.AddWithValue("@edad", Me.MaskedTextBoxEdad.Text)
            cmd.Parameters.AddWithValue("@sexo", Me.cmbSexo.Text)
            cmd.Parameters.AddWithValue("@telefono", Me.MaskedTextBoxTelefono.Text)
            cmd.Parameters.AddWithValue("@gmail", Me.MaskedTextBoxGmail.Text)
            cmd.Parameters.AddWithValue("@contrasena", Me.txtContrasena.Text)
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
    Private Sub txbEdad_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbNombre_KeyPress(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbApellido_KeyPress(sender As Object, e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbNombre_Validating(sender As Object, e As CancelEventArgs)
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

    Private Sub txbApellido_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorApellido.SetError(sender, "")
        Else
            Me.ErrorApellido.SetError(sender, "Ingrese el apellido, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbEdad_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorEdad.SetError(sender, "")
        Else
            Me.ErrorEdad.SetError(sender, "Ingrese la edad, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbTelefono_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.Errortlf.SetError(sender, "")
        Else
            Me.Errortlf.SetError(sender, "Ingrese un telefono, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbGmail_Validating(sender As Object, e As CancelEventArgs)
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

    Private Sub MaskedTextBoxNombre_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBoxNombre.MaskInputRejected

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class