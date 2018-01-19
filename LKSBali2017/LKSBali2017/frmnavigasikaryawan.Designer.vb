<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmnavigasikaryawan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbwelcome = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 177)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manajemen Master Data"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 145)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(238, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "User Account"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 116)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(238, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Jadwal Ujian"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 87)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(238, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Jurusan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(238, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Calon Siswa"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(238, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Karyawan dan Guru"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbwelcome
        '
        Me.lbwelcome.AutoSize = True
        Me.lbwelcome.Location = New System.Drawing.Point(12, 14)
        Me.lbwelcome.Name = "lbwelcome"
        Me.lbwelcome.Size = New System.Drawing.Size(166, 13)
        Me.lbwelcome.TabIndex = 8
        Me.lbwelcome.Text = "Selamat datang, [ nama dari db ] !"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Location = New System.Drawing.Point(271, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 177)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manajemen Ujian"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(6, 87)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(238, 23)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Laporan Hasil Ujian"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(6, 58)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(238, 23)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Koreksi Hasil Ujian"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(6, 29)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(238, 23)
        Me.Button10.TabIndex = 0
        Me.Button10.Text = "Alokasi Peserta Ujian"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'frmnavigasikaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 231)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbwelcome)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmnavigasikaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beranda Karyawan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lbwelcome As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
