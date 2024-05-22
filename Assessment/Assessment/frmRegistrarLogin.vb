Public Class frmRegistrarLogin
    Private Sub frmRegistrarLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim status = LogiinREsult(txtUsername, txtPassword, {"Assessment"})

        Select Case status
            Case LoginStatus.Success

                Hide()
                frmITMDashboard.Show()

            Case LoginStatus.Incorrect

                MessageBox.Show("Incorrect")

            Case LoginStatus.ZeroAttempt

                MessageBox.Show("Attempts Exceeded")

            Case LoginStatus.Locked

                MessageBox.Show("Locked")

            Case Else

        End Select

    End Sub
End Class