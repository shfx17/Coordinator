﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(16, 15)
        Me.txtChat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(465, 384)
        Me.txtChat.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 415)
        Me.Controls.Add(Me.txtChat)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Server"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChat As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
