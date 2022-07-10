<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fullname_txtbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.female_radbtn = New System.Windows.Forms.RadioButton()
        Me.male_radbtn = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.age_txtbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.contact_txtbox = New System.Windows.Forms.TextBox()
        Me.email_txtbox = New System.Windows.Forms.TextBox()
        Me.address_txtbox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.out_country_no = New System.Windows.Forms.RadioButton()
        Me.out_country_yes = New System.Windows.Forms.RadioButton()
        Me.flu_no = New System.Windows.Forms.RadioButton()
        Me.flu_yes = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.vaccinate_no = New System.Windows.Forms.RadioButton()
        Me.vaccinate_yes = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.covid_no = New System.Windows.Forms.RadioButton()
        Me.covid_yes = New System.Windows.Forms.RadioButton()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.reset_btn = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.time_label = New System.Windows.Forms.Label()
        Me.time_txtbox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(54, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Tracing Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Full Name:"
        '
        'fullname_txtbox
        '
        Me.fullname_txtbox.Location = New System.Drawing.Point(103, 73)
        Me.fullname_txtbox.Name = "fullname_txtbox"
        Me.fullname_txtbox.Size = New System.Drawing.Size(329, 22)
        Me.fullname_txtbox.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.female_radbtn)
        Me.GroupBox1.Controls.Add(Me.male_radbtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 79)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sex"
        '
        'female_radbtn
        '
        Me.female_radbtn.AutoSize = True
        Me.female_radbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.female_radbtn.Location = New System.Drawing.Point(110, 34)
        Me.female_radbtn.Name = "female_radbtn"
        Me.female_radbtn.Size = New System.Drawing.Size(85, 24)
        Me.female_radbtn.TabIndex = 1
        Me.female_radbtn.TabStop = True
        Me.female_radbtn.Text = "Female"
        Me.female_radbtn.UseVisualStyleBackColor = True
        '
        'male_radbtn
        '
        Me.male_radbtn.AutoSize = True
        Me.male_radbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.male_radbtn.Location = New System.Drawing.Point(13, 34)
        Me.male_radbtn.Name = "male_radbtn"
        Me.male_radbtn.Size = New System.Drawing.Size(66, 24)
        Me.male_radbtn.TabIndex = 0
        Me.male_radbtn.TabStop = True
        Me.male_radbtn.Text = "Male"
        Me.male_radbtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(235, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Age:"
        '
        'age_txtbox
        '
        Me.age_txtbox.Location = New System.Drawing.Point(284, 155)
        Me.age_txtbox.Name = "age_txtbox"
        Me.age_txtbox.Size = New System.Drawing.Size(148, 22)
        Me.age_txtbox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact No.:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Address:"
        '
        'contact_txtbox
        '
        Me.contact_txtbox.Location = New System.Drawing.Point(120, 218)
        Me.contact_txtbox.Name = "contact_txtbox"
        Me.contact_txtbox.Size = New System.Drawing.Size(312, 22)
        Me.contact_txtbox.TabIndex = 10
        '
        'email_txtbox
        '
        Me.email_txtbox.Location = New System.Drawing.Point(74, 255)
        Me.email_txtbox.Name = "email_txtbox"
        Me.email_txtbox.Size = New System.Drawing.Size(358, 22)
        Me.email_txtbox.TabIndex = 11
        '
        'address_txtbox
        '
        Me.address_txtbox.Location = New System.Drawing.Point(94, 322)
        Me.address_txtbox.Name = "address_txtbox"
        Me.address_txtbox.Size = New System.Drawing.Size(338, 22)
        Me.address_txtbox.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.out_country_no)
        Me.GroupBox2.Controls.Add(Me.out_country_yes)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 363)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(416, 69)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Have you been outside the country for the past 14 days?"
        '
        'out_country_no
        '
        Me.out_country_no.AutoSize = True
        Me.out_country_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.out_country_no.Location = New System.Drawing.Point(241, 34)
        Me.out_country_no.Name = "out_country_no"
        Me.out_country_no.Size = New System.Drawing.Size(51, 24)
        Me.out_country_no.TabIndex = 1
        Me.out_country_no.TabStop = True
        Me.out_country_no.Text = "No"
        Me.out_country_no.UseVisualStyleBackColor = True
        '
        'out_country_yes
        '
        Me.out_country_yes.AutoSize = True
        Me.out_country_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.out_country_yes.Location = New System.Drawing.Point(110, 34)
        Me.out_country_yes.Name = "out_country_yes"
        Me.out_country_yes.Size = New System.Drawing.Size(58, 24)
        Me.out_country_yes.TabIndex = 0
        Me.out_country_yes.TabStop = True
        Me.out_country_yes.Text = "Yes"
        Me.out_country_yes.UseVisualStyleBackColor = True
        '
        'flu_no
        '
        Me.flu_no.AutoSize = True
        Me.flu_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.flu_no.Location = New System.Drawing.Point(241, 34)
        Me.flu_no.Name = "flu_no"
        Me.flu_no.Size = New System.Drawing.Size(51, 24)
        Me.flu_no.TabIndex = 1
        Me.flu_no.TabStop = True
        Me.flu_no.Text = "No"
        Me.flu_no.UseVisualStyleBackColor = True
        '
        'flu_yes
        '
        Me.flu_yes.AutoSize = True
        Me.flu_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.flu_yes.Location = New System.Drawing.Point(110, 34)
        Me.flu_yes.Name = "flu_yes"
        Me.flu_yes.Size = New System.Drawing.Size(58, 24)
        Me.flu_yes.TabIndex = 0
        Me.flu_yes.TabStop = True
        Me.flu_yes.Text = "Yes"
        Me.flu_yes.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.flu_no)
        Me.GroupBox3.Controls.Add(Me.flu_yes)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 441)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 69)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Have you been experiencing flu like symptoms?"
        '
        'vaccinate_no
        '
        Me.vaccinate_no.AutoSize = True
        Me.vaccinate_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.vaccinate_no.Location = New System.Drawing.Point(241, 34)
        Me.vaccinate_no.Name = "vaccinate_no"
        Me.vaccinate_no.Size = New System.Drawing.Size(51, 24)
        Me.vaccinate_no.TabIndex = 1
        Me.vaccinate_no.TabStop = True
        Me.vaccinate_no.Text = "No"
        Me.vaccinate_no.UseVisualStyleBackColor = True
        '
        'vaccinate_yes
        '
        Me.vaccinate_yes.AutoSize = True
        Me.vaccinate_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.vaccinate_yes.Location = New System.Drawing.Point(110, 34)
        Me.vaccinate_yes.Name = "vaccinate_yes"
        Me.vaccinate_yes.Size = New System.Drawing.Size(58, 24)
        Me.vaccinate_yes.TabIndex = 0
        Me.vaccinate_yes.TabStop = True
        Me.vaccinate_yes.Text = "Yes"
        Me.vaccinate_yes.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.vaccinate_no)
        Me.GroupBox4.Controls.Add(Me.vaccinate_yes)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 519)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 69)
        Me.GroupBox4.TabIndex = 16
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Have you been recently vaccinated in the past 14 days?"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.covid_no)
        Me.GroupBox5.Controls.Add(Me.covid_yes)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 602)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(416, 69)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Have you shown symptoms of Covid in the past 14 days?"
        '
        'covid_no
        '
        Me.covid_no.AutoSize = True
        Me.covid_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.covid_no.Location = New System.Drawing.Point(241, 34)
        Me.covid_no.Name = "covid_no"
        Me.covid_no.Size = New System.Drawing.Size(51, 24)
        Me.covid_no.TabIndex = 1
        Me.covid_no.TabStop = True
        Me.covid_no.Text = "No"
        Me.covid_no.UseVisualStyleBackColor = True
        '
        'covid_yes
        '
        Me.covid_yes.AutoSize = True
        Me.covid_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.covid_yes.Location = New System.Drawing.Point(110, 34)
        Me.covid_yes.Name = "covid_yes"
        Me.covid_yes.Size = New System.Drawing.Size(58, 24)
        Me.covid_yes.TabIndex = 0
        Me.covid_yes.TabStop = True
        Me.covid_yes.Text = "Yes"
        Me.covid_yes.UseVisualStyleBackColor = True
        '
        'submit_btn
        '
        Me.submit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.submit_btn.Location = New System.Drawing.Point(284, 689)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(78, 32)
        Me.submit_btn.TabIndex = 18
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'reset_btn
        '
        Me.reset_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.reset_btn.Location = New System.Drawing.Point(365, 689)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.Size = New System.Drawing.Size(78, 32)
        Me.reset_btn.TabIndex = 19
        Me.reset_btn.Text = "Reset"
        Me.reset_btn.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(61, 288)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(229, 22)
        Me.DateTimePicker1.TabIndex = 20
        Me.DateTimePicker1.Value = New Date(2022, 7, 10, 0, 0, 0, 0)
        '
        'time_label
        '
        Me.time_label.AutoSize = True
        Me.time_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.time_label.Location = New System.Drawing.Point(296, 288)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(51, 20)
        Me.time_label.TabIndex = 21
        Me.time_label.Text = "Time:"
        '
        'time_txtbox
        '
        Me.time_txtbox.Location = New System.Drawing.Point(353, 287)
        Me.time_txtbox.Name = "time_txtbox"
        Me.time_txtbox.Size = New System.Drawing.Size(79, 22)
        Me.time_txtbox.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 733)
        Me.Controls.Add(Me.time_txtbox)
        Me.Controls.Add(Me.time_label)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.reset_btn)
        Me.Controls.Add(Me.submit_btn)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.address_txtbox)
        Me.Controls.Add(Me.email_txtbox)
        Me.Controls.Add(Me.contact_txtbox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.age_txtbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fullname_txtbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fullname_txtbox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents female_radbtn As RadioButton
    Friend WithEvents male_radbtn As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents age_txtbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents contact_txtbox As TextBox
    Friend WithEvents email_txtbox As TextBox
    Friend WithEvents address_txtbox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents out_country_no As RadioButton
    Friend WithEvents out_country_yes As RadioButton
    Friend WithEvents flu_no As RadioButton
    Friend WithEvents flu_yes As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents vaccinate_no As RadioButton
    Friend WithEvents vaccinate_yes As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents covid_no As RadioButton
    Friend WithEvents covid_yes As RadioButton
    Friend WithEvents submit_btn As Button
    Friend WithEvents reset_btn As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents time_label As Label
    Friend WithEvents time_txtbox As TextBox
End Class
