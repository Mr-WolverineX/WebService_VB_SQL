Imports Microsoft.VisualBasic
Imports System.Data.SqlClient



Public Class Conexion

    Public Cnn As SqlConnection
    Private _CadenaConexion As String
    Private _Origen As String
    Private _BaseDatos As String
    Private _UsuarioDB As String
    Private _ClaveDB As String


    Public Sub New()

    End Sub




    Public Sub New(pOrigen As String, pBaseDatos As String,
                   pUsuarioDB As String, ClaveDB As String)
        Dim r As Integer

        _Origen = pOrigen
        _BaseDatos = pBaseDatos
        _UsuarioDB = pUsuarioDB
        _ClaveDB = ClaveDB
        _CadenaConexion = GenerarCadena()

        r = Conectar()
    End Sub


    Public Function GenerarCadena() As String
        Dim strCadena As String = String.Format("Data Source={0};" +
                                                "Initial Catalog={1};" +
                                                "User id={2};" +
                                                "Password={3};" +
                                                "Connect Timeout=600",
                                                _Origen, _BaseDatos,
                                                _UsuarioDB, _ClaveDB)
        Return strCadena
    End Function



    Public Function Conectar() As Integer
        Dim r As Integer
        Try
            Cnn = New SqlConnection(_CadenaConexion)
            Cnn.Open()
            r = 1
        Catch ex As Exception
            r = -1
        End Try

        Return r

    End Function


    Public Function DesConectar() As Integer
        Dim r As Integer

        Try
            Cnn.Close()
            r = 1 ' Satisfactorio  

        Catch ex As Exception

            r = -1 ' Error  

        End Try
        Return r

    End Function



















End Class
