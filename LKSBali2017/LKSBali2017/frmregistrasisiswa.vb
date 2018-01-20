Public Class frmregistrasisiswa
    ' Point
    ' 1. Pastikan semua komponen terisi sebelum di simpan
    ' 2. Pastikan jurusan yang telah terpilih tidak ditampilkan lagi pada pemilihan jurusan lain
    ' 3. Random char untuk konfirmasi kode : 10 char (a-z, A-z, nomor, simbol)
    ' 4. Keluarkan error jika salah input konfirmasi kode
    ' 5. Umur calon siswa > 18 tahun

    ' sebagai penanda
    Dim procls As Boolean = True
    ' untuk id generate
    Friend strid As String = ""

    Friend Sub cls()
        procls = True

        ' reset form
        tbalamat.Text = ""
        tbasalsekolah.Text = ""
        tbkode.Text = ""
        tbnama.Text = ""
        tbnotelp.Text = ""

        ' Point 3
        Dim s As String = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$"
        Dim str As String = ""

        Dim rnd As New Random

        For i As Integer = 1 To 10
            Dim idx As Integer = rnd.Next(0, s.Length)
            str += s.Substring(idx, 1)
        Next

        lbkode.Text = str

        ' Point 2
        ' load pilihan jurusan
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

        ' reset radio button
        rblaki.Checked = False
        rbperempuan.Checked = False

        procls = False
    End Sub

    Private Sub frmregistrasisiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub frmregistrasisiswa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmmain.Show()
    End Sub

    ' saat piljur1 berubah indexnya maka piljur2 dan 3 diload ulang
    Private Sub cbpiljurusan1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpiljurusan1.SelectedIndexChanged
        If procls = False Then
            procls = True

            cbpiljurusan2.ValueMember = "id"
            cbpiljurusan2.DisplayMember = "nama"
            cbpiljurusan2.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "'")

            cbpiljurusan3.ValueMember = "id"
            cbpiljurusan3.DisplayMember = "nama"
            cbpiljurusan3.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "' and id <> '" & cbpiljurusan2.SelectedValue & "'")

            procls = False
        End If
    End Sub

    ' saat piljur2 berubah index maka load ulang piljur3
    Private Sub cbpiljurusan2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpiljurusan2.SelectedIndexChanged
        If procls = False Then
            procls = True

            cbpiljurusan3.ValueMember = "id"
            cbpiljurusan3.DisplayMember = "nama"
            cbpiljurusan3.DataSource = bacadb("select id, nama from tabjurusan where id <> '" & cbpiljurusan1.SelectedValue & "' and id <> '" & cbpiljurusan2.SelectedValue & "'")

            procls = False
        End If
    End Sub

    Private Sub btsubmit_Click(sender As Object, e As EventArgs) Handles btsubmit.Click
        ' Point 1
        If tbalamat.Text = "" Or tbasalsekolah.Text = "" Or tbkode.Text = "" Or tbnama.Text = "" Or tbnotelp.Text = "" Then
            MsgBox("Lengkapi form!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        ' Point 4
        If tbkode.Text <> lbkode.Text Then
            MsgBox("Kode konfirmasi salah!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        ' Point 5
        Dim dtp As DateTime = Now
        dtp = dtp.AddYears(-18)
        If dtptgllahir.Value.Date > dtp.Date Then
            MsgBox("Umur harus lebih dari 18 tahun!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        ' Generate Id
        Dim dt As New DataTable
        dt = bacadb("select top 1 id from tabsiswa order by id desc")

        Dim idx As Integer = dt.Rows(0).Item(0) + 1
        For i As Integer = idx.ToString.Length To 4
            strid &= "0"
        Next
        strid &= idx

        ' Simpan data
        Try
            Dim jk As String = ""
            If rblaki.Checked = True Then
                jk = "Laki - Laki"
            Else
                jk = "Perempuan"
            End If
            ' Simpan tabsiswa
            simpandb("insert into tabsiswa values('" & strid & "','" & tbnama.Text & "','" & tbalamat.Text & "','" & dtptgllahir.Value.Month & "/" & dtptgllahir.Value.Day & "/" & dtptgllahir.Value.Year & "','" & tbnotelp.Text & "','" & jk & "','" & tbasalsekolah.Text & "','" & cbpiljurusan1.SelectedValue & "','" & cbpiljurusan2.SelectedValue & "','" & cbpiljurusan3.SelectedValue & "')")

            ' Simpan tabuser
            simpandb("insert into tabuser values('" & strid & "','" & strid & Format(dtptgllahir.Value, "MMddyy") & "','1')")

            MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Info")

            frmregistrasikonfirmasi.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class