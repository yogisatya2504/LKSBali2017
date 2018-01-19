Imports System.Data.SqlClient

Module modulkoneksi
    Dim str As String = "Data Source=DESKTOP-D2PBETU\SQLEXPRESS;Initial Catalog=LKSBali2017;Integrated Security=True"

    Public Function bacadb(s As String)
        Dim dt As New DataTable

        ' try untuk mempermudah analisis error
        Try
            Using conn As New SqlConnection(str)
                conn.Open()
                Dim cmd As New SqlCommand(s, conn)
                Dim dr As SqlDataReader = cmd.ExecuteReader
                dt.Load(dr)
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return dt
    End Function

    Public Sub simpandb(s As String)
        Try
            Using conn As New SqlConnection(str)
                conn.Open()
                Dim cmd As New SqlCommand(s, conn)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
