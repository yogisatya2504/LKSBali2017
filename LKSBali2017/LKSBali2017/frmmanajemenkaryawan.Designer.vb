<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanajemenkaryawan
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
        Me.btback = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
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
        Me.tbnip = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbkodekaryawan = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btback
        '
        Me.btback.BackColor = System.Drawing.Color.Silver
        Me.btback.Location = New System.Drawing.Point(463, 432)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(134, 23)
        Me.btback.TabIndex = 18
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(463, 384)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(134, 23)
        Me.bthapus.TabIndex = 18
        Me.bthapus.Text = "Hapus Data"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(463, 358)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(134, 23)
        Me.btsimpan.TabIndex = 17
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(463, 332)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(134, 23)
        Me.btupdate.TabIndex = 16
        Me.btupdate.Text = "Perbaharui Data"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(463, 306)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(134, 23)
        Me.bttambah.TabIndex = 15
        Me.bttambah.Text = "Tambah Data"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 485)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Alamat"
        '
        'tbalamat
        '
        Me.tbalamat.Location = New System.Drawing.Point(166, 482)
        Me.tbalamat.Multiline = True
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(252, 56)
        Me.tbalamat.TabIndex = 14
        '
        'tbnotelp
        '
        Me.tbnotelp.Location = New System.Drawing.Point(166, 456)
        Me.tbnotelp.Name = "tbnotelp"
        Me.tbnotelp.Size = New System.Drawing.Size(252, 20)
        Me.tbnotelp.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "No. Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 427)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Jenis Kelamin"
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(98, 13)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 12
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(6, 13)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(70, 17)
        Me.rblaki.TabIndex = 11
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki - laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Tanggal Lahir"
        '
        'dtptgllahir
        '
        Me.dtptgllahir.Location = New System.Drawing.Point(166, 386)
        Me.dtptgllahir.Name = "dtptgllahir"
        Me.dtptgllahir.Size = New System.Drawing.Size(252, 20)
        Me.dtptgllahir.TabIndex = 10
        '
        'tbnamakaryawan
        '
        Me.tbnamakaryawan.Location = New System.Drawing.Point(166, 360)
        Me.tbnamakaryawan.Name = "tbnamakaryawan"
        Me.tbnamakaryawan.Size = New System.Drawing.Size(252, 20)
        Me.tbnamakaryawan.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Nama Karyawan"
        '
        'tbnip
        '
        Me.tbnip.Location = New System.Drawing.Point(166, 334)
        Me.tbnip.Name = "tbnip"
        Me.tbnip.Size = New System.Drawing.Size(252, 20)
        Me.tbnip.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "NIP"
        '
        'tbkodekaryawan
        '
        Me.tbkodekaryawan.Location = New System.Drawing.Point(166, 308)
        Me.tbkodekaryawan.Name = "tbkodekaryawan"
        Me.tbkodekaryawan.Size = New System.Drawing.Size(252, 20)
        Me.tbkodekaryawan.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Kode Karyawan"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(17, 94)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(580, 200)
        Me.dgv.TabIndex = 20
        '
        'bturut
        '
        Me.bturut.Location = New System.Drawing.Point(499, 39)
        Me.bturut.Name = "bturut"
        Me.bturut.Size = New System.Drawing.Size(98, 23)
        Me.bturut.TabIndex = 6
        Me.bturut.Text = "Urutkan"
        Me.bturut.UseVisualStyleBackColor = True
        '
        'btcari
        '
        Me.btcari.Location = New System.Drawing.Point(499, 10)
        Me.btcari.Name = "btcari"
        Me.btcari.Size = New System.Drawing.Size(98, 23)
        Me.btcari.TabIndex = 2
        Me.btcari.Text = "Cari"
        Me.btcari.UseVisualStyleBackColor = True
        '
        'rbdsc
        '
        Me.rbdsc.AutoSize = True
        Me.rbdsc.Location = New System.Drawing.Point(411, 42)
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
        Me.rbasc.Location = New System.Drawing.Point(296, 42)
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
        Me.cburut.Location = New System.Drawing.Point(92, 41)
        Me.cburut.Name = "cburut"
        Me.cburut.Size = New System.Drawing.Size(198, 21)
        Me.cburut.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Urutkan Data"
        '
        'tbcari
        '
        Me.tbcari.Location = New System.Drawing.Point(296, 12)
        Me.tbcari.Name = "tbcari"
        Me.tbcari.Size = New System.Drawing.Size(197, 20)
        Me.tbcari.TabIndex = 1
        '
        'cbcari
        '
        Me.cbcari.FormattingEnabled = True
        Me.cbcari.Location = New System.Drawing.Point(92, 12)
        Me.cbcari.Name = "cbcari"
        Me.cbcari.Size = New System.Drawing.Size(198, 21)
        Me.cbcari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cari Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rblaki)
        Me.GroupBox1.Controls.Add(Me.rbperempuan)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 412)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 38)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'frmmanajemenkaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 549)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.tbnotelp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtptgllahir)
        Me.Controls.Add(Me.tbnamakaryawan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbnip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbkodekaryawan)
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
        Me.Name = "frmmanajemenkaryawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Karyawan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btback As Button
    Friend WithEvents bthapus As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents btupdate As Button
    Friend WithEvents bttambah As Button
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
    Friend WithEvents tbnip As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbkodekaryawan As TextBox
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
    Friend WithEvents GroupBox1 As GroupBox
End Class
