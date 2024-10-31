Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Imports System.Net ' Para descargar la imagen desde la URL
Imports System.Net.Http
Imports System.IO
Imports System.Drawing



Public Class frmCompras
    Dim connection As MySqlConnection = GetConnection()
    Dim precioEntero, totalEntero As Integer

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

        Dim compraTotal As New TextBox
        ' compraTotal.Text = totalCompra
        For Each fila As DataRow In dataTable.Rows
            Dim precio As New TextBox
            precio.SetBounds(varx + 200, vary, 60, 20)
            precio.Text = String.Format("${0:0,0.00}", fila("precio"))
            precio.Enabled = False
            Me.panelComprar.Controls.Add(precio)

            Dim precioTotal As New TextBox
            precioTotal.SetBounds(varx + 400, vary, 60, 20)
            ' precioTotal.Text = CInt(precio.Text) * CInt(cantidad.Text)
            Me.panelComprar.Controls.Add(precioTotal)
            'If Integer.TryParse(precioTotal.Text, precioEntero) Then
            '    totalCompra = totalCompra + precioEntero
            'End If

            Dim cantidad As New TextBox
            cantidad.SetBounds(varx + 300, vary, 60, 20)
            cantidad.Text = 0
            Me.panelComprar.Controls.Add(cantidad)
            AddHandler cantidad.TextChanged, Sub(senderObj, eventArgs) ModificarValor(cantidad, precioTotal, fila("precio"), compraTotal)

            Dim btnImagen As New Button
            btnImagen.SetBounds(varx, vary, 60, 40)
            AddHandler btnImagen.Click, Sub(senderObj, eventArgs) IncrementarValor(cantidad, precioTotal, fila("precio"), compraTotal)
            ' Asignar la imagen al botón
            If fila("foto") <> Nothing Then
                btnImagen.BackgroundImage = Image.FromFile(fila("foto"))
                btnImagen.BackgroundImageLayout = ImageLayout.Zoom
            End If
            Me.panelComprar.Controls.Add(btnImagen)

            vary = vary + 60

        Next


        compraTotal.SetBounds(varx + 400, vary, 60, 20)
        Me.panelComprar.Controls.Add(compraTotal)

    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs)
        MessageBox.Show("¡Botón dinámico clickeado!")
    End Sub

    ' Método para incrementar el valor del TextBox asociado al botón
    Private Sub IncrementarValor(textBoxCantidad As TextBox, txtBoxPrecio As TextBox, precioProducto As Integer, txtCompraTotal As TextBox)
        ' Convertir el valor actual del TextBox a un número
        Dim currentValue As Integer
        If Integer.TryParse(textBoxCantidad.Text, currentValue) Then
            ' Incrementar el valor y actualizar el TextBox
            textBoxCantidad.Text = (currentValue + 1).ToString()
        Else
            ' Si el valor no es un número, lo reiniciamos a 1
            textBoxCantidad.Text = "1"
        End If
        txtBoxPrecio.Text = CInt(textBoxCantidad.Text) * precioProducto
        If Integer.TryParse(txtCompraTotal.Text, totalEntero) Then
            txtCompraTotal.Text = totalEntero + precioEntero
        Else
            txtCompraTotal.Text = 0 + precioEntero
        End If
    End Sub

    Private Sub ModificarValor(textBoxCantidad As TextBox, txtBoxPrecio As TextBox, precioProducto As Integer, txtCompraTotal As TextBox)
        ' Convertir el valor actual del TextBox a un número
        Dim currentValue As Integer
        If Integer.TryParse(textBoxCantidad.Text, currentValue) Then
            '    ' Incrementar el valor y actualizar el TextBox
            textBoxCantidad.Text = currentValue.ToString()
        Else
            '    ' Si el valor no es un número, lo reiniciamos a 1
            textBoxCantidad.Text = "1"
        End If

        txtBoxPrecio.Text = CInt(textBoxCantidad.Text) * precioProducto
0If Integer.TryParse(txtBoxPrecio.Text, precioEntero) Then
            If Integer.TryParse(txtCompraTotal.Text, totalEntero) Then
                txtCompraTotal.Text = totalEntero + precioEntero
            Else
                txtCompraTotal.Text = 0 + precioEntero
            End If
        End If
    End Sub


    Private Sub panelComprar_Paint(sender As Object, e As PaintEventArgs) Handles panelComprar.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    ' Private Sub 
    ' End Sub

End Class
