Imports System.Data.OleDb

Public Class Admit

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

        Hide()
        MainForm.Show()

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        If Not chb2by2.Checked And Not chb2pcsEnvelope.Checked And Not chbBirth.Checked And Not chbF137.Checked And Not chbGoodMoral.Checked And Not chbReportCard.Checked Then

            MessageBox.Show("Incomplete forms!")
            Return

        End If

        Dim query As New MieInsertInto("Student")
        query.AddValueToColumn("StudentID", DoIncrement("SELECT MAX(StudentID) FROM Student"))
        query.AddValueToColumn("LastName", tbLN.Text)
        query.AddValueToColumn("FirstName", tbFN.Text)
        query.AddValueToColumn("MiddleName", tbMN.Text)
        query.AddValueToColumn("Address", tbAddress.Text)
        query.AddValueToColumn("ContactNo", tbContact.Text)
        query.AddValueToColumn("BDate", dtpBirthday.Value)
        query.AddValueToColumn("Age", tbAge.Text)
        query.AddValueToColumn("GuardianName", tbGuardianN.Text)
        query.AddValueToColumn("Relationship", cbRS.SelectedItem)
        query.AddValueToColumn("GuardianNo", tbGContact.Text)
        query.AddValueToColumn("SY", cbYRLVL.SelectedItem)
        query.AddValueToColumn("Course", cbCourse.SelectedItem)
        query.AddValueToColumn("GradeLevel", cbYRLVL.SelectedItem)
        query.AddValueToColumn("Status", "Active")
        query.AddValueToColumn("Dateregistered", Date.Now)
        query.ExecuteNonQuery()

    End Sub

    Private Sub cbYRLVL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYRLVL.SelectedIndexChanged
        cbYRLVL.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbStudType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStudType.SelectedIndexChanged
        cbStudType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourse.SelectedIndexChanged
        cbCourse.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbRS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRS.SelectedIndexChanged
        cbRS.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester.SelectedIndexChanged
        cbSemester.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Admit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbLN_TextChanged(sender As Object, e As EventArgs) Handles tbLN.TextChanged

    End Sub

    Private Sub tbMN_TextChanged(sender As Object, e As EventArgs) Handles tbMN.TextChanged

    End Sub

    Private Sub tbFN_TextChanged(sender As Object, e As EventArgs) Handles tbFN.TextChanged

    End Sub

    Private Sub tbEmail_TextChanged(sender As Object, e As EventArgs) Handles tbEmail.TextChanged

    End Sub

    Private Sub tbContact_TextChanged(sender As Object, e As EventArgs) Handles tbContact.TextChanged

    End Sub

    Private Sub tbAddress_TextChanged(sender As Object, e As EventArgs) Handles tbAddress.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub tbGContact_TextChanged(sender As Object, e As EventArgs) Handles tbGContact.TextChanged

    End Sub

    Private Sub tbAge_TextChanged(sender As Object, e As EventArgs) Handles tbAge.TextChanged

    End Sub

    Private Sub tbGuardianN_TextChanged(sender As Object, e As EventArgs) Handles tbGuardianN.TextChanged

    End Sub
End Class