<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanajemenjurusan
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btback = New System.Windows.Forms.Button()
        Me.bthapus = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.bttambah = New System.Windows.Forms.Button()
        Me.tbkodejurusan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbnamajurusan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbpenjelasanjurusan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.btbrowse = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(482, 200)
        Me.dgv.TabIndex = 9
        '
        'btback
        '
        Me.btback.BackColor = System.Drawing.Color.Silver
        Me.btback.Location = New System.Drawing.Point(500, 138)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(97, 23)
        Me.btback.TabIndex = 4
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = False
        '
        'bthapus
        '
        Me.bthapus.Location = New System.Drawing.Point(500, 90)
        Me.bthapus.Name = "bthapus"
        Me.bthapus.Size = New System.Drawing.Size(97, 23)
        Me.bthapus.TabIndex = 3
        Me.bthapus.Text = "Hapus Data"
        Me.bthapus.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(500, 64)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(97, 23)
        Me.btsimpan.TabIndex = 2
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(500, 38)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(97, 23)
        Me.btupdate.TabIndex = 1
        Me.btupdate.Text = "Perbaharui Data"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'bttambah
        '
        Me.bttambah.Location = New System.Drawing.Point(500, 12)
        Me.bttambah.Name = "bttambah"
        Me.bttambah.Size = New System.Drawing.Size(97, 23)
        Me.bttambah.TabIndex = 0
        Me.bttambah.Text = "Tambah Data"
        Me.bttambah.UseVisualStyleBackColor = True
        '
        'tbkodejurusan
        '
        Me.tbkodejurusan.Location = New System.Drawing.Point(114, 242)
        Me.tbkodejurusan.Name = "tbkodejurusan"
        Me.tbkodejurusan.Size = New System.Drawing.Size(193, 20)
        Me.tbkodejurusan.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Kode Jurusan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nama Jurusan"
        '
        'tbnamajurusan
        '
        Me.tbnamajurusan.Location = New System.Drawing.Point(114, 268)
        Me.tbnamajurusan.Name = "tbnamajurusan"
        Me.tbnamajurusan.Size = New System.Drawing.Size(193, 20)
        Me.tbnamajurusan.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Penjelasan Jurusan"
        '
        'tbpenjelasanjurusan
        '
        Me.tbpenjelasanjurusan.Location = New System.Drawing.Point(114, 294)
        Me.tbpenjelasanjurusan.Multiline = True
        Me.tbpenjelasanjurusan.Name = "tbpenjelasanjurusan"
        Me.tbpenjelasanjurusan.Size = New System.Drawing.Size(193, 109)
        Me.tbpenjelasanjurusan.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(322, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Foto Jurusan"
        '
        'pb
        '
        Me.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb.Location = New System.Drawing.Point(325, 260)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(270, 143)
        Me.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb.TabIndex = 34
        Me.pb.TabStop = False
        '
        'btbrowse
        '
        Me.btbrowse.Location = New System.Drawing.Point(500, 231)
        Me.btbrowse.Name = "btbrowse"
        Me.btbrowse.Size = New System.Drawing.Size(95, 23)
        Me.btbrowse.TabIndex = 8
        Me.btbrowse.Text = "Browse"
        Me.btbrowse.UseVisualStyleBackColor = True
        '
        'frmmanajemenjurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 415)
        Me.Controls.Add(Me.btbrowse)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbpenjelasanjurusan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbnamajurusan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbkodejurusan)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.bthapus)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.bttambah)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmmanajemenjurusan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen Jurusan"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents btback As Button
    Friend WithEvents bthapus As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents btupdate As Button
    Friend WithEvents bttambah As Button
    Friend WithEvents tbkodejurusan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbnamajurusan As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbpenjelasanjurusan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pb As PictureBox
    Friend WithEvents btbrowse As Button
End Class
