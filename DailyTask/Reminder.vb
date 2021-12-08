Imports System.ComponentModel

Public Class Reminder
    Public Shared Open As Boolean
    Public Shared Task As DailyTask
    Private Sub Reminder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Open = True
        Label_TaskText.Text = Task.Description
    End Sub

    Private Sub Reminder_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Open = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Task._Done = Stgs.Done
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Task._Done = Stgs.NotDone
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Task.Postpone()
        Close()
    End Sub
End Class