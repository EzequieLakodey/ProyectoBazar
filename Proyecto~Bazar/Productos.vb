Public Class Productos







    ''''''''''''''''''''''''''''''''    Carga del Form

    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla 'BazarDataSet.Compras' Puede moverla o quitarla según sea necesario.
        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ProductosBindingSource.AddNew()

        Me.Refresh()

        Me.ProductosDataGridView.ClearSelection()

        TextBoxConsulta.Text = ID_ProductoTextBox.Text

        Me.ProductosBindingSource.MoveLast()

    End Sub








    ''''''''''''''''''''''''''''''''    Declaracion de variables

    Dim confirmacion As Boolean

    Dim idProducto, posicion As Long











    ''''''''''''''''''''''''''''''''    Busqueda de Productos por ID

    Function BuscarProducto() As Integer

        idProducto = CLng(TextBoxConsulta.Text)

        posicion = Me.ProductosBindingSource.Find("ID_Producto", idProducto)

        If posicion >= 0 Then

            Me.ProductosBindingSource.Position = posicion

            Return posicion

        End If

        Return 0

    End Function








    ''''''''''''''''''''''''''''''''    Eventos de Busquedas

    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBuscar.Click

        BuscarProducto()

    End Sub

    Private Sub ID_ProductoTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID_ProductoTextBox.TextChanged

        TextBoxConsulta.Text = ID_ProductoTextBox.Text

    End Sub






    ''''''''''''''''''''''''''''''''    ALTAS

    Private Sub ButtonCrear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCrear.Click

        Me.ProductosBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

        Me.Refresh()

        Me.ProductosBindingSource.AddNew()

        Me.ProductosBindingSource.MoveLast()

    End Sub











    ''''''''''''''''''''''''''''''''    MODIFICACIONES

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

        Me.ProductosBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

        Me.Refresh()

        Me.ProductosBindingSource.MoveLast()

    End Sub















    ''''''''''''''''''''''''''''''''    BAJAS POR ID

    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEliminar.Click

        BuscarProducto()

        confirmacion = MsgBox("Esta seguro que desea eliminar el PRODUCTO = " & ID_ProductoTextBox.Text & " | " & NombreComboBox.Text, MsgBoxStyle.YesNo)

        If confirmacion Then

            Me.ProductosBindingSource.RemoveCurrent()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

            MsgBox("Registro eliminado correctamente", MsgBoxStyle.MsgBoxRight)

        End If

        Me.ProductosBindingSource.AddNew()

        Me.Refresh()

        Me.ProductosBindingSource.MoveLast()

    End Sub









    ''''''''''''''''''''''''''''''''    PURGADO TOTAL DE BD

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

        BuscarProducto()

        confirmacion = MsgBox("Esta seguro que desea eliminar TODOS los registros de [Productos], y las [Ventas] y [Compras] asociados a los mismos: ESTA ACCION ES PERMANENTE", MsgBoxStyle.YesNo, MsgBoxStyle.Critical)

        If confirmacion Then

            Me.VentasTableAdapter.Purgar()

            Me.ComprasTableAdapter.Purgar()

            Me.ProductosTableAdapter.Purgar()

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

            MsgBox("TODOS los registros fueron eliminados de [Productos]", MsgBoxStyle.MsgBoxRight)

        End If

        Me.Refresh()

        Me.ProductosBindingSource.AddNew()

        Me.ProductosBindingSource.MoveLast()

    End Sub









    ''''''''''''''''''''''''''''''''    Validaciones Campos y Tipos de Datos
    Private Sub NombreComboBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NombreComboBox.KeyPress

        If LetrasNumerosPuntos(e) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub CategoriaComboBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CategoriaComboBox.KeyPress

        If LetrasNumerosPuntos(e) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub StockMinimoTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles StockMinimoTextBox.KeyPress

        If SoloNumerosEnteros(e) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub StockTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles StockTextBox.KeyPress

        If SoloNumerosEnteros(e) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub









    ''''''''''''''''''''''''''''''''    Navegacion

    Private Sub ButtonUltimoItem_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUltimoItem.Click

        Me.ProductosBindingSource.MoveLast()

    End Sub

    Private Sub ButtonAnterior_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnterior.Click

        Me.ProductosBindingSource.MovePrevious()

    End Sub

    Private Sub ButtonPrimerItem_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPrimerItem.Click

        Me.ProductosBindingSource.MoveFirst()

    End Sub

    Private Sub ButtonSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSiguiente.Click

        Me.ProductosBindingSource.MoveNext()

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InicioToolStripMenuItem.Click

        Me.Hide()

        Inicio.Show()

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click

        Me.Hide()

        Ventas.Show()

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasToolStripMenuItem.Click

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