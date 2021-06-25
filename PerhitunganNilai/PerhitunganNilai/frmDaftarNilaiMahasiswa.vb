Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class frmDaftarNilaiMahasiswa
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
        frmPerhitunganNilaiMahasiswa.Cari()
        Me.Close()
    End Sub
End Class