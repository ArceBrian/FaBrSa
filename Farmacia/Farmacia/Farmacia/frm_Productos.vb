Imports FarmaciaAD
Public Class frm_Productos
#Region "Variables"

    Private eEstado As EstadodelFormulario

#End Region

#Region "Enumeraciones"

    Public Enum EstadodelFormulario
        eConsulta = 1
        eAgregar = 2
        eEditar = 3
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
                    DesHabililarEdicion()
                    DesHabililarComandos()
                    cmdAgregar.Enabled = True
                    cmdAceptar.Enabled = False
                    cmdCancelar.Enabled = False
                    grlGrilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lblAccion.Text = "Consultando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txtIdProducto.Enabled = False
                    cmdAceptar.Enabled = True
                    cmdCancelar.Enabled = True
                    DesHabililarComandos()
                    grlGrilla.Enabled = False
                    Limpiar()
                    'txtSubRubro.Focus()
                    Panel1.BackColor = Color.GreenYellow
                    lblAccion.Text = "Agregando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txtIdProducto.Enabled = False
                    cmdAceptar.Enabled = True
                    cmdCancelar.Enabled = True
                    DesHabililarComandos()
                    grlGrilla.Enabled = False
                    Panel1.BackColor = Color.GreenYellow
                    lblAccion.Text = "Modificando"
                    lblAccion.ForeColor = Color.Black



            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "Procedimientos"

    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub

    Private Sub CargarSubRubros()
        Dim oDs As New DataSet
        Dim oSubRubro As New SubRubros

        oDs = oSubRubro.BuscarTodos

        cboSubRubro.DataSource = oDs.Tables(0)
        cboSubRubro.ValueMember = oDs.Tables(0).Columns(0).ToString
        cboSubRubro.DisplayMember = oDs.Tables(0).Columns(1).ToString

        oDs = Nothing
        oSubRubro = Nothing
    End Sub


    Private Sub BuscarTodos()
        Dim oDs As New DataSet
        Dim oSubRubro As New C_Productos

        oDs = oSubRubro.BuscarTodos

        grlGrilla.DataSource = oDs.Tables(0)

        grlGrilla.Columns(0).HeaderText = "Cod."
        grlGrilla.Columns(0).Width = 50


        oDs = Nothing
        oSubRubro = Nothing
    End Sub


    Private Sub BuscarPorID(ByVal IdProducto As Integer)


        Dim oDs As New DataSet
        Dim oProducto As New C_Productos

        oDs = oProducto.BuscarPorIDProducto(IdProducto)

        txtIdProducto.Text = oDs.Tables(0).Rows(0).Item("IdProducto")
        cboSubRubro.Text = oDs.Tables(0).Rows(0).Item("IdSubRubro")
        txtProducto.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
        txtCantidad.Text = oDs.Tables(0).Rows(0).Item("Cantidad")
        txtTroquel.Text = oDs.Tables(0).Rows(0).Item("CodigoMSP")
        txtPrecioUnidad.Text = oDs.Tables(0).Rows(0).Item("PrecioVentaCliente")

        oDs = Nothing
        oProducto = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txtIdProducto.Text = ""
        txtProducto.Text = ""
        txtCantidad.Text = ""
        txtTroquel.Text = ""
        txtPrecioUnidad.Text = ""
        CargarSubRubros()

    End Sub

    Private Sub HabililarEdicion()

        txtIdProducto.Enabled = True
        txtProducto.Enabled = True
        txtCantidad.Enabled = True
        txtTroquel.Enabled = True
        txtPrecioUnidad.Enabled = True
        cboSubRubro.Enabled = True

    End Sub

    Private Sub DesHabililarEdicion()

        txtIdProducto.Enabled = False
        txtProducto.Enabled = False
        txtCantidad.Enabled = False
        txtTroquel.Enabled = False
        txtPrecioUnidad.Enabled = False
        cboSubRubro.Enabled = False

    End Sub

    Private Sub HabililarComandos()

        cmdAgregar.Enabled = True
        cmdModificar.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()

        cmdAgregar.Enabled = False
        cmdModificar.Enabled = False


    End Sub


#End Region


#Region "Formulario"

    Private Sub frm_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eConsulta

    End Sub

#End Region

#Region "Botones de Comando"
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click

        Try

            If Validar() = True Then


                Dim oProducto As New C_Productos


                If Me.Estado = EstadodelFormulario.eEditar Then
                    oProducto.Modificar(txtIdProducto.Text, cboSubRubro.SelectedValue, txtProducto.Text, txtCantidad.Text, txtTroquel.Text, txtPrecioUnidad.Text)
                    MsgBox("Se modificó correctamente el subrubro con el código Nro: " + txtIdProducto.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oProducto.Agregar(cboSubRubro.SelectedValue, txtProducto.Text, txtCantidad.Text, txtTroquel.Text, txtPrecioUnidad.Text)
                    MsgBox("Se agregó correctamente el rubro " + txtProducto.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
               "Se perderán las ultimas modificaciones", _
               vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If


        Exit Sub
    End Sub

    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgregar.Click
        Me.Estado = EstadodelFormulario.eAgregar
    End Sub


#End Region

#Region "Funciones"

    Private Function Validar() As Boolean

        If txtProducto.Text = "" Then

            MsgBox("Complete el nombre del subrubro", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function
#End Region

#Region "Grilla"
    Private Sub grl_Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrilla.CellContentClick

        BuscarPorID(grlGrilla.CurrentRow.Cells(0).Value)
        cmdModificar.Enabled = True

    End Sub
#End Region
End Class