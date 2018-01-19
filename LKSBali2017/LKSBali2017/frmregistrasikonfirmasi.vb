Public Class frmregistrasikonfirmasi
    ' Point
    ' 1. Data disimpan dulu baru tampilkan form ini
    ' 2. Nomor pendaftaran auto increment : 5 char diawali 0
    ' 3. Format password : no.pendaftaran + tgllahir (mmddyy)

    Private Sub frmregistrasikonfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = bacadb("select tabsiswa.id, tabuser.[password], tabsiswa.nama, jur1.nama, jur2.nama, jur3.nama from tabsiswa inner join tabuser on tabuser.username = tabsiswa.id inner join tabjurusan as jur1 on jur1.id = tabsiswa.pri_jur1 inner join tabjurusan as jur2 on jur2.id = tabsiswa.pri_jur2 inner join tabjurusan as jur3 on jur3.id = tabsiswa.pri_jur3 where tabsiswa.id = '" & frmregistrasisiswa.strid & "'")

        lbnodaftar.Text = dt.Rows(0).Item(0)
        lbusername.Text = dt.Rows(0).Item(0)
        lbpwd.Text = dt.Rows(0).Item(1)
        lbnama.Text = dt.Rows(0).Item(2)
        lbpri1.Text = dt.Rows(0).Item(3)
        lbpri2.Text = dt.Rows(0).Item(4)
        lbpri3.Text = dt.Rows(0).Item(5)
    End Sub

    Private Sub btsubmit_Click(sender As Object, e As EventArgs) Handles btsubmit.Click
        Me.Close()
    End Sub
End Class