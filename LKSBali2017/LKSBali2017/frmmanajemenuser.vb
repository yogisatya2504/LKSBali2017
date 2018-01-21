Public Class frmmanajemenuser
    ' Point
    ' 1. Karyawan atau siswa yang terdaftar akan merubah username dan password disini
    ' 2. Karyawan dapat menjadi guru dan karyawan sedangkan siswa hanya siswa
    ' 3. Simpan hanya muncul saat perbaharui di klik
    ' 4. Pastikan semua fungsi berjalan dengan normal

    Dim stts As String = ""

    Private Sub cls()
        tbpwd.Text = ""
        tbuname.Text = ""

        btsimpan.Enabled = False

        cbkaryawan.Checked = False
        cbguru.Checked = False
        cbsiswa.Checked = False

        tbuname.Enabled = False

        Dim dt As New DataTable
        dt = bacadb("select * from tabuser")

        dgv.DataSource = dt

        stts = ""
    End Sub

    Private Sub frmmanajemenuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls()
    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        stts = "update"
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        If stts = "update" Then
            ' ketika rows nya di pilih maka akan mengambil cell ke 0 nya
            Dim id As String = dgv.Rows(dgv.CurrentCell.RowIndex).Cells(0).Value.ToString

            ' +--------+--------+--------+
            '   uname      pwd     role
            ' +--------+--------+--------+

            ' semua data akan disimpan pada dt terlebih dahulu
            Dim dt As New DataTable
            dt = bacadb("select * from tabuser where username = '" & id & "'")

            tbuname.Text = dt.Rows(0).Item(0)
            tbpwd.Text = dt.Rows(0).Item(1)

            cbkaryawan.Checked = False
            cbguru.Checked = False
            cbsiswa.Checked = False

            If dt.Rows(0).Item(2) = "1" Then
                ' siswa
                cbsiswa.Checked = True
            End If

            If dt.Rows(0).Item(2) = "2" Then
                ' guru
                cbguru.Checked = True
            End If

            If dt.Rows(0).Item(2) = "3" Then
                ' karyawan
                cbkaryawan.Checked = True
            End If

            If dt.Rows(0).Item(2) = "4" Then
                ' karyawan + guru
                cbguru.Checked = True
                cbkaryawan.Checked = True
            End If

            btsimpan.Enabled = True
        End If
    End Sub

    Private Sub cbsiswa_CheckedChanged(sender As Object, e As EventArgs) Handles cbsiswa.CheckedChanged
        If cbguru.Checked = True Or cbkaryawan.Checked = True Then
            cbsiswa.Checked = False
        End If
    End Sub

    Private Sub cbkaryawan_CheckedChanged(sender As Object, e As EventArgs) Handles cbkaryawan.CheckedChanged
        If cbsiswa.Checked = True Then
            cbkaryawan.Checked = False
        End If
    End Sub

    Private Sub cbguru_CheckedChanged(sender As Object, e As EventArgs) Handles cbguru.CheckedChanged
        If cbsiswa.Checked = True Then
            cbguru.Checked = False
        End If
    End Sub

    Private Sub btkembali_Click(sender As Object, e As EventArgs) Handles btkembali.Click
        Me.Close()
    End Sub

    Private Sub frmmanajemenuser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmnavigasikaryawan.Show()
    End Sub

    Private Sub btsimpan_Click(sender As Object, e As EventArgs) Handles btsimpan.Click
        If tbpwd.Text = "" Or tbuname.Text = "" Or (cbguru.Checked = False And cbkaryawan.Checked = False And cbsiswa.Checked = False) Then
            MsgBox("Tolong lengkapi form!", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Dim role As Integer
        If cbguru.Checked = True And cbkaryawan.Checked = True Then
            role = 4
        ElseIf cbguru.Checked = True Then
            role = 2
        ElseIf cbkaryawan.Checked = True Then
            role = 3
        Else
            role = 1
        End If

        simpandb("update tabuser set [password] = '" & tbpwd.Text & "', [role] = '" & role & "' where username = '" & tbuname.Text & "'")

        MsgBox("Data berhasil diperbaharui")

        cls()
    End Sub
End Class