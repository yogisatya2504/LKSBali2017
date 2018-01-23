<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrekapitulasinilai
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
        Me.btgrafik = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Kode Ujian"
        '
        'cbjadwal
        '
        Me.cbjadwal.FormattingEnabled = True
        Me.cbjadwal.Location = New System.Drawing.Point(12, 41)
        Me.cbjadwal.Name = "cbjadwal"
        Me.cbjadwal.Size = New System.Drawing.Size(299, 21)
        Me.cbjadwal.TabIndex = 1
        '
        'btok
        '
        Me.btok.Location = New System.Drawing.Point(348, 41)
        Me.btok.Name = "btok"
        Me.btok.Size = New System.Drawing.Size(75, 23)
        Me.btok.TabIndex = 2
        Me.btok.Text = "OK"
        Me.btok.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(348, 12)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(75, 23)
        Me.btback.TabIndex = 2
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 68)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(411, 299)
        Me.dgv.TabIndex = 3
        '
        'btgrafik
        '
        Me.btgrafik.Location = New System.Drawing.Point(153, 373)
        Me.btgrafik.Name = "btgrafik"
        Me.btgrafik.Size = New System.Drawing.Size(128, 49)
        Me.btgrafik.TabIndex = 4
        Me.btgrafik.Text = "Lihat Grafik Hasil Test"
        Me.btgrafik.UseVisualStyleBackColor = True
        '
        'frmrekapitulasinilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 434)
        Me.Controls.Add(Me.btgrafik)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.btok)
        Me.Controls.Add(Me.cbjadwal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmrekapitulasinilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekapitulasi Hasil Test"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbjadwal As ComboBox
    Friend WithEvents btok As Button
    Friend WithEvents btback As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btgrafik As Button
End Class
