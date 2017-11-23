<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lstCost = New System.Windows.Forms.ListBox()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radClassroom = New System.Windows.Forms.RadioButton()
        Me.radOnline = New System.Windows.Forms.RadioButton()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lstCourse = New System.Windows.Forms.ListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpLocation.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCost
        '
        Me.lstCost.FormattingEnabled = True
        Me.lstCost.ItemHeight = 16
        Me.lstCost.Location = New System.Drawing.Point(332, 49)
        Me.lstCost.Name = "lstCost"
        Me.lstCost.Size = New System.Drawing.Size(169, 132)
        Me.lstCost.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.lstCost, "Area for selected course costs")
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(12, 350)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(75, 63)
        Me.btnAddCourse.TabIndex = 1
        Me.btnAddCourse.Text = "Add A Course"
        Me.ToolTip1.SetToolTip(Me.btnAddCourse, "Click to add a course")
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(176, 350)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 63)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Total Due"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click to calculate total due")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(316, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 63)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear Form"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click to clear form")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(470, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 63)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radClassroom
        '
        Me.radClassroom.AutoSize = True
        Me.radClassroom.Location = New System.Drawing.Point(18, 30)
        Me.radClassroom.Name = "radClassroom"
        Me.radClassroom.Size = New System.Drawing.Size(95, 21)
        Me.radClassroom.TabIndex = 5
        Me.radClassroom.TabStop = True
        Me.radClassroom.Text = "Classroom"
        Me.ToolTip1.SetToolTip(Me.radClassroom, "Click to select classroom")
        Me.radClassroom.UseVisualStyleBackColor = True
        '
        'radOnline
        '
        Me.radOnline.AutoSize = True
        Me.radOnline.Location = New System.Drawing.Point(18, 57)
        Me.radOnline.Name = "radOnline"
        Me.radOnline.Size = New System.Drawing.Size(70, 21)
        Me.radOnline.TabIndex = 6
        Me.radOnline.TabStop = True
        Me.radOnline.Text = "Online"
        Me.ToolTip1.SetToolTip(Me.radOnline, "click to select online")
        Me.radOnline.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(384, 217)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(70, 17)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "Total Due"
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(50, 19)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(95, 17)
        Me.lblCourse.TabIndex = 9
        Me.lblCourse.Text = "Pick a Course"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.radClassroom)
        Me.grpLocation.Controls.Add(Me.radOnline)
        Me.grpLocation.Location = New System.Drawing.Point(12, 217)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(200, 100)
        Me.grpLocation.TabIndex = 10
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Choose a Location"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(329, 19)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(172, 17)
        Me.lblCost.TabIndex = 11
        Me.lblCost.Text = "Cost for Selected Courses"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDue.Location = New System.Drawing.Point(332, 247)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(169, 36)
        Me.lblTotalDue.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.lblTotalDue, "Area to display total due")
        '
        'lstCourse
        '
        Me.lstCourse.FormattingEnabled = True
        Me.lstCourse.ItemHeight = 16
        Me.lstCourse.Items.AddRange(New Object() {"Microsoft Word", "Microsoft Excel", "Microsoft Access", "Microsoft PowerPoint", "App Inventor", "Programming Made Simple"})
        Me.lstCourse.Location = New System.Drawing.Point(12, 49)
        Me.lstCourse.Name = "lstCourse"
        Me.lstCourse.Size = New System.Drawing.Size(194, 132)
        Me.lstCourse.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.lstCourse, "Please select a course")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 425)
        Me.Controls.Add(Me.lstCourse)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.grpLocation)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.lstCost)
        Me.Name = "Form1"
        Me.Text = "Community Education Class Registration"
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCost As ListBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents radClassroom As RadioButton
    Friend WithEvents radOnline As RadioButton
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lstCourse As ListBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
