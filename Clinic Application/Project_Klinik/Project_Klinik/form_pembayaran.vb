Imports MySql.Data.MySqlClient
Public Class form_pembayaran
    Dim PerintahSSQL As String
    Private Sub form_pembayaran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bukaDB()
        CMD = New MySqlCommand("SELECT id_asistant,tb_transaksi.nama_pelanggan, tb_transaksi.alamat_pelanggan,tgl_transaksi,harga_total FROM tb_transaksi,tb_pelanggan WHERE  id_transaksi='" & TextBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBox2.Text = RD.Item(0)
            TextBox3.Text = home.kunci.Text

            TextBox4.Text = RD.Item(1)
            TextBox5.Text = RD.Item(2)
            MaskedTextBox1.Text = Format(RD.Item(3), "dd/MM/yyyy")
            TextBox6.Text = CStr(RD.Item(4))

            bukaDB()
            DA = New MySqlDataAdapter("SELECT tb_detil_transaksi.id_obat,tb_obat.nama_obat, tb_obat.jenis_obat,jumlah,sub_total FROM tb_detil_transaksi, tb_obat WHERE tb_detil_transaksi.id_obat=tb_obat.id_obat and id_transaksi='" & TextBox1.Text & "' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_gabungan")
            DataGridView1.DataSource = DS.Tables("tb_gabungan")
            DataGridView1.Refresh()


            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(0).Width = 110
            DataGridView1.Columns(1).Width = 180
            DataGridView1.Columns(2).Width = 110
            DataGridView1.Columns(3).Width = 120
            DataGridView1.Columns(4).Width = 200
       

            DataGridView1.Columns(0).HeaderText = "ID OBAT"
            DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
            DataGridView1.Columns(2).HeaderText = "JENIS OBAT"
            DataGridView1.Columns(3).HeaderText = "JUMLAH"
            DataGridView1.Columns(4).HeaderText = "SUB TOTAL HARGA (Rp.)"


        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim f As Long
        If TextBox6.Text = "" Or Not IsNumeric(TextBox6.Text) Then
            TextBox6.Text = 0
        End If
        f = TextBox6.Text
        TextBox6.Text = Format(f, "##,##0")
        TextBox6.SelectionStart = Len(TextBox6.Text)
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Dim f As Long
        If TextBox7.Text = "" Or Not IsNumeric(TextBox7.Text) Then
            TextBox7.Text = 0
        End If
        f = TextBox7.Text
        TextBox7.Text = Format(f, "##,##0")
        TextBox7.SelectionStart = Len(TextBox7.Text)

        TextBox8.Text = CLng(TextBox7.Text) - CLng(TextBox6.Text)
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Dim f As Long
        If TextBox8.Text = "" Or Not IsNumeric(TextBox8.Text) Then
            TextBox8.Text = 0
        End If
        f = TextBox8.Text
        TextBox8.Text = Format(f, "##,##0")
        TextBox8.SelectionStart = Len(TextBox8.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox8.Text < 0 Then
            MessageBox.Show("PEMBAYARAN KURANG", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            bukaDB()
            PerintahSSQL = "UPDATE tb_transaksi set id_karyawan='" & TextBox3.Text & "',bayar='" & TextBox7.Text & "',kembali='" & TextBox8.Text & "',status='" & "Sudah Bayar" & "' WHERE id_transaksi='" & TextBox1.Text & "'"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()
            MessageBox.Show("TRANSAKSI BERHASIL", "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            form_daftar_pesanan.Button5.PerformClick()
            TextBox7.Clear()
            TextBox8.Clear()
            Me.Close()


            'cetak
            cetak.Label10.Text = TextBox1.Text
            cetak.Label16.Text = TextBox2.Text
            cetak.Label12.Text = TextBox3.Text
            cetak.Label11.Text = TextBox4.Text
            cetak.Label17.Text = TextBox5.Text
            cetak.MaskedTextBox1.Text = MaskedTextBox1.Text
            cetak.TextBox1.Text = TextBox6.Text
            cetak.TextBox2.Text = TextBox7.Text
            cetak.TextBox3.Text = TextBox8.Text

            'Copy all rows and cells.
            Dim sourceGrid As DataGridView = Me.DataGridView1
            Dim targetGrid As DataGridView = cetak.DataGridView2
            Dim targetRows = New List(Of DataGridViewRow)
            For Each sourceRow As DataGridViewRow In sourceGrid.Rows
                If (Not sourceRow.IsNewRow) Then
                    Dim targetRow = CType(sourceRow.Clone(), DataGridViewRow)
                    For Each cell As DataGridViewCell In sourceRow.Cells
                        targetRow.Cells(cell.ColumnIndex).Value = cell.Value
                    Next
                    targetRows.Add(targetRow)
                End If
            Next
            targetGrid.Columns.Clear()
            For Each column As DataGridViewColumn In sourceGrid.Columns
                targetGrid.Columns.Add(CType(column.Clone(), DataGridViewColumn))
            Next
            targetGrid.Rows.AddRange(targetRows.ToArray())
            'end

            cetak.ShowDialog()
            'end cetak





        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Clear()
        Me.Close()
    End Sub
End Class