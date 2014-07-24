Public Class Form1
    Private Sub bstart_Click(sender As Object, e As EventArgs) Handles bstart.Click
        Timer1.Enabled = True
    End Sub

    Private Sub bset_Click(sender As Object, e As EventArgs) Handles bset.Click
        Timer1.Enabled = False
        lbcountdown.Text = Val(tbupdate.Text)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lbcountdown.Text = 1 Then
            lbcountdown.Text = Val(tbupdate.Text)
            Process.Start("c:\praw-rt\1.py")
            Process.Start("c:\praw-rt\2.py")
            lbupdates.Text = lbupdates.Text + 1
        End If

        If lbcountdown.Text = 0 Then
            Timer1.Enabled = False
            lbcountdown.Text = lbcountdown.Text + 1
        End If
        lbcountdown.Text = Val(lbcountdown.Text) - 1
    End Sub

    Private Sub bstop_Click(sender As Object, e As EventArgs) Handles bstop.Click
        Timer1.Enabled = False
        lbcountdown.Text = 0
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

    End Sub
End Class
