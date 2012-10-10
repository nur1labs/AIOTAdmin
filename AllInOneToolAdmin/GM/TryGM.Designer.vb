<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TryGM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TryGM))
        Me.TryGMS = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.AIOTGM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AIOTGM.SuspendLayout()
        Me.SuspendLayout()
        '
        'TryGMS
        '
        Me.TryGMS.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TryGMS.BalloonTipText = "This Is Beta GM Tools"
        Me.TryGMS.BalloonTipTitle = "Notification"
        Me.TryGMS.ContextMenuStrip = Me.AIOTGM
        Me.TryGMS.Icon = CType(resources.GetObject("TryGMS.Icon"), System.Drawing.Icon)
        Me.TryGMS.Text = "AIOT GM Control"
        Me.TryGMS.Visible = True
        '
        'AIOTGM
        '
        Me.AIOTGM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.ToolStripSeparator1, Me.FeedbackToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.HelpToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.AIOTGM.Name = "ContextMenuStrip1"
        Me.AIOTGM.Size = New System.Drawing.Size(125, 120)
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainProgramsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'MainProgramsToolStripMenuItem
        '
        Me.MainProgramsToolStripMenuItem.Name = "MainProgramsToolStripMenuItem"
        Me.MainProgramsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MainProgramsToolStripMenuItem.Text = "Main Programs"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(121, 6)
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeyDisplayString = "F1"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TryGM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 93)
        Me.ContextMenuStrip = Me.AIOTGM
        Me.ControlBox = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TryGM"
        Me.Opacity = 0.0R
        Me.ShowInTaskbar = False
        Me.Text = "TryGM"
        Me.AIOTGM.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TryGMS As System.Windows.Forms.NotifyIcon
    Friend WithEvents AIOTGM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
