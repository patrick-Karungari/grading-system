Public Class PasswordForm
    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Me.DialogResult = DialogResult.OK

    End Sub

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        If Me.DialogResult = DialogResult.Cancel Then
            MainForm.Show()
        Else
            MAINFORM.SHOW()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ID As String = InputBox("ENTER NEW USERNAME")
        Dim PW As String = InputBox("ENTER NEW PASSWORD")
        MainForm.USERNAME = ID
        MainForm.PASSWORD = PW
    End Sub
End Class