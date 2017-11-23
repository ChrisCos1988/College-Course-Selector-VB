Public Class Form1

    'Course Constants
    Const decWord As Decimal = 150.0
    Const decExcel As Decimal = 200.0
    Const decAccess As Decimal = 200.0
    Const decPowerPoint As Decimal = 100.0
    Const decAppInv As Decimal = 250.0
    Const decProg As Decimal = 225.0

    'Learning Fee Constants
    Const intOnline As Integer = 10
    Const intClassroom As Integer = 5

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        'Holds variables for course

        If lstCourse.SelectedIndex = 0 And radClassroom.Checked Then
            lstCost.Items.Add("$" & decWord + intClassroom & ".00")
        ElseIf lstCourse.SelectedIndex = 0 And radOnline.Checked Then
            lstCost.Items.Add("$" & decWord + intOnline & ".00")
        ElseIf lstCourse.SelectedIndex = 1 And radClassroom.Checked Then
            lstCost.Items.Add("$" & decExcel + intClassroom & ".00")
        ElseIf lstCourse.SelectedIndex = 1 And radOnline.Checked Then
            lstCost.Items.Add("$" & decExcel + intOnline & ".00")
        ElseIf lstCourse.SelectedIndex = 2 And radClassroom.Checked Then
            lstCost.Items.Add("$" & decAccess + intClassroom & ".00")
        ElseIf lstCourse.SelectedIndex = 2 And radOnline.Checked Then
            lstCost.Items.Add("$" & decAccess + intOnline & ".00")
        ElseIf lstCourse.SelectedIndex = 3 And radClassroom.Checked Then
            lstCost.Items.Add("$" & decPowerPoint + intClassroom & ".00")
        ElseIf lstCourse.SelectedIndex = 3 And radOnline.Checked Then
            lstCost.Items.Add("$" & decPowerPoint + intOnline & ".00")
        ElseIf lstCourse.SelectedIndex = 4 And radClassroom.Checked Then
            lstCost.Items.Add("$" & decAppInv + intClassroom & ".00")
        ElseIf lstCourse.SelectedIndex = 4 And radOnline.Checked Then
            lstCost.Items.Add("$" & decAppInv + intOnline & ".00")
        ElseIf lstCourse.SelectedIndex = 5 And radClassroom.Checked Then
            lstCost.Items.Add("$" & decProg + intClassroom & ".00")
        ElseIf lstCourse.SelectedIndex = 5 And radOnline.Checked Then
            lstCost.Items.Add("$" & decProg + intOnline & ".00")
        End If


        If lstCost.SelectedIndex = -1 Then
            MessageBox.Show("You must select a course from the menu")
        End If

        If radClassroom.Checked = False And radOnline.Checked = False Then
            MessageBox.Show("You must select a location for the course")
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotalDue As Decimal

        For Each dec As Decimal In lstCost.Items
            decTotalDue = decTotalDue + CInt(dec)
        Next

        lblTotalDue.Text = decTotalDue.ToString("c")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstCourse.SelectedIndex = -1
        lstCost.Items.Clear()
        radClassroom.Checked = False
        radOnline.Checked = False
        lblTotalDue.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
