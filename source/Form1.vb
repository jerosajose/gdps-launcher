Public Class Form1

    ' Coded by JerosGamer89 on behalf of WGDPS Software Team
    ' Licensed under the GNU Lesser General Public License v3
    ' August 2021
    ' WGDPS Launcher 3

    ' I think you shouldn't be looking here... -_-

    Dim x As Integer
    Dim y As Integer

    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://wgdps.7m.pl/launcher3/version.txt")
    Dim response As System.Net.HttpWebResponse = request.GetResponse
    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

    Dim newestversion As String = sr.ReadToEnd
    Dim currentversion As String = Application.ProductVersion

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutWGDPSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutWGDPSToolStripMenuItem.Click
        Try
            about.Show()
        Catch ex As Exception
            MsgBox("An internal error ocurred in the launcher. Please do not modify the launcher.
Modifying the launcher can cause this kind of errors. Check the help PDF for more information.", vbCritical, "Error code: 2")
            End
        End Try
    End Sub

    Private Sub OpenGameFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenGameFolderToolStripMenuItem.Click
        System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 1
        If x = 7 Then
            Timer1.Stop()
            System.Diagnostics.Process.Start(Application.StartupPath + "/runmh.bat")
        End If
    End Sub

    Private Sub ContactUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactUsToolStripMenuItem.Click
        MsgBox("Discord: JerosGamer89#0089  or  Wylie#2674", vbInformation, "Support")
    End Sub

    Private Sub QuickSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuickSupportToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("help.pdf")
        Catch ex As Exception
            MsgBox("Could not open the help guide. Please check the file 'help.pdf'
exists. Do not delete/modify files in case you did.", vbCritical, "Error code: 1")
            End
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        If newestversion.Contains(currentversion) Then

        Else
            MsgBox("There's a new update available for the launcher, now the installer will start. Just go through the installer as if you would install it the first time.", vbMsgBoxSetForeground, "Updates")
            If My.Computer.FileSystem.FileExists("C:/Users/Public/setup.msi") Then
                My.Computer.FileSystem.DeleteFile("C:/Users/Public/setup.msi")
            End If

            Try
                My.Computer.Network.DownloadFile("https://wgdps.7m.pl/launcher3/setup.msi", "C:/Users/Public/setup.exe")
                System.Diagnostics.Process.Start("C:/Users/Public/setup.msi")
                End
            Catch ex As Exception
                MsgBox("An error ocurred downloading the new version setup wizard.
This might be due to a downtime of the servers, or a failure of your connection. Please
check you are connected to the internet and 7m.pl servers are operative.", vbCritical, "Error code: 3")
                End
            End Try
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        If newestversion.Contains(currentversion) Then
            MsgBox("No updates available, seems you are using the latest version :)", vbInformation, "Updates")
        Else
            MsgBox("There's a new update available for the launcher, now the installer will start. Just go through the installer as if you would install it the first time.", vbMsgBoxSetForeground, "Updates")
            If My.Computer.FileSystem.FileExists("C:/Users/Public/setup.msi") Then
                My.Computer.FileSystem.DeleteFile("C:/Users/Public/setup.msi")
            End If

            Try
                My.Computer.Network.DownloadFile("https://wgdps.7m.pl/launcher3/setup.msi", "C:/Users/Public/setup.exe")
                System.Diagnostics.Process.Start("C:/Users/Public/setup.msi")
                End
            Catch ex As Exception
                MsgBox("An error ocurred downloading the new version setup wizard.
This might be due to a downtime of the servers, or a failure of your connection. Please
check you are connected to the internet and 7m.pl servers are operative.", vbCritical, "Error code: 3")
                End
            End Try
        End If
    End Sub

    Private Sub ChagelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChagelogToolStripMenuItem.Click
        MsgBox("Version 1.0 - July 2020
Initial release

Version 1.1 - July 2020
Minor fixes

Version 2.0 - August 2020
Fully rewritten UI and launcher code
Minor game fixes
Mega Hack fixed
Added more buttons (someones with utility in a future)
Added a loading screen at the start
Added a loading bar for running game
Added Yoshi :)

Version 2.1 - September 2020
Added Discord Rich Presence for WGDPS
Added Transparent menu BG by Absolute (still in beta, maybe won't work)dded Transparent menu BG by Absolute

Version 2.2 (unreleased)
Minor launcher fixes
Better Discord Rich Presence
New UI

Version 3.0 (this one) - August 2021
Fully rewritten launcher
Improved the updater
Added an installer for updates and new users
New help guide
Better quality UI
Added new logotypes to the design
Changed the whole Discord Rich Presence
+ a trailer
+ a new website", vbInformation, "WGDPS Launcher Changelog")
    End Sub

    Private Sub OpenGDPSToolsPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenGDPSToolsPageToolStripMenuItem.Click
        Try
            tools.Show()
        Catch ex As Exception
            MsgBox("An internal error ocurred in the launcher. Please do not modify the launcher.
Modifying the launcher can cause this kind of errors. Check the help PDF for more information.", vbCritical, "Error code: 2")
            End
        End Try
    End Sub

    Private Sub UpdateCreatorPointsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateCreatorPointsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://wyliegdps02.7m.pl/database/tools/cron/cron.php")
    End Sub

    Private Sub ReuploadALevelToGDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReuploadALevelToGDToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://wyliegdps02.7m.pl/database/tools/levelToGD.php")
    End Sub

    Public Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        y = y + 1
        If y = 5 Then
            PictureBox1.Visible = False
            Label1.Visible = False
        End If
        If y = 14400 Then
            MsgBox("yo, you should consider taking a break, it's been 2 hours :P")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MsgBox("Hey, an easter egg :D
Here's your time elapsed in the launcher.
Close and open the box again to refresh.

Time elapsed: " + y.ToString() + " seconds", vbOKOnly, "Time elapsed")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Try
            about.Show()
        Catch ex As Exception
            MsgBox("An internal error ocurred in the launcher. Please do not modify the launcher.
Modifying the launcher can cause this kind of errors. Check the help PDF for more information.", vbCritical, "Error code: 2")
            End
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            System.Diagnostics.Process.Start("wgdpsbywylie.exe")
        Catch ex As Exception
            MsgBox("Could not open the game. Please check the game is located in the same
folder as the launcher executable, and it's named 'wgdpsbywylie.exe'. Do not modify the launcher in case you did.", vbCritical, "Error code: 1")
            End
        End Try
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Try
            System.Diagnostics.Process.Start("wgdpsbywylie.exe")
        Catch ex As Exception
            MsgBox("Could not open the game. Please check the game is located in the same
folder as the launcher executable, and it's named 'wgdpsbywylie.exe'. Do not modify the launcher in case you did.", vbCritical, "Error code: 1")
            End
        End Try
        Try
            Timer1.Start()
        Catch ex As Exception
            MsgBox("An internal error ocurred in the launcher. Please do not modify the launcher.
Modifying the launcher can cause this kind of errors. Check the help PDF for more information.", vbCritical, "Error code: 2")
            End
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Try
            tools.Show()
        Catch ex As Exception
            MsgBox("An internal error ocurred in the launcher. Please do not modify the launcher.
Modifying the launcher can cause this kind of errors. Check the help PDF for more information.", vbCritical, "Error code: 2")
        End Try
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartGameToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("wgdpsbywylie.exe")
        Catch ex As Exception
            MsgBox("Could not open the game. Please check the game is located in the same
folder as the launcher executable, and it's named 'wgdpsbywylie.exe'. Do not modify the launcher in case you did.", vbCritical, "Error code: 1")
        End Try
    End Sub

    Private Sub OpenMegaHackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMegaHackToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start(Application.StartupPath + "/runmh.bat")
        Catch ex As Exception
            MsgBox("Could not open Mega Hack. To repair this error, please refer to the
help PDF left in the installation, you can access in the launcher at the top bar by clicking
'Help', and so 'FAQ document'. Do not modify the launcher in case you did.", vbCritical, "Error code: 1")
        End Try
    End Sub
End Class
