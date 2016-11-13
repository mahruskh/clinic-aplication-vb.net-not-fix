Imports MySql.Data.MySqlClient
Public Class form_tampil_pelanggan
    Dim kd_hapus As String = ""
    Dim PerintahSSQL, ambil As String

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox3.Clear()
        bukaDB()
        DA = New MySqlDataAdapter("SELECT * FROM tb_pelanggan", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_pelanggan")
        DataGridView1.DataSource = DS.Tables("tb_pelanggan")
        DataGridView1.Refresh()

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView1.Columns(0).Width = 350
        DataGridView1.Columns(1).Width = 200
        DataGridView1.Columns(2).Width = 200
        DataGridView1.Columns(3).Width = 600


        DataGridView1.Columns(0).HeaderText = "NAMA LENGKAP"
        DataGridView1.Columns(1).HeaderText = "TANGGAL LAHIR"
        DataGridView1.Columns(2).HeaderText = "HP / TELEPON"
        DataGridView1.Columns(3).HeaderText = "ALAMAT LENGKAP"

    End Sub

    Private Sub form_tampil_pelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        Button5.PerformClick()



        ambil = Strings.Left(home.kunci.Text, 2)
        If ambil = "KR" Or ambil = "AS" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
        End If
  
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        With DataGridView1
            form_update_pelanggan.TextBox1.Text = .Item(0, .CurrentRow.Index).Value()
            kd_hapus = .Item(0, .CurrentRow.Index).Value()
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        form_tambah_pelanggan.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If form_update_pelanggan.TextBox1.Text = "" Then
            MessageBox.Show("PILIH YG HENDAK DI EDIT", "PILIH", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            form_update_pelanggan.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If kd_hapus = "" Then
            MessageBox.Show("KLIK YANG HENDAK DI HAPUS", "HAPUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            bukaDB()
            CMD = New MySqlCommand("SELECT * FROM tb_pelanggan WHERE nama_pelanggan = '" & kd_hapus & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If MessageBox.Show("Yakin Ingin Menghapus : " & RD.Item(0), "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    bukaDB()
                    PerintahSSQL = "DELETE  FROM tb_pelanggan WHERE nama_pelanggan='" & kd_hapus & "'"
                    CMD = New MySqlCommand(PerintahSSQL, Conn)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("PELANGGAN BERHASIL DIHAPUS", "HAPUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RD.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try
                kd_hapus = ""
                Button5.PerformClick()

            End If

        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If ComboBox1.Text = "Nama" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_pelanggan WHERE nama_pelanggan LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_karyawan")
            DataGridView1.DataSource = DS.Tables("tb_karyawan")
            DataGridView1.Refresh()
        ElseIf ComboBox1.Text = "Alamat" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_pelanggan WHERE alamat LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_karyawan")
            DataGridView1.DataSource = DS.Tables("tb_karyawan")
            DataGridView1.Refresh()
        End If

        If DataGridView1.RowCount = 1 Then
            DataGridView1.Enabled = False
        Else
            DataGridView1.Enabled = True

        End If
    End Sub
End Class