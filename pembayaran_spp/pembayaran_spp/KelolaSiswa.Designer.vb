<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaSiswa
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
        Me.DGVuser = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbSPP = New System.Windows.Forms.ComboBox()
        Me.cbKelas = New System.Windows.Forms.ComboBox()
        Me.txtnisn = New System.Windows.Forms.TextBox()
        Me.txtnis = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtTelp = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGVuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVuser
        '
        Me.DGVuser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVuser.Location = New System.Drawing.Point(54, 294)
        Me.DGVuser.Name = "DGVuser"
        Me.DGVuser.Size = New System.Drawing.Size(582, 166)
        Me.DGVuser.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(309, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "KELOLA SISWA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "NISN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "NIS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "ID Kelas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "No Telp"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(378, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "ID SPP"
        '
        'cbSPP
        '
        Me.cbSPP.FormattingEnabled = True
        Me.cbSPP.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbSPP.Location = New System.Drawing.Point(459, 165)
        Me.cbSPP.Name = "cbSPP"
        Me.cbSPP.Size = New System.Drawing.Size(177, 21)
        Me.cbSPP.TabIndex = 31
        '
        'cbKelas
        '
        Me.cbKelas.FormattingEnabled = True
        Me.cbKelas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbKelas.Location = New System.Drawing.Point(152, 199)
        Me.cbKelas.Name = "cbKelas"
        Me.cbKelas.Size = New System.Drawing.Size(175, 21)
        Me.cbKelas.TabIndex = 32
        '
        'txtnisn
        '
        Me.txtnisn.Location = New System.Drawing.Point(152, 96)
        Me.txtnisn.Name = "txtnisn"
        Me.txtnisn.Size = New System.Drawing.Size(175, 20)
        Me.txtnisn.TabIndex = 33
        '
        'txtnis
        '
        Me.txtnis.Location = New System.Drawing.Point(152, 131)
        Me.txtnis.Name = "txtnis"
        Me.txtnis.Size = New System.Drawing.Size(175, 20)
        Me.txtnis.TabIndex = 35
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(152, 165)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(175, 20)
        Me.txtNama.TabIndex = 36
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(459, 96)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(177, 20)
        Me.txtAlamat.TabIndex = 37
        '
        'txtTelp
        '
        Me.txtTelp.Location = New System.Drawing.Point(459, 131)
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(177, 20)
        Me.txtTelp.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(91, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(181, 254)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 40
        Me.Button8.Text = "UPDATE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(280, 254)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 41
        Me.Button9.Text = "DELETE"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(459, 254)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(161, 20)
        Me.txtcari.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(403, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Cari User"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button2.Location = New System.Drawing.Point(63, 323)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 39)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "KELOLA LAPORAN"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button7.Location = New System.Drawing.Point(63, 413)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 39)
        Me.Button7.TabIndex = 49
        Me.Button7.Text = "LOG OUT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button6.Location = New System.Drawing.Point(63, 368)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 39)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "TRANSAKSI PEMBAYARAN"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button5.Location = New System.Drawing.Point(63, 278)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 39)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "KELOLA SPP"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button4.Location = New System.Drawing.Point(63, 233)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 39)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "KELOLA KELAS"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button3.Location = New System.Drawing.Point(63, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 39)
        Me.Button3.TabIndex = 45
        Me.Button3.Text = "KELOLA PETUGAS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button10.Location = New System.Drawing.Point(63, 143)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(130, 39)
        Me.Button10.TabIndex = 44
        Me.Button10.Text = "KELOLA SISWA"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pembayaran_spp.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(78, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Location = New System.Drawing.Point(676, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 552)
        Me.Panel1.TabIndex = 52
        '
        'KelolaSiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(912, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtnis)
        Me.Controls.Add(Me.txtnisn)
        Me.Controls.Add(Me.cbKelas)
        Me.Controls.Add(Me.cbSPP)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVuser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KelolaSiswa"
        Me.Text = "KelolaSiswa"
        CType(Me.DGVuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVuser As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbSPP As ComboBox
    Friend WithEvents cbKelas As ComboBox
    Friend WithEvents txtnisn As TextBox
    Friend WithEvents txtnis As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtTelp As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
