Imports FarmaciaAD
Public Class frm_Login

    Private Sub CmdIniciar_Click(sender As System.Object, e As System.EventArgs) Handles CmdIniciar.Click


        Dim oDs As New DataSet
        Dim oUsuario As New C_Login


        oDs = oUsuario.BuscarPorLoginPass(TxtUsuario.Text, TxtPassword.Text)

        If oDs.Tables(0).Rows.Count > 0 Then


            ID_Usuario = oDs.Tables(0).Rows(0).Item("ID_Usuario")
            Nombre = oDs.Tables(0).Rows(0).Item("Nombre")

            frm_Menu.Show()


        Else

            MsgBox("El usuario y contraseña, no coinciden con un usuario válido", MsgBoxStyle.Exclamation, "Iniciar Sesión")

        End If



    End Sub
End Class