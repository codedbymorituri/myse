Option Strict On
Option Explicit On

Public Class fProfiles

    Private ChangesMade As Boolean = False

    Private Sub fProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me.ListViewProfiles
            .Columns.Add("Description", 300)
            .Columns.Add("Profile", 300)
            .Columns.Add("Extension", 60)
            .FullRowSelect = True
            .GridLines = True
            .HeaderStyle = ColumnHeaderStyle.Nonclickable
            .HideSelection = False
            .MultiSelect = False
            .View = View.Details
        End With
        Dim RowItem(2) As String
        Dim RowItems As ListViewItem
        For i As Integer = 0 To EncodingProfiles.Count - 1
            RowItem(0) = EncodingDescriptions.Item(i)
            RowItem(1) = EncodingProfiles.Item(i)
            RowItem(2) = EncodingExtensions.Item(i)
            RowItems = New ListViewItem(RowItem)
            Me.ListViewProfiles.Items.Add(RowItems)
        Next
        Me.TextBoxDescription.Focus()
    End Sub

    Private Sub ListViewProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewProfiles.SelectedIndexChanged
        Try
            Me.TextBoxDescription.Text = ListViewProfiles.SelectedItems.Item(0).SubItems(0).Text
            Me.TextBoxProfile.Text = ListViewProfiles.SelectedItems.Item(0).SubItems(1).Text
            Me.TextBoxExtension.Text = ListViewProfiles.SelectedItems.Item(0).SubItems(2).Text
        Catch ex As Exception
            '
        End Try
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If NullFields() = True Then
            MessageBox.Show("Empty fields not allowed   ", MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim RowItem(2) As String
        Dim RowItems As ListViewItem
        RowItem(0) = Me.TextBoxDescription.Text
        RowItem(1) = Me.TextBoxProfile.Text
        RowItem(2) = Me.TextBoxExtension.Text
        RowItems = New ListViewItem(RowItem)
        Me.ListViewProfiles.Items.Add(RowItems)
        Call SetChanges()
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If NullFields() = True Then
            MessageBox.Show("Empty fields not allowed   ", MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        ListViewProfiles.SelectedItems.Item(0).SubItems(0).Text = Me.TextBoxDescription.Text
        ListViewProfiles.SelectedItems.Item(0).SubItems(1).Text = Me.TextBoxProfile.Text
        ListViewProfiles.SelectedItems.Item(0).SubItems(2).Text = Me.TextBoxExtension.Text
        Call SetChanges()
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        Me.ListViewProfiles.Items.RemoveAt(Me.ListViewProfiles.SelectedIndices(0))
        Call SetChanges()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Call SaveChanges()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        If ChangesMade = True Then
            Call CheckSaveOnExit()
        End If
        Me.Close()
    End Sub

    Private Sub CheckSaveOnExit()
        If MessageBox.Show("Save changes   ", MsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call SaveChanges()
        End If
    End Sub

    Private Sub SaveChanges()
        Call UpdateFilterList()
        c.SaveConfig()
        Call fGUI.UpdateComboBox()
        ChangesMade = False
    End Sub

    Private Sub UpdateFilterList()
        EncodingDescriptions.Clear()
        EncodingProfiles.Clear()
        EncodingExtensions.Clear()
        For Each Item As ListViewItem In Me.ListViewProfiles.Items
            EncodingDescriptions.Add(Item.SubItems.Item(0).Text)
            EncodingProfiles.Add(Item.SubItems.Item(1).Text)
            EncodingExtensions.Add(Item.SubItems.Item(2).Text)
        Next
    End Sub

    Private Sub SetChanges()
        ChangesMade = True
        Me.TextBoxDescription.Text = String.Empty
        Me.TextBoxProfile.Text = String.Empty
        Me.TextBoxExtension.Text = String.Empty
        Me.TextBoxDescription.Focus()
    End Sub

    Private Function NullFields() As Boolean
        If Me.TextBoxDescription.Text = String.Empty Then
            Me.TextBoxDescription.Focus()
            Return True
        End If
        If Me.TextBoxProfile.Text = String.Empty Then
            Me.TextBoxProfile.Focus()
            Return True
        End If
        If Me.TextBoxExtension.Text = String.Empty Then
            Me.TextBoxExtension.Focus()
            Return True
        End If
        Return False
    End Function

End Class


