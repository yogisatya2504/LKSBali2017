<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanajemenujian
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
        Me.cbnippengawas = New System.Windows.Forms.ComboBox()
        Me.btupload = New System.Windows.Forms.Button()
        Me.btbrowse = New System.Windows.Forms.Button()
        Me.tbsoalujian = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbkapasitaspeserta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btback = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtptglujian = New System.Windows.Forms.DateTimePicker()
        Me.tbdurasiujian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbkodeujian = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbnippengawas
        '
        Me.cbnippengawas.FormattingEnabled = True
        Me.cbnippengawas.Location = New System.Drawing.Point(105, 390)
        Me.cbnippengawas.Name = "cbnippengawas"
        Me.cbnippengawas.Size = New System.Drawing.Size(311, 21)
        Me.cbnippengawas.TabIndex = 11
        '
        'btupload
        '
        Me.btupload.Location = New System.Drawing.Point(320, 24)
        Me.btupload.Name = "btupload"
        Me.btupload.Size = New System.Drawing.Size(75, 23)
        Me.btupload.TabIndex = 2
        Me.btupload.Text = "Upload"
        Me.btupload.UseVisualStyleBackColor = True
        '
        'btbrowse
        '
        Me.btbrowse.Location = New System.Drawing.Point(239, 24)
        Me.btbrowse.Name = "btbrowse"
        Me.btbrowse.Size = New System.Drawing.Size(75, 23)
        Me.btbrowse.TabIndex = 1
        Me.btbrowse.Text = "Browse .."
        Me.btbrowse.UseVisualStyleBackColor = True
        '
        'tbsoalujian
        '
        Me.tbsoalujian.Location = New System.Drawing.Point(6, 24)
        Me.tbsoalujian.Name = "tbsoalujian"
        Me.tbsoalujian.Size = New System.Drawing.Size(227, 20)
        Me.tbsoalujian.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 393)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "NIP Pengawas"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btupload)
        Me.GroupBox1.Controls.Add(Me.btbrowse)
        Me.GroupBox1.Controls.Add(Me.tbsoalujian)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 425)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 57)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Soal Ujian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 367)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Orang"
        '
        'tbkapasitaspeserta
        '
        Me.tbkapasitaspeserta.Location = New System.Drawing.Point(313, 364)
        Me.tbkapasitaspeserta.Name = "tbkapasitaspeserta"
        Me.tbkapasitaspeserta.Size = New System.Drawing.Size(61, 20)
        Me.tbkapasitaspeserta.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Kapasitas Peserta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(172, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "Menit"
        '
        'btback
        '
        Me.btback.BackColor = System.Drawing.Color.Silver
        Me.btback.Location = New System.Drawing.Point(461, 435)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(134, 23)
        Me.btback.TabIndex = 17
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(461, 387)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(134, 23)
        Me.bthapus.TabIndex = 16
        Me.bthapus.Text = "Hapus Data"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(461, 361)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(134, 23)
        Me.btsimpan.TabIndex = 15
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(461, 335)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(134, 23)
        Me.btupdate.TabIndex = 14
        Me.btupdate.Text = "Perbaharui Data"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(461, 309)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(134, 23)
        Me.bttambah.TabIndex = 13
        Me.bttambah.Text = "Tambah Data"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Tanggal Ujian"
        '
        'dtptglujian
        '
        Me.dtptglujian.CustomFormat = "dd - MM - yyyy , HH : mm"
        Me.dtptglujian.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptglujian.Location = New System.Drawing.Point(105, 338)
        Me.dtptglujian.Name = "dtptglujian"
        Me.dtptglujian.Size = New System.Drawing.Size(311, 20)
        Me.dtptglujian.TabIndex = 8
        '
        'tbdurasiujian
        '
        Me.tbdurasiujian.Location = New System.Drawing.Point(105, 364)
        Me.tbdurasiujian.Name = "tbdurasiujian"
        Me.tbdurasiujian.Size = New System.Drawing.Size(61, 20)
        Me.tbdurasiujian.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Durasi Ujian"
        '
        'tbkodeujian
        '
        Me.tbkodeujian.Location = New System.Drawing.Point(105, 311)
        Me.tbkodeujian.Name = "tbkodeujian"
        Me.tbkodeujian.Size = New System.Drawing.Size(311, 20)
        Me.tbkodeujian.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Kode Ujian"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(15, 97)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(580, 200)
        Me.dgv.TabIndex = 18
        '
        'bturut
        '
        Me.bturut.Location = New System.Drawing.Point(497, 42)
        Me.bturut.Name = "bturut"
        Me.bturut.Size = New System.Drawing.Size(98, 23)
        Me.bturut.TabIndex = 6
        Me.bturut.Text = "Urutkan"
        Me.bturut.UseVisualStyleBackColor = True
        '
        'btcari
        '
        Me.btcari.Location = New System.Drawing.Point(497, 13)
        Me.btcari.Name = "btcari"
        Me.btcari.Size = New System.Drawing.Size(98, 23)
        Me.btcari.TabIndex = 2
        Me.btcari.Text = "Cari"
        Me.btcari.UseVisualStyleBackColor = True
        '
        'rbdsc
        '
        Me.rbdsc.AutoSize = True
        Me.rbdsc.Location = New System.Drawing.Point(409, 45)
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
        Me.rbasc.Location = New System.Drawing.Point(294, 45)
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
        Me.cburut.Location = New System.Drawing.Point(90, 44)
        Me.cburut.Name = "cburut"
        Me.cburut.Size = New System.Drawing.Size(198, 21)
        Me.cburut.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Urutkan Data"
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(294, 15)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(197, 20)
        Me.tbcari.TabIndex = 1
        '
        'cbcari
        '
        Me.cbcari.FormattingEnabled = True
        Me.cbcari.Location = New System.Drawing.Point(90, 15)
        Me.cbcari.Name = "cbcari"
        Me.cbcari.Size = New System.Drawing.Size(198, 21)
        Me.cbcari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Cari Data"
        '
        'frmmanajemenujian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 490)
        Me.Controls.Add(Me.cbnippengawas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbkapasitaspeserta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtptglujian)
        Me.Controls.Add(Me.tbdurasiujian)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbkodeujian)
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
        Me.Name = "frmmanajemenujian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Ujian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbnippengawas As ComboBox
    Friend WithEvents btupload As Button
    Friend WithEvents btbrowse As Button
    Friend WithEvents tbsoalujian As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbkapasitaspeserta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btback As Button
    Friend WithEvents bthapus As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents btupdate As Button
    Friend WithEvents bttambah As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dtptglujian As DateTimePicker
    Friend WithEvents tbdurasiujian As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbkodeujian As TextBox
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
End Class
