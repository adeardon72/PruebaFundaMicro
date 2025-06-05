Imports System.ComponentModel.DataAnnotations

Public Class UserLogin
    <Required>
    Public Property THE_USER As String

    <Required>
    <DataType(DataType.Password)>
    Public Property THE_PSW As String
End Class
