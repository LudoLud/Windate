Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Net

Public Class Form1

    Public Function CheckAddress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim readValue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", Nothing)
        Me.ToolStripStatusLabel2.Text = "Ver" & readValue
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        WebBrowser1.Visible = False
        PictureBox1.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        PictureBox4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        WebBrowser1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        WebBrowser1.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        WebBrowser1.Visible = True
        PictureBox1.Visible = False
        Label1.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        PictureBox4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Ver()





    End Sub

    Sub Ver()


        If My.Computer.FileSystem.FileExists("%programfiles%\Microsoft\Edge\Application\msedge.exe") Then
            Me.ToolStripStatusLabel2.Visible = False
            Me.Label4.Visible = True
            Me.UpdateEdge.Visible = False
        Else
            Me.Label4.Visible = False
            Me.UpdateEdge.Visible = True

        End If

        '%programfiles%\Microsoft Edge\Edge.exe

        If CheckAddress("https://ver101-65.webself.net/") = True Then
            Me.Label6.Visible = True
            Me.UpdateSoft.Visible = False
        Else
            Me.Label6.Visible = False
            Me.UpdateSoft.Visible = True
        End If



        If Me.ToolStripStatusLabel2.Text = "Ver2004" Then

        Else
            Me.Label3.Visible = False
            Me.UpdateWin.Visible = True
        End If



        If Me.UpdateWin.Visible = True Then
            Installthat.Ajour.Visible = False
            Me.ToolStripStatusLabel1.Visible = True
            Installthat.Avertissement.Visible = True
            Installthat.Avertissement.ShowBalloonTip(500, "Windate - Mise à jour(s) disponible(s)", "Une/des mise à jour(s) sont disponible(s). Installez les maintenant en cliquant sur l'icône, ""Mise à jours"" et installez les.", ToolTipIcon.Info)
        Else
            If Me.UpdateEdge.Visible = True Then
                Installthat.Ajour.Visible = False
                Me.ToolStripStatusLabel1.Visible = True
                Installthat.Avertissement.Visible = True
                Installthat.Avertissement.ShowBalloonTip(500, "Windate - Mise à jour(s) disponible(s)", "Une/des mise à jour(s) sont disponible(s). Installez les maintenant en cliquant sur l'icône, ""Mise à jours"" et installez les.", ToolTipIcon.Info)
            Else
                If Me.UpdateSoft.Visible = True Then
                    Installthat.Ajour.Visible = False
                    Me.ToolStripStatusLabel1.Visible = True
                    Installthat.Avertissement.Visible = True
                    Installthat.Avertissement.ShowBalloonTip(500, "Windate - Mise à jour(s) disponible(s)", "Une/des mise à jour(s) sont disponible(s). Installez les maintenant en cliquant sur l'icône, ""Mise à jours"" et installez les.", ToolTipIcon.Info)
                End If
            End If
        End If
        If UpdateWin.Visible = True Then

        Else
            If UpdateEdge.Visible = True Then

            Else
                If UpdateSoft.Visible = True Then

                Else
                    Me.ToolStripStatusLabel2.Visible = False
                    Installthat.Avertissement.Visible = False
                    Installthat.Ajour.Visible = True
                    Installthat.Ajour.ShowBalloonTip(500, "Windate - Votre ordinateur est à jour", "Votre ordinateur dispose de la dernière version. Vérifiez plus tard.", ToolTipIcon.Info)
                End If
            End If
        End If

        If Me.Label3.Visible = True Then
            If Me.Label4.Visible = True Then
                If Me.Label6.Visible = True Then
                    Me.ToolStripStatusLabel2.Visible = False
                End If
            End If
        End If

    End Sub

    Sub CheckUpdates()
        If UpdateWin.Visible = True Then

        Else
            If UpdateEdge.Visible = True Then

            Else
                If UpdateSoft.Visible = True Then

                Else
                    Installthat.Avertissement.Visible = False
                    Installthat.Ajour.Visible = True
                    Installthat.Ajour.ShowBalloonTip(500, "Windate - Votre ordinateur est à jour", "Votre ordinateur dispose de la dernière version. Vérifiez plus tard.", ToolTipIcon.Info)
                End If
            End If
        End If

        If Me.Label3.Visible = True Then
            If Me.Label4.Visible = True Then
                If Me.Label6.Visible = True Then
                    Me.ToolStripStatusLabel2.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        WebBrowser1.Visible = False
        PictureBox1.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        PictureBox4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button10.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        WebBrowser1.Visible = True
        PictureBox1.Visible = False
        Label1.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        PictureBox4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button10.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Winver_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Visible = True

        PictureBox1.Visible = False
        Label1.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        PictureBox4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button10.Visible = False

        Label11.Visible = False
        Label10.Visible = False
        Button9.Visible = False
        'Label12.Visible = False
        'ComboBox1.Visible = False
        Label13.Visible = False
        ComboBox2.Visible = False

        Label7.Visible = False
        Winver.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        PictureBox5.Visible = False

        UpdateWin.Visible = False
        UpdateEdge.Visible = False
        UpdateSoft.Visible = False

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click


        WebBrowser1.Visible = False

        PictureBox1.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        PictureBox4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button10.Visible = True

        Label11.Visible = False
        Label10.Visible = False
        Button9.Visible = False
        'Label12.Visible = False
        'ComboBox1.Visible = False
        Label13.Visible = False
        ComboBox2.Visible = False

        Label7.Visible = False
        Winver.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        PictureBox5.Visible = False

        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False

        UpdateEdge.Visible = True
        UpdateSoft.Visible = True








        WebBrowser1.Visible = False

        PictureBox1.Visible = True
        Label1.Visible = True
        Label3.Visible = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        Label2.Visible = True
        Label4.Visible = True
        PictureBox4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Button5.Visible = True
        Button6.Visible = True
        Button10.Visible = True

        Label11.Visible = False
        Label10.Visible = False
        Button9.Visible = False
        'Label12.Visible = False
        'ComboBox1.Visible = False
        Label13.Visible = False
        ComboBox2.Visible = False

        Label7.Visible = False
        Winver.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        PictureBox5.Visible = False

        Label3.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        UpdateWin.Visible = False
        UpdateEdge.Visible = False
        UpdateSoft.Visible = False





        Ver2()



    End Sub

    Sub Ver2()

        '%programfiles%\Microsoft Edge\Edge.exe
        If My.Computer.FileSystem.FileExists("%programfiles%\Microsoft\Edge\Application\msedge.exe") Then
            Me.Label4.Visible = True
            Me.UpdateEdge.Visible = False
        Else
            Me.Label4.Visible = False
            Me.UpdateEdge.Visible = True

        End If



        If CheckAddress("https://ver101-65.webself.net/") = True Then
            Me.Label6.Visible = True
            Me.UpdateSoft.Visible = False
        Else
            Me.Label6.Visible = False
            Me.UpdateSoft.Visible = True
        End If



        If Me.ToolStripStatusLabel2.Text = "Ver2004" Then
            Me.Label3.Visible = True
            Me.UpdateWin.Visible = False
        Else
            Me.Label3.Visible = False
            Me.UpdateWin.Visible = True
        End If



        If Me.UpdateWin.Visible = True Then
            Installthat.Ajour.Visible = False
            Me.ToolStripStatusLabel1.Visible = True
            Installthat.Avertissement.Visible = True
        Else
            If Me.UpdateEdge.Visible = True Then
                Installthat.Ajour.Visible = False
                Me.ToolStripStatusLabel1.Visible = True
                Installthat.Avertissement.Visible = True
            Else
                If Me.UpdateSoft.Visible = True Then
                    Installthat.Ajour.Visible = False
                    Me.ToolStripStatusLabel1.Visible = True
                    Installthat.Avertissement.Visible = True
                Else

                End If
            End If
        End If

        If UpdateWin.Visible = True Then

        Else
            If UpdateEdge.Visible = True Then

            Else
                If UpdateSoft.Visible = True Then

                Else
                    Me.ToolStripStatusLabel2.Visible = False
                    Installthat.Avertissement.Visible = False
                    Installthat.Ajour.Visible = True

                End If
            End If
        End If
        ', label4, label6
        If Me.Label3.Visible = False Then
            If Me.Label4.Visible = False Then
                If Me.Label6.Visible = False Then
                    Me.ToolStripStatusLabel2.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click


        WebBrowser1.Visible = False

        PictureBox1.Visible = False
        Label1.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        PictureBox4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button10.Visible = False

        Label11.Visible = True
        Label10.Visible = True
        Button9.Visible = True
        'Label12.Visible = True
        'ComboBox1.Visible = True
        Label13.Visible = True
        ComboBox2.Visible = True

        Label7.Visible = False
        Winver.Visible = False
        Label9.Visible = False
        Label8.Visible = False
        Button7.Visible = False
        Button8.Visible = False
        PictureBox5.Visible = False

        UpdateWin.Visible = False
        UpdateEdge.Visible = False
        UpdateSoft.Visible = False

    End Sub

    Private Sub Button4_Click_2(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Visible = False

        PictureBox1.Visible = False
        Label1.Visible = False
        Label3.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        Label2.Visible = False
        Label4.Visible = False
        PictureBox4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button10.Visible = False

        Label11.Visible = False
        Label10.Visible = False
        Button9.Visible = False
        'Label12.Visible = False
        'ComboBox1.Visible = False
        Label13.Visible = False
        ComboBox2.Visible = False

        Label7.Visible = True
        Winver.Visible = True
        Label9.Visible = True
        Label8.Visible = True
        Button7.Visible = True
        Button8.Visible = True
        PictureBox5.Visible = True

        UpdateWin.Visible = False
        UpdateEdge.Visible = False
        UpdateSoft.Visible = False

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Catalogue.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("Votre liscence est déjà activée où vous utilisez une version antérieur.", MsgBoxStyle.Information, "Activation de Windate")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Github.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If UpdateWin.Visible = True Then
            Windows.Show()
        End If
        If UpdateEdge.Visible = True Then
            Edge.Show()
        End If
        If UpdateSoft.Visible = True Then
            Windate.Show()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
