Imports System.Net

Public Class Installthat

    Public Function CheckAddress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


    Private Sub Installthat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Ajour.ShowBalloonTip(500, "Windate - Exécution", "Windate est exécutez en arrière plan. Il peut donc détectez si une mise à jour est disponible.", ToolTipIcon.Info)
    End Sub

    Private Sub Installthat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            End2222few.Show()
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Ajour.MouseDoubleClick
        End2222few.Show()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles Ajour.MouseClick
        Form1.Show()
    End Sub

    Private Sub Erreur_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Erreur.MouseDoubleClick
        End2222few.Show()
    End Sub

    Private Sub Erreur_MouseClick(sender As Object, e As MouseEventArgs) Handles Erreur.MouseClick
        Form1.Show()
    End Sub

    Private Sub Info_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Info.MouseDoubleClick
        End2222few.Show()
    End Sub

    Private Sub Info_MouseClick(sender As Object, e As MouseEventArgs) Handles Info.MouseClick
        Form1.Show()
    End Sub

    Private Sub Avertissement_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Avertissement.MouseDoubleClick
        End2222few.Show()
    End Sub

    Private Sub Avertissement_MouseClick(sender As Object, e As MouseEventArgs) Handles Avertissement.MouseClick
        Form1.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim readValue = My.Computer.Registry.GetValue(
    "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", Nothing)
        Me.Version.Text = "Ver" & readValue

        'Modifier Windows
        If Me.Version.Text = "Ver2004" Then
            Me.Windows.Text = "Non"
        Else
            Me.Windows.Text = "Oui"
        End If

        'Modifier Windate
        If CheckAddress("https://ver101-65.webself.net/") = True Then
            Me.Windate.Text = "Non"
        Else
            Me.Windate.Text = "Oui"
        End If

        If My.Computer.FileSystem.FileExists("%programfiles%\Microsoft\Edge\Application\msedge.exe") Then
            Me.Edge.Text = "Non"
        Else
            Me.Edge.Text = "Oui"
        End If


        If Me.Windows.Text = "Oui" Then
            Me.Ajour.Visible = False
            Me.Avertissement.Visible = True
            Me.Avertissement.ShowBalloonTip(500, "Windate - Mise à jour(s) disponible(s)", "Une/des mise à jour(s) sont disponible(s). Installez les maintenant en cliquant sur l'icône, ""Mise à jours"" et installez les.", ToolTipIcon.Info)
        Else
            If Me.Edge.Text = "Oui" Then
                Me.Ajour.Visible = False
                Me.Avertissement.Visible = True
                Me.Avertissement.ShowBalloonTip(500, "Windate - Mise à jour(s) disponible(s)", "Une/des mise à jour(s) sont disponible(s). Installez les maintenant en cliquant sur l'icône, ""Mise à jours"" et installez les.", ToolTipIcon.Info)
            Else
                If Me.Windate.Text = "Oui" Then
                    Me.Ajour.Visible = False
                    Me.Avertissement.Visible = True
                    Me.Avertissement.ShowBalloonTip(500, "Windate - Mise à jour(s) disponible(s)", "Une/des mise à jour(s) sont disponible(s). Installez les maintenant en cliquant sur l'icône, ""Mise à jours"" et installez les.", ToolTipIcon.Info)
                Else
                    Me.Ajour.Visible = True
                    Me.Avertissement.Visible = False
                End If
            End If
        End If

    End Sub
End Class