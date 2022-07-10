Public Class Form1
    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        Dim file As System.IO.StreamWriter
        file = New IO.StreamWriter("ContactTracingForm.txt", True)
        file.Close()
    End Sub
End Class
