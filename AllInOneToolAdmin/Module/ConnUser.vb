Imports System.Data.SqlClient
Module ConnUser
    'Module Created By O2PSoftlabs
    Public Function connusers() As SqlConnection
        Dim dcmduser As New SqlCommand
        Dim conuser As SqlConnection

        conuser = New SqlConnection("server=195.91.172.114;uid=sa;pwd=ShadowRun007;database=RF_User;")
        Return conuser
        conuser = Nothing
    End Function
    Public dauser As SqlDataAdapter
    Public dtuser As New DataTable
    Public conuserc = ConnUser.connusers
    Public cmduser As SqlCommand
    Public rouser As SqlDataAdapter
    Public scmuser As SqlCommandBuilder
    Public dsuser As DataSet
    Public rduser As SqlDataReader
    Public sdbuser As Data.SqlClient.SqlDataAdapter
    Public perintahuser As SqlClient.SqlCommand
    Public sqlManagerAreauser As CurrencyManager
End Module
