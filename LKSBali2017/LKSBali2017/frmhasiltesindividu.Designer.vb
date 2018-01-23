<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhasiltesindividu
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbkodeujian = New System.Windows.Forms.TextBox()
        Me.tbtanggalujian = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btback = New System.Windows.Forms.Button()
        Me.chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lbstatus = New System.Windows.Forms.Label()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Ujian"
        '
        'tbkodeujian
        '
        Me.tbkodeujian.Location = New System.Drawing.Point(91, 12)
        Me.tbkodeujian.Name = "tbkodeujian"
        Me.tbkodeujian.Size = New System.Drawing.Size(199, 20)
        Me.tbkodeujian.TabIndex = 1
        '
        'tbtanggalujian
        '
        Me.tbtanggalujian.Location = New System.Drawing.Point(91, 38)
        Me.tbtanggalujian.Name = "tbtanggalujian"
        Me.tbtanggalujian.Size = New System.Drawing.Size(199, 20)
        Me.tbtanggalujian.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tanggal Ujian"
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(365, 12)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(75, 46)
        Me.btback.TabIndex = 4
        Me.btback.Text = "Kembali"
        Me.btback.UseVisualStyleBackColor = True
        '
        'chart
        '
        ChartArea1.Name = "ChartArea1"
        Me.chart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chart.Legends.Add(Legend1)
        Me.chart.Location = New System.Drawing.Point(15, 76)
        Me.chart.Name = "chart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chart.Series.Add(Series1)
        Me.chart.Size = New System.Drawing.Size(425, 300)
        Me.chart.TabIndex = 5
        Me.chart.Text = "Chart1"
        '
        'lbstatus
        '
        Me.lbstatus.AutoSize = True
        Me.lbstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbstatus.Location = New System.Drawing.Point(12, 398)
        Me.lbstatus.Name = "lbstatus"
        Me.lbstatus.Size = New System.Drawing.Size(206, 24)
        Me.lbstatus.TabIndex = 6
        Me.lbstatus.Text = "[ Lulus ] / [ Tidak Lulus ]"
        '
        'frmhasiltesindividu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 441)
        Me.Controls.Add(Me.lbstatus)
        Me.Controls.Add(Me.chart)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.tbtanggalujian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbkodeujian)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmhasiltesindividu"
        Me.Text = "Hasil Test Individu"
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbkodeujian As TextBox
    Friend WithEvents tbtanggalujian As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btback As Button
    Friend WithEvents chart As DataVisualization.Charting.Chart
    Friend WithEvents lbstatus As Label
End Class
