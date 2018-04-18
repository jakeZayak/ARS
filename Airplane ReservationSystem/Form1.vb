Public Class Form1
    'Boolean array to hold whether seat is booked or not
    Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
    'Bool variable to hold if FirstClass is full
    Dim fullFC As Boolean = False
    'Bool variable to hold if Economy is full
    Dim fullEco As Boolean = False
    Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        'Control PictureBox array to hold seat icons
        Dim seatBox() As PictureBox = {pbSeat1, pbSeat2, pbSeat3, pbSeat4, pbSeat5, pbSeat6, pbSeat7, pbSeat8, pbSeat9, pbSeat10}
        'Bool variable to break out of While loop once a seat is filled.
        Dim emptySeat As Boolean = False
        'Counter
        Dim i As Integer = 0

        '
        'While the seat is empty, if FirstClass is selected and we are looking at seats 1-5
        'If the seat is empty, then make seats(i) = true, change the color of the picturebox
        'and exit loop
        '
        While emptySeat = False
            If rbFC.Checked Then
                If i <= 4 Then
                    If seats(i) = False Then
                        seats(i) = True
                        lblBPSeat.Text = ("Seat Number:" & i + 1)
                        seatBox(i).BackColor = Color.LightGray
                        lblBPClass.Text = "First Class"
                        pnlBP.Visible = True
                        emptySeat = True
                    Else
                        i += 1  'Else add one to counter and re-loop.
                    End If
                Else
                    fullFC = True
                    If fullFC = True And fullEco = True Then 'If first class and economy is full, then move to Economy
                        Dim newFlight As Integer = MessageBox.Show("Would you like to start booking the next flight?", "Book New Flight", MessageBoxButtons.YesNo)
                        If newFlight = DialogResult.No Then
                            MessageBox.Show("The next flight leaves in 3 hours")
                        ElseIf newFlight = DialogResult.Yes Then 'Reset the form for next flight
                            Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
                            Dim fullFC As Boolean = False
                            Dim fullEco As Boolean = False
                            Dim frm = New Form1
                            frm.Show()
                            Me.Close()
                        End If
                        Return
                    Else
                        'Dialog session to ask to book economy instead
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
                '
                'While the seat is empty, if Economy is selected and we are looking at seats 6-10
                'If the seat is empty, then make seats(i) = true, change the color of the picturebox
                'and exit loop
                '
            ElseIf rbEco.Checked Then
                If i < 4 Then
                    i = 5 'If counter is below 5 and Economy is selected then make counter start at 5
                    If seats(i) = False Then
                        seats(i) = True
                        emptySeat = True
                        lblBPSeat.Text = ("Seat Number:" & i + 1)
                        seatBox(i).BackColor = Color.LightGray
                        lblBPClass.Text = "Economy Class"
                        pnlBP.Visible = True
                    Else
                        i += 1 'Else add one to counter and re-loop.
                    End If
                ElseIf i > 4 And i <= 9 Then
                    If seats(i) = False Then
                        seats(i) = True
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
                    If fullFC = True And fullEco = True Then 'If first class and economy is full, then move to Economy
                        Dim newFlight As Integer = MessageBox.Show("Would you like to start booking the next flight?", "Book New Flight", MessageBoxButtons.YesNo)
                        If newFlight = DialogResult.No Then
                            MessageBox.Show("The next flight leaves in 3 hours")
                        ElseIf newFlight = DialogResult.Yes Then 'Reset the form for next flight
                            Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
                            Dim fullFC As Boolean = False
                            Dim fullEco As Boolean = False
                            Dim frm = New Form1
                            frm.Show()
                            Me.Close()
                        End If
                    Else
                        'Dialog session to ask to book First Class instead
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

    'Close Form
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        pnlBP.Visible = False
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
