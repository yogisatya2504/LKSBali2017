Public Class frmnavigasisiswa
    ' Point
    ' 1. Pastikan nama tampil

    Private Sub frmnavigasisiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = bacadb("select nama from tabsiswa where id = '" & frmlogin.tbusername.Text & "'")

        lbwelcome.Text = "Selamat datang, " & dt.Rows(0).Item(0) & "!"
    End Sub

    Private Sub btlogout_Click(sender As Object, e As EventArgs) Handles btlogout.Click
        If MsgBox("Logout?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question) = MsgBoxResult.Ok Then
            Me.Close()
        End If
    End Sub

    Private Sub frmnavigasisiswa_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmlogin.cls()
        frmlogin.Show()
    End Sub
End Class