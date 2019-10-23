Imports FarmaciaAD
Public Class frm_ProductosItem

#Region "Variables"

    Private eEstado As EstadodelFormulario

#End Region

#Region "Enumeraciones"

    Public Enum EstadodelFormulario
        eConsulta = 1
    End Enum

#End Region

#Region "Propiedades"

    Public Property Estado() As EstadodelFormulario
        Get
            Return eEstado
        End Get
        Set(ByVal vNewValue As EstadodelFormulario)
            Select Case vNewValue
                Case EstadodelFormulario.eConsulta
                    Limpiar()
                    grlGrilla1.Enabled = True
                    Panel1.BackColor = Color.White
                    Label1.Text = "Consultando"
                    Label1.ForeColor = Color.Black
            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "Formulario"

    Private Sub frm_Proveedores(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eConsulta

    End Sub

#End Region

#Region "Procedimientos"


    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub

    Private Sub BuscarTodos()


        Dim oDs As New DataSet
        Dim oFarmacia As New C_ProductosItem

        oDs = oFarmacia.BuscarTodos

        grlGrilla1.DataSource = oDs.Tables(0)

        grlGrilla1.Columns(0).HeaderText = "Cod."
        grlGrilla1.Columns(0).Width = 50
        grlGrilla1.Columns(1).Width = 50
        grlGrilla1.Columns(2).Width = 250
        grlGrilla1.Columns(3).Width = 100


        oDs = Nothing
        oFarmacia = Nothing

    End Sub

    Private Sub Limpiar()
        CargarGrilla()
        txtFiltrar.Text = ""
    End Sub

#End Region

#Region "FiltarDatos"
    Private Sub cmdFiltrarD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFiltrarD.Click
        Dim ods As New DataSet
        Dim oFarmacia As New C_ProductosItem

        If txtFiltrar.Text <> Nothing Then

            ods = oFarmacia.FiltrarDatos(txtFiltrar.Text)
            grlGrilla1.DataSource = ods.Tables(0)
            grlGrilla1.Refresh()
        End If
    End Sub
#End Region

#Region "Botones de Comando"
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub
#End Region



    '#Region "Envair Datos a ota grilla"
    '    Private Sub grlGrilla1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrilla1.CellClick
    '        frm_Factura.TextBox2.Text = grlGrilla1.CurrentRow.Cells(0).Value.ToString
    '        frm_Factura.TextBox6.Text = grlGrilla1.CurrentRow.Cells(2).Value.ToString
    '        frm_Factura.TextBox7.Text = grlGrilla1.CurrentRow.Cells(3).Value.ToString
    '        Close()
    '    End Sub
    '#End Region


#Region "Envair Datos a ota grilla"
    Private Sub grlGrilla1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrilla1.CellClick

        frm_Factura.txtIdProd.Text = grlGrilla1.CurrentRow.Cells(0).Value.ToString
        frm_Factura.txtProducto.Text = grlGrilla1.CurrentRow.Cells(2).Value.ToString
        frm_Factura.txtPrecioUnidad.Text = grlGrilla1.CurrentRow.Cells(3).Value.ToString
        Close()
    End Sub
#End Region

End Class