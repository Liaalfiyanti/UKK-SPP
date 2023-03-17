Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class KelolaPembayaranPetugas
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Private Sub KelolaPembayaranPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT id_pembayaran, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, jumlah_bayar from pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        DGVuser.DataSource = ds.Tables("pembayaran")
    End Sub

    Sub kosong()
        txtPembayaran.Text = ""
        cbnisn.Text = ""
        cbBulan.Text = ""
        txtTahun.Text = ""
        txtJumlah.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        If txtPembayaran.Text = "" Or txtPetugas.Text = "" Or cbnisn.Text = "" Or cbBulan.Text = "" Or txtTahun.Text = "" Or cbSPP.Text = "" Or txtJumlah.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into pembayaran (id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar) VALUES ('" & txtPembayaran.Text & "', '" & txtPetugas.Text & "', '" & cbnisn.Text & "', '" & Format(dtTgl.Value, "yyyy-MM-dd") & "', '" & cbBulan.Text & "', '" & txtTahun.Text & "', '" & cbSPP.Text & "',  '" & txtJumlah.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil menambah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        connect()
        If txtPembayaran.Text = "" Or txtPetugas.Text = "" Or cbnisn.Text = "" Or cbBulan.Text = "" Or txtTahun.Text = "" Or cbSPP.Text = "" Or txtJumlah.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE pembayaran set nisn='" & cbnisn.Text & "', tgl_bayar='" & Format(dtTgl.Value, "yyyy-MM-dd") & "', bulan_dibayar='" & cbBulan.Text & "', tahun_dibayar='" & txtTahun.Text & "', jumlah_bayar='" & txtJumlah.Text & "'where id_pembayaran='" & txtPembayaran.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil mengubah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        connect()
        If txtPembayaran.Text = "" And txtPetugas.Text = "" And cbnisn.Text = "" And cbBulan.Text = "" And txtTahun.Text = "" And cbSPP.Text = "" And txtJumlah.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM pembayaran where id_pembayaran='" & txtPembayaran.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus data")
            aturdgv()
            kosong()
        End If
    End Sub
    Private Sub DGVuser_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVuser.MouseClick
        txtPembayaran.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(0).Value
        cbnisn.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(1).Value
        dtTgl.Value = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(2).Value
        cbBulan.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(3).Value
        txtTahun.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(4).Value
        txtJumlah.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(5).Value
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'printPD()
        PDD.Document = PD
        PDD.ShowDialog()
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis As String
        garis = "--------------------------------------------------------------------------------------"

        e.Graphics.DrawString("SPP SMK Negeri 2 Kuningan", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl.Sukamulya No.77", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("No Tlp: 0812", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Petugas", f10, Brushes.Black, 0, 65)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 65)
        e.Graphics.DrawString("Iyong", f10, Brushes.Black, 80, 65)

        e.Graphics.DrawString("Siswa", f10, Brushes.Black, 0, 85)
        e.Graphics.DrawString(":", f10, Brushes.Black, 60, 85)
        e.Graphics.DrawString("________", f10, Brushes.Black, 80, 85)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString("nisn", f10, Brushes.Black, 10, 115)
        e.Graphics.DrawString("jumlah bayar", f10, Brushes.Black, 60, 115)
        e.Graphics.DrawString("tanggal bayar", f10, Brushes.Black, 150, 115)
        DGVuser.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To DGVuser.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(DGVuser.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 10, 120 + tinggi)
            e.Graphics.DrawString(DGVuser.Rows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 60, 120 + tinggi)
            e.Graphics.DrawString(DGVuser.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 150, 120 + tinggi)


        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Terimakasih!", f10, Brushes.Black, centermargin, 450, tengah)



    End Sub

    Sub printPD()
        PrintDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        PrintDoc.Print()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 350, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        sql = "SELECT * From pembayaran Where (id_pembayaran like '%" & TextBox1.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        DGVuser.DataSource = ds.Tables("kelas")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Petugas.Show()
        Me.Hide()
    End Sub

    Private Sub txtnisn_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPetugas.TextChanged

    End Sub

    Private Sub DGVuser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVuser.CellContentClick

    End Sub
End Class