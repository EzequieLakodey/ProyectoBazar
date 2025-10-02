Public Class Compras

    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

    End Sub

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

    End Sub

    Private Sub ComprasBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ComprasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

    End Sub
End Class