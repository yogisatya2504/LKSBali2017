<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.lberror = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbrole = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btlogin
        '
        Me.btlogin.Location = New System.Drawing.Point(175, 144)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(75, 23)
        Me.btlogin.TabIndex = 3
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.BackColor = System.Drawing.Color.Silver
        Me.btback.Location = New System.Drawing.Point(37, 144)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(85, 23)
        Me.btback.TabIndex = 4
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = False
        '
        'lberror
        '
        Me.lberror.AutoSize = True
        Me.lberror.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lberror.ForeColor = System.Drawing.Color.Red
        Me.lberror.Location = New System.Drawing.Point(34, 106)
        Me.lberror.Name = "lberror"
        Me.lberror.Size = New System.Drawing.Size(72, 13)
        Me.lberror.TabIndex = 15
        Me.lberror.Text = "[ pesan error ]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Role"
        '
        'cbrole
        '
        Me.cbrole.FormattingEnabled = True
        Me.cbrole.Location = New System.Drawing.Point(105, 64)
        Me.cbrole.Name = "cbrole"
        Me.cbrole.Size = New System.Drawing.Size(167, 21)
        Me.cbrole.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Password"
        '
        'tbpwd
        '
        Me.tbpwd.Location = New System.Drawing.Point(105, 38)
        Me.tbpwd.Name = "tbpwd"
        Me.tbpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpwd.Size = New System.Drawing.Size(167, 20)
        Me.tbpwd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Username"
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(105, 12)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(167, 20)
        Me.tbusername.TabIndex = 0
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 181)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.lberror)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbrole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbpwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbusername)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btlogin As Button
    Friend WithEvents btback As Button
    Friend WithEvents lberror As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbrole As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbpwd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbusername As TextBox
End Class
