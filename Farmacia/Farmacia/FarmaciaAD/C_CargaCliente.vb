Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class C_CargaCliente
    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

#Region "Cargar"
    Public Function Agregar(ByVal NombreCliente As String, ByVal ApellidoCliente As String, ByVal Direccion As String, ByVal Localidad As String, ByVal Telefono As String, ByVal IdEstado As Integer) As Double
        Return oDatabase.ExecuteScalar("ClientesAgregar", NombreCliente, ApellidoCliente, Direccion, Localidad, Telefono, IdEstado)
    End Function
#End Region

#Region "BuscarPorID"
    Public Function BuscarPorId(ByVal IdCliente As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("ClientesBuscarPorId", IdCliente)
    End Function
#End Region

#Region "BuscarPorNombre"
    Public Function BuscarPorNombre(ByVal txtNombre As String) As DataSet
        Return oDatabase.ExecuteDataSet("ClientesBuscarPorNombre", txtNombre)
    End Function
#End Region

#Region "Modifiacar"
    Public Function Modificar(ByVal IdCliente As Integer, ByVal NombreCliente As String, ByVal ApellidoCliente As String, ByVal Direccion As String, ByVal Localidad As String, ByVal Telefono As String, ByVal IdEstado As Integer) As Double
        Return oDatabase.ExecuteScalar("ClientesModificar", IdCliente, NombreCliente, ApellidoCliente, Direccion, Localidad, Telefono, IdEstado)
    End Function
#End Region

#Region "BuscarTodos"
    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("ClientesBuscarTodos")
    End Function
#End Region

#Region "FiltrarDatos"
    Public Function FiltrarDatos(ByVal NombreCliente As String) As DataSet
            Return oDatabase.ExecuteDataSet("FiltrarDatos", NombreCliente)
    End Function
#End Region

End Class
