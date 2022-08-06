Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec

Public Class QR
    Dim Cam As VideoCaptureDevice
    Dim BeatEmUp As Bitmap

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        Dim Era As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If Era.ShowDialog() = DialogResult.OK Then
            Cam = Era.VideoDevice
            AddHandler Cam.NewFrame, New NewFrameEventHandler(AddressOf PicBox)
            Cam.Start()
        End If
    End Sub
    Private Sub PicBox(sender As Object, eventArgs As NewFrameEventArgs)
        BeatEmUp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pic_box.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub timer_qr_Tick(sender As Object, e As EventArgs) Handles timer_qr.Tick
        If pic_box.Image IsNot Nothing Then
            Dim BReader As BarcodeReader = New BarcodeReader
            Dim QRDecoder As Result = BReader.Decode(DirectCast(pic_box.Image, Bitmap))
            If QRDecoder IsNot Nothing Then
                Dim ccresult As New Form1
                ccresult.QRresult = QRDecoder.ToString()
                ccresult.Show()
                Me.Hide()
            End If
        End If
    End Sub
End Class