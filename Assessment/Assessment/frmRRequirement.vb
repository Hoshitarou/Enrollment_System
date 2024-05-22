Public Class frmRRequirement
    Private Sub cbSemester1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSemester1.SelectedIndexChanged
        cbSemester1.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub txtAY_TextChanged(sender As Object, e As EventArgs) Handles txtAY.TextChanged

    End Sub

    Private Sub cbYRLVL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbYRLVL.SelectedIndexChanged
        cbYRLVL.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbStudentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStudentType.SelectedIndexChanged
        cbStudentType.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub cbCourseSub_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCourseSub.SelectedIndexChanged
        cbCourseSub.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
End Class