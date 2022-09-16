Public Class Persona


    Public id As Integer
    Public cedula As String
    Public nombre As String
    Public apellido As String
    Public direccion As String
    Public sexo As String


    Public Sub New()
        id = 0
        cedula = ""
        nombre = ""
        apellido = ""
        direccion = ""
        sexo = ""

    End Sub


    Public Sub New(pid As Integer, pcedula As String,
                   pnombre As String, papellido As String,
                   pdireccion As String, psexo As String)

        id = pid
        cedula = pcedula
        nombre = pnombre
        apellido = papellido
        direccion = pdireccion
        sexo = psexo

    End Sub







End Class
