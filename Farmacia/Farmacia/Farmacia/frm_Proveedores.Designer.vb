<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Proveedores))
        Me.grl_Grilla = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Accion = New System.Windows.Forms.Label()
        Me.grp_Informacion = New System.Windows.Forms.GroupBox()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.txtCompañia = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grl_Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.grp_Informacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grl_Grilla
        '
        Me.grl_Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_Grilla.Location = New System.Drawing.Point(12, 12)
        Me.grl_Grilla.Name = "grl_Grilla"
        Me.grl_Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grl_Grilla.Size = New System.Drawing.Size(535, 129)
        Me.grl_Grilla.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_Accion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 401)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 31)
        Me.Panel1.TabIndex = 16
        '
        'lbl_Accion
        '
        Me.lbl_Accion.AutoSize = True
        Me.lbl_Accion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Accion.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Accion.Name = "lbl_Accion"
        Me.lbl_Accion.Size = New System.Drawing.Size(0, 13)
        Me.lbl_Accion.TabIndex = 0
        '
        'grp_Informacion
        '
        Me.grp_Informacion.Controls.Add(Me.cmd_Aceptar)
        Me.grp_Informacion.Controls.Add(Me.cmd_Cancelar)
        Me.grp_Informacion.Controls.Add(Me.txtCargo)
        Me.grp_Informacion.Controls.Add(Me.txtDireccion)
        Me.grp_Informacion.Controls.Add(Me.txtLocalidad)
        Me.grp_Informacion.Controls.Add(Me.txtCompañia)
        Me.grp_Informacion.Controls.Add(Me.txtNombre)
        Me.grp_Informacion.Controls.Add(Me.txtIdProveedor)
        Me.grp_Informacion.Controls.Add(Me.Label6)
        Me.grp_Informacion.Controls.Add(Me.Label5)
        Me.grp_Informacion.Controls.Add(Me.Label4)
        Me.grp_Informacion.Controls.Add(Me.Label3)
        Me.grp_Informacion.Controls.Add(Me.Label2)
        Me.grp_Informacion.Controls.Add(Me.Label1)
        Me.grp_Informacion.Location = New System.Drawing.Point(109, 176)
        Me.grp_Informacion.Name = "grp_Informacion"
        Me.grp_Informacion.Size = New System.Drawing.Size(369, 185)
        Me.grp_Informacion.TabIndex = 15
        Me.grp_Informacion.TabStop = False
        Me.grp_Informacion.Text = "Datos Proveedor"
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Image = CType(resources.GetObject("cmd_Aceptar.Image"), System.Drawing.Image)
        Me.cmd_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Aceptar.Location = New System.Drawing.Point(276, 122)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(81, 23)
        Me.cmd_Aceptar.TabIndex = 5
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Image = CType(resources.GetObject("cmd_Cancelar.Image"), System.Drawing.Image)
        Me.cmd_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancelar.Location = New System.Drawing.Point(276, 151)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(81, 23)
        Me.cmd_Cancelar.TabIndex = 6
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(147, 158)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtCargo.TabIndex = 11
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(147, 133)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 10
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(147, 106)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.txtLocalidad.TabIndex = 9
        '
        'txtCompañia
        '
        Me.txtCompañia.Location = New System.Drawing.Point(147, 76)
        Me.txtCompañia.Name = "txtCompañia"
        Me.txtCompañia.Size = New System.Drawing.Size(100, 20)
        Me.txtCompañia.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(147, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Location = New System.Drawing.Point(147, 22)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtIdProveedor.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(81, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Cargo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Localidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Compañia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IdProvedor"
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Location = New System.Drawing.Point(391, 147)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Agregar.TabIndex = 14
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Location = New System.Drawing.Point(472, 147)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Modificar.TabIndex = 13
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Location = New System.Drawing.Point(18, 147)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Limpiar.TabIndex = 12
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(472, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 432)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grl_Grilla)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grp_Informacion)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Name = "frm_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        CType(Me.grl_Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grp_Informacion.ResumeLayout(False)
        Me.grp_Informacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grl_Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Accion As System.Windows.Forms.Label
    Friend WithEvents grp_Informacion As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCompañia As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
