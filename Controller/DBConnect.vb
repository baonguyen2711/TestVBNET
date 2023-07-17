Imports System.Data.SqlClient
Imports System.Web.Configuration

Public Class DBConnect
    Private Shared instance As SqlConnection
    Private Shared lockObject As New Object()

    Private Sub New()
        ' Private constructor to prevent direct instantiation
    End Sub

    Public Shared Function GetInstance() As SqlConnection
        Dim connectionString As String = "Data Source=DNCPU0100\MSSQLSERVER2019;Initial Catalog=HRM_Table;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Return connection
    End Function

End Class

