Imports System.Data.SqlClient
Public Class Form5
    Dim connectionString As String = "Data Source=DESKTOP-8E6NIMB;Initial Catalog=QL_TraSua;Integrated Security=True;"
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionString)
        LoadData()
        SetupDataGridView()
    End Sub
    Private Sub SetupDataGridView()
        With Data_DS
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
        End With
    End Sub
    Private Sub LoadData()
        Try
            conn.Open()
            da = New SqlDataAdapter("SELECT * FROM ChiTiet_HoaDon ORDER BY MaHD", conn)
            dt = New DataTable()
            da.Fill(dt)
            Data_DS.DataSource = dt
            If Data_DS.Columns.Count > 0 Then
                Data_DS.Columns("MaHD").HeaderText = "Mã HD"
                Data_DS.Columns("MaMon").HeaderText = "Mã Món"
                Data_DS.Columns("SoLuong").HeaderText = "Số Lượng"
                Data_DS.Columns("DonGia").HeaderText = "Đơn Giá"
                Data_DS.Columns("ThanhTien").HeaderText = "Thành Tiền"
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Nút Thêm hóa đơn
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        If ValidateInput() Then
            Try
                conn.Open()
                cmd = New SqlCommand("INSERT INTO ChiTiet_HoaDon (MaHD, MaMon, SoLuong, DonGia, ThanhTien) VALUES (@mahd, @mamon, @soluong, @dongia, @thanhtien)", conn)

                cmd.Parameters.AddWithValue("@mahd", TxtMK.Text.Trim())
                cmd.Parameters.AddWithValue("@mamon", TxtTM.Text.Trim())
                cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(TxtSL.Text))
                cmd.Parameters.AddWithValue("@dongia", Convert.ToDecimal(TxtDG.Text))
                cmd.Parameters.AddWithValue("@thanhtien", Convert.ToDecimal(TxtTong.Text))

                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm hóa đơn thành công!")
                LoadData()
                ClearControls()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi thêm: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    ' Nút Sửa hóa đơn
    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        If Data_DS.SelectedRows.Count > 0 AndAlso ValidateInput() Then
            Try
                Dim maHD As String = Data_DS.SelectedRows(0).Cells("MaHD").Value.ToString()
                Dim maMon As String = Data_DS.SelectedRows(0).Cells("MaMon").Value.ToString()

                conn.Open()
                cmd = New SqlCommand("UPDATE ChiTiet_HoaDon SET SoLuong = @soluong, DonGia = @dongia, ThanhTien = @thanhtien WHERE MaHD = @mahd AND MaMon = @mamon", conn)

                cmd.Parameters.AddWithValue("@mahd", maHD)
                cmd.Parameters.AddWithValue("@mamon", maMon)
                cmd.Parameters.AddWithValue("@soluong", Convert.ToInt32(TxtSL.Text))
                cmd.Parameters.AddWithValue("@dongia", Convert.ToDecimal(TxtDG.Text))
                cmd.Parameters.AddWithValue("@thanhtien", Convert.ToDecimal(TxtTong.Text))

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cập nhật hóa đơn thành công!")
                LoadData()
                ClearControls()
                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi cập nhật: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        Else
            MessageBox.Show("Vui lòng chọn một dòng để sửa!")
        End If
    End Sub

    ' Nút Xóa hóa đơn
    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        If Data_DS.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Dim maHD As String = Data_DS.SelectedRows(0).Cells("MaHD").Value.ToString()
                    Dim maMon As String = Data_DS.SelectedRows(0).Cells("MaMon").Value.ToString()

                    conn.Open()
                    cmd = New SqlCommand("DELETE FROM ChiTiet_HoaDon WHERE MaHD = @mahd AND MaMon = @mamon", conn)
                    cmd.Parameters.AddWithValue("@mahd", maHD)
                    cmd.Parameters.AddWithValue("@mamon", maMon)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Xóa chi tiết hóa đơn thành công!")
                    LoadData()
                    ClearControls()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi xóa: " & ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End If
        Else
            MessageBox.Show("Vui lòng chọn một dòng để xóa!")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_DS.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Data_DS.Rows(e.RowIndex)

            ' Hiển thị thông tin vào các controls
            If row.Cells("MaHD").Value IsNot Nothing Then
                TxtMK.Text = row.Cells("MaHD").Value.ToString()
            End If

            If row.Cells("MaMon").Value IsNot Nothing Then
                TxtTM.Text = row.Cells("MaMon").Value.ToString()
            End If

            If row.Cells("SoLuong").Value IsNot Nothing Then
                TxtSL.Text = row.Cells("SoLuong").Value.ToString()
            End If

            If row.Cells("DonGia").Value IsNot Nothing Then
                TxtDG.Text = row.Cells("DonGia").Value.ToString()
            End If

            If row.Cells("ThanhTien").Value IsNot Nothing Then
                TxtTong.Text = row.Cells("ThanhTien").Value.ToString()
            End If
        End If
    End Sub

    Private Sub TxtSL_TextChanged(sender As Object, e As EventArgs) Handles TxtSL.TextChanged
        TinhThanhTien()
    End Sub

    Private Sub TxtDG_TextChanged(sender As Object, e As EventArgs) Handles TxtDG.TextChanged
        TinhThanhTien()
    End Sub

    Private Sub TinhThanhTien()
        Try
            Dim soLuong As Integer
            Dim donGia As Decimal

            If Integer.TryParse(TxtSL.Text, soLuong) And Decimal.TryParse(TxtDG.Text, donGia) Then
                Dim thanhTien As Decimal = soLuong * donGia
                TxtTong.Text = thanhTien.ToString("N2")
            Else
                TxtTong.Text = "0"
            End If
        Catch ex As Exception
            TxtTong.Text = "0"
        End Try
    End Sub

    ' Kiểm tra tính hợp lệ của input
    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(TxtMK.Text) Then
            MessageBox.Show("Vui lòng nhập mã hóa đơn!")
            TxtMK.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtTM.Text) Then
            MessageBox.Show("Vui lòng nhập mã món!")
            TxtTM.Focus()
            Return False
        End If

        Dim soLuong As Integer
        If String.IsNullOrWhiteSpace(TxtSL.Text) OrElse Not Integer.TryParse(TxtSL.Text, soLuong) OrElse soLuong <= 0 Then
            MessageBox.Show("Số lượng phải là số nguyên dương!")
            TxtSL.Focus()
            Return False
        End If

        Dim donGia As Decimal
        If String.IsNullOrWhiteSpace(TxtDG.Text) OrElse Not Decimal.TryParse(TxtDG.Text, donGia) OrElse donGia <= 0 Then
            MessageBox.Show("Đơn giá phải là số dương!")
            TxtDG.Focus()
            Return False
        End If

        Return True
    End Function
    Private Sub ClearControls()
        TxtMK.Clear()
        TxtTM.Clear()
        TxtSL.Clear()
        TxtDG.Clear()
        TxtTong.Clear()

        Data_DS.ClearSelection()
    End Sub

    Private Sub TinhTongTienHoaDon()
        Try
            Dim maHD As String = TxtMK.Text.Trim()
            If Not String.IsNullOrEmpty(maHD) Then
                conn.Open()
                cmd = New SqlCommand("SELECT SUM(ThanhTien) FROM ChiTietHoaDon WHERE MaHD = @mahd", conn)
                cmd.Parameters.AddWithValue("@mahd", maHD)

                Dim tongTien As Object = cmd.ExecuteScalar()
                If tongTien IsNot Nothing AndAlso Not IsDBNull(tongTien) Then
                    MessageBox.Show($"Tổng tiền hóa đơn {maHD}: {Convert.ToDecimal(tongTien):N0} VND")
                Else
                    MessageBox.Show("Không tìm thấy hóa đơn!")
                End If

                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tính tổng tiền: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Nút tính tổng tiền (nếu có)
    Private Sub BtTong_Click(sender As Object, e As EventArgs) Handles BtTong.Click
        TinhTongTienHoaDon()
    End Sub

    Private Sub SearchHoaDon(maHD As String)
        Try
            conn.Open()
            da = New SqlDataAdapter("SELECT * FROM ChiTiet_HoaDon WHERE MaHD LIKE '%" & maHD & "%' ORDER BY MaHD", conn)
            dt = New DataTable()
            da.Fill(dt)
            Data_DS.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tìm kiếm: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub BtLamMoi_Click(sender As Object, e As EventArgs) Handles BtLamMoi.Click
        LoadData()
        ClearControls()
    End Sub

End Class