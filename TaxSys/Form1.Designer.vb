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
        Me.datep = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.confirm = New System.Windows.Forms.Button()
        Me.Exp = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
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
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
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
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.save.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.save.Location = New System.Drawing.Point(1230, 857)
        Me.save.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(118, 50)
        Me.save.TabIndex = 0
        Me.save.Text = "保存"
        Me.save.UseVisualStyleBackColor = True
        '
        'taxcb
        '
        Me.taxcb.AllowDrop = True
        Me.taxcb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.taxcb.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxcb.FormattingEnabled = True
        Me.taxcb.Items.AddRange(New Object() {"增值税电子普通", "增值税电子专用"})
        Me.taxcb.Location = New System.Drawing.Point(765, 78)
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
        Me.Label1.Location = New System.Drawing.Point(1355, 57)
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
        Me.Label2.Location = New System.Drawing.Point(1355, 102)
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
        Me.Label3.Location = New System.Drawing.Point(1355, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "开票日期:"
        '
        'taxNum
        '
        Me.taxNum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.taxNum.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.taxNum.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxNum.Location = New System.Drawing.Point(1507, 47)
        Me.taxNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxNum.Name = "taxNum"
        Me.taxNum.Size = New System.Drawing.Size(229, 35)
        Me.taxNum.TabIndex = 6
        '
        'taxId
        '
        Me.taxId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.taxId.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.taxId.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.taxId.Location = New System.Drawing.Point(1507, 93)
        Me.taxId.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.taxId.Name = "taxId"
        Me.taxId.Size = New System.Drawing.Size(229, 35)
        Me.taxId.TabIndex = 7
        '
        'datep
        '
        Me.datep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.datep.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.datep.Location = New System.Drawing.Point(1507, 134)
        Me.datep.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.datep.Name = "datep"
        Me.datep.Size = New System.Drawing.Size(229, 35)
        Me.datep.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("DengXian", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Olive
        Me.Label5.Location = New System.Drawing.Point(669, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 37)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "上海"
        '
        'confirm
        '
        Me.confirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.confirm.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.confirm.Location = New System.Drawing.Point(1441, 857)
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
        Me.Exp.Location = New System.Drawing.Point(1640, 857)
        Me.Exp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Exp.Name = "Exp"
        Me.Exp.Size = New System.Drawing.Size(118, 50)
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
        Me.Label7.Location = New System.Drawing.Point(1041, 78)
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
        Me.Label9.Location = New System.Drawing.Point(1355, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 30)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "校验码:"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox7.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1507, 180)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(229, 35)
        Me.TextBox7.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Olive
        Me.Label4.Location = New System.Drawing.Point(723, 458)
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
        Me.Label12.Location = New System.Drawing.Point(389, 458)
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
        Me.Label11.Location = New System.Drawing.Point(925, 458)
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
        Me.Label15.Location = New System.Drawing.Point(573, 458)
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
        Me.Label13.Location = New System.Drawing.Point(50, 458)
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
        Me.Label17.Location = New System.Drawing.Point(38, 314)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 90)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "购" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "买" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "方"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(26, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1723, 181)
        Me.Label6.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(520, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 120)
        Me.Label8.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(26, 645)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1723, 175)
        Me.Label10.TabIndex = 41
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(26, 569)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(1723, 77)
        Me.Label18.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Location = New System.Drawing.Point(26, 450)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(1723, 120)
        Me.Label19.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(827, 450)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(243, 120)
        Me.Label20.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label21.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(1391, 450)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(124, 120)
        Me.Label21.TabIndex = 45
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label22.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Olive
        Me.Label22.Location = New System.Drawing.Point(1615, 458)
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
        Me.Label23.Location = New System.Drawing.Point(1218, 458)
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
        Me.Label24.Location = New System.Drawing.Point(1429, 458)
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
        Me.Label25.Location = New System.Drawing.Point(26, 449)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(303, 121)
        Me.Label25.TabIndex = 49
        '
        'Comment
        '
        Me.Comment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Comment.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Comment.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Comment.Location = New System.Drawing.Point(1191, 645)
        Me.Comment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Comment.Multiline = True
        Me.Comment.Name = "Comment"
        Me.Comment.Size = New System.Drawing.Size(558, 175)
        Me.Comment.TabIndex = 50
        '
        'val
        '
        Me.val.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.val.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.val.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.val.Location = New System.Drawing.Point(1069, 483)
        Me.val.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.val.Multiline = True
        Me.val.Name = "val"
        Me.val.Size = New System.Drawing.Size(323, 87)
        Me.val.TabIndex = 51
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Olive
        Me.Label26.Location = New System.Drawing.Point(128, 591)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(106, 24)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "加税合计"
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label28.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(86, 645)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(1044, 175)
        Me.Label28.TabIndex = 54
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label29.Location = New System.Drawing.Point(38, 681)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(26, 90)
        Me.Label29.TabIndex = 55
        Me.Label29.Text = "购" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "买" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "方"
        '
        'Label31
        '
        Me.Label31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label31.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Olive
        Me.Label31.Location = New System.Drawing.Point(1148, 681)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(26, 108)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "备" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "注"
        '
        'Label32
        '
        Me.Label32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label32.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Olive
        Me.Label32.Location = New System.Drawing.Point(118, 407)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(116, 18)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "开户行及账号"
        '
        'Label33
        '
        Me.Label33.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label33.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Olive
        Me.Label33.Location = New System.Drawing.Point(118, 366)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 18)
        Me.Label33.TabIndex = 59
        Me.Label33.Text = "地址电话"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label34.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Olive
        Me.Label34.Location = New System.Drawing.Point(118, 323)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(116, 18)
        Me.Label34.TabIndex = 60
        Me.Label34.Text = "纳税人识别号"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label35.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Olive
        Me.Label35.Location = New System.Drawing.Point(118, 282)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(44, 18)
        Me.Label35.TabIndex = 61
        Me.Label35.Text = "名称"
        '
        'Label36
        '
        Me.Label36.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label36.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Olive
        Me.Label36.Location = New System.Drawing.Point(118, 658)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(44, 18)
        Me.Label36.TabIndex = 65
        Me.Label36.Text = "名称"
        '
        'Label37
        '
        Me.Label37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label37.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Olive
        Me.Label37.Location = New System.Drawing.Point(118, 701)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(116, 18)
        Me.Label37.TabIndex = 64
        Me.Label37.Text = "纳税人识别号"
        '
        'Label38
        '
        Me.Label38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label38.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Olive
        Me.Label38.Location = New System.Drawing.Point(118, 744)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 18)
        Me.Label38.TabIndex = 63
        Me.Label38.Text = "地址电话"
        '
        'Label39
        '
        Me.Label39.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label39.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Olive
        Me.Label39.Location = New System.Drawing.Point(118, 787)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(116, 18)
        Me.Label39.TabIndex = 62
        Me.Label39.Text = "开户行及账号"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox1.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(26, 483)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 87)
        Me.TextBox1.TabIndex = 66
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox2.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(328, 483)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 87)
        Me.TextBox2.TabIndex = 67
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox3.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(520, 483)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(149, 87)
        Me.TextBox3.TabIndex = 68
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox4.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(668, 483)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(160, 87)
        Me.TextBox4.TabIndex = 69
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox5.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(827, 483)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 87)
        Me.TextBox5.TabIndex = 70
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox6.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1391, 483)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(124, 87)
        Me.TextBox6.TabIndex = 71
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox8.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1514, 483)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(235, 87)
        Me.TextBox8.TabIndex = 72
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox9.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox9.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(328, 569)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(1421, 77)
        Me.TextBox9.TabIndex = 73
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox10.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(262, 270)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(868, 181)
        Me.TextBox10.TabIndex = 74
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TextBox11.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(262, 645)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(868, 175)
        Me.TextBox11.TabIndex = 75
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label30.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label30.Location = New System.Drawing.Point(86, 270)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(1044, 181)
        Me.Label30.TabIndex = 56
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 62)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        's
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1924, 926)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
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
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Exp)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.datep)
        Me.Controls.Add(Me.taxId)
        Me.Controls.Add(Me.taxNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.taxcb)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "s"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
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
    Friend WithEvents datep As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents confirm As Button
    Friend WithEvents Exp As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox7 As TextBox
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
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
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
    Friend WithEvents Label30 As Label
    Friend WithEvents Button1 As Button
End Class
