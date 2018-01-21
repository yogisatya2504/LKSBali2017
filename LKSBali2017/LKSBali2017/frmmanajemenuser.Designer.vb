<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanajemenuser
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
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpwd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbkaryawan = New System.Windows.Forms.CheckBox()
        Me.cbguru = New System.Windows.Forms.CheckBox()
        Me.cbsiswa = New System.Windows.Forms.CheckBox()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.btsimpan = New System.Windows.Forms.Button()
        Me.btkembali = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(333, 254)
        Me.dgv.TabIndex = 0
        '
        'tbuname
        '
        Me.tbuname.Location = New System.Drawing.Point(93, 283)
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(252, 20)
        Me.tbuname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'tbpwd
        '
        Me.tbpwd.Location = New System.Drawing.Point(93, 309)
        Me.tbpwd.Name = "tbpwd"
        Me.tbpwd.Size = New System.Drawing.Size(252, 20)
        Me.tbpwd.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Role"
        '
        'cbkaryawan
        '
        Me.cbkaryawan.AutoSize = True
        Me.cbkaryawan.Location = New System.Drawing.Point(93, 335)
        Me.cbkaryawan.Name = "cbkaryawan"
        Me.cbkaryawan.Size = New System.Drawing.Size(73, 17)
        Me.cbkaryawan.TabIndex = 2
        Me.cbkaryawan.Text = "Karyawan"
        Me.cbkaryawan.UseVisualStyleBackColor = True
        '
        'cbguru
        '
        Me.cbguru.AutoSize = True
        Me.cbguru.Location = New System.Drawing.Point(198, 335)
        Me.cbguru.Name = "cbguru"
        Me.cbguru.Size = New System.Drawing.Size(49, 17)
        Me.cbguru.TabIndex = 3
        Me.cbguru.Text = "Guru"
        Me.cbguru.UseVisualStyleBackColor = True
        '
        'cbsiswa
        '
        Me.cbsiswa.AutoSize = True
        Me.cbsiswa.Location = New System.Drawing.Point(291, 335)
        Me.cbsiswa.Name = "cbsiswa"
        Me.cbsiswa.Size = New System.Drawing.Size(54, 17)
        Me.cbsiswa.TabIndex = 4
        Me.cbsiswa.Text = "Siswa"
        Me.cbsiswa.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Location = New System.Drawing.Point(12, 371)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(107, 23)
        Me.btupdate.TabIndex = 5
        Me.btupdate.Text = "Perbaharui Data"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'btsimpan
        '
        Me.btsimpan.Location = New System.Drawing.Point(125, 371)
        Me.btsimpan.Name = "btsimpan"
        Me.btsimpan.Size = New System.Drawing.Size(107, 23)
        Me.btsimpan.TabIndex = 6
        Me.btsimpan.Text = "Simpan"
        Me.btsimpan.UseVisualStyleBackColor = True
        '
        'btkembali
        '
        Me.btkembali.Location = New System.Drawing.Point(238, 371)
        Me.btkembali.Name = "btkembali"
        Me.btkembali.Size = New System.Drawing.Size(107, 23)
        Me.btkembali.TabIndex = 7
        Me.btkembali.Text = "Kembali"
        Me.btkembali.UseVisualStyleBackColor = True
        '
        'frmmanajemenuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 406)
        Me.Controls.Add(Me.btkembali)
        Me.Controls.Add(Me.btsimpan)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.cbsiswa)
        Me.Controls.Add(Me.cbguru)
        Me.Controls.Add(Me.cbkaryawan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbpwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbuname)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmmanajemenuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manajemen User Account"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents tbuname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbpwd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbkaryawan As CheckBox
    Friend WithEvents cbguru As CheckBox
    Friend WithEvents cbsiswa As CheckBox
    Friend WithEvents btupdate As Button
    Friend WithEvents btsimpan As Button
    Friend WithEvents btkembali As Button
End Class
