Public Class BoardingPass
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    'DLL for capturing screen and printing
    <System.Runtime.InteropServices.DllImport("gdi32.dll")>
    Public Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr,
         ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Long
    End Function


    'get the screenshot
    Private memoryImage As Bitmap
    'Capture boarding pass panel
    Private Sub CaptureScreen()
        Dim mygraphics As Graphics = Me.pnlBoardingPass.CreateGraphics()
        Dim s As Size = Me.pnlBoardingPass.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.pnlBP.ClientRectangle.Width, Me.pnlBoardingPass.ClientRectangle.Height, dc1,
     0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub


    'Sets print area for print button event
    Private Sub printDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub

    'Prints Boarding Pass
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        CaptureScreen()
        PrintDocument1.Print()
    End Sub

End Class