Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_FacturaDetalle
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)

    End Sub

#Region "Cargar"
    Public Function AgregarFacturaDetalle(ByVal Letra As String, ByVal PuntoVenta As Integer, ByVal Numero As Integer, ByVal IdCliente As Integer, ByVal Fecha As Date) As Double
        Return oDatabase.ExecuteScalar("AgregarFacturaDetalle", Letra, PuntoVenta, Numero, IdCliente, Fecha)
    End Function
#End Region

End Class
