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

    Public Function SumarStock(ByVal IdProducto As Integer, ByVal Cantidad As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Productos_SumarStock", IdProducto, Cantidad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function RestarStock(ByVal IdProducto As Integer, ByVal Cantidad As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("Productos_RestarStock", IdProducto, Cantidad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal IdProducto As Integer, ByVal CodigoMSP As Integer, ByVal Descripcion As String, ByVal IdSeccion As Integer, ByVal Seccion As String, ByVal Venta As Integer, ByVal TipoCodBarra1 As String, ByVal CodigoBarra1 As String, TipoCodBarra2 As String, CodigoBarra2 As String, TipoCodBarra3 As String, CodigoBarra3 As String, TipoCodBarra4 As String, CodigoBarra4 As String, ByVal PrecioVentaCliente As Integer, ByVal PrecioSugerido As Integer, ByVal CodigoLaboratorio As Integer, ByVal Laboratorio As String, ByVal CuitLaboratorio As Integer, ByVal IdSubRubro As Integer, ByVal Cantidad As Integer) As Double
        Try
            Return oDatabase.ExecuteScalar("ProductossAgregar", IdProducto, CodigoMSP, Descripcion, IdSeccion, Seccion, Venta, TipoCodBarra1, CodigoBarra1, TipoCodBarra2, CodigoBarra2, TipoCodBarra3, CodigoBarra3, TipoCodBarra4, CodigoBarra4, PrecioVentaCliente, PrecioSugerido, CodigoLaboratorio, Laboratorio, CuitLaboratorio, IdSubRubro, Cantidad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdProducto As Integer, ByVal CodigoMSP As Integer, ByVal Descripcion As String, ByVal IdSeccion As Integer, ByVal Seccion As String, ByVal Venta As Integer, ByVal TipoCodBarra1 As String, ByVal CodigoBarra1 As String, TipoCodBarra2 As String, CodigoBarra2 As String, TipoCodBarra3 As String, CodigoBarra3 As String, TipoCodBarra4 As String, CodigoBarra4 As String, ByVal PrecioVentaCliente As Integer, ByVal PrecioSugerido As Integer, ByVal CodigoLaboratorio As Integer, ByVal Laboratorio As String, ByVal CuitLaboratorio As Integer, ByVal IdSubRubro As Integer, ByVal Cantidad As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProductossModificar", IdProducto, CodigoMSP, Descripcion, IdSeccion, Seccion, Venta, TipoCodBarra1, CodigoBarra1, TipoCodBarra2, CodigoBarra2, TipoCodBarra3, CodigoBarra3, TipoCodBarra4, CodigoBarra4, PrecioVentaCliente, PrecioSugerido, CodigoLaboratorio, Laboratorio, CuitLaboratorio, IdSubRubro, Cantidad)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class
