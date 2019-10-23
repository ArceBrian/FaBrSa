Public Class frm_Menu
    Private Sub RubrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubrosToolStripMenuItem.Click
        frm_Rubros.Show()
    End Sub

    Private Sub SubRubrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubRubrosToolStripMenuItem.Click
        frm_SubRubros.Show()
    End Sub
    Private Sub CargaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargaToolStripMenuItem.Click
        frm_CargaCliente.Show()
    End Sub
    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click

    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frm_Proveedores.Show()
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrienteToolStripMenuItem.Click
        frm_Factura.Show()
    End Sub

    Private Sub CuentaCorrienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentaCorrienteToolStripMenuItem1.Click
        frm_CuentaCorriente.Show()
    End Sub

    Private Sub ProductosItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosItemsToolStripMenuItem.Click
        frm_ProductosItem.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem1.Click
        frm_Productos.Show()
    End Sub

    Private Sub ClientesItemsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClientesItemsToolStripMenuItem.Click
        frm_ClientesItem.Show()
    End Sub
End Class