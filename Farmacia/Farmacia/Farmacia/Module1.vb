Imports System.Data.SqlClient
Imports System.Configuration
Module Module1
    Public con As New SqlConnection(ConfigurationManager.ConnectionStrings("Constring").ToString)
    Sub Conectar()
        con.Open()
        MessageBox.Show(con.State.ToString)
    End Sub
End Module
