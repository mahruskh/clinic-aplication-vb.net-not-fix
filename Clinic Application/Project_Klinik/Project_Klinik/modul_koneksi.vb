Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Module modul_koneksi
    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet

    Public Sub bukaDB()
        Dim SQLConn As String
        SQLConn = "server=localhost;Uid=root;Pwd=;Database=klinik_andi;Convert Zero Datetime=True"
        Conn = New MySqlConnection(SQLConn)
        If Conn.State = ConnectionState.Open Then
            Conn.Close()
        End If

        Try
            Conn.Open()
        Catch mex As MySql.Data.MySqlClient.MySqlException
            If mex.Number = 0 Then
                MsgBox("Tidak Koneksi Database")
            ElseIf mex.Number = 1045 Then
                MsgBox("Salah user/pass Mysql")
            Else
                MsgBox(mex.Number & mex.Message)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub kosong(ByVal FormAktif As Object)
        For Each ctl As Control In FormAktif.controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Or TypeOf ctl Is MaskedTextBox Or TypeOf ctl Is CheckBox Then
                ctl.Text = ""
            End If
        Next
    End Sub

    Public Sub Aktif(ByVal FormAktif As Object, ByVal OnOff As String)
        For Each ctl As Control In FormAktif.controls
            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Or TypeOf ctl Is MaskedTextBox Or TypeOf ctl Is CheckBox Then
                If OnOff = "ON" Then
                    ctl.Enabled = True

                ElseIf OnOff = "OFF" Then
                    ctl.Enabled = False
                End If
            End If
        Next
    End Sub


End Module
