#Region " Imports "
Imports System.IO
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Reflection
Imports Microsoft.Win32.SafeHandles
Imports System.ComponentModel
Imports System.Math
Imports AIOTDataAdmin
#End Region

Module RunRF

#Region "Call"
    Dim rundat As New AIOTDataAdmin.Running
#End Region

#Region "Running"
    Sub connection()
        If rundat.GotInternet = True Then
            MessageBox.Show("You Are Connected Internet!", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            updateprograms()
        Else
            MessageBox.Show("You Not Connected Internet!Please Connect For Future Update", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region

#Region "update"
    Sub updateprograms()
        Dim webupdate As New WebClient
        Dim update As String = webupdate.DownloadString("http://o2psoftlabsportal.comeze.com/connection/update/updateAIOTC.inf")
        If update.Contains(Application.ProductVersion) Then
            MessageBox.Show("Product Already Update", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information)
            rundat.linkinalterable()
            Login.txtUname.Enabled = True
            Login.txtUPass.Enabled = True
        Else
            MessageBox.Show("Update Program Available!Please Update For Protect!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            rundat.forums()
            Login.txtUname.Enabled = False
            Login.txtUPass.Enabled = False
        End If
    End Sub
#End Region

End Module
