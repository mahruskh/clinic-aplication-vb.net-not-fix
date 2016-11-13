Imports MySql.Data.MySqlClient
Public Class form_karyawan_update
    Dim PerintahSSQL, jk As String
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub form_karyawan_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        CMD = New MySqlCommand("SELECT * FROM tb_karyawan WHERE id_karyawan = '" & TextBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()

        TextBox1.Text = RD.Item(0)
        TextBox2.Text = RD.Item(1)
        TextBox3.Text = RD.Item(2)
       

        If RD.Item(3) = "Laki - Laki" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
         
        End If
        TextBox6.Text = RD.Item(4)
        TextBox7.Text = RD.Item(5)
        TextBox8.Text = RD.Item(6)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or jk = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MessageBox.Show("SEMUA DATA WAJIB DIISI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                bukaDB()
                PerintahSSQL = "UPDATE tb_karyawan SET password='" & TextBox2.Text & "',nama='" & TextBox3.Text & "',jenis_kelamin='" & jk & "',alamat='" & TextBox6.Text & "',hp='" & TextBox7.Text & "',keterangan='" & TextBox8.Text & "' WHERE id_karyawan='" & TextBox1.Text & "'    "
                CMD = New MySqlCommand(PerintahSSQL, Conn)
                CMD.ExecuteNonQuery()
                MessageBox.Show("DATA BERHASIL DIUPDATE", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
            Me.Close()
            form_tampil_karyawan.Button5.PerformClick()

        End If

        
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            jk = "Laki - Laki"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            jk = "Perempuan"
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Or Not IsNumeric(TextBox7.Text) Then
            TextBox7.Clear()
        End If
    End Sub
End Class