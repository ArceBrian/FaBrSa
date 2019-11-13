Imports FarmaciaAD
Public Class frm_ClientesItem

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
                    Panel1.BackColor = Color.MediumAquamarine
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
        Dim oFarmacia As New C_ClientesItem

        oDs = oFarmacia.BuscarTodos

        grlGrilla1.DataSource = oDs.Tables(0)

        grlGrilla1.Columns(0).HeaderText = "Cod."
        grlGrilla1.Columns(0).Width = 50
        grlGrilla1.Columns(1).Width = 100
        grlGrilla1.Columns(2).Width = 100
        grlGrilla1.Columns(3).Width = 150
        grlGrilla1.Columns(4).Width = 100
        grlGrilla1.Columns(5).Width = 100
        grlGrilla1.Columns(6).Width = 50


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
        Dim oFarmacia As New C_ClientesItem

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

#Region "PasarDatosDesdeGrillaATxt"
    Private Sub grlGrilla1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrilla1.CellClick
        frm_Factura.txtIdCliente.Text = grlGrilla1.CurrentRow.Cells(0).Value.ToString
        frm_Factura.txtNombreCliente.Text = grlGrilla1.CurrentRow.Cells(1).Value.ToString
        frm_Factura.txtApellido.Text = grlGrilla1.CurrentRow.Cells(2).Value.ToString()
        frm_Factura.txtDireccion.Text = grlGrilla1.CurrentRow.Cells(3).Value.ToString()
        frm_Factura.txtLocalidad.Text = grlGrilla1.CurrentRow.Cells(4).Value.ToString()
        frm_Factura.txtTelefono.Text = grlGrilla1.CurrentRow.Cells(5).Value.ToString()
        frm_Factura.txtEstado.Text = grlGrilla1.CurrentRow.Cells(6).Value.ToString()
        Close()
    End Sub
#End Region

End Class