Public Class Productos
    Dim confirmacion, posicion As Boolean
    Dim idProducto As Long
    Dim fila As DataRowView

    Private Sub ProductosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)
    End Sub

    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)
        Me.ProductosBindingSource.AddNew()
        Me.ProductosBindingSource.MoveFirst()
    End Sub

    Function BuscarProducto() As Integer

        idProducto = CLng(ID_ProductoTextBox.Text)

        posicion = Me.ProductosBindingSource.Find("ID_Producto", idProducto)

        If posicion >= 0 Then

            Me.ProductosBindingSource.Position = posicion

            Return posicion

        End If

        Return 0

    End Function




    Private Sub ButtonAnterior_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnterior.Click
        Me.ProductosBindingSource.MovePrevious()
    End Sub

    Private Sub ButtonSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSiguiente.Click
        Me.ProductosBindingSource.MoveNext()
    End Sub

    Private Sub ID_ProductoTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID_ProductoTextBox.TextChanged
        TextBoxConsulta.Text = ID_ProductoTextBox.Text
    End Sub

    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBuscar.Click

        BuscarProducto()

    End Sub

    Private Sub ButtonCrear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCrear.Click

    End Sub

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

    End Sub

    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEliminar.Click

    End Sub

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InicioToolStripMenuItem.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        Me.Hide()
        Ventas.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        Compras.Show()
    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactoToolStripMenuItem.Click
        Me.Hide()
        Contacto.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

End Class