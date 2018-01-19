<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistrasisiswa
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
        Me.btsubmit = New System.Windows.Forms.Button()
        Me.lbkode = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbpiljurusan3 = New System.Windows.Forms.ComboBox()
        Me.cbpiljurusan2 = New System.Windows.Forms.ComboBox()
        Me.cbpiljurusan1 = New System.Windows.Forms.ComboBox()
        Me.tbkode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbasalsekolah = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.tbnotelp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtptgllahir = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbalamat = New System.Windows.Forms.TextBox()
        Me.tbnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btback = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btsubmit
        '
        Me.btsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsubmit.Location = New System.Drawing.Point(288, 381)
        Me.btsubmit.Name = "btsubmit"
        Me.btsubmit.Size = New System.Drawing.Size(96, 40)
        Me.btsubmit.TabIndex = 9
        Me.btsubmit.Text = "Daftar"
        Me.btsubmit.UseVisualStyleBackColor = True
        '
        'lbkode
        '
        Me.lbkode.AutoSize = True
        Me.lbkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbkode.Location = New System.Drawing.Point(13, 402)
        Me.lbkode.Name = "lbkode"
        Me.lbkode.Size = New System.Drawing.Size(102, 16)
        Me.lbkode.TabIndex = 40
        Me.lbkode.Text = "[Rnd 10 Char]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(269, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Masukkan kode berikut untuk melanjutkan pendaftaran"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Pilihan Jurusan 3"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Pilihan Jurusan 2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pilihan Jurusan 1"
        '
        'cbpiljurusan3
        '
        Me.cbpiljurusan3.FormattingEnabled = True
        Me.cbpiljurusan3.Location = New System.Drawing.Point(137, 73)
        Me.cbpiljurusan3.Name = "cbpiljurusan3"
        Me.cbpiljurusan3.Size = New System.Drawing.Size(225, 21)
        Me.cbpiljurusan3.TabIndex = 2
        '
        'cbpiljurusan2
        '
        Me.cbpiljurusan2.FormattingEnabled = True
        Me.cbpiljurusan2.Location = New System.Drawing.Point(137, 46)
        Me.cbpiljurusan2.Name = "cbpiljurusan2"
        Me.cbpiljurusan2.Size = New System.Drawing.Size(225, 21)
        Me.cbpiljurusan2.TabIndex = 1
        '
        'cbpiljurusan1
        '
        Me.cbpiljurusan1.FormattingEnabled = True
        Me.cbpiljurusan1.Location = New System.Drawing.Point(137, 19)
        Me.cbpiljurusan1.Name = "cbpiljurusan1"
        Me.cbpiljurusan1.Size = New System.Drawing.Size(225, 21)
        Me.cbpiljurusan1.TabIndex = 0
        '
        'tbkode
        '
        Me.tbkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbkode.Location = New System.Drawing.Point(121, 399)
        Me.tbkode.Name = "tbkode"
        Me.tbkode.Size = New System.Drawing.Size(161, 22)
        Me.tbkode.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbpiljurusan3)
        Me.GroupBox1.Controls.Add(Me.cbpiljurusan2)
        Me.GroupBox1.Controls.Add(Me.cbpiljurusan1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 107)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan Jurusan"
        '
        'tbasalsekolah
        '
        Me.tbasalsekolah.Location = New System.Drawing.Point(153, 242)
        Me.tbasalsekolah.Name = "tbasalsekolah"
        Me.tbasalsekolah.Size = New System.Drawing.Size(231, 20)
        Me.tbasalsekolah.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Asal Sekolah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Jenis Kelamin"
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(229, 219)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 5
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(153, 219)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(70, 17)
        Me.rblaki.TabIndex = 4
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki - laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'tbnotelp
        '
        Me.tbnotelp.Location = New System.Drawing.Point(153, 193)
        Me.tbnotelp.MaxLength = 15
        Me.tbnotelp.Name = "tbnotelp"
        Me.tbnotelp.Size = New System.Drawing.Size(231, 20)
        Me.tbnotelp.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "No. Telepon"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tanggal Lahir"
        '
        'dtptgllahir
        '
        Me.dtptgllahir.Location = New System.Drawing.Point(153, 167)
        Me.dtptgllahir.Name = "dtptgllahir"
        Me.dtptgllahir.Size = New System.Drawing.Size(231, 20)
        Me.dtptgllahir.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Alamat"
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(153, 90)
        Me.tbalamat.Multiline = True
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(231, 71)
        Me.tbalamat.TabIndex = 1
        '
        'tbnama
        '
        Me.tbnama.Location = New System.Drawing.Point(153, 64)
        Me.tbnama.Name = "tbnama"
        Me.tbnama.Size = New System.Drawing.Size(231, 20)
        Me.tbnama.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama Lengkap"
        '
        'btback
        '
        Me.btback.BackColor = System.Drawing.Color.Silver
        Me.btback.Location = New System.Drawing.Point(299, 12)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(85, 23)
        Me.btback.TabIndex = 10
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Pendaftaran Siswa Baru"
        '
        'frmregistrasisiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 436)
        Me.Controls.Add(Me.btsubmit)
        Me.Controls.Add(Me.lbkode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbkode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbasalsekolah)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbperempuan)
        Me.Controls.Add(Me.rblaki)
        Me.Controls.Add(Me.tbnotelp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtptgllahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.tbnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmregistrasisiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pendaftaran Siswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btsubmit As Button
    Friend WithEvents lbkode As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbpiljurusan3 As ComboBox
    Friend WithEvents cbpiljurusan2 As ComboBox
    Friend WithEvents cbpiljurusan1 As ComboBox
    Friend WithEvents tbkode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbasalsekolah As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbperempuan As RadioButton
    Friend WithEvents rblaki As RadioButton
    Friend WithEvents tbnotelp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtptgllahir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents tbalamat As TextBox
    Friend WithEvents tbnama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btback As Button
    Friend WithEvents Label1 As Label
End Class
