Imports System.Data.SqlClient
Module ConnWorld
    'Module Created By O2PSoftlabs
    Public Function connworlds() As SqlConnection
        Dim dcmdworld As New SqlCommand
        Dim conworld As SqlConnection

        conworld = New SqlConnection("server=195.91.172.114;uid=sa;pwd=ShadowRun007;database=RF_World;")
        Return conworld
        conworld = Nothing
    End Function
    Public daworld As SqlDataAdapter
    Public dtworld As New DataTable
    Public conworldc = ConnWorld.connworlds
    Public cmdworld As SqlCommand
    Public riworld As SqlCommand
    Public roworld As SqlDataAdapter
    Public scmworld As SqlCommandBuilder
    Public dsworld As DataSet
    Public rdworld As SqlDataReader
    Public sdbworld As Data.SqlClient.SqlDataAdapter
    Public perintahworld As SqlClient.SqlCommand
    Public sqlManagerAreaworld As CurrencyManager
End Module
