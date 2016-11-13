Imports MySql.Data.MySqlClient
Public Class form_tambah_pelanggan
    Dim a As Long
    Dim PerintahSSQL As String
    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Or Not IsNumeric(TextBox3.Text) Then
            TextBox3.Clear()
        End If
    End Sub

    Private Sub form_tambah_pelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kosong(Me)
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("SEMUA DATA WAJIB DIISI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else

            bukaDB()
            PerintahSSQL = "INSERT  INTO tb_pelanggan  VALUES ('" & TextBox1.Text & "','" & Format(CDate(DateTimePicker1.Text), "yyyy/MM/dd") & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()
            MessageBox.Show("PENYIMPANAN BERHASIL", "SIMPAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kosong(Me)
            form_tampil_pelanggan.Button5.PerformClick()
          
        End If

    End Sub
End Class