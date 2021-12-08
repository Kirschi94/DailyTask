Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class MainForm
    Private LastText As String = "00:00"
    Public Shared ListOfTasks As New List(Of DailyTask)()
    Private ListOfPasts As New List(Of DailyTask)()
    Private ListOfOverdueTasks As New List(Of DailyTask)()
    Private LastCheck As String = Stgs.GetDayOfYearFormatted()
    Private Overdue As Boolean = False
    Public Shared RefreshListviews As Boolean = False
    Private Closable As Boolean = False
    Private ReminderWindow = New Reminder

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

        If Regex.IsMatch(TextBox_Tasktime.Text, "[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}", RegexOptions.None) Then
            Dim Times As String() = TextBox_Tasktime.Text.Split(":")
            If Int(Times.GetValue(0)) > 24 Or Int(Times.GetValue(0)) < 0 Or Int(Times.GetValue(1)) > 59 Or Int(Times.GetValue(1)) < 0 Then
                TextBox_Tasktime.Text = LastText
                TextBox_Tasktime.SelectionStart = GoFurther
                Exit Sub
            End If

            If TextBox_Tasktime.Text.StartsWith("24") Then TextBox_Tasktime.Text = "00" & TextBox_Tasktime.Text.Substring(2, 3)
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

        If ListOfTasks.Count > 0 Then
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
        End If

        If RadioButton_EveryDay.Checked Then
            Dim NewTask As New DailyTask(TempID, TextBox_Taskdescription.Text, TextBox_Tasktime.Text)
            ListOfTasks.Add(NewTask)
            BuildListview_AllTasks()
            BuildListview_CurrentTasks()
            Exit Sub
        End If
        If RadioButton_OnTheseDays.Checked Then
            Dim NewTask As New DailyTask(TempID, TextBox_Taskdescription.Text, TextBox_Tasktime.Text,
                                         New Short() {CheckBox_Su.Checked * -1, CheckBox_Mo.Checked * -1, CheckBox_Tue.Checked * -1,
                                         CheckBox_Wed.Checked * -1, CheckBox_Thu.Checked * -1, CheckBox_Fr.Checked * -1, CheckBox_Sat.Checked * -1})
            ListOfTasks.Add(NewTask)
            BuildListview_AllTasks()
            BuildListview_CurrentTasks()
        End If
    End Sub

    Public Sub BuildListview_AllTasks()
        ListView_AllTasks.Items.Clear()

        For Each TheItem In ListOfTasks
            With ListView_AllTasks.Items.Add(TheItem.Description)
                .SubItems.Add(TheItem.NextDue.ToString("dd/MM/yyyy, HH:mm"))
                .SubItems.Add(TheItem.ID)
            End With
        Next
    End Sub

    Public Sub BuildListview_CurrentTasks()
        ListView_CurrentTasks.Items.Clear()

        For Each TheItem In ListOfTasks
            If TheItem._Done = stgs.Done AndAlso CheckBox_ShowExecutedTasks.Checked = False Then
                'Do nothing
            Else
                If CheckBox_ShowNotToday.Checked = False AndAlso Not (TheItem.NextDue.Year = DateTime.Now.Year AndAlso TheItem.NextDue.DayOfYear = DateTime.Now.DayOfYear) Then
                    'Do nothing
                Else
                    ListView_CurrentTasks.ShowGroups = CheckBox_ShowNotToday.Checked

                    With ListView_CurrentTasks.Items.Add(TheItem.Description)
                        .SubItems.Add(TheItem.OriginalDue.ToString("dd/MM/yyyy, HH:mm"))
                        .SubItems.Add(TheItem._Done)
                        .SubItems.Add(TheItem.ID)

                        'GroupView somehow doesn't work, still need to fix this
                        Dim TempGroup As New ListViewGroup(TheItem.OriginalDue.ToString("dd/MM/yyyy"))
                        If Not ListView_CurrentTasks.Groups.Contains(TempGroup) Then
                            ListView_CurrentTasks.Groups.Add(TempGroup)
                        End If
                        .Group = TempGroup
                    End With
                End If
            End If
        Next
    End Sub

    Private Sub BuildListview_PastTasks()
        If Directory.Exists(Application.StartupPath & "\The Past") Then
            Dim files() As String = Directory.GetFiles(Application.StartupPath & "\The Past")
            For Each file As String In files
                Dim TempTask As DailyTask = GetDataFromJsonFile(file)
                TempTask.GetNextDue()
                ListOfPasts.Add(TempTask)
            Next
        Else
            Directory.CreateDirectory(Application.StartupPath & "\The Past")
        End If

        ListView_PastTasks.Items.Clear()
        For Each TheItem In ListOfPasts
            With ListView_PastTasks.Items.Add(TheItem.Description)
                .SubItems.Add(TheItem.OriginalDue.ToString("dd/MM/yyyy, HH:mm"))
                .SubItems.Add(TheItem.NextDue.ToString("dd/MM/yyyy, HH:mm"))
                .SubItems.Add(TheItem._Done)
                .SubItems.Add(TheItem.ID)

                Dim TempGroup As New ListViewGroup(TheItem.OriginalDue.ToString("dd/MM/yyyy"))
                If Not ListView_CurrentTasks.Groups.Contains(TempGroup) Then
                    ListView_CurrentTasks.Groups.Add(TempGroup)
                End If
                .Group = TempGroup
            End With
        Next
    End Sub

    Private Function GetRandomInt() As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As New Random()
        Return Generator.Next(Integer.MinValue, Integer.MaxValue)
    End Function

    Private Sub CheckBox_ShowNotToday_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ShowNotToday.CheckedChanged
        BuildListview_CurrentTasks()
    End Sub

    Private Sub CheckBox_ShowExecutedTasks_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ShowExecutedTasks.CheckedChanged
        BuildListview_CurrentTasks()
    End Sub

    Private Sub MarkAs(ID As Integer, TheValue As String)
        For Each TheItem In ListOfTasks
            If TheItem.ID = ID Then
                TheItem._Done = TheValue
                Exit For
            End If
        Next
        BuildListview_CurrentTasks()
        BuildListview_AllTasks()
    End Sub

    Private Sub DeleteTask(ID As Integer)
        For Each TheItem In ListOfTasks
            If TheItem.ID = ID Then
                ListOfTasks.Remove(TheItem)
                Exit For
            End If
        Next
        If File.Exists(Application.StartupPath & "\Tasks\" & ID.ToString() & ".json") Then
            File.Delete(Application.StartupPath & "\Tasks\" & ID.ToString() & ".json")
        End If
        BuildListview_CurrentTasks()
        BuildListview_AllTasks()
    End Sub

    Private Sub MarkAsDoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsDoneToolStripMenuItem.Click
        MarkAs(Int(ListView_CurrentTasks.SelectedItems.Item(0).SubItems.Item(3).Text), "🗸")
    End Sub

    Private Sub MarkAsXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsXToolStripMenuItem.Click
        MarkAs(Int(ListView_CurrentTasks.SelectedItems.Item(0).SubItems.Item(3).Text), "x")
    End Sub

    Private Sub MarkAsQMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsQMToolStripMenuItem.Click
        MarkAs(Int(ListView_CurrentTasks.SelectedItems.Item(0).SubItems.Item(3).Text), "?")
    End Sub

    Private Sub MarkAsUnfulfilledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkAsUnfulfilledToolStripMenuItem.Click
        MarkAs(Int(ListView_CurrentTasks.SelectedItems.Item(0).SubItems.Item(3).Text), "o")
    End Sub

    Private Sub EditTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTaskToolStripMenuItem.Click

    End Sub

    Private Sub DeleteTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteTaskToolStripMenuItem.Click
        If MessageBox.Show(Me, "Are you sure you want to delete the selected task?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            DeleteTask(Int(ListView_CurrentTasks.SelectedItems.Item(0).SubItems.Item(3).Text))
        End If
    End Sub

    Private Sub LVCT_ContextMenuItemsEnabled(TheValue As Boolean)
        MarkTaskToolStripMenuItem.Enabled = TheValue
        MarkAsDoneToolStripMenuItem.Enabled = TheValue
        MarkAsXToolStripMenuItem.Enabled = TheValue
        MarkAsQMToolStripMenuItem.Enabled = TheValue
        MarkAsUnfulfilledToolStripMenuItem.Enabled = TheValue
        EditTaskToolStripMenuItem.Enabled = TheValue
        DeleteTaskToolStripMenuItem.Enabled = TheValue
    End Sub

    Private Sub CheckContextMenuBasedOnSelectedTask(TheListView As ListView)
        MarkAsDoneToolStripMenuItem.Checked = False
        MarkAsXToolStripMenuItem.Checked = False
        MarkAsQMToolStripMenuItem.Checked = False
        MarkAsUnfulfilledToolStripMenuItem.Checked = False
        Select Case TheListView.SelectedItems.Item(0).SubItems.Item(2).Text
            Case stgs.Done
                MarkAsDoneToolStripMenuItem.Checked = True
            Case stgs.NotDone
                MarkAsXToolStripMenuItem.Checked = True
            Case stgs.Unclear
                MarkAsQMToolStripMenuItem.Checked = True
            Case stgs.Pending
                MarkAsUnfulfilledToolStripMenuItem.Checked = True
        End Select
    End Sub

    Private Sub ContextMenuStrip_LVCT_Opening(sender As Object, e As CancelEventArgs) Handles ContextMenuStrip_LVCT.Opening
        If ListView_CurrentTasks.SelectedItems.Count <= 0 Then
            LVCT_ContextMenuItemsEnabled(False)
        Else
            LVCT_ContextMenuItemsEnabled(True)
            CheckContextMenuBasedOnSelectedTask(ListView_CurrentTasks)
        End If
    End Sub

    Private Function GetDataFromJsonFile(FilePath As String)
        Dim rawJson = File.ReadAllText(FilePath)
        Return ToClass(Of DailyTask)(rawJson)
    End Function

    Private Function GetJsonFromDailyTask(TheDailyTask As DailyTask)
        Return FromClass(TheDailyTask)
    End Function

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Closable Then
            If Not Directory.Exists(Application.StartupPath & "\Tasks") Then
                Directory.CreateDirectory(Application.StartupPath & "\Tasks")
            End If
            For Each task As DailyTask In ListOfTasks
                File.WriteAllText(Application.StartupPath & "\Tasks\" & task.ID.ToString() & ".json", task.ToJson())
            Next

            If Not Directory.Exists(Application.StartupPath & "\The Past") Then
                Directory.CreateDirectory(Application.StartupPath & "\The Past")
            End If
            For Each task As DailyTask In ListOfPasts
                File.WriteAllText(Application.StartupPath & "\The Past\" & task.ID.ToString() & ".json", task.ToJson())
            Next
        Else
            e.Cancel = True
            WindowState = FormWindowState.Minimized
            Hide()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Directory.Exists(Application.StartupPath & "\Tasks") Then
            Dim files() As String = Directory.GetFiles(Application.StartupPath & "\Tasks")
            For Each file As String In files
                Dim TempTask As DailyTask = GetDataFromJsonFile(file)
                TempTask.GetNextDue()
                ListOfTasks.Add(TempTask)
            Next
            BuildListview_AllTasks()
            BuildListview_CurrentTasks()
        Else
            Directory.CreateDirectory(Application.StartupPath & "\Tasks")
        End If
        BuildListview_PastTasks()
    End Sub

    Private Sub Timer_CheckTasks_Tick(sender As Object, e As EventArgs) Handles Timer_CheckTasks.Tick
        If RefreshListviews Then
            BuildListview_AllTasks()
            BuildListview_CurrentTasks()

            Dim counting = 0
            Dim TempList As New List(Of DailyTask)()
            For Each TheItem In ListOfTasks
                If TheItem.OriginalDue.ToString("dd/MM/yyyy") = DateTime.Now.ToString("dd/MM/yyyy") Then
                    TempList.Add(TheItem)
                    If TheItem._Done = Stgs.Done Then counting += 1
                End If
            Next
            If counting = TempList.Count Then
                AppIcon.Icon = My.Resources.Hell_kein_Schatten_grün
            End If
            TempList.Clear()

            RefreshListviews = False
        End If

        For Each TheTask In ListOfTasks
            If TheTask.NextDue <= Date.Now Then
                Remind(TheTask)
            End If
        Next
        If (Not LastCheck = Stgs.GetDayOfYearFormatted()) OrElse Overdue Then
            'TheItem.OriginalDue.ToString("dd/MM/yyyy, HH:mm")
            For Each TheItem In ListOfTasks
                If TheItem.NextDue < Date.Now AndAlso (Not TheItem._Done = Stgs.Pending) Then
                    ListOfPasts.Add(TheItem.Clone())
                    TheItem.GetNextDue()
                End If
                If TheItem.OriginalDue < Date.Now AndAlso TheItem.NextDue > Date.Now Then
                    Overdue = True
                    ListOfOverdueTasks.Add(TheItem)
                    AppIcon.Icon = My.Resources.Hell_kein_Schatten_hellblau
                End If
            Next
        End If
        If Overdue Then
            For Each TheItem In ListOfOverdueTasks
                If TheItem.NextDue < Date.Now AndAlso (Not TheItem._Done = Stgs.Pending) Then
                    ListOfPasts.Add(TheItem.Clone())
                    TheItem.GetNextDue()
                    ListOfOverdueTasks.Remove(TheItem)
                End If
            Next
            If ListOfOverdueTasks.Count <= 0 Then
                Overdue = False
                AppIcon.Icon = My.Resources.Hell_kein_Schatten
            End If
        Else
            LastCheck = Stgs.GetDayOfYearFormatted()
        End If
    End Sub

    Private Sub Remind(ByRef TheTask As DailyTask)
        If ReminderWindow.Open Then
            TheTask.Postpone()
        Else
            ReminderWindow.Task = TheTask
            ReminderWindow.Show()
        End If
    End Sub

    Private Sub AppIcon_DoubleClick(sender As Object, e As EventArgs) Handles AppIcon.DoubleClick
        WindowState = FormWindowState.Normal
        Show()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        WindowState = FormWindowState.Normal
        Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Closable = True
        Close()
    End Sub
End Class
