Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
<System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class wsDemo03VB
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hola a todos"
    End Function



    <WebMethod()>
    Public Function BuscarPersona() As List(Of Persona)
        Dim t As DataTable
        Dim p As New List(Of Persona)
        Dim pr As New Procesos

        't = pr.LecturaDatosDT("uspConsultar")

        p = pr.BuscarUsuarios(t)
        Return p

    End Function

End Class