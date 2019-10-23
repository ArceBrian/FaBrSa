Imports FarmaciaAD
Public Class frm_SubRubros

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
                    Cmd_Agregar.Enabled = True
                    cmd_Aceptar.Enabled = False
                    cmd_Cancelar.Enabled = False
                    grl_Grilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lbl_Accion.Text = "Consultando"
                    lbl_Accion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txt_ID.Enabled = False
                    cmd_Aceptar.Enabled = True
                    cmd_Cancelar.Enabled = True
                    DesHabililarComandos()
                    grl_Grilla.Enabled = False
                    Limpiar()
                    txt_SubRubro.Focus()
                    Panel1.BackColor = Color.GreenYellow
                    lbl_Accion.Text = "Agregando"
                    lbl_Accion.ForeColor = Color.Black

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txt_ID.Enabled = False
                    cmd_Aceptar.Enabled = True
                    cmd_Cancelar.Enabled = True
                    DesHabililarComandos()
                    grl_Grilla.Enabled = False
                    Panel1.BackColor = Color.GreenYellow
                    lbl_Accion.Text = "Modificando"
                    lbl_Accion.ForeColor = Color.Black



            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

#Region "Procedimientos"

    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub

    Private Sub CargarRubros()

        Dim oDs As New DataSet
        Dim oRubro As New Rubros

        oDs = oRubro.BuscarTodos

        cbo_Rubros.DataSource = oDs.Tables(0)
        cbo_Rubros.ValueMember = oDs.Tables(0).Columns(0).ToString
        cbo_Rubros.DisplayMember = oDs.Tables(0).Columns(1).ToString

        oDs = Nothing
        oRubro = Nothing

    End Sub

    Private Sub BuscarTodos()


        Dim oDs As New DataSet
        Dim oSubRubro As New SubRubros

        oDs = oSubRubro.BuscarTodos

        grl_Grilla.DataSource = oDs.Tables(0)

        grl_Grilla.Columns(0).HeaderText = "Cod."
        grl_Grilla.Columns(0).Width = 50


        oDs = Nothing
        oSubRubro = Nothing

    End Sub

    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim oSubRubro As New SubRubros

        oDs = oSubRubro.BuscarPorID(ID)

        txt_Id.Text = oDs.Tables(0).Rows(0).Item("IdSubRubro")
        txt_SubRubro.Text = oDs.Tables(0).Rows(0).Item("SubRubro")
        cbo_Rubros.SelectedValue = oDs.Tables(0).Rows(0).Item("IdRubro")
        chk_Activo.Checked = oDs.Tables(0).Rows(0).Item("Activo")

        oDs = Nothing
        oSubRubro = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txt_ID.Text = ""
        txt_SubRubro.Text = ""
        CargarRubros()
        chk_Activo.Checked = True


    End Sub

    Private Sub HabililarEdicion()

        txt_ID.Enabled = True
        txt_SubRubro.Enabled = True
        cbo_Rubros.Enabled = True
        chk_Activo.Enabled = True

    End Sub

    Private Sub DesHabililarEdicion()

        txt_ID.Enabled = False
        txt_SubRubro.Enabled = False
        cbo_Rubros.Enabled = False
        chk_Activo.Enabled = False


    End Sub

    Private Sub HabililarComandos()

        cmd_Agregar.Enabled = True
        cmd_Modificar.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()

        cmd_Agregar.Enabled = False
        cmd_Modificar.Enabled = False


    End Sub


#End Region

#Region "Formulario"

    Private Sub frm_SubRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Estado = EstadodelFormulario.eConsulta

    End Sub

#End Region

#Region "Botones de Comando"
    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Limpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub CmdModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Modificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Aceptar.Click

        Try

            If Validar() = True Then


                Dim oSubRubro As New SubRubros


                If Me.Estado = EstadodelFormulario.eEditar Then
                    oSubRubro.Modificar(txt_Id.Text, cbo_Rubros.SelectedValue, txt_SubRubro.Text, chk_Activo.Checked)
                    MsgBox("Se modificó correctamente el subrubro con el código Nro: " + txt_Id.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oSubRubro.Agregar(cbo_Rubros.SelectedValue, txt_SubRubro.Text, chk_Activo.Checked)
                    MsgBox("Se agregó correctamente el rubro " + txt_SubRubro.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
                End If

                Me.Estado = EstadodelFormulario.eConsulta

            End If

        Catch

            MsgBox("Sucedió un error", MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Cancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
               "Se perderán las ultimas modificaciones", _
               vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            Me.Estado = EstadodelFormulario.eConsulta

        End If


        Exit Sub
    End Sub

    Private Sub CmdAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Agregar.Click
        Me.Estado = EstadodelFormulario.eAgregar
    End Sub


#End Region

#Region "Funciones"

    Private Function Validar() As Boolean

        If txt_SubRubro.Text = "" Then

            MsgBox("Complete el nombre del subrubro", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If


        Return True

    End Function
#End Region

#Region "Grilla"
    Private Sub grl_Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grl_Grilla.CellContentClick

        BuscarPorID(grl_Grilla.CurrentRow.Cells(0).Value)
        cmd_Modificar.Enabled = True

    End Sub
#End Region

    'Private Sub frm_SubRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    CargarGrilla()
    'End Sub

#Region "Salir"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
#End Region

End Class