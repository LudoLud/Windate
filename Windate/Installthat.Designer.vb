<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Installthat
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Installthat))
        Me.Ajour = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Erreur = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Info = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Avertissement = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Version = New System.Windows.Forms.Label()
        Me.Windows = New System.Windows.Forms.Label()
        Me.Edge = New System.Windows.Forms.Label()
        Me.Windate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Ajour
        '
        Me.Ajour.Icon = CType(resources.GetObject("Ajour.Icon"), System.Drawing.Icon)
        Me.Ajour.Text = "Windate - L'ordinateur est à jours"
        Me.Ajour.Visible = True
        '
        'Erreur
        '
        Me.Erreur.Icon = CType(resources.GetObject("Erreur.Icon"), System.Drawing.Icon)
        Me.Erreur.Text = "Windate - L'ordinateur présente des risques"
        '
        'Info
        '
        Me.Info.Icon = CType(resources.GetObject("Info.Icon"), System.Drawing.Icon)
        Me.Info.Text = "Windate - Il y a des informations que vous devez voir"
        '
        'Avertissement
        '
        Me.Avertissement.Icon = CType(resources.GetObject("Avertissement.Icon"), System.Drawing.Icon)
        Me.Avertissement.Text = "Windate - Une/des mise à jour(s) est/sont disponible(s)"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1200000
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.ForeColor = System.Drawing.Color.White
        Me.Version.Location = New System.Drawing.Point(12, 67)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(42, 13)
        Me.Version.TabIndex = 0
        Me.Version.Text = "Version"
        '
        'Windows
        '
        Me.Windows.AutoSize = True
        Me.Windows.ForeColor = System.Drawing.Color.White
        Me.Windows.Location = New System.Drawing.Point(57, 67)
        Me.Windows.Name = "Windows"
        Me.Windows.Size = New System.Drawing.Size(51, 13)
        Me.Windows.TabIndex = 1
        Me.Windows.Text = "Windows"
        '
        'Edge
        '
        Me.Edge.AutoSize = True
        Me.Edge.ForeColor = System.Drawing.Color.White
        Me.Edge.Location = New System.Drawing.Point(114, 67)
        Me.Edge.Name = "Edge"
        Me.Edge.Size = New System.Drawing.Size(32, 13)
        Me.Edge.TabIndex = 2
        Me.Edge.Text = "Edge"
        '
        'Windate
        '
        Me.Windate.AutoSize = True
        Me.Windate.ForeColor = System.Drawing.Color.White
        Me.Windate.Location = New System.Drawing.Point(152, 67)
        Me.Windate.Name = "Windate"
        Me.Windate.Size = New System.Drawing.Size(47, 13)
        Me.Windate.TabIndex = 3
        Me.Windate.Text = "Windate"
        '
        'Installthat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(210, 89)
        Me.Controls.Add(Me.Windate)
        Me.Controls.Add(Me.Edge)
        Me.Controls.Add(Me.Windows)
        Me.Controls.Add(Me.Version)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Installthat"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windate - Mise à jour"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ajour As NotifyIcon
    Friend WithEvents Erreur As NotifyIcon
    Friend WithEvents Info As NotifyIcon
    Friend WithEvents Avertissement As NotifyIcon
    Friend WithEvents Version As Label
    Friend WithEvents Windows As Label
    Friend WithEvents Edge As Label
    Friend WithEvents Windate As Label
    Friend WithEvents Timer1 As Timer
End Class
