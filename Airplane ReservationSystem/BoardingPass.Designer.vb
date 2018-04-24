<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoardingPass
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
        Me.pnlBP = New System.Windows.Forms.Panel()
        Me.pnlBoardingPass = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBPSeat = New System.Windows.Forms.Label()
        Me.lblBPClass = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnlBP.SuspendLayout()
        Me.pnlBoardingPass.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBP
        '
        Me.pnlBP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBP.Controls.Add(Me.pnlBoardingPass)
        Me.pnlBP.Controls.Add(Me.btnPrint)
        Me.pnlBP.Controls.Add(Me.btnClose)
        Me.pnlBP.Location = New System.Drawing.Point(4, 3)
        Me.pnlBP.Name = "pnlBP"
        Me.pnlBP.Size = New System.Drawing.Size(545, 444)
        Me.pnlBP.TabIndex = 6
        '
        'pnlBoardingPass
        '
        Me.pnlBoardingPass.BackColor = System.Drawing.Color.White
        Me.pnlBoardingPass.Controls.Add(Me.PictureBox3)
        Me.pnlBoardingPass.Controls.Add(Me.PictureBox2)
        Me.pnlBoardingPass.Controls.Add(Me.Label4)
        Me.pnlBoardingPass.Controls.Add(Me.lblBPSeat)
        Me.pnlBoardingPass.Controls.Add(Me.lblBPClass)
        Me.pnlBoardingPass.Location = New System.Drawing.Point(3, 3)
        Me.pnlBoardingPass.Name = "pnlBoardingPass"
        Me.pnlBoardingPass.Size = New System.Drawing.Size(535, 326)
        Me.pnlBoardingPass.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Airplane_ReservationSystem.My.Resources.Resources.if_resolutions_21_897231
        Me.PictureBox3.Location = New System.Drawing.Point(290, 8)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(238, 225)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.Airplane_ReservationSystem.My.Resources.Resources._1608570_512
        Me.PictureBox2.Location = New System.Drawing.Point(8, 270)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(520, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(267, 50)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Boarding Pass"
        '
        'lblBPSeat
        '
        Me.lblBPSeat.AutoSize = True
        Me.lblBPSeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBPSeat.Location = New System.Drawing.Point(12, 238)
        Me.lblBPSeat.Name = "lblBPSeat"
        Me.lblBPSeat.Size = New System.Drawing.Size(194, 29)
        Me.lblBPSeat.TabIndex = 7
        Me.lblBPSeat.Text = "Seat Number: 1"
        '
        'lblBPClass
        '
        Me.lblBPClass.AutoSize = True
        Me.lblBPClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBPClass.Location = New System.Drawing.Point(287, 246)
        Me.lblBPClass.Name = "lblBPClass"
        Me.lblBPClass.Size = New System.Drawing.Size(79, 18)
        Me.lblBPClass.TabIndex = 8
        Me.lblBPClass.Text = "First Class"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(333, 359)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(133, 39)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(59, 359)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(131, 39)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'BoardingPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 450)
        Me.Controls.Add(Me.pnlBP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "BoardingPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoardingPass"
        Me.pnlBP.ResumeLayout(False)
        Me.pnlBoardingPass.ResumeLayout(False)
        Me.pnlBoardingPass.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlBP As Panel
    Friend WithEvents pnlBoardingPass As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblBPSeat As Label
    Friend WithEvents lblBPClass As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
