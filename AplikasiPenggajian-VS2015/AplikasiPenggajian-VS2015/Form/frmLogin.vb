Public Class frmLogin

    Dim blueColor As Color = Color.FromArgb(74, 99, 202)
    Dim darkGrey As Color = Color.FromArgb(79, 82, 95)
    Dim lightGrey As Color = Color.FromArgb(101, 104, 116)
    Dim darkBlue As Color = Color.FromArgb(53, 75, 166)
    Dim redColor As Color = Color.FromArgb(209, 72, 53)

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = darkGrey
        Panel2.BackColor = darkBlue
        BtnLogin.BackColor = blueColor
        Label2.BackColor = lightGrey
        Label2.ForeColor = darkGrey

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Login()
    End Sub

    Sub bersih()
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub
    Sub Login()
        If txtUsername.Text = "" Then
            MsgBox("Username Tidak Boleh Kosong", MsgBoxStyle.Critical)
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong", MsgBoxStyle.Critical)
            txtPassword.Focus()
        Else
            Try
                cekkoneksi()
                sqlcommand = New MySql.Data.MySqlClient.MySqlCommand("Select * from users Where username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'", conn)
                Dr = sqlcommand.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then
                    MsgBox("Maaf Username atau Password Anda Salah", vbOKOnly, "Konfirmasi")
                    Dr.Close()
                    tutupkoneksi()
                    bersih()
                    txtUsername.Focus()
                    Exit Sub
                Else
                    MsgBox("Login berhasil", vbOKOnly, "Konfirmasi")
                    frmSplash.Show()
                    Me.Hide()
                    'frmMain.lblUsernmae.Text = txtUsername.Text
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                tutupkoneksi()
            End Try

        End If
        Call bersih()
        txtUsername.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.BackColor = redColor
        Label2.ForeColor = Color.White

    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.BackColor = lightGrey
        Label2.ForeColor = darkGrey
    End Sub
End Class