<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ClientesItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ClientesItem))
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        Me.cmdFiltrarD = New System.Windows.Forms.Button()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.grlGrilla1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grlGrilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(12, 280)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(125, 23)
        Me.cmdLimpiar.TabIndex = 9
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'cmdFiltrarD
        '
        Me.cmdFiltrarD.Image = CType(resources.GetObject("cmdFiltrarD.Image"), System.Drawing.Image)
        Me.cmdFiltrarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFiltrarD.Location = New System.Drawing.Point(173, 5)
        Me.cmdFiltrarD.Name = "cmdFiltrarD"
        Me.cmdFiltrarD.Size = New System.Drawing.Size(125, 23)
        Me.cmdFiltrarD.TabIndex = 8
        Me.cmdFiltrarD.Text = "Buscar nombre"
        Me.cmdFiltrarD.UseVisualStyleBackColor = True
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(12, 7)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(155, 20)
        Me.txtFiltrar.TabIndex = 7
        '
        'grlGrilla1
        '
        Me.grlGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlGrilla1.Location = New System.Drawing.Point(12, 34)
        Me.grlGrilla1.Name = "grlGrilla1"
        Me.grlGrilla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlGrilla1.Size = New System.Drawing.Size(505, 240)
        Me.grlGrilla1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 27)
        Me.Panel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'frm_ClientesItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 336)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdFiltrarD)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.grlGrilla1)
        Me.Name = "frm_ClientesItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes item"
        CType(Me.grlGrilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmdFiltrarD As System.Windows.Forms.Button
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Public WithEvents grlGrilla1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
