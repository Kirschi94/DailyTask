Public Class MainForm
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
End Class
