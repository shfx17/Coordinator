Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class TCPController
    Public Client As TcpClient
    Public DataStream As StreamWriter

    Public Sub New(Host As String, Port As Integer)
        Try
            Client = New TcpClient(Host, Port)
            DataStream = New StreamWriter(Client.GetStream)
        Catch ex As Exception

        End Try

    End Sub

    Public Sub Send(Data As String)
        DataStream.Write(Data & vbCrLf)
        DataStream.Flush()
    End Sub
End Class
