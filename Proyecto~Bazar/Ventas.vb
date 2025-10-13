Public Class Ventas


    ''''''''''''''''''''''''''''''''    Carga del Form

    Private Sub Ventas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

        Me.VentasBindingSource.MoveLast()

        TextBoxID.Text = ID_ClienteTextBox.Text

        FechaDateTimePicker.Value = DateTime.Now

        ' Poblacion del ComboBoxAtributo
        CargarColumnasEnComboBox(BazarDataSet.Tables("Ventas"), ComboBoxAtributo)


        BuscarProducto()



        ''''''''''''''''''''''''''''''''''''''''''''''''''''''' CODIGO EN STANDBY:
        ' Creamos una vista de datos
        'Dim vistaVentas As New DataView(Me.BazarDataSet.Ventas)

        ' Creamos una tabla nueva en base a la vista, seleccionando valores unicos para el atributo "Cliente"
        'Dim tablaClientesUnicos As DataTable = vistaVentas.ToTable(True, "Cliente")

        ' Asignamos los valores unicos filtrados en la vista al ComboBox
        'ComboBoxClientes.DataSource = tablaClientesUnicos

        ' Configurar el ComboBox con esta nueva fuente de datos
        ' ComboBoxClientes.DataSource = tablaClientesUnicos
        ' ComboBoxClientes.DisplayMember = "Cliente"  ' Lo que el usuario ve
        ' ComboBoxClientes.ValueMember = "ID_Cliente" ' El valor único subyacente

        'Obtener los datos originales (por ejemplo, de tu DataSet)
        ' Dim tablaVentas As DataTable = Me.BazarDataSet.Ventas

    End Sub








    ''''''''''''''''''''''''''''''''    Declaracion de variables

    Dim confirmacion As MsgBoxResult

    Dim idCliente, cantidad, posicion, stock, idProducto As Long

    Dim precioUnitario, subTotal, total As Decimal

    Dim fecha As DateTime

    Dim cliente As String










    ''''''''''''''''''''''''''''''''    Busqueda de Cliente por ID

    Function BuscarCliente() As Integer

        idCliente = CLng(TextBoxID.Text)

        If idCliente >= 0 Then

            posicion = Me.VentasBindingSource.Find("ID_Cliente", idCliente)

            Me.VentasBindingSource.Position = posicion

            Return posicion

        End If

        Return 0

    End Function



    Function BuscarProducto() As Integer

        Try

            posicion = Me.ProductosBindingSource.Find("ID_Producto", ProductoComboBox.SelectedValue)

            Me.ProductosBindingSource.Position = posicion

            TextBoxStock.Text = Me.ProductosBindingSource.Current("Stock")

            Return posicion

        Catch ex As Exception

            Return -1

        End Try

        Return 0

    End Function









    ''''''''''''''''''''''''''''''''    Eventos de Busquedas


    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBuscar.Click

        BuscarCliente()

    End Sub



    Private Sub ID_ClienteTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID_ClienteTextBox.TextChanged

        TextBoxID.Text = ID_ClienteTextBox.Text

    End Sub


    Private Sub ProductoComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ProductoComboBox.SelectedIndexChanged

        BuscarProducto()

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










    ''''''''''''''''''''''''''''''''    Eventos Aritmeticos

    Private Sub CantidadTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CantidadTextBox.TextChanged

        CalcularImportes()

    End Sub



    Private Sub PrecioUnitarioTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PrecioUnitarioTextBox.TextChanged

        CalcularImportes()

    End Sub











    Private Sub ButtonCrear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCrear.Click

        'Me.VentasBindingSource.Current("ID_Producto") = ProductoComboBox.SelectedValue

        'Me.VentasBindingSource.Current("Cliente") = ClienteTextBox.Text

        'Me.VentasBindingSource.Current("Fecha") = FechaDateTimePicker.Value

        'Me.VentasBindingSource.Current("Cantidad") = Val(CantidadTextBox.Text)

        'Me.VentasBindingSource.Current("PrecioUnitario") = Val(PrecioUnitarioTextBox.Text)

        'Me.VentasBindingSource.Current("SubTotal") = Val(SubTotalTextBox.Text)

        'Me.VentasBindingSource.Current("Total") = Val(TotalTextBox.Text)

        'Me.VentasBindingSource.Current("Cantidad") = cantidad

        FechaDateTimePicker.Value = DateTime.Now

        stock = Me.ProductosBindingSource.Current("Stock")

        idProducto = ProductoComboBox.SelectedValue

        cliente = ClienteTextBox.Text

        fecha = FechaDateTimePicker.Value

        cantidad = Val(CantidadTextBox.Text)

        precioUnitario = Val(PrecioUnitarioTextBox.Text)

        subTotal = Val(SubTotalTextBox.Text)

        total = Val(TotalTextBox.Text)

        If cantidad <= stock Then

            Me.VentasTableAdapter.Insert(
            idProducto,
            cliente,
            fecha,
            cantidad,
            precioUnitario,
            subTotal,
            total
                                        )

            Me.ProductosBindingSource.Current("Stock") = stock - cantidad

            Me.ProductosBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.VentasBindingSource.MoveLast()

        Else

            MsgBox("No hay Stock suficiente del Producto para realizar la venta | ID Producto: " & ProductoComboBox.SelectedValue & " | Nombre : " & ProductoComboBox.Text, MsgBoxStyle.Exclamation)

        End If

    End Sub




    ''''''''''''''''''''''''''''''''    MODIFICACIONES

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

        Dim cantidadInicial As Long = Val(Convert.ToString(Me.VentasBindingSource.Current("Cantidad")))

        cantidad = Val(CantidadTextBox.Text)

        stock = Me.ProductosBindingSource.Current("Stock")

        Dim diferenciaCantidades As Long = cantidad - cantidadInicial

        ' Validar stock suficiente si se aumenta la cantidad
        If diferenciaCantidades > 0 And diferenciaCantidades > stock Then

            MsgBox("No hay Stock suficiente del Producto para realizar la modificación | Stock disponible: " & stock, MsgBoxStyle.Exclamation)

            Return

        End If

        ' ACTUALIZAR STOCK:
        ' Si diferencia > 0: stockActual - diferencia = RESTAR
        ' Si diferencia < 0: stockActual - (-diferencia) = SUMAR
        If diferenciaCantidades <> 0 Then

            Me.ProductosBindingSource.Current("Stock") = stock - diferenciaCantidades

        End If

        Me.VentasBindingSource.Current("Cantidad") = cantidad

            Me.VentasBindingSource.EndEdit()

            Me.ProductosBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            Me.VentasBindingSource.MoveLast()

    End Sub









    ''''''''''''''''''''''''''''''''    BAJAS POR ID

    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEliminar.Click

        BuscarCliente()

        confirmacion = MsgBox("Esta seguro que desea eliminar el CLIENTE = " & ID_ClienteTextBox.Text & " | " & ClienteTextBox.Text, MsgBoxStyle.YesNo)

        If confirmacion = MsgBoxResult.Yes Then

            Me.ProductosBindingSource.Current("Stock") = Me.ProductosBindingSource.Current("Stock") + Me.VentasBindingSource.Current("Cantidad")

            Me.VentasBindingSource.RemoveCurrent()

            Me.ProductosBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            MsgBox("Registro eliminado correctamente", MsgBoxStyle.MsgBoxRight)

            Me.VentasBindingSource.MoveLast()

        Else : Return

        End If

    End Sub








    ''''''''''''''''''''''''''''''''    PURGADO TOTAL DE BD

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

        confirmacion = MsgBox("Esta seguro que desea eliminar TODOS los registros de [Clientes], esta accion es PERMANENTE", MsgBoxStyle.YesNo, MsgBoxStyle.Critical)

        If confirmacion = MsgBoxResult.Yes Then

            Me.VentasTableAdapter.Purgar()

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.VentasTableAdapter.Fill(Me.BazarDataSet.Ventas)

            ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            ProductosTableAdapter.Fill(Compras.BazarDataSet.Productos)

            MsgBox("TODOS los registros fueron eliminados de [Clientes]", MsgBoxStyle.MsgBoxRight)

            Me.VentasBindingSource.MoveLast()

        Else : Return

        End If

    End Sub

    ''''''''''''''''''''''''''''''''    Manejo de Grillas y Filtros

    Private Sub TextBoxConsulta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxConsulta.TextChanged

        Dim vista As New DataView()

        vista.Table = Me.BazarDataSet.Ventas

        ' Validamos que el filtrado no sea ejecutado al estar el TextBox vacio
        If String.IsNullOrEmpty(TextBoxConsulta.Text) Then

            vista.RowFilter = ""

            Me.VentasDataGridView.DataSource = vista

            Exit Sub

        End If

        ' Filtramos casteando a string
        vista.RowFilter = "CONVERT(" & ComboBoxAtributo.Text & ", 'System.String') LIKE '" & TextBoxConsulta.Text & "%'"

        ' Aplicamos a la grilla
        Me.VentasDataGridView.DataSource = vista

    End Sub






    ''''''''''''''''''''''''''''''''    Validaciones Campos y Tipos de Datos


    Private Sub ClienteTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ClienteTextBox.KeyPress

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




    Private Sub ProductoComboBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ProductoComboBox.KeyPress

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








    Private Sub TextBoxID_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxID.KeyPress

        If SoloNumerosEnteros(e) Then

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

        Close()

        Inicio.Show()

    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComprasToolStripMenuItem.Click

        Close()

        Compras.Show()

    End Sub



    Private Sub ProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductosToolStripMenuItem.Click

        Close()

        Productos.Show()

    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactoToolStripMenuItem.Click

        Close()

        Contacto.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        End

    End Sub


End Class