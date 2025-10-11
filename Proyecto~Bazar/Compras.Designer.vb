<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LabelBuscar As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ID_ProveedorLabel As System.Windows.Forms.Label
        Dim ProveedorLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioUnitarioLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim ID_ProductoLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Me.Panel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonUltimoItem = New System.Windows.Forms.Button()
        Me.ButtonPrimerItem = New System.Windows.Forms.Button()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarDataSet = New Proyecto_Bazar.BazarDataSet()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ID_ProveedorTextBox = New System.Windows.Forms.TextBox()
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ProductoComboBox = New System.Windows.Forms.ComboBox()
        Me.ButtonSiguiente = New System.Windows.Forms.Button()
        Me.ButtonPurgar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonCrear = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonAnterior = New System.Windows.Forms.Button()
        Me.TextBoxConsulta = New System.Windows.Forms.TextBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ComprasDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopMenu = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasTableAdapter = New Proyecto_Bazar.BazarDataSetTableAdapters.ComprasTableAdapter()
        Me.TableAdapterManager = New Proyecto_Bazar.BazarDataSetTableAdapters.TableAdapterManager()
        Me.ProductosTableAdapter = New Proyecto_Bazar.BazarDataSetTableAdapters.ProductosTableAdapter()
        LabelBuscar = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ID_ProveedorLabel = New System.Windows.Forms.Label()
        ProveedorLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioUnitarioLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBuscar
        '
        LabelBuscar.AutoSize = True
        LabelBuscar.BackColor = System.Drawing.Color.Transparent
        LabelBuscar.ForeColor = System.Drawing.Color.White
        LabelBuscar.Location = New System.Drawing.Point(219, 410)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New System.Drawing.Size(147, 17)
        LabelBuscar.TabIndex = 52
        LabelBuscar.Text = "Buscar Proveedor"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.Color.White
        NombreLabel.Location = New System.Drawing.Point(93, 205)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(85, 17)
        NombreLabel.TabIndex = 92
        NombreLabel.Text = "Producto:"
        '
        'ID_ProveedorLabel
        '
        ID_ProveedorLabel.AutoSize = True
        ID_ProveedorLabel.ForeColor = System.Drawing.Color.White
        ID_ProveedorLabel.Location = New System.Drawing.Point(64, 111)
        ID_ProveedorLabel.Name = "ID_ProveedorLabel"
        ID_ProveedorLabel.Size = New System.Drawing.Size(114, 17)
        ID_ProveedorLabel.TabIndex = 93
        ID_ProveedorLabel.Text = "ID Proveedor:"
        '
        'ProveedorLabel
        '
        ProveedorLabel.AutoSize = True
        ProveedorLabel.ForeColor = System.Drawing.Color.White
        ProveedorLabel.Location = New System.Drawing.Point(84, 79)
        ProveedorLabel.Name = "ProveedorLabel"
        ProveedorLabel.Size = New System.Drawing.Size(94, 17)
        ProveedorLabel.TabIndex = 97
        ProveedorLabel.Text = "Proveedor:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.ForeColor = System.Drawing.Color.White
        FechaLabel.Location = New System.Drawing.Point(117, 237)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(61, 17)
        FechaLabel.TabIndex = 99
        FechaLabel.Text = "Fecha:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.ForeColor = System.Drawing.Color.White
        CantidadLabel.Location = New System.Drawing.Point(95, 269)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(83, 17)
        CantidadLabel.TabIndex = 101
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioUnitarioLabel
        '
        PrecioUnitarioLabel.AutoSize = True
        PrecioUnitarioLabel.ForeColor = System.Drawing.Color.White
        PrecioUnitarioLabel.Location = New System.Drawing.Point(51, 301)
        PrecioUnitarioLabel.Name = "PrecioUnitarioLabel"
        PrecioUnitarioLabel.Size = New System.Drawing.Size(127, 17)
        PrecioUnitarioLabel.TabIndex = 103
        PrecioUnitarioLabel.Text = "Precio Unitario:"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.ForeColor = System.Drawing.Color.White
        SubTotalLabel.Location = New System.Drawing.Point(92, 333)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(86, 17)
        SubTotalLabel.TabIndex = 105
        SubTotalLabel.Text = "Sub Total:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.ForeColor = System.Drawing.Color.White
        TotalLabel.Location = New System.Drawing.Point(127, 365)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(51, 17)
        TotalLabel.TabIndex = 107
        TotalLabel.Text = "Total:"
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.ForeColor = System.Drawing.Color.White
        ID_ProductoLabel.Location = New System.Drawing.Point(73, 143)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(105, 17)
        ID_ProductoLabel.TabIndex = 95
        ID_ProductoLabel.Text = "ID Producto:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.ForeColor = System.Drawing.Color.White
        CategoriaLabel.Location = New System.Drawing.Point(90, 174)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(88, 17)
        CategoriaLabel.TabIndex = 109
        CategoriaLabel.Text = "Categoria:"
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel.Controls.Add(Me.SplitContainer1)
        Me.Panel.Controls.Add(Me.TopMenu)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.ForeColor = System.Drawing.Color.Black
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1274, 691)
        Me.Panel.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 92)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonUltimoItem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonPrimerItem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CategoriaComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(CategoriaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ProductoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ID_ProveedorLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ProveedorTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ID_ProductoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(ProveedorLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProveedorComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(FechaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.SplitContainer1.Panel1.Controls.Add(CantidadLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CantidadTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(PrecioUnitarioLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PrecioUnitarioTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(SubTotalLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SubTotalTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(TotalLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TotalTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProductoComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonSiguiente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonPurgar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEliminar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCrear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonModificar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAnterior)
        Me.SplitContainer1.Panel1.Controls.Add(LabelBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxConsulta)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1274, 599)
        Me.SplitContainer1.SplitterDistance = 576
        Me.SplitContainer1.TabIndex = 1
        '
        'ButtonUltimoItem
        '
        Me.ButtonUltimoItem.BackColor = System.Drawing.Color.White
        Me.ButtonUltimoItem.ForeColor = System.Drawing.Color.Black
        Me.ButtonUltimoItem.Location = New System.Drawing.Point(303, 509)
        Me.ButtonUltimoItem.Name = "ButtonUltimoItem"
        Me.ButtonUltimoItem.Size = New System.Drawing.Size(80, 41)
        Me.ButtonUltimoItem.TabIndex = 112
        Me.ButtonUltimoItem.Text = ">>>"
        Me.ButtonUltimoItem.UseVisualStyleBackColor = False
        '
        'ButtonPrimerItem
        '
        Me.ButtonPrimerItem.BackColor = System.Drawing.Color.White
        Me.ButtonPrimerItem.ForeColor = System.Drawing.Color.Black
        Me.ButtonPrimerItem.Location = New System.Drawing.Point(183, 509)
        Me.ButtonPrimerItem.Name = "ButtonPrimerItem"
        Me.ButtonPrimerItem.Size = New System.Drawing.Size(80, 41)
        Me.ButtonPrimerItem.TabIndex = 111
        Me.ButtonPrimerItem.Text = "<<<"
        Me.ButtonPrimerItem.UseVisualStyleBackColor = False
        '
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CategoriaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Nombre", True))
        Me.CategoriaComboBox.DataSource = Me.ProductosBindingSource
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CategoriaComboBox.Location = New System.Drawing.Point(183, 166)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(200, 25)
        Me.CategoriaComboBox.TabIndex = 110
        Me.CategoriaComboBox.ValueMember = "Categoria"
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.BazarDataSet
        '
        'BazarDataSet
        '
        Me.BazarDataSet.DataSetName = "BazarDataSet"
        Me.BazarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ID_Producto", True))
        Me.ID_ProductoTextBox.Enabled = False
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(184, 134)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(199, 26)
        Me.ID_ProductoTextBox.TabIndex = 109
        '
        'ID_ProveedorTextBox
        '
        Me.ID_ProveedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "ID_Proveedor", True))
        Me.ID_ProveedorTextBox.Enabled = False
        Me.ID_ProveedorTextBox.Location = New System.Drawing.Point(183, 102)
        Me.ID_ProveedorTextBox.Name = "ID_ProveedorTextBox"
        Me.ID_ProveedorTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ID_ProveedorTextBox.TabIndex = 94
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.AllowNew = True
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.BazarDataSet
        '
        'ProveedorComboBox
        '
        Me.ProveedorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "Proveedor", True))
        Me.ProveedorComboBox.DataSource = Me.ComprasBindingSource
        Me.ProveedorComboBox.DisplayMember = "Proveedor"
        Me.ProveedorComboBox.FormattingEnabled = True
        Me.ProveedorComboBox.Location = New System.Drawing.Point(183, 71)
        Me.ProveedorComboBox.Name = "ProveedorComboBox"
        Me.ProveedorComboBox.Size = New System.Drawing.Size(200, 25)
        Me.ProveedorComboBox.TabIndex = 98
        Me.ProveedorComboBox.ValueMember = "ID_Proveedor"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(183, 228)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.FechaDateTimePicker.TabIndex = 100
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(183, 260)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CantidadTextBox.TabIndex = 102
        '
        'PrecioUnitarioTextBox
        '
        Me.PrecioUnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "PrecioUnitario", True))
        Me.PrecioUnitarioTextBox.Location = New System.Drawing.Point(183, 292)
        Me.PrecioUnitarioTextBox.Name = "PrecioUnitarioTextBox"
        Me.PrecioUnitarioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PrecioUnitarioTextBox.TabIndex = 104
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Enabled = False
        Me.SubTotalTextBox.Location = New System.Drawing.Point(183, 324)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SubTotalTextBox.TabIndex = 106
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "Total", True))
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(183, 356)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TotalTextBox.TabIndex = 108
        '
        'ProductoComboBox
        '
        Me.ProductoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ProductoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ProductoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Nombre", True))
        Me.ProductoComboBox.DataSource = Me.ProductosBindingSource
        Me.ProductoComboBox.DisplayMember = "Nombre"
        Me.ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProductoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ProductoComboBox.Location = New System.Drawing.Point(183, 197)
        Me.ProductoComboBox.Name = "ProductoComboBox"
        Me.ProductoComboBox.Size = New System.Drawing.Size(200, 25)
        Me.ProductoComboBox.TabIndex = 93
        Me.ProductoComboBox.ValueMember = "ID_Producto"
        '
        'ButtonSiguiente
        '
        Me.ButtonSiguiente.BackColor = System.Drawing.Color.Black
        Me.ButtonSiguiente.ForeColor = System.Drawing.Color.White
        Me.ButtonSiguiente.Location = New System.Drawing.Point(303, 462)
        Me.ButtonSiguiente.Name = "ButtonSiguiente"
        Me.ButtonSiguiente.Size = New System.Drawing.Size(80, 41)
        Me.ButtonSiguiente.TabIndex = 92
        Me.ButtonSiguiente.Text = ">"
        Me.ButtonSiguiente.UseVisualStyleBackColor = False
        '
        'ButtonPurgar
        '
        Me.ButtonPurgar.BackColor = System.Drawing.Color.Magenta
        Me.ButtonPurgar.ForeColor = System.Drawing.Color.Black
        Me.ButtonPurgar.Location = New System.Drawing.Point(405, 341)
        Me.ButtonPurgar.Name = "ButtonPurgar"
        Me.ButtonPurgar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonPurgar.TabIndex = 74
        Me.ButtonPurgar.Text = "Purgar"
        Me.ButtonPurgar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.Red
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.Black
        Me.ButtonEliminar.Location = New System.Drawing.Point(405, 260)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonEliminar.TabIndex = 73
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonCrear
        '
        Me.ButtonCrear.BackColor = System.Drawing.Color.LawnGreen
        Me.ButtonCrear.ForeColor = System.Drawing.Color.Black
        Me.ButtonCrear.Location = New System.Drawing.Point(405, 71)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(135, 41)
        Me.ButtonCrear.TabIndex = 72
        Me.ButtonCrear.Text = "Crear"
        Me.ButtonCrear.UseVisualStyleBackColor = False
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.Yellow
        Me.ButtonModificar.ForeColor = System.Drawing.Color.Black
        Me.ButtonModificar.Location = New System.Drawing.Point(405, 150)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonModificar.TabIndex = 71
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Cyan
        Me.ButtonBuscar.ForeColor = System.Drawing.Color.Black
        Me.ButtonBuscar.Location = New System.Drawing.Point(43, 421)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonBuscar.TabIndex = 55
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.BackColor = System.Drawing.Color.Black
        Me.ButtonAnterior.ForeColor = System.Drawing.Color.White
        Me.ButtonAnterior.Location = New System.Drawing.Point(183, 462)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(80, 41)
        Me.ButtonAnterior.TabIndex = 53
        Me.ButtonAnterior.Text = "<"
        Me.ButtonAnterior.UseVisualStyleBackColor = False
        '
        'TextBoxConsulta
        '
        Me.TextBoxConsulta.BackColor = System.Drawing.Color.White
        Me.TextBoxConsulta.ForeColor = System.Drawing.Color.Black
        Me.TextBoxConsulta.Location = New System.Drawing.Point(183, 430)
        Me.TextBoxConsulta.Name = "TextBoxConsulta"
        Me.TextBoxConsulta.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxConsulta.TabIndex = 51
        Me.TextBoxConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.AutoScroll = True
        Me.SplitContainer2.Panel1.Controls.Add(Me.ComprasDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.ProductosDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(694, 599)
        Me.SplitContainer2.SplitterDistance = 311
        Me.SplitContainer2.TabIndex = 0
        '
        'ComprasDataGridView
        '
        Me.ComprasDataGridView.AutoGenerateColumns = False
        Me.ComprasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.ComprasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.ComprasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComprasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProveedorDataGridViewTextBoxColumn, Me.ProveedorDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioUnitarioDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.ComprasDataGridView.DataSource = Me.ComprasBindingSource
        Me.ComprasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComprasDataGridView.EnableHeadersVisualStyles = False
        Me.ComprasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ComprasDataGridView.Name = "ComprasDataGridView"
        Me.ComprasDataGridView.Size = New System.Drawing.Size(692, 309)
        Me.ComprasDataGridView.TabIndex = 0
        '
        'IDProveedorDataGridViewTextBoxColumn
        '
        Me.IDProveedorDataGridViewTextBoxColumn.DataPropertyName = "ID_Proveedor"
        Me.IDProveedorDataGridViewTextBoxColumn.HeaderText = "ID_Proveedor"
        Me.IDProveedorDataGridViewTextBoxColumn.Name = "IDProveedorDataGridViewTextBoxColumn"
        Me.IDProveedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProveedorDataGridViewTextBoxColumn
        '
        Me.ProveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor"
        Me.ProveedorDataGridViewTextBoxColumn.Name = "ProveedorDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PrecioUnitarioDataGridViewTextBoxColumn
        '
        Me.PrecioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario"
        Me.PrecioUnitarioDataGridViewTextBoxColumn.Name = "PrecioUnitarioDataGridViewTextBoxColumn"
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProductosDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductosDataGridView.EnableHeadersVisualStyles = False
        Me.ProductosDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.Size = New System.Drawing.Size(692, 282)
        Me.ProductosDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ID_Producto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID_Producto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "StockMinimo"
        Me.DataGridViewTextBoxColumn14.HeaderText = "StockMinimo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'TopMenu
        '
        Me.TopMenu.Font = New System.Drawing.Font("Liberation Mono", 20.0!, System.Drawing.FontStyle.Bold)
        Me.TopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ContactoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.TopMenu.Location = New System.Drawing.Point(0, 0)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.TopMenu.Size = New System.Drawing.Size(1274, 92)
        Me.TopMenu.TabIndex = 0
        Me.TopMenu.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(193, 92)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(193, 92)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(213, 92)
        Me.ClientesToolStripMenuItem.Text = "Compras"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(253, 92)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(233, 92)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(173, 92)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ComprasTableAdapter
        '
        Me.ComprasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComprasTableAdapter = Me.ComprasTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Proyecto_Bazar.BazarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Compras
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("Liberation Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.TopMenu
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Compras"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.ComprasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMenu.ResumeLayout(False)
        Me.TopMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents TopMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonPurgar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonCrear As System.Windows.Forms.Button
    Friend WithEvents ButtonModificar As System.Windows.Forms.Button
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ButtonAnterior As System.Windows.Forms.Button
    Friend WithEvents TextBoxConsulta As System.Windows.Forms.TextBox
    Friend WithEvents BazarDataSet As Proyecto_Bazar.BazarDataSet
    Friend WithEvents ComprasTableAdapter As Proyecto_Bazar.BazarDataSetTableAdapters.ComprasTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto_Bazar.BazarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As Proyecto_Bazar.BazarDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ButtonSiguiente As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ProveedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComprasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioUnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ComprasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents IDProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProveedorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonUltimoItem As System.Windows.Forms.Button
    Friend WithEvents ButtonPrimerItem As System.Windows.Forms.Button
End Class
