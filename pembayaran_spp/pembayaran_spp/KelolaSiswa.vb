Imports System.Data.SqlClient

Public Class KelolaSiswa
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub KelolaSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Sub aturdgv()
        sql = "SELECT * FROM siswa"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "siswa")
        DGVuser.DataSource = ds.Tables("siswa")
    End Sub

    Sub kosong()
        txtnisn.Text = ""
        txtnis.Text = ""
        txtNama.Text = ""
        cbKelas.Text = ""
        txtAlamat.Text = ""
        txtTelp.Text = ""
        cbSPP.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KelolaPetugas.Show()
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
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtNama.Text = "" Or cbKelas.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Or cbSPP.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into siswa (nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) VALUES ('" & txtnisn.Text & "', '" & txtnis.Text & "','" & txtNama.Text & "', '" & cbKelas.Text & "', '" & txtAlamat.Text & "', '" & txtTelp.Text & "', '" & cbSPP.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil menambah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        connect()
        If txtnisn.Text = "" Or txtnis.Text = "" Or txtNama.Text = "" Or cbKelas.Text = "" Or txtAlamat.Text = "" Or txtTelp.Text = "" Or cbSPP.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE siswa set nis= '" & txtnis.Text & "',nama='" & txtNama.Text & "', id_kelas='" & cbKelas.Text & "', alamat='" & txtAlamat.Text & "', no_telp='" & txtTelp.Text & "' where nisn='" & txtnisn.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil mengubah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        connect()
        If txtnisn.Text = "" And txtnis.Text = "" And txtNama.Text = "" And cbKelas.Text = "" And txtAlamat.Text = "" And txtTelp.Text = "" And cbSPP.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM siswa where nisn='" & txtnisn.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From siswa Where (nama like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "siswa")
        DGVuser.DataSource = ds.Tables("siswa")
    End Sub

    Private Sub DGVuser_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVuser.MouseClick
        txtnisn.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(0).Value
        txtnis.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(1).Value
        txtNama.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(2).Value
        cbKelas.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(3).Value
        txtAlamat.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(4).Value
        txtTelp.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(5).Value
        cbSPP.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(6).Value
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub
End Class