Public Class Compras






    ''''''''''''''''''''''''''''''''    Carga del Form

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.ProductosBindingSource.EndEdit()

        Me.ComprasBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.ComprasBindingSource.MoveLast()

        TextBoxID.Text = ID_ProveedorTextBox.Text

        FechaDateTimePicker.Value = DateTime.Now

        ' Poblacion del ComboBoxAtributo
        CargarColumnasEnComboBox(BazarDataSet.Tables("Compras"), ComboBoxAtributo)

        BuscarProducto()


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''' CODIGO EN STANDBY:
        ' Creamos una vista de datos
        ' Dim vistaCompras As New DataView(Me.BazarDataSet.Ventas)

        ' Creamos una tabla nueva en base a la vista, seleccionando valores unicos para el atributo "Cliente"
        ' Dim tablaProveedoresUnicos As DataTable = vistaCompras.ToTable(True, "Proveedor")

        ' Asignamos los valores unicos filtrados en la vista al ComboBox
        ' ProveedorComboBox.DataSource = tablaProveedoresUnicos

        ' Configurar el ComboBox con esta nueva fuente de datos
        ' ProveedorComboBox.DataSource = tablaProveedoresUnicos
        ' ProveedorComboBox.DisplayMember = "Proveedor"  ' Lo que el usuario ve
        ' ProveedorComboBox.ValueMember = "ID_Proveedor" ' El valor único subyacente

        ' Obtener los datos originales (por ejemplo, de tu DataSet)
        ' Dim tablaVentas As DataTable = Me.BazarDataSet.Ventas

    End Sub








    ''''''''''''''''''''''''''''''''    Declaracion de variables

    Dim confirmacion As MsgBoxResult

    Dim idProveedor, cantidad, posicion, stock, idProducto As Long

    Dim precioUnitario, subTotal, total As Decimal

    Dim fecha As DateTime

    Dim proveedor As String













    ''''''''''''''''''''''''''''''''    Busqueda de Proveedores por ID

    Function BuscarProveedor() As Integer

        idProveedor = Val(TextBoxID.Text)

        If idProveedor >= 0 Then

            posicion = Me.ComprasBindingSource.Find("ID_Proveedor", idProveedor)

            Me.ComprasBindingSource.Position = posicion

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

        BuscarProveedor()

    End Sub


    Private Sub ID_ProveedorTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles ID_ProveedorTextBox.TextChanged

        TextBoxID.Text = ID_ProveedorTextBox.Text

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













    ''''''''''''''''''''''''''''''''    ALTAS

    Private Sub ButtonCrear_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCrear.Click

        'Me.ComprasBindingSource.Current("ID_Producto") = ProductoComboBox.SelectedValue

        'Me.ComprasBindingSource.Current("Proveedor") = ProveedorTextBox.Text

        'Me.ComprasBindingSource.Current("Fecha") = FechaDateTimePicker.Value

        'Me.ComprasBindingSource.Current("Cantidad") = Val(CantidadTextBox.Text)

        'Me.ComprasBindingSource.Current("PrecioUnitario") = Val(PrecioUnitarioTextBox.Text)

        'Me.ComprasBindingSource.Current("SubTotal") = Val(SubTotalTextBox.Text)

        'Me.ComprasBindingSource.Current("Total") = Val(TotalTextBox.Text)

        'Me.ProductosBindingSource.Current("Stock") = ProductosBindingSource.Current("Stock") + Val(CantidadTextBox.Text)

        FechaDateTimePicker.Value = DateTime.Now

        stock = Me.ProductosBindingSource.Current("Stock")

        idProducto = ProductoComboBox.SelectedValue

        proveedor = ProveedorTextBox.Text

        fecha = FechaDateTimePicker.Value

        cantidad = Val(CantidadTextBox.Text)

        precioUnitario = Val(PrecioUnitarioTextBox.Text)

        subTotal = Val(SubTotalTextBox.Text)

        total = Val(TotalTextBox.Text)

        Me.ComprasTableAdapter.Insert(
        idProducto,
        proveedor,
        fecha,
        cantidad,
        precioUnitario,
        subTotal,
        total
        )

        Me.ProductosBindingSource.Current("Stock") = stock + cantidad

        Me.ProductosBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

        ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

        Me.ComprasBindingSource.MoveLast()

        BuscarProducto()

    End Sub










    ''''''''''''''''''''''''''''''''    MODIFICACIONES

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

        Dim cantidadInicial As Long = Val(Convert.ToString(Me.ComprasBindingSource.Current("Cantidad")))

        cantidad = Val(CantidadTextBox.Text)

        stock = Me.ProductosBindingSource.Current("Stock")

        Dim diferenciaCantidades As Long = cantidad - cantidadInicial

        ' Validar que no quede stock negativo si se disminuye la compra
        If diferenciaCantidades < 0 And Math.Abs(diferenciaCantidades) > stock Then

            MsgBox("No se puede disminuir la compra. Stock insuficiente | Stock actual: " & stock & " | Diferencia: " & Math.Abs(diferenciaCantidades), MsgBoxStyle.Exclamation)

            Return

        End If

        ' Aplicar la lógica de actualización de stock (INVERSA A VENTAS)
        If diferenciaCantidades <> 0 Then
            ' Si la nueva cantidad es mayor: SUMAR diferencia al stock
            ' Si la nueva cantidad es menor: RESTAR diferencia al stock
            Me.ProductosBindingSource.Current("Stock") = stock + diferenciaCantidades
        End If

        Me.ComprasBindingSource.EndEdit()

        Me.ProductosBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

        Me.ComprasBindingSource.MoveLast()

    End Sub









    ''''''''''''''''''''''''''''''''    BAJAS POR ID

    Private Sub ButtonEliminar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEliminar.Click

        BuscarProveedor()

        confirmacion = MsgBox("Esta seguro que desea eliminar el PROVEEDOR = " & ID_ProveedorTextBox.Text & " | " & ProveedorTextBox.Text, MsgBoxStyle.YesNo)

        If confirmacion = MsgBoxResult.Yes Then

            Me.ComprasBindingSource.RemoveCurrent()

            Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

            Me.ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

            MsgBox("Registro eliminado correctamente!", MsgBoxStyle.MsgBoxRight)

            Me.ComprasBindingSource.MoveLast()

        Else : Return

        End If



    End Sub








    ''''''''''''''''''''''''''''''''    PURGADO TOTAL DE BD

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

        BuscarProveedor()

        confirmacion = MsgBox("Esta seguro que desea eliminar TODOS los registros de [Compras], esta accion es PERMANENTE", MsgBoxStyle.YesNo)

        If confirmacion = MsgBoxResult.Yes Then

            Me.ComprasTableAdapter.Purgar()

            Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

            Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

            Me.ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

            Me.ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

            MsgBox("TODOS los registros fueron eliminados de [Proveedores]", MsgBoxStyle.MsgBoxRight)

            Me.ComprasBindingSource.MoveLast()

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

            Me.ComprasDataGridView.DataSource = vista

            Exit Sub

        End If

        ' Filtramos casteando a string
        vista.RowFilter = "CONVERT(" & ComboBoxAtributo.Text & ", 'System.String') LIKE '" & TextBoxConsulta.Text & "%'"

        ' Aplicamos a la grilla
        Me.ComprasDataGridView.DataSource = vista

    End Sub










    ''''''''''''''''''''''''''''''''    Validaciones Campos y Tipos de Datos

    Private Sub ProductoComboBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles ProductoComboBox.KeyPress

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




    Private Sub ProveedorComboBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)

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

        Me.ComprasBindingSource.MoveLast()

    End Sub

    Private Sub ButtonAnterior_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnterior.Click

        ComprasBindingSource.MovePrevious()

    End Sub

    Private Sub ButtonPrimerItem_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPrimerItem.Click

        Me.ComprasBindingSource.MoveFirst()

    End Sub

    Private Sub ButtonSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSiguiente.Click

        Me.ComprasBindingSource.MoveNext()

    End Sub



    Private Sub InicioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InicioToolStripMenuItem.Click

        Inicio.Show()

        Close()

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VentasToolStripMenuItem.Click

        Ventas.Show()

        Close()

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProductosToolStripMenuItem.Click

        Productos.Show()

        Close()

    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ContactoToolStripMenuItem.Click

        Contacto.Show()

        Close()

    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        End

    End Sub


    Private Sub ComprasBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles ComprasBindingSource.CurrentChanged

        BuscarProducto()

    End Sub

End Class