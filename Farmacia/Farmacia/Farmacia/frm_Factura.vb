Imports FarmaciaAD
Public Class frm_Factura
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frm_ClientesItem.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        frm_ProductosItem.ShowDialog()
        txtCantidad.Focus()
    End Sub

#Region "Prueba NO VA"
    '    Private Sub cmdAgregar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregar.Click
    '        Dim total As Double = 0
    '        Dim fila As DataGridViewRow = New DataGridViewRow
    '        Dim totalpagar As Double = 0
    '        Dim descuento As Double = 0

    '        Dim IdProducto As Double
    '        Dim Producto As String
    '        Dim cantidad As Double
    '        Dim PrecioUnidad As Double

    '        IdProducto = txtIdProd.Text
    '        Producto = txtProducto.Text
    '        cantidad = txtCantidad.Text
    '        PrecioUnidad = txtPrecioUnidad.Text


    '        total = Val(txtCantidad.Text) * Val(txtPrecioUnidad.Text)

    '        Try
    '            grlGrillaa.Rows.Add(IdProducto, Producto, cantidad, PrecioUnidad, total)


    '            For Each fila In grlGrillaa.Rows
    '                totalpagar += Convert.ToDouble(fila.Cells("total").Value)
    '                totalpagar = totalpagar
    '            Next
    '            txtTotal.Text = totalpagar

    '        Catch ex As Exception

    '        End Try

    '    End Sub
#End Region



#Region "Suma de prod"
    Private Sub cmdAgregar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAgregar.Click

        Dim suma As Double

        suma = CDbl(txtCantidad.Text) * CDbl(txtPrecioUnidad.Text)
        TextBox1.Text = CDbl(suma)

        grlGrillaa.Rows.Add(txtIdProd.Text, txtProducto.Text, txtCantidad.Text, txtPrecioUnidad.Text, TextBox1.Text)

        Dim linea As DataGridViewRow
        Dim valor As Double

        For Each linea In grlGrillaa.Rows
            valor = valor + linea.Cells(4).Value
        Next

        txtSubTotal.Text = "$" & FormatNumber(valor, 2)
        txtDescuento.Text = "0.00"
        txtTotal.Text = "$" & FormatNumber(valor, 2)

    End Sub
#End Region

#Region "Tamaño de celdas de la grilla"
    Private Sub grlGrillaa_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grlGrillaa.CellContentClick
        grlGrillaa.Columns(0).HeaderText = "Cod."
        grlGrillaa.Columns(0).Width = 50
        grlGrillaa.Columns(1).Width = 50
        grlGrillaa.Columns(2).Width = 250
        grlGrillaa.Columns(3).Width = 100
    End Sub
#End Region

#Region "Remover filas de la grilla"
    Private Sub cmdQuitar_Click(sender As System.Object, e As System.EventArgs) Handles cmdQuitar.Click
        For Each r As DataGridViewRow In grlGrillaa.SelectedRows
            grlGrillaa.Rows.Remove(r)
        Next
    End Sub
#End Region

#Region "Load"
    Private Sub frm_Factura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cargarcboFacturas()
        CondicionesIva()

        Panel1.BackColor = Color.GreenYellow
        Label10.Text = "Agregando"
        Label10.ForeColor = Color.Black

        Dim Punto As Integer = 1
        Dim Nro As Integer = 1

        txtPuntoVenta.Text = String.Format("{0:0000}", Punto)
        txtNroComp.Text = String.Format("{0:000000}", Nro)

        NumeroComprobante()

    End Sub
#End Region

#Region "Cargar cbo Facturas"
    Private Sub cargarcboFacturas()
        Dim ods As New DataSet
        Dim oFactura As New C_Factura
        ods = oFactura.TipoFactura
        cboTipoFact.DataSource = ods.Tables(0)
        cboTipoFact.DisplayMember = "Descripcion"
        cboTipoFact.ValueMember = "IdTipoFactura"

        'cboTipoFact.SelectedItem = (ods.Tables(0).Rows(0).Item("IdTipoFactura")).ToString
        'cboTipoFact.Text = (ods.Tables(0).Rows(0).Item("Descripcion")).ToString
    End Sub
#End Region

#Region "Cargar cbo Condicion de Iva"
    Private Sub CondicionesIva()
        Dim ods As New DataSet
        Dim oFactura As New C_Factura
        ods = oFactura.Condicion
        cboCondicion.DataSource = ods.Tables(0)
        cboCondicion.DisplayMember = "Descripcion"
        cboCondicion.ValueMember = "IdIva"

        'cboTipoFact.SelectedItem = (ods.Tables(0).Rows(0).Item("IdTipoFactura")).ToString
        'cboTipoFact.Text = (ods.Tables(0).Rows(0).Item("Descripcion")).ToString
    End Sub
#End Region

#Region "Nro comprobante"
    Private Sub NumeroComprobante()
        txtNroComp.Text = ""
        Dim ods As New DataSet
        Dim oFactura As New C_Factura

        ods = oFactura.NumeroComprobante

        txtNroComp.Text = ods.Tables(0).Rows(0).Item("IdFactura")
    End Sub
#End Region

#Region "Color en el txtCantidad"
    Private Sub txtCantidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCantidad.TextChanged

        If Len(txtCantidad.Text) > 0 Then
            txtCantidad.BackColor = Color.GreenYellow
        Else
            txtCantidad.BackColor = Color.White
        End If
    End Sub
#End Region

#Region "Boton Aceptar"
    Private Sub cmdAceptar_Click(sender As System.Object, e As System.EventArgs) Handles cmdAceptar.Click
        Dim Nro As Integer = Convert.ToInt16(txtNroComp.Text)
        Nro += 1
        txtNroComp.Text = Nro.ToString("D5") 'Numero Comprobante


            Dim oFactura As New C_Factura
            Dim oFacturaDetalle As New C_FacturaDetalle
            Dim oProducto As New C_Productos
            Dim resultado As Integer

            'PARA FECHA ES .VALUE.DATE

            resultado = oFactura.AgregarFactura(cboCondicion.SelectedValue, txtPuntoVenta.Text, txtNroComp.Text, txtIdCliente.Text, DateTimePicker1.Value.Date, txtTotal.Text)


            For i = 0 To grlGrillaa.Rows.Count - 2

                oFacturaDetalle.AgregarFacturaDetalle(resultado, grlGrillaa.Rows(i).Cells(0).Value, grlGrillaa.Rows(i).Cells(2).Value, grlGrillaa.Rows(i).Cells(3).Value, grlGrillaa.Rows(i).Cells(4).Value)

                oProducto.RestarStock(grlGrillaa.Rows(i).Cells(0).Value, grlGrillaa.Rows(i).Cells(2).Value)

            Next

        MsgBox("Se realizó la factura exitosamente!")



    End Sub
#End Region

#Region "Cancelar"
    Private Sub cmdCancelar_Click(sender As System.Object, e As System.EventArgs) Handles cmdCancelar.Click
        If MsgBox("Esta seguro de Cancelar?" & vbCrLf & _
              "Se perderán las ultimas modificaciones", _
              vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            grlGrillaa.Rows.Clear()
            txtIdCliente.Text = ""
            txtNombreCliente.Text = ""
            txtApellido.Text = ""
            txtDireccion.Text = ""
            txtLocalidad.Text = ""
            txtTelefono.Text = ""
            txtEstado.Text = ""
            txtIdProd.Text = ""
            txtProducto.Text = ""
            txtCantidad.Text = ""
            txtPrecioUnidad.Text = ""
            TextBox1.Text = ""
            txtSubTotal.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = ""
        End If
    End Sub
#End Region

#Region "Limpair"
    Private Sub cmdLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles cmdLimpiar.Click
        If MsgBox("Esta seguro de limpiar el formulario?" & vbCrLf & _
      "Se perderán las ultimas modificaciones", _
      vbYesNo, "Confirmacion de Accion") = MsgBoxResult.Yes Then

            grlGrillaa.Rows.Clear()
            txtIdCliente.Text = ""
            txtNombreCliente.Text = ""
            txtApellido.Text = ""
            txtDireccion.Text = ""
            txtLocalidad.Text = ""
            txtTelefono.Text = ""
            txtEstado.Text = ""
            txtIdProd.Text = ""
            txtProducto.Text = ""
            txtCantidad.Text = ""
            txtPrecioUnidad.Text = ""
            TextBox1.Text = ""
            txtSubTotal.Text = ""
            txtDescuento.Text = ""
            txtTotal.Text = ""
        End If
    End Sub
#End Region

End Class