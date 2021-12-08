Imports System.ComponentModel

Public Class Reminder
    Public Shared Open As Boolean
    Public Shared Task As DailyTask
    Public Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIn()
    End Sub

    Public Sub LoadIn()
        Open = True
        Label_TaskText.Text = Task.Description
        WindowState = FormWindowState.Normal
        Media.SystemSounds.Exclamation.Play()
    End Sub

    Private Sub Reminder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Open = False
        Hide()
        e.Cancel = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Task._Done = Stgs.Done
        MainForm.RefreshListviews = True
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Task._Done = Stgs.NotDone
        MainForm.RefreshListviews = True
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Task.Postpone()
        MainForm.RefreshListviews = True
        Close()
    End Sub
End Class