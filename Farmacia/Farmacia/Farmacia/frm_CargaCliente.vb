Imports FarmaciaAD
Public Class frm_CargaCliente
    Private Sub frm_CargaClientevb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

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
                    CmdAgregar.Enabled = True
                    CmdAceptar.Enabled = False
                    CmdCancelar.Enabled = False
                    grlGrilla.Enabled = True
                    Panel1.BackColor = Color.White
                    lblAccion.Text = "Consultando"
                    LblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eAgregar

                    HabililarEdicion()
                    txtIdCliente.Enabled = False
                    CmdAceptar.Enabled = True
                    CmdCancelar.Enabled = True
                    DesHabililarComandos()
                    grlGrilla.Enabled = False
                    Limpiar()
                    txtNombre.Focus()
                    txtApellido.Focus()
                    txtDireccion.Focus()
                    txtLocalidad.Focus()
                    txtTelefono.Focus()
                    txtEstado.Focus()
                    Panel1.BackColor = Color.GreenYellow
                    LblAccion.Text = "Agregando"
                    lblAccion.ForeColor = Color.Black

                Case EstadodelFormulario.eEditar

                    HabililarEdicion()
                    txtIdCliente.Enabled = False
                    CmdAceptar.Enabled = True
                    CmdCancelar.Enabled = True
                    DesHabililarComandos()
                    grlGrilla.Enabled = False
                    Panel1.BackColor = Color.GreenYellow
                    LblAccion.Text = "Modificando"
                    lblAccion.ForeColor = Color.Black
            End Select
            eEstado = vNewValue
        End Set
    End Property

#End Region

    '#Region "Formulario"

    '    Private Sub FrmRubros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '        Me.Estado = EstadodelFormulario.eConsulta

    '    End Sub

    '#End Region

#Region "Procedimientos"

    Private Sub CargarGrilla()

        BuscarTodos()

    End Sub

    Private Sub BuscarTodos()


        Dim oDs As New DataSet
        Dim oFarmacia As New C_CargaCliente

        grlGrilla.DataSource = Nothing
        oDs = oFarmacia.BuscarTodos

        grlGrilla.DataSource = oDs.Tables(0)

        grlGrilla.Columns(0).HeaderText = "Cod."
        grlGrilla.Columns(0).Width = 50
        grlGrilla.Refresh()

        oDs = Nothing
        oFarmacia = Nothing

    End Sub

    Private Sub BuscarPorID(ByVal ID As Integer)


        Dim oDs As New DataSet
        Dim oFarmacia As New C_CargaCliente

        oDs = oFarmacia.BuscarPorId(ID)

        txtIdCliente.Text = oDs.Tables(0).Rows(0).Item("IdCliente")
        txtNombre.Text = oDs.Tables(0).Rows(0).Item("NombreCliente")
        txtApellido.Text = oDs.Tables(0).Rows(0).Item("ApellidoCliente")
        txtDireccion.Text = oDs.Tables(0).Rows(0).Item("Direccion")
        txtLocalidad.Text = oDs.Tables(0).Rows(0).Item("Localidad")
        txtTelefono.Text = oDs.Tables(0).Rows(0).Item("Telefono")
        txtEstado.Text = oDs.Tables(0).Rows(0).Item("IdEstado")
        oDs = Nothing
        oFarmacia = Nothing

    End Sub

    Private Sub Limpiar()

        CargarGrilla()
        txtIdCliente.Text = ""
        TxtNombre.Text = ""
        txtApellido.Text = ""
        txtDireccion.Text = ""
        txtLocalidad.Text = ""
        txtTelefono.Text = ""
        txtEstado.Text = ""
        TextBox1.Text = ""

    End Sub

    Private Sub HabililarEdicion()

        txtIdCliente.Enabled = True
        TxtNombre.Enabled = True
        txtApellido.Enabled = True
        txtDireccion.Enabled = True
        txtLocalidad.Enabled = True
        txtTelefono.Enabled = True
        txtEstado.Enabled = True

    End Sub

    Private Sub DesHabililarEdicion()

        txtIdCliente.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        txtDireccion.Enabled = False
        txtLocalidad.Enabled = False
        txtTelefono.Enabled = False
        txtEstado.Enabled = False

    End Sub

    Private Sub HabililarComandos()

        CmdAgregar.Enabled = True
        CmdModificar.Enabled = True


    End Sub

    Private Sub DesHabililarComandos()

        CmdAgregar.Enabled = False
        CmdModificar.Enabled = False


    End Sub

#End Region

#Region "Botones de Comando"

    Private Sub frm_CargaClientevb_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmdLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click
        Me.Estado = EstadodelFormulario.eConsulta
    End Sub

    Private Sub cmdModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModificar.Click
        Me.Estado = EstadodelFormulario.eEditar
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAceptar.Click
        Try
            If Validar() = True Then

                Dim oFarmacia As New C_CargaCliente

                If Me.Estado = EstadodelFormulario.eEditar Then
                    oFarmacia.Modificar(txtIdCliente.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtLocalidad.Text, txtTelefono.Text, txtEstado.Text)
                    MsgBox("Se modificó correctamente el cliente con el código Nro: " + txtIdCliente.Text, MsgBoxStyle.Information, "Exitos!")
                End If

                If Me.Estado = EstadodelFormulario.eAgregar Then
                    Dim resultado As Integer
                    resultado = oFarmacia.Agregar(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtLocalidad.Text, txtTelefono.Text, txtEstado.Text)
                    MsgBox("Se agregó correctamente el cliente " + txtNombre.Text + " con el código Nro: " + resultado.ToString, MsgBoxStyle.Information, "Exitos!")
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

#Region "Grilla"
    Private Sub grl_Grilla_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrilla.CellContentClick

        BuscarPorID(grlGrilla.CurrentRow.Cells(0).Value)
        cmdModificar.Enabled = True

    End Sub
#End Region

    '#Region "Grilla"

    '    Private Sub Grilla_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellErrorTextNeededEventArgs) Handles grlGrilla.CellContentClick


    '        BuscarPorID(grlGrilla.CurrentRow.Cells(0).Value)
    '        cmdModificar.Enabled = True
    '    End Sub

    '#End Region

#Region "Funciones"

    Private Function Validar() As Boolean

        If TxtNombre.Text = "" Then

            MsgBox("Complete el nombre", MsgBoxStyle.Exclamation, "Mensaje")
            Return False

        End If

        Return True

    End Function

#End Region

#Region "Solo Numeros o Letras"
    Private Sub txtIdCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCliente.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEstado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEstado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub
#End Region

#Region "Salir"
    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub
#End Region

#Region "FiltrarDatosEnGrilla"
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim ods As New DataSet
        Dim oFarmacia As New C_CargaCliente

        If TextBox1.Text <> Nothing Then

            ods = oFarmacia.BuscarPorNombre(TextBox1.Text)
            grlGrilla.DataSource = ods.Tables(0)
            grlGrilla.Refresh()
        End If
    End Sub
#End Region




    '#Region "PasarDatosDesdeGrillaATxt"
    '    Private Sub grlGrilla_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrilla.CellClick
    '        frm_Factura.txtIdCliente.Text = grlGrilla.CurrentRow.Cells(0).Value.ToString
    '        frm_Factura.txtNombreCliente.Text = grlGrilla.CurrentRow.Cells(1).Value.ToString
    '        frm_Factura.txtApellido.Text = grlGrilla.CurrentRow.Cells(2).Value.ToString()
    '        frm_Factura.txtDireccion.Text = grlGrilla.CurrentRow.Cells(3).Value.ToString()
    '        frm_Factura.txtLocalidad.Text = grlGrilla.CurrentRow.Cells(4).Value.ToString()
    '        frm_Factura.txtTelefono.Text = grlGrilla.CurrentRow.Cells(5).Value.ToString()
    '        frm_Factura.txtEstado.Text = grlGrilla.CurrentRow.Cells(6).Value.ToString()
    '        Close()
    '    End Sub
    '#End Region

End Class