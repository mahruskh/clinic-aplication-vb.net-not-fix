Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel


Public Class form_detil_transaksi_besar

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub form_detil_transaksi_besar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        Button1.PerformClick()
        



       
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If ComboBox1.Text = "ID Transaksi" Then
            bukaDB()
            DA = New MySqlDataAdapter("select dt.id_transaksi, tr.id_karyawan, tb.id_obat, tb.nama_obat, tb.jenis_obat,tr.tgl_transaksi,tr.nama_pelanggan, tb.harga_jual, dt.jumlah, dt.sub_total FROM tb_detil_transaksi dt,tb_transaksi tr,tb_obat tb WHERE tb.id_obat=dt.id_obat and tr.id_transaksi=dt.id_transaksi and dt.id_transaksi LIKE'%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_gabungan")
            DataGridView1.DataSource = DS.Tables("tb_gabungan")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "ID Karyawan" Then
            bukaDB()
            DA = New MySqlDataAdapter("select dt.id_transaksi, tr.id_karyawan, tb.id_obat, tb.nama_obat, tb.jenis_obat,tr.tgl_transaksi,tr.nama_pelanggan, tb.harga_jual, dt.jumlah, dt.sub_total FROM tb_detil_transaksi dt,tb_transaksi tr,tb_obat tb WHERE tb.id_obat=dt.id_obat and tr.id_transaksi=dt.id_transaksi and tr.id_karyawan LIKE '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "ID Obat" Then
            bukaDB()
            DA = New MySqlDataAdapter("select dt.id_transaksi, tr.id_karyawan, tb.id_obat, tb.nama_obat, tb.jenis_obat,tr.tgl_transaksi,tr.nama_pelanggan, tb.harga_jual, dt.jumlah, dt.sub_total FROM tb_detil_transaksi dt,tb_transaksi tr,tb_obat tb WHERE tb.id_obat=dt.id_obat and tr.id_transaksi=dt.id_transaksi and tb.id_obat LIKE '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "Nama Pelanggan" Then
            bukaDB()
            DA = New MySqlDataAdapter("select dt.id_transaksi, tr.id_karyawan, tb.id_obat, tb.nama_obat, tb.jenis_obat,tr.tgl_transaksi,tr.nama_pelanggan, tb.harga_jual, dt.jumlah, dt.sub_total FROM tb_detil_transaksi dt,tb_transaksi tr,tb_obat tb WHERE tb.id_obat=dt.id_obat and tr.id_transaksi=dt.id_transaksi and tr.nama_pelanggan LIKE '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Clear()

        bukaDB()
        DA = New MySqlDataAdapter("select dt.id_transaksi, tr.id_karyawan, tb.id_obat, tb.nama_obat, tb.jenis_obat,tr.tgl_transaksi,tr.nama_pelanggan, tb.harga_jual, dt.jumlah, dt.sub_total FROM tb_detil_transaksi dt,tb_transaksi tr,tb_obat tb WHERE tb.id_obat=dt.id_obat and tr.id_transaksi=dt.id_transaksi ", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_gabungan")
        DataGridView1.DataSource = DS.Tables("tb_gabungan")
        DataGridView1.Refresh()

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 155
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 120
        DataGridView1.Columns(6).Width = 150
        DataGridView1.Columns(7).Width = 190
        DataGridView1.Columns(8).Width = 80
        DataGridView1.Columns(8).Width = 190



        DataGridView1.Columns(0).HeaderText = "ID TRANSAKSI"
        DataGridView1.Columns(1).HeaderText = "ID KARYAWAN"
        DataGridView1.Columns(2).HeaderText = "ID OBAT"
        DataGridView1.Columns(3).HeaderText = "NAMA OBAT"
        DataGridView1.Columns(4).HeaderText = "JENIS OBAT"
        DataGridView1.Columns(5).HeaderText = "TGL TRANSAKSI"
        DataGridView1.Columns(6).HeaderText = "NAMA PELANGGAN"
        DataGridView1.Columns(7).HeaderText = "HARGA"
        DataGridView1.Columns(8).HeaderText = "JUMLAH"
        DataGridView1.Columns(9).HeaderText = "SUB TOTAL"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        bukaDB()
        DA = New MySqlDataAdapter("select dt.id_transaksi, tr.id_karyawan, tb.id_obat, tb.nama_obat, tb.jenis_obat,tr.tgl_transaksi,tr.nama_pelanggan, tb.harga_jual, dt.jumlah, dt.sub_total FROM tb_detil_transaksi dt,tb_transaksi tr,tb_obat tb WHERE tb.id_obat=dt.id_obat and tr.id_transaksi=dt.id_transaksi and tgl_transaksi>='" & Format(CDate(DateTimePicker1.Text), "yyyy/MM/dd") & "' and tgl_transaksi<='" & Format(CDate(DateTimePicker2.Text), "yyyy/MM/dd") & "'", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_transaksi")
        DataGridView1.DataSource = DS.Tables("tb_transaksi")
        DataGridView1.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True
            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.ColumnCount - 1

            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next

                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 10
                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MsgBox("Export Excel Error " & ex.Message)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
End Class