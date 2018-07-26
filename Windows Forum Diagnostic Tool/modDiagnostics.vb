Imports System.IO
Module modDiagnostics
    Public Function GetDXDiag() As String

        '/t outfile – save txt information to the outfile And quit
        '/whql[on/off] – allow Or do Not allow dxdiag to check for WQHL digital signature

        Dim fileName As String = Path.GetTempPath + "WF_DXDiag.txt"

        MessageBox.Show(Environment.SystemDirectory + "\dxdiag.exe" + " /t " + """" + fileName + """")

        Dim DXDiag As System.Diagnostics.Process = System.Diagnostics.Process.Start(Environment.SystemDirectory + "\dxdiag.exe", " /t " + """" + fileName + """")
        Dim timeout As Integer = 60000 '1 minute in milliseconds

        If Not DXDiag.WaitForExit(timeout) Then
            MessageBox.Show("DXDiag did not complete in a timely fashion")
            Return "Timeout error collecting DXDiag information"
        Else
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(fileName)

            Return fileReader
        End If
    End Function

End Module
