Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_FacturasDetalleVer
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)

    End Sub


#Region "BuscarTodos"
    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("FacturasBuscarTodos")
    End Function
#End Region
End Class
