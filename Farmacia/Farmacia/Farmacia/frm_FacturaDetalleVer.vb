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