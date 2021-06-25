<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaftarNilaiMahasiswa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCariSQL = New System.Windows.Forms.TextBox()
        Me.btnCariSQL = New System.Windows.Forms.Button()
        Me.gridData = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCariSQL
        '
        Me.txtCariSQL.Location = New System.Drawing.Point(80, 383)
        Me.txtCariSQL.Name = "txtCariSQL"
        Me.txtCariSQL.Size = New System.Drawing.Size(259, 20)
        Me.txtCariSQL.TabIndex = 43
        '
        'btnCariSQL
        '
        Me.btnCariSQL.Location = New System.Drawing.Point(345, 383)
        Me.btnCariSQL.Name = "btnCariSQL"
        Me.btnCariSQL.Size = New System.Drawing.Size(103, 23)
        Me.btnCariSQL.TabIndex = 42
        Me.btnCariSQL.Text = "Cari di MySql"
        Me.btnCariSQL.UseVisualStyleBackColor = True
        '
        'gridData
        '
        Me.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridData.Location = New System.Drawing.Point(12, 12)
        Me.gridData.Name = "gridData"
        Me.gridData.Size = New System.Drawing.Size(790, 368)
        Me.gridData.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 383)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Ketik Nama"
        '
        'frmDaftarNilaiMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 421)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCariSQL)
        Me.Controls.Add(Me.btnCariSQL)
        Me.Controls.Add(Me.gridData)
        Me.Name = "frmDaftarNilaiMahasiswa"
        Me.Text = "Daftar Nilai Mahasiswa"
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCariSQL As TextBox
    Friend WithEvents btnCariSQL As Button
    Friend WithEvents gridData As DataGridView
    Friend WithEvents Label1 As Label
End Class
