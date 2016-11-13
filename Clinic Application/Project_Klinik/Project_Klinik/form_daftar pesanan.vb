Imports MySql.Data.MySqlClient

Public Class form_daftar_pesanan

    Private Sub form_daftar_pesanan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Button5.PerformClick()

    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        With DataGridView1
            form_pembayaran.TextBox1.Text = .Item(0, .CurrentRow.Index).Value()
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If form_pembayaran.TextBox1.Text = "" Then
            MessageBox.Show("KLIK YG HENDAK DIPILIH", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            form_pembayaran.ShowDialog()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox3.Clear()

        bukaDB()
        DA = New MySqlDataAdapter("SELECT id_transaksi,id_asistant,nama_pelanggan,alamat_pelanggan,tgl_transaksi,harga_total,status FROM tb_transaksi WHERE  status='" & "Belum Bayar" & "'", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_transaksi")
        DataGridView1.DataSource = DS.Tables("tb_transaksi")
        DataGridView1.Refresh()

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView1.Columns(0).Width = 150
        DataGridView1.Columns(1).Width = 150
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 370
        DataGridView1.Columns(4).Width = 150
        DataGridView1.Columns(5).Width = 200
        DataGridView1.Columns(6).Width = 155


        DataGridView1.Columns(0).HeaderText = "ID TRANSAKSI"
        DataGridView1.Columns(1).HeaderText = "ID ASISTANT"
        DataGridView1.Columns(2).HeaderText = "NAMA PELANGGAN"
        DataGridView1.Columns(3).HeaderText = "ALAMAT PELANGGAN"
        DataGridView1.Columns(4).HeaderText = "TGL TRANSAKSI"
        DataGridView1.Columns(5).HeaderText = "HARGA TOTAL (Rp.)"
        DataGridView1.Columns(6).HeaderText = "STATUS"

        If DataGridView1.RowCount = 1 Then
            DataGridView1.Enabled = False
        Else
            DataGridView1.Enabled = True

        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If ComboBox1.Text = "ID Transaksi" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT id_transaksi,id_asistant,nama_pelanggan,alamat_pelanggan,tgl_transaksi,harga_total,status FROM tb_transaksi WHERE  status='" & "Belum Bayar" & "'  and id_transaksi LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "Nama" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT id_transaksi,id_asistant,nama_pelanggan,alamat_pelanggan,tgl_transaksi,harga_total,status FROM tb_transaksi WHERE  status='" & "Belum Bayar" & "' and nama_pelanggan LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()
        ElseIf ComboBox1.Text = "Alamat" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT id_transaksi,id_asistant,nama_pelanggan,alamat_pelanggan,tgl_transaksi,harga_total,status FROM tb_transaksi WHERE  status='" & "Belum Bayar" & "' and alamat_pelanggan LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()


            If DataGridView1.RowCount = 1 Then
                DataGridView1.Enabled = False
            Else
                DataGridView1.Enabled = True

            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class