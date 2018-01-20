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
        Me.btmanajemenuserakun = New System.Windows.Forms.Button()
        Me.btmanajemenjadwal = New System.Windows.Forms.Button()
        Me.btmanajemenjurusan = New System.Windows.Forms.Button()
        Me.btmanajemensiswa = New System.Windows.Forms.Button()
        Me.btmanajemenkaryawan = New System.Windows.Forms.Button()
        Me.lbwelcome = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btlaporanhasilujian = New System.Windows.Forms.Button()
        Me.btkoreksiujian = New System.Windows.Forms.Button()
        Me.btalokasipesertaujian = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btmanajemenuserakun)
        Me.GroupBox1.Controls.Add(Me.btmanajemenjadwal)
        Me.GroupBox1.Controls.Add(Me.btmanajemenjurusan)
        Me.GroupBox1.Controls.Add(Me.btmanajemensiswa)
        Me.GroupBox1.Controls.Add(Me.btmanajemenkaryawan)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 177)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manajemen Master Data"
        '
        'btmanajemenuserakun
        '
        Me.btmanajemenuserakun.Location = New System.Drawing.Point(6, 145)
        Me.btmanajemenuserakun.Name = "btmanajemenuserakun"
        Me.btmanajemenuserakun.Size = New System.Drawing.Size(238, 23)
        Me.btmanajemenuserakun.TabIndex = 4
        Me.btmanajemenuserakun.Text = "User Account"
        Me.btmanajemenuserakun.UseVisualStyleBackColor = True
        '
        'btmanajemenjadwal
        '
        Me.btmanajemenjadwal.Location = New System.Drawing.Point(6, 116)
        Me.btmanajemenjadwal.Name = "btmanajemenjadwal"
        Me.btmanajemenjadwal.Size = New System.Drawing.Size(238, 23)
        Me.btmanajemenjadwal.TabIndex = 3
        Me.btmanajemenjadwal.Text = "Jadwal Ujian"
        Me.btmanajemenjadwal.UseVisualStyleBackColor = True
        '
        'btmanajemenjurusan
        '
        Me.btmanajemenjurusan.Location = New System.Drawing.Point(6, 87)
        Me.btmanajemenjurusan.Name = "btmanajemenjurusan"
        Me.btmanajemenjurusan.Size = New System.Drawing.Size(238, 23)
        Me.btmanajemenjurusan.TabIndex = 2
        Me.btmanajemenjurusan.Text = "Jurusan"
        Me.btmanajemenjurusan.UseVisualStyleBackColor = True
        '
        'btmanajemensiswa
        '
        Me.btmanajemensiswa.Location = New System.Drawing.Point(6, 58)
        Me.btmanajemensiswa.Name = "btmanajemensiswa"
        Me.btmanajemensiswa.Size = New System.Drawing.Size(238, 23)
        Me.btmanajemensiswa.TabIndex = 1
        Me.btmanajemensiswa.Text = "Calon Siswa"
        Me.btmanajemensiswa.UseVisualStyleBackColor = True
        '
        'btmanajemenkaryawan
        '
        Me.btmanajemenkaryawan.Location = New System.Drawing.Point(6, 29)
        Me.btmanajemenkaryawan.Name = "btmanajemenkaryawan"
        Me.btmanajemenkaryawan.Size = New System.Drawing.Size(238, 23)
        Me.btmanajemenkaryawan.TabIndex = 0
        Me.btmanajemenkaryawan.Text = "Karyawan dan Guru"
        Me.btmanajemenkaryawan.UseVisualStyleBackColor = True
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
        Me.GroupBox2.Controls.Add(Me.btlaporanhasilujian)
        Me.GroupBox2.Controls.Add(Me.btkoreksiujian)
        Me.GroupBox2.Controls.Add(Me.btalokasipesertaujian)
        Me.GroupBox2.Location = New System.Drawing.Point(271, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(250, 177)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manajemen Ujian"
        '
        'btlaporanhasilujian
        '
        Me.btlaporanhasilujian.Location = New System.Drawing.Point(6, 87)
        Me.btlaporanhasilujian.Name = "btlaporanhasilujian"
        Me.btlaporanhasilujian.Size = New System.Drawing.Size(238, 23)
        Me.btlaporanhasilujian.TabIndex = 2
        Me.btlaporanhasilujian.Text = "Laporan Hasil Ujian"
        Me.btlaporanhasilujian.UseVisualStyleBackColor = True
        '
        'btkoreksiujian
        '
        Me.btkoreksiujian.Location = New System.Drawing.Point(6, 58)
        Me.btkoreksiujian.Name = "btkoreksiujian"
        Me.btkoreksiujian.Size = New System.Drawing.Size(238, 23)
        Me.btkoreksiujian.TabIndex = 1
        Me.btkoreksiujian.Text = "Koreksi Hasil Ujian"
        Me.btkoreksiujian.UseVisualStyleBackColor = True
        '
        'btalokasipesertaujian
        '
        Me.btalokasipesertaujian.Location = New System.Drawing.Point(6, 29)
        Me.btalokasipesertaujian.Name = "btalokasipesertaujian"
        Me.btalokasipesertaujian.Size = New System.Drawing.Size(238, 23)
        Me.btalokasipesertaujian.TabIndex = 0
        Me.btalokasipesertaujian.Text = "Alokasi Peserta Ujian"
        Me.btalokasipesertaujian.UseVisualStyleBackColor = True
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
    Friend WithEvents btmanajemenuserakun As Button
    Friend WithEvents btmanajemenjadwal As Button
    Friend WithEvents btmanajemenjurusan As Button
    Friend WithEvents btmanajemensiswa As Button
    Friend WithEvents btmanajemenkaryawan As Button
    Friend WithEvents lbwelcome As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btlaporanhasilujian As Button
    Friend WithEvents btkoreksiujian As Button
    Friend WithEvents btalokasipesertaujian As Button
End Class
