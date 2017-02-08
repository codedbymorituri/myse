Option Strict On
Option Explicit On

Imports System.Xml

Public Class Config

    Private ConfigFile As String = My.Application.Info.DirectoryPath & "\Config.xml"

    Public Function ReadConfig() As Boolean
        If GetDragAndDropFilter() = False Then
            Return False
        End If
        If GetEncodingProfiles() = False Then
            Return False
        End If
        Return True
    End Function

    Public Function GetDragAndDropFilter() As Boolean
        DragAndDropFilter = New List(Of String)
        Try
            Dim XMLDoc As New XmlDocument
            XMLDoc.Load(ConfigFile)
            Dim NodeList As XmlNodeList = XMLDoc.SelectNodes("/Config/DragAndDrop")
            For Each NodeFound As XmlNode In NodeList
                DragAndDropFilter.Add(NodeFound.Item("Filter").InnerText)
            Next
        Catch ex As Exception
            MessageBox.Show("Cannot continue - error loading Drag and Drop Filters" & vbCrLf & ex.Message, MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function GetEncodingProfiles() As Boolean
        EncodingDescriptions = New List(Of String)
        EncodingProfiles = New List(Of String)
        EncodingExtensions = New List(Of String)
        Try
            Dim XMLDoc As New XmlDocument
            XMLDoc.Load(ConfigFile)
            Dim NodeList As XmlNodeList = XMLDoc.SelectNodes("/Config/EncodingProfile")
            For Each NodeFound As XmlNode In NodeList
                EncodingDescriptions.Add(NodeFound.Item("Description").InnerText)
                EncodingProfiles.Add(NodeFound.Item("Profile").InnerText)
                EncodingExtensions.Add(NodeFound.Item("Extension").InnerText)
            Next
        Catch ex As Exception
            MessageBox.Show("Cannot continue - error loading Encoding Profiles" & vbCrLf & ex.Message, MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Sub SaveConfig()
        Dim xmlWriter As XmlTextWriter = New XmlTextWriter(ConfigFile, System.Text.Encoding.Default)
        Try
            With xmlWriter
                .Formatting = Formatting.Indented
                .Indentation = 4
                .WriteRaw("<?xml version=""1.0""?>")
                .WriteStartElement("Config")
                For Each Filter As String In DragAndDropFilter
                    .WriteStartElement("DragAndDrop")
                    .WriteStartElement("Filter")
                    .WriteString(Filter)
                    .WriteEndElement()
                    .WriteEndElement()
                Next
                For i As Integer = 0 To EncodingProfiles.Count - 1
                    .WriteStartElement("EncodingProfile")
                    .WriteStartElement("Description")
                    .WriteString(EncodingDescriptions.Item(i))
                    .WriteEndElement()
                    .WriteStartElement("Profile")
                    .WriteString(EncodingProfiles.Item(i))
                    .WriteEndElement()
                    .WriteStartElement("Extension")
                    .WriteString(EncodingExtensions.Item(i))
                    .WriteEndElement()
                    .WriteEndElement()
                Next
                .WriteEndElement()
            End With
            MessageBox.Show("Changes saved  ", MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving Config File" & vbCrLf & ex.Message, MsgBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        xmlWriter.Close()
    End Sub

End Class

