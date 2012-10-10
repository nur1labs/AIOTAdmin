<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMControl
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.remworld = New System.Windows.Forms.Label()
        Me.rembill = New System.Windows.Forms.Label()
        Me.remacc = New System.Windows.Forms.Label()
        Me.lblworld = New System.Windows.Forms.Label()
        Me.lblbilling = New System.Windows.Forms.Label()
        Me.lblacc = New System.Windows.Forms.Label()
        Me.lblstatuslogin = New System.Windows.Forms.Label()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.checking = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.remworld)
        Me.GroupBox2.Controls.Add(Me.rembill)
        Me.GroupBox2.Controls.Add(Me.remacc)
        Me.GroupBox2.Controls.Add(Me.lblworld)
        Me.GroupBox2.Controls.Add(Me.lblbilling)
        Me.GroupBox2.Controls.Add(Me.lblacc)
        Me.GroupBox2.Controls.Add(Me.lblstatuslogin)
        Me.GroupBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.GroupBox2.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(260, 123)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "System"
        '
        'remworld
        '
        Me.remworld.AutoSize = True
        Me.remworld.Location = New System.Drawing.Point(111, 69)
        Me.remworld.Name = "remworld"
        Me.remworld.Size = New System.Drawing.Size(39, 13)
        Me.remworld.TabIndex = 2
        Me.remworld.Text = "Label3"
        '
        'rembill
        '
        Me.rembill.AutoSize = True
        Me.rembill.Location = New System.Drawing.Point(111, 56)
        Me.rembill.Name = "rembill"
        Me.rembill.Size = New System.Drawing.Size(39, 13)
        Me.rembill.TabIndex = 2
        Me.rembill.Text = "Label2"
        '
        'remacc
        '
        Me.remacc.AutoSize = True
        Me.remacc.Location = New System.Drawing.Point(111, 41)
        Me.remacc.Name = "remacc"
        Me.remacc.Size = New System.Drawing.Size(39, 13)
        Me.remacc.TabIndex = 2
        Me.remacc.Text = "Label1"
        '
        'lblworld
        '
        Me.lblworld.AutoSize = True
        Me.lblworld.Location = New System.Drawing.Point(14, 69)
        Me.lblworld.Name = "lblworld"
        Me.lblworld.Size = New System.Drawing.Size(69, 13)
        Me.lblworld.TabIndex = 4
        Me.lblworld.Text = "World Server"
        '
        'lblbilling
        '
        Me.lblbilling.AutoSize = True
        Me.lblbilling.Location = New System.Drawing.Point(14, 56)
        Me.lblbilling.Name = "lblbilling"
        Me.lblbilling.Size = New System.Drawing.Size(68, 13)
        Me.lblbilling.TabIndex = 3
        Me.lblbilling.Text = "Billing Server"
        '
        'lblacc
        '
        Me.lblacc.AutoSize = True
        Me.lblacc.Location = New System.Drawing.Point(14, 41)
        Me.lblacc.Name = "lblacc"
        Me.lblacc.Size = New System.Drawing.Size(81, 13)
        Me.lblacc.TabIndex = 2
        Me.lblacc.Text = "Account Server"
        '
        'lblstatuslogin
        '
        Me.lblstatuslogin.AutoSize = True
        Me.lblstatuslogin.Location = New System.Drawing.Point(14, 26)
        Me.lblstatuslogin.Name = "lblstatuslogin"
        Me.lblstatuslogin.Size = New System.Drawing.Size(74, 13)
        Me.lblstatuslogin.TabIndex = 2
        Me.lblstatuslogin.Text = "Status Server:"
        '
        'btnlogout
        '
        Me.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogout.Location = New System.Drawing.Point(12, 12)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(75, 23)
        Me.btnlogout.TabIndex = 3
        Me.btnlogout.Text = "Close"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'checking
        '
        Me.checking.Enabled = True
        '
        'GMControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 188)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "GMControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMControl"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents remworld As System.Windows.Forms.Label
    Friend WithEvents rembill As System.Windows.Forms.Label
    Friend WithEvents remacc As System.Windows.Forms.Label
    Friend WithEvents lblworld As System.Windows.Forms.Label
    Friend WithEvents lblbilling As System.Windows.Forms.Label
    Friend WithEvents lblacc As System.Windows.Forms.Label
    Friend WithEvents lblstatuslogin As System.Windows.Forms.Label
    Friend WithEvents btnlogout As System.Windows.Forms.Button
    Friend WithEvents checking As System.Windows.Forms.Timer
End Class
