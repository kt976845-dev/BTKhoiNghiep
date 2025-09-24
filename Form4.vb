Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form4
    Dim connectionString As String = "Data Source=DESKTOP-8E6NIMB;Initial Catalog=QL_TraSua;Integrated Security=True;"
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionString)
        LoadData()
        LoadComboBox()
    End Sub


    Private Sub LoadData()
        Try
            conn.Open()
            da = New SqlDataAdapter("SELECT * FROM Nguyen_Lieu", conn)
            dt = New DataTable()
            da.Fill(dt)
            Data_DS.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Lỗi khi tải dữ liệu: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub LoadComboBox()
        CbDVT.Items.Clear()
        CbDVT.Items.Add("kg")
        CbDVT.Items.Add("gram")
    End Sub

    Private Sub BtThem_Click(sender As Object, e As EventArgs) Handles BtThem.Click
        If ValidateInput() Then
            Try
                conn.Open()
                cmd = New SqlCommand("INSERT INTO NguyenLieu (TenNguyenLieu, DonViTinh, SoLuongTon) VALUES (@ten, @donvi, @soluong)", conn)
                cmd.Parameters.AddWithValue("@ten", TxtTNL.Text.Trim())
                cmd.Parameters.AddWithValue("@donvi", CbDVT.Text)
                cmd.Parameters.AddWithValue("@soluong", Convert.ToDecimal(TxtMNL.Text))

                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm nguyên liệu thành công!")
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

    Private Sub BtSua_Click(sender As Object, e As EventArgs) Handles BtSua.Click
        If Data_DS.SelectedRows.Count > 0 AndAlso ValidateInput() Then
            Try
                Dim maNguyenLieu As Integer = Convert.ToInt32(Data_DS.SelectedRows(0).Cells("MaNguyenLieu").Value)

                conn.Open()
                cmd = New SqlCommand("UPDATE Nguyen_Lieu SET TenNguyenLieu = @ten, DonViTinh = @donvi, SoLuongTon = @soluong WHERE MaNguyenLieu = @ma", conn)
                cmd.Parameters.AddWithValue("@ma", maNguyenLieu)
                cmd.Parameters.AddWithValue("@ten", TxtTNL.Text.Trim())
                cmd.Parameters.AddWithValue("@donvi", CbDVT.Text)
                cmd.Parameters.AddWithValue("@soluong", Convert.ToDecimal(TxtMNL.Text))

                cmd.ExecuteNonQuery()
                MessageBox.Show("Cập nhật nguyên liệu thành công!")
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

    ' Nút Xóa
    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        If Data_DS.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    Dim maNguyenLieu As Integer = Convert.ToInt32(Data_DS.SelectedRows(0).Cells("MaNguyenLieu").Value)

                    conn.Open()
                    cmd = New SqlCommand("DELETE FROM Nguyen_Lieu WHERE MaNguyenLieu = @ma", conn)
                    cmd.Parameters.AddWithValue("@ma", maNguyenLieu)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Xóa nguyên liệu thành công!")
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

    Private Sub Data_DS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Data_DS.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Data_DS.Rows(e.RowIndex)

            If row.Cells("TenNguyenLieu").Value IsNot Nothing Then
                TxtTNL.Text = row.Cells("TenNguyenLieu").Value.ToString()
            End If

            If row.Cells("DonViTinh").Value IsNot Nothing Then
                CbDVT.Text = row.Cells("DonViTinh").Value.ToString()
            End If

            If row.Cells("SoLuongTon").Value IsNot Nothing Then
                TxtSLT.Text = row.Cells("SoLuongTon").Value.ToString()
            End If
        End If
    End Sub


    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(TxtTNL.Text) Then
            MessageBox.Show("Vui lòng nhập tên nguyên liệu!")
            TxtTNL.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(CbDVT.Text) Then
            MessageBox.Show("Vui lòng chọn đơn vị tính!")
            CbDVT.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtSLT.Text) Then
            MessageBox.Show("Vui lòng nhập số lượng tồn!")
            TxtSLT.Focus()
            Return False
        End If

        Dim soLuong As Decimal
        If Not Decimal.TryParse(TxtMNL.Text, soLuong) OrElse soLuong < 0 Then
            MessageBox.Show("Số lượng tồn phải là số không âm!")
            TxtMNL.Focus()
            Return False
        End If

        Return True
    End Function


    Private Sub ClearControls()
        TxtMNL.Clear()
        TxtTNL.Clear()
        CbDVT.SelectedIndex = -1
        Data_DS.ClearSelection()
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub


    Private Sub SearchData(searchText As String)
        Try
            conn.Open()
            da = New SqlDataAdapter("SELECT * FROM Nguyen_Lieu WHERE TenNguyenLieu LIKE '%" & searchText & "%'", conn)
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

End Class