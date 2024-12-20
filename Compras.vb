﻿Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar
Imports System.Net ' Para descargar la imagen desde la URL
Imports System.Net.Http
Imports System.IO
Imports System.Drawing
Imports Org.BouncyCastle.Math.EC

Public Class frmCompras
    Dim connection As MySqlConnection = GetConnection()
    Dim precioEntero, totalEntero As Integer
    Private compraTotal As TextBox
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
            Dim precio As New TextBox
            precio.SetBounds(varx + 200, vary, 60, 20)
            precio.TextAlign = HorizontalAlignment.Right
            precio.Text = CInt(fila("precio")).ToString("F2")
            precio.Enabled = False
            Me.panelComprar.Controls.Add(precio)

            Dim precioTotal As New TextBox
            precioTotal.SetBounds(varx + 400, vary, 60, 20)
            precioTotal.Name = "precioTotal"
            precioTotal.TextAlign = HorizontalAlignment.Right


            Me.panelComprar.Controls.Add(precioTotal)
            AddHandler precioTotal.TextChanged, Sub(senderObj, eventArgs) actualizarCompraTotal()

            Dim cantidad As New TextBox
            cantidad.SetBounds(varx + 300, vary, 60, 20)
            cantidad.Text = 0
            Me.panelComprar.Controls.Add(cantidad)
            AddHandler cantidad.TextChanged, Sub(senderObj, eventArgs) ModificarValor(cantidad, precioTotal, fila("precio"))

            Dim btnImagen As New Button
            btnImagen.SetBounds(varx, vary, 60, 40)
            AddHandler btnImagen.Click, Sub(senderObj, eventArgs) IncrementarValor(cantidad, precioTotal, fila("precio"))
            ' Asignar la imagen al botón
            If fila("foto") <> Nothing Then
                btnImagen.BackgroundImage = Image.FromFile(fila("foto"))
                btnImagen.BackgroundImageLayout = ImageLayout.Zoom
            End If
            Me.panelComprar.Controls.Add(btnImagen)

            vary = vary + 60

        Next

        compraTotal = New TextBox()

        ' Verificar que se ha creado correctamente
        If compraTotal IsNot Nothing Then
            ' Configurar las propiedades del TextBox
            compraTotal.Name = "compraTotal"
            compraTotal.SetBounds(varx + 400, vary, 60, 20)
            ' Configurar la alineación del texto a la derecha
            compraTotal.TextAlign = HorizontalAlignment.Right

            Me.panelComprar.Controls.Add(compraTotal)
        End If

        Dim btnCancelar As New Button
        btnCancelar.SetBounds(varx, vary, 80, 40)
        AddHandler btnCancelar.Click, Sub(senderObj, eventArgs)

                                      End Sub
        Dim btnAceptar As New Button
        btnAceptar.SetBounds(varx, vary, 60, 40)
        AddHandler btnAceptar.Click, Sub(senderObj, eventArgs)
                                     End Sub
    End Sub

    ' Método para incrementar el valor del TextBox asociado al botón
    Private Sub IncrementarValor(textBoxCantidad As TextBox, txtBoxPrecio As TextBox, precioProducto As Integer)
        ' Convertir el valor actual del TextBox a un número
        Dim currentValue As Integer
        If Integer.TryParse(textBoxCantidad.Text, currentValue) Then
            ' Incrementar el valor y actualizar el TextBox
            textBoxCantidad.Text = (currentValue + 1).ToString()
        Else
            ' Si el valor no es un número, lo reiniciamos a 1
            textBoxCantidad.Text = "1"
        End If
        txtBoxPrecio.Text = (CInt(textBoxCantidad.Text) * precioProducto).ToString("F2")
        actualizarCompraTotal()

    End Sub

    Private Sub ModificarValor(textBoxCantidad As TextBox, txtBoxPrecio As TextBox, precioProducto As Integer)
        ' Convertir el valor actual del TextBox a un número
        Dim currentValue As Integer
        If Integer.TryParse(textBoxCantidad.Text, currentValue) Then
            '    ' Incrementar el valor y actualizar el TextBox
            textBoxCantidad.Text = currentValue.ToString()
        Else
            '    ' Si el valor no es un número, lo reiniciamos a 1
            textBoxCantidad.Text = "1"
        End If

        txtBoxPrecio.Text = (CInt(textBoxCantidad.Text) * precioProducto).ToString("F2")
        actualizarCompraTotal()

    End Sub

    Private Sub actualizarCompraTotal()
        Dim totalProducto, totalCompra As Decimal
        totalCompra = 0
        totalProducto = 0
        If panelComprar.Controls.Count = 0 Then
            MessageBox.Show("No hay controles en panelComprar.")
            Return
        End If

        For Each control As Control In panelComprar.Controls
            ' Verificar si el control es un TextBox
            If TypeOf control Is TextBox AndAlso control.Name.StartsWith("precioTotal") Then
                Dim txt As TextBox = CType(control, TextBox)
                ' Intentar convertir el texto del TextBox a Integer

                If Decimal.TryParse(txt.Text.Replace(",", "."), totalProducto) Then
                    ' Si es válido, sumar al totalCompra
                    totalCompra += totalProducto
                Else
                    totalProducto = 0
                End If
            End If
        Next

        If compraTotal IsNot Nothing Then
            compraTotal.Text = (totalCompra)
        End If


    End Sub

    Private Sub panelComprar_Paint(sender As Object, e As PaintEventArgs) Handles panelComprar.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

End Class
