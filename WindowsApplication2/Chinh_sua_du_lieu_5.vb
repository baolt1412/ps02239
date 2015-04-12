Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Chinh_sua_du_lieu_5

    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlSan_pham As New SqlDataAdapter("select * from Chi_Tiet_HD", connect)
        Dim tb As New DataTable
        Try
            sqlSan_pham.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuchitietHD2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub bangdulieuchitietHD2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bangdulieuchitietHD2.CellContentClick
        Dim Index As Integer = bangdulieuchitietHD2.CurrentCell.RowIndex
        txchinhsuadulieuchitietHD1.Text = bangdulieuchitietHD2.Item(0, Index).Value
        txchinhsuadulieuchitietHD2.Text = bangdulieuchitietHD2.Item(1, Index).Value
        txchinhsuadulieuchitietHD3.Text = bangdulieuchitietHD2.Item(2, Index).Value
        txchinhsuadulieuchitietHD4.Text = bangdulieuchitietHD2.Item(3, Index).Value
        txchinhsuadulieuchitietHD5.Text = bangdulieuchitietHD2.Item(4, Index).Value
        txchinhsuadulieuchitietHD6.Text = bangdulieuchitietHD2.Item(5, Index).Value
        txchinhsuadulieuchitietHD7.Text = bangdulieuchitietHD2.Item(6, Index).Value
    End Sub

    Private Sub btxemdulieu_chinhsuachitietHD2_Click(sender As Object, e As EventArgs) Handles btxemdulieu_chinhsuachitietHD2.Click
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
        bangdulieuchitietHD2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub btthemchitietHD_Click(sender As Object, e As EventArgs) Handles btthemchitietHD.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into Chi_Tiet_HD Values (@Ma_chitiet_HD, @So_HD, @So_Luong, @Gia_Ban, @Thue_SP, @Thanh_Tien, @Hoa_Don_So_HD)"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_chitiet_HD", txchinhsuadulieuchitietHD1.Text)
            unk.Parameters.AddWithValue("@So_HD", txchinhsuadulieuchitietHD2.Text)
            unk.Parameters.AddWithValue("@So_Luong", txchinhsuadulieuchitietHD3.Text)
            unk.Parameters.AddWithValue("@Gia_Ban", txchinhsuadulieuchitietHD4.Text)
            unk.Parameters.AddWithValue("@Thue_SP", txchinhsuadulieuchitietHD5.Text)
            unk.Parameters.AddWithValue("@Thanh_Tien", txchinhsuadulieuchitietHD6.Text)
            unk.Parameters.AddWithValue("@Hoa_Don_So_HD", txchinhsuadulieuchitietHD7.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuchitietHD2.DataSource = tb
        bangdulieuchitietHD2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btsuachitietHD_Click(sender As Object, e As EventArgs) Handles btsuachitietHD.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE Chi_Tiet_HD SET So_HD = @So_HD, So_Luong = @So_Luong, Gia_Ban = @Gia_Ban, Thue_SP= @Thue_SP, Thanh_Tien = @Thanh_Tien, Hoa_Don_So_HD = @Hoa_Don_So_HD WHERE Ma_chitiet_HD = @Ma_chitiet_HD"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_chitiet_HD", txchinhsuadulieuchitietHD1.Text)
            unk.Parameters.AddWithValue("@So_HD", txchinhsuadulieuchitietHD2.Text)
            unk.Parameters.AddWithValue("@So_Luong", txchinhsuadulieuchitietHD3.Text)
            unk.Parameters.AddWithValue("@Gia_Ban", txchinhsuadulieuchitietHD4.Text)
            unk.Parameters.AddWithValue("@Thue_SP", txchinhsuadulieuchitietHD5.Text)
            unk.Parameters.AddWithValue("@Thanh_Tien", txchinhsuadulieuchitietHD6.Text)
            unk.Parameters.AddWithValue("@Hoa_Don_So_HD", txchinhsuadulieuchitietHD7.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuchitietHD2.DataSource = tb
        bangdulieuchitietHD2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btxoachitietHD_Click(sender As Object, e As EventArgs) Handles btxoachitietHD.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Chi_Tiet_HD where Ma_chitiet_HD = @Ma_chitiet_HD"
        Dim unk As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_chitiet_HD", txchinhsuadulieuchitietHD1.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuchitietHD2.DataSource = tb
        bangdulieuchitietHD2.DataSource = Nothing
        LoadData()
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

    Private Sub btthoatchitietHD_Click(sender As Object, e As EventArgs) Handles btthoatchitietHD.Click
        Me.Close()
    End Sub
End Class