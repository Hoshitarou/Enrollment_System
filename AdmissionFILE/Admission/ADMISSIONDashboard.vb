Public Class ADMISSIONDashboard
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMM | dd | yyyy")
        lblTime.Text = Date.Now.ToString("HH:MM:ss")
    End Sub

    Private Sub ADMISSIONDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

        lblEnrolled.Text = DoScalar("SELECT COUNT(*) FROM Enrollment_Details WHERE EnrollmentStatus='Enrolled'")
        lblActive.Text = DoScalar("SELECT COUNT(*) FROM Student WHERE Status='Active'")
        lblInactive.Text = DoScalar("SELECT COUNT(*) FROM Student WHERE Status='Inactive'")

    End Sub

    Private Sub Guna2Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel3.Paint

    End Sub
End Class