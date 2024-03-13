Public Class frmIngresar
    Private Sub USUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles usuario.Click
        listUsuarios.Show()

    End Sub

    Private Sub PRODUCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles producto.Click
        listadoProducto.Show()
    End Sub

    Private Sub compras_Click(sender As Object, e As EventArgs) Handles compras.Click
        frmCompras.Show()
    End Sub


End Class