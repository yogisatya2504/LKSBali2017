Public Class frmgrafikhasiltest
    ' Point
    ' 1. dalam chart akan tampil berapa banyak yang lulus dan tidak lulus
    ' 2. pastikan info yang tampil benar

    Private Sub frmgrafikhasiltest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = bacadb("select id, tglujian from tabjadwal where id = '" & frmrekapitulasinilai.cbjadwal.SelectedValue & "'")

        lb.Text = "Grafik Hasil Test : " & dt.Rows(0).Item(0) & " - " & dt.Rows(0).Item(1)

        dt.Clear()
        dt = bacadb("select [status] from tabaktivitasujian where idjadwal = '" & frmrekapitulasinilai.cbjadwal.SelectedValue & "'")

        Dim lulus As Integer = 0
        Dim tidaklulus As Integer = 0

        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item(0) = "Lulus" Then
                lulus += 1
            Else
                tidaklulus += 1
            End If
        Next

        chart.Series.Clear()
        chart.Series.Add("Nilai")

        With chart.Series("Nilai").Points
            .AddXY("Lulus", lulus)
            .AddXY("Tidak Lulus", tidaklulus)
        End With
    End Sub

    Private Sub frmgrafikhasiltest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmrekapitulasinilai.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class