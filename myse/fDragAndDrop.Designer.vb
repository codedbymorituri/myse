<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDragAndDrop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDragAndDrop))
        Me.GroupBoxDragAndDrop = New System.Windows.Forms.GroupBox()
        Me.ListBoxFilters = New System.Windows.Forms.ListBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TextBoxFilter = New System.Windows.Forms.TextBox()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        Me.GroupBoxDragAndDrop.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxDragAndDrop
        '
        Me.GroupBoxDragAndDrop.Controls.Add(Me.ButtonRemove)
        Me.GroupBoxDragAndDrop.Controls.Add(Me.ButtonUpdate)
        Me.GroupBoxDragAndDrop.Controls.Add(Me.ButtonAdd)
        Me.GroupBoxDragAndDrop.Controls.Add(Me.TextBoxFilter)
        Me.GroupBoxDragAndDrop.Controls.Add(Me.ListBoxFilters)
        Me.GroupBoxDragAndDrop.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxDragAndDrop.Name = "GroupBoxDragAndDrop"
        Me.GroupBoxDragAndDrop.Size = New System.Drawing.Size(168, 133)
        Me.GroupBoxDragAndDrop.TabIndex = 0
        Me.GroupBoxDragAndDrop.TabStop = False
        Me.GroupBoxDragAndDrop.Text = "Allow these extensions"
        '
        'ListBoxFilters
        '
        Me.ListBoxFilters.FormattingEnabled = True
        Me.ListBoxFilters.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxFilters.Name = "ListBoxFilters"
        Me.ListBoxFilters.Size = New System.Drawing.Size(75, 108)
        Me.ListBoxFilters.TabIndex = 0
        Me.ListBoxFilters.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(12, 151)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 1
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(105, 151)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 2
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TextBoxFilter
        '
        Me.TextBoxFilter.Location = New System.Drawing.Point(87, 19)
        Me.TextBoxFilter.Name = "TextBoxFilter"
        Me.TextBoxFilter.Size = New System.Drawing.Size(75, 20)
        Me.TextBoxFilter.TabIndex = 1
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(87, 45)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 2
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(87, 74)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 3
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(87, 103)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRemove.TabIndex = 4
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'fDragAndDrop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(192, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.GroupBoxDragAndDrop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fDragAndDrop"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Drag And Drop Filter"
        Me.GroupBoxDragAndDrop.ResumeLayout(False)
        Me.GroupBoxDragAndDrop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxDragAndDrop As GroupBox
    Friend WithEvents ListBoxFilters As ListBox
    Friend WithEvents ButtonRemove As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents TextBoxFilter As TextBox
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonClose As Button
End Class
