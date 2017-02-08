Option Strict On
Option Explicit On

Public Class fDragAndDrop

    Private ChangesMade As Boolean = False

    Private Sub fDragAndDrop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Filter As String In DragAndDropFilter
            Me.ListBoxFilters.Items.Add(Filter)
        Next
    End Sub

    Private Sub ListBoxFilters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFilters.SelectedIndexChanged
        Me.TextBoxFilter.Text = Me.ListBoxFilters.Text
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        If Not Me.TextBoxFilter.Text = String.Empty Then
            Me.ListBoxFilters.Items.Add(Me.TextBoxFilter.Text)
            Call SetChanges()
        End If
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If Not Me.TextBoxFilter.Text = String.Empty And Me.ListBoxFilters.SelectedIndex > -1 Then
            Me.ListBoxFilters.Items(Me.ListBoxFilters.SelectedIndex) = Me.TextBoxFilter.Text
            Call SetChanges()
        End If
    End Sub

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If Me.ListBoxFilters.SelectedIndex > -1 Then
            Me.ListBoxFilters.Items.RemoveAt(Me.ListBoxFilters.SelectedIndex)
            Call SetChanges()
        End If
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

    Private Sub SaveChanges()
        Call UpdateFilterList()
        c.SaveConfig()
        ChangesMade = False
    End Sub

    Private Sub CheckSaveOnExit()
        If MessageBox.Show("Save changes   ", MsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call SaveChanges()
        End If
    End Sub

    Private Sub UpdateFilterList()
        DragAndDropFilter.Clear()
        For Each Filter As String In Me.ListBoxFilters.Items
            DragAndDropFilter.Add(Filter)
        Next
    End Sub

    Private Sub SetChanges()
        ChangesMade = True
        Me.TextBoxFilter.Text = String.Empty
        Me.TextBoxFilter.Focus()
    End Sub

End Class