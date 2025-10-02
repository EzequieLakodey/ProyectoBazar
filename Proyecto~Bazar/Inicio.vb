Public Class Inicio

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        Me.Hide()
        Compras.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactoToolStripMenuItem.Click
        Me.Hide()
        Contacto.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class
