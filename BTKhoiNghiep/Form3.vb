Imports System.Data.SqlClient

Public Class Form3
    Dim Ket_Noi As SqlConnection
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-8E6NIMB\SQLEXPRESS;Initial Catalog=KHACH_HANG;Integrated Security=True;Trust Server Certificate=True")
        Ket_Noi.Open()
    End Sub
    Private Sub Btdangnhap_Click(sender As Object, e As EventArgs) Handles BtDN.Click
        If TxtTDN.Text.Trim() = "" Then
            MsgBox("Bạn chưa nhập dữ liệu", vbYes, "Thông báo")
        End If
        Dim SQL As New SqlDataAdapter("Select * From TaiKhoan Where TenDangNhap=@TenDN AND MatKhau=@MatKhau", Ket_Noi)
        SQL.SelectCommand.Parameters.AddWithValue("@TenDN", TxtTDN.Text.Trim())
        SQL.SelectCommand.Parameters.AddWithValue("@MatKhau", TxtMK.Text)

        Dim Db As New DataTable
        SQL.Fill(Db)
        If Db.Rows.Count > 0 Then
            MsgBox("Đăng nhập thành công")
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Sai tên đăng nhập hoặc mật khẩu")
        End If
    End Sub

    Private Sub BtDK_Click(sender As Object, e As EventArgs) Handles BtDK.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Close()
    End Sub
End Class
