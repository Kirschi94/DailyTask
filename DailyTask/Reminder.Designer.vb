<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reminder
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reminder))
        Me.Label_TaskText = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_TaskText
        '
        Me.Label_TaskText.AutoSize = True
        Me.Label_TaskText.Location = New System.Drawing.Point(12, 9)
        Me.Label_TaskText.Name = "Label_TaskText"
        Me.Label_TaskText.Size = New System.Drawing.Size(53, 15)
        Me.Label_TaskText.TabIndex = 0
        Me.Label_TaskText.Text = "Task Text"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Save as done"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Save as not executed"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(236, 36)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 43)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Postpone alert by 5 minutes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Reminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 91)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label_TaskText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reminder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_TaskText As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
