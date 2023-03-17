Imports System.Data.SqlClient

Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub
    Sub aturdgv()
        sql = "SELECT * from pembayaran"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        DgvLaporan.DataSource = ds.Tables("pembayaran")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "SELECT tgl_bayar, jumlah_bayar from tb_pembayaran WHERE tgl_bayar = '" & Dtdari.Value.Date.ToString("MM/dd/yyyy") & "' "
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "pembayaran")
        DgvLaporan.DataSource = ds.Tables("pembayaran")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KelolaPetugas.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaSiswa.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        KelolaKelas.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        KelolaSPP.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        KelolaLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TransaksiPembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DgvLaporan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLaporan.CellContentClick

    End Sub
End Class