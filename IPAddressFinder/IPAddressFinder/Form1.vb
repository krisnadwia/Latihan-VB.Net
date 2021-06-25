Imports System.Net
Public Class Form1
    <Obsolete>
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim hostname As IPHostEntry = Dns.GetHostByName(txtHost.Text)
        Dim ip As IPAddress() = hostname.AddressList
        txtIP.Text = ip(0).ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHost.Clear()
        txtIP.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCredit_Click(sender As Object, e As EventArgs) Handles btnCredit.Click
        MsgBox("Krisna Dwi Andrianto", vbInformation, "IP Address Finder")
    End Sub
End Class