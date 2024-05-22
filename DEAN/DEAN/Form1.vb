Imports System.Data.OleDb
Public Class Form1

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim status = LogiinREsult(txtUsername, txtPassword, {"DEAN"})

        Select Case status
            Case LoginStatus.Success

                Hide()
                DEANMainPanel.Show()

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
