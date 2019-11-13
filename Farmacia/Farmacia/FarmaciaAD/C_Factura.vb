Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_Factura
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)

    End Sub

#Region "TipoFactura"
    Public Function TipoFactura() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("TipoFactura")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "CondicionIva"
    Public Function Condicion() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("CondicionesIvabuscar")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "FacturasBuscar"
    Public Function FacturaBuscar() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("FacturasBuscar")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "NumeroComprobante"
    Public Function NumeroComprobante() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("NumeroComprobante")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "Cargar"
    Public Function AgregarFactura(ByVal Letra As String, ByVal PuntoVenta As Integer, ByVal Numero As Integer, ByVal IdCliente As Integer, ByVal Fecha As Date, ByVal Total As Double) As Double
        Return oDatabase.ExecuteScalar("AgregarFactura", Letra, PuntoVenta, Numero, IdCliente, Fecha, Total)
    End Function
#End Region


End Class
