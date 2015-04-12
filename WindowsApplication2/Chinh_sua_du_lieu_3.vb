Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Chinh_sua_du_lieu_3

    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlSan_pham As New SqlDataAdapter("select * from Loai_San_Pham", connect)
        Dim tb As New DataTable
        Try
            sqlSan_pham.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuLSP2.DataSource = tb
        connect.Close()
    End Sub
    Private Sub bangdulieuLSP2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bangdulieuLSP2.CellContentClick
        Dim Index As Integer = bangdulieuLSP2.CurrentCell.RowIndex
        txchinhsuadulieuLSP1.Text = bangdulieuLSP2.Item(0, Index).Value
        txchinhsuadulieuLSP2.Text = bangdulieuLSP2.Item(1, Index).Value
        txchinhsuadulieuLSP3.Text = bangdulieuLSP2.Item(2, Index).Value
        txchinhsuadulieuLSP4.Text = bangdulieuLSP2.Item(3, Index).Value
        txchinhsuadulieuLSP5.Text = bangdulieuLSP2.Item(4, Index).Value
    End Sub

    Private Sub btxemdulieu_chinhsuaLSP2_Click(sender As Object, e As EventArgs) Handles btxemdulieu_chinhsuaLSP2.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Loai_San_Pham", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuLSP2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub btthemLSP_Click(sender As Object, e As EventArgs) Handles btthemLSP.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into Loai_San_Pham Values (@Ma_Loai_SP, @Ten_SP, @So_Luong, @Chat_Luong_SP, @Danh_Gia_Loai_SP)"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_Loai_SP", txchinhsuadulieuLSP1.Text)
            unk.Parameters.AddWithValue("@Ten_SP", txchinhsuadulieuLSP2.Text)
            unk.Parameters.AddWithValue("@So_Luong", txchinhsuadulieuLSP3.Text)
            unk.Parameters.AddWithValue("@Chat_Luong_SP", txchinhsuadulieuLSP4.Text)
            unk.Parameters.AddWithValue("@Danh_Gia_Loai_SP", txchinhsuadulieuLSP5.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuLSP2.DataSource = tb
        bangdulieuLSP2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btsuaLSP_Click(sender As Object, e As EventArgs) Handles btsuaLSP.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE Loai_San_Pham SET Ten_SP = @Ten_SP, So_Luong = @So_Luong, Chat_Luong_SP = @Chat_Luong_SP, Danh_Gia_Loai_SP = @Danh_Gia_Loai_SP WHERE Ma_Loai_SP = @Ma_Loai_SP"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_Loai_SP", txchinhsuadulieuLSP1.Text)
            unk.Parameters.AddWithValue("@Ten_SP", txchinhsuadulieuLSP2.Text)
            unk.Parameters.AddWithValue("@So_Luong", txchinhsuadulieuLSP3.Text)
            unk.Parameters.AddWithValue("@Chat_Luong_SP", txchinhsuadulieuLSP4.Text)
            unk.Parameters.AddWithValue("@Danh_Gia_Loai_SP", txchinhsuadulieuLSP5.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuLSP2.DataSource = tb
        bangdulieuLSP2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btxoaLSP_Click(sender As Object, e As EventArgs) Handles btxoaLSP.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Loai_San_Pham where Ma_Loai_SP = @Ma_Loai_SP"
        Dim unk As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_Loai_SP", txchinhsuadulieuLSP1.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuLSP2.DataSource = tb
        bangdulieuLSP2.DataSource = Nothing
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
        Danh_sach_chi_tiet_hoa_don.Show()
        Me.Close()
    End Sub

    Private Sub NgườiTạoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NgườiTạoToolStripMenuItem.Click
        Nguoi_tao.Show()
        Me.Close()
    End Sub
End Class