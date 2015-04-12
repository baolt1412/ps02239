<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assignment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.taikhoan1 = New System.Windows.Forms.TextBox()
        Me.matkhau1 = New System.Windows.Forms.TextBox()
        Me.thoat1 = New System.Windows.Forms.Button()
        Me.xoa1 = New System.Windows.Forms.Button()
        Me.dangnhap1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tài khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mật khẩu"
        '
        'taikhoan1
        '
        Me.taikhoan1.Location = New System.Drawing.Point(169, 47)
        Me.taikhoan1.Name = "taikhoan1"
        Me.taikhoan1.Size = New System.Drawing.Size(204, 20)
        Me.taikhoan1.TabIndex = 1
        '
        'matkhau1
        '
        Me.matkhau1.Location = New System.Drawing.Point(169, 78)
        Me.matkhau1.Name = "matkhau1"
        Me.matkhau1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.matkhau1.Size = New System.Drawing.Size(204, 20)
        Me.matkhau1.TabIndex = 1
        '
        'thoat1
        '
        Me.thoat1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thoat1.Location = New System.Drawing.Point(184, 134)
        Me.thoat1.Name = "thoat1"
        Me.thoat1.Size = New System.Drawing.Size(75, 51)
        Me.thoat1.TabIndex = 2
        Me.thoat1.Text = "Thoát"
        Me.thoat1.UseVisualStyleBackColor = True
        '
        'xoa1
        '
        Me.xoa1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xoa1.Location = New System.Drawing.Point(298, 134)
        Me.xoa1.Name = "xoa1"
        Me.xoa1.Size = New System.Drawing.Size(75, 51)
        Me.xoa1.TabIndex = 2
        Me.xoa1.Text = "Xóa"
        Me.xoa1.UseVisualStyleBackColor = True
        '
        'dangnhap1
        '
        Me.dangnhap1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dangnhap1.Location = New System.Drawing.Point(68, 134)
        Me.dangnhap1.Name = "dangnhap1"
        Me.dangnhap1.Size = New System.Drawing.Size(75, 51)
        Me.dangnhap1.TabIndex = 2
        Me.dangnhap1.Text = "Đăng nhập"
        Me.dangnhap1.UseVisualStyleBackColor = True
        '
        'Assignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 214)
        Me.Controls.Add(Me.xoa1)
        Me.Controls.Add(Me.dangnhap1)
        Me.Controls.Add(Me.thoat1)
        Me.Controls.Add(Me.matkhau1)
        Me.Controls.Add(Me.taikhoan1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Assignment"
        Me.Text = "Assignment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents taikhoan1 As System.Windows.Forms.TextBox
    Friend WithEvents matkhau1 As System.Windows.Forms.TextBox
    Friend WithEvents thoat1 As System.Windows.Forms.Button
    Friend WithEvents xoa1 As System.Windows.Forms.Button
    Friend WithEvents dangnhap1 As System.Windows.Forms.Button

End Class
