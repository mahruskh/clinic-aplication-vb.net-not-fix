Imports MySql.Data.MySqlClient
Public Class form_admin
    Dim a, b, c, d, f, PerintahSSQL As String
    

    Public Sub load_data()
        bukaDB()
        DA = New MySqlDataAdapter("SELECT id_admin, nama, keterangan FROM tb_admin", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_admin")
        DataGridView1.DataSource = DS.Tables("tb_admin")
        DataGridView1.Refresh()

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 140
        DataGridView1.Columns(2).Width = 150

        DataGridView1.Columns(0).HeaderText = "ID Admin"
        DataGridView1.Columns(1).HeaderText = "Nama Lengkap"
        DataGridView1.Columns(2).HeaderText = "Keterangan"

    End Sub
    Private Sub form_admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_data()
        If home.kunci.Text = "AD-1" Then
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        Else
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False

        End If


    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        With DataGridView1
            TextBox1.Text = .Item(0, .CurrentRow.Index).Value()

        End With
    
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bukaDB()
        CMD = New MySqlCommand("SELECT  * FROM lainnya", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        a = RD.Item(0)
        b = RD.Item(1)
        c = RD.Item(2)
        d = RD.Item(3)
        f = b + 1
        TextBox1.Text = "AD-" & f


        If Button1.Text = "TAMBAH" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Aktif(Me, "ON")
            TextBox1.Enabled = False
            TextBox2.Focus()
            DataGridView1.Enabled = False



        ElseIf Button1.Text = "SIMPAN" Then


            If TextBox2.Text = "" Or TextBox3.Text = "" Then
                MessageBox.Show("SEMUA DATA WAJIB DIISI", "WAJIB", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                bukaDB()
                PerintahSSQL = "UPDATE lainnya set no_transaksi='" & a & "',no_admin='" & f & "',no_karyawan='" & c & "',no_obat='" & d & "'   "
                CMD = New MySqlCommand(PerintahSSQL, Conn)
                CMD.ExecuteNonQuery()

                bukaDB()
                PerintahSSQL = "INSERT  INTO tb_admin VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
                CMD = New MySqlCommand(PerintahSSQL, Conn)
                CMD.ExecuteNonQuery()
                MessageBox.Show("PENYIMPANAN BERHASIL", "SIMPAN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                kosong(Me)
                Button1.Text = "TAMBAH"
                Button2.Enabled = True
                Button3.Enabled = True
                Aktif(Me, "OFF")
                DataGridView1.Enabled = True
                load_data()

            End If
          


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("PILIH ID YG HENDAK DI EDIT pada KOLOM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Button2.Text = "UPDATE" Then
                bukaDB()
                CMD = New MySqlCommand("SELECT * FROM tb_admin WHERE id_admin = '" & TextBox1.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                TextBox1.Text = RD.Item(0)
                TextBox2.Text = RD.Item(1)
                TextBox3.Text = RD.Item(2)
                TextBox4.Text = RD.Item(3)

                Button1.Enabled = False
                Button3.Enabled = False
                Button2.Text = "SIMPAN"
                Aktif(Me, "ON")
                TextBox1.Enabled = False
                TextBox2.Enabled = False

            ElseIf Button2.Text = "SIMPAN" Then
                If TextBox2.Text = "" Or TextBox3.Text = "" Then
                    MessageBox.Show("SEMUA DATA WAJIB DIISI", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else

                    Try
                        bukaDB()
                        PerintahSSQL = "UPDATE tb_admin SET password='" & TextBox2.Text & "',nama='" & TextBox3.Text & "',keterangan='" & TextBox4.Text & "' WHERE id_admin='" & TextBox1.Text & "'    "
                        CMD = New MySqlCommand(PerintahSSQL, Conn)
                        CMD.ExecuteNonQuery()
                        MessageBox.Show("DATA BERHASIL DIUPDATE", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                    End Try
                    Button2.Text = "UPDATE"
                    kosong(Me)
                    Aktif(Me, "OFF")
                    Button1.Enabled = True
                    Button3.Enabled = True
                    load_data()

                End If

            End If
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Then
            MessageBox.Show("PILIH ID YANG HENDAK DI HAPUS pada KOLOM", "HAPUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            bukaDB()
            CMD = New MySqlCommand("SELECT * FROM tb_admin WHERE id_admin = '" & TextBox1.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If MessageBox.Show("Yakin Ingin Menghapus : " & RD.Item(0) & " " & RD.Item(2), "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    bukaDB()
                    PerintahSSQL = "DELETE  FROM tb_admin WHERE id_admin='" & TextBox1.Text & "'"
                    CMD = New MySqlCommand(PerintahSSQL, Conn)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("ADMIN BERHASIL DIHAPUS", "HAPUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RD.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try
                kosong(Me)
                load_data()

            End If

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        kosong(Me)
        Aktif(Me, "OFF")
        DataGridView1.Enabled = True
        Button1.Text = "TAMBAH"
        Button2.Text = "UPDATE"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        load_data()

    End Sub
End Class