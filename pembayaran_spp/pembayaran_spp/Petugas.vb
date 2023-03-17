Imports System.Data.SqlClient
Public Class Petugas
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaPembayaranPetugas.Show()
        Me.Hide()
    End Sub
    Sub aturdgv()
        sql = "SELECT tgl_bayar, bulan_dibayar, tahun_dibayar, jumlah_bayar from pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        DgvLaporan.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT tgl_bayar, jumlah_bayar from pembayaran WHERE tgl_bayar = '" & dtdari.Value.Date.ToString("MM/dd/yyyy") & "' "
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        DgvLaporan.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Petugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DgvLaporan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLaporan.CellContentClick

    End Sub
End Class