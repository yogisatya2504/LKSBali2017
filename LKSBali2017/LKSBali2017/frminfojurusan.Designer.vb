<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminfojurusan
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
        Me.tbinfo = New System.Windows.Forms.TextBox()
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.lbnama = New System.Windows.Forms.Label()
        Me.btkembali = New System.Windows.Forms.Button()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbinfo
        '
        Me.tbinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbinfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbinfo.Location = New System.Drawing.Point(60, 263)
        Me.tbinfo.Multiline = True
        Me.tbinfo.Name = "tbinfo"
        Me.tbinfo.ReadOnly = True
        Me.tbinfo.Size = New System.Drawing.Size(215, 139)
        Me.tbinfo.TabIndex = 4
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(16, 43)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(296, 205)
        Me.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb.TabIndex = 5
        Me.pb.TabStop = False
        '
        'lbnama
        '
        Me.lbnama.AutoSize = True
        Me.lbnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnama.Location = New System.Drawing.Point(12, 9)
        Me.lbnama.Name = "lbnama"
        Me.lbnama.Size = New System.Drawing.Size(128, 20)
        Me.lbnama.TabIndex = 6
        Me.lbnama.Text = "[ Nama Jurusan ]"
        '
        'btkembali
        '
        Me.btkembali.Location = New System.Drawing.Point(237, 9)
        Me.btkembali.Name = "btkembali"
        Me.btkembali.Size = New System.Drawing.Size(75, 23)
        Me.btkembali.TabIndex = 0
        Me.btkembali.Text = "Kembali"
        Me.btkembali.UseVisualStyleBackColor = True
        '
        'frminfojurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 425)
        Me.Controls.Add(Me.btkembali)
        Me.Controls.Add(Me.lbnama)
        Me.Controls.Add(Me.tbinfo)
        Me.Controls.Add(Me.pb)
        Me.Name = "frminfojurusan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informasi Jurusan"
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbinfo As TextBox
    Friend WithEvents pb As PictureBox
    Friend WithEvents lbnama As Label
    Friend WithEvents btkembali As Button
End Class
