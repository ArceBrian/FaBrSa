Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data



Public Class Rubros

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub

    Public Function BuscarPorID(ByVal IdRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("RubrosBuscarPorID", IdRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarPorID_Rubro(ByVal IdRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("RubrosBuscarPorID_Rubro", IdRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("RubrosBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function


    Public Function Agregar(ByVal Rubro As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("RubrosAgregar", Rubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdRubro As Integer, ByVal Rubro As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("RubrosModificar", IdRubro, Rubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
