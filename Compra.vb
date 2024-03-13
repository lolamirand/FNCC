Imports MySql.Data.MySqlClient
Imports MySql.Data
Imports FNCC.conectar

Public Class frmCompra
    Dim connection As MySqlConnection = GetConnection()

    Private Sub frmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim selectQuery As String = "SELECT idProducto,nombre,precio,stock,foto FROM PRODUCTO"
        Dim dataTable As New DataTable()
        connection.Open()

        Using command As New MySqlCommand(selectQuery, connection)
            Using adapter As New MySqlDataAdapter(command)
                ' Llenar el DataTable con los datos del adaptador
                adapter.Fill(dataTable)
            End Using
        End Using
        txtTotal.Text = 0
        txtCantMila.Text = 0
        txtCantPancho.Text = 0
        txtCantPbt.Text = 0
        txtCantInfantil.Text = 0
        txtCantAgua.Text = 0
        txtCantAquarius.Text = 0
        txtCantGaseosa.Text = 0
        txtCantCerveza.Text = 0
        txtTotal.Text = 0
    End Sub

    Private Sub txtCantMila_TextChanged(sender As Object, e As EventArgs) Handles txtCantMila.TextChanged
        txtPrecioMila.Text = CDec(lbl_precioMila.Text) * CDec(txtCantMila.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioMila.Text)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub





    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_precioInfantil.Click

    End Sub

    Private Sub txtCantPancho_TextChanged(sender As Object, e As EventArgs) Handles txtCantPancho.TextChanged
        txtPrecioPancho.Text = CDec(lbl_precioPancho.Text) * CDec(txtCantPancho.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioPancho.Text)
    End Sub
    Private Sub btn_milanesa_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtCantMila.Text = CInt(txtCantMila.Text) + 1

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtCantPancho.Text = CInt(txtCantPancho.Text) + 1
        txtTotal.Text = CInt(txtTotal.Text) + CInt(lbl_precioPancho.Text)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtCantPbt.Text = CInt(txtCantPbt.Text) + 1
        txtTotal.Text = CInt(txtTotal.Text) + CInt(lbl_precioPbt.Text)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtCantInfantil.Text = CInt(txtCantInfantil.Text) + 1
        txtTotal.Text = CInt(txtTotal.Text) + CInt(lbl_precioInfantil.Text)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtCantAgua.Text = CInt(txtCantAgua.Text) + 1
        txtTotal.Text = CInt(txtTotal.Text) + CInt(lbl_precioAgua.Text)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtCantAquarius.Text = CInt(txtCantAquarius.Text) + 1
        txtTotal.Text = CInt(txtTotal.Text) + CInt(lbl_precioAquarius.Text)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtCantGaseosa.Text = CInt(txtCantGaseosa.Text) + 1
        txtTotal.Text = CInt(txtTotal.Text) + CInt(lbl_precioGaseosa.Text)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtCantCerveza.Text = CInt(txtCantCerveza.Text) + 1
        txtTotal.Text = CInt(txtTotal.Text) + CInt(lbl_precioCerveza.Text)


    End Sub

    Private Sub txtCantPbt_TextChanged(sender As Object, e As EventArgs) Handles txtCantPbt.TextChanged
        txtPrecioPbt.Text = CDec(lbl_precioPbt.Text) * CDec(txtCantPbt.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioPbt.Text)
    End Sub

    Private Sub txtCantInfantil_TextChanged(sender As Object, e As EventArgs) Handles txtCantInfantil.TextChanged
        txtPrecioInfantil.Text = CDec(lbl_precioInfantil.Text) * CDec(txtCantInfantil.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioInfantil.Text)
    End Sub

    Private Sub txtCantAgua_TextChanged(sender As Object, e As EventArgs) Handles txtCantAgua.TextChanged
        txtPrecioAgua.Text = CDec(lbl_precioAgua.Text) * CDec(txtCantAgua.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioAgua.Text)
    End Sub

    Private Sub txtCantAquarius_TextChanged(sender As Object, e As EventArgs) Handles txtCantAquarius.TextChanged
        txtPrecioAquarius.Text = CDec(lbl_precioAquarius.Text) * CDec(txtCantAquarius.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioAquarius.Text)
    End Sub

    Private Sub txtCantGaseosa_TextChanged(sender As Object, e As EventArgs) Handles txtCantGaseosa.TextChanged
        txtPrecioGaseosa.Text = CDec(lbl_precioGaseosa.Text) * CDec(txtCantGaseosa.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioGaseosa.Text)
    End Sub

    Private Sub txtCantCerveza_TextChanged(sender As Object, e As EventArgs) Handles txtCantCerveza.TextChanged
        txtPrecioCerveza.Text = CDec(lbl_precioCerveza.Text) * CDec(txtCantCerveza.Text)
        txtTotal.Text = CDec(txtTotal.Text) + CDec(lbl_precioCerveza.Text)
    End Sub

    Private Sub lbl_precioCerveza_Click(sender As Object, e As EventArgs) Handles lbl_precioCerveza.Click

    End Sub

    Private Sub txtPrecioMila_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioMila.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        If txtTotal.Text <> 0 Then
            MessageBox.Show("¡Su compra se ha efectuado exitosamente!", "Mensaje de confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Debes seleccionar algo para comprar.", "Algo anda mal :(", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtCantMila.Text = 0
        txtCantPancho.Text = 0
        txtCantPbt.Text = 0
        txtCantInfantil.Text = 0
        txtCantAgua.Text = 0
        txtCantAquarius.Text = 0
        txtCantGaseosa.Text = 0
        txtCantCerveza.Text = 0
        txtTotal.Text = 0
    End Sub

    Private Sub lbl_precioMila_Click(sender As Object, e As EventArgs) Handles lbl_precioMila.Click

    End Sub
End Class
