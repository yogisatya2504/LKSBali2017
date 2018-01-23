Public Class frmdownloadsoal
    ' Point
    ' 1. jika siswa membuka form ini sebelum waktu ujian maka semua tombol akan disable
    ' 2. timer akan berjalan setelah siswa mendownload saol
    ' 3. pastikan soal yang didownload sesuai dengan jadwal
    ' 4. saat textbox jawaban diklik maka akan muncul openfiledialog untuk uplaod jawaban
    '    btupload berfungsi untuk mengupload soal dan simpan ke db
    ' 5. siswa bisa upload soal sampai 3x, tapi soal terakhir saja yang akan diperiksa
    ' 6. jika waktu selesai tapi siswa tidak memfinalize maka akan otomatis finalize
    ' 7. pastikan timer terus berjalan jika form di close cek frmnavigasisiswa line 28

    ' untuk banyak upload
    Dim bup As Integer = 0
    Dim dt As New DataTable
    Dim dtdgv As New DataTable
    ' untuk upload soal
    Dim op As New OpenFileDialog

    ' status untuk point 1
    Dim stts As String = ""

    Private Sub cls()
        ' point 1
        dt = bacadb("select id, tglujian, soal, durasi from tabjadwal where id = (select idjadwal from tabaktivitasujian where id = '" & frmlogin.tbusername.Text & "')")

        If dt.Rows(0).Item(1) > Now Then
            stts = "lewat"
        End If

        If stts = "lewat" Then
            tbupload.Enabled = False
            btupload.Enabled = False
            btfinalize.Enabled = False
            lbdownload.Enabled = False

            Exit Sub
        End If

        tbjadwal.Text = dt.Rows(0).Item(0)

        dtdgv.Columns.Add("Nama File")
        dtdgv.Columns.Add("Waktu Upload")

        Dim dtx As New DataTable
        dtx = bacadb("select jawaban_siswa, waktu_up1, waktu_up2, waktu_up3, status from tabaktivitasujian where id = '" & frmlogin.tbusername.Text & "'")
        If dtx.Rows(0).Item(4) = "Belum Diperiksa" Then
            dtdgv.Rows.Add(IO.Path.GetFileName(dtx.Rows(0).Item(0)), dt.Rows(0).Item(1))
            dtdgv.Rows.Add(IO.Path.GetFileName(dtx.Rows(0).Item(0)), dt.Rows(0).Item(2))
            dtdgv.Rows.Add(IO.Path.GetFileName(dtx.Rows(0).Item(0)), dt.Rows(0).Item(3))
        End If

        dgv.DataSource = dtdgv
    End Sub

    Private Sub frmdownloadsoal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub lbdownload_Click(sender As Object, e As EventArgs) Handles lbdownload.Click
        ' pilih folder tempat simpan soal
        Dim ds As New FolderBrowserDialog
        If ds.ShowDialog Then
            FileCopy(IO.Directory.GetCurrentDirectory & dt.Rows(0).Item(2), ds.SelectedPath & "\" & frmlogin.tbusername.Text & IO.Path.GetExtension(dt.Rows(0).Item(2)))

            MsgBox("File berhasil didownload!" & vbNewLine & ds.SelectedPath, MsgBoxStyle.Information, "Info")

            ' point 2 & 7
            frmnavigasisiswa.sisawaktu = dt.Rows(0).Item(3) * 60
            frmnavigasisiswa.timer.Start()

        End If
    End Sub

    Private Sub frmdownloadsoal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasisiswa.Show()
    End Sub


    Private Sub tbupload_Click(sender As Object, e As EventArgs) Handles tbupload.Click
        op.Title = "Pilih jawaban"
        If op.ShowDialog Then
            tbupload.Text = op.SafeFileName
        End If
    End Sub

    Private Sub btupload_Click(sender As Object, e As EventArgs) Handles btupload.Click
        If tbupload.Text = "" Then
            Exit Sub
        End If

        ' Point 5
        If bup = 3 Then
            MsgBox("Upload max 3x!", MsgBoxStyle.Critical)
            ' update status ke belum diperiksa
            simpandb("update tabaktivitasujian set status = 'Belum Diperiksa' where id = '" & frmlogin.tbusername.Text & "'")

            Exit Sub
        End If

        bup += 1

        Dim dtx As New DataTable
        dtx = bacadb("select jawaban_siswa, waktu_up" & bup & ", status from tabaktivitasujian where id = '" & frmlogin.tbusername.Text & "'")

        If dtx.Rows(0).Item(2) = "Belum Diperiksa" Then
            MsgBox("Anda sudah memfinalize jawaban!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ' upload
        FileCopy(op.FileName, IO.Directory.GetCurrentDirectory & "\jawaban\" & frmlogin.tbusername.Text & IO.Path.GetExtension(op.FileName))

        ' simpan db
        Dim str As String = "update tabaktivitasujian set waktu_up" & bup & " = '" & Now.Year & "-" & Now.Month & "-" & Now.Day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "', jawaban_siswa = '\jawaban\" & frmlogin.tbusername.Text & IO.Path.GetExtension(op.FileName) & "' where id = '" & frmlogin.tbusername.Text & "'"
        simpandb(str)

        dtdgv.Rows.Add(IO.Path.GetFileName(dtx.Rows(0).Item(0)), dt.Rows(0).Item(1))
        dgv.DataSource = dtdgv
    End Sub

    Private Sub btfinalize_Click(sender As Object, e As EventArgs) Handles btfinalize.Click
        ' update status ke belum diperiksa
        simpandb("update tabaktivitasujian set status = 'Belum Diperiksa' where id = '" & frmlogin.tbusername.Text & "'")
        Me.Close()
    End Sub
End Class