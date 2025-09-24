<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        BtDK = New Button()
        BtThoat = New Button()
        TxtTDN = New TextBox()
        TxtMK = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' BtDK
        ' 
        BtDK.Location = New Point(155, 281)
        BtDK.Name = "BtDK"
        BtDK.Size = New Size(152, 48)
        BtDK.TabIndex = 0
        BtDK.Text = "Đăng Kí"
        BtDK.UseVisualStyleBackColor = True
        ' 
        ' BtThoat
        ' 
        BtThoat.Location = New Point(409, 281)
        BtThoat.Name = "BtThoat"
        BtThoat.Size = New Size(152, 48)
        BtThoat.TabIndex = 2
        BtThoat.Text = "Thoát"
        BtThoat.UseVisualStyleBackColor = True
        ' 
        ' TxtTDN
        ' 
        TxtTDN.Location = New Point(343, 64)
        TxtTDN.Multiline = True
        TxtTDN.Name = "TxtTDN"
        TxtTDN.Size = New Size(218, 53)
        TxtTDN.TabIndex = 3
        ' 
        ' TxtMK
        ' 
        TxtMK.Location = New Point(343, 162)
        TxtMK.Multiline = True
        TxtMK.Name = "TxtMK"
        TxtMK.Size = New Size(218, 53)
        TxtMK.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(174, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 20)
        Label1.TabIndex = 5
        Label1.Text = "Tên Đăng Nhập"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 6
        Label2.Text = "Mật Khẩu"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtMK)
        Controls.Add(TxtTDN)
        Controls.Add(BtThoat)
        Controls.Add(BtDK)
        Name = "Form2"
        Text = "F_DangKi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtDK As Button
    Friend WithEvents BtThoat As Button
    Friend WithEvents TxtTDN As TextBox
    Friend WithEvents TxtMK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
