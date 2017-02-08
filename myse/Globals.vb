Option Strict On
Option Explicit On

Module Globals

    Public Const MsgBoxCaption As String = "myse"
    Public DragAndDropFilter As List(Of String)
    Public EncodingDescriptions As List(Of String)
    Public EncodingProfiles As List(Of String)
    Public EncodingExtensions As List(Of String)
    Public Encoding As Boolean = False
    Public c As Config = New Config
    Public p As Process

End Module
