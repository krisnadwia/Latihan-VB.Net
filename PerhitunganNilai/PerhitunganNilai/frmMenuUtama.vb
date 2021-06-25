Public Class frmMenuUtama
    Private Sub PerhitunganNilaiMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerhitunganNilaiMahasiswaToolStripMenuItem.Click
        frmPerhitunganNilaiMahasiswa.ShowDialog()
    End Sub

    Private Sub frmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "User:"
        ToolStripStatusLabel2.Text = "Perhitungan Nilai Mahasiswa"
        ToolStripStatusLabel3.Text = Today
        ToolStripStatusLabel4.Text = TimeOfDay
    End Sub

    Private Sub DaftarNilaiMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DaftarNilaiMahasiswaToolStripMenuItem.Click
        frmDaftarNilaiMahasiswa.ShowDialog()
    End Sub
End Class