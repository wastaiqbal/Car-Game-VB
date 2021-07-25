Public Class Form1
    Dim speed As Integer
    Dim road(5) As PictureBox
    Dim score As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = Picjalan1
        road(1) = Picjalan2
        road(2) = Picjalan3
        road(3) = Picjalan4
        road(4) = Picjalan5
        road(5) = Picjalan6
    End Sub

    Private Sub TimeRoadMover_Tick(sender As System.Object, e As System.EventArgs) Handles TimeRoadMover.Tick
        For x As Integer = 0 To 5
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

        If score > 10 And score < 30 Then
            speed = 5
        End If
        If score > 30 And score < 50 Then
            speed = 6
        End If
        If score > 50 And score < 70 Then
            speed = 7
        End If
        If score > 100 Then
            speed = 9
        End If

        LblSpeed.Text = "Speed" & speed
        If (PicMobilPolisi.Bounds.IntersectsWith(PicMobilPutih.Bounds)) Then
            endgame()
        End If
        If (PicMobilPolisi.Bounds.IntersectsWith(PicMobilKuning.Bounds)) Then
            endgame()
        End If
        If (PicMobilPolisi.Bounds.IntersectsWith(PicMobilHitam.Bounds)) Then
            endgame()
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            TimeRightSide.Start()
        End If

        If e.KeyCode = Keys.Left Then
            TimeLeftSide.Start()
        End If
    End Sub

    Private Sub TimeRightSide_Tick(sender As System.Object, e As System.EventArgs) Handles TimeRightSide.Tick
        If (PicMobilPolisi.Location.X < 190) Then
            PicMobilPolisi.Left += 5
        End If
    End Sub

    Private Sub TimeLeftSide_Tick(sender As System.Object, e As System.EventArgs) Handles TimeLeftSide.Tick
        If (PicMobilPolisi.Location.X > 0) Then
            PicMobilPolisi.Left -= 5
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        TimeLeftSide.Stop()
        TimeRightSide.Stop()
    End Sub

    Private Sub endgame()
        BtnReplay.Visible = True
        LblGameover.Visible = True
        TimeRoadMover.Stop()
        TimeRace1.Stop()
        TimeRace2.Stop()
        TimeRace3.Stop()
    End Sub

    Private Sub TimeRace1_Tick(sender As System.Object, e As System.EventArgs) Handles TimeRace1.Tick
        PicMobilHitam.Top += speed / 2
        If PicMobilHitam.Top >= Me.Height Then
            score += 1
            LblScore.Text = "Score" & score

            PicMobilHitam.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + PicMobilHitam.Height)
            PicMobilHitam.Left = CInt(Math.Ceiling(Rnd() * 50)) + 5
        End If
    End Sub

    Private Sub TimeRace2_Tick(sender As System.Object, e As System.EventArgs) Handles TimeRace2.Tick
        PicMobilPutih.Top += speed / 3
        If PicMobilPutih.Top >= Me.Height Then
            score += 1
            LblScore.Text = "Score" & score

            PicMobilPutih.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + PicMobilPutih.Height)
            PicMobilPutih.Left = CInt(Math.Ceiling(Rnd() * 50)) + 50
        End If
    End Sub

    Private Sub TimeRace3_Tick(sender As System.Object, e As System.EventArgs) Handles TimeRace3.Tick
        PicMobilKuning.Top += speed * 1 / 2
        If PicMobilKuning.Top >= Me.Height Then
            score += 1
            LblScore.Text = "Score" & score

            PicMobilKuning.Top = -(CInt(Math.Ceiling(Rnd() * 200)) + PicMobilKuning.Height)
            PicMobilKuning.Left = CInt(Math.Ceiling(Rnd() * 50)) + 140
        End If
    End Sub

    Private Sub BtnReplay_Click(sender As System.Object, e As System.EventArgs) Handles BtnReplay.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
