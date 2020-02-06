
Imports MySql.Data.MySqlClient
Public Class Buscar
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim sql2 As String
    Dim das1 As DataSet
    Dim das2 As DataSet
    Dim das3 As DataSet
    Dim adap1 As MySqlDataAdapter
    Dim adap3 As MySqlDataAdapter
    Dim cmd3 As MySqlCommand
    Dim cadenaconexion As String = "server=192.168.106.14;database=retoethazi;user id=root2;password=root2;port=3306"
    Private Sub Buscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16)
        DataGridView2.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 16)
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

        sql2 = "SELECT * FROM reservas WHERE Fk_IdCliente = " & Me.DataGridView1.CurrentRow.Cells.Item(0).Value & ""

        Dim a As String = Me.DataGridView1.CurrentRow.Cells.Item(0).Value
        Me.Label3.Text = "El precio de todas las reservas es: " & calcular(a) & "€"

        Dim cmd1 As New MySqlCommand(sql2, cnn)
        Dim das9 As New DataSet()
        Dim adap9 As New MySqlDataAdapter(cmd1)


        Try
            'cnn.Open()
            'Dim resultado As MySqlDataReader
            'resultado = cmd1.ExecuteReader

            adap9.Fill(das9, "aaa")

            'DataGridView2.Columns(0).Width = 60
            'DataGridView2.Columns(1).Width = 60
            'DataGridView2.Columns(2).Width = 60
            'DataGridView2.Columns(3).Width = 60
            'DataGridView2.Columns(4).Width = 60
            'DataGridView2.Columns(5).Width = 60
            'DataGridView2.Columns(6).Width = 60
            'DataGridView2.Columns(7).Width = 100
            Me.DataGridView2.DataSource = das9.Tables("aaa")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim total As Double
        Dim x As Integer = 1
        Dim fecha1, fecha2 As Date
        Dim difFecha As Integer
        fecha1 = Convert.ToDateTime(Me.das3.Tables("reserva").Rows(X).Item("fecha_ini"))
        fecha2 = Convert.ToDateTime(Me.das3.Tables("reserva").Rows(X).Item("FechaFin"))
        difFecha = DateDiff(DateInterval.Day, fecha1, fecha2)
        total += Me.das3.Tables("reserva").Rows(x).Item("Precio") * Me.das3.Tables("reserva").Rows(x).Item("Habitaciones") * difFecha
        Me.Label3.Text = "El valor de esta reserva es: " & total & "€"
    End Sub

    Function calcular(a As String) As Double
        Dim total As Double
        Dim x As Integer
        Dim fecha1, fecha2 As Date
        Dim difFecha As Integer

        das3 = New DataSet
        Try
            cmd3 = New MySqlCommand("Select * from reservas where Fk_IdCliente =" & a, cnn)
            adap3 = New MySqlDataAdapter(cmd3)
            adap3.Fill(das3, "reserva")

            For x = 0 To Me.das3.Tables("reserva").Rows.Count - 1
                fecha1 = Convert.ToDateTime(Me.das3.Tables("reserva").Rows(x).Item("fecha_ini"))
                fecha2 = Convert.ToDateTime(Me.das3.Tables("reserva").Rows(x).Item("FechaFin"))
                difFecha = DateDiff(DateInterval.Day, fecha1, fecha2)
                total += Me.das3.Tables("reserva").Rows(x).Item("Precio") * Me.das3.Tables("reserva").Rows(x).Item("Habitaciones") * difFecha
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return total
    End Function
End Class