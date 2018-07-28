Imports System.Net
Module modNetworking

    'Need functions to: Download file (if remote size/date is different than local)
    'Download needed files in background when app is idle, keep track of download state

    'Grab IP/DNS/Network Components status


    Public Function DoGetHostEntry(hostName) As [String]

        Dim host As IPHostEntry = Dns.GetHostEntry(hostName)

        Dim addresses As String = vbNullString

        Dim ip As IPAddress() = host.AddressList

        Dim index As Integer
        For index = 0 To ip.Length - 1
            addresses = addresses & ", " & ip(index).ToString
        Next index

        Return addresses
    End Function

End Module
