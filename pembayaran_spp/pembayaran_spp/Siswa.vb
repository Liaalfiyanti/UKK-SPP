Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Siswa
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Sub aturdgv()
        sql = "SELECT bulan_dibayar, tgl_bayar, jumlah_bayar from pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        DgvLaporan.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT bulan_dibayar, tgl_bayar, jumlah_bayar from pembayaran WHERE tgl_bayar = '" & Dtdari.Value.Date.ToString("MM/dd/yyyy") & "' "
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        DgvLaporan.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 350, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
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
        DgvLaporan.AllowUserToAddRows = False

        Dim tinggi As Integer
        For baris As Integer = 0 To DgvLaporan.RowCount - 1
            tinggi += 15
            e.Graphics.DrawString(DgvLaporan.Rows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 10, 120 + tinggi)
            e.Graphics.DrawString(DgvLaporan.Rows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 60, 120 + tinggi)
            e.Graphics.DrawString(DgvLaporan.Rows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 150, 120 + tinggi)


        Next
        tinggi = 110 + tinggi
        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 400)
        e.Graphics.DrawString("Terimakasih!", f10, Brushes.Black, centermargin, 450, tengah)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DgvLaporan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLaporan.CellContentClick

    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        'printPD()
        PDD.Document = PD
        PDD.ShowDialog()
    End Sub
End Class