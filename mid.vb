﻿Public Class frmIngresar
    Private Sub USUARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles usuario.Click
        listUsuarios.Show()

    End Sub

    Private Sub PRODUCTOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles producto.Click
        listadoProducto.Show()
    End Sub

    Private Sub compras_Click(sender As Object, e As EventArgs) Handles compras.Click
        frmCompras.Show()
    End Sub

    Private Sub COMPRASPORDIAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPRASPORDIAToolStripMenuItem.Click
        comprasTotales.Show()
    End Sub

    Private Sub TOTALESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOTALESToolStripMenuItem.Click
        ' frmTotales.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class