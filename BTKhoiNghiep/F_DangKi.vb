Imports System.Data.SqlClient
Class Form2

    Dim Ket_Noi As SqlConnection
    Private Sub F_DangKi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ket_Noi = New SqlConnection("Data Source=DESKTOP-8E6NIMB\SQLEXPRESS;Initial Catalog=QL_TraSua;Integrated Security=True")
        Ket_Noi.Open()
    End Sub

    Private Sub BtDK_Click(sender As Object, e As EventArgs) Handles BtDK.Click
        If TxtTDN.Text.Trim() = "" Then
            MsgBox("Tên đăng nhập không được để trống!")
            Exit Sub
        End If

        If TxtMK.Text.Trim() = "" Then
            MsgBox("Mật khẩu không được để trống!")
            Exit Sub
        End If

        If TxtMK.Text.Length < 6 Then
            MsgBox("Mật khẩu phải có ít nhất 6 ký tự!")
            Exit Sub
        End If

        Dim SQL_KiemTra As New SqlDataAdapter("SELECT * FROM Tai_Khoan WHERE TenDN=@TenDN", Ket_Noi)
        SQL_KiemTra.SelectCommand.Parameters.AddWithValue("@TenDN", TxtTDN.Text.Trim())

        Dim Db_Check As New DataTable
        SQL_KiemTra.Fill(Db_Check)

        If Db_Check.Rows.Count > 0 Then
            MsgBox("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!")
            Exit Sub
        End If

        Dim SQL_DangKy As New SqlCommand("INSERT INTO TaiKhoan (TenDangNhap, MatKhau) VALUES (@TenDN, @MatKhau)", Ket_Noi)
        SQL_DangKy.Parameters.AddWithValue("@TenDN", TxtTDN.Text.Trim())
        SQL_DangKy.Parameters.AddWithValue("@MatKhau", TxtMK.Text)

        Try
            SQL_DangKy.ExecuteNonQuery()
            MsgBox("Đăng ký thành công!")

        Catch ex As Exception
            MsgBox("Có lỗi xảy ra khi đăng ký: " & ex.Message)
        End Try
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Close()
    End Sub
End Class
