<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkoreksihasiltest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbjadwal = New System.Windows.Forms.ComboBox()
        Me.btok = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpeserta = New System.Windows.Forms.TextBox()
        Me.cbdaftarpeserta = New System.Windows.Forms.ComboBox()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.lbterakhirupdate = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih kode ujian :"
        '
        'cbjadwal
        '
        Me.cbjadwal.FormattingEnabled = True
        Me.cbjadwal.Location = New System.Drawing.Point(102, 12)
        Me.cbjadwal.Name = "cbjadwal"
        Me.cbjadwal.Size = New System.Drawing.Size(231, 21)
        Me.cbjadwal.TabIndex = 1
        '
        'btok
        '
        Me.btok.Location = New System.Drawing.Point(339, 12)
        Me.btok.Name = "btok"
        Me.btok.Size = New System.Drawing.Size(75, 23)
        Me.btok.TabIndex = 2
        Me.btok.Text = "OK"
        Me.btok.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(471, 12)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(75, 23)
        Me.btback.TabIndex = 3
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(15, 97)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(531, 150)
        Me.dgv.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Daftar Peserta Ujian"
        '
        'tbpeserta
        '
        Me.tbpeserta.Location = New System.Drawing.Point(339, 70)
        Me.tbpeserta.Name = "tbpeserta"
        Me.tbpeserta.Size = New System.Drawing.Size(207, 20)
        Me.tbpeserta.TabIndex = 6
        '
        'cbdaftarpeserta
        '
        Me.cbdaftarpeserta.FormattingEnabled = True
        Me.cbdaftarpeserta.Location = New System.Drawing.Point(200, 70)
        Me.cbdaftarpeserta.Name = "cbdaftarpeserta"
        Me.cbdaftarpeserta.Size = New System.Drawing.Size(133, 21)
        Me.cbdaftarpeserta.TabIndex = 1
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(212, 289)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(137, 51)
        Me.btsimpan.TabIndex = 7
        Me.btsimpan.Text = "Simpan Hasil Koreksi"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'lbterakhirupdate
        '
        Me.lbterakhirupdate.AutoSize = True
        Me.lbterakhirupdate.Location = New System.Drawing.Point(315, 250)
        Me.lbterakhirupdate.Name = "lbterakhirupdate"
        Me.lbterakhirupdate.Size = New System.Drawing.Size(231, 13)
        Me.lbterakhirupdate.TabIndex = 8
        Me.lbterakhirupdate.Text = "Terakhir diupdate pada : 01 - 01 - 2018  00 : 00"
        '
        'frmkoreksihasiltest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 352)
        Me.Controls.Add(Me.lbterakhirupdate)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.tbpeserta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.btok)
        Me.Controls.Add(Me.cbdaftarpeserta)
        Me.Controls.Add(Me.cbjadwal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmkoreksihasiltest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Koreksi Hasil Test"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbjadwal As ComboBox
    Friend WithEvents btok As Button
    Friend WithEvents btback As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents tbpeserta As TextBox
    Friend WithEvents cbdaftarpeserta As ComboBox
    Friend WithEvents btsimpan As Button
    Friend WithEvents lbterakhirupdate As Label
End Class
