Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New DefaultLogger.FormTask
        form.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Log4NetSample.FormTask
        form.Show()
    End Sub
End Class
