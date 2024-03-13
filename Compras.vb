Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Imports System.Net ' Para descargar la imagen desde la URL
Imports System.Net.Http
Imports System.IO
Imports System.Drawing



Public Class frmCompras
    Dim connection As MySqlConnection = GetConnection()





    '-----------------------------------------------
    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim varx, vary As Integer
        Dim selectQuery As String = "SELECT idProducto, nombre, precio, stock, foto FROM PRODUCTO"
        Dim dataTable As New DataTable()
        varx = 20
        vary = 30
        connection.Open()

        Using command As New MySqlCommand(selectQuery, connection)
            Using adapter As New MySqlDataAdapter(command)
                ' Llenar el DataTable con los datos del adaptador
                adapter.Fill(dataTable)
            End Using
        End Using


        For Each fila As DataRow In dataTable.Rows

            Dim btnImagen As New Button
            btnImagen.SetBounds(varx, vary, 60, 40)

            ' Asignar la imagen al botón
            If fila("foto") <> Nothing Then
                btnImagen.BackgroundImage = Image.FromFile(fila("foto"))
                btnImagen.BackgroundImageLayout = ImageLayout.Zoom
            End If

            Me.panelComprar.Controls.Add(btnImagen)

            Dim precio As New Label
            precio.SetBounds(varx + 100, vary, 60, 20)
            precio.Text = String.Format("${0:0,0.00}", fila("precio"))
            Me.panelComprar.Controls.Add(precio)

            Dim cantidad As New TextBox
            cantidad.SetBounds(varx + 200, vary, 60, 20)
            cantidad.Text = 0
            Me.panelComprar.Controls.Add(cantidad)

            Dim precioTotal As New TextBox
            precioTotal.SetBounds(varx + 300, vary, 60, 20)
            precioTotal.Text = CInt(precio.Text) * CInt(cantidad.Text)
            Me.panelComprar.Controls.Add(precioTotal)

            vary = vary + 60

            '
            'Next
        Next
    End Sub

    Private Sub panelComprar_Paint(sender As Object, e As PaintEventArgs) Handles panelComprar.Paint

    End Sub
    ' Private Sub 
    ' End Sub

End Class
