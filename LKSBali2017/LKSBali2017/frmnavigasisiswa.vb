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

    Private Sub btunduh_Click(sender As Object, e As EventArgs) Handles btunduh.Click
        Me.Hide()
        frmdownloadsoal.Show()
    End Sub

    Friend sisawaktu As Integer
    Friend waktu As String = ""
    Friend Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If sisawaktu > 0 Then
            sisawaktu -= 1
            waktu = konvertwaktu(sisawaktu)

            frmdownloadsoal.lbtimer.Text = waktu
        Else
            waktu = "00 : 00 : 00"
            frmdownloadsoal.btfinalize.PerformClick()
            timer.Stop()
        End If
    End Sub
    Public Function konvertwaktu(waktu As Integer) As String
        Dim jam As Integer
        Dim min As Integer
        Dim sec As Integer

        'Seconds'
        sec = waktu Mod 60

        'Minutes'
        min = ((waktu - sec) / 60) Mod 60

        'Jam'
        jam = ((waktu - (sec + (min * 60))) / 3600) Mod 60

        Return Format(jam, "00") & ":" & Format(min, "00") & ":" & Format(sec, "00")
    End Function

    Private Sub btlihat_Click(sender As Object, e As EventArgs) Handles btlihat.Click
        Dim dt As New DataTable
        dt = bacadb("select [status] from tabaktivitasujian where id = '" & frmlogin.tbusername.Text & "'")

        If dt.Rows(0).Item(0) = "Belum Dikoreksi" Or dt.Rows(0).Item(0) = "Belum Ujian" Then
            MsgBox("Maaf jawaban anda belum dikoreksi", MsgBoxStyle.Information)
            Exit Sub
        End If

        Me.Hide()
        frmhasiltesindividu.Show()
    End Sub
End Class