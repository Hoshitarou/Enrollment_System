Imports System.Data.OleDb

Public Class ADMISSIONLogin

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim status = LoginResult(txtUsername, txtPassword, {"Admission"})

        Select Case status
            Case LoginStatus.Success

                Hide()
                MainForm.Show()

            Case LoginStatus.Incorrect

                MessageBox.Show("Incorrect Password")

            Case LoginStatus.ZeroAttempt

                MessageBox.Show("Attempts Exceeded")

            Case LoginStatus.Locked

                MessageBox.Show("Locked")

            Case Else

        End Select

    End Sub
End Class