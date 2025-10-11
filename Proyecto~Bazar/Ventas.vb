Public Class Ventas


    ''''''''''''''''''''''''''''''''    Carga del Form

    Private Sub Ventas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

        Me.VentasBindingSource.AddNew()

        Me.VentasBindingSource.MoveLast()

        FechaDateTimePicker.Value = DateTime.Now

        ' Poblacion del ComboBoxAtributo
        CargarColumnasEnComboBox(BazarDataSet.Tables("Ventas"), ComboBoxAtributo)

    End Sub








    ''''''''''''''''''''''''''''''''    Declaracion de variables

    Dim confirmacion As Boolean

    Dim idCliente, cantidad, posicion, stock As Long

    Dim precioUnitario, subTotal, total As Decimal










    ''''''''''''''''''''''''''''''''    Busqueda de Cliente por ID

    Function BuscarCliente() As Integer

        idCliente = CLng(TextBoxConsulta.Text)

        If idCliente >= 0 Then

            posicion = Me.VentasBindingSource.Find("ID_Proveedor", idCliente)

            Me.VentasBindingSource.Position = posicion

            Return posicion

        End If

        Return 0

    End Function










    ''''''''''''''''''''''''''''''''    Eventos de Busquedas


    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBuscar.Click

        BuscarCliente()

    End Sub


    Private Sub ID_ClienteTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID_ClienteTextBox.TextChanged

        TextBoxConsulta.Text = ID_ClienteTextBox.Text

    End Sub









    ''''''''''''''''''''''''''''''''    Limpieza de Totales 

    Sub LimpiarImportes()

        SubTotalTextBox.Text = "0.00"

        TotalTextBox.Text = "0.00"

    End Sub










    ''''''''''''''''''''''''''''''''    Funcion para Calcular SubTotales y Totales

    Sub CalcularImportes()

        Dim Iva As Decimal = 0.21D

        If String.IsNullOrWhiteSpace(CantidadTextBox.Text) OrElse String.IsNullOrWhiteSpace(PrecioUnitarioTextBox.Text) Then

            LimpiarImportes()

            Return

        End If

        cantidad = CLng(CantidadTextBox.Text)

        precioUnitario = Convert.ToDecimal(PrecioUnitarioTextBox.Text)

        If precioUnitario <= 0 Or cantidad <= 0 Then

            LimpiarImportes()

            Return

        End If

        subTotal = cantidad * precioUnitario

        Iva = subTotal * Iva

        total = subTotal + Iva

        SubTotalTextBox.Text = subTotal.ToString("F2")

        TotalTextBox.Text = total.ToString("F2")

    End Sub









    ''''''''''''''''''''''''''''''''    Funcion para Calcular Stock









    ''''''''''''''''''''''''''''''''    Eventos Aritmeticos

    Private Sub CantidadTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CantidadTextBox.TextChanged

        CalcularImportes()

    End Sub



    Private Sub PrecioUnitarioTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PrecioUnitarioTextBox.TextChanged

        CalcularImportes()

    End Sub








    Private Sub ButtonCrear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCrear.Click

        'Me.ProductosBindingSource.AddNew()

        'Me.ProductosBindingSource.Current("Nombre") = ProductoComboBox.Text

        'Me.ProductosBindingSource.EndEdit()

        'Me.ProductosTableAdapter.Update(Me.BazarDataSet.Productos)

        'Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        stock = Me.ProductosBindingSource.Current("Stock")

        cantidad = Val(CantidadTextBox.Text)

        If cantidad <= stock Then

            Me.VentasBindingSource.Current("ID_Producto") = ProductoComboBox.SelectedValue

            Me.VentasBindingSource.Current("Cliente") = ClienteComboBox.Text

            Me.VentasBindingSource.Current("Fecha") = FechaDateTimePicker.Value

            Me.VentasBindingSource.Current("Cantidad") = Val(CantidadTextBox.Text)

            Me.VentasBindingSource.Current("PrecioUnitario") = Val(PrecioUnitarioTextBox.Text)

            Me.VentasBindingSource.Current("SubTotal") = Val(SubTotalTextBox.Text)

            Me.VentasBindingSource.Current("Total") = Val(TotalTextBox.Text)

            Me.VentasBindingSource.Current("Cantidad") = cantidad

            Me.ProductosBindingSource.Current("Stock") = stock - cantidad

            Me.VentasBindingSource.EndEdit()

            Me.ProductosBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.VentasBindingSource.AddNew()

            Me.Refresh()

            Me.VentasBindingSource.MoveLast()

        Else

            MsgBox("No hay Stock suficiente del Producto para realizar la venta | ID Producto: " & ProductoComboBox.SelectedValue & " | Nombre : " & ProductoComboBox.Text, MsgBoxStyle.Exclamation)

        End If

    End Sub




    ''''''''''''''''''''''''''''''''    MODIFICACIONES

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

        cantidad = Val(CantidadTextBox.Text)

        stock = Me.ProductosBindingSource.Current("Stock")

        If cantidad <= stock Then

            Me.ProductosBindingSource.Current("Stock") = stock - cantidad

            Me.VentasBindingSource.EndEdit()

            Me.ProductosBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.Refresh()

            Me.VentasBindingSource.MoveLast()

        Else

            MsgBox("No hay Stock suficiente del Producto para realizar la venta | ID Producto: " & ProductoComboBox.SelectedValue & " | Nombre : " & ProductoComboBox.Text, MsgBoxStyle.Exclamation)

        End If

    End Sub









    ''''''''''''''''''''''''''''''''    BAJAS POR ID

    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEliminar.Click

        BuscarCliente()

        confirmacion = MsgBox("Esta seguro que desea eliminar el CLIENTE = " & ID_ClienteTextBox.Text & " | " & ClienteComboBox.Text, MsgBoxStyle.YesNo)

        If confirmacion Then

            Me.ventasbindingsource.RemoveCurrent()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            MsgBox("Registro eliminado correctamente", MsgBoxStyle.MsgBoxRight)

            Me.VentasBindingSource.AddNew()

            Me.Refresh()

            Me.VentasBindingSource.MoveLast()

        End If

    End Sub








    ''''''''''''''''''''''''''''''''    PURGADO TOTAL DE BD

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

        BuscarCliente()

        confirmacion = MsgBox("Esta seguro que desea eliminar TODOS los registros de [Clientes], esta accion es PERMANENTE", MsgBoxStyle.YesNo, MsgBoxStyle.Critical)

        If confirmacion Then

            Me.VentasTableAdapter.Purgar()

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            MsgBox("TODOS los registros fueron eliminados de [Clientes]", MsgBoxStyle.MsgBoxRight)

            Me.VentasBindingSource.AddNew()

            Me.Refresh()

            Me.VentasBindingSource.MoveLast()

        End If

    End Sub

    ''''''''''''''''''''''''''''''''    Manejo de Grillas y Filtros

    Private Sub TextBoxConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxConsulta.TextChanged

        ' Crear DataView correctamente desde el BindingSource
        Dim vista As DataView = New DataView(Me.BazarDataSet.Ventas)

        ' Validar que hay un atributo seleccionado
        If String.IsNullOrEmpty(ComboBoxAtributo.Text) Then
            Exit Sub
        End If

        ' Aplicar filtro - forma correcta para VB.NET 4.0
        vista.RowFilter = ComboBoxAtributo.Text & " LIKE '" & TextBoxConsulta.Text & "%'"

        ' Asignar al DataGridView
        Me.VentasDataGridView.DataSource = vista

    End Sub


    ''''''''''''''''''''''''''''''''    Validaciones Campos y Tipos de Datos

    Private Sub ProductoComboBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ProductoComboBox.KeyPress

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

    Private Sub ClienteComboBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ClienteComboBox.KeyPress

        If LetrasNumerosPuntos(e) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub




    Private Sub CantidadTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CantidadTextBox.KeyPress

        If SoloNumerosEnteros(e) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub




    Private Sub PrecioUnitarioTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles PrecioUnitarioTextBox.KeyPress

        If SoloNumerosDecimales(e, PrecioUnitarioTextBox.Text) Then

            e.Handled = False

        Else

            e.Handled = True

        End If

    End Sub


 




    ''''''''''''''''''''''''''''''''    Navegacion

    Private Sub ButtonUltimoItem_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUltimoItem.Click

        Me.VentasBindingSource.MoveLast()

    End Sub

    Private Sub ButtonAnterior_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnterior.Click

        VentasBindingSource.MovePrevious()

    End Sub

    Private Sub ButtonPrimerItem_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPrimerItem.Click

        Me.VentasBindingSource.MoveFirst()

    End Sub

    Private Sub ButtonSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSiguiente.Click

        VentasBindingSource.MoveNext()

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InicioToolStripMenuItem.Click

        Me.Hide()

        Inicio.Show()

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