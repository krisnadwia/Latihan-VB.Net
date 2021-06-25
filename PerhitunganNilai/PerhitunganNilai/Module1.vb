Imports MySql.Data.MySqlClient
Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public QUERY As String
    Public DS As DataSet
    Public DT As DataTable
    Public str As String
    Public strCari As String
    Public CodeCari As Boolean
    Public strMenuAkses As String
    Public strUser As String
    Sub koneksi()
        Try
            Dim str As String = "server=localhost;user id=root;password=;database=perhitungan_nilai"
            CONN = New MySqlConnection(str)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
                MsgBox("Database Berhasil TERKONEKSI")
            End If
        Catch ex As Exception
            MsgBox("Database Tidak Bisa Terhubung, Silahkan Cek Koneksi", MsgBoxStyle.Information, "Pemberitahuan")
        End Try
    End Sub
End Module
