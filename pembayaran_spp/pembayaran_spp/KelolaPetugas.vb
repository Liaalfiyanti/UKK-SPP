Imports System.Data.SqlClient

Public Class KelolaPetugas
    Sub aturdgv()
        sql = "SELECT * FROM petugas"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "petugas")
        DGVuser.DataSource = ds.Tables("petugas")
    End Sub

    Sub kosong()
        cbLevel.Text = ""
        txtPetugas.Text = ""
        txtNama.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtcari.Text = ""
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub KelolaPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        aturdgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
        If txtPetugas.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtNama.Text = "" Or cbLevel.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "INSERT into petugas (id_petugas, username, password, nama_petugas, level) VALUES ('" & txtPetugas.Text & "', '" & txtUsername.Text & "','" & txtPassword.Text & "', '" & txtNama.Text & "', '" & cbLevel.Text & "')"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil menambah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        connect()
        If txtPetugas.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Or txtNama.Text = "" Or cbLevel.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "UPDATE petugas set username= '" & txtUsername.Text & "',password='" & txtPassword.Text & "', nama_petugas='" & txtNama.Text & "', level='" & cbLevel.Text & "' where id_petugas='" & txtPetugas.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil mengubah data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        connect()
        If txtPetugas.Text = "" And txtUsername.Text = "" And txtPassword.Text = "" And txtNama.Text = "" And cbLevel.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            sql = "DELETE FROM petugas where id_petugas='" & txtPetugas.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil hapus data")
            aturdgv()
            kosong()
        End If
    End Sub

    Private Sub txtcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcari.KeyPress
        sql = "SELECT * From petugas Where (nama_petugas like '%" & txtcari.Text & "%')"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "petugas")
        DGVuser.DataSource = ds.Tables("petugas")
    End Sub

    Private Sub DGVuser_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVuser.MouseClick
        txtPetugas.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(0).Value
        txtUsername.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(1).Value
        txtPassword.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(2).Value
        txtNama.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(3).Value
        cbLevel.Text = DGVuser.Rows(DGVuser.CurrentRow.Index).Cells(4).Value
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class