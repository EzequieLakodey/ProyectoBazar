Public Class Compras

    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
    End Sub

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)
        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)
    End Sub

    Private Sub ComprasBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        Me.Hide()
        Ventas.Show()
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