Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Label2.Visible = False
        Label1.Visible = True
        ProgressBar1.Visible = True
        Timer1.Start()
    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Await Task.Delay(1000)
            ProgressBar1.Visible = False
            Label1.Visible = False
            ToolStrip1.Visible = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        RichTextBox1.Visible = True
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        RichTextBox2.Visible = True
    End Sub

End Class
