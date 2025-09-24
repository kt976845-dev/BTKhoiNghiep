<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        BtKhachHang = New Button()
        BtSanPham = New Button()
        BtHoaDon = New Button()
        BtThoat = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtKhachHang
        ' 
        BtKhachHang.Location = New Point(232, 124)
        BtKhachHang.Name = "BtKhachHang"
        BtKhachHang.Size = New Size(298, 52)
        BtKhachHang.TabIndex = 0
        BtKhachHang.Text = "Thông Tin Khách Hàng"
        BtKhachHang.UseVisualStyleBackColor = True
        ' 
        ' BtSanPham
        ' 
        BtSanPham.Location = New Point(232, 200)
        BtSanPham.Name = "BtSanPham"
        BtSanPham.Size = New Size(298, 52)
        BtSanPham.TabIndex = 1
        BtSanPham.Text = "Thông Tin Sản Phẩm"
        BtSanPham.UseVisualStyleBackColor = True
        ' 
        ' BtHoaDon
        ' 
        BtHoaDon.Location = New Point(232, 280)
        BtHoaDon.Name = "BtHoaDon"
        BtHoaDon.Size = New Size(298, 52)
        BtHoaDon.TabIndex = 2
        BtHoaDon.Text = "Hóa Đơn"
        BtHoaDon.UseVisualStyleBackColor = True
        ' 
        ' BtThoat
        ' 
        BtThoat.Location = New Point(630, 355)
        BtThoat.Name = "BtThoat"
        BtThoat.Size = New Size(91, 52)
        BtThoat.TabIndex = 3
        BtThoat.Text = "Thoát"
        BtThoat.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(323, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 50)
        Label1.TabIndex = 4
        Label1.Text = "Menu"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BtThoat)
        Controls.Add(BtHoaDon)
        Controls.Add(BtSanPham)
        Controls.Add(BtKhachHang)
        Name = "Form6"
        Text = "F_Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtKhachHang As Button
    Friend WithEvents BtSanPham As Button
    Friend WithEvents BtHoaDon As Button
    Friend WithEvents BtThoat As Button
    Friend WithEvents Label1 As Label
End Class
