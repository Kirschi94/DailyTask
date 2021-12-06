﻿Imports System.Text.RegularExpressions
Public Class MainForm
    Private LastText As String = "00:00"
    Private ListOfTasks As List(Of DailyTask)
    Private Sub RadioButton_OnTheseDays_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_OnTheseDays.CheckedChanged
        If RadioButton_OnTheseDays.Checked Then RadioButton_EveryDay.Checked = False
        Change_Checkboxes(True)
    End Sub

    Private Sub RadioButton_EveryDay_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_EveryDay.CheckedChanged
        If RadioButton_EveryDay.Checked Then RadioButton_OnTheseDays.Checked = False
        Change_Checkboxes(False)
    End Sub

    Private Sub Change_Checkboxes(ByVal Bool As Boolean)
        CheckBox_Mo.Enabled = Bool
        CheckBox_Tue.Enabled = Bool
        CheckBox_Wed.Enabled = Bool
        CheckBox_Thu.Enabled = Bool
        CheckBox_Fr.Enabled = Bool
        CheckBox_Sat.Enabled = Bool
        CheckBox_Su.Enabled = Bool
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox_Taskdescription_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Taskdescription.TextChanged
        If TextBox_Taskdescription.Text = "" Or TextBox_Taskdescription.Text = Nothing Then
            Button_CreateTask.Enabled = False
        Else
            Button_CreateTask.Enabled = True
        End If
    End Sub

    Private Sub Check_Checkboxes(ByRef CheckingBox As CheckBox)
        If CheckBox_Mo.Checked Then Exit Sub
        If CheckBox_Tue.Checked Then Exit Sub
        If CheckBox_Wed.Checked Then Exit Sub
        If CheckBox_Thu.Checked Then Exit Sub
        If CheckBox_Fr.Checked Then Exit Sub
        If CheckBox_Sat.Checked Then Exit Sub
        If CheckBox_Su.Checked Then Exit Sub
        CheckingBox.Checked = True
        MessageBox.Show(Me, "At least one day has to be checked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub CheckBox_Mo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Mo.CheckedChanged
        Check_Checkboxes(CheckBox_Mo)
    End Sub

    Private Sub CheckBox_Tue_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Tue.CheckedChanged
        Check_Checkboxes(CheckBox_Tue)
    End Sub

    Private Sub CheckBox_Wed_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Wed.CheckedChanged
        Check_Checkboxes(CheckBox_Wed)
    End Sub

    Private Sub CheckBox_Thu_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Thu.CheckedChanged
        Check_Checkboxes(CheckBox_Thu)
    End Sub

    Private Sub CheckBox_Fr_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Fr.CheckedChanged
        Check_Checkboxes(CheckBox_Fr)
    End Sub

    Private Sub CheckBox_Sat_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Sat.CheckedChanged
        Check_Checkboxes(CheckBox_Sat)
    End Sub

    Private Sub CheckBox_Su_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Su.CheckedChanged
        Check_Checkboxes(CheckBox_Su)
    End Sub

    Private Sub TextBox_Tasktime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Tasktime.KeyPress
        Dim GoFurther As Short = TextBox_Tasktime.SelectionStart

        Select Case TextBox_Tasktime.SelectionStart
            Case 0
                TextBox_Tasktime.Text = e.KeyChar & TextBox_Tasktime.Text.Remove(0, 1)
            Case 1
                TextBox_Tasktime.Text = TextBox_Tasktime.Text.Substring(0, 1) & e.KeyChar & TextBox_Tasktime.Text.Substring(2, 3)
                GoFurther += 1
            Case 2
                GoFurther += 1
                TextBox_Tasktime.Text = TextBox_Tasktime.Text.Substring(0, 3) & e.KeyChar & TextBox_Tasktime.Text.Substring(4, 1)
            Case 3
                TextBox_Tasktime.Text = TextBox_Tasktime.Text.Substring(0, 3) & e.KeyChar & TextBox_Tasktime.Text.Substring(4, 1)
            Case 4
                TextBox_Tasktime.Text = TextBox_Tasktime.Text.Substring(0, 4) & e.KeyChar
        End Select
        GoFurther += 1

        Dim Times As String() = TextBox_Tasktime.Text.Split(":")
        If Int(Times.GetValue(0)) > 24 Or Int(Times.GetValue(0)) < 0 Or Int(Times.GetValue(1)) > 59 Or Int(Times.GetValue(1)) < 0 Then
            TextBox_Tasktime.Text = LastText
            TextBox_Tasktime.SelectionStart = GoFurther
            Exit Sub
        End If

        If TextBox_Tasktime.Text.StartsWith("24") Then TextBox_Tasktime.Text = "00" & TextBox_Tasktime.Text.Substring(2, 3)

        If Regex.IsMatch(TextBox_Tasktime.Text, "[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}", RegexOptions.None) Then
            LastText = TextBox_Tasktime.Text
        Else
            TextBox_Tasktime.Text = LastText
        End If

        TextBox_Tasktime.SelectionStart = GoFurther
    End Sub

    Private Sub Button_CreateTask_Click(sender As Object, e As EventArgs) Handles Button_CreateTask.Click
        BuildNewTask()
    End Sub

    Private Sub BuildNewTask()
        Dim TempID As Integer = GetRandomInt()
        Dim Contains As Boolean = True

        While Contains
            For Each TheItem In ListOfTasks
                If TheItem.ID = TempID Then
                    Contains = True
                    TempID = GetRandomInt()
                    Exit For
                Else
                    Contains = False
                End If
            Next
        End While

        If RadioButton_EveryDay.Checked Then
            Dim NewTask As New DailyTask(TempID, TextBox_Taskdescription.Text, TextBox_Tasktime.Text)
            ListOfTasks.Add(NewTask)
            BuildListviews()
            Exit Sub
        End If
        If RadioButton_OnTheseDays.Checked Then
            Dim NewTask As New DailyTask(TempID, TextBox_Taskdescription.Text, TextBox_Tasktime.Text,
                                         New Short() {CheckBox_Su.Checked * -1, CheckBox_Mo.Checked * -1, CheckBox_Tue.Checked * -1,
                                         CheckBox_Wed.Checked * -1, CheckBox_Thu.Checked * -1, CheckBox_Fr.Checked * -1, CheckBox_Sat.Checked * -1})
            ListOfTasks.Add(NewTask)
            BuildListviews()
        End If
    End Sub

    Private Sub BuildListviews()
        ListView_AllTasks.Items.Clear()
        ListView_CurrentTasks.Items.Clear()

        For Each TheItem In ListOfTasks
            With ListView_AllTasks.Items.Add(TheItem.Description)
                .SubItems.Add(TheItem.NextDue.ToString("yyyy/MM/dd, HH:mm"))
                .SubItems.Add(TheItem.ID)
            End With

            If CheckBox_ShowExecutedTasks.Checked And TheItem.Done Then
                'Abbruch in der Session wegen Kopffick
            End If
        Next
    End Sub

    Private Function GetRandomInt() As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As New Random()
        Return Generator.Next(Integer.MinValue, Integer.MaxValue)
    End Function
End Class