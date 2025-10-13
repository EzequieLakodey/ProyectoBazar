Public Class Productos







    ''''''''''''''''''''''''''''''''    Carga del Form

    Private Sub Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        TextBoxID.Text = ID_ProductoTextBox.Text

        Me.ProductosBindingSource.MoveLast()

        ' Poblacion del ComboBoxAtributo
        CargarColumnasEnComboBox(BazarDataSet.Tables("Productos"), ComboBoxAtributo)

    End Sub








    ''''''''''''''''''''''''''''''''    Declaracion de variables

    Dim confirmacion As MsgBoxResult

    Dim idProducto, posicion, stock, stockMinimo As Long

    Dim nombre, categoria As String











    ''''''''''''''''''''''''''''''''    Busqueda de Productos por ID

    Function BuscarProducto() As Integer

        If String.IsNullOrWhiteSpace(ID_ProductoTextBox.Text) Then

            MsgBox("Ingrese un ID Valido")

            Return -1

        Else

            idProducto = CLng(TextBoxID.Text)

            posicion = Me.ProductosBindingSource.Find("ID_Producto", idProducto)

            If posicion >= 0 Then

                Me.ProductosBindingSource.Position = posicion

                Return posicion

            End If

        End If

        Return 0

    End Function








    ''''''''''''''''''''''''''''''''    Eventos de Busquedas

    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBuscar.Click

        BuscarProducto()

    End Sub

    Private Sub ID_ProductoTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID_ProductoTextBox.TextChanged

        TextBoxID.Text = ID_ProductoTextBox.Text

    End Sub













    ''''''''''''''''''''''''''''''''    ALTAS

    Private Sub ButtonCrear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCrear.Click

        Me.ProductosBindingSource.MoveLast()

        nombre = NombreTextBox.Text

        categoria = CategoriaTextBox.Text

        stock = Val(StockTextBox.Text)

        stockMinimo = Val(StockMinimoTextBox.Text)

        Me.ProductosTableAdapter.Insert(
            nombre,
            categoria,
            stock,
            stockMinimo
            )

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

        Me.ProductosBindingSource.MoveLast()

    End Sub











    ''''''''''''''''''''''''''''''''    MODIFICACIONES

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

        Me.ProductosBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

        Me.ProductosBindingSource.MoveLast()

    End Sub















    ''''''''''''''''''''''''''''''''    BAJAS POR ID

    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEliminar.Click

        posicion = BuscarProducto()

        confirmacion = MsgBox("Esta seguro que desea eliminar el PRODUCTO = " & ID_ProductoTextBox.Text & " | " & NombreTextBox.Text, MsgBoxStyle.YesNo)

        If confirmacion = MsgBoxResult.Yes And posicion >= 0 Then

            Me.ProductosBindingSource.RemoveCurrent()

            Me.ProductosBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

            MsgBox("Registro eliminado correctamente", MsgBoxStyle.MsgBoxRight)

            Me.ProductosBindingSource.MoveLast()

        Else : Return

        End If

    End Sub









    ''''''''''''''''''''''''''''''''    PURGADO TOTAL DE BD

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

        confirmacion = MsgBox("Esta seguro que desea eliminar TODOS los registros de [Productos], y las [Ventas] y [Compras] asociados a los mismos: ESTA ACCION ES PERMANENTE", MsgBoxStyle.YesNo, MsgBoxStyle.Critical)

        If confirmacion = MsgBoxResult.Yes Then

            Me.VentasTableAdapter.Purgar()

            Me.ComprasTableAdapter.Purgar()

            Me.ProductosTableAdapter.Purgar()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosBindingSource.EndEdit()

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

            MsgBox("TODOS los registros fueron eliminados de [Productos] [Compras] y [Ventas]", MsgBoxStyle.MsgBoxRight)

            Me.ProductosBindingSource.MoveLast()

        Else

            Return

        End If

    End Sub










    ''''''''''''''''''''''''''''''''    Manejo de Grillas y Filtros

    Private Sub TextBoxConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxConsulta.TextChanged

        Dim vista As New DataView()

        vista.Table = Me.BazarDataSet.Productos

        ' Validamos que el filtrado no sea ejecutado al estar el TextBox vacio
        If String.IsNullOrEmpty(TextBoxConsulta.Text) Then

            vista.RowFilter = ""

            Me.ProductosDataGridView.DataSource = vista

            Exit Sub

        End If

        ' Filtramos casteando a string
        vista.RowFilter = "CONVERT(" & ComboBoxAtributo.Text & ", 'System.String') LIKE '" & TextBoxConsulta.Text & "%'"

        ' Aplicamos a la grilla
        Me.ProductosDataGridView.DataSource = vista

    End Sub

    Private Sub ProductosDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick

        If e.RowIndex < 0 Then Return

        Dim fila As Integer = e.RowIndex

        Dim stringIdProducto As String = ProductosDataGridView.Item(0, fila).Value.ToString()

        Dim nombreProducto As String = ProductosDataGridView.Item(1, fila).Value.ToString()

        Dim mensaje As String = "Producto: " & nombreProducto & Environment.NewLine & Environment.NewLine &
                        "¿A qué formulario transferir los datos?" & Environment.NewLine &
                        "• Sí = VENTAS" & Environment.NewLine &
                        "• No = COMPRAS" & Environment.NewLine &
                        "• Cancelar = Salir"

        Dim resultado As DialogResult = MessageBox.Show(
          mensaje,
          "Transferir datos del producto",
          MessageBoxButtons.YesNoCancel,
          MessageBoxIcon.Question)

        Select Case resultado

            Case DialogResult.Yes

                Ventas.Show()

                Ventas.ProductoComboBox.SelectedValue = Val(stringIdProducto)

                Ventas.ProductoComboBox.Focus()

                Me.Close()

            Case DialogResult.No

                Compras.Show()

                Compras.ProductoComboBox.Text = stringIdProducto

                Compras.ProductoComboBox.Focus()

                Me.Close()

            Case DialogResult.Cancel

                ' No Hacer Nada

        End Select

    End Sub











    ''''''''''''''''''''''''''''''''    Validaciones Campos y Tipos de Datos
    Private Sub NombreTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles NombreTextBox.KeyPress

        If LetrasNumerosPuntos(e) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub

    Private Sub CategoriaTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CategoriaTextBox.KeyPress

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





    Private Sub TextBoxID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxID.KeyPress

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

        Close()

        Inicio.Show()

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click

        Close()

        Ventas.Show()

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasToolStripMenuItem.Click

        Close()

        Compras.Show()

    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactoToolStripMenuItem.Click

        Close()

        Contacto.Show()

    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        End

    End Sub


End Class