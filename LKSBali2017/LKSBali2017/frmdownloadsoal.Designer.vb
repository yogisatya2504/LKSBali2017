<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmdownloadsoal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbjadwal = New System.Windows.Forms.TextBox()
        Me.lbdownload = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbupload = New System.Windows.Forms.TextBox()
        Me.btupload = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbtimer = New System.Windows.Forms.Label()
        Me.btfinalize = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tbjadwal
        '
        Me.tbjadwal.Location = New System.Drawing.Point(85, 12)
        Me.tbjadwal.Name = "tbjadwal"
        Me.tbjadwal.ReadOnly = True
        Me.tbjadwal.Size = New System.Drawing.Size(187, 20)
        Me.tbjadwal.TabIndex = 0
        '
        'lbdownload
        '
        Me.lbdownload.AutoSize = True
        Me.lbdownload.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdownload.ForeColor = System.Drawing.Color.Blue
        Me.lbdownload.Location = New System.Drawing.Point(59, 50)
        Me.lbdownload.Name = "lbdownload"
        Me.lbdownload.Size = New System.Drawing.Size(178, 24)
        Me.lbdownload.TabIndex = 2
        Me.lbdownload.Text = "Download Soal Test"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Upload Jawaban (max. 3x)"
        '
        'tbupload
        '
        Me.tbupload.Location = New System.Drawing.Point(12, 107)
        Me.tbupload.Name = "tbupload"
        Me.tbupload.ReadOnly = True
        Me.tbupload.Size = New System.Drawing.Size(179, 20)
        Me.tbupload.TabIndex = 3
        '
        'btupload
        '
        Me.btupload.Location = New System.Drawing.Point(197, 104)
        Me.btupload.Name = "btupload"
        Me.btupload.Size = New System.Drawing.Size(75, 23)
        Me.btupload.TabIndex = 1
        Me.btupload.Text = "Upload"
        Me.btupload.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 133)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(260, 150)
        Me.dgv.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sisa waktu ujian :"
        '
        'lbtimer
        '
        Me.lbtimer.AutoSize = True
        Me.lbtimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtimer.Location = New System.Drawing.Point(211, 286)
        Me.lbtimer.Name = "lbtimer"
        Me.lbtimer.Size = New System.Drawing.Size(61, 13)
        Me.lbtimer.TabIndex = 7
        Me.lbtimer.Text = "00 : 00 : 00"
        '
        'btfinalize
        '
        Me.btfinalize.Location = New System.Drawing.Point(85, 324)
        Me.btfinalize.Name = "btfinalize"
        Me.btfinalize.Size = New System.Drawing.Size(116, 33)
        Me.btfinalize.TabIndex = 2
        Me.btfinalize.Text = "Finalize"
        Me.btfinalize.UseVisualStyleBackColor = True
        '
        'frmdownloadsoal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 370)
        Me.Controls.Add(Me.btfinalize)
        Me.Controls.Add(Me.lbtimer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btupload)
        Me.Controls.Add(Me.tbupload)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbdownload)
        Me.Controls.Add(Me.tbjadwal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmdownloadsoal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download Soal Test"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbjadwal As TextBox
    Friend WithEvents lbdownload As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbupload As TextBox
    Friend WithEvents btupload As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents lbtimer As Label
    Friend WithEvents btfinalize As Button
End Class
