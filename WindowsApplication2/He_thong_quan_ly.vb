Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class He_thong_quan_ly

    Private Sub DanhSáchSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchSảnPhẩmToolStripMenuItem.Click
        Danh_sach_san_pham.Show()
        Me.Close()
    End Sub

    Private Sub BảngDữLiệuSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BảngDữLiệuSảnPhẩmToolStripMenuItem.Click
        Danh_sach_khach_hang.Show()
        Me.Close()
    End Sub

    Private Sub DanhSáchHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchHóaĐơnToolStripMenuItem.Click
        Danh_sach_hoa_don.Show()
        Me.Close()
    End Sub

    Private Sub DanhSáchLoạiSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchLoạiSảnPhẩmToolStripMenuItem.Click
        Danh_sach_loai_san_pham.Show()
        Me.Close()
    End Sub

    Private Sub DanhSáchChiTiếtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchChiTiếtSảnPhẩmToolStripMenuItem.Click
        Danh_sach_chi_tiet_hoa_don.Show()
        Me.Close()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Assignment.Show()
        Me.Close()
    End Sub

    Private Sub NgườiTạoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NgườiTạoToolStripMenuItem.Click
        Nguoi_tao.Show()
        Me.Close()
    End Sub

    Private Sub PhầnMềmHỗTrợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhầnMềmHỗTrợToolStripMenuItem.Click
        Phan_mem_ho_tro.Show()
        Me.Close()
    End Sub
End Class