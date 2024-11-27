Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Public Class comprasTotales
    Dim connection As MySqlConnection = GetConnection()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If fechaHasta.Value <= fechaDesde.Value Then
            MsgBox("Las fechas ingresadas son incorrectas")
        End If

        Dim selectQuery As String = "SELECT * FROM PEDIDO WHERE fecha BETWEEN " & fechaDesde.Text & " And " & fechaHasta.Text
        Dim dataTable As New DataTable()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If


        Using command As New MySqlCommand(selectQuery, connection)
            Using adapter As New MySqlDataAdapter(command)
                ' Llenar el DataTable con los datos del adaptador
                adapter.Fill(dataTable)
                dataGridTotales.DataSource = dataTable
                dataGridTotales.AllowUserToAddRows = False
                dataGridTotales.Columns(0).Visible = False

            End Using
        End Using
    End Sub

    Private Sub comprasTotales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecer el formato del DateTimePicker
        fechaDesde.Format = DateTimePickerFormat.Custom
        fechaDesde.CustomFormat = "yyyy-MM-dd"

        fechaHasta.Format = DateTimePickerFormat.Custom
        fechaHasta.CustomFormat = "yyyy-MM-dd"
    End Sub
End Class