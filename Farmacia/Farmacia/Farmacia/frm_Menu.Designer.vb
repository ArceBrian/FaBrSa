<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubRubrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaCorrienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaCorrienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.ItemsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubrosToolStripMenuItem, Me.SubRubrosToolStripMenuItem, Me.ProductosToolStripMenuItem1})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'RubrosToolStripMenuItem
        '
        Me.RubrosToolStripMenuItem.Name = "RubrosToolStripMenuItem"
        Me.RubrosToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.RubrosToolStripMenuItem.Text = "Rubros"
        '
        'SubRubrosToolStripMenuItem
        '
        Me.SubRubrosToolStripMenuItem.Name = "SubRubrosToolStripMenuItem"
        Me.SubRubrosToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SubRubrosToolStripMenuItem.Text = "SubRubros"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargaToolStripMenuItem, Me.CuentaCorrienteToolStripMenuItem, Me.CuentaCorrienteToolStripMenuItem1})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'CargaToolStripMenuItem
        '
        Me.CargaToolStripMenuItem.Name = "CargaToolStripMenuItem"
        Me.CargaToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CargaToolStripMenuItem.Text = "Carga"
        '
        'CuentaCorrienteToolStripMenuItem
        '
        Me.CuentaCorrienteToolStripMenuItem.Name = "CuentaCorrienteToolStripMenuItem"
        Me.CuentaCorrienteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CuentaCorrienteToolStripMenuItem.Text = "Facturas"
        '
        'CuentaCorrienteToolStripMenuItem1
        '
        Me.CuentaCorrienteToolStripMenuItem1.Name = "CuentaCorrienteToolStripMenuItem1"
        Me.CuentaCorrienteToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.CuentaCorrienteToolStripMenuItem1.Text = "Cuenta Corriente"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProveedoresToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosItemsToolStripMenuItem, Me.ClientesItemsToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'ProductosItemsToolStripMenuItem
        '
        Me.ProductosItemsToolStripMenuItem.Name = "ProductosItemsToolStripMenuItem"
        Me.ProductosItemsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ProductosItemsToolStripMenuItem.Text = "Productos Items"
        '
        'ClientesItemsToolStripMenuItem
        '
        Me.ClientesItemsToolStripMenuItem.Name = "ClientesItemsToolStripMenuItem"
        Me.ClientesItemsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ClientesItemsToolStripMenuItem.Text = "Clientes Items"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.BackgroundImage = Global.Farmacia.My.Resources.Resources.Logo_tamaño_grande_con_texto
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 318)
        Me.Panel1.TabIndex = 2
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Farmacia.My.Resources.Resources._314252
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(422, 342)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Menu"
        Me.Text = "FarmaEasy"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubRubrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CargaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaCorrienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaCorrienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
