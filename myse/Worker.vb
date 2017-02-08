Option Strict On
Option Explicit On

Imports System.IO
Imports System.Timers
Imports System.Text.RegularExpressions

Public Class Worker

    Private t As Timer
    Private StartTime As DateTime
    Private FileDuration As Integer = 0
    Private Progress As Integer = 0
    Private wFilesToConvert As List(Of String)
    Private wConversionProfileIndex As Integer
    Private wFormToUpdate As fGUI = Nothing

    Public Sub New(ByVal FilesToConvert As List(Of String), ByVal ConversionProfileIndex As Integer, ByVal CallingForm As fGUI)
        wFilesToConvert = FilesToConvert
        wConversionProfileIndex = ConversionProfileIndex
        wFormToUpdate = CallingForm
    End Sub

    Public Sub Start()
        Call CreateTimer()
        Call CreateProcess()
        Dim ConversionIndex As Integer = 0
        Do While ConversionIndex < wFilesToConvert.Count
            Dim FilePath As String = wFilesToConvert(ConversionIndex)
            Call DoConversion(FilePath)
            ConversionIndex = ConversionIndex + 1
        Loop
        wFormToUpdate.Invoke(wFormToUpdate.DelegateToUpdateTimeRemaining, "00:00:00")
        wFormToUpdate.Invoke(wFormToUpdate.DelegateToToggleControls, True)
    End Sub

    Private Sub DoConversion(ByVal FilePath As String)
        Encoding = True
        wFormToUpdate.Invoke(wFormToUpdate.DelegateToUpdateInfo, Path.GetFileName(FilePath))
        Dim DurationArguments As String = GetDurationArguments(FilePath)
        Dim ConversionArguments As String = GetConversionArguments(FilePath)
        Dim Reader As StreamReader
        Dim FFmpegInfo As String = Nothing
        StartTime = DateTime.Now
        t.Start()
        p.StartInfo.Arguments = DurationArguments
        p.Start()
        p.WaitForExit()
        Reader = p.StandardError
        FFmpegInfo = Reader.ReadToEnd()
        FileDuration = GetFileDuration(FFmpegInfo)
        If FileDuration = -1 Then
            t.Stop()
            Encoding = False
            Exit Sub
        End If
        Dim RegexElapsed As String = "time=([^.]*)"
        p.StartInfo.Arguments = ConversionArguments
        p.Start()
        Reader = p.StandardError
        Do
            FFmpegInfo = Reader.ReadLine
            If Regex.IsMatch(FFmpegInfo, "time=([^.]*)") = True Then
                Progress = ParseSeconds(Regex.Match(FFmpegInfo, "time=([^.]*)").Groups(1).Value)
            End If
        Loop While Not Reader.EndOfStream
        p.WaitForExit()
        p.Close()
        t.Stop()
        Reader.Close()
        wFormToUpdate.Invoke(wFormToUpdate.DelegateToUpdateProgressBar, 100)
        Encoding = False
    End Sub

    Private Function GetDurationArguments(ByVal FilePath As String) As String
        Return " -i " & Chr(34) & FilePath & Chr(34)
    End Function

    Private Function GetConversionArguments(ByVal FilePath As String) As String
        Dim Profile As String = EncodingProfiles(wConversionProfileIndex)
        Dim Extension As String = EncodingExtensions(wConversionProfileIndex)
        Dim ConversionArguments As String = " -i " & Chr(34) & FilePath & Chr(34) & " " & Profile & " -y " & Chr(34) & FilePath & "." & Extension & Chr(34)
        Return ConversionArguments
    End Function

    Private Function GetFileDuration(ByVal FFmpegInfo As String) As Integer
        Dim ResultString As String = Regex.Match(FFmpegInfo, "Duration: ([^.]*)").Groups(1).Value
        If ResultString = String.Empty Then
            Return -1
        End If
        Return ParseSeconds(ResultString)
    End Function

    Private Function ParseSeconds(ByVal TimeString As String) As Integer
        Dim hms() As String = TimeString.Split(CType(":", Char()))
        Dim h As Integer = Integer.Parse(CType(CInt(hms(0)) * 3600, String))
        Dim m As Integer = Integer.Parse(CType(CInt(hms(1)) * 60, String))
        Dim s As Integer = Integer.Parse(CType(CInt(hms(2)), String))
        Return h + m + s
    End Function

    Private Sub CreateTimer()
        t = New Timer(1000)
        AddHandler t.Elapsed, New Timers.ElapsedEventHandler(AddressOf TimerHandler)
        t.Enabled = True
    End Sub

    Private Sub TimerHandler(ByVal sender As Object, ByVal e As Timers.ElapsedEventArgs)
        Try
            Dim TimeNow As DateTime = DateTime.Now
            Dim ElapsedTime As TimeSpan = TimeNow - StartTime
            Dim PercentageDone As Integer = CInt(Progress / FileDuration * 100)
            Dim RemainingSeconds As Integer = CInt(CInt(ElapsedTime.TotalSeconds) / PercentageDone * (100 - PercentageDone))
            Dim RemainingTime As TimeSpan = TimeSpan.FromSeconds(RemainingSeconds)
            wFormToUpdate.Invoke(wFormToUpdate.DelegateToUpdateTimeElapsed, Microsoft.VisualBasic.Left(ElapsedTime.ToString(), 8))
            wFormToUpdate.Invoke(wFormToUpdate.DelegateToUpdateTimeRemaining, Microsoft.VisualBasic.Left(RemainingTime.ToString(), 8))
            wFormToUpdate.Invoke(wFormToUpdate.DelegateToUpdateProgressBar, PercentageDone)
        Catch ex As Exception
            'catch division by zero
        End Try
    End Sub

    Private Sub CreateProcess()
        p = New Process
        p.EnableRaisingEvents = True
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.FileName = My.Application.Info.DirectoryPath & "\ffmpeg.exe"
        p.StartInfo.RedirectStandardError = True
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.UseShellExecute = False
        'p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.WorkingDirectory = My.Application.Info.DirectoryPath
    End Sub

End Class

