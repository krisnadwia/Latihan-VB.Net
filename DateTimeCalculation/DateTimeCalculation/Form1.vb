Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim d1 As DateTime = DateTimePicker1.Value
        Dim d2 As DateTime = DateTimePicker2.Value
        Dim result As TimeSpan = d1.Subtract(d2)
        Dim days As Integer = result.TotalDays
        txtResult.Text = days
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResult.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        MsgBox("KDA", vbInformation, "Date Time Calculation")
    End Sub
End Class
