Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_Productos
    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)

    End Sub


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProductosBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorIDProducto(ByVal IdProducto As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProductosBuscarID", IdProducto)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal IdSubRubro As Integer, ByVal Descripcion As String, ByVal Cantidad As Integer, ByVal CodigoMSP As Integer, ByVal PrecioVentaCliente As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("ProductossAgregar", IdSubRubro, Descripcion, Cantidad, CodigoMSP, PrecioVentaCliente)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdProducto As Integer, ByVal IdSubRubro As Integer, ByVal Descripcion As String, ByVal Cantidad As Integer, ByVal CodigoMSP As Integer, ByVal PrecioVentaCliente As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProductossModificar", IdProducto, IdSubRubro, Descripcion, Cantidad, CodigoMSP, PrecioVentaCliente)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
