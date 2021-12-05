<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.CreateNewTask = New System.Windows.Forms.TabPage()
        Me.CheckBox_ShowNotToday = New System.Windows.Forms.CheckBox()
        Me.TabControl_Main.SuspendLayout()
        Me.CurrentTasks.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView_CurrentTasks
        '
        Me.ListView_CurrentTasks.HideSelection = False
        Me.ListView_CurrentTasks.Location = New System.Drawing.Point(6, 6)
        Me.ListView_CurrentTasks.Name = "ListView_CurrentTasks"
        Me.ListView_CurrentTasks.Size = New System.Drawing.Size(450, 400)
        Me.ListView_CurrentTasks.TabIndex = 0
        Me.ListView_CurrentTasks.UseCompatibleStateImageBehavior = False
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
        'CreateNewTask
        '
        Me.CreateNewTask.Location = New System.Drawing.Point(4, 24)
        Me.CreateNewTask.Name = "CreateNewTask"
        Me.CreateNewTask.Padding = New System.Windows.Forms.Padding(3)
        Me.CreateNewTask.Size = New System.Drawing.Size(835, 412)
        Me.CreateNewTask.TabIndex = 1
        Me.CreateNewTask.Text = "Create new Task"
        Me.CreateNewTask.UseVisualStyleBackColor = True
        '
        'CheckBox_ShowNotToday
        '
        Me.CheckBox_ShowNotToday.AutoSize = True
        Me.CheckBox_ShowNotToday.Location = New System.Drawing.Point(462, 6)
        Me.CheckBox_ShowNotToday.Name = "CheckBox_ShowNotToday"
        Me.CheckBox_ShowNotToday.Size = New System.Drawing.Size(161, 19)
        Me.CheckBox_ShowNotToday.TabIndex = 1
        Me.CheckBox_ShowNotToday.Text = "Show tasks not due today"
        Me.CheckBox_ShowNotToday.UseVisualStyleBackColor = True
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView_CurrentTasks As ListView
    Friend WithEvents TabControl_Main As TabControl
    Friend WithEvents CurrentTasks As TabPage
    Friend WithEvents CheckBox_ShowNotToday As CheckBox
    Friend WithEvents CreateNewTask As TabPage
End Class
