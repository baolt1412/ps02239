<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Danh_sach_san_pham
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HệThốngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĐăngXuấtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMụcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BảngDữLiệuSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchLoạiSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhSáchChiTiếtSảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChứcNăngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrợGiúpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NgườiTạoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhầnMềmHỗTrợToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.bangdulieuSP1 = New System.Windows.Forms.DataGridView()
        Me.btxemdulieu1 = New System.Windows.Forms.Button()
        Me.btchinhsuadulieu1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.bangdulieuSP1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HệThốngToolStripMenuItem, Me.DanhMụcToolStripMenuItem, Me.ChứcNăngToolStripMenuItem, Me.TrợGiúpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HệThốngToolStripMenuItem
        '
        Me.HệThốngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĐăngXuấtToolStripMenuItem})
        Me.HệThốngToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HệThốngToolStripMenuItem.Name = "HệThốngToolStripMenuItem"
        Me.HệThốngToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.HệThốngToolStripMenuItem.Text = "Hệ thống"
        '
        'ĐăngXuấtToolStripMenuItem
        '
        Me.ĐăngXuấtToolStripMenuItem.Name = "ĐăngXuấtToolStripMenuItem"
        Me.ĐăngXuấtToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ĐăngXuấtToolStripMenuItem.Text = "Đăng xuất"
        '
        'DanhMụcToolStripMenuItem
        '
        Me.DanhMụcToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BảngDữLiệuSảnPhẩmToolStripMenuItem, Me.DanhSáchSảnPhẩmToolStripMenuItem, Me.DanhSáchHóaĐơnToolStripMenuItem, Me.DanhSáchLoạiSảnPhẩmToolStripMenuItem, Me.DanhSáchChiTiếtSảnPhẩmToolStripMenuItem})
        Me.DanhMụcToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DanhMụcToolStripMenuItem.Name = "DanhMụcToolStripMenuItem"
        Me.DanhMụcToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.DanhMụcToolStripMenuItem.Text = "Danh mục"
        '
        'BảngDữLiệuSảnPhẩmToolStripMenuItem
        '
        Me.BảngDữLiệuSảnPhẩmToolStripMenuItem.Name = "BảngDữLiệuSảnPhẩmToolStripMenuItem"
        Me.BảngDữLiệuSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.BảngDữLiệuSảnPhẩmToolStripMenuItem.Text = "Danh sách khách hàng"
        '
        'DanhSáchSảnPhẩmToolStripMenuItem
        '
        Me.DanhSáchSảnPhẩmToolStripMenuItem.Name = "DanhSáchSảnPhẩmToolStripMenuItem"
        Me.DanhSáchSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DanhSáchSảnPhẩmToolStripMenuItem.Text = "Danh sách sản phẩm"
        '
        'DanhSáchHóaĐơnToolStripMenuItem
        '
        Me.DanhSáchHóaĐơnToolStripMenuItem.Name = "DanhSáchHóaĐơnToolStripMenuItem"
        Me.DanhSáchHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DanhSáchHóaĐơnToolStripMenuItem.Text = "Danh sách hóa đơn"
        '
        'DanhSáchLoạiSảnPhẩmToolStripMenuItem
        '
        Me.DanhSáchLoạiSảnPhẩmToolStripMenuItem.Name = "DanhSáchLoạiSảnPhẩmToolStripMenuItem"
        Me.DanhSáchLoạiSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DanhSáchLoạiSảnPhẩmToolStripMenuItem.Text = "Danh sách loại sản phẩm"
        '
        'DanhSáchChiTiếtSảnPhẩmToolStripMenuItem
        '
        Me.DanhSáchChiTiếtSảnPhẩmToolStripMenuItem.Name = "DanhSáchChiTiếtSảnPhẩmToolStripMenuItem"
        Me.DanhSáchChiTiếtSảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.DanhSáchChiTiếtSảnPhẩmToolStripMenuItem.Text = "Danh sách chi tiết hóa đơn"
        '
        'ChứcNăngToolStripMenuItem
        '
        Me.ChứcNăngToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChứcNăngToolStripMenuItem.Name = "ChứcNăngToolStripMenuItem"
        Me.ChứcNăngToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ChứcNăngToolStripMenuItem.Text = "Chức năng"
        '
        'TrợGiúpToolStripMenuItem
        '
        Me.TrợGiúpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NgườiTạoToolStripMenuItem, Me.PhầnMềmHỗTrợToolStripMenuItem})
        Me.TrợGiúpToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrợGiúpToolStripMenuItem.Name = "TrợGiúpToolStripMenuItem"
        Me.TrợGiúpToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.TrợGiúpToolStripMenuItem.Text = "Trợ giúp"
        '
        'NgườiTạoToolStripMenuItem
        '
        Me.NgườiTạoToolStripMenuItem.Name = "NgườiTạoToolStripMenuItem"
        Me.NgườiTạoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NgườiTạoToolStripMenuItem.Text = "Người tạo"
        '
        'PhầnMềmHỗTrợToolStripMenuItem
        '
        Me.PhầnMềmHỗTrợToolStripMenuItem.Name = "PhầnMềmHỗTrợToolStripMenuItem"
        Me.PhầnMềmHỗTrợToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PhầnMềmHỗTrợToolStripMenuItem.Text = "Phần mềm hỗ trợ"
        '
        'bangdulieuSP1
        '
        Me.bangdulieuSP1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.bangdulieuSP1.Location = New System.Drawing.Point(0, 27)
        Me.bangdulieuSP1.Name = "bangdulieuSP1"
        Me.bangdulieuSP1.Size = New System.Drawing.Size(445, 165)
        Me.bangdulieuSP1.TabIndex = 1
        '
        'btxemdulieu1
        '
        Me.btxemdulieu1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btxemdulieu1.Location = New System.Drawing.Point(0, 198)
        Me.btxemdulieu1.Name = "btxemdulieu1"
        Me.btxemdulieu1.Size = New System.Drawing.Size(111, 23)
        Me.btxemdulieu1.TabIndex = 2
        Me.btxemdulieu1.Text = "Xem dữ liệu"
        Me.btxemdulieu1.UseVisualStyleBackColor = True
        '
        'btchinhsuadulieu1
        '
        Me.btchinhsuadulieu1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btchinhsuadulieu1.Location = New System.Drawing.Point(117, 198)
        Me.btchinhsuadulieu1.Name = "btchinhsuadulieu1"
        Me.btchinhsuadulieu1.Size = New System.Drawing.Size(328, 23)
        Me.btchinhsuadulieu1.TabIndex = 3
        Me.btchinhsuadulieu1.Text = "Chỉnh sửa dữ liệu"
        Me.btchinhsuadulieu1.UseVisualStyleBackColor = True
        '
        'Danh_sach_san_pham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 228)
        Me.Controls.Add(Me.btchinhsuadulieu1)
        Me.Controls.Add(Me.btxemdulieu1)
        Me.Controls.Add(Me.bangdulieuSP1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Danh_sach_san_pham"
        Me.Text = "Danh sách sản phẩm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.bangdulieuSP1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents bangdulieuSP1 As System.Windows.Forms.DataGridView
    Friend WithEvents btxemdulieu1 As System.Windows.Forms.Button
    Friend WithEvents HệThốngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ĐăngXuấtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhMụcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BảngDữLiệuSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchLoạiSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DanhSáchChiTiếtSảnPhẩmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChứcNăngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrợGiúpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NgườiTạoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhầnMềmHỗTrợToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btchinhsuadulieu1 As System.Windows.Forms.Button
End Class
