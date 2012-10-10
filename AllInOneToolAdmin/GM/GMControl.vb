Imports System.Data.SqlClient
Public Class GMControl

#Region "check"
    Sub user()
        Try
            ConnUser.conuserc.Open()
            remacc.Text = "Open"
            remacc.ForeColor = Color.Blue
            ConnUser.conuserc.Close()
        Catch ex As Exception
            remacc.Text = "Closed"
            remacc.ForeColor = Color.Red
        End Try
    End Sub

    Sub billing()
        Try
            ConnBilling.conbillc.Open()
            rembill.Text = "Open"
            rembill.ForeColor = Color.Blue
            ConnBilling.conbillc.Close()
        Catch ex As Exception
            rembill.Text = "Closed"
            rembill.ForeColor = Color.Red
        End Try
    End Sub

    Sub world()
        Try
            ConnWorld.conworldc.Open()
            remworld.Text = "Open"
            remworld.ForeColor = Color.Blue
            ConnWorld.conworldc.Close()
        Catch ex As Exception
            remworld.Text = "Closed"
            remworld.ForeColor = Color.Red
        End Try
    End Sub

    Sub check()
        user()
        billing()
        world()
    End Sub
#End Region

#Region "command"
    Private Sub btnlogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogout.Click
        Close()
    End Sub

    Private Sub GMControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        check()
    End Sub
#End Region

#Region "timer"
    Private Sub Load_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checking.Tick
        Refresh()
        check()
    End Sub
#End Region
   
End Class