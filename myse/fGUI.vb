Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.IO
Imports System.Threading

Public Class fGUI

#Region "Form Load"

    Private Sub fGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CheckForConfigFile() = False Then
            Application.Exit()
        End If
        If c.ReadConfig = False Then
            Application.Exit()
        End If
        Call UpdateComboBox()
        Me.ListBoxFiles.AllowDrop = True
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Maximum = 100
    End Sub

#End Region

#Region "Check for Required Files"

    Private Function CheckForConfigFile() As Boolean
        Dim ConfigFile As String = My.Application.Info.DirectoryPath & "\Config.xml"
        If File.Exists(ConfigFile) = False Then
            MessageBox.Show("Cannot continue - Config file not found :" & vbCrLf & ConfigFile, MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function CheckForFFmpeg() As Boolean
        Dim FFmpeg As String = My.Application.Info.DirectoryPath & "\ffmpeg.exe"
        If File.Exists(FFmpeg) = False Then
            MessageBox.Show("Conversion aborted - FFmpeg.exe not found at" & vbCrLf & FFmpeg, MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

#End Region

#Region "ListBox"

    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If Me.ListBoxFiles.SelectedIndex > -1 Then
            Me.ListBoxFiles.Items.RemoveAt(Me.ListBoxFiles.SelectedIndex)
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Me.ListBoxFiles.Items.Clear()
    End Sub

#End Region

#Region "ComboBox"

    Public Sub UpdateComboBox()
        Me.ComboBoxDescription.Items.Clear()
        Dim Description As String = Nothing
        For i As Integer = 0 To EncodingDescriptions.Count - 1
            Description = EncodingDescriptions(i) & " (" & EncodingExtensions(i) & ")"
            Me.ComboBoxDescription.Items.Add(Description)
        Next
        If Me.ComboBoxDescription.Items.Count > 0 Then
            Me.ComboBoxDescription.SelectedIndex = 0
        Else
            Me.LabelInfo.Text = "No conversion profiles"
        End If
    End Sub

    Private Sub ComboBoxDescription_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDescription.SelectedIndexChanged
        Me.LabelInfo.Text = EncodingProfiles(Me.ComboBoxDescription.SelectedIndex)
    End Sub

#End Region

#Region "Menu Options"

    Private Sub DragAndDropFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DragAndDropFilterToolStripMenuItem.Click
        Dim f As fDragAndDrop = New fDragAndDrop
        f.ShowDialog()
    End Sub

    Private Sub EncodingProfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncodingProfilesToolStripMenuItem.Click
        Dim f As fProfiles = New fProfiles
        f.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Call CloseApplication()
    End Sub

#End Region

#Region "Drag and Drop"

    Private Sub ListBoxFiles_DragEnter(sender As Object, e As DragEventArgs) Handles ListBoxFiles.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub ListBoxFiles_DragDrop(sender As Object, e As DragEventArgs) Handles ListBoxFiles.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            For Each FileDropped As String In CType(e.Data.GetData(DataFormats.FileDrop), String())
                If CheckExtensionValid(FileDropped) = True Then
                    Me.ListBoxFiles.Items.Add(FileDropped)
                End If
            Next
        End If
    End Sub

    Private Function CheckExtensionValid(ByVal FileDropped As String) As Boolean
        For Each Filter As String In DragAndDropFilter
            If "." & Filter.ToLower = Path.GetExtension(FileDropped).ToLower Then
                Return True
            End If
        Next
        Return False
    End Function

#End Region

#Region "Conversion"

    Private Sub ButtonConvert_Click(sender As Object, e As EventArgs) Handles ButtonConvert.Click
        If CheckForFFmpeg() = False Then
            Exit Sub
        End If
        If ValidateData() = False Then
            Exit Sub
        End If
        Call ToggleControls(False)
        Dim FilesToConvert As List(Of String) = New List(Of String)
        FilesToConvert = GetFilesToConvert()
        Call CreateDelegates()
        Dim w As Worker = New Worker(FilesToConvert, Me.ComboBoxDescription.SelectedIndex, Me)
        Dim t As Thread = New Thread(AddressOf w.Start)
        t.IsBackground = True
        t.Start()
    End Sub

    Private Function ValidateData() As Boolean
        If Me.ListBoxFiles.Items.Count = 0 Then
            MessageBox.Show("Nothing to convert   ", MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        If Me.ComboBoxDescription.SelectedIndex = -1 Then
            MessageBox.Show("No conversion profile   ", MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Private Function GetFilesToConvert() As List(Of String)
        Dim FilesToConvert As List(Of String) = New List(Of String)
        For Each File As String In Me.ListBoxFiles.Items
            FilesToConvert.Add(File)
        Next
        Return FilesToConvert
    End Function

#End Region

#Region "Delegates"

    Private Sub CreateDelegates()
        DelegateToUpdateTimeElapsed = New CallUpdateTimeElapsed(AddressOf UpdateTimeElapsed)
        DelegateToUpdateTimeRemaining = New CallUpdateTimeRemaining(AddressOf UpdateTimeRemaining)
        DelegateToUpdateInfo = New CallUpdateInfo(AddressOf UpdateInfo)
        DelegateToUpdateProgressBar = New CallUpdateProgressBar(AddressOf UpdateProgressBar)
        DelegateToToggleControls = New CallToggleControls(AddressOf ToggleControls)
    End Sub

    Public DelegateToUpdateTimeElapsed As CallUpdateTimeElapsed
    Delegate Sub CallUpdateTimeElapsed(ByVal Text As String)
    Public Sub UpdateTimeElapsed(ByVal Text As String)
        Me.LabelTimeElapsed.Text = Text
    End Sub

    Public DelegateToUpdateTimeRemaining As CallUpdateTimeRemaining
    Delegate Sub CallUpdateTimeRemaining(ByVal Text As String)
    Public Sub UpdateTimeRemaining(ByVal Text As String)
        Me.LabelTimeRemaining.Text = Text
    End Sub

    Public DelegateToUpdateInfo As CallUpdateInfo
    Delegate Sub CallUpdateInfo(ByVal Text As String)
    Public Sub UpdateInfo(ByVal Text As String)
        Me.LabelInfo.Text = Text
    End Sub

    Public DelegateToUpdateProgressBar As CallUpdateProgressBar
    Delegate Sub CallUpdateProgressBar(ByVal Value As Integer)
    Public Sub UpdateProgressBar(ByVal Value As Integer)
        Me.ProgressBar1.Value = Value
    End Sub

    Public DelegateToToggleControls As CallToggleControls
    Delegate Sub CallToggleControls(ByVal Toggle As Boolean)
    Public Sub ToggleControls(ByVal Toggle As Boolean)
        Me.GroupBoxFilesToConvert.Enabled = Toggle
        Me.GroupBoxConversion.Enabled = Toggle
    End Sub

#End Region

#Region "Close"

    Private Sub CloseApplication()
        If Encoding = True Then
            If ConfirmExit() = False Then
                Exit Sub
            End If
            Try
                p.Kill()
            Catch ex As Exception
                'there is a remote chance that ffmpeg may not actually be running within the Worker.DoConversion function when p.Kill is made
            End Try
        End If
        Application.Exit()
    End Sub

    Private Function ConfirmExit() As Boolean
        If MessageBox.Show("Encoder is still running, are you sure you want to quit   ", MsgBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub fGUI_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Encoding = True Then
            If ConfirmExit() = False Then
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

End Class
