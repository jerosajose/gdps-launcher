Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Timer1.Start()
        LaunchNotify.ShowBalloonTip(5)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        System.Diagnostics.Process.Start("https://discord.gg/mK4HVTu")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MsgBox("There aren't mod trials for the server.")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MsgBox("There isn't a staff list yet.")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MsgBox("There isn't a demon list at the moment")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Form4.Show()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        System.Diagnostics.Process.Start(".\runMH.bat")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs)
        Form4.Show()
    End Sub

    Private Sub PictureBox11_Click_1(sender As Object, e As EventArgs) 
        LaunchNotify.ShowBalloonTip(5)
    End Sub

    Private Sub PictureBox11_Click_2(sender As Object, e As EventArgs) Handles PictureBox11.Click
        System.Diagnostics.Process.Start(".\openGameFolder.bat")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            LaunchNotify.Visible = False
        Else
            LaunchNotify.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Label2.Text = "Playing"
        End If
        Label3.Text = ProgressBar1.Value & (" %")
        If ProgressBar1.Value = 100 Then
            Label3.Text = "     "
        End If
        If ProgressBar1.Value = 100 Then
            System.Diagnostics.Process.Start(".\runWGDPS.bat")
            Timer1.Stop()
            ProgressBar1.Value = 0
            Label2.Text = "Play"
            Label3.Text = "     "
        End If
        If ProgressBar1.Value = 100 Then
            System.Diagnostics.Process.Start(".\runWGDPS.bat")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ProgressBar1.Visible = False
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ProgressBar1.Visible = False
            Label3.Visible = False
        Else
            ProgressBar1.Visible = True
            Label3.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start(".\restartLauncher.bat")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DevZoneForm.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Form6.Show()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Label2.Visible = False
        Else
            Label2.Visible = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox3.Checked Then
            If ProgressBar1.Value = 100 Then
                Me.Close()
            End If
        Else

        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        System.Diagnostics.Process.Start("https://www.github.com/Ascript89")
    End Sub

    Private Sub LaunchNotify_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles LaunchNotify.MouseDoubleClick

    End Sub
End Class