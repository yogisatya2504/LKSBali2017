Public Class frmhasiltesindividu
    ' Pointt
    ' 1. form ini hanya muncul jika guru sudah mengkoreksi hasil tes, jika tidak munculkan pesan cek frmnavigasisiswa.btlihat
    ' 2. dalam chart akan tampil nilai essay, nilai pg, dan nilai kasus
    ' 3. form akan menampilkan jadwal ujian dan nilai yang benar
    ' 4. status akan muncul dengan benar

    Private Sub frmhasiltesindividu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = bacadb("select tabaktivitasujian.idjadwal, tabjadwal.tglujian, tabaktivitasujian.nilaipg, tabaktivitasujian.nilaiessay, tabaktivitasujian.nilaikasus, tabaktivitasujian.[status] from tabaktivitasujian inner join tabjadwal on tabjadwal.id = tabaktivitasujian.idjadwal where tabaktivitasujian.id = '" & frmlogin.tbusername.Text & "'")

        tbkodeujian.Text = dt.Rows(0).Item(0)
        tbtanggalujian.Text = dt.Rows(0).Item(1)

        chart.Series.Clear()
        chart.Series.Add("Nilai")

        With chart.Series("Nilai").Points
            .AddXY("Nilai PG", dt.Rows(0).Item(2))
            .AddXY("Nilai Essay", dt.Rows(0).Item(3))
            .AddXY("Nilai Kasus", dt.Rows(0).Item(4))
        End With

        lbstatus.Text = dt.Rows(0).Item(5)
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub frmhasiltesindividu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasisiswa.Show()
    End Sub
End Class