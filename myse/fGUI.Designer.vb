<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGUI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fGUI))
        Me.ListBoxFiles = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DragAndDropFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncodingProfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ComboBoxDescription = New System.Windows.Forms.ComboBox()
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LabelTimeElapsed = New System.Windows.Forms.Label()
        Me.LabelTimeRemaining = New System.Windows.Forms.Label()
        Me.GroupBoxFilesToConvert = New System.Windows.Forms.GroupBox()
        Me.GroupBoxConversion = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBoxFilesToConvert.SuspendLayout()
        Me.GroupBoxConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxFiles
        '
        Me.ListBoxFiles.FormattingEnabled = True
        Me.ListBoxFiles.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxFiles.Name = "ListBoxFiles"
        Me.ListBoxFiles.Size = New System.Drawing.Size(760, 108)
        Me.ListBoxFiles.TabIndex = 0
        Me.ListBoxFiles.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(796, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DragAndDropFilterToolStripMenuItem, Me.EncodingProfilesToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'DragAndDropFilterToolStripMenuItem
        '
        Me.DragAndDropFilterToolStripMenuItem.Name = "DragAndDropFilterToolStripMenuItem"
        Me.DragAndDropFilterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DragAndDropFilterToolStripMenuItem.Text = "Drag and Drop Filter"
        '
        'EncodingProfilesToolStripMenuItem
        '
        Me.EncodingProfilesToolStripMenuItem.Name = "EncodingProfilesToolStripMenuItem"
        Me.EncodingProfilesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EncodingProfilesToolStripMenuItem.Text = "Encoding Profiles"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(6, 133)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRemove.TabIndex = 2
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(87, 133)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 3
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ComboBoxDescription
        '
        Me.ComboBoxDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDescription.FormattingEnabled = True
        Me.ComboBoxDescription.Location = New System.Drawing.Point(9, 19)
        Me.ComboBoxDescription.Name = "ComboBoxDescription"
        Me.ComboBoxDescription.Size = New System.Drawing.Size(676, 21)
        Me.ComboBoxDescription.TabIndex = 4
        '
        'ButtonConvert
        '
        Me.ButtonConvert.Location = New System.Drawing.Point(691, 19)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConvert.TabIndex = 5
        Me.ButtonConvert.Text = "Convert"
        Me.ButtonConvert.UseVisualStyleBackColor = True
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Location = New System.Drawing.Point(6, 43)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(112, 13)
        Me.LabelInfo.TabIndex = 6
        Me.LabelInfo.Text = "No conversion profiles"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(9, 59)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(757, 12)
        Me.ProgressBar1.TabIndex = 7
        '
        'LabelTimeElapsed
        '
        Me.LabelTimeElapsed.AutoSize = True
        Me.LabelTimeElapsed.Location = New System.Drawing.Point(6, 74)
        Me.LabelTimeElapsed.Name = "LabelTimeElapsed"
        Me.LabelTimeElapsed.Size = New System.Drawing.Size(49, 13)
        Me.LabelTimeElapsed.TabIndex = 8
        Me.LabelTimeElapsed.Text = "00:00:00"
        '
        'LabelTimeRemaining
        '
        Me.LabelTimeRemaining.AutoSize = True
        Me.LabelTimeRemaining.Location = New System.Drawing.Point(717, 74)
        Me.LabelTimeRemaining.Name = "LabelTimeRemaining"
        Me.LabelTimeRemaining.Size = New System.Drawing.Size(49, 13)
        Me.LabelTimeRemaining.TabIndex = 9
        Me.LabelTimeRemaining.Text = "00:00:00"
        '
        'GroupBoxFilesToConvert
        '
        Me.GroupBoxFilesToConvert.Controls.Add(Me.ListBoxFiles)
        Me.GroupBoxFilesToConvert.Controls.Add(Me.ButtonRemove)
        Me.GroupBoxFilesToConvert.Controls.Add(Me.ButtonClear)
        Me.GroupBoxFilesToConvert.Location = New System.Drawing.Point(12, 27)
        Me.GroupBoxFilesToConvert.Name = "GroupBoxFilesToConvert"
        Me.GroupBoxFilesToConvert.Size = New System.Drawing.Size(772, 162)
        Me.GroupBoxFilesToConvert.TabIndex = 10
        Me.GroupBoxFilesToConvert.TabStop = False
        Me.GroupBoxFilesToConvert.Text = "Files to Convert"
        '
        'GroupBoxConversion
        '
        Me.GroupBoxConversion.Controls.Add(Me.ComboBoxDescription)
        Me.GroupBoxConversion.Controls.Add(Me.ButtonConvert)
        Me.GroupBoxConversion.Controls.Add(Me.LabelTimeElapsed)
        Me.GroupBoxConversion.Controls.Add(Me.LabelTimeRemaining)
        Me.GroupBoxConversion.Controls.Add(Me.LabelInfo)
        Me.GroupBoxConversion.Controls.Add(Me.ProgressBar1)
        Me.GroupBoxConversion.Location = New System.Drawing.Point(12, 195)
        Me.GroupBoxConversion.Name = "GroupBoxConversion"
        Me.GroupBoxConversion.Size = New System.Drawing.Size(772, 95)
        Me.GroupBoxConversion.TabIndex = 11
        Me.GroupBoxConversion.TabStop = False
        Me.GroupBoxConversion.Text = "Conversion"
        '
        'fGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 302)
        Me.Controls.Add(Me.GroupBoxConversion)
        Me.Controls.Add(Me.GroupBoxFilesToConvert)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "fGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "myse"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBoxFilesToConvert.ResumeLayout(False)
        Me.GroupBoxConversion.ResumeLayout(False)
        Me.GroupBoxConversion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxFiles As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DragAndDropFilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncodingProfilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ComboBoxDescription As ComboBox
    Friend WithEvents ButtonConvert As Button
    Friend WithEvents LabelInfo As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LabelTimeElapsed As Label
    Friend WithEvents LabelTimeRemaining As Label
    Friend WithEvents GroupBoxFilesToConvert As GroupBox
    Friend WithEvents GroupBoxConversion As GroupBox
End Class
