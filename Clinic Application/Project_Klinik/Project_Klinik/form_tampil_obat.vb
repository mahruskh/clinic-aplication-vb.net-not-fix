Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class form_tampil_obat
    Dim PerintahSSQL, ambil As String
    Dim kd_hapus As String = ""
    Dim namafile As String


    

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

   

    Private Sub form_tampil_obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        ambil = Strings.Left(home.kunci.Text, 2)
        If ambil = "KR" Or ambil = "AS" Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False


            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_obat", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(0).Width = 180
            DataGridView1.Columns(1).Width = 380
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 80
            DataGridView1.Columns(4).Width = 230
            DataGridView1.Columns(5).Width = 230
            DataGridView1.Columns(6).Width = 200
            DataGridView1.Columns(0).HeaderText = "ID OBAT"
            DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
            DataGridView1.Columns(2).HeaderText = "JENIS OBAT"
            DataGridView1.Columns(3).HeaderText = "STOCK"
            DataGridView1.Columns(4).HeaderText = "HARGA BELI (Rp) - SATUAN"
            DataGridView1.Columns(5).HeaderText = "HARGA JUAL (Rp) - SATUAN"
            DataGridView1.Columns(6).HeaderText = "KETERANGAN"
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True

            bukaDB()
            DA = New MySqlDataAdapter("SELECT id_obat, nama_obat,jenis_obat,stock,harga_jual,keterangan FROM tb_obat", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(0).Width = 180
            DataGridView1.Columns(1).Width = 380
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 80
            DataGridView1.Columns(4).Width = 200
            DataGridView1.Columns(5).Width = 400

            DataGridView1.Columns(0).HeaderText = "ID OBAT"
            DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
            DataGridView1.Columns(2).HeaderText = "JENIS OBAT"
            DataGridView1.Columns(3).HeaderText = "STOCK"
            DataGridView1.Columns(4).HeaderText = "HARGA JUAL (Rp) - SATUAN"
            DataGridView1.Columns(5).HeaderText = "KETERANGAN"


        End If






    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        form_obat_tambah.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        With DataGridView1
            form_obat_update.TextBox1.Text = .Item(0, .CurrentRow.Index).Value()
            kd_hapus = .Item(0, .CurrentRow.Index).Value()
        End With
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Clear()

        ambil = Strings.Left(home.kunci.Text, 2)
        If ambil = "AD" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_obat", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(0).Width = 180
            DataGridView1.Columns(1).Width = 380
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 80
            DataGridView1.Columns(4).Width = 230
            DataGridView1.Columns(5).Width = 230
            DataGridView1.Columns(6).Width = 200
            DataGridView1.Columns(0).HeaderText = "ID OBAT"
            DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
            DataGridView1.Columns(2).HeaderText = "JENIS OBAT"
            DataGridView1.Columns(3).HeaderText = "STOCK"
            DataGridView1.Columns(4).HeaderText = "HARGA BELI (Rp) - SATUAN"
            DataGridView1.Columns(5).HeaderText = "HARGA JUAL (Rp) - SATUAN"
            DataGridView1.Columns(6).HeaderText = "KETERANGAN"

        Else
            bukaDB()
            DA = New MySqlDataAdapter("SELECT id_obat, nama_obat,jenis_obat,stock,harga_jual,keterangan FROM tb_obat", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

            DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            DataGridView1.Columns(0).Width = 180
            DataGridView1.Columns(1).Width = 380
            DataGridView1.Columns(2).Width = 150
            DataGridView1.Columns(3).Width = 80
            DataGridView1.Columns(4).Width = 200
            DataGridView1.Columns(5).Width = 400

            DataGridView1.Columns(0).HeaderText = "ID OBAT"
            DataGridView1.Columns(1).HeaderText = "NAMA OBAT"
            DataGridView1.Columns(2).HeaderText = "JENIS OBAT"
            DataGridView1.Columns(3).HeaderText = "STOCK"
            DataGridView1.Columns(4).HeaderText = "HARGA JUAL (Rp) - SATUAN"
            DataGridView1.Columns(5).HeaderText = "KETERANGAN"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If form_obat_update.TextBox1.Text = "" Then
            MessageBox.Show("KLIK YANG HENDAK DI EDIT", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            form_obat_update.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If kd_hapus = "" Then
            MessageBox.Show("KLIK YANG HENDAK DI HAPUS", "HAPUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            bukaDB()
            CMD = New MySqlCommand("SELECT * FROM tb_obat WHERE id_obat = '" & kd_hapus & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If MessageBox.Show("Yakin Ingin Menghapus : " & RD.Item(0) & " " & RD.Item(2), "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                Try
                    bukaDB()
                    PerintahSSQL = "DELETE  FROM tb_obat WHERE id_obat='" & kd_hapus & "'"
                    CMD = New MySqlCommand(PerintahSSQL, Conn)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("OBAT BERHASIL DIHAPUS", "HAPUS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RD.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try
                kd_hapus = ""
                Button4.PerformClick()

            End If

        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        If ComboBox1.Text = "ID" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_obat WHERE id_obat LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "Nama" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_obat WHERE nama_obat LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "Jenis" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_obat WHERE jenis_obat LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()

        ElseIf ComboBox1.Text = "Stock" Then
            bukaDB()
            DA = New MySqlDataAdapter("SELECT * FROM tb_obat WHERE stock LIKE  '%" & TextBox3.Text & "%' ", Conn)
            DS = New DataSet
            DA.Fill(DS, "tb_obat")
            DataGridView1.DataSource = DS.Tables("tb_obat")
            DataGridView1.Refresh()
        End If
    End Sub
    Private Sub import_excel(ByVal Data As DataGridView)

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