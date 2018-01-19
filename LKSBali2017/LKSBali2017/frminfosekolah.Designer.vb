<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminfosekolah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frminfosekolah))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btkembali = New System.Windows.Forms.Button()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.tbinfo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbinfo = New System.Windows.Forms.ComboBox()
        Me.btlihatinfo = New System.Windows.Forms.Button()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SMK Nasional"
        '
        'btkembali
        '
        Me.btkembali.Location = New System.Drawing.Point(372, 12)
        Me.btkembali.Name = "btkembali"
        Me.btkembali.Size = New System.Drawing.Size(75, 23)
        Me.btkembali.TabIndex = 2
        Me.btkembali.Text = "Kembali"
        Me.btkembali.UseVisualStyleBackColor = True
        '
        'pb
        '
        Me.pb.Image = CType(resources.GetObject("pb.Image"), System.Drawing.Image)
        Me.pb.Location = New System.Drawing.Point(12, 66)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(215, 139)
        Me.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb.TabIndex = 3
        Me.pb.TabStop = False
        '
        'tbinfo
        '
        Me.tbinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbinfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbinfo.Location = New System.Drawing.Point(233, 66)
        Me.tbinfo.Multiline = True
        Me.tbinfo.Name = "tbinfo"
        Me.tbinfo.ReadOnly = True
        Me.tbinfo.Size = New System.Drawing.Size(215, 139)
        Me.tbinfo.TabIndex = 3
        Me.tbinfo.Text = resources.GetString("tbinfo.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Informasi Jurusan"
        '
        'cbinfo
        '
        Me.cbinfo.FormattingEnabled = True
        Me.cbinfo.Location = New System.Drawing.Point(233, 211)
        Me.cbinfo.Name = "cbinfo"
        Me.cbinfo.Size = New System.Drawing.Size(214, 21)
        Me.cbinfo.TabIndex = 0
        '
        'btlihatinfo
        '
        Me.btlihatinfo.Location = New System.Drawing.Point(343, 238)
        Me.btlihatinfo.Name = "btlihatinfo"
        Me.btlihatinfo.Size = New System.Drawing.Size(104, 23)
        Me.btlihatinfo.TabIndex = 1
        Me.btlihatinfo.Text = "Lihat Informasi"
        Me.btlihatinfo.UseVisualStyleBackColor = True
        '
        'frminfosekolah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 270)
        Me.Controls.Add(Me.btlihatinfo)
        Me.Controls.Add(Me.cbinfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbinfo)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.btkembali)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frminfosekolah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informasi Sekolah"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btkembali As Button
    Friend WithEvents pb As PictureBox
    Friend WithEvents tbinfo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbinfo As ComboBox
    Friend WithEvents btlihatinfo As Button
End Class
