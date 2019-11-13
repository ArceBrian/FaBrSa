Imports FarmaciaAD
Public Class frm_FacturaDetalleVer

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
                    grlFacturas.Enabled = True
                    Panel1.BackColor = Color.White
                    Label2.Text = "Consultando"
                    Label2.ForeColor = Color.Black
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
        Dim oFarmacia As New C_FacturasDetalleVer

        oDs = oFarmacia.BuscarTodos

        grlFacturas.DataSource = oDs.Tables(0)

        grlFacturas.Columns(0).HeaderText = "Cod."

        oDs = Nothing
        oFarmacia = Nothing
    End Sub

    Private Sub Limpiar()
        CargarGrilla()
        txtFiltrar.Text = ""
    End Sub

#End Region

#Region "BuscarID"
    Private Sub BuscarPorID(ByVal ID As Integer)

        Dim oDs As New DataSet
        Dim oFarmacia As New C_FacturasDetalleVer

        oDs = oFarmacia.BuscarPorId(ID)

        TextBox1.Text = oDs.Tables(0).Rows(0).Item("IdFacturaDetalle")
        TextBox2.Text = oDs.Tables(0).Rows(0).Item("IdFactura")
        TextBox3.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
        TextBox4.Text = oDs.Tables(0).Rows(0).Item("Cantidad")
        TextBox5.Text = oDs.Tables(0).Rows(0).Item("PrecioUnitario")
        TextBox6.Text = oDs.Tables(0).Rows(0).Item("Total")

        oDs = Nothing
        oFarmacia = Nothing

    End Sub

    Private Sub grlFacturas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlFacturas.CellContentClick
        BuscarPorID(grlFacturas.CurrentRow.Cells(0).Value)
    End Sub
#End Region

#Region "FiltrarD"
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ods As New DataSet
        Dim oFarmacia As New C_FacturasDetalleVer
        If txtFiltrar.Text <> Nothing Then
            ods = oFarmacia.FiltrarDatos(txtFiltrar.Text)
            grlFacturas.DataSource = ods.Tables(0)
            grlFacturas.Refresh()
        End If
    End Sub
#End Region

End Class