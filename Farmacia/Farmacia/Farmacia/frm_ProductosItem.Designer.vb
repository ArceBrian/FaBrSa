<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProductosItem
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
        Me.grlGrilla1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.cmdFiltrarD = New System.Windows.Forms.Button()
        Me.cmdLimpiar = New System.Windows.Forms.Button()
        CType(Me.grlGrilla1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grlGrilla1
        '
        Me.grlGrilla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grlGrilla1.Location = New System.Drawing.Point(13, 39)
        Me.grlGrilla1.Name = "grlGrilla1"
        Me.grlGrilla1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grlGrilla1.Size = New System.Drawing.Size(505, 240)
        Me.grlGrilla1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 27)
        Me.Panel1.TabIndex = 2
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
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(13, 12)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(155, 20)
        Me.txtFiltrar.TabIndex = 3
        '
        'cmdFiltrarD
        '
        Me.cmdFiltrarD.Location = New System.Drawing.Point(173, 10)
        Me.cmdFiltrarD.Name = "cmdFiltrarD"
        Me.cmdFiltrarD.Size = New System.Drawing.Size(125, 23)
        Me.cmdFiltrarD.TabIndex = 4
        Me.cmdFiltrarD.Text = "Buscar"
        Me.cmdFiltrarD.UseVisualStyleBackColor = True
        '
        'cmdLimpiar
        '
        Me.cmdLimpiar.Location = New System.Drawing.Point(12, 285)
        Me.cmdLimpiar.Name = "cmdLimpiar"
        Me.cmdLimpiar.Size = New System.Drawing.Size(125, 23)
        Me.cmdLimpiar.TabIndex = 5
        Me.cmdLimpiar.Text = "Limpiar"
        Me.cmdLimpiar.UseVisualStyleBackColor = True
        '
        'frm_ProductosItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 367)
        Me.Controls.Add(Me.cmdLimpiar)
        Me.Controls.Add(Me.cmdFiltrarD)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grlGrilla1)
        Me.Name = "frm_ProductosItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos item"
        CType(Me.grlGrilla1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents grlGrilla1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltrar As System.Windows.Forms.TextBox
    Friend WithEvents cmdFiltrarD As System.Windows.Forms.Button
    Friend WithEvents cmdLimpiar As System.Windows.Forms.Button
End Class
