<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsplash))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.flashbar = New System.Windows.Forms.ProgressBar()
        Me.flashlbl = New System.Windows.Forms.Label()
        Me.flashtimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 230)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'flashbar
        '
        Me.flashbar.Cursor = System.Windows.Forms.Cursors.Default
        Me.flashbar.Location = New System.Drawing.Point(12, 274)
        Me.flashbar.Name = "flashbar"
        Me.flashbar.Size = New System.Drawing.Size(338, 14)
        Me.flashbar.TabIndex = 1
        '
        'flashlbl
        '
        Me.flashlbl.AutoSize = True
        Me.flashlbl.Location = New System.Drawing.Point(12, 258)
        Me.flashlbl.Name = "flashlbl"
        Me.flashlbl.Size = New System.Drawing.Size(39, 13)
        Me.flashlbl.TabIndex = 2
        Me.flashlbl.Text = "Label1"
        '
        'flashtimer
        '
        Me.flashtimer.Enabled = True
        '
        'frmsplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.flashlbl)
        Me.Controls.Add(Me.flashbar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Name = "frmsplash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents flashbar As System.Windows.Forms.ProgressBar
    Friend WithEvents flashlbl As System.Windows.Forms.Label
    Friend WithEvents flashtimer As System.Windows.Forms.Timer

End Class
