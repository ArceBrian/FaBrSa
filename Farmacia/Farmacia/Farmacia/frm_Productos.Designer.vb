<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Productos
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
        Me.grlGrilla = New System.Windows.Forms.DataGridView()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.cmdFiltrarProd = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdAgregar = New System.Windows.Forms.Button()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAccion = New System.Windows.Forms.Label()
        Me.grb_Productos = New System.Windows.Forms.GroupBox()
        Me.lbl_Cantidad = New System.Windows.Forms.Label()
        Me.txt_Cantidad = New System.Windows.Forms.TextBox()
        Me.lbl_IdSubRubro = New System.Windows.Forms.Label()
        Me.txt_PrecioVentaCliente = New System.Windows.Forms.TextBox()
        Me.txt_CodigoBarra4 = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoBarra4 = New System.Windows.Forms.Label()
        Me.txt_TipoCodBarra4 = New System.Windows.Forms.TextBox()
        Me.lbl_TipoCodBarra4 = New System.Windows.Forms.Label()
        Me.txt_CodigoBarra3 = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoBarra3 = New System.Windows.Forms.Label()
        Me.txt_TipoCodBarra3 = New System.Windows.Forms.TextBox()
        Me.lbl_TipoCodBarra3 = New System.Windows.Forms.Label()
        Me.txt_CodigoBarra2 = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoBarra2 = New System.Windows.Forms.Label()
        Me.txt_TipoCodBarra2 = New System.Windows.Forms.TextBox()
        Me.lbl_TipoCodBarra2 = New System.Windows.Forms.Label()
        Me.txt_CodigoBarra1 = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoBarra1 = New System.Windows.Forms.Label()
        Me.txt_TipoCodBarra1 = New System.Windows.Forms.TextBox()
        Me.lbl_TipoCodBarra1 = New System.Windows.Forms.Label()
        Me.txt_Venta = New System.Windows.Forms.TextBox()
        Me.lvl_Venta = New System.Windows.Forms.Label()
        Me.txt_Seccion = New System.Windows.Forms.TextBox()
        Me.lbl_Seccion = New System.Windows.Forms.Label()
        Me.txt_IdSeccion = New System.Windows.Forms.TextBox()
        Me.lbl_IdSeccion = New System.Windows.Forms.Label()
        Me.txt_Descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.txt_CodigoMSP = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoMSP = New System.Windows.Forms.Label()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.txt_CuitLaboratorio = New System.Windows.Forms.TextBox()
        Me.txt_Laboratorio = New System.Windows.Forms.TextBox()
        Me.txt_CodigoLaboratorio = New System.Windows.Forms.TextBox()
        Me.txt_PrecioSugerido = New System.Windows.Forms.TextBox()
        Me.cbo_IdSubRubro = New System.Windows.Forms.ComboBox()
        Me.txt_IdProducto = New System.Windows.Forms.TextBox()
        Me.lbl_CuitLaboratorio = New System.Windows.Forms.Label()
        Me.lbl_Laboratorio = New System.Windows.Forms.Label()
        Me.lbl_CodigoLaboratorio = New System.Windows.Forms.Label()
        Me.lbl_PrecioSugerido = New System.Windows.Forms.Label()
        Me.lbl_PrecioVentaCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grb_Productos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grlGrilla
        '
        Me.grlGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlGrilla.Location = New System.Drawing.Point(13, 41)
        Me.grlGrilla.Name = "grlGrilla"
        Me.grlGrilla.Size = New System.Drawing.Size(879, 196)
        Me.grlGrilla.TabIndex = 0
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(13, 13)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(100, 20)
        Me.txtFiltrar.TabIndex = 1
        '
        'cmdFiltrarProd
        '
        Me.cmdFiltrarProd.Location = New System.Drawing.Point(119, 11)
        Me.cmdFiltrarProd.Name = "cmdFiltrarProd"
        Me.cmdFiltrarProd.Size = New System.Drawing.Size(75, 23)
        Me.cmdFiltrarProd.TabIndex = 2
        Me.cmdFiltrarProd.Text = "Buscar"
        Me.cmdFiltrarProd.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(13, 243)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLimpiar.TabIndex = 3
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdAgregar
        '
        Me.cmdAgregar.Location = New System.Drawing.Point(817, 243)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAgregar.TabIndex = 4
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = True
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(817, 272)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(75, 23)
        Me.cmdModificar.TabIndex = 5
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAccion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 559)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 24)
        Me.Panel1.TabIndex = 7
        '
        'lblAccion
        '
        Me.lblAccion.AutoSize = True
        Me.lblAccion.Location = New System.Drawing.Point(7, 3)
        Me.lblAccion.Name = "lblAccion"
        Me.lblAccion.Size = New System.Drawing.Size(39, 13)
        Me.lblAccion.TabIndex = 0
        Me.lblAccion.Text = "Label9"
        '
        'grb_Productos
        '
        Me.grb_Productos.Controls.Add(Me.lbl_Cantidad)
        Me.grb_Productos.Controls.Add(Me.txt_Cantidad)
        Me.grb_Productos.Controls.Add(Me.lbl_IdSubRubro)
        Me.grb_Productos.Controls.Add(Me.txt_PrecioVentaCliente)
        Me.grb_Productos.Controls.Add(Me.txt_CodigoBarra4)
        Me.grb_Productos.Controls.Add(Me.lbl_CodigoBarra4)
        Me.grb_Productos.Controls.Add(Me.txt_TipoCodBarra4)
        Me.grb_Productos.Controls.Add(Me.lbl_TipoCodBarra4)
        Me.grb_Productos.Controls.Add(Me.txt_CodigoBarra3)
        Me.grb_Productos.Controls.Add(Me.lbl_CodigoBarra3)
        Me.grb_Productos.Controls.Add(Me.txt_TipoCodBarra3)
        Me.grb_Productos.Controls.Add(Me.lbl_TipoCodBarra3)
        Me.grb_Productos.Controls.Add(Me.txt_CodigoBarra2)
        Me.grb_Productos.Controls.Add(Me.lbl_CodigoBarra2)
        Me.grb_Productos.Controls.Add(Me.txt_TipoCodBarra2)
        Me.grb_Productos.Controls.Add(Me.lbl_TipoCodBarra2)
        Me.grb_Productos.Controls.Add(Me.txt_CodigoBarra1)
        Me.grb_Productos.Controls.Add(Me.lbl_CodigoBarra1)
        Me.grb_Productos.Controls.Add(Me.txt_TipoCodBarra1)
        Me.grb_Productos.Controls.Add(Me.lbl_TipoCodBarra1)
        Me.grb_Productos.Controls.Add(Me.txt_Venta)
        Me.grb_Productos.Controls.Add(Me.lvl_Venta)
        Me.grb_Productos.Controls.Add(Me.txt_Seccion)
        Me.grb_Productos.Controls.Add(Me.lbl_Seccion)
        Me.grb_Productos.Controls.Add(Me.txt_IdSeccion)
        Me.grb_Productos.Controls.Add(Me.lbl_IdSeccion)
        Me.grb_Productos.Controls.Add(Me.txt_Descripcion)
        Me.grb_Productos.Controls.Add(Me.lbl_Descripcion)
        Me.grb_Productos.Controls.Add(Me.txt_CodigoMSP)
        Me.grb_Productos.Controls.Add(Me.lbl_CodigoMSP)
        Me.grb_Productos.Controls.Add(Me.cmdCancelar)
        Me.grb_Productos.Controls.Add(Me.cmdAceptar)
        Me.grb_Productos.Controls.Add(Me.txt_CuitLaboratorio)
        Me.grb_Productos.Controls.Add(Me.txt_Laboratorio)
        Me.grb_Productos.Controls.Add(Me.txt_CodigoLaboratorio)
        Me.grb_Productos.Controls.Add(Me.txt_PrecioSugerido)
        Me.grb_Productos.Controls.Add(Me.cbo_IdSubRubro)
        Me.grb_Productos.Controls.Add(Me.txt_IdProducto)
        Me.grb_Productos.Controls.Add(Me.lbl_CuitLaboratorio)
        Me.grb_Productos.Controls.Add(Me.lbl_Laboratorio)
        Me.grb_Productos.Controls.Add(Me.lbl_CodigoLaboratorio)
        Me.grb_Productos.Controls.Add(Me.lbl_PrecioSugerido)
        Me.grb_Productos.Controls.Add(Me.lbl_PrecioVentaCliente)
        Me.grb_Productos.Controls.Add(Me.Label1)
        Me.grb_Productos.Location = New System.Drawing.Point(109, 243)
        Me.grb_Productos.Name = "grb_Productos"
        Me.grb_Productos.Size = New System.Drawing.Size(679, 301)
        Me.grb_Productos.TabIndex = 7
        Me.grb_Productos.TabStop = False
        Me.grb_Productos.Text = "Productos"
        '
        'lbl_Cantidad
        '
        Me.lbl_Cantidad.AutoSize = True
        Me.lbl_Cantidad.Location = New System.Drawing.Point(447, 215)
        Me.lbl_Cantidad.Name = "lbl_Cantidad"
        Me.lbl_Cantidad.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Cantidad.TabIndex = 47
        Me.lbl_Cantidad.Text = "Cantidad"
        '
        'txt_Cantidad
        '
        Me.txt_Cantidad.Location = New System.Drawing.Point(550, 212)
        Me.txt_Cantidad.Name = "txt_Cantidad"
        Me.txt_Cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_Cantidad.TabIndex = 46
        '
        'lbl_IdSubRubro
        '
        Me.lbl_IdSubRubro.AutoSize = True
        Me.lbl_IdSubRubro.Location = New System.Drawing.Point(447, 188)
        Me.lbl_IdSubRubro.Name = "lbl_IdSubRubro"
        Me.lbl_IdSubRubro.Size = New System.Drawing.Size(64, 13)
        Me.lbl_IdSubRubro.TabIndex = 45
        Me.lbl_IdSubRubro.Text = "IdSubRubro"
        '
        'txt_PrecioVentaCliente
        '
        Me.txt_PrecioVentaCliente.Location = New System.Drawing.Point(550, 31)
        Me.txt_PrecioVentaCliente.Name = "txt_PrecioVentaCliente"
        Me.txt_PrecioVentaCliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_PrecioVentaCliente.TabIndex = 44
        '
        'txt_CodigoBarra4
        '
        Me.txt_CodigoBarra4.Location = New System.Drawing.Point(306, 212)
        Me.txt_CodigoBarra4.Name = "txt_CodigoBarra4"
        Me.txt_CodigoBarra4.Size = New System.Drawing.Size(100, 20)
        Me.txt_CodigoBarra4.TabIndex = 43
        '
        'lbl_CodigoBarra4
        '
        Me.lbl_CodigoBarra4.AutoSize = True
        Me.lbl_CodigoBarra4.Location = New System.Drawing.Point(222, 215)
        Me.lbl_CodigoBarra4.Name = "lbl_CodigoBarra4"
        Me.lbl_CodigoBarra4.Size = New System.Drawing.Size(71, 13)
        Me.lbl_CodigoBarra4.TabIndex = 42
        Me.lbl_CodigoBarra4.Text = "CódigoBarra4"
        '
        'txt_TipoCodBarra4
        '
        Me.txt_TipoCodBarra4.Location = New System.Drawing.Point(306, 182)
        Me.txt_TipoCodBarra4.Name = "txt_TipoCodBarra4"
        Me.txt_TipoCodBarra4.Size = New System.Drawing.Size(100, 20)
        Me.txt_TipoCodBarra4.TabIndex = 41
        '
        'lbl_TipoCodBarra4
        '
        Me.lbl_TipoCodBarra4.AutoSize = True
        Me.lbl_TipoCodBarra4.Location = New System.Drawing.Point(222, 185)
        Me.lbl_TipoCodBarra4.Name = "lbl_TipoCodBarra4"
        Me.lbl_TipoCodBarra4.Size = New System.Drawing.Size(78, 13)
        Me.lbl_TipoCodBarra4.TabIndex = 40
        Me.lbl_TipoCodBarra4.Text = "TipoCódBarra4"
        '
        'txt_CodigoBarra3
        '
        Me.txt_CodigoBarra3.Location = New System.Drawing.Point(306, 152)
        Me.txt_CodigoBarra3.Name = "txt_CodigoBarra3"
        Me.txt_CodigoBarra3.Size = New System.Drawing.Size(100, 20)
        Me.txt_CodigoBarra3.TabIndex = 39
        '
        'lbl_CodigoBarra3
        '
        Me.lbl_CodigoBarra3.AutoSize = True
        Me.lbl_CodigoBarra3.Location = New System.Drawing.Point(222, 155)
        Me.lbl_CodigoBarra3.Name = "lbl_CodigoBarra3"
        Me.lbl_CodigoBarra3.Size = New System.Drawing.Size(71, 13)
        Me.lbl_CodigoBarra3.TabIndex = 38
        Me.lbl_CodigoBarra3.Text = "CódigoBarra3"
        '
        'txt_TipoCodBarra3
        '
        Me.txt_TipoCodBarra3.Location = New System.Drawing.Point(306, 121)
        Me.txt_TipoCodBarra3.Name = "txt_TipoCodBarra3"
        Me.txt_TipoCodBarra3.Size = New System.Drawing.Size(100, 20)
        Me.txt_TipoCodBarra3.TabIndex = 37
        '
        'lbl_TipoCodBarra3
        '
        Me.lbl_TipoCodBarra3.AutoSize = True
        Me.lbl_TipoCodBarra3.Location = New System.Drawing.Point(222, 124)
        Me.lbl_TipoCodBarra3.Name = "lbl_TipoCodBarra3"
        Me.lbl_TipoCodBarra3.Size = New System.Drawing.Size(78, 13)
        Me.lbl_TipoCodBarra3.TabIndex = 36
        Me.lbl_TipoCodBarra3.Text = "TipoCódBarra3"
        '
        'txt_CodigoBarra2
        '
        Me.txt_CodigoBarra2.Location = New System.Drawing.Point(306, 90)
        Me.txt_CodigoBarra2.Name = "txt_CodigoBarra2"
        Me.txt_CodigoBarra2.Size = New System.Drawing.Size(100, 20)
        Me.txt_CodigoBarra2.TabIndex = 35
        '
        'lbl_CodigoBarra2
        '
        Me.lbl_CodigoBarra2.AutoSize = True
        Me.lbl_CodigoBarra2.Location = New System.Drawing.Point(222, 94)
        Me.lbl_CodigoBarra2.Name = "lbl_CodigoBarra2"
        Me.lbl_CodigoBarra2.Size = New System.Drawing.Size(71, 13)
        Me.lbl_CodigoBarra2.TabIndex = 34
        Me.lbl_CodigoBarra2.Text = "CódigoBarra2"
        '
        'txt_TipoCodBarra2
        '
        Me.txt_TipoCodBarra2.Location = New System.Drawing.Point(306, 62)
        Me.txt_TipoCodBarra2.Name = "txt_TipoCodBarra2"
        Me.txt_TipoCodBarra2.Size = New System.Drawing.Size(100, 20)
        Me.txt_TipoCodBarra2.TabIndex = 33
        '
        'lbl_TipoCodBarra2
        '
        Me.lbl_TipoCodBarra2.AutoSize = True
        Me.lbl_TipoCodBarra2.Location = New System.Drawing.Point(222, 65)
        Me.lbl_TipoCodBarra2.Name = "lbl_TipoCodBarra2"
        Me.lbl_TipoCodBarra2.Size = New System.Drawing.Size(78, 13)
        Me.lbl_TipoCodBarra2.TabIndex = 32
        Me.lbl_TipoCodBarra2.Text = "TipoCódBarra2"
        '
        'txt_CodigoBarra1
        '
        Me.txt_CodigoBarra1.Location = New System.Drawing.Point(306, 31)
        Me.txt_CodigoBarra1.Name = "txt_CodigoBarra1"
        Me.txt_CodigoBarra1.Size = New System.Drawing.Size(100, 20)
        Me.txt_CodigoBarra1.TabIndex = 31
        '
        'lbl_CodigoBarra1
        '
        Me.lbl_CodigoBarra1.AutoSize = True
        Me.lbl_CodigoBarra1.Location = New System.Drawing.Point(222, 34)
        Me.lbl_CodigoBarra1.Name = "lbl_CodigoBarra1"
        Me.lbl_CodigoBarra1.Size = New System.Drawing.Size(71, 13)
        Me.lbl_CodigoBarra1.TabIndex = 30
        Me.lbl_CodigoBarra1.Text = "CódigoBarra1"
        '
        'txt_TipoCodBarra1
        '
        Me.txt_TipoCodBarra1.Location = New System.Drawing.Point(90, 212)
        Me.txt_TipoCodBarra1.Name = "txt_TipoCodBarra1"
        Me.txt_TipoCodBarra1.Size = New System.Drawing.Size(100, 20)
        Me.txt_TipoCodBarra1.TabIndex = 29
        '
        'lbl_TipoCodBarra1
        '
        Me.lbl_TipoCodBarra1.AutoSize = True
        Me.lbl_TipoCodBarra1.Location = New System.Drawing.Point(6, 215)
        Me.lbl_TipoCodBarra1.Name = "lbl_TipoCodBarra1"
        Me.lbl_TipoCodBarra1.Size = New System.Drawing.Size(78, 13)
        Me.lbl_TipoCodBarra1.TabIndex = 28
        Me.lbl_TipoCodBarra1.Text = "TipoCódBarra1"
        '
        'txt_Venta
        '
        Me.txt_Venta.Location = New System.Drawing.Point(90, 182)
        Me.txt_Venta.Name = "txt_Venta"
        Me.txt_Venta.Size = New System.Drawing.Size(100, 20)
        Me.txt_Venta.TabIndex = 27
        '
        'lvl_Venta
        '
        Me.lvl_Venta.AutoSize = True
        Me.lvl_Venta.Location = New System.Drawing.Point(6, 185)
        Me.lvl_Venta.Name = "lvl_Venta"
        Me.lvl_Venta.Size = New System.Drawing.Size(35, 13)
        Me.lvl_Venta.TabIndex = 26
        Me.lvl_Venta.Text = "Venta"
        '
        'txt_Seccion
        '
        Me.txt_Seccion.Location = New System.Drawing.Point(90, 152)
        Me.txt_Seccion.Name = "txt_Seccion"
        Me.txt_Seccion.Size = New System.Drawing.Size(100, 20)
        Me.txt_Seccion.TabIndex = 25
        '
        'lbl_Seccion
        '
        Me.lbl_Seccion.AutoSize = True
        Me.lbl_Seccion.Location = New System.Drawing.Point(6, 155)
        Me.lbl_Seccion.Name = "lbl_Seccion"
        Me.lbl_Seccion.Size = New System.Drawing.Size(46, 13)
        Me.lbl_Seccion.TabIndex = 24
        Me.lbl_Seccion.Text = "Sección"
        '
        'txt_IdSeccion
        '
        Me.txt_IdSeccion.Location = New System.Drawing.Point(90, 121)
        Me.txt_IdSeccion.Name = "txt_IdSeccion"
        Me.txt_IdSeccion.Size = New System.Drawing.Size(100, 20)
        Me.txt_IdSeccion.TabIndex = 23
        '
        'lbl_IdSeccion
        '
        Me.lbl_IdSeccion.AutoSize = True
        Me.lbl_IdSeccion.Location = New System.Drawing.Point(6, 124)
        Me.lbl_IdSeccion.Name = "lbl_IdSeccion"
        Me.lbl_IdSeccion.Size = New System.Drawing.Size(55, 13)
        Me.lbl_IdSeccion.TabIndex = 22
        Me.lbl_IdSeccion.Text = "IdSección"
        '
        'txt_Descripcion
        '
        Me.txt_Descripcion.Location = New System.Drawing.Point(90, 90)
        Me.txt_Descripcion.Name = "txt_Descripcion"
        Me.txt_Descripcion.Size = New System.Drawing.Size(100, 20)
        Me.txt_Descripcion.TabIndex = 21
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(6, 94)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Descripcion.TabIndex = 20
        Me.lbl_Descripcion.Text = "Descripción"
        '
        'txt_CodigoMSP
        '
        Me.txt_CodigoMSP.Location = New System.Drawing.Point(90, 62)
        Me.txt_CodigoMSP.Name = "txt_CodigoMSP"
        Me.txt_CodigoMSP.Size = New System.Drawing.Size(100, 20)
        Me.txt_CodigoMSP.TabIndex = 19
        '
        'lbl_CodigoMSP
        '
        Me.lbl_CodigoMSP.AutoSize = True
        Me.lbl_CodigoMSP.Location = New System.Drawing.Point(6, 65)
        Me.lbl_CodigoMSP.Name = "lbl_CodigoMSP"
        Me.lbl_CodigoMSP.Size = New System.Drawing.Size(66, 13)
        Me.lbl_CodigoMSP.TabIndex = 18
        Me.lbl_CodigoMSP.Text = "Código MSP"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(575, 254)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 17
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(494, 254)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 16
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'txt_CuitLaboratorio
        '
        Me.txt_CuitLaboratorio.Location = New System.Drawing.Point(550, 152)
        Me.txt_CuitLaboratorio.Name = "txt_CuitLaboratorio"
        Me.txt_CuitLaboratorio.Size = New System.Drawing.Size(100, 20)
        Me.txt_CuitLaboratorio.TabIndex = 14
        '
        'txt_Laboratorio
        '
        Me.txt_Laboratorio.Location = New System.Drawing.Point(550, 121)
        Me.txt_Laboratorio.Name = "txt_Laboratorio"
        Me.txt_Laboratorio.Size = New System.Drawing.Size(100, 20)
        Me.txt_Laboratorio.TabIndex = 13
        '
        'txt_CodigoLaboratorio
        '
        Me.txt_CodigoLaboratorio.Location = New System.Drawing.Point(550, 91)
        Me.txt_CodigoLaboratorio.Name = "txt_CodigoLaboratorio"
        Me.txt_CodigoLaboratorio.Size = New System.Drawing.Size(100, 20)
        Me.txt_CodigoLaboratorio.TabIndex = 12
        '
        'txt_PrecioSugerido
        '
        Me.txt_PrecioSugerido.Location = New System.Drawing.Point(550, 62)
        Me.txt_PrecioSugerido.Name = "txt_PrecioSugerido"
        Me.txt_PrecioSugerido.Size = New System.Drawing.Size(100, 20)
        Me.txt_PrecioSugerido.TabIndex = 11
        '
        'cbo_IdSubRubro
        '
        Me.cbo_IdSubRubro.FormattingEnabled = True
        Me.cbo_IdSubRubro.Location = New System.Drawing.Point(550, 182)
        Me.cbo_IdSubRubro.Name = "cbo_IdSubRubro"
        Me.cbo_IdSubRubro.Size = New System.Drawing.Size(100, 21)
        Me.cbo_IdSubRubro.TabIndex = 10
        '
        'txt_IdProducto
        '
        Me.txt_IdProducto.Location = New System.Drawing.Point(90, 31)
        Me.txt_IdProducto.Name = "txt_IdProducto"
        Me.txt_IdProducto.Size = New System.Drawing.Size(100, 20)
        Me.txt_IdProducto.TabIndex = 8
        '
        'lbl_CuitLaboratorio
        '
        Me.lbl_CuitLaboratorio.AutoSize = True
        Me.lbl_CuitLaboratorio.Location = New System.Drawing.Point(447, 155)
        Me.lbl_CuitLaboratorio.Name = "lbl_CuitLaboratorio"
        Me.lbl_CuitLaboratorio.Size = New System.Drawing.Size(81, 13)
        Me.lbl_CuitLaboratorio.TabIndex = 6
        Me.lbl_CuitLaboratorio.Text = "Cuit Laboratorio"
        '
        'lbl_Laboratorio
        '
        Me.lbl_Laboratorio.AutoSize = True
        Me.lbl_Laboratorio.Location = New System.Drawing.Point(447, 124)
        Me.lbl_Laboratorio.Name = "lbl_Laboratorio"
        Me.lbl_Laboratorio.Size = New System.Drawing.Size(60, 13)
        Me.lbl_Laboratorio.TabIndex = 5
        Me.lbl_Laboratorio.Text = "Laboratorio"
        '
        'lbl_CodigoLaboratorio
        '
        Me.lbl_CodigoLaboratorio.AutoSize = True
        Me.lbl_CodigoLaboratorio.Location = New System.Drawing.Point(447, 94)
        Me.lbl_CodigoLaboratorio.Name = "lbl_CodigoLaboratorio"
        Me.lbl_CodigoLaboratorio.Size = New System.Drawing.Size(96, 13)
        Me.lbl_CodigoLaboratorio.TabIndex = 4
        Me.lbl_CodigoLaboratorio.Text = "Código Laboratorio"
        '
        'lbl_PrecioSugerido
        '
        Me.lbl_PrecioSugerido.AutoSize = True
        Me.lbl_PrecioSugerido.Location = New System.Drawing.Point(447, 65)
        Me.lbl_PrecioSugerido.Name = "lbl_PrecioSugerido"
        Me.lbl_PrecioSugerido.Size = New System.Drawing.Size(82, 13)
        Me.lbl_PrecioSugerido.TabIndex = 3
        Me.lbl_PrecioSugerido.Text = "Precio Sugerido"
        '
        'lbl_PrecioVentaCliente
        '
        Me.lbl_PrecioVentaCliente.AutoSize = True
        Me.lbl_PrecioVentaCliente.Location = New System.Drawing.Point(447, 34)
        Me.lbl_PrecioVentaCliente.Name = "lbl_PrecioVentaCliente"
        Me.lbl_PrecioVentaCliente.Size = New System.Drawing.Size(97, 13)
        Me.lbl_PrecioVentaCliente.TabIndex = 2
        Me.lbl_PrecioVentaCliente.Text = "PrecioVentaCliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdProducto"
        '
        'frm_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 583)
        Me.Controls.Add(Me.grb_Productos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdFiltrarProd)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.grlGrilla)
        Me.Name = "frm_Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Productos"
        CType(Me.grlGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grb_Productos.ResumeLayout(False)
        Me.grb_Productos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grlGrilla As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents cmdFiltrarProd As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdAgregar As System.Windows.Forms.Button
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblAccion As System.Windows.Forms.Label
    Friend WithEvents grb_Productos As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_Cantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_IdSubRubro As System.Windows.Forms.Label
    Friend WithEvents txt_PrecioVentaCliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_CodigoBarra4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoBarra4 As System.Windows.Forms.Label
    Friend WithEvents txt_TipoCodBarra4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TipoCodBarra4 As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoBarra3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoBarra3 As System.Windows.Forms.Label
    Friend WithEvents txt_TipoCodBarra3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TipoCodBarra3 As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoBarra2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoBarra2 As System.Windows.Forms.Label
    Friend WithEvents txt_TipoCodBarra2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TipoCodBarra2 As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoBarra1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoBarra1 As System.Windows.Forms.Label
    Friend WithEvents txt_TipoCodBarra1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TipoCodBarra1 As System.Windows.Forms.Label
    Friend WithEvents txt_Venta As System.Windows.Forms.TextBox
    Friend WithEvents lvl_Venta As System.Windows.Forms.Label
    Friend WithEvents txt_Seccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Seccion As System.Windows.Forms.Label
    Friend WithEvents txt_IdSeccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_IdSeccion As System.Windows.Forms.Label
    Friend WithEvents txt_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents txt_CodigoMSP As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CodigoMSP As System.Windows.Forms.Label
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdAceptar As System.Windows.Forms.Button
    Friend WithEvents txt_CuitLaboratorio As System.Windows.Forms.TextBox
    Friend WithEvents txt_Laboratorio As System.Windows.Forms.TextBox
    Friend WithEvents txt_CodigoLaboratorio As System.Windows.Forms.TextBox
    Friend WithEvents txt_PrecioSugerido As System.Windows.Forms.TextBox
    Friend WithEvents cbo_IdSubRubro As System.Windows.Forms.ComboBox
    Friend WithEvents txt_IdProducto As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CuitLaboratorio As System.Windows.Forms.Label
    Friend WithEvents lbl_Laboratorio As System.Windows.Forms.Label
    Friend WithEvents lbl_CodigoLaboratorio As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioSugerido As System.Windows.Forms.Label
    Friend WithEvents lbl_PrecioVentaCliente As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
