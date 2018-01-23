Public Class frmkoreksihasiltest
    ' Point
    ' 1. Kode ujian hanya diisi oleh ujian yang sudah lewat
    ' 2. pencarian berdasarkan kode pendaftaran atau nama siswa
    ' 3. siswa yang dipilih akan muncul pada datagridview
    ' 4. Total Score = (30% * NilaiPG) + (30% * NilaiEssay) + (40% * NilaiKasus)
    ' 5. sistem akan update status siswa
    '    total score >= 65 : 'Lulus'
    '    total score < 65 : 'Tidak Lulus'
    ' 6. last update akan diisi dengan terakhir siswa memfinalize jawaban

    Private Sub cls()
        ' point 1
        Dim dt As New DataTable
        dt = bacadb("select id, tglujian, durasi from tabjadwal where tglujian < '" & Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "'")
        Dim dtx As New DataTable
        With dtx
            .Columns.Add("id")
            .Columns.Add("nama")
        End With
        For i As Integer = 0 To dt.Rows.Count - 1
            dtx.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(0) & " - " & dt.Rows(i).Item(1) & " - " & dt.Rows(i).Item(2))
        Next
        With cbjadwal
            .ValueMember = "id"
            .DisplayMember = "nama"
            .DataSource = dtx
        End With

        ' point 2
        Dim dtcari As New DataTable
        With dtcari
            .Columns.Add("id")
            .Columns.Add("nama")
            .Rows.Add("id", "Kode Pendaftaran")
            .Rows.Add("nama", "Nama Peserta")
        End With
        With cbdaftarpeserta
            .ValueMember = "id"
            .DisplayMember = "nama"
            .DataSource = dtcari
        End With

        tbpeserta.Text = ""
    End Sub

    Private Sub frmkoreksihasiltest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub frmkoreksihasiltest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If nav = "guru" Then
            frmnavigasiguru.Show()
        Else
            frmnavigasikaryawan.Show()
        End If
    End Sub

    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        Dim dt As New DataTable
        dt = bacadb("select tabaktivitasujian.jawaban_siswa as 'Download Jawaban', tabaktivitasujian.id as 'Kode Pendaftaran', tabsiswa.nama as 'Nama Peserta', tabaktivitasujian.nilaipg as 'Nilai PG', tabaktivitasujian.nilaiessay as 'Nilai Essay', tabaktivitasujian.nilaikasus as 'Nilai Kasus' from tabaktivitasujian inner join tabsiswa on tabsiswa.id = tabaktivitasujian.id where tabaktivitasujian.idjadwal = '" & cbjadwal.SelectedValue & "'")
        dgv.DataSource = dt
    End Sub

    Private Sub tbpeserta_TextChanged(sender As Object, e As EventArgs) Handles tbpeserta.TextChanged
        Dim dt As New DataTable
        dt = bacadb("select tabaktivitasujian.jawaban_siswa as 'Download Jawaban', tabaktivitasujian.id as 'Kode Pendaftaran', tabsiswa.nama as 'Nama Peserta', tabaktivitasujian.nilaipg as 'Nilai PG', tabaktivitasujian.nilaiessay as 'Nilai Essay', tabaktivitasujian.nilaikasus as 'Nilai Kasus' from tabaktivitasujian inner join tabsiswa on tabsiswa.id = tabaktivitasujian.id where tabaktivitasujian.idjadwal = '" & cbjadwal.SelectedValue & "' and tabsiswa." & cbdaftarpeserta.SelectedValue & " like '" & tbpeserta.Text & "%'")
        dgv.DataSource = dt
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim id As String = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(1).Value.ToString

        Dim dt As New DataTable
        dt = bacadb("select waktu_up1, waktu_up2, waktu_up3 from tabaktivitasujian where id = '" & id & "'")

        Dim tgl As String = ""

        If dt.Rows(0).Item(2).ToString = "01/01/1900 00:00:00" Then
            If dt.Rows(0).Item(1).ToString = "01/01/1900 00:00:00" Then
                tgl = dt.Rows(0).Item(0).ToString
            Else
                tgl = dt.Rows(0).Item(1).ToString
            End If
        Else
            tgl = dt.Rows(0).Item(2).ToString
        End If

        lbterakhirupdate.Text = "Terakhir diupdate pada : " & tgl
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        ' download - id - nama - nilaipg - nilaiessay - nilai kasus
        ' update db
        ' -2 karena 1 untuk rows terakhir yang isinya kosong (cek dgv), 1 kareane kita mulai dari 0
        For i As Integer = 0 To dgv.Rows.Count - 2
            ' point 4
            If (30 * dgv.Rows(i).Cells(3).Value / 100) + (30 * dgv.Rows(i).Cells(4).Value / 100) + (40 * dgv.Rows(i).Cells(4).Value / 100) >= 65 Then
                ' lulus
                simpandb("update tabaktivitasujian set [status] = 'Lulus', nilaipg = '" & dgv.Rows(i).Cells(3).Value.ToString & "', nilaiessay = '" & dgv.Rows(i).Cells(4).Value.ToString & "', nilaikasus = '" & dgv.Rows(i).Cells(5).Value.ToString & "' where id = '" & dgv.Rows(i).Cells(1).Value.ToString & "'")
            Else
                simpandb("update tabaktivitasujian set [status] = 'Tidak Lulus', nilaipg = '" & dgv.Rows(i).Cells(3).Value.ToString & "', nilaiessay = '" & dgv.Rows(i).Cells(4).Value.ToString & "', nilaikasus = '" & dgv.Rows(i).Cells(5).Value.ToString & "' where id = '" & dgv.Rows(i).Cells(1).Value.ToString & "'")
            End If
        Next

        MsgBox("Data berhasil diupdate")

        cls()
    End Sub
End Class