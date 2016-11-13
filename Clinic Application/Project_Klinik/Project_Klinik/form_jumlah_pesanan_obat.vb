Imports MySql.Data.MySqlClient
Public Class form_jumlah_pesanan_obat
    Dim a As Double
    Private Sub form_jumlah_pesanan_obat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        TextBox1.Clear()
        form_transaksi.TextBox3.Clear()
        form_transaksi.TextBox3.Focus()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
      
        bukaDB()
        CMD = New MySqlCommand("SELECT id_obat,nama_obat,harga_jual FROM tb_obat WHERE id_obat = '" & form_transaksi.TextBox3.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()

        If TextBox1.Text = "" Or TextBox1.Text = "0" Then
            MessageBox.Show("ISI JUMLAH PESANAN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox1.Focus()

        Else

            With form_transaksi
                .DataGridView2.RowCount = .DataGridView2.RowCount + 1


                .DataGridView2.Item(.DataGridView2.ColumnCount - 5, .DataGridView2.RowCount - 2).Value = RD.Item(0)
                .DataGridView2.Item(.DataGridView2.ColumnCount - 4, .DataGridView2.RowCount - 2).Value = RD.Item(1)
                .DataGridView2.Item(.DataGridView2.ColumnCount - 3, .DataGridView2.RowCount - 2).Value = RD.Item(2)
                .DataGridView2.Item(.DataGridView2.ColumnCount - 2, .DataGridView2.RowCount - 2).Value = TextBox1.Text
                .DataGridView2.Item(.DataGridView2.ColumnCount - 1, .DataGridView2.RowCount - 2).Value = .DataGridView2.Item(.DataGridView2.ColumnCount - 3, .DataGridView2.RowCount - 2).Value * .DataGridView2.Item(.DataGridView2.ColumnCount - 2, .DataGridView2.RowCount - 2).Value


            End With


            For i = 0 To form_transaksi.DataGridView2.RowCount - 1
                Dim a As Long
                a = form_transaksi.DataGridView2.Item(4, i).Value + a
                form_transaksi.TextBox6.Text = a
            Next
            a = 0
            TextBox1.Clear()
            form_transaksi.TextBox3.Clear()
            form_transaksi.TextBox3.Focus()
            Me.Close()
           
            If form_transaksi.DataGridView2.RowCount = 1 Then
                form_transaksi.Button2.Enabled = False
            Else
                form_transaksi.Button2.Enabled = True
            End If

        End If


        









    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Or Not IsNumeric(TextBox1.Text) Then
            TextBox1.Clear()
        End If
    End Sub
End Class