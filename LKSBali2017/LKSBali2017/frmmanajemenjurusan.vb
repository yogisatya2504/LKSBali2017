Public Class frmmanajemenjurusan
    ' Point
    ' 1. Pastikan semua data jurusan bisa tampil
    ' 2. Pastikan semua data terisi sebelum disimpan
    ' 3. Semua tombol berfungsi dengan benar
    ' 4. Tombol simpan akan muncul saat tambah atau update data
    '    tombol update untuk mengaktifkan sgv bisa diklik agar data dapat diupdate
    ' 5. Id autogenerate -- S0001 + 1
    ' 6. Pastikan jurusan yang sudah punya murid gak bisa dihapus
    ' 7. Pastikan semua fungsi dapat berjalan sebagaimana mestinya

    ' status apakah simpan baru atau update
    Dim stts As String = ""

    Private Sub cls()
        tbkodejurusan.Text = ""
        tbnamajurusan.Text = ""
        tbpenjelasanjurusan.Text = ""

        pb.Image = Nothing
        pb.Tag = ""

        tbkodejurusan.Enabled = False

        btsimpan.Enabled = False
        bthapus.Enabled = False

        ' Load DGV
        Dim dtdgv As New DataTable
        dtdgv = bacadb("select id as 'Kode Jurusan', nama as 'Nama Jurusan', penjelasan as 'Penjelasan Jurusan', foto as 'Foto Jurusan' from tabjurusan")

        dgv.DataSource = dtdgv
    End Sub

    Private Sub frmmanajemenjurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub frmmanajemenjurusan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasikaryawan.Show()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub bttambah_Click(sender As Object, e As EventArgs) Handles bttambah.Click
        cls()

        stts = "simpan"
        btsimpan.Enabled = True

        ' Point 5
        tbkodejurusan.Text = generateid("select top 1 id from tabjurusan order by id desc", "S")
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        cls()

        stts = "update"
        btsimpan.Enabled = True
        bthapus.Enabled = True
    End Sub

    Private Sub bthapus_Click(sender As Object, e As EventArgs) Handles bthapus.Click
        ' Point 6
        Dim dtcek As New DataTable
        dtcek = bacadb("select * from tabsiswa where pri_jur1 = '" & tbkodejurusan.Text & "' or pri_jur2 = '" & tbkodejurusan.Text & "' or pri_jur3 = '" & tbkodejurusan.Text & "'")

        If dtcek.Rows.Count > 0 Then
            MsgBox("Jurusan sudah berisi siswa!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        ' hapus data
        simpandb("delete from tabjurusan where id = '" & tbkodejurusan.Text & "'")

        MsgBox("Data berhasil dihapus", MsgBoxStyle.Information, "Info")

        cls()
    End Sub

    Private Sub btbrowse_Click(sender As Object, e As EventArgs) Handles btbrowse.Click
        ' openfiledialog mencari foto
        Dim op As New OpenFileDialog
        op.Filter = "Image Files|*.jpg;*.png"
        op.Title = "Pilih gambar jurusan"

        If op.ShowDialog = DialogResult.OK Then
            ' jika file yang dipilih ada
            pb.Image = Image.FromFile(op.FileName)
            ' fungsi tag untuk menandai dimana lokasi gambar berada
            ' mempermudah saat simpan
            pb.Tag = op.FileName
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If stts = "update" Then
            ' ketika rows nya di pilih maka akan mengambil cell ke 0 nya
            Dim id As String = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(0).Value.ToString

            ' +--------+--------+--------+--------+
            '     id      nama     penj    foto    
            ' +--------+--------+--------+--------+

            ' semua data akan disimpan pada dt terlebih dahulu
            Dim dt As New DataTable
            dt = bacadb("select * from tabjurusan where id = '" & id & "'")

            tbkodejurusan.Text = dt.Rows(0).Item(0)
            tbnamajurusan.Text = dt.Rows(0).Item(1)
            tbpenjelasanjurusan.Text = dt.Rows(0).Item(2)

            pb.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & dt.Rows(0).Item(3))
            ' fungsi tag untuk menandai dimana lokasi gambar berada
            ' mempermudah saat simpan
            pb.Tag = IO.Directory.GetCurrentDirectory & dt.Rows(0).Item(3)
        End If
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        ' Point 2
        If tbkodejurusan.Text = "" Or tbnamajurusan.Text = "" Or tbpenjelasanjurusan.Text = "" Or pb.Image Is Nothing Then
            MsgBox("Tolong lengkapi form!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        ' gunakan try karena jika gak dapet ngubah gambar kann gambarnya masih digunain di project
        ' jadi gak bisa diakses, untuk menghindari error gunakan try
        ' *coba jangan gunakan try biar tau errornya
        Try
            ' upload foto
            FileCopy(pb.Tag, IO.Directory.GetCurrentDirectory & "\gambar\jurusan\" & tbkodejurusan.Text & IO.Path.GetExtension(pb.Tag))
        Catch ex As Exception

        End Try

        If stts = "simpan" Then
            simpandb("insert into tabjurusan values('" & tbkodejurusan.Text & "','" & tbnamajurusan.Text & "','" & tbpenjelasanjurusan.Text & "','\gambar\jurusan\" & tbkodejurusan.Text & IO.Path.GetExtension(pb.Tag) & "')")

            MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
        End If

        If stts = "update" Then
            simpandb("update tabjurusan set nama = '" & tbnamajurusan.Text & "', penjelasan = '" & tbpenjelasanjurusan.Text & "', foto = '\gambar\jurusan\" & tbkodejurusan.Text & IO.Path.GetExtension(pb.Tag) & "' where id = '" & tbkodejurusan.Text & "'")

            MsgBox("Data berhasil diperbaharui!", MsgBoxStyle.Information, "Info")
        End If

        cls()
    End Sub
End Class