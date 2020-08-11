Public Class Data
    Public Property OSVersionInfo As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ("OS         : " & My.Computer.Info.OSVersion & vbNewLine &
                            "Version    : " & My.Computer.Info.OSVersion & vbNewLine &
                            "Platform   : " & My.Computer.Info.OSPlatform & vbNewLine)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Me.Label3.Text = "Windows 10 version 2004" Then
            MsgBox("Dernière version")
        Else
            MsgBox("Mettre à jour")
        End If
    End Sub
End Class