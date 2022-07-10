Public Class Form1
    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        Dim ctf As System.IO.StreamWriter
        ctf = New IO.StreamWriter("ContactTracingForm.txt", True)
        ctf.WriteLine("Quezon City Contact Tracing Form")
        ctf.WriteLine("")
        ctf.WriteLine("Full Name: " + fullname_txtbox.Text)
        ctf.WriteLine("Age: " + ageTextbox.Text)

        If male_radbtn.Checked Then
            ctf.WriteLine("Gender: Male")
        Else
            ctf.WriteLine("Gender: Female")
        End If
        ctf.Close()
    End Sub
End Class
