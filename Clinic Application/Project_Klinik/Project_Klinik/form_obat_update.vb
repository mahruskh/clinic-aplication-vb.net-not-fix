Imports MySql.Data.MySqlClient
Public Class form_obat_update
    Dim PerintahSSQL As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MessageBox.Show("SEMUA DATA WAJIB DIISI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            If TextBox5.Text = "" Then
                TextBox5.Text = 0
            End If
            Try
                bukaDB()
                PerintahSSQL = "UPDATE tb_obat SET nama_obat='" & TextBox2.Text & "',jenis_obat='" & TextBox3.Text & "',stock='" & CLng(TextBox4.Text) + CLng(TextBox5.Text) & "',harga_beli='" & TextBox6.Text & "',harga_jual='" & TextBox7.Text & "',keterangan='" & TextBox8.Text & "' WHERE id_obat='" & TextBox1.Text & "'    "
                CMD = New MySqlCommand(PerintahSSQL, Conn)
                CMD.ExecuteNonQuery()
                MessageBox.Show("DATA BERHASIL DIUPDATE", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox5.Clear()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
            Me.Close()
            form_tampil_obat.Button4.PerformClick()

        End If
    End Sub

    Private Sub form_obat_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        CMD = New MySqlCommand("SELECT * FROM tb_obat WHERE id_obat = '" & TextBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()

        TextBox1.Text = RD.Item(0)
        TextBox2.Text = RD.Item(1)
        TextBox3.Text = RD.Item(2)
        TextBox4.Text = RD.Item(3)
        TextBox6.Text = RD.Item(4)
        TextBox7.Text = RD.Item(5)
        TextBox8.Text = RD.Item(6)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Or Not IsNumeric(TextBox4.Text) Then
            TextBox4.Clear()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox4.Text = "" Or Not IsNumeric(TextBox4.Text) Then
            TextBox4.Clear()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Or Not IsNumeric(TextBox7.Text) Then
            TextBox7.Clear()
        End If
    End Sub
End Class