<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.txtUPass = New System.Windows.Forms.TextBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(12, 9)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(55, 13)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Username"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(12, 39)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(53, 13)
        Me.lblpassword.TabIndex = 1
        Me.lblpassword.Text = "Password"
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(73, 6)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(163, 20)
        Me.txtUname.TabIndex = 2
        '
        'txtUPass
        '
        Me.txtUPass.Location = New System.Drawing.Point(71, 32)
        Me.txtUPass.Name = "txtUPass"
        Me.txtUPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtUPass.Size = New System.Drawing.Size(165, 20)
        Me.txtUPass.TabIndex = 3
        '
        'btnsubmit
        '
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Location = New System.Drawing.Point(31, 58)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 4
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Location = New System.Drawing.Point(112, 58)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 5
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtUPass)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblname)
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents txtUPass As System.Windows.Forms.TextBox
    Friend WithEvents btnsubmit As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
