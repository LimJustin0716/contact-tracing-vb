Public Class Form1
    Public Property QRresult As String
    Private Sub current_time(sender As Object, e As EventArgs) Handles Timer1.Tick
        current_timeLabel.Text = DateTime.Now.ToLongTimeString()
    End Sub
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
        Dim GetData As String()
        GetData = QRresult.Split("/".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        fullname_txtbox.Text = GetData(0)
        age_txtbox.Text = GetData(1)
        If GetData(2) = "Male" Then
            male_radbtn.Checked = True
        Else
            female_radbtn.Checked = True
        End If
        contact_txtbox.Text = GetData(3)
        email_txtbox.Text = GetData(4)
        address_txtbox.Text = GetData(5)
        If GetData(6) = "Yes" Then
            out_country_yes.Checked = True
        Else
            out_country_no.Checked = True
        End If
        If GetData(7) = "Yes" Then
            flu_yes.Checked = True
        Else
            flu_no.Checked = True
        End If
        If GetData(8) = "Yes" Then
            vaccinate_yes.Checked = True
        Else
            vaccinate_no.Checked = True
        End If
        If GetData(9) = "Yes" Then
            covid_yes.Checked = True
        Else
            covid_no.Checked = True
        End If
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
