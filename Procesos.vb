Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient



Public Class Procesos


    Dim objConn As Conexion
    Dim Cnn As SqlConnection
    Dim objCmd As SqlCommand
    Dim objAdapter As SqlDataAdapter
    Dim objDataTable As New DataTable


    Public Function LecturaDatosDT(ByVal uspConsultar As String) As DataTable
        Try
            objConn = New Conexion("(local)", "Bd_PubsPrueba_Java", "usrPrueba", "usrPrueba")
            objCmd = New SqlCommand(uspConsultar, objConn.Cnn)
            objCmd.CommandType = CommandType.StoredProcedure
            objAdapter = New SqlDataAdapter(objCmd)
            objAdapter.Fill(objDataTable)
            objConn.DesConectar()

            Return objDataTable

        Catch ex As Exception

            Return Nothing

        End Try

    End Function




    Public Function BuscarUsuarios(t As DataTable) As List(Of Persona)
        Dim p As New List(Of Persona)
        Dim pr As New Procesos
        Dim i As Integer

        t = pr.LecturaDatosDT("uspConsultar")

        For i = 0 To t.Rows.Count - 1

            p.Add(New Persona() With {
                  .id = t.Rows(i).Item(0),
                  .cedula = t.Rows(i).Item(1),
                  .nombre = t.Rows(i).Item(2),
                  .apellido = t.Rows(i).Item(3),
                  .direccion = t.Rows(i).Item(4),
                  .sexo = t.Rows(i).Item(5)
                  })
        Next

        Return p

    End Function









End Class
