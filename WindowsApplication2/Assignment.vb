Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Assignment
    Private Sub taikhoan1_TextChanged(sender As Object, e As EventArgs) Handles taikhoan1.TextChanged

    End Sub
    Private Sub matkhau1_TextChanged(sender As Object, e As EventArgs) Handles matkhau1.TextChanged

    End Sub
    Private Sub dangnhap1_Click(sender As Object, e As EventArgs) Handles dangnhap1.Click
        Dim someeconnect As String = "workstation id=ps02239assign.mssql.somee.com;packet size=4096;user id=baolt1412_SQLLogin_1;pwd=fuisprhyk9;data source=ps02239assign.mssql.somee.com;persist security info=False;initial catalog=ps02239assign"

        Dim connect As SqlConnection = New SqlConnection(someeconnect)
        Dim sqlAdapter As New SqlDataAdapter("select * from Khach_Hang where Ma_KH='" & taikhoan1.Text & "' and Ten_KH='" & matkhau1.Text & "' ", connect)
        Dim tb As New DataTable

        Try
            connect.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Kết nối thành công")
                He_thong_quan_ly.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu")
            End If


        Catch ex As Exception
        End Try
    End Sub
    Private Sub thoat1_Click(sender As Object, e As EventArgs) Handles thoat1.Click
        Me.Close()
    End Sub
    Private Sub xoa1_Click(sender As Object, e As EventArgs) Handles xoa1.Click
        taikhoan1.Clear()
        matkhau1.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
