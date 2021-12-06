Imports System.Text.RegularExpressions
Public Class MainForm
    Private LastText As String = Nothing
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

    Private Sub TextBox_Tasktime_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Tasktime.TextChanged
        '[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}
        'Regex.IsMatch(TextBox_Tasktime.Text, "[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}", RegexOptions.None)
        'TextBox_Tasktime.Text = String.Format("00:00", TextBox_Tasktime.Text)
        If Not TextBox_Tasktime.Text.Contains(":") Then
            TextBox_Tasktime.Text = LastText
            Exit Sub
        End If
        Dim Zeiten As String() = TextBox_Tasktime.Text.Split(":")
        If Int(Zeiten.GetValue(0)) > 24 Or Int(Zeiten.GetValue(0)) < 0 Or Int(Zeiten.GetValue(1)) > 59 Or Int(Zeiten.GetValue(1)) < 0 Then
            TextBox_Tasktime.Text = LastText
            Exit Sub
        End If
        'TextBox_Tasktime.Text = Format(Zeiten.GetValue(0), "g") & ":" & Format(Zeiten.GetValue(1), "g")
        If Regex.IsMatch(TextBox_Tasktime.Text, "[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}", RegexOptions.None) Then
            TextBox_Tasktime.Text = String.Format("{0}:{1}", Format(Zeiten.GetValue(0), "00"), Format(Zeiten.GetValue(1), "00"))
            'TextBox_Tasktime.Text = Format(TextBox_Tasktime.Text, "00:00")
            LastText = TextBox_Tasktime.Text
        End If
    End Sub

    Private Sub TextBox_Tasktime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Tasktime.KeyPress
        '[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}
        'Regex.IsMatch(TextBox_Tasktime.Text, "[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}", RegexOptions.None)
        'TextBox_Tasktime.Text = String.Format("00:00", TextBox_Tasktime.Text)
        'TextBox_Tasktime.SelectionStart
        If Not TextBox_Tasktime.Text.Contains(":") Then
            'TextBox_Tasktime.Text = LastText
        Exit Sub
        End If
        Dim Zeiten As String() = TextBox_Tasktime.Text.Split(":")
        If Int(Zeiten.GetValue(0)) > 24 Or Int(Zeiten.GetValue(0)) < 0 Or Int(Zeiten.GetValue(1)) > 59 Or Int(Zeiten.GetValue(1)) < 0 Then
            'TextBox_Tasktime.Text = LastText
            Exit Sub
        End If
        'TextBox_Tasktime.Text = Format(Zeiten.GetValue(0), "g") & ":" & Format(Zeiten.GetValue(1), "g")
        If Regex.IsMatch(TextBox_Tasktime.Text, "[0-2]{1}[0-9]{1}(:)[0-5]{1}[0-9]{1}", RegexOptions.None) Then
            'TextBox_Tasktime.Text = String.Format("{0}:{1}", Format(Zeiten.GetValue(0), "00"), Format(Zeiten.GetValue(1), "00"))
            'TextBox_Tasktime.Text = Format(TextBox_Tasktime.Text, "00:00")
            'LastText = TextBox_Tasktime.Text
        End If
    End Sub
End Class
