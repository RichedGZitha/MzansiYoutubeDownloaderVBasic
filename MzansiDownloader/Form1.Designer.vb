<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMzansiForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMzansiForm))
        Me.menuHeader = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblInstructionText = New System.Windows.Forms.Label()
        Me.txtYoutubeURL = New System.Windows.Forms.TextBox()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.pbarDownloadMonitor = New System.Windows.Forms.ProgressBar()
        Me.menuHeader.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuHeader
        '
        Me.menuHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menuHeader.Location = New System.Drawing.Point(0, 0)
        Me.menuHeader.Name = "menuHeader"
        Me.menuHeader.Size = New System.Drawing.Size(394, 24)
        Me.menuHeader.TabIndex = 0
        Me.menuHeader.Text = "Header menu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.ImageLocation = ""
        Me.picLogo.Location = New System.Drawing.Point(12, 27)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(360, 166)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'lblInstructionText
        '
        Me.lblInstructionText.AutoSize = True
        Me.lblInstructionText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructionText.Location = New System.Drawing.Point(28, 205)
        Me.lblInstructionText.Name = "lblInstructionText"
        Me.lblInstructionText.Size = New System.Drawing.Size(330, 24)
        Me.lblInstructionText.TabIndex = 2
        Me.lblInstructionText.Text = "Paste the YouTube link / url below"
        '
        'txtYoutubeURL
        '
        Me.txtYoutubeURL.Location = New System.Drawing.Point(12, 270)
        Me.txtYoutubeURL.Multiline = True
        Me.txtYoutubeURL.Name = "txtYoutubeURL"
        Me.txtYoutubeURL.Size = New System.Drawing.Size(360, 89)
        Me.txtYoutubeURL.TabIndex = 3
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.SystemColors.Control
        Me.btnDownload.Font = New System.Drawing.Font("Papyrus", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.Location = New System.Drawing.Point(13, 366)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(359, 62)
        Me.btnDownload.TabIndex = 4
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'pbarDownloadMonitor
        '
        Me.pbarDownloadMonitor.Location = New System.Drawing.Point(13, 233)
        Me.pbarDownloadMonitor.Name = "pbarDownloadMonitor"
        Me.pbarDownloadMonitor.Size = New System.Drawing.Size(359, 23)
        Me.pbarDownloadMonitor.Step = 1
        Me.pbarDownloadMonitor.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbarDownloadMonitor.TabIndex = 5
        Me.pbarDownloadMonitor.Visible = False
        '
        'frmMzansiForm
        '
        Me.AcceptButton = Me.btnDownload
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 441)
        Me.Controls.Add(Me.pbarDownloadMonitor)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.txtYoutubeURL)
        Me.Controls.Add(Me.lblInstructionText)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.menuHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuHeader
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 480)
        Me.MinimumSize = New System.Drawing.Size(410, 480)
        Me.Name = "frmMzansiForm"
        Me.Text = "Mzansi Youtube Downloader"
        Me.menuHeader.ResumeLayout(False)
        Me.menuHeader.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuHeader As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblInstructionText As Label
    Friend WithEvents txtYoutubeURL As TextBox
    Friend WithEvents btnDownload As Button
    Public WithEvents pbarDownloadMonitor As ProgressBar
End Class
