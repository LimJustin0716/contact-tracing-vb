<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QR
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
        Me.pic_box = New System.Windows.Forms.PictureBox()
        Me.btn_scan = New System.Windows.Forms.Button()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(167, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contact Tracing QR Scanner"
        '
        'pic_box
        '
        Me.pic_box.Location = New System.Drawing.Point(12, 72)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.Size = New System.Drawing.Size(767, 278)
        Me.pic_box.TabIndex = 1
        Me.pic_box.TabStop = False
        '
        'btn_scan
        '
        Me.btn_scan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_scan.Location = New System.Drawing.Point(296, 366)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(242, 72)
        Me.btn_scan.TabIndex = 2
        Me.btn_scan.Text = "Click to Scan"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'QR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.pic_box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "QR"
        Me.Text = "QR"
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pic_box As PictureBox
    Friend WithEvents btn_scan As Button
End Class
