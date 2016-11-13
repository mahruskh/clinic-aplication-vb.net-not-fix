Imports MySql.Data.MySqlClient
Public Class form_karyawan_tambah
    Dim a, b, c, d, f As Long
    Dim PerintahSSQL, jk As String

    Private Sub form_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        CMD = New MySqlCommand("SELECT *  FROM lainnya", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        a = RD.Item(0) ' transaksi
        b = RD.Item(1) 'admin
        c = RD.Item(2) 'karyawan
        d = RD.Item(3) ' obat
        f = c + 1
        TextBox1.Text = "KR-" & f





    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SIMPAN


        If TextBox2.Text = "" Or TextBox3.Text = "" Or jk = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MessageBox.Show("SEMUA DATA WAJIB DIISI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            bukaDB()
            PerintahSSQL = "UPDATE lainnya set no_transaksi='" & a & "',no_admin='" & b & "',no_karyawan='" & f & "',no_obat='" & d & "'"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()

            bukaDB()
            PerintahSSQL = "INSERT  INTO tb_karyawan  VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & jk & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()
            MessageBox.Show("PENYIMPANAN BERHASIL", "SIMPAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kosong(Me)
            RadioButton1.Checked = False
            RadioButton2.Checked = False

            bukaDB()
            CMD = New MySqlCommand("SELECT *  FROM lainnya", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            a = RD.Item(0) ' transaksi
            b = RD.Item(1) 'admin
            c = RD.Item(2) 'karyawan
            d = RD.Item(3) ' obat
            f = c + 1
            TextBox1.Text = "KR-" & f

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