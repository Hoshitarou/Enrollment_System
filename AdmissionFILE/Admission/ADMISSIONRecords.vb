Public Class ADMISSIONRecords
    Private Sub btnBack_Click(sender As Object, e As EventArgs)

        Hide()
        MainForm.Show()

    End Sub

    Private Sub ADMISSIONRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DoDisplayToDataGridView("SELECT * FROM qryStudent", DataGridView1)

    End Sub
End Class