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

        If out_country_yes.Checked Then
            ctf.WriteLine("Have you been outside the country for 14 days?: Yes")
        Else
            ctf.WriteLine("Have you been outside the country for 14 days?: No")
        End If

        If flu_yes.Checked Then
            ctf.WriteLine("Are you experiencing flu like symptoms?: Yes")
        Else
            ctf.WriteLine("Are you experiencing flu like symptoms?: No")
        End If

        If vaccinate_yes.Checked Then
            ctf.WriteLine("Have you been recently vaccinated in the past 14 days?: Yes")
        Else
            ctf.WriteLine("Have you been recently vaccinated in the past 14 days?: No")
        End If

        If covid_yes.Checked Then
            ctf.WriteLine("Have you shown symptoms of Covid in the past 14 days?: Yes")
        Else
            ctf.WriteLine("Have you shown symptoms of Covid in the past 14 days?: No")
        End If

        ctf.WriteLine("")
        ctf.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        fullname_txtbox.Clear()
        age_txtbox.Clear()
        contact_txtbox.Clear()
        email_txtbox.Clear()
        address_txtbox.Clear()

        male_radbtn.Checked = False
        female_radbtn.Checked = False
        out_country_yes.Checked = False
        out_country_no.Checked = False
        flu_yes.Checked = False
        flu_no.Checked = False
        vaccinate_yes.Checked = False
        vaccinate_no.Checked = False
        covid_yes.Checked = False
        covid_no.Checked = False

    End Sub
End Class
