Imports FarmaciaAD
Public Class frm_FacturaDetalleVer


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

End Class