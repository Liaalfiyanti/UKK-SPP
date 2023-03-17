Imports System.Data.SqlClient

Public Class KelolaKelas
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        KelolaSiswa.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        KelolaPetugas.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

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
        If txtKelas.Text = "" Or txtNama.Text = "" Or CBkompetensi.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into kelas (id_kelas, nama_kelas, kompetensi_keahlian) VALUES ('" & txtKelas.Text & "', '" & txtNama.Text & "','" & CBkompetensi.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil menambah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Sub aturdgv()
        sql = "SELECT * FROM kelas"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        DGVuser.DataSource = ds.Tables("kelas")
    End Sub

    Sub kosong()
        txtKelas.Text = ""
        txtNama.Text = ""
        CBkompetensi.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub KelolaKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        connect()
        If txtKelas.Text = "" Or txtNama.Text = "" Or CBkompetensi.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE kelas set nama_kelas= '" & txtNama.Text & "',kompetensi_keahlian='" & CBkompetensi.Text & "' where id_kelas='" & txtKelas.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil mengubah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        connect()
        If txtKelas.Text = "" And txtNama.Text = "" And CBkompetensi.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM kelas where id_kelas='" & txtKelas.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From kelas Where (nama_kelas like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "kelas")
        DGVuser.DataSource = ds.Tables("kelas")
    End Sub

    Private Sub DGVuser_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVuser.MouseClick
        txtKelas.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(0).Value
        txtNama.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(1).Value
        CBkompetensi.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(2).Value
    End Sub

    Private Sub CBkompetensi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBkompetensi.SelectedIndexChanged

    End Sub
End Class