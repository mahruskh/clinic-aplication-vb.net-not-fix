Imports MySql.Data.MySqlClient
Public Class form_update_pelanggan
    Dim PerintahSSQL As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosong(Me)
        Me.Close()
    End Sub

    Private Sub form_update_pelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        CMD = New MySqlCommand("SELECT * FROM tb_pelanggan WHERE nama_pelanggan = '" & TextBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        DateTimePicker1.Text = RD.Item(1)
        TextBox3.Text = RD.Item(2)
        TextBox4.Text = RD.Item(3)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("SEMUA DATA WAJIB DIISI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                bukaDB()
                PerintahSSQL = "UPDATE tb_pelanggan SET nama_pelanggan='" & TextBox1.Text & "',tgl_lahir_pelanggan='" & Format(CDate(DateTimePicker1.Text), "yyyy/MM/dd") & "',hp='" & TextBox3.Text & "',alamat='" & TextBox4.Text & "' WHERE nama_pelanggan='" & TextBox1.Text & "'"
                CMD = New MySqlCommand(PerintahSSQL, Conn)
                CMD.ExecuteNonQuery()
                MessageBox.Show("DATA BERHASIL DIUPDATE", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
            form_tampil_pelanggan.Button5.PerformClick()
            TextBox1.Clear()
            Me.Close()


        End If
    End Sub
End Class