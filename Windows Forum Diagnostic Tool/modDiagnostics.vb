Imports System.IO
Module modDiagnostics
    Public Function GetDXDiag() As String

        '/t outfile – save txt information to the outfile And quit
        '/whql[on/off] – allow Or do Not allow dxdiag to check for WQHL digital signature

        Dim fileName As String = Path.GetTempPath + "WF_DXDiag.txt"

        'MessageBox.Show(Environment.SystemDirectory + "\dxdiag.exe" + " /t " + """" + fileName + """")

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
    Public Function GetCPUZ() As String
        'cpuz.exe -txt=cpuz
        Dim fileName As String = clsUtilities.appPath + "\downloads\cpuz.txt"

        Dim CPUZ As System.Diagnostics.Process = System.Diagnostics.Process.Start(clsUtilities.appPath + "\downloads\cpuz.exe", "-txt=cpuz")
        Dim timeout As Integer = 60000 '1 minute in milliseconds

        If Not CPUZ.WaitForExit(timeout) Then
            MessageBox.Show("CPU-Z did not complete in a timely fashion")
            Return "Timeout error collecting CPU-Z information"
        Else
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(fileName)

            Return fileReader
        End If


    End Function

    Public Function GetMSInfo32() As String
        'msinfo32.exe /nfo file.nfo
        Dim fileName As String = Path.GetTempPath + "WF_MSInfo32.nfo"

        'MessageBox.Show(Environment.SystemDirectory + "\msinfo32.exe" + " /nfo " + """" + fileName + """")

        Dim MSInfo32 As System.Diagnostics.Process = System.Diagnostics.Process.Start(Environment.SystemDirectory + "\msinfo32.exe", " /nfo " + """" + fileName + """")
        Dim timeout As Integer = 60000 '1 minute in milliseconds

        If Not MSInfo32.WaitForExit(timeout) Then
            MessageBox.Show("MSINfo32 did not complete in a timely fashion")
            Return "Timeout error collecting MSInfo32 information"
        Else
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(fileName)

            Return fileReader
        End If

    End Function
    Public Function GetHosts() As String
        Dim filename As String = Environment.SystemDirectory + "\drivers\etc\hosts"

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText(filename)

        Return fileReader
    End Function

End Module
