Imports MySql.Data.MySqlClient
Public Class form_detil_transaksi_kecil
    Dim test As New form_laporan_transaksi
    Private Sub form_detil_transaksi_kecil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
        CMD = New MySqlCommand("SELECT * FROM tb_transaksi WHERE id_transaksi = '" & TextBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        TextBox1.Text = RD.Item(0)
        TextBox2.Text = RD.Item(1)
        TextBox8.Text = RD.Item(2)
        TextBox3.Text = RD.Item(3)
        TextBox4.Text = RD.Item(4)
        MaskedTextBox1.Text = Format(RD.Item(5), "dd/MM/yyyy")
        TextBox5.Text = RD.Item(6)
        TextBox6.Text = RD.Item(7)
        TextBox7.Text = RD.Item(8)



        bukaDB()
        DA = New MySqlDataAdapter("select tb.id_obat, tb.nama_obat, tb.jenis_obat, tb.harga_jual, dt.jumlah, dt.sub_total FROM tb_detil_transaksi dt,tb_transaksi tr,tb_obat tb WHERE tb.id_obat=dt.id_obat and tr.id_transaksi=dt.id_transaksi and dt.id_transaksi='" & TextBox1.Text & "'", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_gabungan")
        DataGridView1.DataSource = DS.Tables("tb_gabungan")
        DataGridView1.Refresh()

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView1.Columns(0).Width = 120
        DataGridView1.Columns(1).Width = 140
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 120
        DataGridView1.Columns(4).Width = 80
        DataGridView1.Columns(5).Width = 120
       


        DataGridView1.Columns(0).HeaderText = "ID OBAT"
        DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
        DataGridView1.Columns(2).HeaderText = "JENIS OBAT"
        DataGridView1.Columns(3).HeaderText = "HARGA JUAL"
        DataGridView1.Columns(4).HeaderText = "JUMLAH"
        DataGridView1.Columns(5).HeaderText = "SUB TOTAL"
      
        
       
    End Sub

    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class