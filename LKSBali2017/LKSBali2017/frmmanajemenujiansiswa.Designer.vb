<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmanajemenujiansiswa
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
        Me.btkembali = New System.Windows.Forms.Button()
        Me.dgvkiri = New System.Windows.Forms.DataGridView()
        Me.dgvkanan = New System.Windows.Forms.DataGridView()
        Me.btpindahkanan = New System.Windows.Forms.Button()
        Me.btpindahkiri = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbsisakursi = New System.Windows.Forms.Label()
        CType(Me.dgvkiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvkanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jadwal Ujian"
        '
        'cbjadwal
        '
        Me.cbjadwal.FormattingEnabled = True
        Me.cbjadwal.Location = New System.Drawing.Point(90, 12)
        Me.cbjadwal.Name = "cbjadwal"
        Me.cbjadwal.Size = New System.Drawing.Size(313, 21)
        Me.cbjadwal.TabIndex = 1
        '
        'btkembali
        '
        Me.btkembali.Location = New System.Drawing.Point(469, 12)
        Me.btkembali.Name = "btkembali"
        Me.btkembali.Size = New System.Drawing.Size(75, 23)
        Me.btkembali.TabIndex = 2
        Me.btkembali.Text = "Kembali"
        Me.btkembali.UseVisualStyleBackColor = True
        '
        'dgvkiri
        '
        Me.dgvkiri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkiri.Location = New System.Drawing.Point(12, 71)
        Me.dgvkiri.Name = "dgvkiri"
        Me.dgvkiri.Size = New System.Drawing.Size(240, 346)
        Me.dgvkiri.TabIndex = 3
        '
        'dgvkanan
        '
        Me.dgvkanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkanan.Location = New System.Drawing.Point(306, 71)
        Me.dgvkanan.Name = "dgvkanan"
        Me.dgvkanan.Size = New System.Drawing.Size(240, 346)
        Me.dgvkanan.TabIndex = 4
        '
        'btpindahkanan
        '
        Me.btpindahkanan.Location = New System.Drawing.Point(258, 195)
        Me.btpindahkanan.Name = "btpindahkanan"
        Me.btpindahkanan.Size = New System.Drawing.Size(42, 23)
        Me.btpindahkanan.TabIndex = 5
        Me.btpindahkanan.Text = ">>"
        Me.btpindahkanan.UseVisualStyleBackColor = True
        '
        'btpindahkiri
        '
        Me.btpindahkiri.Location = New System.Drawing.Point(258, 224)
        Me.btpindahkiri.Name = "btpindahkiri"
        Me.btpindahkiri.Size = New System.Drawing.Size(42, 23)
        Me.btpindahkiri.TabIndex = 5
        Me.btpindahkiri.Text = "<<"
        Me.btpindahkiri.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Daftar Siswa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Peserta Ujian"
        '
        'lbsisakursi
        '
        Me.lbsisakursi.AutoSize = True
        Me.lbsisakursi.Location = New System.Drawing.Point(460, 55)
        Me.lbsisakursi.Name = "lbsisakursi"
        Me.lbsisakursi.Size = New System.Drawing.Size(86, 13)
        Me.lbsisakursi.TabIndex = 6
        Me.lbsisakursi.Text = "Sisa Kursi : [ db ]"
        '
        'frmmanajemenujiansiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 429)
        Me.Controls.Add(Me.lbsisakursi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btpindahkiri)
        Me.Controls.Add(Me.btpindahkanan)
        Me.Controls.Add(Me.dgvkanan)
        Me.Controls.Add(Me.dgvkiri)
        Me.Controls.Add(Me.btkembali)
        Me.Controls.Add(Me.cbjadwal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmanajemenujiansiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alokasi Jadwal Ujian"
        CType(Me.dgvkiri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvkanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbjadwal As ComboBox
    Friend WithEvents btkembali As Button
    Friend WithEvents dgvkiri As DataGridView
    Friend WithEvents dgvkanan As DataGridView
    Friend WithEvents btpindahkanan As Button
    Friend WithEvents btpindahkiri As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbsisakursi As Label
End Class
