Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub Login()
        Call koneksi()
        CMD = New MySqlCommand("select * from login where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", CONN)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows = False Then
            MsgBox("Username dan Password Salah", vbInformation, "Info")
        Else 'Data ditemukan
            txtUsername.Text = "" : txtPassword.Text = ""
            frmMenuUtama.ShowDialog()
        End If
        DR.Close()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Call Login()
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call Login()
        End If
    End Sub
    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call Login()
        End If
    End Sub
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class