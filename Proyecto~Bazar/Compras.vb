Public Class Compras

    Dim confirmacion As Boolean

    Dim idProveedor, idCompra, posicion, contadorCompra As Long

    Dim fila As DataRowView

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ComprasBindingSource.AddNew()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.Refresh()

        Me.ComprasBindingSource.MoveLast()

    End Sub

    Function BuscarProveedor() As Integer

        idProveedor = CLng(TextBoxConsulta.Text)

        If idProveedor >= 0 Then

            posicion = Me.ComprasBindingSource.Find("ID_Proveedor", idProveedor)

            Me.ComprasBindingSource.Position = posicion

            Return posicion

        End If

        Return 0

    End Function

    Private Sub ButtonCrear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCrear.Click

        Me.ComprasBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.ComprasBindingSource.AddNew()

        Me.ComprasBindingSource.MoveLast()

    End Sub

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

        Me.ComprasBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.Refresh()

    End Sub

    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEliminar.Click

        BuscarProveedor()

        confirmacion = MsgBox("Esta seguro que desea eliminar el PROVEEDOR = " & ID_ProveedorTextBox.Text & " | " & ProveedorComboBox.Text, MsgBoxStyle.YesNo)

        If confirmacion Then

            Me.ComprasBindingSource.RemoveCurrent()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

            MsgBox("Registro eliminado correctamente", MsgBoxStyle.MsgBoxRight)

        End If

        Me.Refresh()

        Me.ComprasBindingSource.MoveLast()

    End Sub

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

    End Sub

    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBuscar.Click

        BuscarProveedor()

    End Sub

    Private Sub ButtonAnterior_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnterior.Click

        ComprasBindingSource.MoveNext()

    End Sub

    Private Sub ButtonSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSiguiente.Click

        ComprasBindingSource.MoveNext()

    End Sub

    Private Sub ID_ProveedorTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID_ProveedorTextBox.TextChanged

        TextBoxConsulta.Text = ID_ProveedorTextBox.Text

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