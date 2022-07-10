Public Class Form1
    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        Dim ctf As System.IO.StreamWriter
        ctf = New IO.StreamWriter("ContactTracingForm.txt", True)
        ctf.WriteLine("Quezon City Contact Tracing Form")
        ctf.WriteLine("")
        ctf.WriteLine("Full Name: " + fullname_txtbox.Text)
        ctf.WriteLine("Age: " + age_txtbox.Text)

        If male_radbtn.Checked Then
            ctf.WriteLine("Gender: Male")
        Else
            ctf.WriteLine("Gender: Female")
        End If

        ctf.WriteLine("Contact No: " + contact_txtbox.Text)
        ctf.WriteLine("Email: " + email_txtbox.Text)
        ctf.WriteLine("Date: " + DateTimePicker1.Text)
        ctf.WriteLine("Time: " + time_txtbox.Text)
        ctf.WriteLine("Address: " + address_txtbox.Text)
        ctf.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
