﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viewer
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AlbumCover = New System.Windows.Forms.PictureBox()
        Me.TrackLabel = New System.Windows.Forms.Label()
        Me.ArtistLabel = New System.Windows.Forms.Label()
        Me.AlbumLabel = New System.Windows.Forms.Label()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        CType(Me.AlbumCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlbumCover
        '
        Me.AlbumCover.Location = New System.Drawing.Point(23, 18)
        Me.AlbumCover.Name = "AlbumCover"
        Me.AlbumCover.Size = New System.Drawing.Size(130, 130)
        Me.AlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlbumCover.TabIndex = 0
        Me.AlbumCover.TabStop = False
        '
        'TrackLabel
        '
        Me.TrackLabel.AutoSize = True
        Me.TrackLabel.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.TrackLabel.Location = New System.Drawing.Point(166, 26)
        Me.TrackLabel.Name = "TrackLabel"
        Me.TrackLabel.Size = New System.Drawing.Size(205, 33)
        Me.TrackLabel.TabIndex = 4
        Me.TrackLabel.Text = "<< Track Name >>"
        '
        'ArtistLabel
        '
        Me.ArtistLabel.AutoSize = True
        Me.ArtistLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.ArtistLabel.Location = New System.Drawing.Point(167, 63)
        Me.ArtistLabel.Name = "ArtistLabel"
        Me.ArtistLabel.Size = New System.Drawing.Size(163, 26)
        Me.ArtistLabel.TabIndex = 5
        Me.ArtistLabel.Text = "<< Track Name >>"
        '
        'AlbumLabel
        '
        Me.AlbumLabel.AutoSize = True
        Me.AlbumLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlbumLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.AlbumLabel.Location = New System.Drawing.Point(168, 96)
        Me.AlbumLabel.Name = "AlbumLabel"
        Me.AlbumLabel.Size = New System.Drawing.Size(144, 23)
        Me.AlbumLabel.TabIndex = 6
        Me.AlbumLabel.Text = "<< Track Name >>"
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Location = New System.Drawing.Point(172, 131)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(250, 10)
        Me.MetroProgressBar1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroProgressBar1.TabIndex = 7
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroProgressBar1)
        Me.Controls.Add(Me.AlbumLabel)
        Me.Controls.Add(Me.ArtistLabel)
        Me.Controls.Add(Me.TrackLabel)
        Me.Controls.Add(Me.AlbumCover)
        Me.DisplayHeader = False
        Me.Name = "Viewer"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Spotify Player Viewer"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.AlbumCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AlbumCover As PictureBox
    Friend WithEvents TrackLabel As Label
    Friend WithEvents ArtistLabel As Label
    Friend WithEvents AlbumLabel As Label
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
End Class