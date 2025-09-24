<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        BtXoa = New Button()
        BtSua = New Button()
        BtThem = New Button()
        BtLamMoi = New Button()
        BtTong = New Button()
        TxtTong = New TextBox()
        TxtMK = New TextBox()
        TxtTM = New TextBox()
        TxtSL = New TextBox()
        TxtDG = New TextBox()
        LbMK = New Label()
        LbTM = New Label()
        LbSL = New Label()
        LbDG = New Label()
        CType(Data_DS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Data_DS
        ' 
        Data_DS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_DS.Location = New Point(24, 12)
        Data_DS.Name = "Data_DS"
        Data_DS.RowHeadersWidth = 51
        Data_DS.Size = New Size(744, 206)
        Data_DS.TabIndex = 2
        ' 
        ' BtXoa
        ' 
        BtXoa.Location = New Point(408, 464)
        BtXoa.Name = "BtXoa"
        BtXoa.Size = New Size(83, 31)
        BtXoa.TabIndex = 11
        BtXoa.Text = "Xóa"
        BtXoa.UseVisualStyleBackColor = True
        ' 
        ' BtSua
        ' 
        BtSua.Location = New Point(251, 464)
        BtSua.Name = "BtSua"
        BtSua.Size = New Size(83, 31)
        BtSua.TabIndex = 10
        BtSua.Text = "Sửa"
        BtSua.UseVisualStyleBackColor = True
        ' 
        ' BtThem
        ' 
        BtThem.Location = New Point(80, 464)
        BtThem.Name = "BtThem"
        BtThem.Size = New Size(83, 31)
        BtThem.TabIndex = 9
        BtThem.Text = "Thêm"
        BtThem.UseVisualStyleBackColor = True
        ' 
        ' BtLamMoi
        ' 
        BtLamMoi.Location = New Point(573, 464)
        BtLamMoi.Name = "BtLamMoi"
        BtLamMoi.Size = New Size(83, 31)
        BtLamMoi.TabIndex = 12
        BtLamMoi.Text = "Làm Mới"
        BtLamMoi.UseVisualStyleBackColor = True
        ' 
        ' BtTong
        ' 
        BtTong.Location = New Point(236, 389)
        BtTong.Name = "BtTong"
        BtTong.Size = New Size(83, 31)
        BtTong.TabIndex = 13
        BtTong.Text = "Tổng Tiền"
        BtTong.UseVisualStyleBackColor = True
        ' 
        ' TxtTong
        ' 
        TxtTong.Location = New Point(360, 391)
        TxtTong.Name = "TxtTong"
        TxtTong.Size = New Size(154, 27)
        TxtTong.TabIndex = 14
        ' 
        ' TxtMK
        ' 
        TxtMK.Location = New Point(180, 257)
        TxtMK.Name = "TxtMK"
        TxtMK.Size = New Size(154, 27)
        TxtMK.TabIndex = 15
        ' 
        ' TxtTM
        ' 
        TxtTM.Location = New Point(180, 323)
        TxtTM.Name = "TxtTM"
        TxtTM.Size = New Size(154, 27)
        TxtTM.TabIndex = 16
        ' 
        ' TxtSL
        ' 
        TxtSL.Location = New Point(573, 257)
        TxtSL.Name = "TxtSL"
        TxtSL.Size = New Size(154, 27)
        TxtSL.TabIndex = 17
        ' 
        ' TxtDG
        ' 
        TxtDG.Location = New Point(573, 323)
        TxtDG.Name = "TxtDG"
        TxtDG.Size = New Size(154, 27)
        TxtDG.TabIndex = 18
        ' 
        ' LbMK
        ' 
        LbMK.AutoSize = True
        LbMK.Location = New Point(80, 264)
        LbMK.Name = "LbMK"
        LbMK.Size = New Size(74, 20)
        LbMK.TabIndex = 19
        LbMK.Text = "Mã Khách"
        ' 
        ' LbTM
        ' 
        LbTM.AutoSize = True
        LbTM.Location = New Point(80, 330)
        LbTM.Name = "LbTM"
        LbTM.Size = New Size(70, 20)
        LbTM.TabIndex = 20
        LbTM.Text = "Tên Món "
        ' 
        ' LbSL
        ' 
        LbSL.AutoSize = True
        LbSL.Location = New Point(461, 260)
        LbSL.Name = "LbSL"
        LbSL.Size = New Size(72, 20)
        LbSL.TabIndex = 21
        LbSL.Text = "Số Lượng"
        ' 
        ' LbDG
        ' 
        LbDG.AutoSize = True
        LbDG.Location = New Point(461, 330)
        LbDG.Name = "LbDG"
        LbDG.Size = New Size(63, 20)
        LbDG.TabIndex = 22
        LbDG.Text = "Đơn Giá"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 584)
        Controls.Add(LbDG)
        Controls.Add(LbSL)
        Controls.Add(LbTM)
        Controls.Add(LbMK)
        Controls.Add(TxtDG)
        Controls.Add(TxtSL)
        Controls.Add(TxtTM)
        Controls.Add(TxtMK)
        Controls.Add(TxtTong)
        Controls.Add(BtTong)
        Controls.Add(BtLamMoi)
        Controls.Add(BtXoa)
        Controls.Add(BtSua)
        Controls.Add(BtThem)
        Controls.Add(Data_DS)
        Name = "Form5"
        Text = "F_HoaDon"
        CType(Data_DS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents BtXoa As Button
    Friend WithEvents BtSua As Button
    Friend WithEvents BtThem As Button
    Friend WithEvents BtLamMoi As Button
    Friend WithEvents BtTong As Button
    Friend WithEvents TxtTong As TextBox
    Friend WithEvents TxtMK As TextBox
    Friend WithEvents TxtTM As TextBox
    Friend WithEvents TxtSL As TextBox
    Friend WithEvents TxtDG As TextBox
    Friend WithEvents LbMK As Label
    Friend WithEvents LbTM As Label
    Friend WithEvents LbSL As Label
    Friend WithEvents LbDG As Label
End Class
