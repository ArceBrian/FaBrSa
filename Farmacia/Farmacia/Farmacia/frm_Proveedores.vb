Imports FarmaciaAD
Public Class frm_Proveedores

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
                    cmd_Agregar.Enabled = True
                    cmd_Aceptar.Enabled = False
                    cmd_Cancelar.Enabled = False
                    grl_Grilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lbl_Accion.Text = "Consultando"
                    lbl_Accion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txtIdProveedor.Enabled = False
                    cmd_Aceptar.Enabled = True
                    cmd_Cancelar.Enabled = True
                    DesHabililarComandos()
                    grl_Grilla.Enabled = False
                    Limpiar()
                    txtNombre.Focus()
                    txtCompañia.Focus()
                    txtLocalidad.Focus()
                    txtDireccion.Focus()
                    txtCargo.Focus()
                    Panel1.BackColor = Color.GreenYellow
                    lbl_Accion.Text = "Agregando"
                    lbl_Accion.ForeColor = Color.Black

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txtIdProveedor.Enabled = False
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
        Dim oFarmacia As New C_Proveedores

        oDs = oFarmacia.BuscarTodos

        grl_Grilla.DataSource = oDs.Tables(0)

        grl_Grilla.Columns(0).HeaderText = "Cod."
        grl_Grilla.Columns(0).Width = 50


        oDs = Nothing
        oFarmacia = Nothing

    End Sub
    '#Region "BuscarxID"
    '    Private Sub cmd_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Consultar.Click


    '        Dim oDs As New DataSet
    '        Dim oSubRubro As New SubRubros

    '        If txt_Id.Text <> Nothing Then
    '            oDs = oSubRubro.BuscarPorID(txt_Id.Text)


    '            If oDs.Tables(0).Rows.Count > 0 Then
    '                txt_Rubro.Text = oDs.Tables(0).Rows(0).Item("Rubro")
    '                chk_Activo.Checked = oDs.Tables(0).Rows(0).Item("Activo")
    '            End If
    '        Else
    '            MsgBox("Este ID es inexistente", vbInformation, "Cargar")
    '        End If
    '    End Sub
    '#End Region
    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim oFarmacia As New C_Proveedores

        oDs = oFarmacia.BuscarPorID(ID)

        txtIdProveedor.Text = oDs.Tables(0).Rows(0).Item("IdProveedor")
        txtNombre.Text = oDs.Tables(0).Rows(0).Item("Nombre")
        txtCompañia.Text = oDs.Tables(0).Rows(0).Item("Compañia")
        txtDireccion.Text = oDs.Tables(0).Rows(0).Item("Direccion")
        txtLocalidad.Text = oDs.Tables(0).Rows(0).Item("Localidad")
        txtCargo.Text = oDs.Tables(0).Rows(0).Item("Cargo")

        oDs = Nothing
        oFarmacia = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txtIdProveedor.Text = ""
        txtNombre.Text = ""
        txtCompañia.Text = ""
        txtDireccion.Text = ""
        txtLocalidad.Text = ""
        txtCargo.Text = ""

    End Sub

    Private Sub HabililarEdicion()

        txtIdProveedor.Enabled = True
        txtNombre.Enabled = True
        txtCompañia.Enabled = True
        txtDireccion.Enabled = True
        txtLocalidad.Enabled = True
        txtCargo.Enabled = True

    End Sub

    Private Sub DesHabililarEdicion()

        txtIdProveedor.Enabled = False
        txtNombre.Enabled = False
        txtCompañia.Enabled = False
        txtDireccion.Enabled = False
        txtLocalidad.Enabled = False
        txtCargo.Enabled = False

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


                Dim oFarmacia As New C_Proveedores


                If Me.Estado = EstadodelFormulario.eEditar Then
                    oFarmacia.Modificar(txtIdProveedor.Text, txtNombre.Text, txtCompañia.Text, txtLocalidad.Text, txtDireccion.Text, txtCargo.Text)
                    MsgBox("Se modificó correctamente el Proveedor con el código Nro: " + txtIdProveedor.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oFarmacia.Agregar(txtNombre.Text, txtCompañia.Text, txtLocalidad.Text, txtDireccion.Text, txtCargo.Text)
                    MsgBox("Se agregó correctamente el Proveedor " + txtNombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
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

        If txtNombre.Text = "" Then

            MsgBox("Complete el nombre del Proveedor", MsgBoxStyle.Exclamation, "Mensaje")
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

#Region "Salir"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
#End Region
End Class