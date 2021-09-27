Public Class Display
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Button1.Location = New Point(Int(Me.Size.Width - Button1.Width) / 2, Button1.Location.Y)
        'MsgBox(Button1.Location.ToString)
    End Sub
End Class