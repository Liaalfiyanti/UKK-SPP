Imports System.Data.SqlClient

Public Class KelolaSPP
    Private Sub KelolaSPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Sub aturdgv()
        sql = "SELECT * FROM spp"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        DGVuser.DataSource = ds.Tables("spp")
    End Sub

    Sub kosong()
        txtspp.Text = ""
        txtTahun.Text = ""
        txtNominal.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        KelolaSiswa.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KelolaPetugas.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        KelolaKelas.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        KelolaLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TransaksiPembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        If txtspp.Text = "" Or txtTahun.Text = "" Or txtNominal.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into spp (id_spp, tahun, nominal) VALUES ('" & txtspp.Text & "', '" & txtTahun.Text & "','" & txtNominal.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil menambah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        connect()
        If txtspp.Text = "" Or txtTahun.Text = "" Or txtNominal.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE spp set tahun= '" & txtTahun.Text & "', nominal='" & txtNominal.Text & "' where id_spp='" & txtspp.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil mengubah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        connect()
        If txtspp.Text = "" And txtTahun.Text = "" And txtNominal.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM spp where id_spp='" & txtspp.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub DGVuser_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVuser.MouseClick
        txtspp.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(0).Value
        txtTahun.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(1).Value
        txtNominal.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(2).Value
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From spp Where (tahun like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "spp")
        DGVuser.DataSource = ds.Tables("spp")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class