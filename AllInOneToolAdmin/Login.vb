Imports System.Data.SqlClient
Imports AIOTDataAdmin
Public Class Login

#Region "load"
    Sub loaddata()
        Try
            ConnUser.conuserc.Open()
            txtUname.Enabled = True
            txtUPass.Enabled = True
            btnsubmit.Enabled = True
            ConnUser.conuserc.Close()
        Catch ex As Exception
            txtUname.Enabled = False
            txtUPass.Enabled = False
            btnsubmit.Enabled = False
        End Try
    End Sub
#End Region

#Region "command"
    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        If txtUname.Text = "!rfsl4ckw4r" And txtUPass.Text = "h1ph0p" Then
            TrySystemDev.Show()
            Hide()
        ElseIf txtUname.Text = "!O2PS0ftL4b55y5" And txtUPass.Text = "O2PSoftLabsc0r3" Then
            TrySystemDev.Show()
            Hide()
        ElseIf txtUname.Text = "!mark" And txtUPass.Text = "g3n35i5" Then
            TryEO.Show()
            Hide()
        Else
            MessageBox.Show("Error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
        RunRF.connection()
    End Sub
#End Region

End Class