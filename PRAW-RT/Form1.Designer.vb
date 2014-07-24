<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tbupdate = New System.Windows.Forms.TextBox()
        Me.bset = New System.Windows.Forms.Button()
        Me.bstart = New System.Windows.Forms.Button()
        Me.bstop = New System.Windows.Forms.Button()
        Me.lbcountdown = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbupdates = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(225, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'tbupdate
        '
        Me.tbupdate.Location = New System.Drawing.Point(6, 22)
        Me.tbupdate.Name = "tbupdate"
        Me.tbupdate.Size = New System.Drawing.Size(100, 20)
        Me.tbupdate.TabIndex = 1
        '
        'bset
        '
        Me.bset.Location = New System.Drawing.Point(112, 20)
        Me.bset.Name = "bset"
        Me.bset.Size = New System.Drawing.Size(75, 23)
        Me.bset.TabIndex = 2
        Me.bset.Text = "Set"
        Me.bset.UseVisualStyleBackColor = True
        '
        'bstart
        '
        Me.bstart.Location = New System.Drawing.Point(134, 178)
        Me.bstart.Name = "bstart"
        Me.bstart.Size = New System.Drawing.Size(75, 23)
        Me.bstart.TabIndex = 3
        Me.bstart.Text = "Start"
        Me.bstart.UseVisualStyleBackColor = True
        '
        'bstop
        '
        Me.bstop.Location = New System.Drawing.Point(13, 178)
        Me.bstop.Name = "bstop"
        Me.bstop.Size = New System.Drawing.Size(75, 23)
        Me.bstop.TabIndex = 4
        Me.bstop.Text = "Stop"
        Me.bstop.UseVisualStyleBackColor = True
        '
        'lbcountdown
        '
        Me.lbcountdown.AutoSize = True
        Me.lbcountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.lbcountdown.Location = New System.Drawing.Point(6, 16)
        Me.lbcountdown.Name = "lbcountdown"
        Me.lbcountdown.Size = New System.Drawing.Size(36, 39)
        Me.lbcountdown.TabIndex = 5
        Me.lbcountdown.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbupdate)
        Me.GroupBox1.Controls.Add(Me.bset)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(196, 63)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update interval (seconds)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbcountdown)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(196, 66)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Countdown (Seconds)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbupdates)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 42)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total updates"
        '
        'lbupdates
        '
        Me.lbupdates.AutoSize = True
        Me.lbupdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lbupdates.Location = New System.Drawing.Point(8, 14)
        Me.lbupdates.Name = "lbupdates"
        Me.lbupdates.Size = New System.Drawing.Size(23, 25)
        Me.lbupdates.TabIndex = 5
        Me.lbupdates.Text = "0"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 261)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bstop)
        Me.Controls.Add(Me.bstart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "PRAW-RT"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tbupdate As System.Windows.Forms.TextBox
    Friend WithEvents bset As System.Windows.Forms.Button
    Friend WithEvents bstart As System.Windows.Forms.Button
    Friend WithEvents bstop As System.Windows.Forms.Button
    Friend WithEvents lbcountdown As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbupdates As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
