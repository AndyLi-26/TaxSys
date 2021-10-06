Public Class main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        record.Show()
        record.company.Text = Button1.Text
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        record.Show()
        record.company.Text = Button2.Text
        Me.Hide()
    End Sub
End Class