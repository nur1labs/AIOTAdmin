Imports AIOTDataAdmin
Public Class TryGM

#Region "command"
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Close()
        Me.Hide()
        Login.Show()
        Login.txtUname.Clear()
        Login.txtUPass.Clear()
        MessageBox.Show("You Are Logout From GameMaster!", "Thank You For Using", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TryGM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TryGMS.ShowBalloonTip(500, "Information", "Version 1.0.8.0 -> Still Release System But While Feature Is Complete Run!Tell Us", ToolTipIcon.Info)
    End Sub

    Private Sub MainProgramsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainProgramsToolStripMenuItem.Click
        GMControl.Show()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeedbackToolStripMenuItem.Click
        Dim feed As AIOTDataAdmin.Running
        feed.linkmail()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Dim help As AIOTDataAdmin.Running
        help.Help()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub
#End Region
  
End Class