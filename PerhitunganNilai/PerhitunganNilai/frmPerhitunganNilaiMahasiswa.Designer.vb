<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerhitunganNilaiMahasiswa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtNilaiAbsen = New System.Windows.Forms.TextBox()
        Me.txtNilaiTugas = New System.Windows.Forms.TextBox()
        Me.txtNilaiUTS = New System.Windows.Forms.TextBox()
        Me.txtNilaiUAS = New System.Windows.Forms.TextBox()
        Me.txtHasilAbsen = New System.Windows.Forms.TextBox()
        Me.txtHasilTugas = New System.Windows.Forms.TextBox()
        Me.txtHasilUTS = New System.Windows.Forms.TextBox()
        Me.txtHasilUAS = New System.Windows.Forms.TextBox()
        Me.txtTotalNilai = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnI = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.gridData = New System.Windows.Forms.DataGridView()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCariSQL = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnTesKoneksi = New System.Windows.Forms.Button()
        Me.txtCariSQL = New System.Windows.Forms.TextBox()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PERHITUNGAN NILAI MAHASISWA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Absen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai Tugas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai UTS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai UAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "10%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(428, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "20%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(428, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "30%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(428, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "40%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(170, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Nilai"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(170, 316)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Grade"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(170, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 23)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Keterangan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(643, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "=================================================================================" &
    "========================="
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 265)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(643, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "=================================================================================" &
    "========================="
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(174, 397)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 14
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(498, 397)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 15
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(63, 397)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(75, 23)
        Me.btnKeluar.TabIndex = 16
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'txtNilaiAbsen
        '
        Me.txtNilaiAbsen.Location = New System.Drawing.Point(133, 163)
        Me.txtNilaiAbsen.Name = "txtNilaiAbsen"
        Me.txtNilaiAbsen.Size = New System.Drawing.Size(190, 20)
        Me.txtNilaiAbsen.TabIndex = 17
        '
        'txtNilaiTugas
        '
        Me.txtNilaiTugas.Location = New System.Drawing.Point(133, 186)
        Me.txtNilaiTugas.Name = "txtNilaiTugas"
        Me.txtNilaiTugas.Size = New System.Drawing.Size(190, 20)
        Me.txtNilaiTugas.TabIndex = 18
        '
        'txtNilaiUTS
        '
        Me.txtNilaiUTS.Location = New System.Drawing.Point(133, 209)
        Me.txtNilaiUTS.Name = "txtNilaiUTS"
        Me.txtNilaiUTS.Size = New System.Drawing.Size(190, 20)
        Me.txtNilaiUTS.TabIndex = 19
        '
        'txtNilaiUAS
        '
        Me.txtNilaiUAS.Location = New System.Drawing.Point(133, 232)
        Me.txtNilaiUAS.Name = "txtNilaiUAS"
        Me.txtNilaiUAS.Size = New System.Drawing.Size(190, 20)
        Me.txtNilaiUAS.TabIndex = 20
        '
        'txtHasilAbsen
        '
        Me.txtHasilAbsen.Location = New System.Drawing.Point(484, 163)
        Me.txtHasilAbsen.Name = "txtHasilAbsen"
        Me.txtHasilAbsen.ReadOnly = True
        Me.txtHasilAbsen.Size = New System.Drawing.Size(180, 20)
        Me.txtHasilAbsen.TabIndex = 21
        '
        'txtHasilTugas
        '
        Me.txtHasilTugas.Location = New System.Drawing.Point(484, 186)
        Me.txtHasilTugas.Name = "txtHasilTugas"
        Me.txtHasilTugas.ReadOnly = True
        Me.txtHasilTugas.Size = New System.Drawing.Size(180, 20)
        Me.txtHasilTugas.TabIndex = 22
        '
        'txtHasilUTS
        '
        Me.txtHasilUTS.Location = New System.Drawing.Point(484, 209)
        Me.txtHasilUTS.Name = "txtHasilUTS"
        Me.txtHasilUTS.ReadOnly = True
        Me.txtHasilUTS.Size = New System.Drawing.Size(180, 20)
        Me.txtHasilUTS.TabIndex = 23
        '
        'txtHasilUAS
        '
        Me.txtHasilUAS.Location = New System.Drawing.Point(484, 232)
        Me.txtHasilUAS.Name = "txtHasilUAS"
        Me.txtHasilUAS.ReadOnly = True
        Me.txtHasilUAS.Size = New System.Drawing.Size(180, 20)
        Me.txtHasilUAS.TabIndex = 24
        '
        'txtTotalNilai
        '
        Me.txtTotalNilai.Location = New System.Drawing.Point(276, 296)
        Me.txtTotalNilai.Name = "txtTotalNilai"
        Me.txtTotalNilai.ReadOnly = True
        Me.txtTotalNilai.Size = New System.Drawing.Size(388, 20)
        Me.txtTotalNilai.TabIndex = 25
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(276, 319)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(388, 20)
        Me.txtGrade.TabIndex = 26
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(276, 342)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ReadOnly = True
        Me.txtKeterangan.Size = New System.Drawing.Size(388, 20)
        Me.txtKeterangan.TabIndex = 27
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(686, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 78)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Keterangan:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Nilai 100 - 80 = A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Nilai <80 - 65 = B" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Nilai <65 " &
    "- 50 = C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Nilai <50 - 35 = D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Nilai <35 = E"
        '
        'btnI
        '
        Me.btnI.Location = New System.Drawing.Point(24, 397)
        Me.btnI.Name = "btnI"
        Me.btnI.Size = New System.Drawing.Size(33, 23)
        Me.btnI.TabIndex = 29
        Me.btnI.Text = "i"
        Me.btnI.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(360, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 23)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Bobot"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(20, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 23)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Nama"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(20, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 23)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "NIM"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(133, 102)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(190, 20)
        Me.txtNama.TabIndex = 33
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(133, 79)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(190, 20)
        Me.txtNIM.TabIndex = 34
        '
        'gridData
        '
        Me.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridData.Location = New System.Drawing.Point(12, 442)
        Me.gridData.Name = "gridData"
        Me.gridData.Size = New System.Drawing.Size(790, 211)
        Me.gridData.TabIndex = 35
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(417, 397)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 36
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnCariSQL
        '
        Me.btnCariSQL.Location = New System.Drawing.Point(345, 656)
        Me.btnCariSQL.Name = "btnCariSQL"
        Me.btnCariSQL.Size = New System.Drawing.Size(103, 23)
        Me.btnCariSQL.TabIndex = 37
        Me.btnCariSQL.Text = "Cari di MySql"
        Me.btnCariSQL.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(255, 397)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 38
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTesKoneksi
        '
        Me.btnTesKoneksi.Location = New System.Drawing.Point(24, 293)
        Me.btnTesKoneksi.Name = "btnTesKoneksi"
        Me.btnTesKoneksi.Size = New System.Drawing.Size(87, 72)
        Me.btnTesKoneksi.TabIndex = 39
        Me.btnTesKoneksi.Text = "Tes Koneksi"
        Me.btnTesKoneksi.UseVisualStyleBackColor = True
        '
        'txtCariSQL
        '
        Me.txtCariSQL.Location = New System.Drawing.Point(80, 656)
        Me.txtCariSQL.Name = "txtCariSQL"
        Me.txtCariSQL.Size = New System.Drawing.Size(259, 20)
        Me.txtCariSQL.TabIndex = 40
        '
        'btnCari
        '
        Me.btnCari.Location = New System.Drawing.Point(336, 397)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 41
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(454, 656)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 656)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "Ketik Nama"
        '
        'frmPerhitunganNilaiMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 693)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCariSQL)
        Me.Controls.Add(Me.btnTesKoneksi)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCariSQL)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.gridData)
        Me.Controls.Add(Me.txtNIM)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnI)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtTotalNilai)
        Me.Controls.Add(Me.txtHasilUAS)
        Me.Controls.Add(Me.txtHasilUTS)
        Me.Controls.Add(Me.txtHasilTugas)
        Me.Controls.Add(Me.txtHasilAbsen)
        Me.Controls.Add(Me.txtNilaiUAS)
        Me.Controls.Add(Me.txtNilaiUTS)
        Me.Controls.Add(Me.txtNilaiTugas)
        Me.Controls.Add(Me.txtNilaiAbsen)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPerhitunganNilaiMahasiswa"
        Me.Text = "Perhitungan Nilai Mahasiswa"
        CType(Me.gridData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtNilaiAbsen As TextBox
    Friend WithEvents txtNilaiTugas As TextBox
    Friend WithEvents txtNilaiUTS As TextBox
    Friend WithEvents txtNilaiUAS As TextBox
    Friend WithEvents txtHasilAbsen As TextBox
    Friend WithEvents txtHasilTugas As TextBox
    Friend WithEvents txtHasilUTS As TextBox
    Friend WithEvents txtHasilUAS As TextBox
    Friend WithEvents txtTotalNilai As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnI As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents gridData As DataGridView
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCariSQL As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTesKoneksi As Button
    Friend WithEvents txtCariSQL As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label19 As Label
End Class
