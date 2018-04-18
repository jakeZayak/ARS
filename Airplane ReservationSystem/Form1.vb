Public Class Form1
    Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
    Dim fullFC As Boolean = False
    Dim fullEco As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim seatBox() As PictureBox = {pbSeat1, pbSeat2, pbSeat3, pbSeat4, pbSeat5, pbSeat6, pbSeat7, pbSeat8, pbSeat9, pbSeat10}
        Dim count As Integer = 0
        Dim emptySeat As Boolean = False
        Dim i As Integer = 0

        While emptySeat = False
            If rbFC.Checked Then
                If i <= 4 Then
                    If seats(i) = False Then
                        seats(i) = True
                        'Label1.Text = ("Your seat is " + (i + 1).ToString)
                        lblBPSeat.Text = ("Seat Number:" & i + 1)
                        seatBox(i).BackColor = Color.LightGray
                        lblBPClass.Text = "First Class"
                        pnlBP.Visible = True
                        emptySeat = True
                    Else
                        i += 1
                    End If
                Else
                    fullFC = True
                    'Label1.Text = "No seats remaining in First Class"
                    If fullFC = True And fullEco = True Then
                        'Label1.Text = "No seats remaining"
                        Dim newFlight As Integer = MessageBox.Show("Would you like to start booking the next flight?", "Book New Flight", MessageBoxButtons.YesNo)
                        If newFlight = DialogResult.No Then
                            MessageBox.Show("The next flight leaves in 3 hours")
                        ElseIf newFlight = DialogResult.Yes Then
                            Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
                            Dim fullFC As Boolean = False
                            Dim fullEco As Boolean = False
                            Dim frm = New Form1
                            frm.Show()
                            Me.Close()
                        End If
                        Return
                    Else
                        Dim result As Integer = MessageBox.Show("Would you like to fly Economy instead?", "No Seats Available", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            MessageBox.Show("The next flight leaves in 3 hours")
                        ElseIf result = DialogResult.Yes Then
                            rbEco.Checked = True
                            rbFC.Checked = False
                        End If
                    End If
                    Return
                End If
            ElseIf rbEco.Checked Then
                If i < 4 Then
                    i = 5
                    If seats(i) = False Then
                        seats(i) = True
                        'Label1.Text = ("Your seat is " + (i + 1).ToString)
                        emptySeat = True
                        lblBPSeat.Text = ("Seat Number:" & i + 1)
                        seatBox(i).BackColor = Color.LightGray
                        lblBPClass.Text = "Economy Class"
                        pnlBP.Visible = True
                    Else
                        i += 1
                    End If
                ElseIf i > 4 And i <= 9 Then
                    If seats(i) = False Then
                        seats(i) = True
                        'Label1.Text = ("Your seat is " + (i + 1).ToString)
                        lblBPSeat.Text = ("Seat Number:" & i + 1)
                        seatBox(i).BackColor = Color.LightGray
                        lblBPClass.Text = "Economy Class"
                        pnlBP.Visible = True
                        emptySeat = True
                    Else
                        i += 1
                    End If
                Else
                    fullEco = True
                    'Label1.Text = "No seats remaining in First Class"
                    If fullFC = True And fullEco = True Then
                        'Label1.Text = "No seats remaining"
                        Dim newFlight As Integer = MessageBox.Show("Would you like to start booking the next flight?", "Book New Flight", MessageBoxButtons.YesNo)
                        If newFlight = DialogResult.No Then
                            MessageBox.Show("The next flight leaves in 3 hours")
                        ElseIf newFlight = DialogResult.Yes Then
                            Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
                            Dim fullFC As Boolean = False
                            Dim fullEco As Boolean = False
                            Dim frm = New Form1
                            frm.Show()
                            Me.Close()
                        End If
                    Else
                        Dim result As Integer = MessageBox.Show("Would you like to fly First Class instead?", "No Seats Available", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            MessageBox.Show("The next flight leaves in 3 hours")
                        ElseIf result = DialogResult.Yes Then
                            rbEco.Checked = False
                            rbFC.Checked = True
                        End If
                    End If
                    Return
                End If
            End If
        End While
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        pnlBP.Visible = False
    End Sub

    <System.Runtime.InteropServices.DllImport("gdi32.dll")>
    Public Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr,
         ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Long
    End Function
    'get the screenshot
    Private memoryImage As Bitmap
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
    Private Sub printDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        CaptureScreen()
        PrintDocument1.Print()
    End Sub
End Class
