<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rbFC = New System.Windows.Forms.RadioButton()
        Me.rbEco = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.pnlBP = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBPClass = New System.Windows.Forms.Label()
        Me.lblBPSeat = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnlBoardingPass = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbSeat10 = New System.Windows.Forms.PictureBox()
        Me.pbSeat9 = New System.Windows.Forms.PictureBox()
        Me.pbSeat8 = New System.Windows.Forms.PictureBox()
        Me.pbSeat7 = New System.Windows.Forms.PictureBox()
        Me.pbSeat6 = New System.Windows.Forms.PictureBox()
        Me.pbSeat5 = New System.Windows.Forms.PictureBox()
        Me.pbSeat4 = New System.Windows.Forms.PictureBox()
        Me.pbSeat3 = New System.Windows.Forms.PictureBox()
        Me.pbSeat2 = New System.Windows.Forms.PictureBox()
        Me.pbSeat1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlBP.SuspendLayout()
        Me.pnlBoardingPass.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSeat1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbFC
        '
        Me.rbFC.AutoSize = True
        Me.rbFC.Location = New System.Drawing.Point(80, 539)
        Me.rbFC.Name = "rbFC"
        Me.rbFC.Size = New System.Drawing.Size(72, 17)
        Me.rbFC.TabIndex = 0
        Me.rbFC.TabStop = True
        Me.rbFC.Text = "First Class"
        Me.rbFC.UseVisualStyleBackColor = True
        '
        'rbEco
        '
        Me.rbEco.AutoSize = True
        Me.rbEco.Location = New System.Drawing.Point(182, 539)
        Me.rbEco.Name = "rbEco"
        Me.rbEco.Size = New System.Drawing.Size(69, 17)
        Me.rbEco.TabIndex = 1
        Me.rbEco.TabStop = True
        Me.rbEco.Text = "Economy"
        Me.rbEco.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(124, 562)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Assign Seat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(48, 192)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'pnlBP
        '
        Me.pnlBP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlBP.Controls.Add(Me.pnlBoardingPass)
        Me.pnlBP.Controls.Add(Me.Button2)
        Me.pnlBP.Controls.Add(Me.btnClose)
        Me.pnlBP.Location = New System.Drawing.Point(12, 12)
        Me.pnlBP.Name = "pnlBP"
        Me.pnlBP.Size = New System.Drawing.Size(312, 238)
        Me.pnlBP.TabIndex = 5
        Me.pnlBP.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(154, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Boarding Pass"
        '
        'lblBPClass
        '
        Me.lblBPClass.AutoSize = True
        Me.lblBPClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBPClass.Location = New System.Drawing.Point(5, 78)
        Me.lblBPClass.Name = "lblBPClass"
        Me.lblBPClass.Size = New System.Drawing.Size(79, 18)
        Me.lblBPClass.TabIndex = 8
        Me.lblBPClass.Text = "First Class"
        '
        'lblBPSeat
        '
        Me.lblBPSeat.AutoSize = True
        Me.lblBPSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBPSeat.Location = New System.Drawing.Point(3, 47)
        Me.lblBPSeat.Name = "lblBPSeat"
        Me.lblBPSeat.Size = New System.Drawing.Size(194, 29)
        Me.lblBPSeat.TabIndex = 7
        Me.lblBPSeat.Text = "Seat Number: 1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'pnlBoardingPass
        '
        Me.pnlBoardingPass.Controls.Add(Me.PictureBox3)
        Me.pnlBoardingPass.Controls.Add(Me.PictureBox2)
        Me.pnlBoardingPass.Controls.Add(Me.Label4)
        Me.pnlBoardingPass.Controls.Add(Me.lblBPSeat)
        Me.pnlBoardingPass.Controls.Add(Me.lblBPClass)
        Me.pnlBoardingPass.Location = New System.Drawing.Point(3, 3)
        Me.pnlBoardingPass.Name = "pnlBoardingPass"
        Me.pnlBoardingPass.Size = New System.Drawing.Size(302, 167)
        Me.pnlBoardingPass.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Airplane_ReservationSystem.My.Resources.Resources.if_resolutions_21_897231
        Me.PictureBox3.Location = New System.Drawing.Point(198, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Airplane_ReservationSystem.My.Resources.Resources._1608570_512
        Me.PictureBox2.Location = New System.Drawing.Point(6, 117)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(293, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'pbSeat10
        '
        Me.pbSeat10.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat10.Location = New System.Drawing.Point(150, 442)
        Me.pbSeat10.Name = "pbSeat10"
        Me.pbSeat10.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat10.TabIndex = 16
        Me.pbSeat10.TabStop = False
        '
        'pbSeat9
        '
        Me.pbSeat9.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat9.Location = New System.Drawing.Point(150, 400)
        Me.pbSeat9.Name = "pbSeat9"
        Me.pbSeat9.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat9.TabIndex = 15
        Me.pbSeat9.TabStop = False
        '
        'pbSeat8
        '
        Me.pbSeat8.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat8.Location = New System.Drawing.Point(150, 358)
        Me.pbSeat8.Name = "pbSeat8"
        Me.pbSeat8.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat8.TabIndex = 14
        Me.pbSeat8.TabStop = False
        '
        'pbSeat7
        '
        Me.pbSeat7.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat7.Location = New System.Drawing.Point(150, 316)
        Me.pbSeat7.Name = "pbSeat7"
        Me.pbSeat7.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat7.TabIndex = 13
        Me.pbSeat7.TabStop = False
        '
        'pbSeat6
        '
        Me.pbSeat6.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat6.Location = New System.Drawing.Point(150, 274)
        Me.pbSeat6.Name = "pbSeat6"
        Me.pbSeat6.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat6.TabIndex = 12
        Me.pbSeat6.TabStop = False
        '
        'pbSeat5
        '
        Me.pbSeat5.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat5.Location = New System.Drawing.Point(150, 232)
        Me.pbSeat5.Name = "pbSeat5"
        Me.pbSeat5.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat5.TabIndex = 11
        Me.pbSeat5.TabStop = False
        '
        'pbSeat4
        '
        Me.pbSeat4.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat4.Location = New System.Drawing.Point(150, 190)
        Me.pbSeat4.Name = "pbSeat4"
        Me.pbSeat4.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat4.TabIndex = 10
        Me.pbSeat4.TabStop = False
        '
        'pbSeat3
        '
        Me.pbSeat3.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat3.Location = New System.Drawing.Point(150, 148)
        Me.pbSeat3.Name = "pbSeat3"
        Me.pbSeat3.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat3.TabIndex = 9
        Me.pbSeat3.TabStop = False
        '
        'pbSeat2
        '
        Me.pbSeat2.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat2.Location = New System.Drawing.Point(150, 106)
        Me.pbSeat2.Name = "pbSeat2"
        Me.pbSeat2.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat2.TabIndex = 8
        Me.pbSeat2.TabStop = False
        '
        'pbSeat1
        '
        Me.pbSeat1.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat1.Location = New System.Drawing.Point(150, 64)
        Me.pbSeat1.Name = "pbSeat1"
        Me.pbSeat1.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat1.TabIndex = 7
        Me.pbSeat1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Airplane_ReservationSystem.My.Resources.Resources._172567_512__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 533)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 597)
        Me.Controls.Add(Me.pnlBP)
        Me.Controls.Add(Me.pbSeat10)
        Me.Controls.Add(Me.pbSeat9)
        Me.Controls.Add(Me.pbSeat8)
        Me.Controls.Add(Me.pbSeat7)
        Me.Controls.Add(Me.pbSeat6)
        Me.Controls.Add(Me.pbSeat5)
        Me.Controls.Add(Me.pbSeat4)
        Me.Controls.Add(Me.pbSeat3)
        Me.Controls.Add(Me.pbSeat2)
        Me.Controls.Add(Me.pbSeat1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rbEco)
        Me.Controls.Add(Me.rbFC)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airline Reservations System"
        Me.pnlBP.ResumeLayout(False)
        Me.pnlBoardingPass.ResumeLayout(False)
        Me.pnlBoardingPass.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSeat1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbFC As RadioButton
    Friend WithEvents rbEco As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlBP As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBPClass As Label
    Friend WithEvents lblBPSeat As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbSeat1 As PictureBox
    Friend WithEvents pbSeat2 As PictureBox
    Friend WithEvents pbSeat3 As PictureBox
    Friend WithEvents pbSeat4 As PictureBox
    Friend WithEvents pbSeat5 As PictureBox
    Friend WithEvents pbSeat6 As PictureBox
    Friend WithEvents pbSeat7 As PictureBox
    Friend WithEvents pbSeat8 As PictureBox
    Friend WithEvents pbSeat9 As PictureBox
    Friend WithEvents pbSeat10 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents pnlBoardingPass As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
