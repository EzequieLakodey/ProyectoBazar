Public Class Compras






    ''''''''''''''''''''''''''''''''    Carga del Form

    Private Sub Compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.ComprasBindingSource.AddNew()

        Me.ComprasBindingSource.MoveLast()

        TextBoxConsulta.Text = ID_ProveedorTextBox.Text

    End Sub








    ''''''''''''''''''''''''''''''''    Declaracion de variables

    Dim confirmacion As Boolean

    Dim idProveedor, cantidad, posicion As Long

    Dim precioUnitario, subTotal, total As Decimal

    Dim fila As DataRowView














    ''''''''''''''''''''''''''''''''    Busqueda de Proveedores por ID

    Function BuscarProveedor() As Integer

        idProveedor = CLng(TextBoxConsulta.Text)

        If idProveedor >= 0 Then

            posicion = Me.ComprasBindingSource.Find("ID_Proveedor", idProveedor)

            Me.ComprasBindingSource.Position = posicion

            Return posicion

        End If

        Return 0

    End Function






    ''''''''''''''''''''''''''''''''    Eventos de Busquedas


    Private Sub ButtonBuscar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBuscar.Click

        BuscarProveedor()

    End Sub


    Private Sub ID_ProveedorTextBox_TextChanged(sender As System.Object, e As System.EventArgs)

        TextBoxConsulta.Text = ID_ProveedorTextBox.Text

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

        'Me.ProductosBindingSource.AddNew()

        'Me.ProductosBindingSource.Current("Nombre") = ProductoComboBox.Text

        'Me.ProductosBindingSource.EndEdit()

        'Me.ProductosTableAdapter.Update(Me.BazarDataSet.Productos)

        'Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ComprasBindingSource.Current("ID_Producto") = ProductoComboBox.SelectedValue

        Me.ComprasBindingSource.Current("Proveedor") = ProveedorComboBox.Text

        Me.ComprasBindingSource.Current("Fecha") = FechaDateTimePicker.Value

        Me.ComprasBindingSource.Current("Cantidad") = Val(CantidadTextBox.Text)

        Me.ComprasBindingSource.Current("PrecioUnitario") = Val(PrecioUnitarioTextBox.Text)

        Me.ComprasBindingSource.Current("SubTotal") = Val(SubTotalTextBox.Text)

        Me.ComprasBindingSource.Current("Total") = Val(TotalTextBox.Text)

        Me.ProductosBindingSource.Current("Stock") = Me.ProductosBindingSource.Current("Stock") + Val(CantidadTextBox.Text)

        Me.ProductosBindingSource.EndEdit()

        Me.ComprasBindingSource.EndEdit()

        Me.ComprasTableAdapter.Update(Me.BazarDataSet.Compras)

        Me.ProductosTableAdapter.Update(Me.BazarDataSet.Productos)

        Me.ProductosTableAdapter.Fill(Me.BazarDataSet.Productos)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        ProductosTableAdapter.Fill(Productos.BazarDataSet.Productos)

        ProductosTableAdapter.Fill(Ventas.BazarDataSet.Productos)

        Me.ComprasBindingSource.AddNew()

        Me.ComprasBindingSource.MoveLast()

        Me.Refresh()

    End Sub










    ''''''''''''''''''''''''''''''''    MODIFICACIONES

    Private Sub ButtonModificar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonModificar.Click

        Me.ComprasBindingSource.EndEdit()

        Me.TableAdapterManager.UpdateAll(Me.BazarDataSet)

        Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

        Me.Refresh()

    End Sub









    ''''''''''''''''''''''''''''''''    BAJAS POR ID

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

        Me.ComprasBindingSource.AddNew()

        Me.ComprasBindingSource.MoveLast()

    End Sub








    ''''''''''''''''''''''''''''''''    PURGADO TOTAL DE BD

    Private Sub ButtonPurgar_Click(sender As System.Object, e As System.EventArgs) Handles ButtonPurgar.Click

        BuscarProveedor()

        confirmacion = MsgBox("Esta seguro que desea eliminar TODOS los registros de [Proveedores], esta accion es PERMANENTE", MsgBoxStyle.YesNo, MsgBoxStyle.Critical)

        If confirmacion Then

            Me.ComprasTableAdapter.Purgar()

            Me.ComprasTableAdapter.Fill(Me.BazarDataSet.Compras)

            MsgBox("TODOS los registros fueron eliminados de [Proveedores]", MsgBoxStyle.MsgBoxRight)

        End If

        Me.Refresh()

        Me.ComprasBindingSource.AddNew()

        Me.ComprasBindingSource.MoveLast()

    End Sub










    ''''''''''''''''''''''''''''''''    Navegacion

    Private Sub ButtonAnterior_Click(sender As System.Object, e As System.EventArgs) Handles ButtonAnterior.Click

        ComprasBindingSource.MoveNext()

    End Sub

    Private Sub ButtonSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSiguiente.Click

        ComprasBindingSource.MoveNext()

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

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.ComprasTableAdapter.FillBy(Me.BazarDataSet.Compras)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    
End Class