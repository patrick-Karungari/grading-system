Public Class MainForm
    Public USERNAME As String = "PATRICK"
    Public PASSWORD As String = "5410"
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles connectbtn.Click

        If PasswordForm.ShowDialog = DialogResult.OK Then
            If PasswordForm.idtxt.Text = USERNAME And
                    PasswordForm.pwtxt.Text = PASSWORD Then
                MsgBox("Sign in successful! You're connected as " & PasswordForm.idtxt.Text)

                Dim number1, number2, number3 As Integer
                Dim grade As String

                number1 = InputBox("ENTER CAT 1 MARKS")
                number2 = InputBox("ENTER CAT 2 MARKS")
                number3 = InputBox("ENTER MAIN EXAM MARKS")
                grade = STUDENT_GRADE.TotalMarks(number1, number2, number3)
                STUDENT_GRADE.cat1txt.Text = number1
                STUDENT_GRADE.cat2txt.Text = number2
                STUDENT_GRADE.maintxt.Text = number3

                STUDENT_GRADE.averagetxt.Text = STUDENT_GRADE.TotalMarks(number1, number2, number3)
                STUDENT_GRADE.gradetxt.Text = STUDENT_GRADE.Grade1(grade)

                STUDENT_GRADE.Show()

            Else
                MsgBox("Enter the correct password and User ID to connect.")


            End If
        Else
            MsgBox("Could not connect to the system.")
            MainForm.SHOW()

        End If

    End Sub

    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        MsgBox("THANK YOU!!! COME AGAIN")
        End


    End Sub
End Class