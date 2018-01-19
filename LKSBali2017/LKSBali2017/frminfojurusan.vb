Public Class frminfojurusan
    ' Point
    ' 1. Pastikan semua komponen terisi dengan benar sesuai dengan data

    Private Sub frminfojurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' isi dt nantinya adalah
        ' +--------+--------+--------+--------+
        ' |   id   |  nama  |  penj  |  foto  |
        ' +--------+--------+--------+--------+
        ' |        |        |        |        |
        ' +--------+--------+--------+--------+
        Dim dt As New DataTable
        dt = bacadb("select * from tabjurusan where id = '" & frminfosekolah.cbinfo.SelectedValue & "'")

        lbnama.Text = dt.Rows(0).Item(1).ToString
        tbinfo.Text = dt.Rows(0).Item(2).ToString
        pb.Image = Image.FromFile(IO.Directory.GetCurrentDirectory & dt.Rows(0).Item(3).ToString)
    End Sub

    Private Sub frminfojurusan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frminfosekolah.Show()
    End Sub

    Private Sub btkembali_Click(sender As Object, e As EventArgs) Handles btkembali.Click
        Me.Close()
    End Sub
End Class