<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contacto
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
        Me.LabelBuscarProveedor = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.ButtonSiguiente = New System.Windows.Forms.Button()
        Me.ButtonAnterior = New System.Windows.Forms.Button()
        Me.TextBoxConsulta = New System.Windows.Forms.TextBox()
        Me.ButtonPurgar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonCrear = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TopMenu = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.SuspendLayout()
        Me.TopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelBuscarProveedor
        '
        Me.LabelBuscarProveedor.AutoSize = True
        Me.LabelBuscarProveedor.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelBuscarProveedor.ForeColor = System.Drawing.Color.White
        Me.LabelBuscarProveedor.Location = New System.Drawing.Point(184, 412)
        Me.LabelBuscarProveedor.Name = "LabelBuscarProveedor"
        Me.LabelBuscarProveedor.Size = New System.Drawing.Size(147, 17)
        Me.LabelBuscarProveedor.TabIndex = 32
        Me.LabelBuscarProveedor.Text = "Buscar Proveedor"
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
        Me.SplitContainer1.ForeColor = System.Drawing.Color.White
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 92)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBuscar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonSiguiente)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAnterior)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelBuscarProveedor)
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
        Me.SplitContainer1.SplitterDistance = 637
        Me.SplitContainer1.TabIndex = 1
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBuscar.Location = New System.Drawing.Point(374, 423)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonBuscar.TabIndex = 35
        Me.ButtonBuscar.Text = "Buscar"
        Me.ButtonBuscar.UseVisualStyleBackColor = False
        '
        'ButtonSiguiente
        '
        Me.ButtonSiguiente.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonSiguiente.Location = New System.Drawing.Point(268, 464)
        Me.ButtonSiguiente.Name = "ButtonSiguiente"
        Me.ButtonSiguiente.Size = New System.Drawing.Size(100, 41)
        Me.ButtonSiguiente.TabIndex = 34
        Me.ButtonSiguiente.Text = ">"
        Me.ButtonSiguiente.UseVisualStyleBackColor = False
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonAnterior.Location = New System.Drawing.Point(142, 464)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(100, 41)
        Me.ButtonAnterior.TabIndex = 33
        Me.ButtonAnterior.Text = "<"
        Me.ButtonAnterior.UseVisualStyleBackColor = False
        '
        'TextBoxConsulta
        '
        Me.TextBoxConsulta.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBoxConsulta.Location = New System.Drawing.Point(142, 432)
        Me.TextBoxConsulta.Name = "TextBoxConsulta"
        Me.TextBoxConsulta.Size = New System.Drawing.Size(226, 26)
        Me.TextBoxConsulta.TabIndex = 31
        Me.TextBoxConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonPurgar
        '
        Me.ButtonPurgar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonPurgar.Location = New System.Drawing.Point(426, 297)
        Me.ButtonPurgar.Name = "ButtonPurgar"
        Me.ButtonPurgar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonPurgar.TabIndex = 30
        Me.ButtonPurgar.Text = "Purgar"
        Me.ButtonPurgar.UseVisualStyleBackColor = False
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonEliminar.Location = New System.Drawing.Point(426, 251)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonEliminar.TabIndex = 29
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = False
        '
        'ButtonCrear
        '
        Me.ButtonCrear.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonCrear.ForeColor = System.Drawing.Color.White
        Me.ButtonCrear.Location = New System.Drawing.Point(426, 88)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(135, 41)
        Me.ButtonCrear.TabIndex = 28
        Me.ButtonCrear.Text = "Crear"
        Me.ButtonCrear.UseVisualStyleBackColor = False
        '
        'ButtonModificar
        '
        Me.ButtonModificar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonModificar.Location = New System.Drawing.Point(426, 135)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(135, 41)
        Me.ButtonModificar.TabIndex = 27
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
        Me.SplitContainer2.Size = New System.Drawing.Size(633, 599)
        Me.SplitContainer2.SplitterDistance = 311
        Me.SplitContainer2.TabIndex = 0
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
        Me.InicioToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Padding = New System.Windows.Forms.Padding(21, 25, 21, 25)
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(183, 92)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.VentasToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(149, 92)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ComprasToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(21, 25, 21, 25)
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(203, 92)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ProductosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(21, 25, 21, 25)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(243, 92)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ContactoToolStripMenuItem
        '
        Me.ContactoToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.ContactoToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ContactoToolStripMenuItem.Name = "ContactoToolStripMenuItem"
        Me.ContactoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(21, 25, 21, 25)
        Me.ContactoToolStripMenuItem.Size = New System.Drawing.Size(223, 92)
        Me.ContactoToolStripMenuItem.Text = "Contacto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Liberation Mono", 25.0!, System.Drawing.FontStyle.Bold)
        Me.SalirToolStripMenuItem.Margin = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Padding = New System.Windows.Forms.Padding(21, 25, 21, 25)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(163, 92)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Inicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.Panel)
        Me.Font = New System.Drawing.Font("Liberation Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.TopMenu
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Inicio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TopMenu.ResumeLayout(False)
        Me.TopMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents TopMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonBuscar As System.Windows.Forms.Button
    Friend WithEvents ButtonSiguiente As System.Windows.Forms.Button
    Friend WithEvents ButtonAnterior As System.Windows.Forms.Button
    Friend WithEvents TextBoxConsulta As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPurgar As System.Windows.Forms.Button
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonCrear As System.Windows.Forms.Button
    Friend WithEvents ButtonModificar As System.Windows.Forms.Button
    Friend WithEvents LabelBuscarProveedor As System.Windows.Forms.Label
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
