Public Class Form1
    Private Client As TCPControl

    Private type = "submit"
    Private key = "klucz"

    Private link

    Private Sub cmdSend_Click(sender As System.Object, e As System.EventArgs) Handles cmdSend.Click
        SendMessage()
        txtMessage.Clear()
        txtMessage.Focus()
    End Sub

    Private Sub cmdConnect_Click(sender As System.Object, e As System.EventArgs) Handles cmdConnect.Click
        Client = New TCPControl("127.0.0.1", 13311)
        Try
            If Client.Client.Connected Then
                Timer1.Start()
            End If
        Catch ex As Exception
            ProgressBar1.Value = 0
            Label9.Text = "Not connection"
            Label9.BackColor = Color.Red
        End Try

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Client.Client.Connected = True Then
                Client.DataStream.Close()
                Client.Client.Close()
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = Keys.Enter Then SendMessage()
    End Sub

    Private Sub SendMessage()
        If Client.Client.Connected = True Then Client.Send(txtMessage.Text)
    End Sub

    Private Sub ChooseServer()
        Client.Client.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Label9.Text = "Connected"
            Label9.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Client = New TCPControl("127.0.0.1", 13312)
        Try
            If Client.Client.Connected Then
                Timer2.Start()
            End If
        Catch ex As Exception
            ProgressBar2.Value = 0
            Label10.Text = "Not connection"
            Label10.BackColor = Color.Red
        End Try

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(10)
        If ProgressBar2.Value = 100 Then
            Timer2.Stop()
            Label10.Text = "Connected"
            Label10.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            ChooseServer()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        ProgressBar3.Increment(10)
        If ProgressBar3.Value = 100 Then
            Timer3.Stop()
            Label11.Text = "Connected"
            Label11.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Client = New TCPControl("127.0.0.1", 13313)
        Try
            If Client.Client.Connected Then
                Timer3.Start()
            End If
        Catch ex As Exception
            ProgressBar3.Value = 0
            Label11.Text = "Not connection"
            Label11.BackColor = Color.Red
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Client = New TCPControl("127.0.0.1", 13314)
        Try
            If Client.Client.Connected Then
                Timer4.Start()
            End If
        Catch ex As Exception
            ProgressBar4.Value = 0
            Label12.Text = "Not connection"
            Label12.BackColor = Color.Red
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Client = New TCPControl("127.0.0.1", 13315)
        Try
            If Client.Client.Connected Then
                Timer5.Start()
            End If
        Catch ex As Exception
            ProgressBar5.Value = 0
            Label13.Text = "Not connection"
            Label13.BackColor = Color.Red
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Client = New TCPControl("127.0.0.1", 13316)
        Try
            If Client.Client.Connected Then
                Timer6.Start()
            End If
        Catch ex As Exception
            ProgressBar6.Value = 0
            Label14.Text = "Not connection"
            Label14.BackColor = Color.Red
        End Try
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Client = New TCPControl("127.0.0.1", 13317)
        Try
            If Client.Client.Connected Then
                Timer7.Start()
            End If
        Catch ex As Exception
            ProgressBar7.Value = 0
            Label15.Text = "Not connection"
            Label15.BackColor = Color.Red
        End Try
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        ProgressBar4.Increment(10)
        If ProgressBar4.Value = 100 Then
            Timer4.Stop()
            Label12.Text = "Connected"
            Label12.BackColor = Color.Green
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        ProgressBar5.Increment(10)
        If ProgressBar5.Value = 100 Then
            Timer5.Stop()
            Label13.Text = "Connected"
            Label13.BackColor = Color.Green
        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        ProgressBar6.Increment(10)
        If ProgressBar6.Value = 100 Then
            Timer6.Stop()
            Label14.Text = "Connected"
            Label14.BackColor = Color.Green
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        ProgressBar7.Increment(10)
        If ProgressBar7.Value = 100 Then
            Timer7.Stop()
            Label15.Text = "Connected"
            Label15.BackColor = Color.Green
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click

        Dim k As Long

        For k = 13311 To 13317
            Client = New TCPControl("127.0.0.1", k)
            Try
                If Client.Client.Connected Then
                    SendMessage()
                    Client.Client.Close()
                Else
                    Client.Client.Close()
                End If
            Catch ex As Exception

            End Try
        Next k
                            
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim k As Long
        Dim getID As Long

        For k = 13311 To 13317
            Client = New TCPControl("127.0.0.1", k)
            Try
                If Client.Client.Connected Then
                    Client.Client.Close()
                Else
                    Client.Client.Close()
                End If
            Catch ex As Exception
                getID = getID + 1
            End Try
        Next k
        MsgBox(getID)

        If getID >= 4 Then
            MsgBox("Unconfirmed")
        Else
            MsgBox("Confirmed")
            For k = 13311 To 13317
                Client = New TCPControl("127.0.0.1", k)
                Try
                    If Client.Client.Connected Then
                        SendMessage()
                        Client.Client.Close()
                    Else
                        Client.Client.Close()
                    End If
                Catch ex As Exception

                End Try
            Next k
        End If
    End Sub


    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then

            For Each jeden As HtmlElement In WebBrowser1.Document.GetElementsByTagName("input")

                If jeden.GetAttribute("type") = type Then

                    If jeden.GetAttribute("name") = key Then
                        Try
                            MsgBox("License active")
                        Catch ex As Exception

                        End Try
                    Else
                        MsgBox("Invalid license")
                        End
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer8.Start()
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        Timer8.Stop()
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then

            For Each jeden As HtmlElement In WebBrowser1.Document.GetElementsByTagName("input")

                If jeden.GetAttribute("type") = type Then

                    If jeden.GetAttribute("name") = key Then
                        Try
                            MsgBox("License correct")
                        Catch ex As Exception

                        End Try
                    Else
                        MsgBox("Invalid license")
                        End
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        link = txtMessage.Text

        Try
            My.Computer.Network.DownloadFile(link, "C:\" + TextBox1.Text + ".rar")
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        Process.Start("C:\Users\makab\Desktop\Project - 2PC\TCPServerClean1\TCPServerClean\bin\Debug\TCPServerClean.exe")
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        Process.Start("C:\Users\makab\Desktop\Project - 2PC\TCPServerClean2\TCPServerClean\bin\Debug\TCPServerClean.exe")
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        Process.Start("C:\Users\makab\Desktop\Project - 2PC\TCPServerClean3\TCPServerClean\bin\Debug\TCPServerClean.exe")
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        Process.Start("C:\Users\makab\Desktop\Project - 2PC\TCPServerClean4\TCPServerClean\bin\Debug\TCPServerClean.exe")
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        Process.Start("C:\Users\makab\Desktop\Project - 2PC\TCPServerClean5\TCPServerClean\bin\Debug\TCPServerClean.exe")
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        Process.Start("C:\Users\makab\Desktop\Project - 2PC\TCPServerClean6\TCPServerClean\bin\Debug\TCPServerClean.exe")
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        Process.Start("C:\Users\makab\Desktop\Project - 2PC\TCPServerClean7\TCPServerClean\bin\Debug\TCPServerClean.exe")
    End Sub
End Class
