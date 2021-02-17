' Author: Richard Zitha
' Email: equitekconsulting@gmail.com
' Class Name: frmMzansiForm

Option Explicit On
Option Infer Off
Option Strict Off

Imports System.ComponentModel
Imports System.IO
Imports VideoLibrary

Public Class frmMzansiForm

    Private Worker As BackgroundWorker
    Private is_Downloaded As Boolean = False

    ' Stores any information / data that needs to be passed to the background worker.
    Private Structure WorkerDataRec
        Public location As String
        Public link As String
    End Structure

    ' instance of the record sturcture.
    Private WorkerDataInstance As WorkerDataRec


    ' ==============================================================================================================
    '                               Event handlers
    ' ==============================================================================================================

    ' Exit menu tool: Closes the application if users confirms. 
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Dim confirm As Integer = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Confirm Exit")

        ' if the user confirmed exit.
        If confirm = 6 Then
            Application.Exit()
        End If

    End Sub

    ' About page too:
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Dim about As AboutDialog = New AboutDialog()
        about.Show()


    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click

        Dim link As String = txtYoutubeURL.Text
        Dim dialog = New FolderBrowserDialog()
        Dim location As String

        ' if the person selected a folder.
        If dialog.ShowDialog() = DialogResult.OK Then

        	' get the folder location.
            location = dialog.SelectedPath

            ' if txtYoutubeURL is not empty.
            If link.Trim.Length <> 0 Then

                ' stores the argumentsL link and location to be consumed by the background worker.
                WorkerDataInstance.link = link
                WorkerDataInstance.location = location

                ' Start a new thread and assign its handlers.
                Worker = New BackgroundWorker
                Worker.WorkerReportsProgress = True
                Worker.WorkerSupportsCancellation = True
                AddHandler Worker.DoWork, AddressOf backgroundDownload_DoWork
                AddHandler Worker.ProgressChanged, AddressOf backgroundDownload_ProgressChanged
                AddHandler Worker.RunWorkerCompleted, AddressOf backgroundDownload_Completed
                Worker.RunWorkerAsync()

                ' disable the download button to prevent multiple downloads at once.
                btnDownload.Enabled = False

            Else
                MsgBox("Please insert a YouTube link.", MsgBoxStyle.Critical, "Important")
            End If

        Else
            MsgBox("Please select a valid destination / directory / folder", MsgBoxStyle.Critical, "Invalid Directory")
        End If

    End Sub


    ' ===========================================================================================================
    '                               Download a youtube video on the backgound.
    ' ===========================================================================================================
    Private Sub backgroundDownload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

        Try
            Worker.ReportProgress(0)

            Dim video = YouTube.Default.GetVideo(WorkerDataInstance.link)
            File.WriteAllBytes(WorkerDataInstance.location & "\" & video.FullName, video.GetBytes())
            is_Downloaded = True

        Catch ex As Exception
            MsgBox("An unexpected error has occured. " & vbNewLine &
                   vbNewLine & ex.Message.ToString, MsgBoxStyle.Exclamation, "Unexpected error")
        End Try

    End Sub

    Private Sub backgroundDownload_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)

        ' monitor progress
        If Me.pbarDownloadMonitor.Visible = False Then
            Me.pbarDownloadMonitor.Visible = True
            Me.pbarDownloadMonitor.Show()
            Me.lblInstructionText.Text = "Downloading ..."

        End If

    End Sub

    Private Sub backgroundDownload_Completed(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)

        ' enable button.
        btnDownload.Enabled = True
        pbarDownloadMonitor.Visible = False
        lblInstructionText.Text = "Paste the YouTube link / url below"

        If is_Downloaded = True Then
            MsgBox("Video was successfully downloaded.", MsgBoxStyle.Information, "Successful download")
        End If

    End Sub

End Class
