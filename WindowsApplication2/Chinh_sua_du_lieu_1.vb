Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Chinh_sua_du_lieu_1
    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlSan_pham As New SqlDataAdapter("select * from San_Pham", connect)
        Dim tb As New DataTable
        Try
            sqlSan_pham.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuSP2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub btxemdulieu_chinhsua1_Click(sender As Object, e As EventArgs) Handles btxemdulieu_chinhsuaSP2.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from San_Pham", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuSP2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub btthem1_Click(sender As Object, e As EventArgs) Handles btthemSP.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into San_Pham Values (@Ma_SP, @Ten_SP, @Ngay_xuat, @Ngay_nhap, @So_Luong, @Loai_San_Pham_Ma_Loai_SP)"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_SP", txchinhsuadulieuSP1.Text)
            unk.Parameters.AddWithValue("@Ten_SP", txchinhsuadulieuSP2.Text)
            unk.Parameters.AddWithValue("@Ngay_xuat", txchinhsuadulieuSP3.Text)
            unk.Parameters.AddWithValue("@Ngay_nhap", txchinhsuadulieuSP4.Text)
            unk.Parameters.AddWithValue("@So_Luong", txchinhsuadulieuSP5.Text)
            unk.Parameters.AddWithValue("@Loai_San_Pham_Ma_Loai_SP", txchinhsuadulieuSP6.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuSP2.DataSource = tb
        bangdulieuSP2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub bangdulieu2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bangdulieuSP2.CellContentClick
        Dim Index As Integer = bangdulieuSP2.CurrentCell.RowIndex
        txchinhsuadulieuSP1.Text = bangdulieuSP2.Item(0, Index).Value
        txchinhsuadulieuSP2.Text = bangdulieuSP2.Item(1, Index).Value
        txchinhsuadulieuSP3.Text = bangdulieuSP2.Item(2, Index).Value
        txchinhsuadulieuSP4.Text = bangdulieuSP2.Item(3, Index).Value
        txchinhsuadulieuSP5.Text = bangdulieuSP2.Item(4, Index).Value
        txchinhsuadulieuSP6.Text = bangdulieuSP2.Item(5, Index).Value
    End Sub

    Private Sub btsua1_Click(sender As Object, e As EventArgs) Handles btsuaSP.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE San_Pham SET Ten_SP = @Ten_SP, Ngay_xuat = @Ngay_xuat, Ngay_nhap = @Ngay_nhap, So_Luong = @So_Luong, Loai_San_Pham_Ma_Loai_SP = @Loai_San_Pham_Ma_Loai_SP WHERE Ma_SP = @Ma_SP"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_SP", txchinhsuadulieuSP1.Text)
            unk.Parameters.AddWithValue("@Ten_SP", txchinhsuadulieuSP2.Text)
            unk.Parameters.AddWithValue("@Ngay_xuat", txchinhsuadulieuSP3.Text)
            unk.Parameters.AddWithValue("@Ngay_nhap", txchinhsuadulieuSP4.Text)
            unk.Parameters.AddWithValue("@So_Luong", txchinhsuadulieuSP5.Text)
            unk.Parameters.AddWithValue("@Loai_San_Pham_Ma_Loai_SP", txchinhsuadulieuSP6.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuSP2.DataSource = tb
        bangdulieuSP2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btxoa1_Click(sender As Object, e As EventArgs) Handles btxoaSP.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from San_Pham where Ma_SP = @Ma_SP"
        Dim unk As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_SP", txchinhsuadulieuSP1.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuSP2.DataSource = tb
        bangdulieuSP2.DataSource = Nothing
        LoadData()
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

    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Assignment.Show()
        Me.Close()
    End Sub
End Class