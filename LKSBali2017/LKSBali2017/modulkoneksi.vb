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

    Public Function generateid(s As String, sep As String)
        Dim strid As String = sep

        Dim dt As New DataTable
        dt = bacadb(s)

        Dim idx As Integer = Split(dt.Rows(0).Item(0).ToString, sep)(1) + 1
        For i As Integer = idx.ToString.Length + strid.Length To 4
            strid &= "0"
        Next
        strid &= idx

        Return strid
    End Function
End Module
