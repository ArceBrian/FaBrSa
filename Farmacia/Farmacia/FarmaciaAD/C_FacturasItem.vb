Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_FacturasItem
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)

    End Sub


#Region "BuscarTodos"
    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("FacturasBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "BuscarPorID"
    Public Function BuscarPorId(ByVal IdFactura As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("FacturasBuscarPorId", IdFactura)
    End Function
#End Region

#Region "FiltrarDatos"
    Public Function FiltrarDatos(ByVal NombreCliente As String) As DataSet
        Return oDatabase.ExecuteDataSet("FacturasFiltrarDatos", NombreCliente)
    End Function
#End Region

End Class
