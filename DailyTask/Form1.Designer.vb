﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ListView_CurrentTasks = New System.Windows.Forms.ListView()
        Me.TabControl_Main = New System.Windows.Forms.TabControl()
        Me.CurrentTasks = New System.Windows.Forms.TabPage()
        Me.CheckBox_ShowNotToday = New System.Windows.Forms.CheckBox()
        Me.CreateNewTask = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox_Wed = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Tue = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Mo = New System.Windows.Forms.CheckBox()
        Me.RadioButton_OnTheseDays = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Tasktime = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Taskdescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton_EveryDay = New System.Windows.Forms.RadioButton()
        Me.ListView_AllTasks = New System.Windows.Forms.ListView()
        Me.CheckBox_Thu = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Fr = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Sat = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Su = New System.Windows.Forms.CheckBox()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.TabControl_Main.SuspendLayout()
        Me.CurrentTasks.SuspendLayout()
        Me.CreateNewTask.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView_CurrentTasks
        '
        Me.ListView_CurrentTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView_CurrentTasks.HideSelection = False
        Me.ListView_CurrentTasks.Location = New System.Drawing.Point(6, 6)
        Me.ListView_CurrentTasks.Name = "ListView_CurrentTasks"
        Me.ListView_CurrentTasks.Size = New System.Drawing.Size(656, 400)
        Me.ListView_CurrentTasks.TabIndex = 0
        Me.ListView_CurrentTasks.UseCompatibleStateImageBehavior = False
        Me.ListView_CurrentTasks.View = System.Windows.Forms.View.Details
        '
        'TabControl_Main
        '
        Me.TabControl_Main.Controls.Add(Me.CurrentTasks)
        Me.TabControl_Main.Controls.Add(Me.CreateNewTask)
        Me.TabControl_Main.Location = New System.Drawing.Point(12, 12)
        Me.TabControl_Main.Name = "TabControl_Main"
        Me.TabControl_Main.SelectedIndex = 0
        Me.TabControl_Main.Size = New System.Drawing.Size(843, 440)
        Me.TabControl_Main.TabIndex = 1
        '
        'CurrentTasks
        '
        Me.CurrentTasks.Controls.Add(Me.CheckBox_ShowNotToday)
        Me.CurrentTasks.Controls.Add(Me.ListView_CurrentTasks)
        Me.CurrentTasks.Location = New System.Drawing.Point(4, 24)
        Me.CurrentTasks.Name = "CurrentTasks"
        Me.CurrentTasks.Padding = New System.Windows.Forms.Padding(3)
        Me.CurrentTasks.Size = New System.Drawing.Size(835, 412)
        Me.CurrentTasks.TabIndex = 0
        Me.CurrentTasks.Text = "Current Tasks"
        Me.CurrentTasks.UseVisualStyleBackColor = True
        '
        'CheckBox_ShowNotToday
        '
        Me.CheckBox_ShowNotToday.AutoSize = True
        Me.CheckBox_ShowNotToday.Location = New System.Drawing.Point(668, 6)
        Me.CheckBox_ShowNotToday.Name = "CheckBox_ShowNotToday"
        Me.CheckBox_ShowNotToday.Size = New System.Drawing.Size(161, 19)
        Me.CheckBox_ShowNotToday.TabIndex = 1
        Me.CheckBox_ShowNotToday.Text = "Show tasks not due today"
        Me.CheckBox_ShowNotToday.UseVisualStyleBackColor = True
        '
        'CreateNewTask
        '
        Me.CreateNewTask.Controls.Add(Me.Panel1)
        Me.CreateNewTask.Controls.Add(Me.ListView_AllTasks)
        Me.CreateNewTask.Location = New System.Drawing.Point(4, 24)
        Me.CreateNewTask.Name = "CreateNewTask"
        Me.CreateNewTask.Padding = New System.Windows.Forms.Padding(3)
        Me.CreateNewTask.Size = New System.Drawing.Size(835, 412)
        Me.CreateNewTask.TabIndex = 1
        Me.CreateNewTask.Text = "Create new Task"
        Me.CreateNewTask.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox_Su)
        Me.Panel1.Controls.Add(Me.CheckBox_Sat)
        Me.Panel1.Controls.Add(Me.CheckBox_Fr)
        Me.Panel1.Controls.Add(Me.CheckBox_Thu)
        Me.Panel1.Controls.Add(Me.CheckBox_Wed)
        Me.Panel1.Controls.Add(Me.CheckBox_Tue)
        Me.Panel1.Controls.Add(Me.CheckBox_Mo)
        Me.Panel1.Controls.Add(Me.RadioButton_OnTheseDays)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox_Tasktime)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox_Taskdescription)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.RadioButton_EveryDay)
        Me.Panel1.Location = New System.Drawing.Point(409, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(420, 400)
        Me.Panel1.TabIndex = 2
        '
        'CheckBox_Wed
        '
        Me.CheckBox_Wed.AutoSize = True
        Me.CheckBox_Wed.Location = New System.Drawing.Point(124, 221)
        Me.CheckBox_Wed.Name = "CheckBox_Wed"
        Me.CheckBox_Wed.Size = New System.Drawing.Size(50, 19)
        Me.CheckBox_Wed.TabIndex = 14
        Me.CheckBox_Wed.Text = "Wed"
        Me.CheckBox_Wed.UseVisualStyleBackColor = True
        '
        'CheckBox_Tue
        '
        Me.CheckBox_Tue.AutoSize = True
        Me.CheckBox_Tue.Location = New System.Drawing.Point(64, 221)
        Me.CheckBox_Tue.Name = "CheckBox_Tue"
        Me.CheckBox_Tue.Size = New System.Drawing.Size(45, 19)
        Me.CheckBox_Tue.TabIndex = 13
        Me.CheckBox_Tue.Text = "Tue"
        Me.CheckBox_Tue.UseVisualStyleBackColor = True
        '
        'CheckBox_Mo
        '
        Me.CheckBox_Mo.AutoSize = True
        Me.CheckBox_Mo.Location = New System.Drawing.Point(5, 221)
        Me.CheckBox_Mo.Name = "CheckBox_Mo"
        Me.CheckBox_Mo.Size = New System.Drawing.Size(44, 19)
        Me.CheckBox_Mo.TabIndex = 12
        Me.CheckBox_Mo.Text = "Mo"
        Me.CheckBox_Mo.UseVisualStyleBackColor = True
        '
        'RadioButton_OnTheseDays
        '
        Me.RadioButton_OnTheseDays.AutoSize = True
        Me.RadioButton_OnTheseDays.Location = New System.Drawing.Point(5, 196)
        Me.RadioButton_OnTheseDays.Name = "RadioButton_OnTheseDays"
        Me.RadioButton_OnTheseDays.Size = New System.Drawing.Size(102, 19)
        Me.RadioButton_OnTheseDays.TabIndex = 11
        Me.RadioButton_OnTheseDays.TabStop = True
        Me.RadioButton_OnTheseDays.Text = "On these days:"
        Me.RadioButton_OnTheseDays.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "h"
        '
        'TextBox_Tasktime
        '
        Me.TextBox_Tasktime.Location = New System.Drawing.Point(30, 110)
        Me.TextBox_Tasktime.Name = "TextBox_Tasktime"
        Me.TextBox_Tasktime.Size = New System.Drawing.Size(39, 23)
        Me.TextBox_Tasktime.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "At"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Task is due:"
        '
        'TextBox_Taskdescription
        '
        Me.TextBox_Taskdescription.Location = New System.Drawing.Point(105, 30)
        Me.TextBox_Taskdescription.Name = "TextBox_Taskdescription"
        Me.TextBox_Taskdescription.Size = New System.Drawing.Size(312, 23)
        Me.TextBox_Taskdescription.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Task description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Create a task:"
        '
        'RadioButton_EveryDay
        '
        Me.RadioButton_EveryDay.AutoSize = True
        Me.RadioButton_EveryDay.Location = New System.Drawing.Point(5, 158)
        Me.RadioButton_EveryDay.Name = "RadioButton_EveryDay"
        Me.RadioButton_EveryDay.Size = New System.Drawing.Size(75, 19)
        Me.RadioButton_EveryDay.TabIndex = 3
        Me.RadioButton_EveryDay.TabStop = True
        Me.RadioButton_EveryDay.Text = "Every day"
        Me.RadioButton_EveryDay.UseVisualStyleBackColor = True
        '
        'ListView_AllTasks
        '
        Me.ListView_AllTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView_AllTasks.HideSelection = False
        Me.ListView_AllTasks.Location = New System.Drawing.Point(6, 6)
        Me.ListView_AllTasks.Name = "ListView_AllTasks"
        Me.ListView_AllTasks.Size = New System.Drawing.Size(397, 400)
        Me.ListView_AllTasks.TabIndex = 1
        Me.ListView_AllTasks.UseCompatibleStateImageBehavior = False
        Me.ListView_AllTasks.View = System.Windows.Forms.View.Details
        '
        'CheckBox_Thu
        '
        Me.CheckBox_Thu.AutoSize = True
        Me.CheckBox_Thu.Location = New System.Drawing.Point(190, 221)
        Me.CheckBox_Thu.Name = "CheckBox_Thu"
        Me.CheckBox_Thu.Size = New System.Drawing.Size(46, 19)
        Me.CheckBox_Thu.TabIndex = 15
        Me.CheckBox_Thu.Text = "Thu"
        Me.CheckBox_Thu.UseVisualStyleBackColor = True
        '
        'CheckBox_Fr
        '
        Me.CheckBox_Fr.AutoSize = True
        Me.CheckBox_Fr.Location = New System.Drawing.Point(255, 221)
        Me.CheckBox_Fr.Name = "CheckBox_Fr"
        Me.CheckBox_Fr.Size = New System.Drawing.Size(36, 19)
        Me.CheckBox_Fr.TabIndex = 16
        Me.CheckBox_Fr.Text = "Fr"
        Me.CheckBox_Fr.UseVisualStyleBackColor = True
        '
        'CheckBox_Sat
        '
        Me.CheckBox_Sat.AutoSize = True
        Me.CheckBox_Sat.Location = New System.Drawing.Point(310, 221)
        Me.CheckBox_Sat.Name = "CheckBox_Sat"
        Me.CheckBox_Sat.Size = New System.Drawing.Size(42, 19)
        Me.CheckBox_Sat.TabIndex = 17
        Me.CheckBox_Sat.Text = "Sat"
        Me.CheckBox_Sat.UseVisualStyleBackColor = True
        '
        'CheckBox_Su
        '
        Me.CheckBox_Su.AutoSize = True
        Me.CheckBox_Su.Location = New System.Drawing.Point(372, 221)
        Me.CheckBox_Su.Name = "CheckBox_Su"
        Me.CheckBox_Su.Size = New System.Drawing.Size(39, 19)
        Me.CheckBox_Su.TabIndex = 18
        Me.CheckBox_Su.Text = "Su"
        Me.CheckBox_Su.UseVisualStyleBackColor = True
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Task"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Next due"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Task"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Next due"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 464)
        Me.Controls.Add(Me.TabControl_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "DailyTask"
        Me.TabControl_Main.ResumeLayout(False)
        Me.CurrentTasks.ResumeLayout(False)
        Me.CurrentTasks.PerformLayout()
        Me.CreateNewTask.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView_CurrentTasks As ListView
    Friend WithEvents TabControl_Main As TabControl
    Friend WithEvents CurrentTasks As TabPage
    Friend WithEvents CheckBox_ShowNotToday As CheckBox
    Friend WithEvents CreateNewTask As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListView_AllTasks As ListView
    Friend WithEvents CheckBox_Wed As CheckBox
    Friend WithEvents CheckBox_Tue As CheckBox
    Friend WithEvents CheckBox_Mo As CheckBox
    Friend WithEvents RadioButton_OnTheseDays As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Tasktime As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Taskdescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton_EveryDay As RadioButton
    Friend WithEvents CheckBox_Su As CheckBox
    Friend WithEvents CheckBox_Sat As CheckBox
    Friend WithEvents CheckBox_Fr As CheckBox
    Friend WithEvents CheckBox_Thu As CheckBox
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
