Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_Proveedores

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorID(ByVal IdProveedor As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProveedorBuscarPorID", IdProveedor)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProveedorBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Agregar(ByVal Nombre As String, ByVal Compañia As String, ByVal Localidad As String, ByVal Direccion As String, ByVal Cargo As String) As Double
        Try
            Return oDatabase.ExecuteScalar("ProveedorAgregar", Nombre, Compañia, Localidad, Direccion, Cargo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdProveedor As Integer, ByVal Nombre As String, ByVal Compañia As String, ByVal Localidad As String, ByVal Direccion As String, ByVal Cargo As String) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("ProveedorModificar", IdProveedor, Nombre, Compañia, Localidad, Direccion, Cargo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
End Class

