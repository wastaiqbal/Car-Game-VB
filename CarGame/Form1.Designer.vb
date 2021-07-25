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
        Me.components = New System.ComponentModel.Container()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.LblSpeed = New System.Windows.Forms.Label()
        Me.TimeRoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.TimeRightSide = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLeftSide = New System.Windows.Forms.Timer(Me.components)
        Me.TimeRace1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeRace2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeRace3 = New System.Windows.Forms.Timer(Me.components)
        Me.LblGameover = New System.Windows.Forms.Label()
        Me.BtnReplay = New System.Windows.Forms.Button()
        Me.PicMobilPolisi = New System.Windows.Forms.PictureBox()
        Me.PicMobilHitam = New System.Windows.Forms.PictureBox()
        Me.PicMobilPutih = New System.Windows.Forms.PictureBox()
        Me.PicMobilKuning = New System.Windows.Forms.PictureBox()
        Me.Picjalan6 = New System.Windows.Forms.PictureBox()
        Me.Picjalan5 = New System.Windows.Forms.PictureBox()
        Me.Picjalan4 = New System.Windows.Forms.PictureBox()
        Me.Picjalan3 = New System.Windows.Forms.PictureBox()
        Me.Picjalan2 = New System.Windows.Forms.PictureBox()
        Me.Picjalan1 = New System.Windows.Forms.PictureBox()
        CType(Me.PicMobilPolisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMobilHitam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMobilPutih, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMobilKuning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picjalan6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picjalan5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picjalan4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picjalan3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picjalan2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picjalan1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Location = New System.Drawing.Point(13, 13)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(64, 20)
        Me.LblScore.TabIndex = 6
        Me.LblScore.Text = "Score 0"
        '
        'LblSpeed
        '
        Me.LblSpeed.AutoSize = True
        Me.LblSpeed.Location = New System.Drawing.Point(247, 13)
        Me.LblSpeed.Name = "LblSpeed"
        Me.LblSpeed.Size = New System.Drawing.Size(69, 20)
        Me.LblSpeed.TabIndex = 7
        Me.LblSpeed.Text = "Speed 0"
        '
        'TimeRoadMover
        '
        Me.TimeRoadMover.Enabled = True
        Me.TimeRoadMover.Interval = 10
        '
        'TimeRightSide
        '
        Me.TimeRightSide.Interval = 10
        '
        'TimeLeftSide
        '
        Me.TimeLeftSide.Interval = 10
        '
        'TimeRace1
        '
        Me.TimeRace1.Enabled = True
        Me.TimeRace1.Interval = 10
        '
        'TimeRace2
        '
        Me.TimeRace2.Enabled = True
        Me.TimeRace2.Interval = 10
        '
        'TimeRace3
        '
        Me.TimeRace3.Enabled = True
        Me.TimeRace3.Interval = 10
        '
        'LblGameover
        '
        Me.LblGameover.AutoSize = True
        Me.LblGameover.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblGameover.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameover.Location = New System.Drawing.Point(89, 199)
        Me.LblGameover.Name = "LblGameover"
        Me.LblGameover.Size = New System.Drawing.Size(146, 30)
        Me.LblGameover.TabIndex = 12
        Me.LblGameover.Text = "Game Over"
        Me.LblGameover.Visible = False
        '
        'BtnReplay
        '
        Me.BtnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnReplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReplay.Location = New System.Drawing.Point(115, 255)
        Me.BtnReplay.Name = "BtnReplay"
        Me.BtnReplay.Size = New System.Drawing.Size(83, 33)
        Me.BtnReplay.TabIndex = 13
        Me.BtnReplay.Text = "Replay"
        Me.BtnReplay.UseVisualStyleBackColor = True
        Me.BtnReplay.Visible = False
        '
        'PicMobilPolisi
        '
        Me.PicMobilPolisi.Image = Global.CarGame.My.Resources.Resources._2
        Me.PicMobilPolisi.Location = New System.Drawing.Point(140, 332)
        Me.PicMobilPolisi.Name = "PicMobilPolisi"
        Me.PicMobilPolisi.Size = New System.Drawing.Size(48, 70)
        Me.PicMobilPolisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMobilPolisi.TabIndex = 11
        Me.PicMobilPolisi.TabStop = False
        '
        'PicMobilHitam
        '
        Me.PicMobilHitam.Image = Global.CarGame.My.Resources.Resources._3
        Me.PicMobilHitam.Location = New System.Drawing.Point(255, 112)
        Me.PicMobilHitam.Name = "PicMobilHitam"
        Me.PicMobilHitam.Size = New System.Drawing.Size(48, 70)
        Me.PicMobilHitam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMobilHitam.TabIndex = 10
        Me.PicMobilHitam.TabStop = False
        '
        'PicMobilPutih
        '
        Me.PicMobilPutih.Image = Global.CarGame.My.Resources.Resources._1
        Me.PicMobilPutih.Location = New System.Drawing.Point(140, 92)
        Me.PicMobilPutih.Name = "PicMobilPutih"
        Me.PicMobilPutih.Size = New System.Drawing.Size(48, 70)
        Me.PicMobilPutih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMobilPutih.TabIndex = 9
        Me.PicMobilPutih.TabStop = False
        '
        'PicMobilKuning
        '
        Me.PicMobilKuning.Image = Global.CarGame.My.Resources.Resources._4
        Me.PicMobilKuning.Location = New System.Drawing.Point(17, 112)
        Me.PicMobilKuning.Name = "PicMobilKuning"
        Me.PicMobilKuning.Size = New System.Drawing.Size(48, 70)
        Me.PicMobilKuning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicMobilKuning.TabIndex = 8
        Me.PicMobilKuning.TabStop = False
        '
        'Picjalan6
        '
        Me.Picjalan6.BackColor = System.Drawing.SystemColors.Control
        Me.Picjalan6.Location = New System.Drawing.Point(220, 305)
        Me.Picjalan6.Name = "Picjalan6"
        Me.Picjalan6.Size = New System.Drawing.Size(10, 226)
        Me.Picjalan6.TabIndex = 5
        Me.Picjalan6.TabStop = False
        '
        'Picjalan5
        '
        Me.Picjalan5.BackColor = System.Drawing.SystemColors.Control
        Me.Picjalan5.Location = New System.Drawing.Point(94, 305)
        Me.Picjalan5.Name = "Picjalan5"
        Me.Picjalan5.Size = New System.Drawing.Size(10, 226)
        Me.Picjalan5.TabIndex = 4
        Me.Picjalan5.TabStop = False
        '
        'Picjalan4
        '
        Me.Picjalan4.BackColor = System.Drawing.SystemColors.Control
        Me.Picjalan4.Location = New System.Drawing.Point(220, 127)
        Me.Picjalan4.Name = "Picjalan4"
        Me.Picjalan4.Size = New System.Drawing.Size(10, 151)
        Me.Picjalan4.TabIndex = 3
        Me.Picjalan4.TabStop = False
        '
        'Picjalan3
        '
        Me.Picjalan3.BackColor = System.Drawing.SystemColors.Control
        Me.Picjalan3.Location = New System.Drawing.Point(94, 127)
        Me.Picjalan3.Name = "Picjalan3"
        Me.Picjalan3.Size = New System.Drawing.Size(10, 151)
        Me.Picjalan3.TabIndex = 2
        Me.Picjalan3.TabStop = False
        '
        'Picjalan2
        '
        Me.Picjalan2.BackColor = System.Drawing.SystemColors.Control
        Me.Picjalan2.Location = New System.Drawing.Point(220, -169)
        Me.Picjalan2.Name = "Picjalan2"
        Me.Picjalan2.Size = New System.Drawing.Size(10, 265)
        Me.Picjalan2.TabIndex = 1
        Me.Picjalan2.TabStop = False
        '
        'Picjalan1
        '
        Me.Picjalan1.BackColor = System.Drawing.SystemColors.Control
        Me.Picjalan1.Location = New System.Drawing.Point(94, -169)
        Me.Picjalan1.Name = "Picjalan1"
        Me.Picjalan1.Size = New System.Drawing.Size(10, 265)
        Me.Picjalan1.TabIndex = 0
        Me.Picjalan1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(328, 444)
        Me.Controls.Add(Me.BtnReplay)
        Me.Controls.Add(Me.LblGameover)
        Me.Controls.Add(Me.PicMobilPolisi)
        Me.Controls.Add(Me.PicMobilHitam)
        Me.Controls.Add(Me.PicMobilPutih)
        Me.Controls.Add(Me.PicMobilKuning)
        Me.Controls.Add(Me.LblSpeed)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.Picjalan6)
        Me.Controls.Add(Me.Picjalan5)
        Me.Controls.Add(Me.Picjalan4)
        Me.Controls.Add(Me.Picjalan3)
        Me.Controls.Add(Me.Picjalan2)
        Me.Controls.Add(Me.Picjalan1)
        Me.MaximumSize = New System.Drawing.Size(350, 500)
        Me.MinimumSize = New System.Drawing.Size(350, 500)
        Me.Name = "Form1"
        Me.Text = "CarGame"
        CType(Me.PicMobilPolisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMobilHitam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMobilPutih, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMobilKuning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picjalan6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picjalan5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picjalan4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picjalan3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picjalan2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picjalan1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Picjalan1 As System.Windows.Forms.PictureBox
    Friend WithEvents Picjalan2 As System.Windows.Forms.PictureBox
    Friend WithEvents Picjalan4 As System.Windows.Forms.PictureBox
    Friend WithEvents Picjalan3 As System.Windows.Forms.PictureBox
    Friend WithEvents Picjalan6 As System.Windows.Forms.PictureBox
    Friend WithEvents Picjalan5 As System.Windows.Forms.PictureBox
    Friend WithEvents LblScore As System.Windows.Forms.Label
    Friend WithEvents LblSpeed As System.Windows.Forms.Label
    Friend WithEvents PicMobilKuning As System.Windows.Forms.PictureBox
    Friend WithEvents PicMobilPutih As System.Windows.Forms.PictureBox
    Friend WithEvents PicMobilHitam As System.Windows.Forms.PictureBox
    Friend WithEvents PicMobilPolisi As System.Windows.Forms.PictureBox
    Friend WithEvents TimeRoadMover As System.Windows.Forms.Timer
    Friend WithEvents TimeRightSide As System.Windows.Forms.Timer
    Friend WithEvents TimeLeftSide As System.Windows.Forms.Timer
    Friend WithEvents TimeRace1 As System.Windows.Forms.Timer
    Friend WithEvents TimeRace2 As System.Windows.Forms.Timer
    Friend WithEvents TimeRace3 As System.Windows.Forms.Timer
    Friend WithEvents LblGameover As System.Windows.Forms.Label
    Friend WithEvents BtnReplay As System.Windows.Forms.Button

End Class
