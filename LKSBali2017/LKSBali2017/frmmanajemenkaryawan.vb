Public Class frmmanajemenkaryawan
    ' Point
    ' 1. Pastikan dapat menampilkan data karyawan
    ' 2. Pastikan semua komponen terisi sebelum simpan
    ' 3. Fitur cari berfungsi dengan benar sesuai dengan nama kolom
    ' 4. Fitur urutkan juga berfungsi seperti fitus cari
    ' 5. Semua tombol berfungsi dengan benar
    ' 6. Tombol simpan muncul saat tambah data dan update data
    '    tombol perbaharui berfungsi agar dgv bisa di klik untuk update data
    ' 7. Saat tambah baru maka id akan autogenerate K0001 + 1
    ' 8. Format password = id + tglhir (mmddyy) -- K0001012789
    ' 9. Pastikan semua fungsi berjalan

    ' status apakah simpan atau update
    Dim stts As String = ""

    Private Sub cls()
        tbalamat.Text = ""
        tbcari.Text = ""
        tbkodekaryawan.Text = ""
        tbnamakaryawan.Text = ""
        tbnip.Text = ""
        tbnotelp.Text = ""

        rblaki.Checked = False
        rbperempuan.Checked = False
        rbasc.Checked = False
        rbdsc.Checked = False

        btsimpan.Enabled = False
        bthapus.Enabled = False

        ' kode autogenerate
        tbkodekaryawan.Enabled = False

        ' Load data cari
        Dim dtc As New DataTable
        dtc.Columns.Add("id")
        dtc.Columns.Add("nama")

        dtc.Rows.Add("id", "Kode karyawan")
        dtc.Rows.Add("nip", "NIP")
        dtc.Rows.Add("nama", "Nama karyawan")
        dtc.Rows.Add("alamat", "Alamat")
        dtc.Rows.Add("jk", "Jenis kelamin")
        dtc.Rows.Add("notelp", "No. Telp")

        cbcari.DataSource = Nothing
        cbcari.ValueMember = "id"
        cbcari.DisplayMember = "nama"
        cbcari.DataSource = dtc

        ' Load data urut
        Dim dtu As New DataTable
        dtu.Columns.Add("id")
        dtu.Columns.Add("nama")

        dtu.Rows.Add("id", "Kode karyawan")
        dtu.Rows.Add("nama", "Nama karyawan")
        dtu.Rows.Add("jk", "Jenis kelamin")
        dtu.Rows.Add("notelp", "No. Telp")

        cburut.DataSource = Nothing
        cburut.ValueMember = "id"
        cburut.DisplayMember = "nama"
        cburut.DataSource = dtu

        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb("select id as 'Kode Karyawan', nip as 'NIP', nama as 'Nama', tgllahir as 'Tanggal Lahir', alamat as 'Alamat', jk as 'Jenis Kelamin', notelp as 'Nomor Telepon' from tabkaryawan")

        dgv.DataSource = dtdgv

        stts = ""
    End Sub

    Private Sub frmmanajemenkaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub btcari_Click(sender As Object, e As EventArgs) Handles btcari.Click
        Dim dtdgv As New DataTable
        dtdgv = bacadb("select id as 'Kode Karyawan', nip as 'NIP', nama as 'Nama', tgllahir as 'Tanggal Lahir', alamat as 'Alamat', jk as 'Jenis Kelamin', notelp as 'Nomor Telepon' from tabkaryawan where " & cbcari.SelectedValue & " like '" & tbcari.Text & "%'")

        dgv.DataSource = dtdgv
    End Sub

    Private Sub frmmanajemenkaryawan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasikaryawan.Show()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub bturut_Click(sender As Object, e As EventArgs) Handles bturut.Click
        ' jika urut berdasar asc atau dsc gak dicek maka fungsi gak berjalan
        If rbasc.Checked = False And rbdsc.Checked = False Then
            Exit Sub
        End If

        ' query
        Dim str As String = ""
        If rbasc.Checked = True Then
            str = "select id as 'Kode Karyawan', nip as 'NIP', nama as 'Nama', tgllahir as 'Tanggal Lahir', alamat as 'Alamat', jk as 'Jenis Kelamin', notelp as 'Nomor Telepon' from tabkaryawan order by " & cburut.SelectedValue & " asc"
        Else
            str = "select id as 'Kode Karyawan', nip as 'NIP', nama as 'Nama', tgllahir as 'Tanggal Lahir', alamat as 'Alamat', jk as 'Jenis Kelamin', notelp as 'Nomor Telepon' from tabkaryawan order by " & cburut.SelectedValue & " desc"
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

        ' Point 7 -- lihat modulkoneksi
        tbkodekaryawan.Text = generateid("select top 1 id from tabkaryawan order by id desc", "K")
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        cls()

        stts = "update"
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        simpandb("delete from tabuser where username = '" & tbkodekaryawan.Text & "'")
        simpandb("delete from tabkaryawan where id = '" & tbkodekaryawan.Text & "'")

        MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Info")

        cls()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        ' Point 2
        If tbkodekaryawan.Text = "" Or tbalamat.Text = "" Or tbnamakaryawan.Text = "" Or tbnip.Text = "" Or tbnotelp.Text = "" Or (rblaki.Checked = False And rbperempuan.Checked = False) Then
            MsgBox("Tolong lengkapi form!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Dim jk As String = ""
        If rblaki.Checked = True Then
            jk = "Laki - Laki"
        Else
            jk = "Perempuan"
        End If

        If stts = "simpan" Then
            ' simpan data user -- role akan diubah di manajemen user
            ' Point 8
            simpandb("insert into tabuser values('" & tbkodekaryawan.Text & "','" & tbkodekaryawan.Text & Format(dtptgllahir.Value, "MMddyy") & "','')")

            ' simpan data karyawan
            simpandb("insert into tabkaryawan values('" & tbkodekaryawan.Text & "','" & tbnip.Text & "','" & tbnamakaryawan.Text & "','" & dtptgllahir.Value.Month & "/" & dtptgllahir.Value.Day & "/" & dtptgllahir.Value.Year & "','" & tbalamat.Text & "','" & jk & "','" & tbnotelp.Text & "')")

            MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
        End If

        If stts = "update" Then
            ' update password user berdasarkan tgl
            simpandb("update tabuser set [password] = '" & tbkodekaryawan.Text & Format(dtptgllahir.Value, "MMddyy") & "' where username = '" & tbkodekaryawan.Text & "'")

            ' update data karyawan
            simpandb("update tabkaryawan set nip = '" & tbnip.Text & "', nama = '" & tbnamakaryawan.Text & "', tgllahir = '" & dtptgllahir.Value.Month & "/" & dtptgllahir.Value.Day & "/" & dtptgllahir.Value.Year & "', alamat = '" & tbalamat.Text & "', jk = '" & jk & "', notelp = '" & tbnotelp.Text & "' where id = '" & tbkodekaryawan.Text & "'")

            MsgBox("Data berhasil diperbaharui!", MsgBoxStyle.Information, "Info")
        End If

        cls()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If stts = "update" Then
            ' ketika rows nya di pilih maka akan mengambil cell ke 0 nya
            Dim id As String = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(0).Value.ToString

            ' +--------+--------+--------+--------+--------+--------+--------+
            '     id      nip      nama    tgllhr    almt      jk     notelp
            ' +--------+--------+--------+--------+--------+--------+--------+

            ' semua data akan disimpan pada dt terlebih dahulu
            Dim dt As New DataTable
            dt = bacadb("select * from tabkaryawan where id = '" & id & "'")

            tbkodekaryawan.Text = dt.Rows(0).Item(0)
            tbnip.Text = dt.Rows(0).Item(1)
            tbnamakaryawan.Text = dt.Rows(0).Item(2)
            dtptgllahir.Value = dt.Rows(0).Item(3)
            tbalamat.Text = dt.Rows(0).Item(4)

            If dt.Rows(0).Item(5) = "Laki - Laki" Then
                rblaki.Checked = True
            Else
                rbperempuan.Checked = True
            End If

            tbnotelp.Text = dt.Rows(0).Item(6)

            btsimpan.Enabled = True
            bthapus.Enabled = True
        End If
    End Sub
End Class