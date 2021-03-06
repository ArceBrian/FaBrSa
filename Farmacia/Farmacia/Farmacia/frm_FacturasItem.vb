﻿Imports FarmaciaAD
Public Class frm_FacturasItem

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
        Dim oFarmacia As New C_FacturasItem

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

#Region "FiltrarD"
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ods As New DataSet
        Dim oFarmacia As New C_FacturasItem

        If txtFiltrar.Text <> Nothing Then

            ods = oFarmacia.FiltrarDatos(txtFiltrar.Text)
            grlFacturas.DataSource = ods.Tables(0)
            grlFacturas.Refresh()
        End If
    End Sub
#End Region

#Region "PasarDatosDesdeGrillaATxt"
    Private Sub grlFacturas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlFacturas.CellClick
        frm_Factura.txtIdFactura.Text = grlFacturas.CurrentRow.Cells(1).Value.ToString()
        frm_Factura.txtIdProd.Text = grlFacturas.CurrentRow.Cells(2).Value.ToString()
        frm_Factura.txtCantidad.Text = grlFacturas.CurrentRow.Cells(3).Value.ToString()
        frm_Factura.txtPrecioUnidad.Text = grlFacturas.CurrentRow.Cells(4).Value.ToString()
        frm_Factura.TextBox1.Text = grlFacturas.CurrentRow.Cells(5).Value.ToString()
        frm_Factura.txtTotal.Text = grlFacturas.CurrentRow.Cells(5).Value.ToString()
        Close()
    End Sub
#End Region

End Class