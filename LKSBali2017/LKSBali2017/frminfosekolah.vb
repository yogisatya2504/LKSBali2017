Public Class frminfosekolah
    ' Point :
    ' 1. Menampilkan foto dan informasi SMK Nasional
    ' 2. Menampilkan daftar jurusan di cbinfo

    ' Properties
    ' start position = center screen
    ' tbinfo :
    '   border style : none
    '   cursor : arrow
    '   readonly : true
    ' tabindex : sesuai saat aplikasi dijalankan
    ' pb : size mode : scretch

    Private Sub frminfosekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' isi dt nantinya adalah
        ' +--------+--------+
        ' |   id   |  nama  |
        ' +--------+--------+
        ' |        |        |
        ' +--------+--------+
        Dim dt As New DataTable
        dt = bacadb("select id, nama from tabjurusan")

        cbinfo.ValueMember = "id"
        cbinfo.DisplayMember = "nama"
        cbinfo.DataSource = dt
    End Sub

    Private Sub btkembali_Click(sender As Object, e As EventArgs) Handles btkembali.Click
        Me.Close()
    End Sub

    Private Sub frminfosekolah_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmmain.Show()
    End Sub

    Private Sub btlihatinfo_Click(sender As Object, e As EventArgs) Handles btlihatinfo.Click
        Me.Hide()
        frminfojurusan.Show()
    End Sub
End Class