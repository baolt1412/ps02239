Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Danh_sach_chi_tiet_hoa_don

    Private Sub btxemdulieuChiTietHD2_Click(sender As Object, e As EventArgs) Handles btxemdulieuChiTietHD2.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Chi_Tiet_HD", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuChitietHD1.DataSource = tb
        connect.Close()
    End Sub

    Private Sub chinhsuadulieuChitietHD_Click(sender As Object, e As EventArgs) Handles chinhsuadulieuChitietHD.Click
        Chinh_sua_du_lieu_5.Show()
        Me.Close()
    End Sub

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Assignment.Show()
        Me.Close()
    End Sub

    Private Sub BảngDữLiệuSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BảngDữLiệuSảnPhẩmToolStripMenuItem.Click
        Danh_sach_khach_hang.Show()
        Me.Close()
    End Sub

    Private Sub DanhSáchSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchSảnPhẩmToolStripMenuItem.Click
        Danh_sach_san_pham.Show()
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

    Private Sub NgườiTạoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NgườiTạoToolStripMenuItem.Click
        Nguoi_tao.Show()
        Me.Close()
    End Sub

    Private Sub PhầnMềmHỗTrợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhầnMềmHỗTrợToolStripMenuItem.Click
        Phan_mem_ho_tro.Show()
        Me.Close()
    End Sub
End Class