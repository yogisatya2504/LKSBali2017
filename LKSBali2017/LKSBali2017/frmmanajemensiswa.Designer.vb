<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanajemensiswa
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
        Me.lbstatus = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbpiljurusan3 = New System.Windows.Forms.ComboBox()
        Me.cbpiljurusan2 = New System.Windows.Forms.ComboBox()
        Me.cbpiljurusan1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtptglpendafataran = New System.Windows.Forms.DateTimePicker()
        Me.btback = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbalamat = New System.Windows.Forms.TextBox()
        Me.tbnotelp = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtptgllahir = New System.Windows.Forms.DateTimePicker()
        Me.tbnamakaryawan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbasalsekolah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbkodependaftaran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bturut = New System.Windows.Forms.Button()
        Me.btcari = New System.Windows.Forms.Button()
        Me.rbdsc = New System.Windows.Forms.RadioButton()
        Me.rbasc = New System.Windows.Forms.RadioButton()
        Me.cburut = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbcari = New System.Windows.Forms.TextBox()
        Me.cbcari = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbstatus
        '
        Me.lbstatus.AutoSize = True
        Me.lbstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstatus.Location = New System.Drawing.Point(456, 571)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(118, 54)
        Me.lbstatus.TabIndex = 93
        Me.lbstatus.Text = "[ Lulus ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[ Tidak Lulus ]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[ Belum Ujian ]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Pilihan Jurusan 3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Pilihan Jurusan 2"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Pilihan Jurusan 1"
        '
        'cbpiljurusan3
        '
        Me.cbpiljurusan3.FormattingEnabled = True
        Me.cbpiljurusan3.Location = New System.Drawing.Point(148, 73)
        Me.cbpiljurusan3.Name = "cbpiljurusan3"
        Me.cbpiljurusan3.Size = New System.Drawing.Size(246, 21)
        Me.cbpiljurusan3.TabIndex = 2
        '
        'cbpiljurusan2
        '
        Me.cbpiljurusan2.FormattingEnabled = True
        Me.cbpiljurusan2.Location = New System.Drawing.Point(148, 46)
        Me.cbpiljurusan2.Name = "cbpiljurusan2"
        Me.cbpiljurusan2.Size = New System.Drawing.Size(246, 21)
        Me.cbpiljurusan2.TabIndex = 1
        '
        'cbpiljurusan1
        '
        Me.cbpiljurusan1.FormattingEnabled = True
        Me.cbpiljurusan1.Location = New System.Drawing.Point(148, 19)
        Me.cbpiljurusan1.Name = "cbpiljurusan1"
        Me.cbpiljurusan1.Size = New System.Drawing.Size(246, 21)
        Me.cbpiljurusan1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(456, 549)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 18)
        Me.Label14.TabIndex = 92
        Me.Label14.Text = "Status Tes Masuk"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cbpiljurusan3)
        Me.GroupBox1.Controls.Add(Me.cbpiljurusan2)
        Me.GroupBox1.Controls.Add(Me.cbpiljurusan1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 568)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 107)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan Jurusan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 548)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Tanggal Pendaftaran"
        '
        'dtptglpendafataran
        '
        Me.dtptglpendafataran.Location = New System.Drawing.Point(169, 542)
        Me.dtptglpendafataran.Name = "dtptglpendafataran"
        Me.dtptglpendafataran.Size = New System.Drawing.Size(252, 20)
        Me.dtptglpendafataran.TabIndex = 15
        '
        'btback
        '
        Me.btback.BackColor = System.Drawing.Color.Silver
        Me.btback.Location = New System.Drawing.Point(466, 432)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(134, 23)
        Me.btback.TabIndex = 20
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(467, 358)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(134, 23)
        Me.bthapus.TabIndex = 19
        Me.bthapus.Text = "Hapus Data"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(467, 332)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(134, 23)
        Me.btsimpan.TabIndex = 18
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(467, 306)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(134, 23)
        Me.btupdate.TabIndex = 17
        Me.btupdate.Text = "Perbaharui Data"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Alamat"
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(169, 360)
        Me.tbalamat.Multiline = True
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(252, 56)
        Me.tbalamat.TabIndex = 9
        '
        'tbnotelp
        '
        Me.tbnotelp.Location = New System.Drawing.Point(169, 448)
        Me.tbnotelp.Name = "tbnotelp"
        Me.tbnotelp.Size = New System.Drawing.Size(252, 20)
        Me.tbnotelp.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 451)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "No. Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 488)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Jenis Kelamin"
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(98, 12)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 13
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(6, 12)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(70, 17)
        Me.rblaki.TabIndex = 12
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki - laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Tanggal Lahir"
        '
        'dtptgllahir
        '
        Me.dtptgllahir.Location = New System.Drawing.Point(169, 422)
        Me.dtptgllahir.Name = "dtptgllahir"
        Me.dtptgllahir.Size = New System.Drawing.Size(252, 20)
        Me.dtptgllahir.TabIndex = 10
        '
        'tbnamakaryawan
        '
        Me.tbnamakaryawan.Location = New System.Drawing.Point(169, 334)
        Me.tbnamakaryawan.Name = "tbnamakaryawan"
        Me.tbnamakaryawan.Size = New System.Drawing.Size(252, 20)
        Me.tbnamakaryawan.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Nama Lengkap"
        '
        'tbasalsekolah
        '
        Me.tbasalsekolah.Location = New System.Drawing.Point(169, 516)
        Me.tbasalsekolah.Name = "tbasalsekolah"
        Me.tbasalsekolah.Size = New System.Drawing.Size(252, 20)
        Me.tbasalsekolah.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 519)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Asal Sekolah"
        '
        'tbkodependaftaran
        '
        Me.tbkodependaftaran.Location = New System.Drawing.Point(169, 308)
        Me.tbkodependaftaran.Name = "tbkodependaftaran"
        Me.tbkodependaftaran.Size = New System.Drawing.Size(252, 20)
        Me.tbkodependaftaran.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Kode Pendaftaran"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(20, 94)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(580, 200)
        Me.dgv.TabIndex = 21
        '
        'bturut
        '
        Me.bturut.Location = New System.Drawing.Point(502, 39)
        Me.bturut.Name = "bturut"
        Me.bturut.Size = New System.Drawing.Size(98, 23)
        Me.bturut.TabIndex = 6
        Me.bturut.Text = "Urutkan"
        Me.bturut.UseVisualStyleBackColor = True
        '
        'btcari
        '
        Me.btcari.Location = New System.Drawing.Point(502, 10)
        Me.btcari.Name = "btcari"
        Me.btcari.Size = New System.Drawing.Size(98, 23)
        Me.btcari.TabIndex = 2
        Me.btcari.Text = "Cari"
        Me.btcari.UseVisualStyleBackColor = True
        '
        'rbdsc
        '
        Me.rbdsc.AutoSize = True
        Me.rbdsc.Location = New System.Drawing.Point(414, 42)
        Me.rbdsc.Name = "rbdsc"
        Me.rbdsc.Size = New System.Drawing.Size(82, 17)
        Me.rbdsc.TabIndex = 5
        Me.rbdsc.TabStop = True
        Me.rbdsc.Text = "Descending"
        Me.rbdsc.UseVisualStyleBackColor = True
        '
        'rbasc
        '
        Me.rbasc.AutoSize = True
        Me.rbasc.Location = New System.Drawing.Point(299, 42)
        Me.rbasc.Name = "rbasc"
        Me.rbasc.Size = New System.Drawing.Size(75, 17)
        Me.rbasc.TabIndex = 4
        Me.rbasc.TabStop = True
        Me.rbasc.Text = "Ascending"
        Me.rbasc.UseVisualStyleBackColor = True
        '
        'cburut
        '
        Me.cburut.FormattingEnabled = True
        Me.cburut.Location = New System.Drawing.Point(95, 41)
        Me.cburut.Name = "cburut"
        Me.cburut.Size = New System.Drawing.Size(198, 21)
        Me.cburut.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Urutkan Data"
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(299, 12)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(197, 20)
        Me.tbcari.TabIndex = 1
        '
        'cbcari
        '
        Me.cbcari.FormattingEnabled = True
        Me.cbcari.Location = New System.Drawing.Point(95, 12)
        Me.cbcari.Name = "cbcari"
        Me.cbcari.Size = New System.Drawing.Size(198, 21)
        Me.cbcari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Cari Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rblaki)
        Me.GroupBox2.Controls.Add(Me.rbperempuan)
        Me.GroupBox2.Location = New System.Drawing.Point(169, 474)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 36)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'frmmanajemensiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 686)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbstatus)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtptglpendafataran)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.tbnotelp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtptgllahir)
        Me.Controls.Add(Me.tbnamakaryawan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbasalsekolah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbkodependaftaran)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.bturut)
        Me.Controls.Add(Me.btcari)
        Me.Controls.Add(Me.rbdsc)
        Me.Controls.Add(Me.rbasc)
        Me.Controls.Add(Me.cburut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbcari)
        Me.Controls.Add(Me.cbcari)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmanajemensiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Siswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbstatus As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbpiljurusan3 As ComboBox
    Friend WithEvents cbpiljurusan2 As ComboBox
    Friend WithEvents cbpiljurusan1 As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtptglpendafataran As DateTimePicker
    Friend WithEvents btback As Button
    Friend WithEvents bthapus As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents btupdate As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents tbalamat As TextBox
    Friend WithEvents tbnotelp As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rbperempuan As RadioButton
    Friend WithEvents rblaki As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents dtptgllahir As DateTimePicker
    Friend WithEvents tbnamakaryawan As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbasalsekolah As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbkodependaftaran As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents bturut As Button
    Friend WithEvents btcari As Button
    Friend WithEvents rbdsc As RadioButton
    Friend WithEvents rbasc As RadioButton
    Friend WithEvents cburut As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbcari As TextBox
    Friend WithEvents cbcari As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
