Imports System.Data.SqlClient
Imports BTKhoiNghiep.Form6

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Menu Chính"
    End Sub

    Private Sub BtKhachHang_Click(sender As Object, e As EventArgs) Handles BtKhachHang.Click
        Dim f As New Form1
        f.ShowDialog()
    End Sub

    Private Sub BtSanPham_Click(sender As Object, e As EventArgs) Handles BtSanPham.Click
        Dim f As New Form4
        f.ShowDialog()
    End Sub

    Private Sub BtHoaDon_Click(sender As Object, e As EventArgs) Handles BtHoaDon.Click
        Dim f As New Form5
        f.ShowDialog()
    End Sub

    Private Sub BtThoat_Click(sender As Object, e As EventArgs) Handles BtThoat.Click
        Application.Exit()
    End Sub
End Class
