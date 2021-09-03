Public Class about
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MsgBox("Not published yet.", vbInformation, "WGDPS")
    End Sub

    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Compile version: " + Application.ProductVersion.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://tiny.one/wgdps")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("https://wyliegdps02.7m.pl/discord")
    End Sub
End Class