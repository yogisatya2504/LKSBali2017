<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnavigasiguru
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
        Me.btlogout = New System.Windows.Forms.Button()
        Me.btlihat = New System.Windows.Forms.Button()
        Me.btkoreksi = New System.Windows.Forms.Button()
        Me.lbwelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btlogout
        '
        Me.btlogout.Location = New System.Drawing.Point(174, 140)
        Me.btlogout.Name = "btlogout"
        Me.btlogout.Size = New System.Drawing.Size(75, 23)
        Me.btlogout.TabIndex = 2
        Me.btlogout.Text = "Logout"
        Me.btlogout.UseVisualStyleBackColor = True
        '
        'btlihat
        '
        Me.btlihat.Location = New System.Drawing.Point(15, 85)
        Me.btlihat.Name = "btlihat"
        Me.btlihat.Size = New System.Drawing.Size(234, 49)
        Me.btlihat.TabIndex = 1
        Me.btlihat.Text = "Lihat Hasil Ujian"
        Me.btlihat.UseVisualStyleBackColor = True
        '
        'btkoreksi
        '
        Me.btkoreksi.Location = New System.Drawing.Point(15, 30)
        Me.btkoreksi.Name = "btkoreksi"
        Me.btkoreksi.Size = New System.Drawing.Size(234, 49)
        Me.btkoreksi.TabIndex = 0
        Me.btkoreksi.Text = "Koreksi Hasil Ujian"
        Me.btkoreksi.UseVisualStyleBackColor = True
        '
        'lbwelcome
        '
        Me.lbwelcome.AutoSize = True
        Me.lbwelcome.Location = New System.Drawing.Point(12, 9)
        Me.lbwelcome.Name = "lbwelcome"
        Me.lbwelcome.Size = New System.Drawing.Size(166, 13)
        Me.lbwelcome.TabIndex = 8
        Me.lbwelcome.Text = "Selamat datang, [ nama dari db ] !"
        '
        'frmnavigasiguru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 174)
        Me.Controls.Add(Me.btlogout)
        Me.Controls.Add(Me.btlihat)
        Me.Controls.Add(Me.btkoreksi)
        Me.Controls.Add(Me.lbwelcome)
        Me.Name = "frmnavigasiguru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beranda Guru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btlogout As Button
    Friend WithEvents btlihat As Button
    Friend WithEvents btkoreksi As Button
    Friend WithEvents lbwelcome As Label
End Class
