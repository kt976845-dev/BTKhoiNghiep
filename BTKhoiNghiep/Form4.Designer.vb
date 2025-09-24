<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        BtXoa = New Button()
        BtSua = New Button()
        BtThem = New Button()
        BtThoat = New Button()
        Data_DS = New DataGridView()
        LbTTS = New Label()
        LbMTS = New Label()
        TxtTNL = New TextBox()
        TxtMNL = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        CbDVT = New ComboBox()
        TxtSLT = New TextBox()
        Label3 = New Label()
        CType(Data_DS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtXoa
        ' 
        BtXoa.Location = New Point(511, 376)
        BtXoa.Name = "BtXoa"
        BtXoa.Size = New Size(83, 31)
        BtXoa.TabIndex = 11
        BtXoa.Text = "Xóa"
        BtXoa.UseVisualStyleBackColor = True
        ' 
        ' BtSua
        ' 
        BtSua.Location = New Point(511, 308)
        BtSua.Name = "BtSua"
        BtSua.Size = New Size(83, 31)
        BtSua.TabIndex = 10
        BtSua.Text = "Sửa"
        BtSua.UseVisualStyleBackColor = True
        ' 
        ' BtThem
        ' 
        BtThem.Location = New Point(511, 250)
        BtThem.Name = "BtThem"
        BtThem.Size = New Size(83, 31)
        BtThem.TabIndex = 9
        BtThem.Text = "Thêm"
        BtThem.UseVisualStyleBackColor = True
        ' 
        ' BtThoat
        ' 
        BtThoat.Location = New Point(511, 450)
        BtThoat.Name = "BtThoat"
        BtThoat.Size = New Size(83, 31)
        BtThoat.TabIndex = 14
        BtThoat.Text = "Thoát"
        BtThoat.UseVisualStyleBackColor = True
        ' 
        ' Data_DS
        ' 
        Data_DS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Data_DS.Location = New Point(30, 12)
        Data_DS.Name = "Data_DS"
        Data_DS.RowHeadersWidth = 51
        Data_DS.Size = New Size(744, 206)
        Data_DS.TabIndex = 15
        ' 
        ' LbTTS
        ' 
        LbTTS.AutoSize = True
        LbTTS.Location = New Point(70, 319)
        LbTTS.Name = "LbTTS"
        LbTTS.Size = New Size(118, 20)
        LbTTS.TabIndex = 19
        LbTTS.Text = "Tên Nguyên Liệu"
        ' 
        ' LbMTS
        ' 
        LbMTS.AutoSize = True
        LbMTS.Location = New Point(70, 254)
        LbMTS.Name = "LbMTS"
        LbMTS.Size = New Size(116, 20)
        LbMTS.TabIndex = 18
        LbMTS.Text = "Mã Nguyên Liệu"
        ' 
        ' TxtTNL
        ' 
        TxtTNL.Location = New Point(206, 316)
        TxtTNL.Name = "TxtTNL"
        TxtTNL.Size = New Size(139, 27)
        TxtTNL.TabIndex = 23
        ' 
        ' TxtMNL
        ' 
        TxtMNL.Location = New Point(206, 254)
        TxtMNL.Name = "TxtMNL"
        TxtMNL.Size = New Size(139, 27)
        TxtMNL.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(70, 319)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 20)
        Label1.TabIndex = 19
        Label1.Text = "Tên Nguyên Liệu"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 423)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 24
        Label2.Text = "Đơn Vị Tính"
        ' 
        ' CbDVT
        ' 
        CbDVT.FormattingEnabled = True
        CbDVT.Items.AddRange(New Object() {"Kg", "Gram"})
        CbDVT.Location = New Point(203, 415)
        CbDVT.Name = "CbDVT"
        CbDVT.Size = New Size(142, 28)
        CbDVT.TabIndex = 25
        ' 
        ' TxtSLT
        ' 
        TxtSLT.Location = New Point(206, 367)
        TxtSLT.Name = "TxtSLT"
        TxtSLT.Size = New Size(139, 27)
        TxtSLT.TabIndex = 26
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(68, 374)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 20)
        Label3.TabIndex = 27
        Label3.Text = "Số Lượng Tồn"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 568)
        Controls.Add(Label3)
        Controls.Add(TxtSLT)
        Controls.Add(CbDVT)
        Controls.Add(Label2)
        Controls.Add(TxtTNL)
        Controls.Add(TxtMNL)
        Controls.Add(Label1)
        Controls.Add(LbTTS)
        Controls.Add(LbMTS)
        Controls.Add(Data_DS)
        Controls.Add(BtThoat)
        Controls.Add(BtXoa)
        Controls.Add(BtSua)
        Controls.Add(BtThem)
        Name = "Form4"
        Text = "F_SanPham"
        CType(Data_DS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtXoa As Button
    Friend WithEvents BtSua As Button
    Friend WithEvents BtThem As Button
    Friend WithEvents BtThoat As Button
    Friend WithEvents Data_DS As DataGridView
    Friend WithEvents LbTTS As Label
    Friend WithEvents LbMTS As Label
    Friend WithEvents TxtTNL As TextBox
    Friend WithEvents TxtMNL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbDVT As ComboBox
    Friend WithEvents TxtSLT As TextBox
    Friend WithEvents Label3 As Label
End Class
