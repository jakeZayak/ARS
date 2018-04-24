<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.btnAssign = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFlightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.SuspendLayout()
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
        Me.rbFC.Checked = True
        Me.rbFC.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFC.Location = New System.Drawing.Point(16, 69)
        Me.rbFC.Name = "rbFC"
        Me.rbFC.Size = New System.Drawing.Size(146, 36)
        Me.rbFC.TabIndex = 0
        Me.rbFC.TabStop = True
        Me.rbFC.Text = "First Class"
        Me.rbFC.UseVisualStyleBackColor = True
        '
        'rbEco
        '
        Me.rbEco.AutoSize = True
        Me.rbEco.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEco.Location = New System.Drawing.Point(16, 318)
        Me.rbEco.Name = "rbEco"
        Me.rbEco.Size = New System.Drawing.Size(202, 36)
        Me.rbEco.TabIndex = 1
        Me.rbEco.TabStop = True
        Me.rbEco.Text = "Economy Class"
        Me.rbEco.UseVisualStyleBackColor = True
        '
        'btnAssign
        '
        Me.btnAssign.Location = New System.Drawing.Point(12, 585)
        Me.btnAssign.Name = "btnAssign"
        Me.btnAssign.Size = New System.Drawing.Size(461, 40)
        Me.btnAssign.TabIndex = 2
        Me.btnAssign.Text = "Assign Seat"
        Me.btnAssign.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearFlightToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearFlightToolStripMenuItem
        '
        Me.ClearFlightToolStripMenuItem.Name = "ClearFlightToolStripMenuItem"
        Me.ClearFlightToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ClearFlightToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ClearFlightToolStripMenuItem.Text = "Clear Flight"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CreditToolStripMenuItem
        '
        Me.CreditToolStripMenuItem.Name = "CreditToolStripMenuItem"
        Me.CreditToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CreditToolStripMenuItem.Text = "Credit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'pbSeat10
        '
        Me.pbSeat10.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat10.Enabled = False
        Me.pbSeat10.Location = New System.Drawing.Point(224, 486)
        Me.pbSeat10.Name = "pbSeat10"
        Me.pbSeat10.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat10.TabIndex = 16
        Me.pbSeat10.TabStop = False
        '
        'pbSeat9
        '
        Me.pbSeat9.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat9.Enabled = False
        Me.pbSeat9.Location = New System.Drawing.Point(224, 444)
        Me.pbSeat9.Name = "pbSeat9"
        Me.pbSeat9.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat9.TabIndex = 15
        Me.pbSeat9.TabStop = False
        '
        'pbSeat8
        '
        Me.pbSeat8.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat8.Enabled = False
        Me.pbSeat8.Location = New System.Drawing.Point(224, 402)
        Me.pbSeat8.Name = "pbSeat8"
        Me.pbSeat8.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat8.TabIndex = 14
        Me.pbSeat8.TabStop = False
        '
        'pbSeat7
        '
        Me.pbSeat7.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat7.Enabled = False
        Me.pbSeat7.Location = New System.Drawing.Point(224, 360)
        Me.pbSeat7.Name = "pbSeat7"
        Me.pbSeat7.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat7.TabIndex = 13
        Me.pbSeat7.TabStop = False
        '
        'pbSeat6
        '
        Me.pbSeat6.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat6.Enabled = False
        Me.pbSeat6.Location = New System.Drawing.Point(224, 318)
        Me.pbSeat6.Name = "pbSeat6"
        Me.pbSeat6.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat6.TabIndex = 12
        Me.pbSeat6.TabStop = False
        '
        'pbSeat5
        '
        Me.pbSeat5.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat5.Enabled = False
        Me.pbSeat5.Location = New System.Drawing.Point(224, 237)
        Me.pbSeat5.Name = "pbSeat5"
        Me.pbSeat5.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat5.TabIndex = 11
        Me.pbSeat5.TabStop = False
        '
        'pbSeat4
        '
        Me.pbSeat4.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat4.Enabled = False
        Me.pbSeat4.Location = New System.Drawing.Point(224, 195)
        Me.pbSeat4.Name = "pbSeat4"
        Me.pbSeat4.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat4.TabIndex = 10
        Me.pbSeat4.TabStop = False
        '
        'pbSeat3
        '
        Me.pbSeat3.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat3.Enabled = False
        Me.pbSeat3.Location = New System.Drawing.Point(224, 153)
        Me.pbSeat3.Name = "pbSeat3"
        Me.pbSeat3.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat3.TabIndex = 9
        Me.pbSeat3.TabStop = False
        '
        'pbSeat2
        '
        Me.pbSeat2.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat2.Enabled = False
        Me.pbSeat2.Location = New System.Drawing.Point(224, 111)
        Me.pbSeat2.Name = "pbSeat2"
        Me.pbSeat2.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat2.TabIndex = 8
        Me.pbSeat2.TabStop = False
        '
        'pbSeat1
        '
        Me.pbSeat1.BackColor = System.Drawing.Color.YellowGreen
        Me.pbSeat1.Enabled = False
        Me.pbSeat1.Location = New System.Drawing.Point(224, 69)
        Me.pbSeat1.Name = "pbSeat1"
        Me.pbSeat1.Size = New System.Drawing.Size(35, 36)
        Me.pbSeat1.TabIndex = 7
        Me.pbSeat1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Airplane_ReservationSystem.My.Resources.Resources._172567_512__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 552)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AcceptButton = Me.btnAssign
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 632)
        Me.Controls.Add(Me.rbEco)
        Me.Controls.Add(Me.rbFC)
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
        Me.Controls.Add(Me.btnAssign)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Airline Reservations System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents btnAssign As Button
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
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFlightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditToolStripMenuItem As ToolStripMenuItem
End Class
