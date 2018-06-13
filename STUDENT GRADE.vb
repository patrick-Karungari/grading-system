Public Class STUDENT_GRADE
    Private Sub Calctbtn_Click(sender As Object, e As EventArgs) Handles calcbtn.Click
        Dim number1, number2, number3 As Integer

        number1 = InputBox("ENTER CAT 1 MARKS")
        number2 = InputBox("ENTER CAT 2 MARKS")
        number3 = InputBox("ENTER MAIN EXAM MARKS")
        cat1txt.Text = number1
        cat2txt.Text = number2
        maintxt.Text = number3
        averagetxt.Text = TotalMarks(number1, number2, number3)
        Dim average1 As Double = TotalMarks(number1, number2, number3)
        gradetxt.Text = Grade1(average1)
    End Sub



    Function TotalMarks(ByVal number1, ByVal number2, ByVal number3) As Integer

        Dim average As Double
        average = ((number1 + number2) / 2 + number3)
        If number1 > 30 Or number2 > 30 Then
            MsgBox("WRONG MARKS ENTRY.")
            average = -1
            averagetxt.Text = ""
        ElseIf number1 < 30 Or number2 < 30 Then

        ElseIf number3 < 0 Or number3 > 70 Then


        End If
        Return average
    End Function

    Function Grade1(ByVal average1 As Double)
        Dim grade As String = Nothing
        Dim remark As String

        If average1 > 70 And
            average1 < 101 Then
            grade = "A"
            remark = "Passed"

        ElseIf average1 > 60 Then
            grade = "B"
            remark = "Passed"

        ElseIf average1 > 50 Then
            grade = "C"
            remark = "Passed"

        ElseIf average1 > 40 Then
            grade = "D"
            remark = "Passed"

        ElseIf average1 < 40 And
            AVERAGE1 > -1 Then
            grade = "E"
            remark = "Fail"
        Else
            MsgBox("WRONG MARKS ENTRY. TRY AGAIN")
        End If

        Return grade
    End Function

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Close()
    End Sub
End Class