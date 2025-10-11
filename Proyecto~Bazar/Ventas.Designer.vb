<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim ID_ClienteLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim PrecioUnitarioLabel As System.Windows.Forms.Label
        Dim SubTotalLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim CategoriaLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ID_ProductoLabel As System.Windows.Forms.Label
        Me.Panel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonUltimoItem = New System.Windows.Forms.Button()
        Me.ButtonPrimerItem = New System.Windows.Forms.Button()
        Me.ID_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazarDataSet = New Proyecto_Bazar.BazarDataSet()
        Me.CategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductoComboBox = New System.Windows.Forms.ComboBox()
        Me.ID_ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioUnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSiguiente = New System.Windows.Forms.Button()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonAnterior = New System.Windows.Forms.Button()
        Me.TextBoxConsulta = New System.Windows.Forms.TextBox()
        Me.ButtonPurgar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonCrear = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TopMenu = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasTableAdapter = New Proyecto_Bazar.BazarDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New Proyecto_Bazar.BazarDataSetTableAdapters.TableAdapterManager()
        Me.ProductosTableAdapter = New Proyecto_Bazar.BazarDataSetTableAdapters.ProductosTableAdapter()
        Me.ComboBoxAtributo = New System.Windows.Forms.ComboBox()
        LabelBuscar = New System.Windows.Forms.Label()
        ID_ClienteLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        PrecioUnitarioLabel = New System.Windows.Forms.Label()
        SubTotalLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CategoriaLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ID_ProductoLabel = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBuscar
        '
        LabelBuscar.AutoSize = True
        LabelBuscar.BackColor = System.Drawing.Color.Transparent
        LabelBuscar.ForeColor = System.Drawing.Color.White
        LabelBuscar.Location = New System.Drawing.Point(222, 415)
        LabelBuscar.Name = "LabelBuscar"
        LabelBuscar.Size = New System.Drawing.Size(110, 17)
        LabelBuscar.TabIndex = 94
        LabelBuscar.Text = "Buscar Venta"
        '
        'ID_ClienteLabel
        '
        ID_ClienteLabel.AutoSize = True
        ID_ClienteLabel.ForeColor = System.Drawing.Color.White
        ID_ClienteLabel.Location = New System.Drawing.Point(91, 101)
        ID_ClienteLabel.Name = "ID_ClienteLabel"
        ID_ClienteLabel.Size = New System.Drawing.Size(87, 17)
        ID_ClienteLabel.TabIndex = 97
        ID_ClienteLabel.Text = "ID Cliente:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.ForeColor = System.Drawing.Color.White
        ClienteLabel.Location = New System.Drawing.Point(112, 69)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(67, 17)
        ClienteLabel.TabIndex = 101
        ClienteLabel.Text = "Cliente:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.ForeColor = System.Drawing.Color.White
        FechaLabel.Location = New System.Drawing.Point(118, 227)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(61, 17)
        FechaLabel.TabIndex = 103
        FechaLabel.Text = "Fecha:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.ForeColor = System.Drawing.Color.White
        CantidadLabel.Location = New System.Drawing.Point(96, 259)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(83, 17)
        CantidadLabel.TabIndex = 105
        CantidadLabel.Text = "Cantidad:"
        '
        'PrecioUnitarioLabel
        '
        PrecioUnitarioLabel.AutoSize = True
        PrecioUnitarioLabel.ForeColor = System.Drawing.Color.White
        PrecioUnitarioLabel.Location = New System.Drawing.Point(52, 291)
        PrecioUnitarioLabel.Name = "PrecioUnitarioLabel"
        PrecioUnitarioLabel.Size = New System.Drawing.Size(127, 17)
        PrecioUnitarioLabel.TabIndex = 107
        PrecioUnitarioLabel.Text = "Precio Unitario:"
        '
        'SubTotalLabel
        '
        SubTotalLabel.AutoSize = True
        SubTotalLabel.ForeColor = System.Drawing.Color.White
        SubTotalLabel.Location = New System.Drawing.Point(93, 323)
        SubTotalLabel.Name = "SubTotalLabel"
        SubTotalLabel.Size = New System.Drawing.Size(86, 17)
        SubTotalLabel.TabIndex = 109
        SubTotalLabel.Text = "Sub Total:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.ForeColor = System.Drawing.Color.White
        TotalLabel.Location = New System.Drawing.Point(128, 355)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(51, 17)
        TotalLabel.TabIndex = 111
        TotalLabel.Text = "Total:"
        '
        'CategoriaLabel
        '
        CategoriaLabel.AutoSize = True
        CategoriaLabel.ForeColor = System.Drawing.Color.White
        CategoriaLabel.Location = New System.Drawing.Point(90, 164)
        CategoriaLabel.Name = "CategoriaLabel"
        CategoriaLabel.Size = New System.Drawing.Size(88, 17)
        CategoriaLabel.TabIndex = 115
        CategoriaLabel.Text = "Categoria:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.Color.White
        NombreLabel.Location = New System.Drawing.Point(94, 195)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(85, 17)
        NombreLabel.TabIndex = 113
        NombreLabel.Text = "Producto:"
        '
        'ID_ProductoLabel
        '
        ID_ProductoLabel.AutoSize = True
        ID_ProductoLabel.ForeColor = System.Drawing.Color.White
        ID_ProductoLabel.Location = New System.Drawing.Point(74, 133)
        ID_ProductoLabel.Name = "ID_ProductoLabel"
        ID_ProductoLabel.Size = New System.Drawing.Size(105, 17)
        ID_ProductoLabel.TabIndex = 116
        ID_ProductoLabel.Text = "ID Producto:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxAtributo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonUltimoItem)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonPrimerItem)
        Me.SplitContainer1.Panel1.Controls.Add(ID_ProductoLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ProductoTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CategoriaComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(CategoriaLabel)
        Me.SplitContainer1.Panel1.Controls.Add(NombreLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProductoComboBox)
        Me.SplitContainer1.Panel1.Controls.Add(ID_ClienteLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ID_ClienteTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(ClienteLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClienteComboBox)
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonSiguiente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAnterior)
        Me.SplitContainer1.Panel1.Controls.Add(LabelBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxConsulta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonPurgar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEliminar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCrear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonModificar)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1274, 599)
        Me.SplitContainer1.SplitterDistance = 563
        Me.SplitContainer1.TabIndex = 1
        '
        'ButtonUltimoItem
        '
        Me.ButtonUltimoItem.BackColor = System.Drawing.Color.White
        Me.ButtonUltimoItem.ForeColor = System.Drawing.Color.Black
        Me.ButtonUltimoItem.Location = New System.Drawing.Point(304, 545)
        Me.ButtonUltimoItem.Name = "ButtonUltimoItem"
        Me.ButtonUltimoItem.Size = New System.Drawing.Size(80, 41)
        Me.ButtonUltimoItem.TabIndex = 119
        Me.ButtonUltimoItem.Text = ">>>"
        Me.ButtonUltimoItem.UseVisualStyleBackColor = False
        '
        'ButtonPrimerItem
        '
        Me.ButtonPrimerItem.BackColor = System.Drawing.Color.White
        Me.ButtonPrimerItem.ForeColor = System.Drawing.Color.Black
        Me.ButtonPrimerItem.Location = New System.Drawing.Point(184, 545)
        Me.ButtonPrimerItem.Name = "ButtonPrimerItem"
        Me.ButtonPrimerItem.Size = New System.Drawing.Size(80, 41)
        Me.ButtonPrimerItem.TabIndex = 118
        Me.ButtonPrimerItem.Text = "<<<"
        Me.ButtonPrimerItem.UseVisualStyleBackColor = False
        '
        'ID_ProductoTextBox
        '
        Me.ID_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "ID_Producto", True))
        Me.ID_ProductoTextBox.Enabled = False
        Me.ID_ProductoTextBox.Location = New System.Drawing.Point(184, 124)
        Me.ID_ProductoTextBox.Name = "ID_ProductoTextBox"
        Me.ID_ProductoTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ID_ProductoTextBox.TabIndex = 117
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
        'CategoriaComboBox
        '
        Me.CategoriaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CategoriaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Nombre", True))
        Me.CategoriaComboBox.DataSource = Me.ProductosBindingSource
        Me.CategoriaComboBox.DisplayMember = "Categoria"
        Me.CategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoriaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CategoriaComboBox.Location = New System.Drawing.Point(184, 156)
        Me.CategoriaComboBox.Name = "CategoriaComboBox"
        Me.CategoriaComboBox.Size = New System.Drawing.Size(200, 25)
        Me.CategoriaComboBox.TabIndex = 116
        Me.CategoriaComboBox.ValueMember = "Categoria"
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
        Me.ProductoComboBox.Location = New System.Drawing.Point(184, 187)
        Me.ProductoComboBox.Name = "ProductoComboBox"
        Me.ProductoComboBox.Size = New System.Drawing.Size(200, 25)
        Me.ProductoComboBox.TabIndex = 114
        Me.ProductoComboBox.ValueMember = "ID_Producto"
        '
        'ID_ClienteTextBox
        '
        Me.ID_ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "ID_Cliente", True))
        Me.ID_ClienteTextBox.Enabled = False
        Me.ID_ClienteTextBox.Location = New System.Drawing.Point(184, 92)
        Me.ID_ClienteTextBox.Name = "ID_ClienteTextBox"
        Me.ID_ClienteTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ID_ClienteTextBox.TabIndex = 98
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.BazarDataSet
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Cliente", True))
        Me.ClienteComboBox.DataSource = Me.VentasBindingSource
        Me.ClienteComboBox.DisplayMember = "Cliente"
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(184, 61)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(200, 25)
        Me.ClienteComboBox.TabIndex = 102
        Me.ClienteComboBox.ValueMember = "ID_Cliente"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(184, 218)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.FechaDateTimePicker.TabIndex = 104
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Location = New System.Drawing.Point(184, 250)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CantidadTextBox.TabIndex = 106
        '
        'PrecioUnitarioTextBox
        '
        Me.PrecioUnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "PrecioUnitario", True))
        Me.PrecioUnitarioTextBox.Location = New System.Drawing.Point(184, 282)
        Me.PrecioUnitarioTextBox.Name = "PrecioUnitarioTextBox"
        Me.PrecioUnitarioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PrecioUnitarioTextBox.TabIndex = 108
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "SubTotal", True))
        Me.SubTotalTextBox.Enabled = False
        Me.SubTotalTextBox.Location = New System.Drawing.Point(184, 314)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.SubTotalTextBox.TabIndex = 110
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Total", True))
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(184, 346)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TotalTextBox.TabIndex = 112
        '
        'ButtonSiguiente
        '
        Me.ButtonSiguiente.BackColor = System.Drawing.Color.Black
        Me.ButtonSiguiente.ForeColor = System.Drawing.Color.White
        Me.ButtonSiguiente.Location = New System.Drawing.Point(304, 498)
        Me.ButtonSiguiente.Name = "ButtonSiguiente"
        Me.ButtonSiguiente.Size = New System.Drawing.Size(80, 41)
        Me.ButtonSiguiente.TabIndex = 97
        Me.ButtonSiguiente.Text = ">"
        Me.ButtonSiguiente.UseVisualStyleBackColor = False
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.Color.Cyan
        Me.ButtonBuscar.ForeColor = System.Drawing.Color.Black
        Me.ButtonBuscar.Location = New System.Drawing.Point(44, 457)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonBuscar.TabIndex = 96
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.BackColor = System.Drawing.Color.Black
        Me.ButtonAnterior.ForeColor = System.Drawing.Color.White
        Me.ButtonAnterior.Location = New System.Drawing.Point(184, 498)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(80, 41)
        Me.ButtonAnterior.TabIndex = 95
        Me.ButtonAnterior.Text = "<"
        Me.ButtonAnterior.UseVisualStyleBackColor = False
        '
        'TextBoxConsulta
        '
        Me.TextBoxConsulta.BackColor = System.Drawing.Color.White
        Me.TextBoxConsulta.ForeColor = System.Drawing.Color.Black
        Me.TextBoxConsulta.Location = New System.Drawing.Point(184, 466)
        Me.TextBoxConsulta.Name = "TextBoxConsulta"
        Me.TextBoxConsulta.Size = New System.Drawing.Size(200, 26)
        Me.TextBoxConsulta.TabIndex = 93
        Me.TextBoxConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonPurgar
        '
        Me.ButtonPurgar.BackColor = System.Drawing.Color.Magenta
        Me.ButtonPurgar.ForeColor = System.Drawing.Color.Black
        Me.ButtonPurgar.Location = New System.Drawing.Point(409, 331)
        Me.ButtonPurgar.Name = "ButtonPurgar"
        Me.ButtonPurgar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonPurgar.TabIndex = 78
        Me.ButtonPurgar.Text = "Purgar"
        Me.ButtonPurgar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.Color.Red
        Me.ButtonEliminar.ForeColor = System.Drawing.Color.Black
        Me.ButtonEliminar.Location = New System.Drawing.Point(409, 250)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonEliminar.TabIndex = 77
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonCrear
        '
        Me.ButtonCrear.BackColor = System.Drawing.Color.LawnGreen
        Me.ButtonCrear.ForeColor = System.Drawing.Color.Black
        Me.ButtonCrear.Location = New System.Drawing.Point(409, 61)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(135, 41)
        Me.ButtonCrear.TabIndex = 76
        Me.ButtonCrear.Text = "Crear"
        Me.ButtonCrear.UseVisualStyleBackColor = False
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.Color.Yellow
        Me.ButtonModificar.ForeColor = System.Drawing.Color.Black
        Me.ButtonModificar.Location = New System.Drawing.Point(409, 140)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonModificar.TabIndex = 75
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = False
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.VentasDataGridView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.ProductosDataGridView)
        Me.SplitContainer2.Size = New System.Drawing.Size(707, 599)
        Me.SplitContainer2.SplitterDistance = 310
        Me.SplitContainer2.TabIndex = 0
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.VentasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VentasDataGridView.EnableHeadersVisualStyles = False
        Me.VentasDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.RowHeadersWidth = 20
        Me.VentasDataGridView.Size = New System.Drawing.Size(705, 308)
        Me.VentasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PrecioUnitario"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PrecioUnitario"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
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
        Me.ProductosDataGridView.RowHeadersWidth = 20
        Me.ProductosDataGridView.Size = New System.Drawing.Size(705, 283)
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
        Me.TopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ContactoToolStripMenuItem, Me.SalirToolStripMenuItem})
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
        Me.VentasToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(193, 92)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(52, 0, 0, 50)
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(213, 92)
        Me.ComprasToolStripMenuItem.Text = "Compras"
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
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ComprasTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Proyecto_Bazar.BazarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ComboBoxAtributo
        '
        Me.ComboBoxAtributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAtributo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxAtributo.FormattingEnabled = True
        Me.ComboBoxAtributo.Location = New System.Drawing.Point(185, 435)
        Me.ComboBoxAtributo.Name = "ComboBoxAtributo"
        Me.ComboBoxAtributo.Size = New System.Drawing.Size(199, 25)
        Me.ComboBoxAtributo.TabIndex = 120
        '
        'Ventas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("Liberation Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.TopMenu
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Ventas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopMenu.ResumeLayout(False)
        Me.TopMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents BazarDataSet As Proyecto_Bazar.BazarDataSet
    Friend WithEvents VentasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VentasTableAdapter As Proyecto_Bazar.BazarDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As Proyecto_Bazar.BazarDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductosTableAdapter As Proyecto_Bazar.BazarDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonPurgar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonCrear As System.Windows.Forms.Button
    Friend WithEvents ButtonModificar As System.Windows.Forms.Button
    Friend WithEvents ButtonSiguiente As System.Windows.Forms.Button
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ButtonAnterior As System.Windows.Forms.Button
    Friend WithEvents TextBoxConsulta As System.Windows.Forms.TextBox
    Friend WithEvents TopMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ID_ClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrecioUnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoriaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProductoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ID_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonUltimoItem As System.Windows.Forms.Button
    Friend WithEvents ButtonPrimerItem As System.Windows.Forms.Button
    Friend WithEvents ComboBoxAtributo As System.Windows.Forms.ComboBox
End Class
