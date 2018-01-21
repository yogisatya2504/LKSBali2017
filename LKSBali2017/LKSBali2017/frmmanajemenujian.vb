Public Class frmmanajemenujian
    ' Point
    ' 1. Pastikan semua data ujian tampil
    ' 2. Pastikan semua form terisi sebelum simpan
    ' 3. Fungsi cari dan urut berfungsi dengan normal
    ' 4. Semua tombol berfungsi dengan bernar
    ' 5. Pastikan tanggal ujian tidak kurang dari tanggal sekarang
    ' 6. Pastikan data yang tanggalnya sudah lewat tidak bisa diedit
    ' 7. Simpan dan hapus hanya muncul saat tambah data atau update data
    ' 8. Id auto generate -- E0001 + 1
    ' 9. Saat upload soal ujian baru maka soal yang lama harus terhapus
    ' 10. Pastikan semua fungsi berjaland engan baik

    ' propierties
    ' dtp :
    '   format : custom
    '   custom format : dd - MM - yyyy , HH : mm

    Dim stts As String = ""
    Dim op As New OpenFileDialog

    Private Sub cls()
        tbkodeujian.Text = ""
        tbcari.Text = ""
        tbdurasiujian.Text = ""
        tbkapasitaspeserta.Text = ""
        tbsoalujian.Text = ""

        rbasc.Checked = False
        rbdsc.Checked = False

        btsimpan.Enabled = False
        bthapus.Enabled = False

        ' kode autogenerate
        tbkodeujian.Enabled = False

        ' Load data cari
        Dim dtc As New DataTable
        dtc.Columns.Add("id")
        dtc.Columns.Add("nama")

        dtc.Rows.Add("id", "Kode ujian")
        dtc.Rows.Add("durasi", "Durasi ujian")
        dtc.Rows.Add("kapasitas", "Kapasitas kursi")
        dtc.Rows.Add("soal", "Soal ujian")


        cbcari.DataSource = Nothing
        cbcari.ValueMember = "id"
        cbcari.DisplayMember = "nama"
        cbcari.DataSource = dtc

        ' Load data urut
        Dim dtu As New DataTable
        dtu.Columns.Add("id")
        dtu.Columns.Add("nama")

        dtu.Rows.Add("id", "Kode ujian")
        dtu.Rows.Add("durasi", "Durasi ujian")
        dtu.Rows.Add("kapasitas", "Kapasitas kursi")

        cburut.DataSource = Nothing
        cburut.ValueMember = "id"
        cburut.DisplayMember = "nama"
        cburut.DataSource = dtu

        ' Load NIP
        Dim dtnip As New DataTable
        dtnip = bacadb("select id, nama, nip from tabkaryawan")

        Dim dtnipx As New DataTable
        dtnipx.Columns.Add("id")
        dtnipx.Columns.Add("nama")

        For i As Integer = 0 To dtnip.Rows.Count - 1
            dtnipx.Rows.Add(dtnip.Rows(i).Item(0), dtnip.Rows(i).Item(1) & " - " & dtnip.Rows(i).Item(2))
        Next

        cbnippengawas.ValueMember = "id"
        cbnippengawas.DisplayMember = "nama"
        cbnippengawas.DataSource = dtnipx

        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb("select id as 'ID', tglujian as 'Tanggal Ujian', durasi as 'Durasi', kapasitas as 'Kapasitas', soal as 'File Soal', idguru as 'ID Guru' from tabjadwal")

        dgv.DataSource = dtdgv

        stts = ""

        op.Reset()
    End Sub

    Private Sub frmmanajemenujian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub frmmanajemenujian_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasikaryawan.Show()
    End Sub

    Private Sub btcari_Click(sender As Object, e As EventArgs) Handles btcari.Click
        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb("select id as 'ID', tglujian as 'Tanggal Ujian', durasi as 'Durasi', kapasitas as 'Kapasitas', soal as 'File Soal', idguru as 'ID Guru' from tabjadwal where " & cbcari.SelectedValue & " like '" & tbcari.Text & "%'")

        dgv.DataSource = dtdgv
    End Sub

    Private Sub bturut_Click(sender As Object, e As EventArgs) Handles bturut.Click
        ' jika urut berdasar asc atau dsc gak dicek maka fungsi gak berjalan
        If rbasc.Checked = False And rbdsc.Checked = False Then
            Exit Sub
        End If

        ' query
        Dim str As String = ""
        If rbasc.Checked = True Then
            str = "select id as 'ID', tglujian as 'Tanggal Ujian', durasi as 'Durasi', kapasitas as 'Kapasitas', soal as 'File Soal', idguru as 'ID Guru' from tabjadwal order by " & cburut.SelectedValue & " asc"
        Else
            str = "select id as 'ID', tglujian as 'Tanggal Ujian', durasi as 'Durasi', kapasitas as 'Kapasitas', soal as 'File Soal', idguru as 'ID Guru' from tabjadwal order by " & cburut.SelectedValue & " desc"
        End If

        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb(str)

        dgv.DataSource = dtdgv
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        cls()

        stts = "simpan"
        btsimpan.Enabled = True

        tbkodeujian.Text = generateid("select top 1 id from tabjadwal order by id desc", "E")
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        cls()

        stts = "update"
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        Dim dt As New DataTable
        dt = bacadb("select tglujian from tabjadwal where id = '" & tbkodeujian.Text & "'")

        If dt.Rows(0).Item(0) < Now Then
            MsgBox("Maaf data tidak dapat dihapus karena jadwal sudah lewat!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        dt.Clear()
        dt = bacadb("select * from tabaktivitasujian where idjadwal = '" & tbkodeujian.Text & "'")

        If dt.Rows.Count > 0 Then
            MsgBox("Jadwal sudah diisi peserta ujian" & vbNewLine & "Hapus peserta ujian terlebih dahulu", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        simpandb("delete from tabjadwal where id = '" & tbkodeujian.Text & "'")

        MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information, "Info")

        cls()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If stts = "update" Then
            ' ketika rows nya di pilih maka akan mengambil cell ke 0 nya
            Dim id As String = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(0).Value.ToString

            ' +--------+--------+--------+--------+--------+--------+
            '     id      tgl      dur      kapa     soal     idgu 
            ' +--------+--------+--------+--------+--------+--------+

            ' semua data akan disimpan pada dt terlebih dahulu
            Dim dt As New DataTable
            dt = bacadb("select * from tabjadwal where id = '" & id & "'")

            tbkodeujian.Text = dt.Rows(0).Item(0)
            dtptglujian.Value = dt.Rows(0).Item(1)
            tbdurasiujian.Text = dt.Rows(0).Item(2)
            tbkapasitaspeserta.Text = dt.Rows(0).Item(3)
            tbsoalujian.Text = dt.Rows(0).Item(4)
            cbnippengawas.SelectedValue = dt.Rows(0).Item(5)

            btsimpan.Enabled = True
            bthapus.Enabled = True
        End If
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        ' form tidak boleh kosong
        If tbkodeujian.Text = "" Or tbdurasiujian.Text = "" Or tbkapasitaspeserta.Text = "" Or tbsoalujian.Text = "" Then
            MsgBox("Lengkapi form!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        ' tgl ujian tidak boleh kurang dari sekarang
        If dtptglujian.Value < Now Then
            MsgBox("Tanggal ujian tidak boleh kurang dari tanggal sekarang!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        ' jika user pernah mengklik browse
        If op.FileName <> "" Then
            FileCopy(op.FileName, IO.Directory.GetCurrentDirectory & "\soal\" & tbkodeujian.Text & IO.Path.GetExtension(op.FileName))
        End If

        If stts = "update" Then
            ' saat update cek apakah tgl kurang dari sekarang
            Dim dt As New DataTable
            dt = bacadb("select tglujian from tabjadwal where id = '" & tbkodeujian.Text & "'")

            If dt.Rows(0).Item(0) < Now Then
                MsgBox("Maaf data tidak dapat diedit karena jadwal sudah lewat!", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            simpandb("update tabjadwal Set tglujian = '" & dtptglujian.Value.Year & "-" & dtptglujian.Value.Month & "-" & dtptglujian.Value.Day & " " & dtptglujian.Value.Hour & ":" & dtptglujian.Value.Minute & ":00" & "', durasi = '" & tbdurasiujian.Text & "', kapasitas = '" & tbkapasitaspeserta.Text & "', idguru = '" & cbnippengawas.SelectedValue & "' where id = '" & tbkodeujian.Text & "'")
            MsgBox("Update sukses", MsgBoxStyle.Information, "Info")
        End If

        If stts = "simpan" Then
            simpandb("insert into tabjadwal values('" & tbkodeujian.Text & "','" & dtptglujian.Value.Year & "-" & dtptglujian.Value.Month & "-" & dtptglujian.Value.Day & " " & dtptglujian.Value.Hour & ":" & dtptglujian.Value.Minute & ":00" & "','" & tbdurasiujian.Text & "','" & tbkapasitaspeserta.Text & "','" & "\soal\" & tbkodeujian.Text & IO.Path.GetExtension(op.FileName) & "','" & cbnippengawas.SelectedValue & "')")
            MsgBox("Simpan sukses", MsgBoxStyle.Information, "Info")
        End If

        cls()
    End Sub

    Private Sub btbrowse_Click(sender As Object, e As EventArgs) Handles btbrowse.Click
        If op.ShowDialog = DialogResult.OK Then
            tbsoalujian.Text = op.SafeFileName
        End If
    End Sub
End Class