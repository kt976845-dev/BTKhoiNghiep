Imports System.Data.SqlClient

Public Class Form1
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim Bs As BindingSource
    Dim cmd As SqlCommand
    Dim ChuoiKN As String = "Data Source=DESKTOP-8E6NIMB\SQLEXPRESS;Initial Catalog=QL_TraSua;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"
    Private viTriHienTai As Integer = 0
    Private Sub Data_DS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(ChuoiKN)
        HienThi()
        Load_dulieu()
    End Sub
    Private Sub Load_dulieu()
        Try
            Using cn As New SqlConnection(ChuoiKN)
                Using da As New SqlDataAdapter("
                    SELECT MaKhachHang, TenKhachHang, SDT, DiaChi
                    FROM dbo.Khach_Hang
                    ORDER BY MaKhachHang", cn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    Data_DS.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Lỗi nạp dữ liệu: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub HienThi()
        Try
            conn.Open()
            da = New SqlDataAdapter("SELECT * FROM Khach_Hang ORDER BY MaKhachHang", conn)
            dt = New DataTable()
            da.Fill(dt)
            Bs = New BindingSource()
            Bs.DataSource = dt
            Data_DS.DataSource = Bs
            Data_DS.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox("Lỗi hiển thị: " & ex.Message)
        End Try
    End Sub
    Private Function IsDigitsOnly(s As String) As Boolean
        If String.IsNullOrWhiteSpace(s) Then Return True
        For Each ch In s
            If ch < "0"c OrElse ch > "9"c Then Return False
        Next : Return True
    End Function
    Private Function MaDaTonTai(ma As Integer) As Boolean
        Using cn As New SqlConnection(ChuoiKN)
            Using cmd As New SqlCommand("SELECT 1 FROM dbo.Khach_Hang WHERE MaKhachHang=@Ma", cn)
                cmd.Parameters.AddWithValue("@Ma", ma)
                cn.Open()
                Return cmd.ExecuteScalar() IsNot Nothing
            End Using
        End Using
    End Function
    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        Dim ma As Integer
        If Not Integer.TryParse(TxtMKH.Text.Trim, ma) Then MsgBox("Nhập mã KH (số nguyên).") : TxtMKH.Focus() : Exit Sub
        If TxtTKH.Text.Trim = "" Then MsgBox("Họ tên không được trống.") : TxtTKH.Focus() : Exit Sub
        If Not IsDigitsOnly(TxtSDT.Text.Trim) Then MsgBox("SĐT chỉ gồm chữ số.") : TxtSDT.Focus() : Exit Sub
        If MaDaTonTai(ma) Then MsgBox("Mã KH đã tồn tại.") : TxtMKH.Focus() : TxtMKH.SelectAll() : Exit Sub
        Try
            conn.Open()
            Dim sql = "INSERT INTO Khach_Hang VALUES(@Ma, @Ten, @SDT, @DiaChi)"
            cmd = New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Ma", TxtMKH.Text)
            cmd.Parameters.AddWithValue("@Ten", TxtTKH.Text)
            cmd.Parameters.AddWithValue("@SDT", TxtSDT.Text)
            cmd.Parameters.AddWithValue("@DiaChi", TxtDC.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            HienThi()
        Catch ex As Exception
            MsgBox("Lỗi thêm: " & ex.Message)
        End Try
    End Sub

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        Dim s = InputBox("Nhập mã KH cần sửa:", "Sửa").Trim
        If s = "" Then Return
        Try
            conn.Open()

            Using cn As New SqlConnection(ChuoiKN)
                Using cmd As New SqlCommand("SELECT * FROM dbo.Khach_Hang WHERE MaKhachHang=@Ma", cn)
                    cmd.Parameters.AddWithValue("@Ma", CInt(s))
                    Using da As New SqlDataAdapter(cmd)
                        Dim tb As New DataTable : da.Fill(tb)
                        If tb.Rows.Count = 0 Then MsgBox("Không tìm thấy!") : Return
                        Dim r = tb.Rows(0)
                        TxtMKH.Text = r("MaKhachHang").ToString
                        TxtTKH.Text = r("TenKhachHang").ToString
                        TxtSDT.Text = r("SDT").ToString
                        TxtDC.Text = r("DiaChi").ToString
                        BtLuu.Enabled = True
                    End Using
                End Using
            End Using
            conn.Close()
            HienThi()
        Catch ex As Exception
            MsgBox("Lỗi sửa: " & ex.Message)
        End Try
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        Dim s = InputBox("Nhập mã KH cần xóa:", "Xóa").Trim
        If s = "" Then Return
        If MsgBox("Xóa khách hàng này?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then Return
        Try
            Using cn As New SqlConnection(ChuoiKN)
                cn.Open()

                Using cmd As New SqlCommand("DELETE FROM dbo.Khach_Hang WHERE MaKhachHang=@Ma", cn)
                    cmd.Parameters.AddWithValue("@Ma", CInt(s))
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Xóa thành công!") : Load_dulieu()
                    Else
                        MsgBox("Không tìm thấy bản ghi!")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Lỗi xóa: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub BtTimKiem_Click(sender As Object, e As EventArgs) Handles BtTimKiem.Click
        Dim s = InputBox("Nhập mã KH cần tìm:", "Tìm kiếm").Trim()
        If s = "" Then Return
        Try
            Using cn As New SqlConnection(ChuoiKN)
                Using cmd As New SqlCommand("SELECT * FROM dbo.Khach_Hang WHERE MaKhachHang=@Ma", cn)
                    cmd.Parameters.AddWithValue("@Ma", CInt(s))
                    Using da As New SqlDataAdapter(cmd)
                        Dim tb As New DataTable() : da.Fill(tb)
                        If tb.Rows.Count = 0 Then MsgBox("Không tìm thấy!") : Return
                        Dim r = tb.Rows(0)
                        TxtMKH.Text = r("MaKhachHang").ToString()
                        TxtTKH.Text = r("TenKhachHang").ToString()
                        TxtSDT.Text = r("SDT").ToString()
                        TxtDC.Text = r("DiaChi").ToString()
                        ' chọn dòng
                        For Each row As DataGridViewRow In Data_DS.Rows
                            If row.Cells(0).Value?.ToString() = s Then
                                row.Selected = True : Data_DS.CurrentCell = row.Cells(0) : viTriHienTai = row.Index : Exit For
                            End If
                        Next
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Lỗi tìm: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub BtLuu_Click(sender As Object, e As EventArgs) Handles BtLuu.Click
        Dim ma As Integer
        If Not Integer.TryParse(TxtMKH.Text.Trim(), ma) Then MsgBox("Mã KH không hợp lệ.") : Return
        If TxtTKH.Text.Trim() = "" Then MsgBox("Họ tên không được trống.") : Return
        If Not IsDigitsOnly(TxtSDT.Text.Trim()) Then MsgBox("SĐT chỉ gồm chữ số.") : Return
        Try
            Using cn As New SqlConnection(ChuoiKN)
                cn.Open()
                Using cmd As New SqlCommand("
                    UPDATE dbo.Khach_Hang
                       SET TenKhachHang=@Ten, SDT=@SDT, DiaChi=@DC
                     WHERE MaKhachHang=@Ma", cn)
                    cmd.Parameters.AddWithValue("@Ma", ma)
                    cmd.Parameters.AddWithValue("@Ten", TxtTKH.Text.Trim())
                    cmd.Parameters.AddWithValue("@SDT", If(TxtSDT.Text.Trim() = "", CType(DBNull.Value, Object), TxtSDT.Text.Trim()))
                    cmd.Parameters.AddWithValue("@DC", If(TxtDC.Text.Trim() = "", CType(DBNull.Value, Object), TxtDC.Text.Trim()))
                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Cập nhật thành công!") : Load_dulieu()
                    Else
                        MsgBox("Không thể cập nhật!")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Lỗi cập nhật: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Data_DS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_DS.CellContentClick
        Dim i As Integer = Data_DS.CurrentRow.Index
        TxtMKH.Text = Data_DS.Item(0, i).Value.ToString()
        TxtTKH.Text = Data_DS.Item(1, i).Value.ToString()
        TxtSDT.Text = Data_DS.Item(2, i).Value.ToString()
        TxtDC.Text = Data_DS.Item(3, i).Value.ToString()
        TxtMKH.DataBindings.Add("Text", Bs, "MaKhach")
        TxtTKH.DataBindings.Add("Text", Bs, "HoTen")
        TxtSDT.DataBindings.Add("Text", Bs, "SDT")
        TxtDC.DataBindings.Add("Text", Bs, "DiaChi")
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Me.Close()
    End Sub

    Private Sub BtDau_Click(sender As Object, e As EventArgs) Handles BtDau.Click
        Bs.MoveFirst()
    End Sub

    Private Sub BtTruoc_Click(sender As Object, e As EventArgs) Handles BtTruoc.Click
        Bs.MovePrevious()
    End Sub

    Private Sub BtSau_Click(sender As Object, e As EventArgs) Handles BtSau.Click
        Bs.MoveNext()
    End Sub

    Private Sub BtCuoi_Click(sender As Object, e As EventArgs) Handles BtCuoi.Click
        Bs.MoveLast()
    End Sub
End Class
