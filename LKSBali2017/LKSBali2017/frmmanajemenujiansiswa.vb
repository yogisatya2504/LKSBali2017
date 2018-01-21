Public Class frmmanajemenujiansiswa
    ' Point
    ' 1. Formm ini berfungsi untuk mempersiapkan siswa mengikuti ujian
    ' 2. Cbjadwal format -- ExamId - ExamDate
    ' 3. Dgv kiri hanya menampilkan siswa yang belum terdaftar dalam ujian manapun
    ' 4. Jika kursi sudah 0 maka tampilkan pesan untuk meremove siswa terlebih dahulu
    ' 5. Semua fungsi ini otomatis tersimmpan ke database

    Dim sload As Boolean

    Dim idkiri As String = ""
    Dim idkanan As String = ""

    Private Sub cls()
        sload = True

        Dim dt As New DataTable
        dt = bacadb("select id, tglujian from tabjadwal")

        Dim dtx As New DataTable
        dtx.Columns.Add("id")
        dtx.Columns.Add("nama")

        For i As Integer = 0 To dt.Rows.Count - 1
            dtx.Rows.Add(dt.Rows(i).Item(0), dt.Rows(i).Item(0) & " - " & dt.Rows(i).Item(1))
        Next

        cbjadwal.ValueMember = "id"
        cbjadwal.DisplayMember = "nama"
        cbjadwal.DataSource = dtx

        sload = False
    End Sub

    Private Sub frmmanajemenujiansiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub cbjadwal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjadwal.SelectedIndexChanged
        If sload = False Then
            ' dgv kiri diisi siswa yang samasekali belum masuk ke jadwal manapun
            Dim dt As New DataTable
            dt = bacadb("select id as 'Kode Pendaftaran', nama as 'Nama Lengkap' from tabsiswa where id not in (select id from tabaktivitasujian)")

            dgvkiri.DataSource = dt

            ' dgv kanan diisi siswa yang sudah masuk ke jadwal yang dipilih
            Dim dtk As New DataTable
            dtk = bacadb("select id as 'Kode Pendaftaran', nama as 'Nama Lengkap' from tabsiswa where id in (select id from tabaktivitasujian where idjadwal = '" & cbjadwal.SelectedValue & "')")

            dgvkanan.DataSource = dtk

            ' load sisa kursi
            Dim dts As New DataTable
            dts = bacadb("select kapasitas from tabjadwal where id = '" & cbjadwal.SelectedValue & "'")

            lbsisakursi.Text = "Sisa Kursi : " & dts.Rows(0).Item(0)

        End If
    End Sub

    Private Sub btkembali_Click(sender As Object, e As EventArgs) Handles btkembali.Click
        Me.Close()
    End Sub

    Private Sub frmmanajemenujiansiswa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasikaryawan.Show()
    End Sub

    Private Sub btpindahkanan_Click(sender As Object, e As EventArgs) Handles btpindahkanan.Click

        ' jika kursi 0 maka keluar peringatan
        ' update jumlah kursi -1
        Dim dt As New DataTable
        dt = bacadb("select kapasitas from tabjadwal where id = '" & cbjadwal.SelectedValue & "'")

        If dt.Rows(0).Item(0) = 0 Then
            MsgBox("Kapasitas sudah penuh!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        simpandb("update tabjadwal set kapasitas = '" & dt.Rows(0).Item(0) - 1 & "' where id = '" & cbjadwal.SelectedValue & "'")

        ' update alokasi siswa
        simpandb("insert into tabaktivitasujian values('" & idkiri & "','" & cbjadwal.SelectedValue & "','','','','','','','','Belum Ujian','')")

        ' dgv kiri diisi siswa yang samasekali belum masuk ke jadwal manapun
        Dim dta As New DataTable
        dta = bacadb("select id as 'Kode Pendaftaran', nama as 'Nama Lengkap' from tabsiswa where id not in (select id from tabaktivitasujian)")

        dgvkiri.DataSource = dta

        ' dgv kanan diisi siswa yang sudah masuk ke jadwal yang dipilih
        Dim dtk As New DataTable
        dtk = bacadb("select id as 'Kode Pendaftaran', nama as 'Nama Lengkap' from tabsiswa where id in (select id from tabaktivitasujian where idjadwal = '" & cbjadwal.SelectedValue & "')")

        dgvkanan.DataSource = dtk

        ' load sisa kursi
        Dim dts As New DataTable
        dts = bacadb("select kapasitas from tabjadwal where id = '" & cbjadwal.SelectedValue & "'")

        lbsisakursi.Text = "Sisa Kursi : " & dts.Rows(0).Item(0)
    End Sub

    Private Sub dgvkiri_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkiri.CellContentClick
        btpindahkanan.Enabled = True
        btpindahkiri.Enabled = False

        idkiri = dgvkiri.Rows(dgvkiri.CurrentCell.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub dgvkanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkanan.CellContentClick
        btpindahkanan.Enabled = False
        btpindahkiri.Enabled = True

        idkanan = dgvkanan.Rows(dgvkanan.CurrentCell.RowIndex).Cells(0).Value.ToString
    End Sub

    Private Sub btpindahkiri_Click(sender As Object, e As EventArgs) Handles btpindahkiri.Click
        ' update jumlah kursi +1
        Dim dt As New DataTable
        dt = bacadb("select kapasitas from tabjadwal where id = '" & cbjadwal.SelectedValue & "'")

        simpandb("update tabjadwal set kapasitas = '" & dt.Rows(0).Item(0) + 1 & "' where id = '" & cbjadwal.SelectedValue & "'")

        ' hapus alokasi
        simpandb("delete from tabaktivitasujian where id = '" & idkanan & "'")


        ' dgv kiri diisi siswa yang samasekali belum masuk ke jadwal manapun
        Dim dta As New DataTable
        dta = bacadb("select id as 'Kode Pendaftaran', nama as 'Nama Lengkap' from tabsiswa where id not in (select id from tabaktivitasujian)")

        dgvkiri.DataSource = dta

        ' dgv kanan diisi siswa yang sudah masuk ke jadwal yang dipilih
        Dim dtk As New DataTable
        dtk = bacadb("select id as 'Kode Pendaftaran', nama as 'Nama Lengkap' from tabsiswa where id in (select id from tabaktivitasujian where idjadwal = '" & cbjadwal.SelectedValue & "')")

        dgvkanan.DataSource = dtk

        ' load sisa kursi
        Dim dts As New DataTable
        dts = bacadb("select kapasitas from tabjadwal where id = '" & cbjadwal.SelectedValue & "'")

        lbsisakursi.Text = "Sisa Kursi : " & dts.Rows(0).Item(0)
    End Sub
End Class