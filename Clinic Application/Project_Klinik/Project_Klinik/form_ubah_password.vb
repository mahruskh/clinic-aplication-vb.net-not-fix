Imports MySql.Data.MySqlClient
Public Class form_ubah_password
    Dim PerintahSSQL As String
    Private Sub LineShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineShape4.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        bukaDB()
        CMD = New MySqlCommand("SELECT id_admin,password FROM tb_admin  WHERE   id_admin ='" & TextBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            If RD.Item(0) = TextBox1.Text And RD.Item(1) = TextBox2.Text Then
                Try

                    bukaDB()
                    PerintahSSQL = "UPDATE tb_admin SET password='" & TextBox3.Text & "' WHERE id_admin='" & TextBox1.Text & "'"
                    CMD = New MySqlCommand(PerintahSSQL, Conn)
                    CMD.ExecuteNonQuery()
                    MessageBox.Show("PASSWORD BERHASIL DIUBAH", "UBAH", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    kosong(Me)
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                End Try
            Else
                MessageBox.Show("ID atau PASSWORD SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                kosong(Me)
            End If
          

        ElseIf Not RD.HasRows Then
            bukaDB()
            CMD = New MySqlCommand("SELECT id_karyawan,password FROM tb_karyawan  WHERE   id_karyawan ='" & TextBox1.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                If RD.Item(0) = TextBox1.Text And RD.Item(1) = TextBox2.Text Then
                    Try
                        bukaDB()
                        PerintahSSQL = "UPDATE tb_karyawan SET password='" & TextBox3.Text & "' WHERE id_karyawan='" & TextBox1.Text & "'"
                        CMD = New MySqlCommand(PerintahSSQL, Conn)
                        CMD.ExecuteNonQuery()
                        MessageBox.Show("PASSWORD BERHASIL DIUBAH", "UBAH", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        kosong(Me)
                    Catch ex As Exception
                        MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
                    End Try
                Else
                    MessageBox.Show("ID atau PASSWORD SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    kosong(Me)
                End If
            ElseIf Not RD.HasRows Then
                MessageBox.Show("ID atau PASSWORD SALAH", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                kosong(Me)
            End If
        
        End If



    End Sub

    Private Sub form_ubah_password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()

    End Sub
End Class