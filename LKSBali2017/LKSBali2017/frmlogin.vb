Public Class frmlogin
    ' Point
    ' 1. Pastikan form terisi dengan benar
    ' 2. Pesan error :
    '    Username not found
    '    Incorrect password
    '    You do not have permission to enter as this role

    Friend Sub cls()
        tbpwd.Text = ""
        tbusername.Text = ""

        lberror.Text = ""
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan role
        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("nama")

        dt.Rows.Add("1", "Siswa")
        dt.Rows.Add("2", "Guru")
        dt.Rows.Add("3", "Karyawan")
        dt.Rows.Add("4", "Karyawan + Guru")

        cbrole.ValueMember = "id"
        cbrole.DisplayMember = "nama"
        cbrole.DataSource = dt

        cls()
    End Sub

    Private Sub frmlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmmain.Show()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Close()
    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click
        ' Point 1
        If tbpwd.Text = "" Or tbusername.Text = "" Then
            MsgBox("Lengkapi Form!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        ' Point 2.1
        Dim dt As New DataTable
        dt = bacadb("select * from tabuser where username = '" & tbusername.Text & "'")

        If dt.Rows.Count = 0 Then
            lberror.Text = "Username not found!"
            Exit Sub
        End If

        ' Point 2.2
        dt.Clear()
        dt = bacadb("select * from tabuser where username = '" & tbusername.Text & "' and CONVERT(varchar, [password]) = '" & tbpwd.Text & "'")

        If dt.Rows.Count = 0 Then
            lberror.Text = "Incorect password!"
            Exit Sub
        End If

        ' Point 2.3
        dt.Clear()
        dt = bacadb("select * from tabuser where username = '" & tbusername.Text & "' and CONVERT(varchar, [password]) = '" & tbpwd.Text & "' and role = '" & cbrole.SelectedValue & "'")

        If dt.Rows.Count = 0 Then
            lberror.Text = "You do not have permission to enter as this role"
            Exit Sub
        End If

        Me.Hide()

        If cbrole.SelectedValue = "1" Then
            ' Siswa
            frmnavigasisiswa.Show()
        ElseIf cbrole.SelectedValue = "2" Or cbrole.SelectedValue = "4" Then
            ' Guru
            frmnavigasiguru.Show()
        ElseIf cbrole.SelectedValue = "3" Or cbrole.SelectedValue = "4" Then
            ' Karyawan
            frmnavigasikaryawan.Show()
        ElseIf cbrole.SelectedValue = "4" Then
            ' Karyawan + Guru
            frmnavigasikaryawan.Show()
            frmnavigasiguru.Show()
            ' agar posisi form navigasi guru berada di samping frmnavogasikaryawan
            frmnavigasiguru.Location = New Point(frmnavigasikaryawan.Location.X + frmnavigasikaryawan.Width, frmnavigasikaryawan.Location.Y)
        End If
    End Sub
End Class