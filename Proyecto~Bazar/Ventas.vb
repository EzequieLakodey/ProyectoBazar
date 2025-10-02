Public Class Ventas

    Private Sub VentasBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
    End Sub

    Private Sub Ventas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)
    End Sub


End Class