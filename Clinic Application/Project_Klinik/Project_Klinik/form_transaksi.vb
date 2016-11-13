Imports MySql.Data.MySqlClient
Public Class form_transaksi
    Dim a, b, c, d, f As Long
    Dim ambil, PerintahSSQL As String
    Dim harga_total As Double

    Private Sub form_transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.StartPosition = FormStartPosition.CenterScreen
        DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        bukaDB()
        CMD = New MySqlCommand("SELECT *  FROM lainnya", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        a = RD.Item(0) ' transaksi
        b = RD.Item(1) 'admin
        c = RD.Item(2) 'karyawan
        d = RD.Item(3) ' obat
        f = a + 1
        TextBox1.Text = "TS-" & f
        TextBox2.Text = home.kunci.Text
        MaskedTextBox1.Text = Format(Now, "dd/MM/yyyy")


      
    End Sub
  
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        With DataGridView1
            TextBox3.Text = .Item(0, .CurrentRow.Index).Value()
        End With
    End Sub

    Private Sub DataGridView3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        With DataGridView3
            TextBox8.Text = .Item(0, .CurrentRow.Index).Value()
        End With
    End Sub

  

  


    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        If RadioButton1.Checked = True Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT id_obat,nama_obat,stock FROM tb_obat WHERE stock > 0 and id_obat LIKE  '%" & TextBox3.Text & "%'", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

            DataGridView1.Columns(0).HeaderText = "ID OBAT"
            DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(0).Width = 180
            DataGridView1.Columns(1).Width = 402


        ElseIf RadioButton2.Checked = True Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT id_obat,nama_obat, stock FROM tb_obat WHERE stock > 0 and nama_obat LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()


            DataGridView1.Columns(0).HeaderText = "ID OBAT"
            DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(0).Width = 180
            DataGridView1.Columns(1).Width = 402
        End If


        

        If DataGridView1.RowCount = 1 Then
            DataGridView1.Enabled = False
        Else
            DataGridView1.Enabled = True

        End If
        

           

      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        bukaDB()
        CMD = New MySqlCommand("SELECT id_obat,stock FROM tb_obat WHERE id_obat = '" & TextBox3.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            If RD.Item(1) > 0 Then
                form_jumlah_pesanan_obat.Label2.Text = RD.Item(0)
                form_jumlah_pesanan_obat.ShowDialog()
            Else
                MessageBox.Show("STOCK OBAT :" & RD.Item(0) & "HABIS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox3.Clear()
                TextBox3.Focus()
            End If
           

        Else
            MessageBox.Show("ID OBAT TIDAK DITEMUKAN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox3.Clear()
            TextBox3.Focus()
        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView2.Rows.RemoveAt(DataGridView2.CurrentRow.Index)
        For i = 0 To DataGridView2.RowCount - 1
            Dim a As Long
            a = DataGridView2.Item(4, i).Value + a
            TextBox6.Text = a
        Next
        a = 0

        If DataGridView2.RowCount = 1 Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
        End If
    End Sub

    Private Sub DataGridView2_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView2.UserDeletingRow
        Dim id_obat As String = e.Row.Cells("column0").FormattedValue.ToString()

        Dim result As DialogResult = MessageBox.Show("YAKIN MENGHAPUS : " & id_obat, "HAPUS", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            e.Cancel = True

        End If
    End Sub

   

    

  

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox8.Text = "" Or TextBox5.Text = "" Or DataGridView2.RowCount = 1 Then
            MessageBox.Show("DATA PELANGGAN WAJIB DI ISI / ISI PESANAN OBAT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox8.Focus()
        Else

            bukaDB()
            PerintahSSQL = "UPDATE lainnya set no_transaksi='" & f & "',no_admin='" & b & "',no_karyawan='" & c & "',no_obat='" & d & "'"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()

            bukaDB()
            PerintahSSQL = "INSERT  INTO tb_transaksi  VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & "" & "','" & TextBox8.Text & "','" & TextBox5.Text & "','" & Format(CDate(MaskedTextBox1.Text), "yyyy/MM/dd") & "','" & CStr(TextBox6.Text) & "','" & "" & "','" & "" & "','" & "Belum Bayar" & "')"
            CMD = New MySqlCommand(PerintahSSQL, Conn)
            CMD.ExecuteNonQuery()



            For i = 0 To DataGridView2.RowCount - 2
                bukaDB()
                PerintahSSQL = "INSERT  INTO tb_detil_transaksi  VALUES ('" & TextBox1.Text & "','" & DataGridView2.Item(0, i).Value & "','" & TextBox2.Text & "','" & "" & "','" & DataGridView2.Item(3, i).Value & "','" & DataGridView2.Item(4, i).Value & "')"
                CMD = New MySqlCommand(PerintahSSQL, Conn)
                CMD.ExecuteNonQuery()

                bukaDB()
                CMD = New MySqlCommand("SELECT stock FROM tb_obat WHERE id_obat = '" & DataGridView2.Item(0, i).Value & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    bukaDB()
                    PerintahSSQL = "UPDATE tb_obat set stock='" & RD.Item(0) - DataGridView2.Item(3, i).Value & "' WHERE id_obat='" & DataGridView2.Item(0, i).Value & "'"
                    CMD = New MySqlCommand(PerintahSSQL, Conn)
                    CMD.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("PENYIMPANAN BERHASIL", "SIMPAN", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TextBox5.Clear()
            TextBox6.Clear()

            TextBox8.Clear()
            DataGridView2.Rows.Clear()
            TextBox3.Focus()



            bukaDB()
            CMD = New MySqlCommand("SELECT *  FROM lainnya", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            a = RD.Item(0) ' transaksi
            b = RD.Item(1) 'admin
            c = RD.Item(2) 'karyawan
            d = RD.Item(3) ' obat
            f = a + 1
            TextBox1.Text = "TS-" & f
            TextBox2.Text = home.kunci.Text
            MaskedTextBox1.Text = Format(Now, "dd/MM/yyyy")


        End If
    End Sub

  

   
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

    
    
    
  
    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        bukaDB()
        DA = New MySqlDataAdapter("SELECT nama_pelanggan, alamat FROM tb_pelanggan WHERE nama_pelanggan LIKE  '%" & TextBox3.Text & "%'", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_pelanggan")
        DataGridView3.DataSource = DS.Tables("tb_pelanggan")
        DataGridView3.Refresh()

        DataGridView3.Columns(0).HeaderText = "Nama Lengkap"
        DataGridView3.Columns(1).HeaderText = "Alamat"
        DataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView3.Columns(0).Width = 200
        DataGridView3.Columns(1).Width = 370

        bukaDB()
        CMD = New MySqlCommand("SELECT alamat FROM tb_pelanggan WHERE nama_pelanggan='" & TextBox8.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            TextBox5.Text = RD.Item(0)
        End If


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class