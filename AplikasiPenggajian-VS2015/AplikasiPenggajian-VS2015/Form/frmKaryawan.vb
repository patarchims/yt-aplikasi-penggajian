Public Class frmKaryawan

    Dim buttonColor As Color = Color.FromArgb(189, 202, 255)
    Private Sub frmKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnBatal.BackColor = buttonColor
        BtnHapus.BackColor = buttonColor
        BtnSimpan.BackColor = buttonColor
        BtnTambah.BackColor = buttonColor
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()

    End Sub
End Class