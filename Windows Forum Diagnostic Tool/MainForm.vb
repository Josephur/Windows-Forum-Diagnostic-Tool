Public Class MainForm
    Private Sub cmdDXDiag_Click(sender As Object, e As EventArgs) Handles cmdDXDiag.Click
        txtOutput.Text = GetDXDiag()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " v" & Application.ProductVersion
    End Sub
End Class
