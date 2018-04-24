''''''''''''''''''''''''''''''''''''''''''''
'Written By Jacob Zayak and Savion Jackson '
'4/18/2018                                 '
'Version 1.6                               '
'Last Modified: 4/24/2018                  '
''''''''''''''''''''''''''''''''''''''''''''



''' <summary> "Application Summary"
''' This application is the final project for CPT 212-001 Spring 2018
''' Instructor: S.Dobson
''' </summary>

Public Class Main

#Region "Globals (Because why not...) ¯\_(ツ)_/¯"
    'Boolean array to hold whether seat is booked or not
    Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
    'Bool variable to hold if FirstClass is full
    Dim fullFC As Boolean = False
    'Bool variable to hold if Economy is full
    Dim fullEco As Boolean = False
#End Region

    'The entire program because I was too lazy to build out classes
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
                        BoardingPass.lblBPSeat.Text = ("Seat Number: " & i + 1) 'Changes boarding pass (bp) label to display Seat Number
                        seatBox(i).BackColor = Color.LightGray 'Changes seat color to indicate seat has been booked
                        seatBox(i).Enabled = True 'Allows user to click on seat to dispay bp
                        BoardingPass.lblBPClass.Text = "First Class" 'Changes boarding pass (bp) label to display seat class
                        BoardingPass.ShowDialog() 'Shows bp dialog form
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

                            'Reset the form for next flight
                        ElseIf newFlight = DialogResult.Yes Then
                            Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
                            Dim fullFC As Boolean = False
                            Dim fullEco As Boolean = False
                            Dim frm = New Main
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
                            seats(i) = True
                            BoardingPass.lblBPSeat.Text = ("Seat Number: " & i + 1)
                            seatBox(i).BackColor = Color.LightGray
                            seatBox(i).Enabled = True
                            BoardingPass.lblBPClass.Text = "First Class"
                            BoardingPass.ShowDialog()
                            emptySeat = True
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
                        BoardingPass.lblBPSeat.Text = ("Seat Number: " & i + 1) 'Changes boarding pass (bp) label to display Seat Number
                        seatBox(i).BackColor = Color.LightGray 'Changes seat color to indicate seat has been booked
                        seatBox(i).Enabled = True 'Allows user to click on seat to dispay bp
                        BoardingPass.lblBPClass.Text = "Economy Class" 'Changes boarding pass (bp) label to display seat class
                        BoardingPass.ShowDialog() 'Shows bp dialog form
                        emptySeat = True
                    Else
                        i += 1 'Else add one to counter and re-loop.
                    End If
                ElseIf i > 4 And i <= 9 Then
                    If seats(i) = False Then
                        seats(i) = True
                        BoardingPass.lblBPSeat.Text = ("Seat Number: " & i + 1) 'Changes boarding pass (bp) label to display Seat Number
                        seatBox(i).BackColor = Color.LightGray 'Changes seat color to indicate seat has been booked
                        seatBox(i).Enabled = True 'Allows user to click on seat to dispay bp
                        BoardingPass.lblBPClass.Text = "Economy Class" 'Changes boarding pass (bp) label to display seat class
                        BoardingPass.ShowDialog() 'Shows bp dialog form
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
                            Dim frm = New Main
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

    'Resets main form
    Private Sub ClearFlightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearFlightToolStripMenuItem.Click
        Dim seats() As Boolean = {False, False, False, False, False, False, False, False, False, False}
        Dim fullFC As Boolean = False
        Dim fullEco As Boolean = False
        Dim frm = New Main
        frm.Show()
        Me.Close()
    End Sub

    'menu close
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Credits form event handler
    Private Sub CreditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditToolStripMenuItem.Click
        Credit.ShowDialog()
    End Sub

    'Help form event handler
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.ShowDialog()
    End Sub


#Region "Booked Seat event handlers for displaying Boarding Pass"
    ''' <summary>
    ''' The follwing event handlers allow the user to go back and print boarding passes
    ''' for previously booked seats.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbSeat9_Click(sender As Object, e As EventArgs) Handles pbSeat9.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 9")
        BoardingPass.lblBPClass.Text = "Economy Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat5_Click(sender As Object, e As EventArgs) Handles pbSeat5.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 5")
        BoardingPass.lblBPClass.Text = "Economy Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat4_Click(sender As Object, e As EventArgs) Handles pbSeat4.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 4")
        BoardingPass.lblBPClass.Text = "First Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat3_Click(sender As Object, e As EventArgs) Handles pbSeat3.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 3")
        BoardingPass.lblBPClass.Text = "First Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat2_Click(sender As Object, e As EventArgs) Handles pbSeat2.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 2")
        BoardingPass.lblBPClass.Text = "First Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat6_Click(sender As Object, e As EventArgs) Handles pbSeat6.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 6")
        BoardingPass.lblBPClass.Text = "Economy Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat7_Click(sender As Object, e As EventArgs) Handles pbSeat7.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 7")
        BoardingPass.lblBPClass.Text = "Economy Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat8_Click(sender As Object, e As EventArgs) Handles pbSeat8.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 8")
        BoardingPass.lblBPClass.Text = "Economy Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat1_Click(sender As Object, e As EventArgs) Handles pbSeat1.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 1")
        BoardingPass.lblBPClass.Text = "First Class"
        BoardingPass.ShowDialog()
    End Sub

    Private Sub pbSeat10_Click(sender As Object, e As EventArgs) Handles pbSeat10.Click
        BoardingPass.lblBPSeat.Text = ("Seat Number: 10")
        BoardingPass.lblBPClass.Text = "Economy Class"
        BoardingPass.ShowDialog()
    End Sub
#End Region

End Class
