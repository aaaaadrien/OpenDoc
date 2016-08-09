Imports System
Imports System.IO
Imports System.Collections


Public Class Form1

    Dim fic

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'MsgBox("Adrien")
        'On Error Resume Next
        'Dim exe_lo
        'Dim directory = "C:\Program Files\"
        'For Each filename As String In IO.Directory.GetFiles(directory, "*exe", IO.SearchOption.AllDirectories)
        '    Dim fName As String = IO.Path.GetFileName(filename)
        '    If fName = "swriter.exe" Then
        '        exe_lo = filename
        '        MsgBox("OK")
        '    End If
        'Next

        Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        Try
            fic = CommandLineArgs(0)
        Catch ex As Exception
            MsgBox("Aucun fichier passé en paramètre")
            Application.Exit()
        End Try

    End Sub


    Private Sub btn_lo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lo.Click

        Try
            Dim lo As New System.Diagnostics.Process()
            lo = Process.Start("swriter.exe", fic)
        Catch ex As Exception
            MsgBox("LibreOffice n'est pas installé")
        End Try
        
        Application.Exit()

    End Sub

    Private Sub btn_wv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_wv.Click

        Try
            Dim wv As New System.Diagnostics.Process()
            wv = Process.Start("WORDVIEW.EXE", fic)
        Catch ex As Exception
            MsgBox("Word Viewer n'est pas installé")
        End Try

        Application.Exit()

    End Sub

    Private Sub btn_ow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ow.Click

        Try
            Dim ow As New System.Diagnostics.Process()
            ow = Process.Start("winword.exe", fic)
        Catch ex As Exception
            MsgBox("Office Word n'est pas installé")
        End Try

        Application.Exit()

    End Sub
End Class
