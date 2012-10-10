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
#End Region

Public Class Running

#Region "check"
    Public Function GotInternet() As Boolean
        Dim req As System.Net.HttpWebRequest
        Dim res As System.Net.HttpWebResponse
        GotInternet = False
        Try
            req = CType(System.Net.HttpWebRequest.Create("http://o2psoftlabsportal.comeze.com/"), System.Net.HttpWebRequest)
            res = CType(req.GetResponse(), System.Net.HttpWebResponse)
            req.Abort()
            If res.StatusCode = System.Net.HttpStatusCode.OK Then
                GotInternet = True
            End If
        Catch weberrt As System.Net.WebException
            GotInternet = False
        Catch except As Exception
            GotInternet = False
        End Try
    End Function
#End Region

#Region "link"
    Sub linkinalterable()
        'Jalankan browser web default dan link ke situs web
        System.Diagnostics.Process.Start _
        ("http://o2psoftlabsportal.comeze.com/")
    End Sub

    Sub linkmail()
        'Jalankan browser web default dan link ke situs web
        System.Diagnostics.Process.Start _
            ("mailto:" & "crbru.yuthafiga@gmail.com")
    End Sub

    Sub donation()
        'Jalankan browser web default dan link ke situs web
        System.Diagnostics.Process.Start _
            ("https://www.paypal.com/cgi-bin/webscr")
    End Sub

    Sub forums()
        'Jalankan browser web default dan link ke situs web
        System.Diagnostics.Process.Start _
            ("http://o2psoftlabsforums.8forum.net/t39-admin-toolsaiotc-for-staff")
    End Sub
#End Region

#Region "process"
    Sub RFInalterable()
        Dim myProcess As Process = System.Diagnostics.Process.Start("Inalterable")
        MsgBox(myProcess.ProcessName)
    End Sub

    Sub Help()
        Dim myProcess As Process = System.Diagnostics.Process.Start("Help\AIOTAHelp.chm")
        MsgBox(myProcess.ProcessName)
    End Sub
#End Region

End Class
