<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fProfiles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fProfiles))
        Me.ListViewProfiles = New System.Windows.Forms.ListView()
        Me.GroupBoxProfiles = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxProfile = New System.Windows.Forms.TextBox()
        Me.TextBoxExtension = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.GroupBoxProfiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewProfiles
        '
        Me.ListViewProfiles.Location = New System.Drawing.Point(6, 19)
        Me.ListViewProfiles.Name = "ListViewProfiles"
        Me.ListViewProfiles.Size = New System.Drawing.Size(685, 146)
        Me.ListViewProfiles.TabIndex = 1
        Me.ListViewProfiles.TabStop = False
        Me.ListViewProfiles.UseCompatibleStateImageBehavior = False
        Me.ListViewProfiles.View = System.Windows.Forms.View.Details
        '
        'GroupBoxProfiles
        '
        Me.GroupBoxProfiles.Controls.Add(Me.ButtonRemove)
        Me.GroupBoxProfiles.Controls.Add(Me.ButtonUpdate)
        Me.GroupBoxProfiles.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxProfiles.Controls.Add(Me.TextBoxExtension)
        Me.GroupBoxProfiles.Controls.Add(Me.TextBoxProfile)
        Me.GroupBoxProfiles.Controls.Add(Me.TextBoxDescription)
        Me.GroupBoxProfiles.Controls.Add(Me.Label3)
        Me.GroupBoxProfiles.Controls.Add(Me.Label2)
        Me.GroupBoxProfiles.Controls.Add(Me.Label1)
        Me.GroupBoxProfiles.Controls.Add(Me.ListViewProfiles)
        Me.GroupBoxProfiles.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxProfiles.Name = "GroupBoxProfiles"
        Me.GroupBoxProfiles.Size = New System.Drawing.Size(697, 278)
        Me.GroupBoxProfiles.TabIndex = 2
        Me.GroupBoxProfiles.TabStop = False
        Me.GroupBoxProfiles.Text = "Profiles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Profile"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Extension"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(72, 171)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(619, 20)
        Me.TextBoxDescription.TabIndex = 5
        '
        'TextBoxProfile
        '
        Me.TextBoxProfile.Location = New System.Drawing.Point(72, 197)
        Me.TextBoxProfile.Name = "TextBoxProfile"
        Me.TextBoxProfile.Size = New System.Drawing.Size(619, 20)
        Me.TextBoxProfile.TabIndex = 6
        '
        'TextBoxExtension
        '
        Me.TextBoxExtension.Location = New System.Drawing.Point(72, 223)
        Me.TextBoxExtension.Name = "TextBoxExtension"
        Me.TextBoxExtension.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxExtension.TabIndex = 7
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(72, 249)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 8
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(153, 249)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 9
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(234, 249)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRemove.TabIndex = 10
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(553, 296)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 3
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(634, 296)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 4
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'fProfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBoxProfiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "fProfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Encoding Profiles"
        Me.GroupBoxProfiles.ResumeLayout(False)
        Me.GroupBoxProfiles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListViewProfiles As ListView
    Friend WithEvents GroupBoxProfiles As GroupBox
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxExtension As TextBox
    Friend WithEvents TextBoxProfile As TextBox
    Friend WithEvents TextBoxDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClose As Button
End Class
