Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class chinh_sua_du_lieu_2
    Public Sub LoadData()
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        Dim sqlSan_pham As New SqlDataAdapter("select * from Khach_Hang", connect)
        Dim tb As New DataTable
        Try
            sqlSan_pham.Fill(tb)
        Catch ex As Exception

        End Try
        bangdulieuKH2.DataSource = tb
        connect.Close()
    End Sub
    Private Sub bangdulieuKH2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles bangdulieuKH2.CellContentClick
        Dim Index As Integer = bangdulieuKH2.CurrentCell.RowIndex
        txchinhsuadulieuKH1.Text = bangdulieuKH2.Item(0, Index).Value
        txchinhsuadulieuKH2.Text = bangdulieuKH2.Item(1, Index).Value
        txchinhsuadulieuKH3.Text = bangdulieuKH2.Item(2, Index).Value
        txchinhsuadulieuKH4.Text = bangdulieuKH2.Item(3, Index).Value
        txchinhsuadulieuKH5.Text = bangdulieuKH2.Item(4, Index).Value
        txchinhsuadulieuKH6.Text = bangdulieuKH2.Item(5, Index).Value
    End Sub

    Private Sub btxemdulieu_chinhsuaKH2_Click(sender As Object, e As EventArgs) Handles btxemdulieu_chinhsuaKH2.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        'Tạo đối tượng chạy câu truy vấn 
        Dim sqlAdapter As New SqlDataAdapter("select * from Khach_Hang", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            'Đổ dữ liệu trên Table vào Datatable trên máy
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        'Hiển thị dữ liệu Từ Datatable ra giao diện thông qua Datagridview
        bangdulieuKH2.DataSource = tb
        connect.Close()
    End Sub

    Private Sub btthemKH_Click(sender As Object, e As EventArgs) Handles btthemKH.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "insert into Khach_hang Values (@Ma_KH, @Ten_KH, @Gioi_Tinh, @So_DT, @Dia_Chi, @Email)"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_KH", txchinhsuadulieuKH1.Text)
            unk.Parameters.AddWithValue("@Ten_KH", txchinhsuadulieuKH2.Text)
            unk.Parameters.AddWithValue("@Gioi_Tinh", txchinhsuadulieuKH3.Text)
            unk.Parameters.AddWithValue("@So_DT", txchinhsuadulieuKH4.Text)
            unk.Parameters.AddWithValue("@Dia_Chi", txchinhsuadulieuKH5.Text)
            unk.Parameters.AddWithValue("@Email", txchinhsuadulieuKH6.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuKH2.DataSource = tb
        bangdulieuKH2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btsuaKH_Click(sender As Object, e As EventArgs) Handles btsuaKH.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim themdulieu As String = "UPDATE Khach_Hang SET Ten_KH = @Ten_KH, Gioi_Tinh = @Gioi_Tinh, So_DT = @So_DT, Dia_Chi = @Dia_Chi, Email = @Email WHERE Ma_KH = @Ma_KH"
        Dim unk As New SqlCommand(themdulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_KH", txchinhsuadulieuKH1.Text)
            unk.Parameters.AddWithValue("@Ten_KH", txchinhsuadulieuKH2.Text)
            unk.Parameters.AddWithValue("@Gioi_Tinh", txchinhsuadulieuKH3.Text)
            unk.Parameters.AddWithValue("@So_DT", txchinhsuadulieuKH4.Text)
            unk.Parameters.AddWithValue("@Dia_Chi", txchinhsuadulieuKH5.Text)
            unk.Parameters.AddWithValue("@Email", txchinhsuadulieuKH6.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuKH2.DataSource = tb
        bangdulieuKH2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btxoaKH_Click(sender As Object, e As EventArgs) Handles btxoaKH.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"
        Dim connect As New SqlConnection(someeconnect)
        connect.Open()

        Dim xoadulieu As String = "Delete from Khach_hang where Ma_KH = @Ma_KH"
        Dim unk As New SqlCommand(xoadulieu, connect)
        Dim tb As New DataTable
        Try
            unk.Parameters.AddWithValue("@Ma_KH", txchinhsuadulieuKH1.Text)
            unk.ExecuteNonQuery()
            connect.Close()
        Catch ex As Exception

        End Try
        tb.Clear()
        bangdulieuKH2.DataSource = tb
        bangdulieuKH2.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btthoatKH_Click(sender As Object, e As EventArgs) Handles btthoatKH.Click
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

    Private Sub chinh_sua_du_lieu_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class