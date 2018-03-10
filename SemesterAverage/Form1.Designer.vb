<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSemesterAverages
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
        Me.lblCourseOne = New System.Windows.Forms.Label()
        Me.CalculatingGradeAverageTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCourseTwo = New System.Windows.Forms.Label()
        Me.lblCourseThree = New System.Windows.Forms.Label()
        Me.lblCourseFive = New System.Windows.Forms.Label()
        Me.lblCourseFour = New System.Windows.Forms.Label()
        Me.lblSemesterAverage = New System.Windows.Forms.Label()
        Me.lblCourseSix = New System.Windows.Forms.Label()
        Me.txtGradeOne = New System.Windows.Forms.TextBox()
        Me.txtGradeSix = New System.Windows.Forms.TextBox()
        Me.txtGradeFive = New System.Windows.Forms.TextBox()
        Me.txtGradeFour = New System.Windows.Forms.TextBox()
        Me.txtGradeThree = New System.Windows.Forms.TextBox()
        Me.txtGradeTwo = New System.Windows.Forms.TextBox()
        Me.lblSemesterAverageDisplay = New System.Windows.Forms.Label()
        Me.lblLetterGrade3 = New System.Windows.Forms.Label()
        Me.lblAverageLetterGrade = New System.Windows.Forms.Label()
        Me.lblLetterGrade6 = New System.Windows.Forms.Label()
        Me.lblLetterGrade5 = New System.Windows.Forms.Label()
        Me.lblLetterGrade4 = New System.Windows.Forms.Label()
        Me.lblLetterGrade2 = New System.Windows.Forms.Label()
        Me.lblLetterGrade1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblErrorDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourseOne
        '
        Me.lblCourseOne.Location = New System.Drawing.Point(39, 24)
        Me.lblCourseOne.Name = "lblCourseOne"
        Me.lblCourseOne.Size = New System.Drawing.Size(56, 19)
        Me.lblCourseOne.TabIndex = 0
        Me.lblCourseOne.Text = "Course 1:"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblCourseOne, "Grade for course one")
        '
        'CalculatingGradeAverageTips
        '
        Me.CalculatingGradeAverageTips.ToolTipTitle = "Semester Average Tips"
        '
        'lblCourseTwo
        '
        Me.lblCourseTwo.Location = New System.Drawing.Point(39, 54)
        Me.lblCourseTwo.Name = "lblCourseTwo"
        Me.lblCourseTwo.Size = New System.Drawing.Size(56, 19)
        Me.lblCourseTwo.TabIndex = 3
        Me.lblCourseTwo.Text = "Course 2:"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblCourseTwo, "Grade for course two")
        '
        'lblCourseThree
        '
        Me.lblCourseThree.Location = New System.Drawing.Point(39, 82)
        Me.lblCourseThree.Name = "lblCourseThree"
        Me.lblCourseThree.Size = New System.Drawing.Size(56, 19)
        Me.lblCourseThree.TabIndex = 6
        Me.lblCourseThree.Text = "Course 3:"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblCourseThree, "Grade for course three")
        '
        'lblCourseFive
        '
        Me.lblCourseFive.Location = New System.Drawing.Point(39, 141)
        Me.lblCourseFive.Name = "lblCourseFive"
        Me.lblCourseFive.Size = New System.Drawing.Size(56, 19)
        Me.lblCourseFive.TabIndex = 12
        Me.lblCourseFive.Text = "Course 5:"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblCourseFive, "Grade for course five")
        '
        'lblCourseFour
        '
        Me.lblCourseFour.Location = New System.Drawing.Point(39, 112)
        Me.lblCourseFour.Name = "lblCourseFour"
        Me.lblCourseFour.Size = New System.Drawing.Size(56, 19)
        Me.lblCourseFour.TabIndex = 9
        Me.lblCourseFour.Text = "Course 4:"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblCourseFour, "Grade for course four")
        '
        'lblSemesterAverage
        '
        Me.lblSemesterAverage.Location = New System.Drawing.Point(39, 205)
        Me.lblSemesterAverage.Name = "lblSemesterAverage"
        Me.lblSemesterAverage.Size = New System.Drawing.Size(56, 19)
        Me.lblSemesterAverage.TabIndex = 18
        Me.lblSemesterAverage.Text = "Semester:"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblSemesterAverage, "The average grade for the semester")
        '
        'lblCourseSix
        '
        Me.lblCourseSix.Location = New System.Drawing.Point(39, 170)
        Me.lblCourseSix.Name = "lblCourseSix"
        Me.lblCourseSix.Size = New System.Drawing.Size(56, 19)
        Me.lblCourseSix.TabIndex = 15
        Me.lblCourseSix.Text = "Course 6:"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblCourseSix, "Grade for course six")
        '
        'txtGradeOne
        '
        Me.txtGradeOne.Location = New System.Drawing.Point(101, 21)
        Me.txtGradeOne.Name = "txtGradeOne"
        Me.txtGradeOne.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeOne.TabIndex = 1
        Me.txtGradeOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CalculatingGradeAverageTips.SetToolTip(Me.txtGradeOne, "Input the grade for the first course")
        '
        'txtGradeSix
        '
        Me.txtGradeSix.Location = New System.Drawing.Point(101, 170)
        Me.txtGradeSix.Name = "txtGradeSix"
        Me.txtGradeSix.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeSix.TabIndex = 16
        Me.txtGradeSix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CalculatingGradeAverageTips.SetToolTip(Me.txtGradeSix, "Input the grade for the sixth course")
        '
        'txtGradeFive
        '
        Me.txtGradeFive.Location = New System.Drawing.Point(101, 138)
        Me.txtGradeFive.Name = "txtGradeFive"
        Me.txtGradeFive.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeFive.TabIndex = 13
        Me.txtGradeFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CalculatingGradeAverageTips.SetToolTip(Me.txtGradeFive, "Input the grade for the fifth course")
        '
        'txtGradeFour
        '
        Me.txtGradeFour.Location = New System.Drawing.Point(101, 111)
        Me.txtGradeFour.Name = "txtGradeFour"
        Me.txtGradeFour.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeFour.TabIndex = 10
        Me.txtGradeFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CalculatingGradeAverageTips.SetToolTip(Me.txtGradeFour, "Input the grade for the fourth course")
        '
        'txtGradeThree
        '
        Me.txtGradeThree.Location = New System.Drawing.Point(101, 82)
        Me.txtGradeThree.Name = "txtGradeThree"
        Me.txtGradeThree.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeThree.TabIndex = 7
        Me.txtGradeThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CalculatingGradeAverageTips.SetToolTip(Me.txtGradeThree, "Input the grade for the third course")
        '
        'txtGradeTwo
        '
        Me.txtGradeTwo.Location = New System.Drawing.Point(101, 54)
        Me.txtGradeTwo.Name = "txtGradeTwo"
        Me.txtGradeTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeTwo.TabIndex = 4
        Me.txtGradeTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CalculatingGradeAverageTips.SetToolTip(Me.txtGradeTwo, "Input the grade for the second course")
        '
        'lblSemesterAverageDisplay
        '
        Me.lblSemesterAverageDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSemesterAverageDisplay.Location = New System.Drawing.Point(102, 201)
        Me.lblSemesterAverageDisplay.Name = "lblSemesterAverageDisplay"
        Me.lblSemesterAverageDisplay.Size = New System.Drawing.Size(99, 21)
        Me.lblSemesterAverageDisplay.TabIndex = 19
        Me.lblSemesterAverageDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblSemesterAverageDisplay, "Displays the average grade for the semester")
        '
        'lblLetterGrade3
        '
        Me.lblLetterGrade3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade3.Location = New System.Drawing.Point(207, 82)
        Me.lblLetterGrade3.Name = "lblLetterGrade3"
        Me.lblLetterGrade3.Size = New System.Drawing.Size(99, 21)
        Me.lblLetterGrade3.TabIndex = 8
        Me.lblLetterGrade3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblLetterGrade3, "Displays the letter grade for course three")
        '
        'lblAverageLetterGrade
        '
        Me.lblAverageLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageLetterGrade.Location = New System.Drawing.Point(207, 201)
        Me.lblAverageLetterGrade.Name = "lblAverageLetterGrade"
        Me.lblAverageLetterGrade.Size = New System.Drawing.Size(99, 21)
        Me.lblAverageLetterGrade.TabIndex = 20
        Me.lblAverageLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblAverageLetterGrade, "Displays the average mark for the semester")
        '
        'lblLetterGrade6
        '
        Me.lblLetterGrade6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade6.Location = New System.Drawing.Point(207, 170)
        Me.lblLetterGrade6.Name = "lblLetterGrade6"
        Me.lblLetterGrade6.Size = New System.Drawing.Size(99, 21)
        Me.lblLetterGrade6.TabIndex = 17
        Me.lblLetterGrade6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblLetterGrade6, "Displays the letter grade for course six")
        '
        'lblLetterGrade5
        '
        Me.lblLetterGrade5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade5.Location = New System.Drawing.Point(207, 138)
        Me.lblLetterGrade5.Name = "lblLetterGrade5"
        Me.lblLetterGrade5.Size = New System.Drawing.Size(99, 21)
        Me.lblLetterGrade5.TabIndex = 14
        Me.lblLetterGrade5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblLetterGrade5, "Displays the letter grade for course five")
        '
        'lblLetterGrade4
        '
        Me.lblLetterGrade4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade4.Location = New System.Drawing.Point(207, 111)
        Me.lblLetterGrade4.Name = "lblLetterGrade4"
        Me.lblLetterGrade4.Size = New System.Drawing.Size(99, 21)
        Me.lblLetterGrade4.TabIndex = 11
        Me.lblLetterGrade4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblLetterGrade4, "Displays the letter grade for course four")
        '
        'lblLetterGrade2
        '
        Me.lblLetterGrade2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade2.Location = New System.Drawing.Point(207, 52)
        Me.lblLetterGrade2.Name = "lblLetterGrade2"
        Me.lblLetterGrade2.Size = New System.Drawing.Size(99, 21)
        Me.lblLetterGrade2.TabIndex = 5
        Me.lblLetterGrade2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblLetterGrade2, "Displays the letter grade for course two")
        '
        'lblLetterGrade1
        '
        Me.lblLetterGrade1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterGrade1.Location = New System.Drawing.Point(207, 21)
        Me.lblLetterGrade1.Name = "lblLetterGrade1"
        Me.lblLetterGrade1.Size = New System.Drawing.Size(99, 21)
        Me.lblLetterGrade1.TabIndex = 2
        Me.lblLetterGrade1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblLetterGrade1, "Displays the letter grade for course one")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(79, 422)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 22
        Me.btnCalculate.Text = "&Calculate"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.btnCalculate, "Click to calculate the semester average")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(160, 422)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 23
        Me.btnReset.Text = "&Reset"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.btnReset, "Click to reset and clear the application")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 422)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "&Exit"
        Me.CalculatingGradeAverageTips.SetToolTip(Me.btnExit, "Click to exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblErrorDisplay
        '
        Me.lblErrorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorDisplay.Location = New System.Drawing.Point(12, 234)
        Me.lblErrorDisplay.Name = "lblErrorDisplay"
        Me.lblErrorDisplay.Size = New System.Drawing.Size(294, 185)
        Me.lblErrorDisplay.TabIndex = 21
        Me.CalculatingGradeAverageTips.SetToolTip(Me.lblErrorDisplay, "Displays error messages")
        '
        'frmSemesterAverages
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(318, 457)
        Me.Controls.Add(Me.lblErrorDisplay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblLetterGrade1)
        Me.Controls.Add(Me.lblLetterGrade2)
        Me.Controls.Add(Me.lblLetterGrade4)
        Me.Controls.Add(Me.lblLetterGrade5)
        Me.Controls.Add(Me.lblLetterGrade6)
        Me.Controls.Add(Me.lblAverageLetterGrade)
        Me.Controls.Add(Me.lblLetterGrade3)
        Me.Controls.Add(Me.lblSemesterAverageDisplay)
        Me.Controls.Add(Me.txtGradeTwo)
        Me.Controls.Add(Me.txtGradeThree)
        Me.Controls.Add(Me.txtGradeFour)
        Me.Controls.Add(Me.txtGradeFive)
        Me.Controls.Add(Me.txtGradeSix)
        Me.Controls.Add(Me.txtGradeOne)
        Me.Controls.Add(Me.lblCourseSix)
        Me.Controls.Add(Me.lblSemesterAverage)
        Me.Controls.Add(Me.lblCourseFour)
        Me.Controls.Add(Me.lblCourseFive)
        Me.Controls.Add(Me.lblCourseThree)
        Me.Controls.Add(Me.lblCourseTwo)
        Me.Controls.Add(Me.lblCourseOne)
        Me.Name = "frmSemesterAverages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.CalculatingGradeAverageTips.SetToolTip(Me, "This application will calculate the semester average and what letter grade the st" &
        "udent achieved")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourseOne As Label
    Friend WithEvents CalculatingGradeAverageTips As ToolTip
    Friend WithEvents lblCourseTwo As Label
    Friend WithEvents lblCourseThree As Label
    Friend WithEvents lblCourseFive As Label
    Friend WithEvents lblCourseFour As Label
    Friend WithEvents lblSemesterAverage As Label
    Friend WithEvents lblCourseSix As Label
    Friend WithEvents txtGradeOne As TextBox
    Friend WithEvents txtGradeSix As TextBox
    Friend WithEvents txtGradeFive As TextBox
    Friend WithEvents txtGradeFour As TextBox
    Friend WithEvents txtGradeThree As TextBox
    Friend WithEvents txtGradeTwo As TextBox
    Friend WithEvents lblSemesterAverageDisplay As Label
    Friend WithEvents lblLetterGrade3 As Label
    Friend WithEvents lblAverageLetterGrade As Label
    Friend WithEvents lblLetterGrade6 As Label
    Friend WithEvents lblLetterGrade5 As Label
    Friend WithEvents lblLetterGrade4 As Label
    Friend WithEvents lblLetterGrade2 As Label
    Friend WithEvents lblLetterGrade1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblErrorDisplay As Label
End Class
