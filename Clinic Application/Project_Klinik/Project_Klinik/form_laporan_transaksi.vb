Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class form_laporan_transaksi
    Dim PerintahSSQL, ambil As String
    Public kd_hapus As String
    Dim tbl As New DataTable
    Private Sub form_laporan_transaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        


        Me.StartPosition = FormStartPosition.CenterScreen
        ambil = Strings.Left(home.kunci.Text, 2)
        If ambil = "KR" Or ambil = "AS" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
        bukaDB()
        DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_transaksi")
        DataGridView1.DataSource = DS.Tables("tb_transaksi")
        DataGridView1.Refresh()

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns(2).Width = 110
        DataGridView1.Columns(3).Width = 210
        DataGridView1.Columns(4).Width = 155
        DataGridView1.Columns(5).Width = 210
        DataGridView1.Columns(6).Width = 210
        DataGridView1.Columns(7).Width = 210
        DataGridView1.Columns(0).HeaderText = "ID TRANSAKSI"
        DataGridView1.Columns(1).HeaderText = "ID KARYAWAN"
        DataGridView1.Columns(2).HeaderText = "TGL TRANSAKSI"
        DataGridView1.Columns(3).HeaderText = "NAMA PELANGGAN"
        DataGridView1.Columns(4).HeaderText = "TELEPON / HP"
        DataGridView1.Columns(5).HeaderText = "HARGA TOTAL (Rp.)"
        DataGridView1.Columns(6).HeaderText = "BAYAR (Rp.)"
        DataGridView1.Columns(7).HeaderText = "KEMBALIAN (Rp.)"
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        With DataGridView1
            kd_hapus = .Item(0, .CurrentRow.Index).Value()
            form_detil_transaksi_kecil.TextBox1.Text = .Item(0, .CurrentRow.Index).Value()
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox3.Clear()
        bukaDB()
        DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_transaksi")
        DataGridView1.DataSource = DS.Tables("tb_transaksi")
        DataGridView1.Refresh()

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        DataGridView1.Columns(0).Width = 110
        DataGridView1.Columns(1).Width = 110
        DataGridView1.Columns(2).Width = 110
        DataGridView1.Columns(3).Width = 210
        DataGridView1.Columns(4).Width = 155
        DataGridView1.Columns(5).Width = 210
        DataGridView1.Columns(6).Width = 210
        DataGridView1.Columns(7).Width = 210


        DataGridView1.Columns(0).HeaderText = "ID TRANSAKSI"
        DataGridView1.Columns(1).HeaderText = "ID KARYAWAN"
        DataGridView1.Columns(2).HeaderText = "TGL TRANSAKSI"
        DataGridView1.Columns(3).HeaderText = "NAMA PELANGGAN"
        DataGridView1.Columns(4).HeaderText = "TELEPON / HP"
        DataGridView1.Columns(5).HeaderText = "HARGA TOTAL (Rp.)"
        DataGridView1.Columns(6).HeaderText = "BAYAR (Rp.)"
        DataGridView1.Columns(7).HeaderText = "KEMBALIAN (Rp.)"
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If ComboBox1.Text = "ID Transaksi" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi WHERE id_transaksi LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "ID Karyawan" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi WHERE id_karyawan LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()
        ElseIf ComboBox1.Text = "Nama Pelanggan" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi WHERE nama_pelanggan LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_transaksi")
            DataGridView1.DataSource = DS.Tables("tb_transaksi")
            DataGridView1.Refresh()
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If kd_hapus = "" Then
            MessageBox.Show("KLIK TABEL UNTUK MENGHAPUS", "DETAIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            bukaDB()
            CMD = New MySqlCommand("SELECT * FROM tb_transaksi WHERE id_transaksi = '" & kd_hapus & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If MessageBox.Show("Yakin Ingin Menghapus Transaksi : " & RD.Item(0) & RD.Item(3) & RD.Item(4), "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    bukaDB()
                    PerintahSSQL = "DELETE  FROM tb_transaksi WHERE id_transaksi='" & kd_hapus & "'"
                    CMD = New MySqlCommand(PerintahSSQL, Conn)
                    CMD.ExecuteNonQuery()

                    bukaDB()
                    PerintahSSQL = "DELETE  FROM tb_detil_transaksi WHERE id_transaksi='" & kd_hapus & "'"
                    CMD = New MySqlCommand(PerintahSSQL, Conn)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("TRANSAKSI BERHASIL DIHAPUS", "HAPUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RD.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try
                kd_hapus = ""
                Button2.PerformClick()

            End If

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If kd_hapus = "" Then
            MessageBox.Show("KLIK TRANSAKSI PADA TABEL", "DETAIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            form_detil_transaksi_kecil.ShowDialog()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        bukaDB()
        DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi WHERE tgl_transaksi>='" & Format(CDate(DateTimePicker1.Text), "yyyy/MM/dd") & "' and tgl_transaksi<='" & Format(CDate(DateTimePicker2.Text), "yyyy/MM/dd") & "'", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_transaksi")
        DataGridView1.DataSource = DS.Tables("tb_transaksi")
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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