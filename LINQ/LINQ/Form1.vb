Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kata As String() = txtKalimat.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries)
        Dim jumlahKata As Integer = kata.Count
        MessageBox.Show(jumlahKata)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim jumlahChar As Integer = (From chars In txtKalimat.Text Select chars).Count
        MessageBox.Show(jumlahChar)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim huruf = (From kalimat In txtKalimat.Text Where Char.IsLetter(kalimat) Select kalimat).Count
        MessageBox.Show(huruf)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim angka = (From kalimat In txtKalimat.Text Where Char.IsDigit(kalimat) Select kalimat).Count
        MessageBox.Show(angka)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim kata As String() = txtKalimat.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries)
        Dim maxKata = From k In kata Group By k Into Group Select textKata = k, jumlah = Group.Count Order By jumlah Descending
        Dim kataTerbanyak = maxKata.First
        MessageBox.Show("Kata yang paling banyak muncul adalah : " & kataTerbanyak.textKata & vbCrLf & "Sebanyak :" & kataTerbanyak.jumlah)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim hurufLINQ = From l In txtKalimat.Text Where Char.IsLetter(l) Group l By key = l Into Group Select huruf = key, jumlah = Group.Count
        Dim hurufTerbanyak = hurufLINQ.First
        MessageBox.Show("Huruf yang paling banyak muncul adalah : " & hurufTerbanyak.huruf & vbCrLf & "Sebanyak :" & hurufTerbanyak.jumlah)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim kata As String() = txtKalimat.Text.Split(New Char() {}, StringSplitOptions.RemoveEmptyEntries)
        Dim jumlahKata As Integer = (From intkata In kata Where intkata = txtFilter.Text Select intkata).Count
        MessageBox.Show(jumlahKata)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim kata As String() = txtKalimat.Text.Split(New Char() {" ", ",", ".", ";", ":"}, StringSplitOptions.RemoveEmptyEntries)
        Dim groupLINQ = From w In kata Group w By key = w Into Group Select word = key, jumlah = Group.Count
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = groupLINQ.ToList
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim hurufLINQ = From l In txtKalimat.Text Where Char.IsLetter(l) Group l By key = l Into Group Select huruf = key, jumlah = Group.Count
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = hurufLINQ.ToList
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim angkaLINQ = From l In txtKalimat.Text Where Char.IsNumber(l) Group l By key = l Into Group Select huruf = key, jumlah = Group.Count
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = angkaLINQ.ToList
    End Sub
End Class