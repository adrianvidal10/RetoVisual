Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class AltaHotel
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub AltaHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbtipo.SelectedValue = "1"
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
        Dim tipo As String
        tipo = cmbtipo.Text
        If tipo = "alojamiento" Then
            'Label8.Text = "SELECT max(IdAloj)
            sql = "INSERT INTO alojamiento (idAloj,Nombre,Ubicacion,Capacidad,Categoria,Web,Precio,Latitud,Longitud) values (@id,@nombre,@ubicacion,@capacidad,@categoria,@web,@precio,@latitud,@longitud)"
        ElseIf tipo = "camping" Then
            sql = "INSERT INTO camping (idCamp,Nombre,Ubicacion,Capacidad,Categoria,Web,Precio,Latitud,Longitud) values (@id,@nombre,@ubicacion,@capacidad,@categoria,@web,@precio,@latitud,@longitud)"
        ElseIf tipo = "albergue" Then
            sql = "INSERT INTO albergue (idAlb,Nombre,Ubicacion,Capacidad,Categoria,Web,Precio,Latitud,Longitud) values (@id,@nombre,@ubicacion,@capacidad,@categoria,@web,@precio,@latitud,@longitud)"
        End If
        cnn = New MySqlConnection(cadenaconexion)

        Dim cmd As New MySqlCommand(sql, cnn)
        cmd.Parameters.AddWithValue("@id", Me.txbId.Text)
        cmd.Parameters.AddWithValue("@nombre", Me.txbNombre.Text)
        cmd.Parameters.AddWithValue("@ubicacion", Me.txbUbicacion.Text)
        cmd.Parameters.AddWithValue("@capacidad", Me.txbCapacidad.Text)
        cmd.Parameters.AddWithValue("@categoria", Me.txbCapacidad.Text)
        cmd.Parameters.AddWithValue("@web", Me.txbWeb.Text)
        cmd.Parameters.AddWithValue("@precio", Me.txbPrecio.Text)
        cmd.Parameters.AddWithValue("@latitud", Me.txbLatitud.Text)
        cmd.Parameters.AddWithValue("@longitud", Me.txbLongitud.Text)
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
    Private Sub txbUbicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbUbicacion.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txbCapacidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbCapacidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txbPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbPrecio.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbNombre.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txbLatitud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbLatitud.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txbLongitud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txbLongitud.KeyPress
        If Not IsNumeric(e.KeyChar) Then
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

    Private Sub lblUbicacion_Validating(sender As Object, e As CancelEventArgs) Handles Label2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorUbicacion.SetError(sender, "")
        Else
            Me.ErrorUbicacion.SetError(sender, "Ingrese la ubicacion, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbCapacidad_Validating(sender As Object, e As CancelEventArgs) Handles Label3.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorCapacidad.SetError(sender, "")
        Else
            Me.ErrorCapacidad.SetError(sender, "Ingrese la capacidad, este dato es obligatorio")
        End If
    End Sub

    Private Sub txbPrecio_Validating(sender As Object, e As CancelEventArgs) Handles Label6.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorPrecio.SetError(sender, "")
        Else
            Me.ErrorPrecio.SetError(sender, "Ingrese el precio por noche, este dato es obligatorio")
        End If
    End Sub
    Private Sub cmbtipo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbtipo.SelectedValueChanged
        If cmbtipo.Text = "alojamiento" Then
            Me.txbId.Text = ""
            Me.txbId.Text = "alo"
        ElseIf cmbtipo.Text = "albergue" Then
            Me.txbId.Text = ""
            Me.txbId.Text = "alb"
        ElseIf cmbtipo.Text = "camping" Then
            Me.txbId.Text = ""
            Me.txbId.Text = "camp"
        End If
    End Sub
End Class