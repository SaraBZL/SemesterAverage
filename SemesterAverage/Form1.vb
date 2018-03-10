Public Class frmSemesterAverages
    ''' <summary>
    ''' Author: Sara Bhatti
    ''' Project: Semester Average
    ''' Date: February 23, 2018
    ''' Description: The purpose of this windows application is
    ''' to calculate a students average mark and letter grade for the semester.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblLetterGrade3.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
        ' closes the application
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        txtGradeOne.Text = ""
        txtGradeTwo.Text = ""
        txtGradeThree.Text = ""
        txtGradeFour.Text = ""
        txtGradeFive.Text = ""
        txtGradeSix.Text = ""
        lblSemesterAverageDisplay.Text = ""
        lblLetterGrade1.Text = ""
        lblLetterGrade2.Text = ""
        lblLetterGrade3.Text = ""
        lblLetterGrade4.Text = ""
        lblLetterGrade5.Text = ""
        lblLetterGrade6.Text = ""
        lblAverageLetterGrade.Text = ""
        lblErrorDisplay.Text = ""

        ' when the user clicks reset, these will clear and 
        'reset all textboxes and labels

        txtGradeOne.Select()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click



        Dim userInput As Integer

        Dim output As String = String.Empty



        If Not IsNumeric(txtGradeOne.Text) Then

            lblErrorDisplay.Text = "Please enter a numeric value."

            txtGradeOne.Select()
            txtGradeOne.SelectionStart = 0
            txtGradeOne.SelectionLength = Len(txtGradeOne.Text)



        ElseIf Not Integer.TryParse(txtGradeOne.Text, userInput) Then

            lblErrorDisplay.Text = "Please enter a whole number only."

            txtGradeOne.Select()
            txtGradeOne.SelectionStart = 0
            txtGradeOne.SelectionLength = Len(txtGradeOne.Text)

        ElseIf CInt(txtGradeOne.Text) >= 0 And CInt(txtGradeOne.Text) <= 49 Then
            lblLetterGrade1.Text = "F"

        ElseIf CInt(txtGradeOne.Text) >= 50 And CInt(txtGradeOne.Text) <= 52 Then
            lblLetterGrade1.Text = "D-"

        ElseIf CInt(txtGradeOne.Text) >= 53 And CInt(txtGradeOne.Text) <= 56 Then
            lblLetterGrade1.Text = "D"

        ElseIf CInt(txtGradeOne.Text) >= 57 And CInt(txtGradeOne.Text) <= 59 Then
            lblLetterGrade1.Text = "D+"

        ElseIf CInt(txtGradeOne.Text) >= 60 And CInt(txtGradeOne.Text) <= 62 Then
            lblLetterGrade1.Text = "C-"

        ElseIf CInt(txtGradeOne.Text) >= 63 And CInt(txtGradeOne.Text) <= 66 Then
            lblLetterGrade1.Text = "C"

        ElseIf CInt(txtGradeOne.Text) >= 67 And CInt(txtGradeOne.Text) <= 69 Then
            lblLetterGrade1.Text = "C+"

        ElseIf CInt(txtGradeOne.Text) >= 70 And CInt(txtGradeOne.Text) <= 72 Then
            lblLetterGrade1.Text = "B-"

        ElseIf CInt(txtGradeOne.Text) >= 73 And CInt(txtGradeOne.Text) <= 76 Then
            lblLetterGrade1.Text = "B"

        ElseIf CInt(txtGradeOne.Text) >= 77 And CInt(txtGradeOne.Text) <= 79 Then
            lblLetterGrade1.Text = "B+"

        ElseIf CInt(txtGradeOne.Text) >= 80 And CInt(txtGradeOne.Text) <= 84 Then
            lblLetterGrade1.Text = "A-"

        ElseIf CInt(txtGradeOne.Text) >= 85 And CInt(txtGradeOne.Text) <= 89 Then
            lblLetterGrade1.Text = "A"

        ElseIf CInt(txtGradeOne.Text) >= 90 And CInt(txtGradeOne.Text) <= 100 Then
            lblLetterGrade1.Text = "A+"

            ' GRADE 1 ENDS
        End If

        If Not IsNumeric(txtGradeSix.Text) Then

            lblErrorDisplay.Text = "Please enter a numeric value."

            txtGradeSix.Select()
            txtGradeSix.SelectionStart = 0
            txtGradeSix.SelectionLength = Len(txtGradeSix.Text)

        ElseIf Not Integer.TryParse(txtGradeSix.Text, userInput) Then

            lblErrorDisplay.Text = "Please enter a whole number only."

            txtGradeSix.Select()
            txtGradeSix.SelectionStart = 0
            txtGradeSix.SelectionLength = Len(txtGradeSix.Text)


        ElseIf CInt(txtGradeSix.Text) >= 0 And CInt(txtGradeSix.Text) <= 49 Then
            lblLetterGrade6.Text = "F"

        ElseIf CInt(txtGradeSix.Text) >= 50 And CInt(txtGradeSix.Text) <= 52 Then
            lblLetterGrade6.Text = "D-"

        ElseIf CInt(txtGradeSix.Text) >= 53 And CInt(txtGradeSix.Text) <= 56 Then
            lblLetterGrade6.Text = "D"

        ElseIf CInt(txtGradeSix.Text) >= 57 And CInt(txtGradeSix.Text) <= 59 Then
            lblLetterGrade6.Text = "D+"

        ElseIf CInt(txtGradeSix.Text) >= 60 And CInt(txtGradeSix.Text) <= 62 Then
            lblLetterGrade6.Text = "C-"

        ElseIf CInt(txtGradeSix.Text) >= 63 And CInt(txtGradeSix.Text) <= 66 Then
            lblLetterGrade6.Text = "C"

        ElseIf CInt(txtGradeSix.Text) >= 67 And CInt(txtGradeSix.Text) <= 69 Then
            lblLetterGrade6.Text = "C+"

        ElseIf CInt(txtGradeSix.Text) >= 70 And CInt(txtGradeSix.Text) <= 72 Then
            lblLetterGrade6.Text = "B-"

        ElseIf CInt(txtGradeSix.Text) >= 73 And CInt(txtGradeSix.Text) <= 76 Then
            lblLetterGrade6.Text = "B"

        ElseIf CInt(txtGradeSix.Text) >= 77 And CInt(txtGradeSix.Text) <= 79 Then
            lblLetterGrade6.Text = "B+"

        ElseIf CInt(txtGradeSix.Text) >= 80 And CInt(txtGradeSix.Text) <= 84 Then
            lblLetterGrade6.Text = "A-"

        ElseIf CInt(txtGradeSix.Text) >= 85 And CInt(txtGradeSix.Text) <= 89 Then
            lblLetterGrade6.Text = "A"

        ElseIf CInt(txtGradeSix.Text) >= 90 And CInt(txtGradeSix.Text) <= 100 Then
            lblLetterGrade6.Text = "A+"


            ' grade 6 ends

        End If

        If Not IsNumeric(txtGradeFive.Text) Then

            lblErrorDisplay.Text = "Please enter a numeric value."

            txtGradeFive.Select()
            txtGradeFive.SelectionStart = 0
            txtGradeFive.SelectionLength = Len(txtGradeFive.Text)

        ElseIf Not Integer.TryParse(txtGradeFive.Text, userInput) Then

            lblErrorDisplay.Text = "Please enter a whole number only."

            txtGradeFive.Select()
            txtGradeFive.SelectionStart = 0
            txtGradeFive.SelectionLength = Len(txtGradeFive.Text)

        ElseIf CInt(txtGradeFive.Text) >= 0 And CInt(txtGradeFive.Text) <= 49 Then
            lblLetterGrade5.Text = "F"

        ElseIf CInt(txtGradeFive.Text) >= 50 And CInt(txtGradeFive.Text) <= 52 Then
            lblLetterGrade5.Text = "D-"

        ElseIf CInt(txtGradeFive.Text) >= 53 And CInt(txtGradeFive.Text) <= 56 Then
            lblLetterGrade5.Text = "D"

        ElseIf CInt(txtGradeFive.Text) >= 57 And CInt(txtGradeFive.Text) <= 59 Then
            lblLetterGrade5.Text = "D+"

        ElseIf CInt(txtGradeFive.Text) >= 60 And CInt(txtGradeFive.Text) <= 62 Then
            lblLetterGrade5.Text = "C-"

        ElseIf CInt(txtGradeFive.Text) >= 63 And CInt(txtGradeFive.Text) <= 66 Then
            lblLetterGrade5.Text = "C"

        ElseIf CInt(txtGradeFive.Text) >= 67 And CInt(txtGradeFive.Text) <= 69 Then
            lblLetterGrade5.Text = "C+"

        ElseIf CInt(txtGradeFive.Text) >= 70 And CInt(txtGradeFive.Text) <= 72 Then
            lblLetterGrade5.Text = "B-"

        ElseIf CInt(txtGradeFive.Text) >= 73 And CInt(txtGradeFive.Text) <= 76 Then
            lblLetterGrade5.Text = "B"

        ElseIf CInt(txtGradeFive.Text) >= 77 And CInt(txtGradeFive.Text) <= 79 Then
            lblLetterGrade5.Text = "B+"

        ElseIf CInt(txtGradeFive.Text) >= 80 And CInt(txtGradeFive.Text) <= 84 Then
            lblLetterGrade5.Text = "A-"

        ElseIf CInt(txtGradeFive.Text) >= 85 And CInt(txtGradeFive.Text) <= 89 Then
            lblLetterGrade5.Text = "A"

        ElseIf CInt(txtGradeFive.Text) >= 90 And CInt(txtGradeFive.Text) <= 100 Then
            lblLetterGrade5.Text = "A+"


            ' grade 5 ends
        End If

        If Not IsNumeric(txtGradeFour.Text) Then

            lblErrorDisplay.Text = "Please enter a numeric value."

            txtGradeFour.Select()
            txtGradeFour.SelectionStart = 0
            txtGradeFour.SelectionLength = Len(txtGradeFour.Text)

        ElseIf Not Integer.TryParse(txtGradeFour.Text, userInput) Then

            lblErrorDisplay.Text = "Please enter a whole number only."

            txtGradeFour.Select()
            txtGradeFour.SelectionStart = 0
            txtGradeFour.SelectionLength = Len(txtGradeFour.Text)

        ElseIf CInt(txtGradeFour.Text) >= 0 And CInt(txtGradeFour.Text) <= 49 Then
            lblLetterGrade4.Text = "F"

        ElseIf CInt(txtGradeFour.Text) >= 50 And CInt(txtGradeFour.Text) <= 52 Then
            lblLetterGrade4.Text = "D-"

        ElseIf CInt(txtGradeFour.Text) >= 53 And CInt(txtGradeFour.Text) <= 56 Then
            lblLetterGrade4.Text = "D"

        ElseIf CInt(txtGradeFour.Text) >= 57 And CInt(txtGradeFour.Text) <= 59 Then
            lblLetterGrade4.Text = "D+"

        ElseIf CInt(txtGradeFour.Text) >= 60 And CInt(txtGradeFour.Text) <= 62 Then
            lblLetterGrade4.Text = "C-"

        ElseIf CInt(txtGradeFour.Text) >= 63 And CInt(txtGradeFour.Text) <= 66 Then
            lblLetterGrade4.Text = "C"

        ElseIf CInt(txtGradeFour.Text) >= 67 And CInt(txtGradeFour.Text) <= 69 Then
            lblLetterGrade4.Text = "C+"

        ElseIf CInt(txtGradeFour.Text) >= 70 And CInt(txtGradeFour.Text) <= 72 Then
            lblLetterGrade4.Text = "B-"

        ElseIf CInt(txtGradeFour.Text) >= 73 And CInt(txtGradeFour.Text) <= 76 Then
            lblLetterGrade4.Text = "B"

        ElseIf CInt(txtGradeFour.Text) >= 77 And CInt(txtGradeFour.Text) <= 79 Then
            lblLetterGrade4.Text = "B+"

        ElseIf CInt(txtGradeFour.Text) >= 80 And CInt(txtGradeFour.Text) <= 84 Then
            lblLetterGrade4.Text = "A-"

        ElseIf CInt(txtGradeFour.Text) >= 85 And CInt(txtGradeFour.Text) <= 89 Then
            lblLetterGrade4.Text = "A"

        ElseIf CInt(txtGradeFour.Text) >= 90 And CInt(txtGradeFour.Text) <= 100 Then
            lblLetterGrade4.Text = "A+"

            ' grade 4 ends
        End If




        If Not IsNumeric(txtGradeThree.Text) Then

            lblErrorDisplay.Text = "Please enter a numeric value."

            txtGradeThree.Select()
            txtGradeThree.SelectionStart = 0
            txtGradeThree.SelectionLength = Len(txtGradeThree.Text)

        ElseIf Not Integer.TryParse(txtGradeThree.Text, userInput) Then

            lblErrorDisplay.Text = "Please enter a whole number only."

            txtGradeThree.Select()
            txtGradeThree.SelectionStart = 0
            txtGradeThree.SelectionLength = Len(txtGradeThree.Text)


        ElseIf CInt(txtGradeThree.Text) >= 0 And CInt(txtGradeThree.Text) <= 49 Then
            lblLetterGrade3.Text = "F"

        ElseIf CInt(txtGradeThree.Text) >= 50 And CInt(txtGradeThree.Text) <= 52 Then
            lblLetterGrade3.Text = "D-"

        ElseIf CInt(txtGradeThree.Text) >= 53 And CInt(txtGradeThree.Text) <= 56 Then
            lblLetterGrade3.Text = "D"

        ElseIf CInt(txtGradeThree.Text) >= 57 And CInt(txtGradeThree.Text) <= 59 Then
            lblLetterGrade3.Text = "D+"

        ElseIf CInt(txtGradeThree.Text) >= 60 And CInt(txtGradeThree.Text) <= 62 Then
            lblLetterGrade3.Text = "C-"

        ElseIf CInt(txtGradeThree.Text) >= 63 And CInt(txtGradeThree.Text) <= 66 Then
            lblLetterGrade3.Text = "C"

        ElseIf CInt(txtGradeThree.Text) >= 67 And CInt(txtGradeThree.Text) <= 69 Then
            lblLetterGrade3.Text = "C+"

        ElseIf CInt(txtGradeThree.Text) >= 70 And CInt(txtGradeThree.Text) <= 72 Then
            lblLetterGrade3.Text = "B-"

        ElseIf CInt(txtGradeThree.Text) >= 73 And CInt(txtGradeThree.Text) <= 76 Then
            lblLetterGrade3.Text = "B"

        ElseIf CInt(txtGradeThree.Text) >= 77 And CInt(txtGradeThree.Text) <= 79 Then
            lblLetterGrade3.Text = "B+"

        ElseIf CInt(txtGradeThree.Text) >= 80 And CInt(txtGradeThree.Text) <= 84 Then
            lblLetterGrade3.Text = "A-"

        ElseIf CInt(txtGradeThree.Text) >= 85 And CInt(txtGradeThree.Text) <= 89 Then
            lblLetterGrade3.Text = "A"

        ElseIf CInt(txtGradeThree.Text) >= 90 And CInt(txtGradeThree.Text) <= 100 Then
            lblLetterGrade3.Text = "A+"


        End If

        ' GRADE 3 ENDS


        If Not IsNumeric(txtGradeTwo.Text) Then

            lblErrorDisplay.Text = "Please enter a numeric value."

            ' lblErrorDisplay.Text & "Please enter a numeric value."

            txtGradeTwo.Select()
            txtGradeTwo.SelectionStart = 0
            txtGradeTwo.SelectionLength = Len(txtGradeTwo.Text)

        ElseIf Not Integer.TryParse(txtGradeTwo.Text, userInput) Then

            lblErrorDisplay.Text = "Please enter a whole number only."

            txtGradeTwo.Select()
            txtGradeTwo.SelectionStart = 0
            txtGradeTwo.SelectionLength = Len(txtGradeTwo.Text)


        ElseIf CInt(txtGradeTwo.Text) >= 0 And CInt(txtGradeTwo.Text) <= 49 Then
            lblLetterGrade2.Text = "F"

        ElseIf CInt(txtGradeTwo.Text) >= 50 And CInt(txtGradeTwo.Text) <= 52 Then
            lblLetterGrade2.Text = "D-"

        ElseIf CInt(txtGradeTwo.Text) >= 53 And CInt(txtGradeTwo.Text) <= 56 Then
            lblLetterGrade2.Text = "D"

        ElseIf CInt(txtGradeTwo.Text) >= 57 And CInt(txtGradeTwo.Text) <= 59 Then
            lblLetterGrade2.Text = "D+"

        ElseIf CInt(txtGradeTwo.Text) >= 60 And CInt(txtGradeTwo.Text) <= 62 Then
            lblLetterGrade2.Text = "C-"

        ElseIf CInt(txtGradeTwo.Text) >= 63 And CInt(txtGradeTwo.Text) <= 66 Then
            lblLetterGrade2.Text = "C"

        ElseIf CInt(txtGradeTwo.Text) >= 67 And CInt(txtGradeTwo.Text) <= 69 Then
            lblLetterGrade2.Text = "C+"

        ElseIf CInt(txtGradeTwo.Text) >= 70 And CInt(txtGradeTwo.Text) <= 72 Then
            lblLetterGrade2.Text = "B-"

        ElseIf CInt(txtGradeTwo.Text) >= 73 And CInt(txtGradeTwo.Text) <= 76 Then
            lblLetterGrade2.Text = "B"

        ElseIf CInt(txtGradeTwo.Text) >= 77 And CInt(txtGradeTwo.Text) <= 79 Then
            lblLetterGrade2.Text = "B+"

        ElseIf CInt(txtGradeTwo.Text) >= 80 And CInt(txtGradeTwo.Text) <= 84 Then
            lblLetterGrade2.Text = "A-"

        ElseIf CInt(txtGradeTwo.Text) >= 85 And CInt(txtGradeTwo.Text) <= 89 Then
            lblLetterGrade2.Text = "A"

        ElseIf CInt(txtGradeTwo.Text) >= 90 And CInt(txtGradeTwo.Text) <= 100 Then
            lblLetterGrade2.Text = "A+"

        End If

        ' GRADE 2 ENDS

        lblSemesterAverageDisplay.Text = CType(CInt(CType(Val(txtGradeOne.Text) + Val(txtGradeTwo.Text) + Val(txtGradeThree.Text) + Val(txtGradeFour.Text) + Val(txtGradeFive.Text) + Val(txtGradeSix.Text), String)) / 6, String)

        If CInt(lblSemesterAverageDisplay.Text) >= 0 And CInt(lblSemesterAverageDisplay.Text) <= 49 Then
            lblAverageLetterGrade.Text = "F"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 50 And CInt(lblSemesterAverageDisplay.Text) <= 52 Then
            lblAverageLetterGrade.Text = "D-"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 53 And CInt(lblSemesterAverageDisplay.Text) <= 56 Then
            lblAverageLetterGrade.Text = "D"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 57 And CInt(lblSemesterAverageDisplay.Text) <= 59 Then
            lblAverageLetterGrade.Text = "D+"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 60 And CInt(lblSemesterAverageDisplay.Text) <= 62 Then
            lblAverageLetterGrade.Text = "C-"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 63 And CInt(lblSemesterAverageDisplay.Text) <= 66 Then
            lblAverageLetterGrade.Text = "C"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 67 And CInt(lblSemesterAverageDisplay.Text) <= 69 Then
            lblAverageLetterGrade.Text = "C+"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 70 And CInt(lblSemesterAverageDisplay.Text) <= 72 Then
            lblAverageLetterGrade.Text = "B-"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 73 And CInt(lblSemesterAverageDisplay.Text) <= 76 Then
            lblAverageLetterGrade.Text = "B"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 77 And CInt(lblSemesterAverageDisplay.Text) <= 79 Then
            lblAverageLetterGrade.Text = "B+"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 80 And CInt(lblSemesterAverageDisplay.Text) <= 84 Then
            lblAverageLetterGrade.Text = "A-"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 85 And CInt(lblSemesterAverageDisplay.Text) <= 89 Then
            lblAverageLetterGrade.Text = "A"

        ElseIf CInt(lblSemesterAverageDisplay.Text) >= 90 And CInt(lblSemesterAverageDisplay.Text) <= 100 Then
            lblAverageLetterGrade.Text = "A+"

        End If

    End Sub

    Private Sub frmSemesterAverages_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
