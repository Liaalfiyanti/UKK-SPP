<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KelolaPembayaranPetugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtTgl = New System.Windows.Forms.DateTimePicker()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.txtPembayaran = New System.Windows.Forms.TextBox()
        Me.cbBulan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVuser = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbnisn = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPetugas = New System.Windows.Forms.TextBox()
        Me.cbSPP = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DGVuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtTgl
        '
        Me.dtTgl.Location = New System.Drawing.Point(120, 187)
        Me.dtTgl.Name = "dtTgl"
        Me.dtTgl.Size = New System.Drawing.Size(200, 20)
        Me.dtTgl.TabIndex = 128
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(428, 187)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(177, 20)
        Me.txtJumlah.TabIndex = 127
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(341, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Jumlah Bayar"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(491, 220)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 27)
        Me.Button9.TabIndex = 125
        Me.Button9.Text = "DELETE"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(281, 218)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 27)
        Me.Button8.TabIndex = 124
        Me.Button8.Text = "UPDATE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(427, 126)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(175, 20)
        Me.txtTahun.TabIndex = 122
        '
        'txtPembayaran
        '
        Me.txtPembayaran.Location = New System.Drawing.Point(120, 91)
        Me.txtPembayaran.Name = "txtPembayaran"
        Me.txtPembayaran.Size = New System.Drawing.Size(200, 20)
        Me.txtPembayaran.TabIndex = 119
        '
        'cbBulan
        '
        Me.cbBulan.FormattingEnabled = True
        Me.cbBulan.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.cbBulan.Location = New System.Drawing.Point(427, 91)
        Me.cbBulan.Name = "cbBulan"
        Me.cbBulan.Size = New System.Drawing.Size(175, 21)
        Me.cbBulan.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(340, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "Tahun Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Bulan Bayar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "Tgl Bayar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "NISN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "ID Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(277, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "TRANSAKSI PEMBAYARAN"
        '
        'DGVuser
        '
        Me.DGVuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVuser.Location = New System.Drawing.Point(22, 260)
        Me.DGVuser.Name = "DGVuser"
        Me.DGVuser.Size = New System.Drawing.Size(582, 184)
        Me.DGVuser.TabIndex = 108
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.PictureBox1.Image = Global.pembayaran_spp.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(65, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button7.Location = New System.Drawing.Point(46, 324)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(126, 39)
        Me.Button7.TabIndex = 105
        Me.Button7.Text = "LOG OUT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button6.Location = New System.Drawing.Point(46, 279)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 39)
        Me.Button6.TabIndex = 104
        Me.Button6.Text = "TRANSAKSI PEMBAYARAN"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(550, 450)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(55, 23)
        Me.Button11.TabIndex = 130
        Me.Button11.Text = "Print"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(477, 452)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(67, 20)
        Me.TextBox1.TabIndex = 129
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(22, 452)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 21)
        Me.Button2.TabIndex = 131
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbnisn
        '
        Me.cbnisn.FormattingEnabled = True
        Me.cbnisn.Items.AddRange(New Object() {"123", "234", "345", "456", "567", "678", "789"})
        Me.cbnisn.Location = New System.Drawing.Point(120, 155)
        Me.cbnisn.Name = "cbnisn"
        Me.cbnisn.Size = New System.Drawing.Size(200, 21)
        Me.cbnisn.TabIndex = 132
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(640, -19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 578)
        Me.Panel1.TabIndex = 134
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "ID Petugas"
        '
        'txtPetugas
        '
        Me.txtPetugas.Location = New System.Drawing.Point(120, 122)
        Me.txtPetugas.Name = "txtPetugas"
        Me.txtPetugas.Size = New System.Drawing.Size(200, 20)
        Me.txtPetugas.TabIndex = 136
        '
        'cbSPP
        '
        Me.cbSPP.FormattingEnabled = True
        Me.cbSPP.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbSPP.Location = New System.Drawing.Point(427, 155)
        Me.cbSPP.Name = "cbSPP"
        Me.cbSPP.Size = New System.Drawing.Size(178, 21)
        Me.cbSPP.TabIndex = 138
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(341, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "ID SPP"
        '
        'KelolaPembayaranPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(849, 484)
        Me.Controls.Add(Me.cbSPP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPetugas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbnisn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtTgl)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.txtPembayaran)
        Me.Controls.Add(Me.cbBulan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KelolaPembayaranPetugas"
        Me.Text = "KelolaPembayaranPetugas"
        CType(Me.DGVuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtTgl As DateTimePicker
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtPembayaran As TextBox
    Friend WithEvents cbBulan As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVuser As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents cbnisn As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPetugas As TextBox
    Friend WithEvents cbSPP As ComboBox
    Friend WithEvents Label8 As Label
End Class
