<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ListView_CurrentTasks = New System.Windows.Forms.ListView()
        Me.Column_LVCT_Task = New System.Windows.Forms.ColumnHeader()
        Me.Column_LVCT_NextDue = New System.Windows.Forms.ColumnHeader()
        Me.Column_LVCT_Done = New System.Windows.Forms.ColumnHeader()
        Me.ContextMenuStrip_LVCT = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarkTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsDoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsQMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkAsUnfulfilledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTaskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl_Main = New System.Windows.Forms.TabControl()
        Me.CurrentTasks = New System.Windows.Forms.TabPage()
        Me.CheckBox_ShowExecutedTasks = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ShowNotToday = New System.Windows.Forms.CheckBox()
        Me.CreateNewTask = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_CreateTask = New System.Windows.Forms.Button()
        Me.CheckBox_Su = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Sat = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Fr = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Thu = New System.Windows.Forms.CheckBox()
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
        Me.Column_LVNT_Task = New System.Windows.Forms.ColumnHeader()
        Me.Column_LVNT_NextDue = New System.Windows.Forms.ColumnHeader()
        Me.ContextMenuStrip_LVAT = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditTaskToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTaskToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PastTasks = New System.Windows.Forms.TabPage()
        Me.ListView_PastTasks = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ContextMenuStrip_LVPT = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTaskToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer_CheckTasks = New System.Windows.Forms.Timer(Me.components)
        Me.AppIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip_Icon = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_MajorError = New System.Windows.Forms.Label()
        Me.ContextMenuStrip_LVCT.SuspendLayout()
        Me.TabControl_Main.SuspendLayout()
        Me.CurrentTasks.SuspendLayout()
        Me.CreateNewTask.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip_LVAT.SuspendLayout()
        Me.PastTasks.SuspendLayout()
        Me.ContextMenuStrip_LVPT.SuspendLayout()
        Me.ContextMenuStrip_Icon.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView_CurrentTasks
        '
        Me.ListView_CurrentTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column_LVCT_Task, Me.Column_LVCT_NextDue, Me.Column_LVCT_Done})
        Me.ListView_CurrentTasks.ContextMenuStrip = Me.ContextMenuStrip_LVCT
        Me.ListView_CurrentTasks.HideSelection = False
        Me.ListView_CurrentTasks.Location = New System.Drawing.Point(6, 6)
        Me.ListView_CurrentTasks.Name = "ListView_CurrentTasks"
        Me.ListView_CurrentTasks.Size = New System.Drawing.Size(705, 441)
        Me.ListView_CurrentTasks.TabIndex = 0
        Me.ListView_CurrentTasks.UseCompatibleStateImageBehavior = False
        Me.ListView_CurrentTasks.View = System.Windows.Forms.View.Details
        '
        'Column_LVCT_Task
        '
        Me.Column_LVCT_Task.Text = "Task"
        Me.Column_LVCT_Task.Width = 360
        '
        'Column_LVCT_NextDue
        '
        Me.Column_LVCT_NextDue.Text = "Next due"
        Me.Column_LVCT_NextDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Column_LVCT_NextDue.Width = 200
        '
        'Column_LVCT_Done
        '
        Me.Column_LVCT_Done.Text = "Done"
        Me.Column_LVCT_Done.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Column_LVCT_Done.Width = 140
        '
        'ContextMenuStrip_LVCT
        '
        Me.ContextMenuStrip_LVCT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkTaskToolStripMenuItem, Me.EditTaskToolStripMenuItem, Me.DeleteTaskToolStripMenuItem})
        Me.ContextMenuStrip_LVCT.Name = "ContextMenuStrip_LVCT"
        Me.ContextMenuStrip_LVCT.Size = New System.Drawing.Size(132, 70)
        '
        'MarkTaskToolStripMenuItem
        '
        Me.MarkTaskToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarkAsDoneToolStripMenuItem, Me.MarkAsXToolStripMenuItem, Me.MarkAsQMToolStripMenuItem, Me.MarkAsUnfulfilledToolStripMenuItem})
        Me.MarkTaskToolStripMenuItem.Name = "MarkTaskToolStripMenuItem"
        Me.MarkTaskToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.MarkTaskToolStripMenuItem.Text = "Mark task"
        '
        'MarkAsDoneToolStripMenuItem
        '
        Me.MarkAsDoneToolStripMenuItem.Name = "MarkAsDoneToolStripMenuItem"
        Me.MarkAsDoneToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MarkAsDoneToolStripMenuItem.Text = "Mark as '🗸'"
        '
        'MarkAsXToolStripMenuItem
        '
        Me.MarkAsXToolStripMenuItem.Name = "MarkAsXToolStripMenuItem"
        Me.MarkAsXToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MarkAsXToolStripMenuItem.Text = "Mark as 'x'"
        '
        'MarkAsQMToolStripMenuItem
        '
        Me.MarkAsQMToolStripMenuItem.Name = "MarkAsQMToolStripMenuItem"
        Me.MarkAsQMToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MarkAsQMToolStripMenuItem.Text = "Mark as '?'"
        '
        'MarkAsUnfulfilledToolStripMenuItem
        '
        Me.MarkAsUnfulfilledToolStripMenuItem.Name = "MarkAsUnfulfilledToolStripMenuItem"
        Me.MarkAsUnfulfilledToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.MarkAsUnfulfilledToolStripMenuItem.Text = "Mark as 'o'"
        '
        'EditTaskToolStripMenuItem
        '
        Me.EditTaskToolStripMenuItem.Name = "EditTaskToolStripMenuItem"
        Me.EditTaskToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EditTaskToolStripMenuItem.Text = "Edit task"
        '
        'DeleteTaskToolStripMenuItem
        '
        Me.DeleteTaskToolStripMenuItem.Name = "DeleteTaskToolStripMenuItem"
        Me.DeleteTaskToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteTaskToolStripMenuItem.Text = "Delete task"
        '
        'TabControl_Main
        '
        Me.TabControl_Main.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl_Main.Controls.Add(Me.CurrentTasks)
        Me.TabControl_Main.Controls.Add(Me.CreateNewTask)
        Me.TabControl_Main.Controls.Add(Me.PastTasks)
        Me.TabControl_Main.Location = New System.Drawing.Point(12, 12)
        Me.TabControl_Main.Name = "TabControl_Main"
        Me.TabControl_Main.SelectedIndex = 0
        Me.TabControl_Main.Size = New System.Drawing.Size(892, 481)
        Me.TabControl_Main.TabIndex = 1
        '
        'CurrentTasks
        '
        Me.CurrentTasks.Controls.Add(Me.CheckBox_ShowExecutedTasks)
        Me.CurrentTasks.Controls.Add(Me.CheckBox_ShowNotToday)
        Me.CurrentTasks.Controls.Add(Me.ListView_CurrentTasks)
        Me.CurrentTasks.Location = New System.Drawing.Point(4, 24)
        Me.CurrentTasks.Name = "CurrentTasks"
        Me.CurrentTasks.Padding = New System.Windows.Forms.Padding(3)
        Me.CurrentTasks.Size = New System.Drawing.Size(884, 453)
        Me.CurrentTasks.TabIndex = 0
        Me.CurrentTasks.Text = "Current Tasks"
        Me.CurrentTasks.UseVisualStyleBackColor = True
        '
        'CheckBox_ShowExecutedTasks
        '
        Me.CheckBox_ShowExecutedTasks.AutoSize = True
        Me.CheckBox_ShowExecutedTasks.Location = New System.Drawing.Point(717, 31)
        Me.CheckBox_ShowExecutedTasks.Name = "CheckBox_ShowExecutedTasks"
        Me.CheckBox_ShowExecutedTasks.Size = New System.Drawing.Size(136, 19)
        Me.CheckBox_ShowExecutedTasks.TabIndex = 4
        Me.CheckBox_ShowExecutedTasks.Text = "Show executed Tasks"
        Me.CheckBox_ShowExecutedTasks.UseVisualStyleBackColor = True
        '
        'CheckBox_ShowNotToday
        '
        Me.CheckBox_ShowNotToday.AutoSize = True
        Me.CheckBox_ShowNotToday.Location = New System.Drawing.Point(717, 6)
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
        Me.CreateNewTask.Size = New System.Drawing.Size(884, 453)
        Me.CreateNewTask.TabIndex = 1
        Me.CreateNewTask.Text = "Create new Task"
        Me.CreateNewTask.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button_CreateTask)
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
        Me.Panel1.Location = New System.Drawing.Point(448, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 441)
        Me.Panel1.TabIndex = 2
        '
        'Button_CreateTask
        '
        Me.Button_CreateTask.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button_CreateTask.Enabled = False
        Me.Button_CreateTask.Location = New System.Drawing.Point(10, 259)
        Me.Button_CreateTask.Name = "Button_CreateTask"
        Me.Button_CreateTask.Size = New System.Drawing.Size(94, 29)
        Me.Button_CreateTask.TabIndex = 19
        Me.Button_CreateTask.Text = "Create Task"
        Me.Button_CreateTask.UseVisualStyleBackColor = True
        '
        'CheckBox_Su
        '
        Me.CheckBox_Su.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_Su.AutoSize = True
        Me.CheckBox_Su.Location = New System.Drawing.Point(377, 221)
        Me.CheckBox_Su.Name = "CheckBox_Su"
        Me.CheckBox_Su.Size = New System.Drawing.Size(39, 19)
        Me.CheckBox_Su.TabIndex = 18
        Me.CheckBox_Su.Text = "Su"
        Me.CheckBox_Su.UseVisualStyleBackColor = True
        '
        'CheckBox_Sat
        '
        Me.CheckBox_Sat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_Sat.AutoSize = True
        Me.CheckBox_Sat.Location = New System.Drawing.Point(315, 221)
        Me.CheckBox_Sat.Name = "CheckBox_Sat"
        Me.CheckBox_Sat.Size = New System.Drawing.Size(42, 19)
        Me.CheckBox_Sat.TabIndex = 17
        Me.CheckBox_Sat.Text = "Sat"
        Me.CheckBox_Sat.UseVisualStyleBackColor = True
        '
        'CheckBox_Fr
        '
        Me.CheckBox_Fr.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_Fr.AutoSize = True
        Me.CheckBox_Fr.Location = New System.Drawing.Point(260, 221)
        Me.CheckBox_Fr.Name = "CheckBox_Fr"
        Me.CheckBox_Fr.Size = New System.Drawing.Size(36, 19)
        Me.CheckBox_Fr.TabIndex = 16
        Me.CheckBox_Fr.Text = "Fr"
        Me.CheckBox_Fr.UseVisualStyleBackColor = True
        '
        'CheckBox_Thu
        '
        Me.CheckBox_Thu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_Thu.AutoSize = True
        Me.CheckBox_Thu.Location = New System.Drawing.Point(195, 221)
        Me.CheckBox_Thu.Name = "CheckBox_Thu"
        Me.CheckBox_Thu.Size = New System.Drawing.Size(46, 19)
        Me.CheckBox_Thu.TabIndex = 15
        Me.CheckBox_Thu.Text = "Thu"
        Me.CheckBox_Thu.UseVisualStyleBackColor = True
        '
        'CheckBox_Wed
        '
        Me.CheckBox_Wed.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_Wed.AutoSize = True
        Me.CheckBox_Wed.Location = New System.Drawing.Point(129, 221)
        Me.CheckBox_Wed.Name = "CheckBox_Wed"
        Me.CheckBox_Wed.Size = New System.Drawing.Size(50, 19)
        Me.CheckBox_Wed.TabIndex = 14
        Me.CheckBox_Wed.Text = "Wed"
        Me.CheckBox_Wed.UseVisualStyleBackColor = True
        '
        'CheckBox_Tue
        '
        Me.CheckBox_Tue.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_Tue.AutoSize = True
        Me.CheckBox_Tue.Location = New System.Drawing.Point(69, 221)
        Me.CheckBox_Tue.Name = "CheckBox_Tue"
        Me.CheckBox_Tue.Size = New System.Drawing.Size(45, 19)
        Me.CheckBox_Tue.TabIndex = 13
        Me.CheckBox_Tue.Text = "Tue"
        Me.CheckBox_Tue.UseVisualStyleBackColor = True
        '
        'CheckBox_Mo
        '
        Me.CheckBox_Mo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox_Mo.AutoSize = True
        Me.CheckBox_Mo.Checked = True
        Me.CheckBox_Mo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Mo.Location = New System.Drawing.Point(10, 221)
        Me.CheckBox_Mo.Name = "CheckBox_Mo"
        Me.CheckBox_Mo.Size = New System.Drawing.Size(44, 19)
        Me.CheckBox_Mo.TabIndex = 12
        Me.CheckBox_Mo.Text = "Mo"
        Me.CheckBox_Mo.UseVisualStyleBackColor = True
        '
        'RadioButton_OnTheseDays
        '
        Me.RadioButton_OnTheseDays.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButton_OnTheseDays.AutoSize = True
        Me.RadioButton_OnTheseDays.Location = New System.Drawing.Point(10, 196)
        Me.RadioButton_OnTheseDays.Name = "RadioButton_OnTheseDays"
        Me.RadioButton_OnTheseDays.Size = New System.Drawing.Size(102, 19)
        Me.RadioButton_OnTheseDays.TabIndex = 11
        Me.RadioButton_OnTheseDays.Text = "On these days:"
        Me.RadioButton_OnTheseDays.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "h"
        '
        'TextBox_Tasktime
        '
        Me.TextBox_Tasktime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox_Tasktime.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox_Tasktime.Location = New System.Drawing.Point(35, 110)
        Me.TextBox_Tasktime.MaxLength = 5
        Me.TextBox_Tasktime.Name = "TextBox_Tasktime"
        Me.TextBox_Tasktime.PlaceholderText = "00:00"
        Me.TextBox_Tasktime.ReadOnly = True
        Me.TextBox_Tasktime.Size = New System.Drawing.Size(39, 23)
        Me.TextBox_Tasktime.TabIndex = 9
        Me.TextBox_Tasktime.Text = "00:00"
        Me.TextBox_Tasktime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "At"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Task is due:"
        '
        'TextBox_Taskdescription
        '
        Me.TextBox_Taskdescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Taskdescription.Location = New System.Drawing.Point(115, 30)
        Me.TextBox_Taskdescription.MaxLength = 50
        Me.TextBox_Taskdescription.Name = "TextBox_Taskdescription"
        Me.TextBox_Taskdescription.Size = New System.Drawing.Size(301, 23)
        Me.TextBox_Taskdescription.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Task description:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Create a task:"
        '
        'RadioButton_EveryDay
        '
        Me.RadioButton_EveryDay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RadioButton_EveryDay.AutoSize = True
        Me.RadioButton_EveryDay.Checked = True
        Me.RadioButton_EveryDay.Location = New System.Drawing.Point(10, 158)
        Me.RadioButton_EveryDay.Name = "RadioButton_EveryDay"
        Me.RadioButton_EveryDay.Size = New System.Drawing.Size(75, 19)
        Me.RadioButton_EveryDay.TabIndex = 3
        Me.RadioButton_EveryDay.TabStop = True
        Me.RadioButton_EveryDay.Text = "Every day"
        Me.RadioButton_EveryDay.UseVisualStyleBackColor = True
        '
        'ListView_AllTasks
        '
        Me.ListView_AllTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_AllTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Column_LVNT_Task, Me.Column_LVNT_NextDue})
        Me.ListView_AllTasks.ContextMenuStrip = Me.ContextMenuStrip_LVAT
        Me.ListView_AllTasks.HideSelection = False
        Me.ListView_AllTasks.Location = New System.Drawing.Point(6, 6)
        Me.ListView_AllTasks.Name = "ListView_AllTasks"
        Me.ListView_AllTasks.Size = New System.Drawing.Size(436, 441)
        Me.ListView_AllTasks.TabIndex = 1
        Me.ListView_AllTasks.UseCompatibleStateImageBehavior = False
        Me.ListView_AllTasks.View = System.Windows.Forms.View.Details
        '
        'Column_LVNT_Task
        '
        Me.Column_LVNT_Task.Text = "Task"
        Me.Column_LVNT_Task.Width = 300
        '
        'Column_LVNT_NextDue
        '
        Me.Column_LVNT_NextDue.Text = "Next due"
        Me.Column_LVNT_NextDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Column_LVNT_NextDue.Width = 130
        '
        'ContextMenuStrip_LVAT
        '
        Me.ContextMenuStrip_LVAT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditTaskToolStripMenuItem1, Me.DeleteTaskToolStripMenuItem1})
        Me.ContextMenuStrip_LVAT.Name = "ContextMenuStrip_LVAT"
        Me.ContextMenuStrip_LVAT.Size = New System.Drawing.Size(132, 48)
        '
        'EditTaskToolStripMenuItem1
        '
        Me.EditTaskToolStripMenuItem1.Name = "EditTaskToolStripMenuItem1"
        Me.EditTaskToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.EditTaskToolStripMenuItem1.Text = "Edit task"
        '
        'DeleteTaskToolStripMenuItem1
        '
        Me.DeleteTaskToolStripMenuItem1.Name = "DeleteTaskToolStripMenuItem1"
        Me.DeleteTaskToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.DeleteTaskToolStripMenuItem1.Text = "Delete task"
        '
        'PastTasks
        '
        Me.PastTasks.Controls.Add(Me.ListView_PastTasks)
        Me.PastTasks.Location = New System.Drawing.Point(4, 24)
        Me.PastTasks.Name = "PastTasks"
        Me.PastTasks.Padding = New System.Windows.Forms.Padding(3)
        Me.PastTasks.Size = New System.Drawing.Size(884, 453)
        Me.PastTasks.TabIndex = 2
        Me.PastTasks.Text = "Past Tasks"
        Me.PastTasks.UseVisualStyleBackColor = True
        '
        'ListView_PastTasks
        '
        Me.ListView_PastTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_PastTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView_PastTasks.ContextMenuStrip = Me.ContextMenuStrip_LVPT
        Me.ListView_PastTasks.HideSelection = False
        Me.ListView_PastTasks.Location = New System.Drawing.Point(6, 6)
        Me.ListView_PastTasks.Name = "ListView_PastTasks"
        Me.ListView_PastTasks.Size = New System.Drawing.Size(872, 441)
        Me.ListView_PastTasks.TabIndex = 2
        Me.ListView_PastTasks.UseCompatibleStateImageBehavior = False
        Me.ListView_PastTasks.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Task"
        Me.ColumnHeader1.Width = 400
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Original due"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Executed at"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Done"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 100
        '
        'ContextMenuStrip_LVPT
        '
        Me.ContextMenuStrip_LVPT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DeleteTaskToolStripMenuItem2})
        Me.ContextMenuStrip_LVPT.Name = "ContextMenuStrip_LVPT"
        Me.ContextMenuStrip_LVPT.Size = New System.Drawing.Size(132, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem1.Text = "Mark task"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem2.Text = "Mark as '🗸'"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem3.Text = "Mark as 'x'"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem4.Text = "Mark as '?'"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem5.Text = "Mark as 'o'"
        '
        'DeleteTaskToolStripMenuItem2
        '
        Me.DeleteTaskToolStripMenuItem2.Name = "DeleteTaskToolStripMenuItem2"
        Me.DeleteTaskToolStripMenuItem2.Size = New System.Drawing.Size(131, 22)
        Me.DeleteTaskToolStripMenuItem2.Text = "Delete task"
        '
        'Timer_CheckTasks
        '
        Me.Timer_CheckTasks.Enabled = True
        Me.Timer_CheckTasks.Interval = 2000
        '
        'AppIcon
        '
        Me.AppIcon.ContextMenuStrip = Me.ContextMenuStrip_Icon
        Me.AppIcon.Icon = CType(resources.GetObject("AppIcon.Icon"), System.Drawing.Icon)
        Me.AppIcon.Text = "DailyTask"
        Me.AppIcon.Visible = True
        '
        'ContextMenuStrip_Icon
        '
        Me.ContextMenuStrip_Icon.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.ContextMenuStrip_Icon.Name = "ContextMenuStrip_Icon"
        Me.ContextMenuStrip_Icon.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'Label_MajorError
        '
        Me.Label_MajorError.AutoSize = True
        Me.Label_MajorError.Location = New System.Drawing.Point(12, 490)
        Me.Label_MajorError.Name = "Label_MajorError"
        Me.Label_MajorError.Size = New System.Drawing.Size(0, 15)
        Me.Label_MajorError.TabIndex = 2
        Me.Label_MajorError.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 505)
        Me.Controls.Add(Me.Label_MajorError)
        Me.Controls.Add(Me.TabControl_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(932, 544)
        Me.MinimumSize = New System.Drawing.Size(932, 544)
        Me.Name = "MainForm"
        Me.Text = "DailyTask"
        Me.ContextMenuStrip_LVCT.ResumeLayout(False)
        Me.TabControl_Main.ResumeLayout(False)
        Me.CurrentTasks.ResumeLayout(False)
        Me.CurrentTasks.PerformLayout()
        Me.CreateNewTask.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip_LVAT.ResumeLayout(False)
        Me.PastTasks.ResumeLayout(False)
        Me.ContextMenuStrip_LVPT.ResumeLayout(False)
        Me.ContextMenuStrip_Icon.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Column_LVCT_Task As ColumnHeader
    Friend WithEvents Column_LVCT_NextDue As ColumnHeader
    Friend WithEvents Column_LVNT_Task As ColumnHeader
    Friend WithEvents Column_LVNT_NextDue As ColumnHeader
    Friend WithEvents Button_CreateTask As Button
    Friend WithEvents Timer_CheckTasks As Timer
    Friend WithEvents Column_LVCT_Done As ColumnHeader
    Friend WithEvents ContextMenuStrip_LVCT As ContextMenuStrip
    Friend WithEvents MarkTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAsDoneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAsXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAsQMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteTaskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkAsUnfulfilledToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PastTasks As TabPage
    Friend WithEvents ListView_PastTasks As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents AppIcon As NotifyIcon
    Friend WithEvents ContextMenuStrip_Icon As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_LVAT As ContextMenuStrip
    Friend WithEvents EditTaskToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteTaskToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip_LVPT As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents DeleteTaskToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label_MajorError As Label
    Friend WithEvents CheckBox_ShowExecutedTasks As CheckBox
End Class
