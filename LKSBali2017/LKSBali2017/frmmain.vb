Public Class frmmain
    ' Form utama

    Private Sub btinfo_Click(sender As Object, e As EventArgs) Handles btinfo.Click
        Me.Hide()
        frminfosekolah.Show()
    End Sub

    Private Sub btdaftar_Click(sender As Object, e As EventArgs) Handles btdaftar.Click
        Me.Hide()
        frmregistrasisiswa.Show()
    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
