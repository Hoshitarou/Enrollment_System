Imports System.Data.OleDb

Public Class MainForm
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Hide()
        ADMISSIONLogin.Show()

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnRecords.Click

        ADMISSIONRecords.TopLevel = False
        Panel2.Controls.Add(ADMISSIONRecords)
        ADMISSIONRecords.BringToFront()
        ADMISSIONRecords.Show()

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnAdmit.Click

        Admit.TopLevel = False
        Panel2.Controls.Add(Admit)
        Admit.BringToFront()
        Admit.Show()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

        Hide()
        'Courses.TopLevel = False
        'pnlDisplay.Controls.Add(Courses)
        'Courses.BringToFront()
        Courses.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ADMISSIONDashboard.TopLevel = False
        Panel2.Controls.Add(ADMISSIONDashboard)
        ADMISSIONDashboard.BringToFront()
        ADMISSIONDashboard.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel2.UseWaitCursor = False
    End Sub
End Class