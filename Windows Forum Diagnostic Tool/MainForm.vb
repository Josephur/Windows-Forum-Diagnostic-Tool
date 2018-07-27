Public Class MainForm
    Private Sub cmdDXDiag_Click(sender As Object, e As EventArgs) Handles cmdDXDiag.Click
        txtOutput.AppendText(GetDXDiag)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Application.ProductName & " v" & Application.ProductVersion
    End Sub

    Private Sub cmdMGADiag_Click(sender As Object, e As EventArgs) Handles cmdMGADiag.Click

        'Win7/8 Need to download http://download.microsoft.com/download/9/F/3/9F3DED28-A521-4352-B8A4-20368D0CC1AA/MGADiag.exe

        'Win10 Perhaps nab slmgr.vbs /dlv?
    End Sub

    Private Sub cmdMSInfo32_Click(sender As Object, e As EventArgs) Handles cmdMSInfo32.Click
        txtOutput.AppendText(GetMSInfo32)
    End Sub
End Class
