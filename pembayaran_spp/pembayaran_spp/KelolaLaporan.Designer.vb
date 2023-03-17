<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KelolaLaporan
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgv_laporan = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.dtsampai = New System.Windows.Forms.DateTimePicker()
        Me.dtdari = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChartLaporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button2.Location = New System.Drawing.Point(26, 343)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 39)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "KELOLA LAPORAN"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button7.Location = New System.Drawing.Point(26, 433)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(161, 39)
        Me.Button7.TabIndex = 73
        Me.Button7.Text = "LOG OUT"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button6.Location = New System.Drawing.Point(26, 388)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(161, 39)
        Me.Button6.TabIndex = 72
        Me.Button6.Text = "TRANSAKSI PEMBAYARAN"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button5.Location = New System.Drawing.Point(26, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(161, 39)
        Me.Button5.TabIndex = 71
        Me.Button5.Text = "KELOLA SPP"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button4.Location = New System.Drawing.Point(26, 253)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(161, 39)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "KELOLA KELAS"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button3.Location = New System.Drawing.Point(26, 208)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 39)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "KELOLA PETUGAS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Button10.Location = New System.Drawing.Point(26, 163)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(161, 39)
        Me.Button10.TabIndex = 68
        Me.Button10.Text = "KELOLA SISWA"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.CadetBlue
        Me.PictureBox1.Image = Global.pembayaran_spp.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(65, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'dgv_laporan
        '
        Me.dgv_laporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_laporan.Location = New System.Drawing.Point(121, 163)
        Me.dgv_laporan.Name = "dgv_laporan"
        Me.dgv_laporan.Size = New System.Drawing.Size(505, 129)
        Me.dgv_laporan.TabIndex = 83
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(551, 120)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 82
        Me.Button8.Text = "Load"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'dtsampai
        '
        Me.dtsampai.Location = New System.Drawing.Point(376, 120)
        Me.dtsampai.Name = "dtsampai"
        Me.dtsampai.Size = New System.Drawing.Size(147, 20)
        Me.dtsampai.TabIndex = 81
        '
        'dtdari
        '
        Me.dtdari.Location = New System.Drawing.Point(168, 120)
        Me.dtdari.Name = "dtdari"
        Me.dtdari.Size = New System.Drawing.Size(136, 20)
        Me.dtdari.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Sampai Tgl"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Dari Tgl"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(290, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 20)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Laporan Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Kelola Laporan"
        '
        'ChartLaporan
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartLaporan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartLaporan.Legends.Add(Legend1)
        Me.ChartLaporan.Location = New System.Drawing.Point(145, 311)
        Me.ChartLaporan.Name = "ChartLaporan"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "omset"
        Me.ChartLaporan.Series.Add(Series1)
        Me.ChartLaporan.Size = New System.Drawing.Size(225, 154)
        Me.ChartLaporan.TabIndex = 85
        Me.ChartLaporan.Text = "Chart1"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(562, 311)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(55, 23)
        Me.Button11.TabIndex = 131
        Me.Button11.Text = "Print"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(697, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 590)
        Me.Panel1.TabIndex = 132
        '
        'KelolaLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(912, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.ChartLaporan)
        Me.Controls.Add(Me.dgv_laporan)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.dtsampai)
        Me.Controls.Add(Me.dtdari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KelolaLaporan"
        Me.Text = "KelolaLaporan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_laporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents dgv_laporan As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents dtsampai As DateTimePicker
    Friend WithEvents dtdari As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ChartLaporan As DataVisualization.Charting.Chart
    Friend WithEvents Button11 As Button
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
End Class
