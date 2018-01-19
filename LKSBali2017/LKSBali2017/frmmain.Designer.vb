<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btdaftar = New System.Windows.Forms.Button()
        Me.btinfo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMK Nasional"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tahun Ajaran 2016/2017"
        '
        'btlogin
        '
        Me.btlogin.Location = New System.Drawing.Point(284, 12)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(92, 25)
        Me.btlogin.TabIndex = 0
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'btdaftar
        '
        Me.btdaftar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdaftar.Location = New System.Drawing.Point(12, 86)
        Me.btdaftar.Name = "btdaftar"
        Me.btdaftar.Size = New System.Drawing.Size(179, 60)
        Me.btdaftar.TabIndex = 1
        Me.btdaftar.Text = "Pendaftaran Siswa Baru"
        Me.btdaftar.UseVisualStyleBackColor = True
        '
        'btinfo
        '
        Me.btinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btinfo.Location = New System.Drawing.Point(197, 86)
        Me.btinfo.Name = "btinfo"
        Me.btinfo.Size = New System.Drawing.Size(179, 60)
        Me.btinfo.TabIndex = 2
        Me.btinfo.Text = "Infromasi Sekolah"
        Me.btinfo.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 165)
        Me.Controls.Add(Me.btinfo)
        Me.Controls.Add(Me.btdaftar)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btlogin As Button
    Friend WithEvents btdaftar As Button
    Friend WithEvents btinfo As Button
End Class
