Imports MySql.Data.MySqlClient
Public Class coba
    Dim PerintahSSQL As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DA = New MySqlDataAdapter("SELECT id_karyawan,nama FROM tb_karyawan", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_karyawan")
        DataGridView1.DataSource = DS.Tables("tb_karyawan")
        DataGridView1.Refresh()



       
    End Sub

    Private Sub coba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        With DataGridView1
            form_karyawan_tambah.TextBox1.Text = .Item(0, .CurrentRow.Index).Value()
        End With
        form_karyawan_tambah.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bukaDB()
        DA = New MySqlDataAdapter("SELECT * FROM tb_transaksi", Conn)
        DS = New DataSet
        DA.Fill(DS, "tb_transaksi")
        DataGridView1.DataSource = DS.Tables("tb_transaksi")
        DataGridView1.Refresh()
    End Sub
End Class