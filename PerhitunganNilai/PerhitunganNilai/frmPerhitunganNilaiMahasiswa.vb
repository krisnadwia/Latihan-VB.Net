Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmPerhitunganNilaiMahasiswa
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        txtHasilAbsen.Text = 0.1 * Val(txtNilaiAbsen.Text)
        txtHasilTugas.Text = 0.2 * Val(txtNilaiTugas.Text)
        txtHasilUTS.Text = 0.3 * Val(txtNilaiUTS.Text)
        txtHasilUAS.Text = 0.4 * Val(txtNilaiUAS.Text)

        txtTotalNilai.Text = CDbl(txtHasilAbsen.Text) + CDbl(txtHasilTugas.Text) + CDbl(txtHasilUTS.Text) + CDbl(txtHasilUAS.Text)

        If txtTotalNilai.Text >= 0 And txtTotalNilai.Text < 35 Then
            txtGrade.Text = "E"
            txtKeterangan.Text = "Nilai Anda Sangat Kurang! Maaf, Anda Tidak Lulus!"
        ElseIf txtTotalNilai.Text >= 35 And txtTotalNilai.Text < 50 Then
            txtGrade.Text = "D"
            txtKeterangan.Text = "Nilai Anda Kurang! Maaf, Anda Tidak Lulus!"
        ElseIf txtTotalNilai.Text >= 50 And txtTotalNilai.Text < 65 Then
            txtGrade.Text = "C"
            txtKeterangan.Text = "Nilai Anda Cukup! Anda Lulus, Tingkatkan Lagi!"
        ElseIf txtTotalNilai.Text >= 65 And txtTotalNilai.Text < 80 Then
            txtGrade.Text = "B"
            txtKeterangan.Text = "Nilai Anda Baik! Anda Lulus, Pertahankan!"
        ElseIf txtTotalNilai.Text >= 80 And txtTotalNilai.Text <= 100 Then
            txtGrade.Text = "A"
            txtKeterangan.Text = "Nilai Anda Sangat Baik! Anda Lulus, Selamat!"
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtNilaiAbsen.Clear()
        txtNilaiTugas.Clear()
        txtNilaiUTS.Clear()
        txtNilaiUAS.Clear()
        txtHasilAbsen.Clear()
        txtHasilTugas.Clear()
        txtHasilUTS.Clear()
        txtHasilUAS.Clear()
        txtTotalNilai.Clear()
        txtGrade.Clear()
        txtKeterangan.Clear()
        txtNIM.Clear()
        txtNama.Clear()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        MsgBox("KDA", vbInformation, "Info")
    End Sub

    Private Sub btnTesKoneksi_Click(sender As Object, e As EventArgs) Handles btnTesKoneksi.Click
        Call koneksi()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Anda yakin data sudah benar?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call koneksi()
        Try
            Dim str As String
            CMD = New MySqlCommand("select * from nilai where nama='" & txtNama.Text & "'", CONN)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows = False Then 'Mode Tambah Data
                str = "insert into nilai values ('" & txtNIM.Text & "','" &
                txtNama.Text & "', '" &
                txtTotalNilai.Text & "', '" &
                txtGrade.Text & "', '" &
                txtKeterangan.Text & "')"
                DR.Close()
                CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Disimpan", vbInformation, "Info")
                Call Bersih()
            Else 'Mode Edit Data
                DR.Close()
                If MsgBox("Data sudah ada sebelumnya, Anda ingin mengupdate?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
                str = "update nilai set nim='" & txtNIM.Text &
                "', nama='" & txtNama.Text &
               "', total_nilai='" & txtTotalNilai.Text &
               "', grade='" & txtGrade.Text &
               "', keterangan='" & txtKeterangan.Text &
               "' Where nama='" & txtNama.Text & "'"
                CMD = New MySqlCommand(str, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil Terupdate", vbInformation, "Info")
                Call Bersih()
            End If
        Catch ex As Exception
            MsgBox("Data Tidak Berhasil Disimpan", vbInformation, "Error")
        End Try
    End Sub

    Private Sub Bersih()
        txtNIM.Text = "" : txtNama.Text = "" : txtTotalNilai.Text = "" : txtGrade.Text = "" : txtKeterangan.Text = "" : txtNama.Focus()
    End Sub

    Public Sub Cari()
        If CodeCari = False Then strCari = InputBox("Masukkan NIM atau Nama!", "Cari Data")
        Call koneksi()
        If Val(strCari) <> 0 Or CodeCari = True Then 'Pencarian by NIM
            CMD = New MySqlCommand("select * from nilai where nim= '" & strCari & "'", CONN)
        Else 'Pencarian by Nama
            CMD = New MySqlCommand("select * from nilai where nama like '%" & strCari & "%'", CONN)
        End If
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = False Then
            MsgBox("Data Tidak Ditemukan", vbInformation, "Info")
        Else 'Data ditemukan
            txtNIM.Text = DR.Item(0)
            txtNama.Text = DR.Item(1)
            txtTotalNilai.Text = DR.Item(2)
            txtGrade.Text = DR.Item(3)
            txtKeterangan.Text = DR.Item(4)
        End If
        DR.Close() : txtNama.Focus() : strCari = "" : CodeCari = False
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        Call Cari()
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If MsgBox("Anda yakin ingin menghapus?", vbYesNo, "Konfirmasi") = vbNo Then Exit Sub
        Call koneksi()
        str = "delete from nilai where nama ='" & txtNama.Text & "'"
        CMD = New MySqlCommand(str, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil Terhapus", vbInformation, "Info")
        Call Bersih()
    End Sub

    Private Sub btnCariSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariSQL.Click
        If txtCariSQL.Text = "" Then
            str = "select * from nilai"
        End If
        Call koneksi()
        DA = New MySqlDataAdapter(str, CONN)
        DT = New DataTable
        DA.Fill(DT)
        gridData.DataSource = DT
        CONN.Close()

        If txtCariSQL.Text = "" Then
            txtCariSQL.Focus()
        Else
            Try
                Call koneksi()
                Using sql As New MySqlCommand("select * from nilai where nama like '%" & txtCariSQL.Text & "%'", CONN)
                    Using dr As MySqlDataReader = sql.ExecuteReader()
                        Using dt As New DataTable
                            dt.Load(dr)
                            If dt.Rows.Count = 0 Then
                                'DataGridView1.DataSource = Nothing
                                MsgBox("Data tidak Ditemukan", MsgBoxStyle.Information, "Information")
                            Else
                                gridData.AutoGenerateColumns = False
                                gridData.DataSource = dt
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                CONN.Close()
            End Try
        End If
    End Sub

    Private Sub gridData_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridData.CellClick
        strCari = gridData.Rows(e.RowIndex).Cells(0).Value
        Me.Cari()
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.gridData.Width, Me.gridData.Height)
        gridData.DrawToBitmap(bm, New Rectangle(0, 0, Me.gridData.Width, Me.gridData.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

End Class