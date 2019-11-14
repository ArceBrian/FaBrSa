<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SubRubros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SubRubros))
        Me.chk_Activo = New System.Windows.Forms.CheckBox()
        Me.lbl_Rubro = New System.Windows.Forms.Label()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cbo_Rubros = New System.Windows.Forms.ComboBox()
        Me.txt_SubRubro = New System.Windows.Forms.TextBox()
        Me.lbl_SubRubro = New System.Windows.Forms.Label()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.txt_Id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.grl_Grilla = New System.Windows.Forms.DataGridView()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Accion = New System.Windows.Forms.Label()
        CType(Me.grl_Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk_Activo
        '
        Me.chk_Activo.AutoSize = True
        Me.chk_Activo.Location = New System.Drawing.Point(59, 96)
        Me.chk_Activo.Name = "chk_Activo"
        Me.chk_Activo.Size = New System.Drawing.Size(56, 17)
        Me.chk_Activo.TabIndex = 20
        Me.chk_Activo.Text = "Activo"
        Me.chk_Activo.UseVisualStyleBackColor = True
        '
        'lbl_Rubro
        '
        Me.lbl_Rubro.AutoSize = True
        Me.lbl_Rubro.Location = New System.Drawing.Point(6, 45)
        Me.lbl_Rubro.Name = "lbl_Rubro"
        Me.lbl_Rubro.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Rubro.TabIndex = 19
        Me.lbl_Rubro.Text = "Rubro"
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Image = CType(resources.GetObject("cmd_Aceptar.Image"), System.Drawing.Image)
        Me.cmd_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Aceptar.Location = New System.Drawing.Point(165, 45)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(88, 23)
        Me.cmd_Aceptar.TabIndex = 17
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Image = CType(resources.GetObject("cmd_Cancelar.Image"), System.Drawing.Image)
        Me.cmd_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancelar.Location = New System.Drawing.Point(165, 73)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(88, 23)
        Me.cmd_Cancelar.TabIndex = 16
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cbo_Rubros
        '
        Me.cbo_Rubros.FormattingEnabled = True
        Me.cbo_Rubros.Location = New System.Drawing.Point(59, 42)
        Me.cbo_Rubros.Name = "cbo_Rubros"
        Me.cbo_Rubros.Size = New System.Drawing.Size(100, 21)
        Me.cbo_Rubros.TabIndex = 22
        '
        'txt_SubRubro
        '
        Me.txt_SubRubro.Location = New System.Drawing.Point(59, 70)
        Me.txt_SubRubro.Name = "txt_SubRubro"
        Me.txt_SubRubro.Size = New System.Drawing.Size(100, 20)
        Me.txt_SubRubro.TabIndex = 23
        '
        'lbl_SubRubro
        '
        Me.lbl_SubRubro.AutoSize = True
        Me.lbl_SubRubro.Location = New System.Drawing.Point(3, 73)
        Me.lbl_SubRubro.Name = "lbl_SubRubro"
        Me.lbl_SubRubro.Size = New System.Drawing.Size(55, 13)
        Me.lbl_SubRubro.TabIndex = 24
        Me.lbl_SubRubro.Text = "SubRubro"
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Location = New System.Drawing.Point(361, 168)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Modificar.TabIndex = 27
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Location = New System.Drawing.Point(280, 168)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Agregar.TabIndex = 25
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'txt_Id
        '
        Me.txt_Id.Location = New System.Drawing.Point(59, 13)
        Me.txt_Id.Name = "txt_Id"
        Me.txt_Id.Size = New System.Drawing.Size(100, 20)
        Me.txt_Id.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ID"
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Location = New System.Drawing.Point(12, 168)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Limpiar.TabIndex = 31
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Location = New System.Drawing.Point(2, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 0)
        Me.Panel2.TabIndex = 32
        '
        'grl_Grilla
        '
        Me.grl_Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_Grilla.Location = New System.Drawing.Point(12, 12)
        Me.grl_Grilla.Name = "grl_Grilla"
        Me.grl_Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grl_Grilla.Size = New System.Drawing.Size(424, 150)
        Me.grl_Grilla.TabIndex = 33
        '
        'cmd_Salir
        '
        Me.cmd_Salir.Location = New System.Drawing.Point(361, 344)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Salir.TabIndex = 34
        Me.cmd_Salir.Text = "&Salir"
        Me.cmd_Salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmd_Cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_Aceptar)
        Me.GroupBox1.Controls.Add(Me.lbl_Rubro)
        Me.GroupBox1.Controls.Add(Me.chk_Activo)
        Me.GroupBox1.Controls.Add(Me.cbo_Rubros)
        Me.GroupBox1.Controls.Add(Me.txt_SubRubro)
        Me.GroupBox1.Controls.Add(Me.txt_Id)
        Me.GroupBox1.Controls.Add(Me.lbl_SubRubro)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 127)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_Accion)
        Me.Panel1.Location = New System.Drawing.Point(1, 373)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 22)
        Me.Panel1.TabIndex = 36
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
        'frm_SubRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 396)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmd_Salir)
        Me.Controls.Add(Me.grl_Grilla)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Name = "frm_SubRubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SubRubros"
        CType(Me.grl_Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chk_Activo As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Rubro As System.Windows.Forms.Label
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cbo_Rubros As System.Windows.Forms.ComboBox
    Friend WithEvents txt_SubRubro As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SubRubro As System.Windows.Forms.Label
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents txt_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents grl_Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_Salir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Accion As System.Windows.Forms.Label
End Class
