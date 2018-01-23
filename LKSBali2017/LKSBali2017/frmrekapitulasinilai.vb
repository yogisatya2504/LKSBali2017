Public Class frmrekapitulasinilai
    ' Point
    ' 1. jadwal yang tampil adalah jadwal dimana semua siswa di dalamnya sudah di periksa guru

    Private Sub frmrekapitulasinilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = bacadb("select id from tabjadwal")

        Dim dtjadwal As New DataTable
        dtjadwal.Columns.Add("id")

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim stts As Boolean = False

            Dim dtx As New DataTable
            dtx = bacadb("select [status] from tabaktivitasujian where idjadwal = '" & dt.Rows(i).Item(0) & "'")

            For x As Integer = 0 To dtx.Rows.Count - 1
                If dtx.Rows(x).Item(0) = "Lulus" Or dtx.Rows(x).Item(0) = "Tidak Lulus" Then
                    stts = True
                End If
            Next

            If stts = True Then
                dtjadwal.Rows.Add(dt.Rows(i).Item(0))
            End If
        Next

        cbjadwal.ValueMember = "id"
        cbjadwal.DisplayMember = "id"
        cbjadwal.DataSource = dtjadwal
    End Sub

    Private Sub frmrekapitulasinilai_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If nav = "guru" Then
            frmnavigasiguru.Show()
        Else
            frmnavigasikaryawan.Show()
        End If
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        Dim dt As New DataTable
        dt = bacadb("select tabsiswa.id as 'Kode Pendaftaran', tabsiswa.nama as 'Nama Lengkap', tabaktivitasujian.[status] as 'Hasil Test' from tabaktivitasujian inner join tabsiswa on tabsiswa.id = tabaktivitasujian.id where tabaktivitasujian.idjadwal = '" & cbjadwal.SelectedValue & "'")

        dgv.DataSource = dt
    End Sub

    Private Sub btgrafik_Click(sender As Object, e As EventArgs) Handles btgrafik.Click
        Me.Hide()
        frmgrafikhasiltest.Show()
    End Sub
End Class