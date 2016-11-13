Imports MySql.Data.MySqlClient
Public Class home



    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub TRANSAKSIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSAKSIToolStripMenuItem.Click
        'perubahan warna
        LOGINToolStripMenuItem.BackColor = Color.RoyalBlue
        TRANSAKSIToolStripMenuItem.BackColor = Color.LightBlue
        OBATToolStripMenuItem.BackColor = Color.RoyalBlue
        LAPORANToolStripMenuItem.BackColor = Color.RoyalBlue
        MASTERToolStripMenuItem.BackColor = Color.RoyalBlue
        LOGOUTToolStripMenuItem.BackColor = Color.RoyalBlue
        'perubahan warna


        form_detil_transaksi_besar.Close()
        form_laporan_transaksi.Close()
        form_tampil_karyawan.Close()
        form_tampil_obat.Close()
        form_tampil_pelanggan.Close()

        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False



    End Sub

    Private Sub OBATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OBATToolStripMenuItem.Click
        'perubahan warna
        LOGINToolStripMenuItem.BackColor = Color.RoyalBlue
        TRANSAKSIToolStripMenuItem.BackColor = Color.RoyalBlue
        OBATToolStripMenuItem.BackColor = Color.LightBlue
        LAPORANToolStripMenuItem.BackColor = Color.RoyalBlue
        MASTERToolStripMenuItem.BackColor = Color.RoyalBlue
        LOGOUTToolStripMenuItem.BackColor = Color.RoyalBlue
        'perubahan warna

        form_daftar_pesanan.Close()
        form_detil_transaksi_besar.Close()
        form_laporan_transaksi.Close()
        form_tampil_karyawan.Close()
        form_tampil_pelanggan.Close()
        form_transaksi.Close()

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
    End Sub

    Private Sub LAPORANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAPORANToolStripMenuItem.Click
        'perubahan warna
        LOGINToolStripMenuItem.BackColor = Color.RoyalBlue
        TRANSAKSIToolStripMenuItem.BackColor = Color.RoyalBlue
        OBATToolStripMenuItem.BackColor = Color.RoyalBlue
        LAPORANToolStripMenuItem.BackColor = Color.LightBlue
        MASTERToolStripMenuItem.BackColor = Color.RoyalBlue
        LOGOUTToolStripMenuItem.BackColor = Color.RoyalBlue
        'perubahan warna

        form_daftar_pesanan.Close()
        form_tampil_karyawan.Close()
        form_tampil_obat.Close()
        form_tampil_pelanggan.Close()
        form_transaksi.Close()

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
        Panel5.Visible = False
        Panel6.Visible = False
    End Sub

    Private Sub MASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MASTERToolStripMenuItem.Click
        'perubahan warna
        LOGINToolStripMenuItem.BackColor = Color.RoyalBlue
        TRANSAKSIToolStripMenuItem.BackColor = Color.RoyalBlue
        OBATToolStripMenuItem.BackColor = Color.RoyalBlue
        LAPORANToolStripMenuItem.BackColor = Color.RoyalBlue
        MASTERToolStripMenuItem.BackColor = Color.LightBlue
        LOGOUTToolStripMenuItem.BackColor = Color.RoyalBlue
        'perubahan warna

        form_daftar_pesanan.Close()
        form_detil_transaksi_besar.Close()
        form_laporan_transaksi.Close()
        form_tampil_obat.Close()
        form_transaksi.Close()

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = True
        Panel6.Visible = False
    End Sub

   

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        login.Label3.Text = "LOGIN ADMIN"
        login.ShowDialog()
    End Sub
    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseMove
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        Label2.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox2_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseMove
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        Label3.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox3_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseMove
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        Label4.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox4_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseMove
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        Label5.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox5_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseMove
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        Label6.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox6_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseMove
        PictureBox6.BackgroundImageLayout = ImageLayout.Stretch
        Label7.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox7_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseMove
        PictureBox7.BackgroundImageLayout = ImageLayout.Stretch
        Label8.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox8_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseMove
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        Label9.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox9_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseMove
        PictureBox9.BackgroundImageLayout = ImageLayout.Stretch
        Label10.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox10_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.MouseMove
        PictureBox10.BackgroundImageLayout = ImageLayout.Stretch
        Label1.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox11_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.MouseMove
        PictureBox11.BackgroundImageLayout = ImageLayout.Stretch
        Label11.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox12_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseMove
        PictureBox12.BackgroundImageLayout = ImageLayout.Stretch
        Label17.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub
    Private Sub PictureBox13_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseMove
        PictureBox13.BackgroundImageLayout = ImageLayout.Stretch
        Label18.Font = New System.Drawing.Font("Arial Narrow", 10, FontStyle.Bold)
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave, PictureBox2.MouseLeave, PictureBox3.MouseLeave, PictureBox4.MouseLeave, PictureBox9.MouseLeave, PictureBox5.MouseLeave, PictureBox6.MouseLeave, PictureBox7.MouseLeave, PictureBox8.MouseLeave, PictureBox10.MouseLeave, PictureBox11.MouseLeave, PictureBox12.MouseLeave, PictureBox13.MouseLeave
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox5.BackgroundImageLayout = ImageLayout.Zoom
        Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox8.BackgroundImageLayout = ImageLayout.Zoom
        Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox9.BackgroundImageLayout = ImageLayout.Zoom
        Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox10.BackgroundImageLayout = ImageLayout.Zoom
        Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox11.BackgroundImageLayout = ImageLayout.Zoom
        Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)

        PictureBox12.BackgroundImageLayout = ImageLayout.Zoom
        Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
        PictureBox13.BackgroundImageLayout = ImageLayout.Zoom
        Label18.Font = New System.Drawing.Font("Arial Narrow", 9.75, FontStyle.Bold)
    End Sub
  
  
    Private Sub PictureBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        login.Label3.Text = "LOGIN KARYAWAN"
        login.ShowDialog()
    End Sub
    
    

    Private Sub PictureBox2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        form_tampil_obat.Show()
        form_tampil_obat.MdiParent = Me

        form_tampil_karyawan.Close()
        form_transaksi.Close()
        form_laporan_transaksi.Close()
        form_detil_transaksi_besar.Close()
        form_tampil_pelanggan.Close()


    End Sub
   

   
 


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        form_admin.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        form_tampil_karyawan.Show()
        form_tampil_karyawan.MdiParent = Me

        form_tampil_obat.Close()
        form_transaksi.Close()
        form_detil_transaksi_besar.Close()
        form_laporan_transaksi.Close()
        form_tampil_pelanggan.Close()

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

   

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        'perubahan warna
        LOGINToolStripMenuItem.BackColor = Color.LightBlue
        TRANSAKSIToolStripMenuItem.BackColor = Color.RoyalBlue
        OBATToolStripMenuItem.BackColor = Color.RoyalBlue
        LAPORANToolStripMenuItem.BackColor = Color.RoyalBlue
        MASTERToolStripMenuItem.BackColor = Color.RoyalBlue
        LOGOUTToolStripMenuItem.BackColor = Color.RoyalBlue

        'perubahan warna

        form_daftar_pesanan.Close()
        form_detil_transaksi_besar.Close()
        form_laporan_transaksi.Close()
        form_tampil_karyawan.Close()
        form_tampil_obat.Close()
        form_tampil_pelanggan.Close()
        form_transaksi.Close()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click
        form_daftar_pesanan.Close()
        form_detil_transaksi_besar.Close()
        form_laporan_transaksi.Close()
        form_tampil_karyawan.Close()
        form_tampil_obat.Close()
        form_tampil_pelanggan.Close()
        form_transaksi.Close()

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = True


        'perubahan warna
        LOGINToolStripMenuItem.BackColor = Color.RoyalBlue
        TRANSAKSIToolStripMenuItem.BackColor = Color.RoyalBlue
        OBATToolStripMenuItem.BackColor = Color.RoyalBlue
        LAPORANToolStripMenuItem.BackColor = Color.RoyalBlue
        MASTERToolStripMenuItem.BackColor = Color.RoyalBlue
        LOGOUTToolStripMenuItem.BackColor = Color.LightBlue
        'perubahan warna

        If MessageBox.Show("YAKIN INGIN KELUAR ?", "KELUAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            LOGINToolStripMenuItem.Visible = True
            Panel1.Visible = True
            LOGINToolStripMenuItem.PerformClick()
            LOGOUTToolStripMenuItem.Text = "LOGOUT"
            kunci.Text = "Selamat Datang"
            LOGOUTToolStripMenuItem.Visible = False
            matikan()



        End If





    End Sub
    Public Sub matikan()
        TRANSAKSIToolStripMenuItem.Enabled = False
        OBATToolStripMenuItem.Enabled = False
        LAPORANToolStripMenuItem.Enabled = False
        MASTERToolStripMenuItem.Enabled = False

        form_daftar_pesanan.Close()
        form_detil_transaksi_besar.Close()
        form_laporan_transaksi.Close()
        form_tampil_karyawan.Close()
        form_tampil_obat.Close()
        form_tampil_pelanggan.Close()
        form_transaksi.Close()

    End Sub
    

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LOGINToolStripMenuItem.PerformClick()

    End Sub

    Private Sub PictureBox7_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox7.MouseMove

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        form_obat_tambah.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        form_ubah_password.ShowDialog()
    End Sub

   
    Private Sub HOMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'perubahan warna
        LOGINToolStripMenuItem.BackColor = Color.RoyalBlue
        TRANSAKSIToolStripMenuItem.BackColor = Color.RoyalBlue
        OBATToolStripMenuItem.BackColor = Color.RoyalBlue
        LAPORANToolStripMenuItem.BackColor = Color.RoyalBlue
        MASTERToolStripMenuItem.BackColor = Color.RoyalBlue
        LOGOUTToolStripMenuItem.BackColor = Color.RoyalBlue

        'perubahan warna
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        form_tampil_karyawan.Close()
        form_tampil_obat.Close()
        form_transaksi.Close()
        form_detil_transaksi_besar.Close()
        form_tampil_pelanggan.Close()


        form_laporan_transaksi.Show()
        form_laporan_transaksi.MdiParent = Me


    End Sub


    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        form_tampil_karyawan.Close()
        form_tampil_obat.Close()
        form_transaksi.Close()
        form_laporan_transaksi.Close()
        form_tampil_pelanggan.Close()


        form_detil_transaksi_besar.Show()
        form_detil_transaksi_besar.MdiParent = Me
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub PictureBox10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        form_tampil_obat.Close()
        form_tampil_karyawan.Close() '
        form_laporan_transaksi.Close()
        form_detil_transaksi_besar.Close()
        form_daftar_pesanan.Close()
        form_transaksi.Show()
        form_transaksi.MdiParent = Me
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        form_tampil_obat.Close()
        form_tampil_karyawan.Close() '
        form_laporan_transaksi.Close()
        form_detil_transaksi_besar.Close()
        form_transaksi.Close()
        form_daftar_pesanan.Show()
        form_daftar_pesanan.MdiParent = Me
    End Sub

    

    

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        form_asistant.ShowDialog()

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        form_tampil_obat.Close()
        form_tampil_karyawan.Close() '
        form_laporan_transaksi.Close()
        form_detil_transaksi_besar.Close()
        form_transaksi.Close()

        form_tampil_pelanggan.Show()
        form_tampil_pelanggan.MdiParent = Me
    End Sub


End Class