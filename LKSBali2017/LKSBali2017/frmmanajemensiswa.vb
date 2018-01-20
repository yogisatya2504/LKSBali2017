Public Class frmmanajemensiswa
    ' Point
    ' 1. Pastikan dapat menampilkan data siswa
    ' 2. Pastikan semua data terisi sebelum simmpan
    ' 3. Pastikan fitur cari berfungsi sesuai dengan nama kolom
    ' 4. Pastikan fitur uruttkan berrfungsi
    ' 5. Semua tombol berfungsi dengan benar
    ' 6. Tombol simpan akan muncul saat tambah atau update data
    '    tombol update untuk mengaktifkan sgv bisa diklik agar data dapat diupdate
    ' 7. Jurrusan yang sudah dipilih tak dapat dipilih lagi
    ' 8. Status tes terisi dengan benar
    ' 9. Pastikan semua fungsi dapat berjalan sebagaimana mestinya

    ' status update
    Dim stts As String = ""
    ' status apakah loadcls
    Dim sload As Boolean = True

    Private Sub cls()
        sload = True

        tbalamat.Text = ""
        tbcari.Text = ""
        tbasalsekolah.Text = ""
        tbnamakaryawan.Text = ""
        tbkodependaftaran.Text = ""
        tbnotelp.Text = ""

        lbstatus.Text = ""

        rblaki.Checked = False
        rbperempuan.Checked = False
        rbasc.Checked = False
        rbdsc.Checked = False

        btsimpan.Enabled = False
        bthapus.Enabled = False

        ' kode autogenerate
        tbkodependaftaran.Enabled = False

        ' Load data cari
        Dim dtc As New DataTable
        dtc.Columns.Add("id")
        dtc.Columns.Add("nama")

        dtc.Rows.Add("id", "Kode pendaftaran")
        dtc.Rows.Add("nama", "Nama siswa")
        dtc.Rows.Add("alamat", "Alamat")
        dtc.Rows.Add("jk", "Jenis kelamin")
        dtc.Rows.Add("notelp", "No. Telp")
        dtc.Rows.Add("asalsekolah", "Asal Sekolah")

        cbcari.DataSource = Nothing
        cbcari.ValueMember = "id"
        cbcari.DisplayMember = "nama"
        cbcari.DataSource = dtc

        ' Load data urut
        Dim dtu As New DataTable
        dtu.Columns.Add("id")
        dtu.Columns.Add("nama")

        dtu.Rows.Add("id", "Kode pendaftaran")
        dtu.Rows.Add("nama", "Nama siswa")
        dtu.Rows.Add("jk", "Jenis kelamin")
        dtu.Rows.Add("notelp", "No. Telp")

        cburut.DataSource = Nothing
        cburut.ValueMember = "id"
        cburut.DisplayMember = "nama"
        cburut.DataSource = dtu

        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb("select tabsiswa.id as 'Kode Pendaftaran', tabsiswa.nama as 'Nama Siswa', tabsiswa.tgllahir as 'Tanggal Lahir', tabsiswa.notelp as 'No. Telp', tabsiswa.jk as 'Jenis Kelamin', tabsiswa.asalsekolah as 'Asal Sekolah', pri1.nama as 'Prioritas Jurusan 1', pri2.nama as 'Prioritas Jurusan 2', pri3.nama as 'Prioritas Jurusan 3' from tabsiswa inner join tabjurusan as pri1 on pri1.id = tabsiswa.pri_jur1 inner join tabjurusan as pri2 on pri2.id = tabsiswa.pri_jur2 inner join tabjurusan as pri3 on pri3.id = tabsiswa.pri_jur3")

        dgv.DataSource = dtdgv

        ' load combo box jurusan
        cbpiljurusan1.DataSource = Nothing
        cbpiljurusan2.DataSource = Nothing
        cbpiljurusan3.DataSource = Nothing

        cbpiljurusan1.ValueMember = "id"
        cbpiljurusan1.DisplayMember = "nama"
        cbpiljurusan1.DataSource = bacadb("select id, nama from tabjurusan")

        cbpiljurusan2.ValueMember = "id"
        cbpiljurusan2.DisplayMember = "nama"
        cbpiljurusan2.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "'")

        cbpiljurusan3.ValueMember = "id"
        cbpiljurusan3.DisplayMember = "nama"
        cbpiljurusan3.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "' and id <> '" & cbpiljurusan2.SelectedValue & "'")

        stts = ""

        sload = False
    End Sub

    Private Sub frmmanajemensiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub cbpiljurusan1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpiljurusan1.SelectedIndexChanged
        If sload = False Then
            sload = True

            cbpiljurusan2.ValueMember = "id"
            cbpiljurusan2.DisplayMember = "nama"
            cbpiljurusan2.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "'")

            cbpiljurusan3.ValueMember = "id"
            cbpiljurusan3.DisplayMember = "nama"
            cbpiljurusan3.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "' and id <> '" & cbpiljurusan2.SelectedValue & "'")

            sload = False
        End If
    End Sub

    Private Sub cbpiljurusan2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpiljurusan2.SelectedIndexChanged
        If sload = False Then
            sload = True

            cbpiljurusan3.ValueMember = "id"
            cbpiljurusan3.DisplayMember = "nama"
            cbpiljurusan3.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "' and id <> '" & cbpiljurusan2.SelectedValue & "'")

            sload = False
        End If
    End Sub

    Private Sub frmmanajemensiswa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasikaryawan.Show()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub btcari_Click(sender As Object, e As EventArgs) Handles btcari.Click
        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb("select tabsiswa.id as 'Kode Pendaftaran', tabsiswa.nama as 'Nama Siswa', tabsiswa.tgllahir as 'Tanggal Lahir', tabsiswa.notelp as 'No. Telp', tabsiswa.jk as 'Jenis Kelamin', tabsiswa.asalsekolah as 'Asal Sekolah', pri1.nama as 'Prioritas Jurusan 1', pri2.nama as 'Prioritas Jurusan 2', pri3.nama as 'Prioritas Jurusan 3' from tabsiswa inner join tabjurusan as pri1 on pri1.id = tabsiswa.pri_jur1 inner join tabjurusan as pri2 on pri2.id = tabsiswa.pri_jur2 inner join tabjurusan as pri3 on pri3.id = tabsiswa.pri_jur3 where tabsiswa." & cbcari.SelectedValue & " like '" & tbcari.Text & "%'")

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
            str = "select tabsiswa.id as 'Kode Pendaftaran', tabsiswa.nama as 'Nama Siswa', tabsiswa.tgllahir as 'Tanggal Lahir', tabsiswa.notelp as 'No. Telp', tabsiswa.jk as 'Jenis Kelamin', tabsiswa.asalsekolah as 'Asal Sekolah', pri1.nama as 'Prioritas Jurusan 1', pri2.nama as 'Prioritas Jurusan 2', pri3.nama as 'Prioritas Jurusan 3' from tabsiswa inner join tabjurusan as pri1 on pri1.id = tabsiswa.pri_jur1 inner join tabjurusan as pri2 on pri2.id = tabsiswa.pri_jur2 inner join tabjurusan as pri3 on pri3.id = tabsiswa.pri_jur3 order by tabsiswa." & cburut.SelectedValue & " asc"
        Else
            str = "select tabsiswa.id as 'Kode Pendaftaran', tabsiswa.nama as 'Nama Siswa', tabsiswa.tgllahir as 'Tanggal Lahir', tabsiswa.notelp as 'No. Telp', tabsiswa.jk as 'Jenis Kelamin', tabsiswa.asalsekolah as 'Asal Sekolah', pri1.nama as 'Prioritas Jurusan 1', pri2.nama as 'Prioritas Jurusan 2', pri3.nama as 'Prioritas Jurusan 3' from tabsiswa inner join tabjurusan as pri1 on pri1.id = tabsiswa.pri_jur1 inner join tabjurusan as pri2 on pri2.id = tabsiswa.pri_jur2 inner join tabjurusan as pri3 on pri3.id = tabsiswa.pri_jur3 order by tabsiswa." & cburut.SelectedValue & " desc"
        End If

        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb(str)

        dgv.DataSource = dtdgv
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        cls()

        stts = "update"
        btsimpan.Enabled = True
        bthapus.Enabled = True
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If stts = "update" Then
            ' ketika rows nya di pilih maka akan mengambil cell ke 0 nya
            Dim id As String = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(0).Value.ToString

            ' +--------+--------+--------+--------+--------+--------+--------+--------+--------+--------+
            '     id      nama    almt     tgllhr   notelp     jk     aslskl    pri1     pri2     pri3   
            ' +--------+--------+--------+--------+--------+--------+--------+--------+--------+--------+

            ' semua data akan disimpan pada dt terlebih dahulu
            Dim dt As New DataTable
            dt = bacadb("select * from tabsiswa where id = '" & id & "'")

            tbkodependaftaran.Text = dt.Rows(0).Item(0)
            tbnamakaryawan.Text = dt.Rows(0).Item(1)
            tbalamat.Text = dt.Rows(0).Item(2)
            dtptgllahir.Value = dt.Rows(0).Item(3)
            tbnotelp.Text = dt.Rows(0).Item(4)

            If dt.Rows(0).Item(5) = "Laki - Laki" Then
                rblaki.Checked = True
            Else
                rbperempuan.Checked = True
            End If

            tbasalsekolah.Text = dt.Rows(0).Item(6)
            cbpiljurusan1.SelectedValue = dt.Rows(0).Item(7)
            cbpiljurusan2.SelectedValue = dt.Rows(0).Item(8)
            cbpiljurusan3.SelectedValue = dt.Rows(0).Item(9)

            Dim dtsts As New DataTable
            dtsts = bacadb("select [status] from tabaktivitasujian where id = '" & id & "'")

            If dtsts.Rows.Count > 0 Then
                lbstatus.Text = dtsts.Rows(0).Item(0)
            Else
                lbstatus.Text = "Jadwal Belum Teralokasi"
            End If

        End If
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        simpandb("delete from tabuser where username = '" & tbkodependaftaran.Text & "'")
        simpandb("delete from tabsiswa where id = '" & tbkodependaftaran.Text & "'")

        MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Info")

        cls()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        ' Point 2
        If tbalamat.Text = "" Or tbasalsekolah.Text = "" Or tbkodependaftaran.Text = "" Or tbnamakaryawan.Text = "" Or tbnotelp.Text = "" Or (rblaki.Checked = False And rbperempuan.Checked = False) Then
            MsgBox("Tolong lengkapi form!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Dim jk As String = ""
        If rblaki.Checked = True Then
            jk = "Laki - Laki"
        Else
            jk = "Perempuan"
        End If

        ' update data siswa
        simpandb("update tabsiswa set nama = '" & tbnamakaryawan.Text & "', alamat = '" & tbalamat.Text & "', tgllahir = '" & dtptgllahir.Value.Month & "/" & dtptgllahir.Value.Day & "/" & dtptgllahir.Value.Year & "', notelp = '" & tbnotelp.Text & "', jk = '" & jk & "', asalsekolah = '" & tbasalsekolah.Text & "', pri_jur1 = '" & cbpiljurusan1.SelectedValue & "', pri_jur2 = '" & cbpiljurusan2.SelectedValue & "', pri_jur3 = '" & cbpiljurusan3.SelectedValue & "' where id = '" & tbkodependaftaran.Text & "'")

        ' update password user berdasarkan tgl
        simpandb("update tabuser set [password] = '" & tbkodependaftaran.Text & Format(dtptgllahir.Value, "MMddyy") & "' where username = '" & tbkodependaftaran.Text & "'")

        MsgBox("Data berhasil diperbaharui!", MsgBoxStyle.Information, "Info")

        cls()
    End Sub
End Class