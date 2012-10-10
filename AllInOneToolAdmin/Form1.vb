Public Class frmsplash

#Region "load"
    Dim bool As Boolean
    Private Sub frmsplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Membuat form transparan
        Dim i As Double
        For i = 0 To 1 Step 0.001
            Me.Opacity = Math.Abs(i)
        Next
    End Sub

    Private Sub flashtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flashtimer.Tick
        flashbar.Value += 2

        If flashbar.Value <= 10 Then

            flashlbl.Text = "Initialization......."

        ElseIf flashbar.Value <= 20 Then

            flashlbl.Text = "Load AIOTAdmin.exe........"

        ElseIf flashbar.Value <= 30 Then

            flashlbl.Text = "Load Library........"

        ElseIf flashbar.Value <= 40 Then

            flashlbl.Text = "Secure Data........"

        ElseIf flashbar.Value <= 50 Then

            flashlbl.Text = "Integrated System Security........"

        ElseIf flashbar.Value <= 60 Then

            flashlbl.Text = "Checking Files ........"

        ElseIf flashbar.Value <= 70 Then

            flashlbl.Text = "Read Libary....."

        ElseIf flashbar.Value <= 80 Then

            flashlbl.Text = "Welcome AIOT Admin Tool Manage And Development ^_^"

        End If
        If flashbar.Value = 98 Then
            Login.Show()
        End If
        If flashbar.Value = 100 Then
            flashtimer.Dispose()
            Me.Visible = False
        End If
    End Sub
#End Region
   
End Class
