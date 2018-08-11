Public Class clsUtilities
    Public Shared appPath As String = My.Application.Info.DirectoryPath
    Public Shared Sub Main()

        Dim mainForm As New MainForm
        Application.Run(mainForm)

    End Sub
    Public Function GetICOfromFile() As Icon
        'Retrieves an Icon from EXE/DLL
        Dim icon As New Icon("x")

    End Function
    Public Function ZipFiles(sFilenames() As String, sDestinationFile As String)
        'Zip files 
    End Function
    Public Function UnzipFile(sFilename As String, sTargetFolder As String)
        'Unzip a file

    End Function
End Class
