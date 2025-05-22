Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim secondForm As New Form2()
        secondForm.StartPosition = FormStartPosition.CenterScreen
        secondForm.Show()

        Me.Hide()
    End Sub
End Class