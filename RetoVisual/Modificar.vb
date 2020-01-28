Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Modificar
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim das1 As DataSet
    Dim resultado As Integer
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaskedTextBoxEdad.Mask = "00"
        Me.MaskedTextBoxTelefono.Mask = "000-000-000"
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        Dim sql As String = "SELECT * FROM cliente"
        Dim cmd1 As New MySqlCommand(sql, coon)

        adap1 = New MySqlDataAdapter(cmd1)
        das1 = New DataSet
        adap1.Fill(das1, "cliente")
        Me.Label8.Text = "Numero de filas: " & das1.Tables("cliente").Rows.Count
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cnn = New MySqlConnection(cadenaconexion)
        sql = "UPDATE cliente SET Dni=@dni, Nombre=@nombre, Apellido=@apellido, Edad=@edad, Sexo=@sexo, Telefono=@telefono,Gmail=@gmail WHERE Dni = '" & Me.DataGridView1.CurrentRow.Cells.Item(1).Value & "'"
        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@dni", Me.TextBox2.Text)
        cmd.Parameters.AddWithValue("@nombre", Me.TextBox3.Text)
        cmd.Parameters.AddWithValue("@apellido", Me.TextBox4.Text)
        cmd.Parameters.AddWithValue("@edad", Me.MaskedTextBoxEdad.Text)
        cmd.Parameters.AddWithValue("@sexo", Me.cmbSexo.Text)
        cmd.Parameters.AddWithValue("@telefono", Me.MaskedTextBoxTelefono.Text)
        cmd.Parameters.AddWithValue("@gmail", Me.TextBox5.Text)

        Try
            cnn.Open()
            resultado = cmd.ExecuteNonQuery()
            MsgBox("Actualizadas: " & resultado & "filas")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        cnn = New MySqlConnection(cadenaconexion)
        cnn.Open()

        'Dim Dni As String
        'Dni = Encriptar.Desencriptar(Convert.ToString(DataGridView1.CurrentRow.Cells.Item(1).Value))
        TextBox2.Text = DataGridView1.CurrentRow.Cells.Item(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells.Item(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells.Item(3).Value
        MaskedTextBoxEdad.Text = DataGridView1.CurrentRow.Cells.Item(4).Value
        cmbSexo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
        MaskedTextBoxTelefono.Text = DataGridView1.CurrentRow.Cells.Item(6).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells.Item(7).Value

        Dim cmd As New MySqlCommand(sql, cnn)

        cnn.Close()

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
End Class