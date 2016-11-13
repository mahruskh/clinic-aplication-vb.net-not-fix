Imports MySql.Data.MySqlClient
Public Class form_obat_tambah

    Dim a, b, c, d, f As Long
    Dim PerintahSSQL, jk As String


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SIMPAN


        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MessageBox.Show("SEMUA DATA WAJIB DIISI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            bukaDB()
            PerintahSSQL = "UPDATE lainnya set no_transaksi='" & a & "',no_admin='" & b & "',no_karyawan='" & c & "',no_obat='" & f & "'"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()

            bukaDB()
            PerintahSSQL = "INSERT  INTO tb_obat  VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "')"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()
            MessageBox.Show("PENYIMPANAN BERHASIL", "SIMPAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            kosong(Me)


            bukaDB()
            CMD = New MySqlCommand("SELECT *  FROM lainnya", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            a = RD.Item(0) ' transaksi
            b = RD.Item(1) 'admin
            c = RD.Item(2) 'karyawan
            d = RD.Item(3) ' obat
            f = c + 1
            TextBox1.Text = "OBT-" & f

            form_tampil_obat.Button4.PerformClick()
        End If
    End Sub

    Private Sub form_obat_tambah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        CMD = New MySqlCommand("SELECT *  FROM lainnya", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        a = RD.Item(0) ' transaksi
        b = RD.Item(1) 'admin
        c = RD.Item(2) 'karyawan
        d = RD.Item(3) ' obat
        f = d + 1
        TextBox1.Text = "OBT-" & f
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Or Not IsNumeric(TextBox4.Text) Then
            TextBox4.Clear()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Or Not IsNumeric(TextBox6.Text) Then
            TextBox6.Clear()
        End If
    End Sub
End Class