Public Class Form1
    Private Server As TCPControl
    Private Client As TCPController


    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Server.IsListening = False
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Server = New TCPControl
        txtChat.Text = ":: SERVER #7 STARTED ::" & vbCrLf

        AddHandler Server.MessageReceived, AddressOf OnLineReceived
    End Sub

    Private Delegate Sub UpdateTextDelegate(TB As TextBox, txt As String)

    Private Sub UpdateText(TB As TextBox, txt As String)
        If TB.InvokeRequired Then
            TB.Invoke(New UpdateTextDelegate(AddressOf UpdateText), New Object() {TB, txt})
        Else
            If txt IsNot Nothing Then TB.AppendText(txt & vbCrLf)
            Try
                If txt = "close()" Then
                    TB.AppendText("Server crashed. Please restart server." & vbCrLf)
                    Timer1.Start()
                End If

                If txt = 1 Then
                    TB.AppendText("Politechnika Swietokrzyska" & vbCrLf)
                End If

                If txt = 2 Then
                    TB.AppendText("Politechnika Swietokrzyska" & vbCrLf)
                End If

                If txt = 3 Then
                    TB.AppendText("Politechnika Swietokrzyska" & vbCrLf)
                End If

                If txt = 4 Then
                    TB.AppendText("Politechnika Świętokrzyska" & vbCrLf)
                End If

                If txt >= 5 Then
                    TB.AppendText("Error ID" & vbCrLf)
                End If



                If txt = 133111 Then
                    Client = New TCPController("127.0.0.1", 13311)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(1)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133112 Then
                    Client = New TCPController("127.0.0.1", 13311)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(2)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133113 Then
                    Client = New TCPController("127.0.0.1", 13311)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(3)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133131 Then
                    Client = New TCPController("127.0.0.1", 13313)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(1)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133132 Then
                    Client = New TCPController("127.0.0.1", 13313)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(2)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133133 Then
                    Client = New TCPController("127.0.0.1", 13313)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(3)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133141 Then
                    Client = New TCPController("127.0.0.1", 13314)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(1)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133142 Then
                    Client = New TCPController("127.0.0.1", 13314)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(2)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133143 Then
                    Client = New TCPController("127.0.0.1", 13314)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(3)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133151 Then
                    Client = New TCPController("127.0.0.1", 13315)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(1)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133152 Then
                    Client = New TCPController("127.0.0.1", 13315)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(2)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133153 Then
                    Client = New TCPController("127.0.0.1", 13315)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(3)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133161 Then
                    Client = New TCPController("127.0.0.1", 13316)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(1)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133162 Then
                    Client = New TCPController("127.0.0.1", 13316)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(2)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133163 Then
                    Client = New TCPController("127.0.0.1", 13316)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(3)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133121 Then
                    Client = New TCPController("127.0.0.1", 13312)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(1)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133122 Then
                    Client = New TCPController("127.0.0.1", 13312)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(2)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If

                If txt = 133123 Then
                    Client = New TCPController("127.0.0.1", 13312)
                    Try
                        If Client.Client.Connected Then
                            If Client.Client.Connected = True Then
                                Client.Send(3)
                                Client.DataStream.Close()
                                Client.Client.Close()
                            End If
                        End If
                    Catch ex As Exception

                    End Try
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub OnLineReceived(sender As TCPControl, Data As String)
        UpdateText(txtChat, Data)
    End Sub

    
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        End
    End Sub
End Class
