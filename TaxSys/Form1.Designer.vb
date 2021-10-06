<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class record
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.taxcb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.taxId = New System.Windows.Forms.TextBox()
        Me.taxNum = New System.Windows.Forms.TextBox()
        Me.datep = New System.Windows.Forms.DateTimePicker()
        Me.confirm = New System.Windows.Forms.Button()
        Me.Exp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Comment = New System.Windows.Forms.TextBox()
        Me.val = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.ct = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.RecordDate = New System.Windows.Forms.DateTimePicker()
        Me.company = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'taxcb
        '
        Me.taxcb.AllowDrop = True
        Me.taxcb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.taxcb.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxcb.FormattingEnabled = True
        Me.taxcb.Items.AddRange(New Object() {"增值税电子普通", "增值税电子专用", "其他类型"})
        Me.taxcb.Location = New System.Drawing.Point(753, 81)
        Me.taxcb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxcb.Name = "taxcb"
        Me.taxcb.Size = New System.Drawing.Size(274, 32)
        Me.taxcb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DengXian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Olive
        Me.Label1.Location = New System.Drawing.Point(1343, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 30)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "发票代码:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("DengXian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Olive
        Me.Label2.Location = New System.Drawing.Point(1343, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "发票号码:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("DengXian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Olive
        Me.Label3.Location = New System.Drawing.Point(1343, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "开票日期:"
        '
        'taxId
        '
        Me.taxId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.taxId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.taxId.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxId.Location = New System.Drawing.Point(1495, 50)
        Me.taxId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxId.Name = "taxId"
        Me.taxId.Size = New System.Drawing.Size(229, 35)
        Me.taxId.TabIndex = 6
        '
        'taxNum
        '
        Me.taxNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.taxNum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.taxNum.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxNum.Location = New System.Drawing.Point(1495, 96)
        Me.taxNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxNum.Name = "taxNum"
        Me.taxNum.Size = New System.Drawing.Size(229, 35)
        Me.taxNum.TabIndex = 7
        '
        'datep
        '
        Me.datep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.datep.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.datep.Location = New System.Drawing.Point(1495, 137)
        Me.datep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datep.Name = "datep"
        Me.datep.Size = New System.Drawing.Size(229, 35)
        Me.datep.TabIndex = 13
        '
        'confirm
        '
        Me.confirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.confirm.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.confirm.Location = New System.Drawing.Point(1441, 425)
        Me.confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(118, 56)
        Me.confirm.TabIndex = 23
        Me.confirm.Text = "确认"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'Exp
        '
        Me.Exp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Exp.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Exp.Location = New System.Drawing.Point(1565, 425)
        Me.Exp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Exp.Name = "Exp"
        Me.Exp.Size = New System.Drawing.Size(118, 56)
        Me.Exp.TabIndex = 25
        Me.Exp.Text = "导出"
        Me.Exp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("DengXian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Olive
        Me.Label7.Location = New System.Drawing.Point(1029, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 37)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "发票"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Olive
        Me.Label14.Location = New System.Drawing.Point(464, 0)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "数量"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("DengXian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Olive
        Me.Label9.Location = New System.Drawing.Point(1343, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 30)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "录入日期"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Olive
        Me.Label4.Location = New System.Drawing.Point(711, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "数量"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label12.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Olive
        Me.Label12.Location = New System.Drawing.Point(377, 307)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "规格型号"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Olive
        Me.Label11.Location = New System.Drawing.Point(913, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 18)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "单价"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Olive
        Me.Label15.Location = New System.Drawing.Point(561, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 18)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "单位"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Olive
        Me.Label13.Location = New System.Drawing.Point(38, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(224, 18)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "货物或应税劳务、服务名称"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.ForeColor = System.Drawing.Color.Olive
        Me.Label17.Location = New System.Drawing.Point(71, 282)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 18)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "购买方名称" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(14, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1723, 26)
        Me.Label6.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(508, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 60)
        Me.Label8.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(14, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1723, 26)
        Me.Label10.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(14, 357)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1723, 26)
        Me.Label18.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(14, 298)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(1723, 58)
        Me.Label19.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(815, 298)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(243, 60)
        Me.Label20.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(1379, 298)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 69)
        Me.Label21.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label22.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Olive
        Me.Label22.Location = New System.Drawing.Point(1603, 307)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 18)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "税额"
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label23.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Olive
        Me.Label23.Location = New System.Drawing.Point(1206, 307)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 18)
        Me.Label23.TabIndex = 47
        Me.Label23.Text = "金额"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label24.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Olive
        Me.Label24.Location = New System.Drawing.Point(1417, 307)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(44, 18)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "税率"
        '
        'Label25
        '
        Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label25.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label25.Location = New System.Drawing.Point(14, 298)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(303, 58)
        Me.Label25.TabIndex = 49
        '
        'Comment
        '
        Me.Comment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Comment.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Comment.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Comment.Location = New System.Drawing.Point(1179, 382)
        Me.Comment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Comment.Multiline = True
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(558, 26)
        Me.Comment.TabIndex = 50
        '
        'val
        '
        Me.val.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.val.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.val.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.val.Location = New System.Drawing.Point(1057, 332)
        Me.val.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.val.Multiline = True
        Me.val.Name = "val"
        Me.val.Size = New System.Drawing.Size(323, 26)
        Me.val.TabIndex = 51
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Olive
        Me.Label26.Location = New System.Drawing.Point(105, 361)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 24)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "价税合计"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label31.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Olive
        Me.Label31.Location = New System.Drawing.Point(1130, 390)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(44, 18)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "备注"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(14, 332)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 26)
        Me.TextBox1.TabIndex = 66
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(316, 332)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 26)
        Me.TextBox2.TabIndex = 67
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox3.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(508, 332)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(149, 26)
        Me.TextBox3.TabIndex = 68
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox4.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(656, 332)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(160, 26)
        Me.TextBox4.TabIndex = 69
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox5.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(815, 332)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 26)
        Me.TextBox5.TabIndex = 70
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox6.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1379, 332)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(124, 26)
        Me.TextBox6.TabIndex = 71
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox8.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1502, 332)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(235, 26)
        Me.TextBox8.TabIndex = 72
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox9.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(316, 357)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(1421, 26)
        Me.TextBox9.TabIndex = 73
        '
        'TextBox10
        '
        Me.TextBox10.AllowDrop = True
        Me.TextBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox10.AutoCompleteCustomSource.AddRange(New String() {"010", "010", "010"})
        Me.TextBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox10.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(250, 273)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(1487, 26)
        Me.TextBox10.TabIndex = 74
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox11.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(250, 382)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(868, 26)
        Me.TextBox11.TabIndex = 75
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 62)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(27, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 18)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "字体大小"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox1.TabIndex = 79
        '
        'Label27
        '
        Me.Label27.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label27.ForeColor = System.Drawing.Color.Olive
        Me.Label27.Location = New System.Drawing.Point(92, 391)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(98, 18)
        Me.Label27.TabIndex = 80
        Me.Label27.Text = "销售方名称" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label28.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label28.Location = New System.Drawing.Point(1474, 335)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(22, 24)
        Me.Label28.TabIndex = 82
        Me.Label28.Text = "%"
        '
        'ct
        '
        Me.ct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ct.Location = New System.Drawing.Point(645, 81)
        Me.ct.Name = "ct"
        Me.ct.Size = New System.Drawing.Size(102, 28)
        Me.ct.TabIndex = 83
        Me.ct.Text = "上海"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1317, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 56)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "查询"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(1193, 425)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(118, 56)
        Me.clear.TabIndex = 85
        Me.clear.Text = "清空"
        Me.clear.UseVisualStyleBackColor = True
        '
        'RecordDate
        '
        Me.RecordDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RecordDate.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.RecordDate.Location = New System.Drawing.Point(1495, 187)
        Me.RecordDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RecordDate.Name = "RecordDate"
        Me.RecordDate.Size = New System.Drawing.Size(229, 35)
        Me.RecordDate.TabIndex = 86
        '
        'company
        '
        Me.company.AutoSize = True
        Me.company.Location = New System.Drawing.Point(654, 21)
        Me.company.Name = "company"
        Me.company.Size = New System.Drawing.Size(53, 18)
        Me.company.TabIndex = 87
        Me.company.Text = "公司1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1697, 519)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 47)
        Me.Button3.TabIndex = 88
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'record
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1766, 569)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.company)
        Me.Controls.Add(Me.RecordDate)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ct)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.val)
        Me.Controls.Add(Me.Comment)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Exp)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.datep)
        Me.Controls.Add(Me.taxNum)
        Me.Controls.Add(Me.taxId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taxcb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "record"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "发票管理系统"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents taxcb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents taxId As TextBox
    Friend WithEvents taxNum As TextBox
    Friend WithEvents datep As DateTimePicker
    Friend WithEvents confirm As Button
    Friend WithEvents Exp As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Comment As TextBox
    Friend WithEvents val As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents ct As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents clear As Button
    Friend WithEvents RecordDate As DateTimePicker
    Friend WithEvents company As Label
    Friend WithEvents Button3 As Button
End Class
