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
                    txt_IdProducto.Enabled = False
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
                    txt_IdProducto.Enabled = False
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

        cbo_IdSubRubro.DataSource = oDs.Tables(0)
        cbo_IdSubRubro.ValueMember = oDs.Tables(0).Columns(0).ToString
        cbo_IdSubRubro.DisplayMember = oDs.Tables(0).Columns(1).ToString

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

        txt_IdProducto.Text = oDs.Tables(0).Rows(0).Item("IdProducto")
        txt_CodigoMSP.Text = oDs.Tables(0).Rows(0).Item("CodigoMSP")
        txt_Descripcion.Text = oDs.Tables(0).Rows(0).Item("Descripcion")
        txt_IdSeccion.Text = oDs.Tables(0).Rows(0).Item("IdSeccion")
        txt_Seccion.Text = oDs.Tables(0).Rows(0).Item("Seccion")
        txt_Venta.Text = oDs.Tables(0).Rows(0).Item("Venta")
        txt_TipoCodBarra1.Text = oDs.Tables(0).Rows(0).Item("TipoCodBarra1")
        txt_CodigoBarra1.Text = oDs.Tables(0).Rows(0).Item("CodigoBarra1")
        txt_TipoCodBarra2.Text = oDs.Tables(0).Rows(0).Item("TipoCodBarra2")
        txt_CodigoBarra2.Text = oDs.Tables(0).Rows(0).Item("CodigoBarra2")
        txt_TipoCodBarra3.Text = oDs.Tables(0).Rows(0).Item("TipoCodBarra3")
        txt_CodigoBarra3.Text = oDs.Tables(0).Rows(0).Item("CodigoBarra3")
        txt_TipoCodBarra4.Text = oDs.Tables(0).Rows(0).Item("TipoCodBarra4")
        txt_CodigoBarra4.Text = oDs.Tables(0).Rows(0).Item("CodigoBarra4")
        txt_PrecioVentaCliente.Text = oDs.Tables(0).Rows(0).Item("PrecioVentaCliente")
        txt_PrecioSugerido.Text = oDs.Tables(0).Rows(0).Item("PrecioSugerido")
        txt_CodigoLaboratorio.Text = oDs.Tables(0).Rows(0).Item("CodigoLaboratorio")
        txt_Laboratorio.Text = oDs.Tables(0).Rows(0).Item("Laboratorio")
        txt_CuitLaboratorio.Text = oDs.Tables(0).Rows(0).Item("CuitLaboratorio")
        cbo_IdSubRubro.Text = oDs.Tables(0).Rows(0).Item("IdSubRubro")
        txt_Cantidad.Text = oDs.Tables(0).Rows(0).Item("Cantidad")

        oDs = Nothing
        oProducto = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txt_IdProducto.Text = " "
        txt_CodigoMSP.Text = " "
        txt_Descripcion.Text = " "
        txt_IdSeccion.Text = " "
        txt_Seccion.Text = " "
        txt_Venta.Text = " "
        txt_TipoCodBarra1.Text = " "
        txt_CodigoBarra1.Text = " "
        txt_TipoCodBarra2.Text = " "
        txt_CodigoBarra2.Text = " "
        txt_TipoCodBarra3.Text = " "
        txt_CodigoBarra3.Text = " "
        txt_TipoCodBarra4.Text = " "
        txt_CodigoBarra4.Text = " "
        txt_PrecioVentaCliente.Text = " "
        txt_PrecioSugerido.Text = " "
        txt_CodigoLaboratorio.Text = " "
        txt_Laboratorio.Text = " "
        txt_CuitLaboratorio.Text = " "
        CargarSubRubros()
        txt_Cantidad.Text = " "

    End Sub

    Private Sub HabililarEdicion()

        txt_IdProducto.Enabled = True
        txt_CodigoMSP.Enabled = True
        txt_Descripcion.Enabled = True
        txt_IdSeccion.Enabled = True
        txt_Seccion.Enabled = True
        txt_Venta.Enabled = True
        txt_TipoCodBarra1.Enabled = True
        txt_CodigoBarra1.Enabled = True
        txt_TipoCodBarra2.Enabled = True
        txt_CodigoBarra2.Enabled = True
        txt_TipoCodBarra3.Enabled = True
        txt_CodigoBarra3.Enabled = True
        txt_TipoCodBarra4.Enabled = True
        txt_CodigoBarra4.Enabled = True
        txt_PrecioVentaCliente.Enabled = True
        txt_PrecioSugerido.Enabled = True
        txt_CodigoLaboratorio.Enabled = True
        txt_Laboratorio.Enabled = True
        txt_CuitLaboratorio.Enabled = True
        cbo_IdSubRubro.Enabled = True
        txt_Cantidad.Enabled = True

    End Sub

    Private Sub DesHabililarEdicion()

        txt_IdProducto.Enabled = False
        txt_CodigoMSP.Enabled = False
        txt_Descripcion.Enabled = False
        txt_IdSeccion.Enabled = False
        txt_Seccion.Enabled = False
        txt_Venta.Enabled = False
        txt_TipoCodBarra1.Enabled = False
        txt_CodigoBarra1.Enabled = False
        txt_TipoCodBarra2.Enabled = False
        txt_CodigoBarra2.Enabled = False
        txt_TipoCodBarra3.Enabled = False
        txt_CodigoBarra3.Enabled = False
        txt_TipoCodBarra4.Enabled = False
        txt_CodigoBarra4.Enabled = False
        txt_PrecioVentaCliente.Enabled = False
        txt_PrecioSugerido.Enabled = False
        txt_CodigoLaboratorio.Enabled = False
        txt_Laboratorio.Enabled = False
        txt_CuitLaboratorio.Enabled = True
        cbo_IdSubRubro.Enabled = True
        txt_Cantidad.Enabled = True

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

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try

            If Validar() = True Then


                Dim oProducto As New C_Productos


                If Me.Estado = EstadodelFormulario.eEditar Then
                    oProducto.Modificar(txt_IdProducto.Text, txt_CodigoMSP.Text, txt_Descripcion.Text, txt_IdSeccion.Text, txt_Seccion.Text, txt_Venta.Text, txt_TipoCodBarra1.Text, txt_CodigoBarra1.Text, txt_TipoCodBarra2.Text, txt_CodigoBarra2.Text, txt_TipoCodBarra3.Text, txt_CodigoBarra3.Text, txt_TipoCodBarra4.Text, txt_CodigoBarra4.Text, txt_PrecioVentaCliente.Text, txt_PrecioSugerido.Text, txt_CodigoLaboratorio.Text, txt_Laboratorio.Text, txt_CuitLaboratorio.Text, cbo_IdSubRubro.Text, txt_Cantidad.Text)
                    MsgBox("Se modificó correctamente el subrubro con el código Nro: " + txt_IdProducto.Text, MsgBoxStyle.Information, "¡Éxitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oProducto.Agregar(txt_IdProducto.Text, txt_CodigoMSP.Text, txt_Descripcion.Text, txt_IdSeccion.Text, txt_Seccion.Text, txt_Venta.Text, txt_TipoCodBarra1.Text, txt_CodigoBarra1.Text, txt_TipoCodBarra2.Text, txt_CodigoBarra2.Text, txt_TipoCodBarra3.Text, txt_CodigoBarra3.Text, txt_TipoCodBarra4.Text, txt_CodigoBarra4.Text, txt_PrecioVentaCliente.Text, txt_PrecioSugerido.Text, txt_CodigoLaboratorio.Text, txt_Laboratorio.Text, txt_CuitLaboratorio.Text, cbo_IdSubRubro.Text, txt_Cantidad.Text)
                    MsgBox("Se agregó correctamente el rubro " + txt_IdProducto.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        If txt_Descripcion.Text = "" Then

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