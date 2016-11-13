Imports MySql.Data.MySqlClient
Public Class login


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukaDB()

    End Sub
    Private Sub hidupkan()
        With home
            .TRANSAKSIToolStripMenuItem.Enabled = True
            .OBATToolStripMenuItem.Enabled = True
            .LAPORANToolStripMenuItem.Enabled = True
            .MASTERToolStripMenuItem.Enabled = True
        End With
     
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Label3.Text = "LOGIN KARYAWAN" Then
            bukaDB()
            CMD = New MySqlCommand("SELECT *  FROM tb_karyawan  WHERE   id_karyawan ='" & TextBox1.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                If TextBox1.Text = RD.Item(0) And TextBox2.Text = RD.Item(1) Then
                    MessageBox.Show("Selamat Datang " & RD.Item(2), "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    kosong(Me)
                    hidupkan()
                    home.kunci.Text = RD.Item(0)
                    home.Panel1.Visible = False
                    home.LOGOUTToolStripMenuItem.Visible = True
                    home.LOGOUTToolStripMenuItem.Text = "LOGOUT(" & RD.Item(0) & ")"
                    home.LOGINToolStripMenuItem.Visible = False
                    home.TRANSAKSIToolStripMenuItem.PerformClick()
                    Me.Close()

                    home.PictureBox4.Enabled = False
                    home.PictureBox8.Enabled = False
                    home.PictureBox10.Enabled = False
                    home.PictureBox11.Enabled = True

                Else
                    MessageBox.Show("ID atau Password SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                End If

            ElseIf Not RD.HasRows Then
                bukaDB()
                CMD = New MySqlCommand("SELECT *  FROM tb_asistant  WHERE   id_asistant ='" & TextBox1.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    If TextBox1.Text = RD.Item(0) And TextBox2.Text = RD.Item(1) Then
                        MessageBox.Show("Selamat Datang " & RD.Item(2), "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        kosong(Me)
                        hidupkan()
                        home.kunci.Text = RD.Item(0)
                        home.Panel1.Visible = False
                        home.LOGOUTToolStripMenuItem.Visible = True
                        home.LOGOUTToolStripMenuItem.Text = "LOGOUT(" & RD.Item(0) & ")"
                        home.LOGINToolStripMenuItem.Visible = False
                        home.TRANSAKSIToolStripMenuItem.PerformClick()
                        Me.Close()
                        home.PictureBox4.Enabled = False
                        home.PictureBox8.Enabled = False
                        home.PictureBox11.Enabled = False
                        home.PictureBox10.Enabled = True

                    Else
                        MessageBox.Show("ID atau Password SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox1.Clear()
                        TextBox2.Clear()
                        TextBox1.Focus()
                    End If
                ElseIf Not RD.HasRows Then
                    MessageBox.Show("ID atau Password SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                End If
                
            

            End If

        ElseIf Label3.Text = "LOGIN ADMIN" Then
            bukaDB()
            CMD = New MySqlCommand("SELECT *  FROM tb_admin  WHERE   id_admin ='" & TextBox1.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                If TextBox1.Text = RD.Item(0) And TextBox2.Text = RD.Item(1) Then
                    MessageBox.Show("Selamat Datang " & RD.Item(2), "BERHASIL", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    kosong(Me)
                    hidupkan()
                    home.kunci.Text = RD.Item(0)
                    home.Panel1.Visible = False
                    home.LOGOUTToolStripMenuItem.Visible = True
                    home.LOGOUTToolStripMenuItem.Text = "LOGOUT(" & RD.Item(0) & ")"
                    home.LOGINToolStripMenuItem.Visible = False
                    home.TRANSAKSIToolStripMenuItem.PerformClick()

                    Me.Close()

                Else
                    MessageBox.Show("ID atau Password SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox1.Focus()
                End If
            ElseIf Not RD.HasRows Then
                MessageBox.Show("ID atau Password SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
            End If


        End If


    End Sub

 
End Class
