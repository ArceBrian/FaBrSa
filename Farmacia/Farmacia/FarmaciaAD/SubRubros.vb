Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data


Public Class SubRubros

    Dim oDatabase As Database

    Public Sub New()

        oDatabase = DatabaseFactory.CreateDatabase("Conn")

    End Sub

    Public Sub New(ByVal str As String)
    End Sub


    Public Function BuscarTodos() As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubrosBuscarTodos")
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID_Rubro(ByVal IdRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubrosBuscarPorID_Rubro", IdRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function BuscarPorID(ByVal IdSubRubro As Integer) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubrosBuscarPorID", IdSubRubro)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Agregar(ByVal IdRubro As Integer, ByVal SubRubro As String, ByVal Activo As Boolean) As Double
        Try
            Return oDatabase.ExecuteScalar("SubRubrosAgregar", IdRubro, SubRubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

    Public Function Modificar(ByVal IdSubRubro As Integer, ByVal IdRubro As Integer, ByVal SubRubro As String, ByVal Activo As Boolean) As DataSet
        Try
            Return oDatabase.ExecuteDataSet("SubRubrosModificar", IdSubRubro, IdRubro, SubRubro, Activo)
        Catch ex As System.Exception
            Throw ex
        End Try
    End Function

End Class
