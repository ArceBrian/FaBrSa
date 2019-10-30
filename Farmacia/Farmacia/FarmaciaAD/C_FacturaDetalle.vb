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
    Public Function AgregarFacturaDetalle(ByVal IdFactura As Integer, ByVal IdProducto As Integer, ByVal Cantidad As Integer, ByVal PrecioUnitario As Double, ByVal Total As Double) As Double
        Return oDatabase.ExecuteScalar("AgregarFacturaDetalle", IdFactura, IdProducto, Cantidad, PrecioUnitario, Total)
    End Function
#End Region

End Class
