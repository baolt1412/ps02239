Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Chinh_sua_du_lieu_4

    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlSan_pham As New SqlDataAdapter("select * from Hoa_Don", connect)
        Dim tb As New DataTable
        Try
            sqlSan_pham.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuHD2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub bangdulieuSP2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bangdulieuHD2.CellContentClick
        Dim Index As Integer = bangdulieuHD2.CurrentCell.RowIndex
        txchinhsuadulieuHD1.Text = bangdulieuHD2.Item(0, Index).Value
        txchinhsuadulieuHD2.Text = bangdulieuHD2.Item(1, Index).Value
        txchinhsuadulieuHD3.Text = bangdulieuHD2.Item(2, Index).Value
        txchinhsuadulieuHD4.Text = bangdulieuHD2.Item(3, Index).Value
        txchinhsuadulieuHD5.Text = bangdulieuHD2.Item(4, Index).Value
        txchinhsuadulieuHD6.Text = bangdulieuHD2.Item(5, Index).Value
        txchinhsuadulieuHD7.Text = bangdulieuHD2.Item(6, Index).Value
    End Sub

    Private Sub btthemHD_Click(sender As Object, e As EventArgs) Handles btthemHD.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into Hoa_Don Values (@So_HD, @Ma_KH, @Ten_KH, @Ma_Loai_SP, @Ten_SP, @Tong_tien_HD, @San_Pham_Ma_SP, @Khach_Hang_Ma_KH)"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@So_HD", txchinhsuadulieuHD1.Text)
            unk.Parameters.AddWithValue("@Ma_KH", txchinhsuadulieuHD2.Text)
            unk.Parameters.AddWithValue("@Ten_KH", txchinhsuadulieuHD3.Text)
            unk.Parameters.AddWithValue("@Ma_Loai_SP", txchinhsuadulieuHD4.Text)
            unk.Parameters.AddWithValue("@Ten_SP", txchinhsuadulieuHD5.Text)
            unk.Parameters.AddWithValue("@Tong_tien_HD", txchinhsuadulieuHD6.Text)
            unk.Parameters.AddWithValue("@San_Pham_Ma_SP", txchinhsuadulieuHD7.Text)
            unk.Parameters.AddWithValue("@Khach_Hang_Ma_KH", txchinhsuadulieuHD8.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuHD2.DataSource = tb
        bangdulieuHD2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btxemdulieu_chinhsuaHD2_Click(sender As Object, e As EventArgs) Handles btxemdulieu_chinhsuaHD2.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Hoa_Don", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuHD2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub btsuaHD_Click(sender As Object, e As EventArgs) Handles btsuaHD.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE Hoa_Don SET Ma_KH = @Ma_KH, Ten_KH = @Ten_KH, Ma_Loai_SP = @Ma_Loai_SP, Ten_SP = @Ten_SP, Tong_tien_HD = @Tong_tien_HD, San_Pham_Ma_SP = @San_Pham_Ma_SP, Khach_Hang_Ma_KH = @Khach_Hang_Ma_KH WHERE So_HD = @So_HD"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@So_HD", txchinhsuadulieuHD1.Text)
            unk.Parameters.AddWithValue("@Ma_KH", txchinhsuadulieuHD2.Text)
            unk.Parameters.AddWithValue("@Ten_KH", txchinhsuadulieuHD3.Text)
            unk.Parameters.AddWithValue("@Ma_Loai_SP", txchinhsuadulieuHD4.Text)
            unk.Parameters.AddWithValue("@Ten_SP", txchinhsuadulieuHD5.Text)
            unk.Parameters.AddWithValue("@Tong_tien_HD", txchinhsuadulieuHD6.Text)
            unk.Parameters.AddWithValue("@San_Pham_Ma_SP", txchinhsuadulieuHD7.Text)
            unk.Parameters.AddWithValue("@Khach_Hang_Ma_KH", txchinhsuadulieuHD8.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuHD2.DataSource = tb
        bangdulieuHD2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btxoaHD_Click(sender As Object, e As EventArgs) Handles btxoaHD.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Hoa_Don where So_HD = @So_HD"
        Dim unk As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@So_HD", txchinhsuadulieuHD1.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuHD2.DataSource = tb
        bangdulieuHD2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btthoatHD_Click(sender As Object, e As EventArgs) Handles btthoatHD.Click
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

    Private Sub DanhSáchChiTiếtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSáchChiTiếtSảnPhẩmToolStripMenuItem.Click
        Danh_sach_chi_tiet_hoa_don.Show()
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