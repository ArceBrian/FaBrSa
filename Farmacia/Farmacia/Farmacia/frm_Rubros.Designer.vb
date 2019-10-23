<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Rubros
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
        Me.grl_Grilla = New System.Windows.Forms.DataGridView()
        Me.chk_Activo = New System.Windows.Forms.CheckBox()
        Me.lbl_Rubro = New System.Windows.Forms.Label()
        Me.txt_Rubro = New System.Windows.Forms.TextBox()
        Me.cmd_Aceptar = New System.Windows.Forms.Button()
        Me.cmd_Cancelar = New System.Windows.Forms.Button()
        Me.cmd_Agregar = New System.Windows.Forms.Button()
        Me.cmd_Modificar = New System.Windows.Forms.Button()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.cmd_Limpiar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_Accion = New System.Windows.Forms.Label()
        CType(Me.grl_Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grl_Grilla
        '
        Me.grl_Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grl_Grilla.Location = New System.Drawing.Point(12, 12)
        Me.grl_Grilla.Name = "grl_Grilla"
        Me.grl_Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grl_Grilla.Size = New System.Drawing.Size(400, 150)
        Me.grl_Grilla.TabIndex = 15
        '
        'chk_Activo
        '
        Me.chk_Activo.AutoSize = True
        Me.chk_Activo.Location = New System.Drawing.Point(41, 78)
        Me.chk_Activo.Name = "chk_Activo"
        Me.chk_Activo.Size = New System.Drawing.Size(56, 17)
        Me.chk_Activo.TabIndex = 14
        Me.chk_Activo.Text = "Activo"
        Me.chk_Activo.UseVisualStyleBackColor = True
        '
        'lbl_Rubro
        '
        Me.lbl_Rubro.AutoSize = True
        Me.lbl_Rubro.Location = New System.Drawing.Point(-1, 55)
        Me.lbl_Rubro.Name = "lbl_Rubro"
        Me.lbl_Rubro.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Rubro.TabIndex = 13
        Me.lbl_Rubro.Text = "Rubro"
        '
        'txt_Rubro
        '
        Me.txt_Rubro.Location = New System.Drawing.Point(41, 52)
        Me.txt_Rubro.Name = "txt_Rubro"
        Me.txt_Rubro.Size = New System.Drawing.Size(109, 20)
        Me.txt_Rubro.TabIndex = 12
        '
        'cmd_Aceptar
        '
        Me.cmd_Aceptar.Location = New System.Drawing.Point(156, 26)
        Me.cmd_Aceptar.Name = "cmd_Aceptar"
        Me.cmd_Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Aceptar.TabIndex = 11
        Me.cmd_Aceptar.Text = "Aceptar"
        Me.cmd_Aceptar.UseVisualStyleBackColor = True
        '
        'cmd_Cancelar
        '
        Me.cmd_Cancelar.Location = New System.Drawing.Point(156, 55)
        Me.cmd_Cancelar.Name = "cmd_Cancelar"
        Me.cmd_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Cancelar.TabIndex = 10
        Me.cmd_Cancelar.Text = "Cancelar"
        Me.cmd_Cancelar.UseVisualStyleBackColor = True
        '
        'cmd_Agregar
        '
        Me.cmd_Agregar.Location = New System.Drawing.Point(256, 168)
        Me.cmd_Agregar.Name = "cmd_Agregar"
        Me.cmd_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Agregar.TabIndex = 16
        Me.cmd_Agregar.Text = "Agregar"
        Me.cmd_Agregar.UseVisualStyleBackColor = True
        '
        'cmd_Modificar
        '
        Me.cmd_Modificar.Location = New System.Drawing.Point(337, 168)
        Me.cmd_Modificar.Name = "cmd_Modificar"
        Me.cmd_Modificar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Modificar.TabIndex = 18
        Me.cmd_Modificar.Text = "Modificar"
        Me.cmd_Modificar.UseVisualStyleBackColor = True
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(41, 26)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(109, 20)
        Me.txt_ID.TabIndex = 19
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(-1, 29)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(18, 13)
        Me.lbl_ID.TabIndex = 20
        Me.lbl_ID.Text = "ID"
        '
        'cmd_Limpiar
        '
        Me.cmd_Limpiar.Location = New System.Drawing.Point(12, 168)
        Me.cmd_Limpiar.Name = "cmd_Limpiar"
        Me.cmd_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.cmd_Limpiar.TabIndex = 22
        Me.cmd_Limpiar.Text = "Limpiar"
        Me.cmd_Limpiar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(337, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "&Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_Aceptar)
        Me.GroupBox1.Controls.Add(Me.cmd_Cancelar)
        Me.GroupBox1.Controls.Add(Me.txt_Rubro)
        Me.GroupBox1.Controls.Add(Me.lbl_Rubro)
        Me.GroupBox1.Controls.Add(Me.lbl_ID)
        Me.GroupBox1.Controls.Add(Me.chk_Activo)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 207)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 103)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese datos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_Accion)
        Me.Panel1.Location = New System.Drawing.Point(2, 384)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 22)
        Me.Panel1.TabIndex = 25
        '
        'lbl_Accion
        '
        Me.lbl_Accion.AutoSize = True
        Me.lbl_Accion.Location = New System.Drawing.Point(3, 1)
        Me.lbl_Accion.Name = "lbl_Accion"
        Me.lbl_Accion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Accion.TabIndex = 0
        Me.lbl_Accion.Text = "Label1"
        '
        'frm_Rubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 407)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmd_Limpiar)
        Me.Controls.Add(Me.cmd_Modificar)
        Me.Controls.Add(Me.cmd_Agregar)
        Me.Controls.Add(Me.grl_Grilla)
        Me.Name = "frm_Rubros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rubros"
        CType(Me.grl_Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grl_Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents chk_Activo As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Rubro As System.Windows.Forms.Label
    Friend WithEvents txt_Rubro As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Aceptar As System.Windows.Forms.Button
    Friend WithEvents cmd_Cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmd_Modificar As System.Windows.Forms.Button
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ID As System.Windows.Forms.Label
    Friend WithEvents cmd_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Accion As System.Windows.Forms.Label
End Class
