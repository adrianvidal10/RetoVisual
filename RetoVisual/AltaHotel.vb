Imports MySql.Data.MySqlClient
Public Class AltaHotel
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub AltaHotel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class