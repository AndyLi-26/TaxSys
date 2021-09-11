<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class s
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
        Me.save = New System.Windows.Forms.Button()
        Me.taxcb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.taxNum = New System.Windows.Forms.TextBox()
        Me.taxId = New System.Windows.Forms.TextBox()
        Me.val = New System.Windows.Forms.TextBox()
        Me.datep = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.confirm = New System.Windows.Forms.Button()
        Me.Comment = New System.Windows.Forms.TextBox()
        Me.Exp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.save.Location = New System.Drawing.Point(708, 256)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(118, 51)
        Me.save.TabIndex = 0
        Me.save.Text = "保存"
        Me.save.UseVisualStyleBackColor = True
        '
        'taxcb
        '
        Me.taxcb.AllowDrop = True
        Me.taxcb.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxcb.FormattingEnabled = True
        Me.taxcb.Items.AddRange(New Object() {"增值税电子普通发票", "增值税电子专用发票"})
        Me.taxcb.Location = New System.Drawing.Point(589, 46)
        Me.taxcb.Name = "taxcb"
        Me.taxcb.Size = New System.Drawing.Size(237, 32)
        Me.taxcb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "发票代码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "发票号码"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "开票日期"
        '
        'taxNum
        '
        Me.taxNum.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxNum.Location = New System.Drawing.Point(154, 94)
        Me.taxNum.Name = "taxNum"
        Me.taxNum.Size = New System.Drawing.Size(229, 35)
        Me.taxNum.TabIndex = 6
        '
        'taxId
        '
        Me.taxId.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxId.Location = New System.Drawing.Point(154, 43)
        Me.taxId.Name = "taxId"
        Me.taxId.Size = New System.Drawing.Size(229, 35)
        Me.taxId.TabIndex = 7
        '
        'val
        '
        Me.val.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.val.Location = New System.Drawing.Point(154, 204)
        Me.val.Name = "val"
        Me.val.Size = New System.Drawing.Size(229, 35)
        Me.val.TabIndex = 10
        '
        'datep
        '
        Me.datep.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.datep.Location = New System.Drawing.Point(154, 147)
        Me.datep.Name = "datep"
        Me.datep.Size = New System.Drawing.Size(229, 35)
        Me.datep.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(447, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "发票类型"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "金额"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 24)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "备注"
        '
        'confirm
        '
        Me.confirm.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.confirm.Location = New System.Drawing.Point(708, 181)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(118, 57)
        Me.confirm.TabIndex = 23
        Me.confirm.Text = "确认"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'Comment
        '
        Me.Comment.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Comment.Location = New System.Drawing.Point(154, 269)
        Me.Comment.Multiline = True
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(294, 114)
        Me.Comment.TabIndex = 24
        '
        'Exp
        '
        Me.Exp.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Exp.Location = New System.Drawing.Point(708, 332)
        Me.Exp.Name = "Exp"
        Me.Exp.Size = New System.Drawing.Size(118, 51)
        Me.Exp.TabIndex = 25
        Me.Exp.Text = "导出"
        Me.Exp.UseVisualStyleBackColor = True
        '
        's
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 463)
        Me.Controls.Add(Me.Exp)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.datep)
        Me.Controls.Add(Me.val)
        Me.Controls.Add(Me.taxId)
        Me.Controls.Add(Me.taxNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taxcb)
        Me.Controls.Add(Me.save)
        Me.Name = "s"
        Me.Text = "发票管理系统"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save As Button
    Friend WithEvents taxcb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents taxNum As TextBox
    Friend WithEvents taxId As TextBox
    Friend WithEvents val As TextBox
    Friend WithEvents datep As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents confirm As Button
    Friend WithEvents Comment As TextBox
    Friend WithEvents Exp As Button
End Class
