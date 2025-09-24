<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Data_DS = New DataGridView()
        BtDau = New Button()
        BtTruoc = New Button()
        BtSau = New Button()
        BtCuoi = New Button()
        BtThem = New Button()
        BtSua = New Button()
        BtXoa = New Button()
        BtTimKiem = New Button()
        BtLuu = New Button()
        BtThoat = New Button()
        LbMK = New Label()
        LbHT = New Label()
        HbSDT = New Label()
        LbDiaChi = New Label()
        TxtMKH = New TextBox()
        TxtTKH = New TextBox()
        TxtSDT = New TextBox()
        TxtDC = New TextBox()
        CType(Data_DS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Data_DS
        ' 
        Data_DS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_DS.Location = New Point(55, 25)
        Data_DS.Name = "Data_DS"
        Data_DS.RowHeadersWidth = 51
        Data_DS.Size = New Size(744, 206)
        Data_DS.TabIndex = 1
        ' 
        ' BtDau
        ' 
        BtDau.Location = New Point(116, 286)
        BtDau.Name = "BtDau"
        BtDau.Size = New Size(83, 31)
        BtDau.TabIndex = 2
        BtDau.Text = "<<"
        BtDau.UseVisualStyleBackColor = True
        ' 
        ' BtTruoc
        ' 
        BtTruoc.Location = New Point(235, 286)
        BtTruoc.Name = "BtTruoc"
        BtTruoc.Size = New Size(83, 31)
        BtTruoc.TabIndex = 3
        BtTruoc.Text = "<"
        BtTruoc.UseVisualStyleBackColor = True
        ' 
        ' BtSau
        ' 
        BtSau.Location = New Point(501, 286)
        BtSau.Name = "BtSau"
        BtSau.Size = New Size(83, 31)
        BtSau.TabIndex = 4
        BtSau.Text = ">"
        BtSau.UseVisualStyleBackColor = True
        ' 
        ' BtCuoi
        ' 
        BtCuoi.Location = New Point(621, 286)
        BtCuoi.Name = "BtCuoi"
        BtCuoi.Size = New Size(83, 31)
        BtCuoi.TabIndex = 5
        BtCuoi.Text = ">>"
        BtCuoi.UseVisualStyleBackColor = True
        ' 
        ' BtThem
        ' 
        BtThem.Location = New Point(55, 355)
        BtThem.Name = "BtThem"
        BtThem.Size = New Size(83, 31)
        BtThem.TabIndex = 6
        BtThem.Text = "Thêm"
        BtThem.UseVisualStyleBackColor = True
        ' 
        ' BtSua
        ' 
        BtSua.Location = New Point(168, 355)
        BtSua.Name = "BtSua"
        BtSua.Size = New Size(83, 31)
        BtSua.TabIndex = 7
        BtSua.Text = "Sửa"
        BtSua.UseVisualStyleBackColor = True
        ' 
        ' BtXoa
        ' 
        BtXoa.Location = New Point(282, 355)
        BtXoa.Name = "BtXoa"
        BtXoa.Size = New Size(83, 31)
        BtXoa.TabIndex = 8
        BtXoa.Text = "Xóa"
        BtXoa.UseVisualStyleBackColor = True
        ' 
        ' BtTimKiem
        ' 
        BtTimKiem.Location = New Point(444, 355)
        BtTimKiem.Name = "BtTimKiem"
        BtTimKiem.Size = New Size(83, 31)
        BtTimKiem.TabIndex = 9
        BtTimKiem.Text = "Tìm Kiếm"
        BtTimKiem.UseVisualStyleBackColor = True
        ' 
        ' BtLuu
        ' 
        BtLuu.Location = New Point(552, 355)
        BtLuu.Name = "BtLuu"
        BtLuu.Size = New Size(83, 31)
        BtLuu.TabIndex = 10
        BtLuu.Text = "Lưu"
        BtLuu.UseVisualStyleBackColor = True
        ' 
        ' BtThoat
        ' 
        BtThoat.Location = New Point(661, 355)
        BtThoat.Name = "BtThoat"
        BtThoat.Size = New Size(83, 31)
        BtThoat.TabIndex = 11
        BtThoat.Text = "Thoát"
        BtThoat.UseVisualStyleBackColor = True
        ' 
        ' LbMK
        ' 
        LbMK.AutoSize = True
        LbMK.Location = New Point(74, 464)
        LbMK.Name = "LbMK"
        LbMK.Size = New Size(117, 20)
        LbMK.TabIndex = 16
        LbMK.Text = "Mã KHách Hàng"
        ' 
        ' LbHT
        ' 
        LbHT.AutoSize = True
        LbHT.Location = New Point(74, 527)
        LbHT.Name = "LbHT"
        LbHT.Size = New Size(116, 20)
        LbHT.TabIndex = 17
        LbHT.Text = "Tên Khách Hàng"
        ' 
        ' HbSDT
        ' 
        HbSDT.AutoSize = True
        HbSDT.Location = New Point(444, 460)
        HbSDT.Name = "HbSDT"
        HbSDT.Size = New Size(35, 20)
        HbSDT.TabIndex = 18
        HbSDT.Text = "SDT"
        ' 
        ' LbDiaChi
        ' 
        LbDiaChi.AutoSize = True
        LbDiaChi.Location = New Point(444, 520)
        LbDiaChi.Name = "LbDiaChi"
        LbDiaChi.Size = New Size(57, 20)
        LbDiaChi.TabIndex = 19
        LbDiaChi.Text = "Địa Chỉ"
        ' 
        ' TxtMKH
        ' 
        TxtMKH.Location = New Point(207, 457)
        TxtMKH.Name = "TxtMKH"
        TxtMKH.Size = New Size(139, 27)
        TxtMKH.TabIndex = 20
        ' 
        ' TxtTKH
        ' 
        TxtTKH.Location = New Point(207, 520)
        TxtTKH.Name = "TxtTKH"
        TxtTKH.Size = New Size(139, 27)
        TxtTKH.TabIndex = 21
        ' 
        ' TxtSDT
        ' 
        TxtSDT.Location = New Point(531, 453)
        TxtSDT.Name = "TxtSDT"
        TxtSDT.Size = New Size(139, 27)
        TxtSDT.TabIndex = 22
        ' 
        ' TxtDC
        ' 
        TxtDC.Location = New Point(531, 517)
        TxtDC.Name = "TxtDC"
        TxtDC.Size = New Size(139, 27)
        TxtDC.TabIndex = 23
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(850, 629)
        Controls.Add(TxtDC)
        Controls.Add(TxtSDT)
        Controls.Add(TxtTKH)
        Controls.Add(TxtMKH)
        Controls.Add(LbDiaChi)
        Controls.Add(HbSDT)
        Controls.Add(LbHT)
        Controls.Add(LbMK)
        Controls.Add(BtThoat)
        Controls.Add(BtLuu)
        Controls.Add(BtTimKiem)
        Controls.Add(BtXoa)
        Controls.Add(BtSua)
        Controls.Add(BtThem)
        Controls.Add(BtCuoi)
        Controls.Add(BtSau)
        Controls.Add(BtTruoc)
        Controls.Add(BtDau)
        Controls.Add(Data_DS)
        Name = "Form1"
        Text = "F_KhachHang"
        CType(Data_DS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents BtDau As Button
    Friend WithEvents BtTruoc As Button
    Friend WithEvents BtSau As Button
    Friend WithEvents BtCuoi As Button
    Friend WithEvents BtThem As Button
    Friend WithEvents BtSua As Button
    Friend WithEvents BtXoa As Button
    Friend WithEvents BtTimKiem As Button
    Friend WithEvents BtLuu As Button
    Friend WithEvents BtThoat As Button
    Friend WithEvents LbMK As Label
    Friend WithEvents LbHT As Label
    Friend WithEvents HbSDT As Label
    Friend WithEvents LbDiaChi As Label
    Friend WithEvents TxtMKH As TextBox
    Friend WithEvents TxtTKH As TextBox
    Friend WithEvents TxtSDT As TextBox
    Friend WithEvents TxtDC As TextBox
End Class
