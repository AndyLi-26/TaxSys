'(add reference :microsoft excel)
Imports System.Diagnostics
Imports System.IO
Imports System.Text
Imports excel = Microsoft.Office.Interop.Excel
Imports System.EventArgs
Imports System.Management
Public Class record
    Public Property dic = New Dictionary(Of String, tax)
    Private Property relative_s As New Dictionary(Of String, eleInfo)
    Private Property sellerAuto As New AutoCompleteStringCollection
    Private Property buyerAuto As New AutoCompleteStringCollection
    Private Property ctAuto As New AutoCompleteStringCollection
    Private Property def As String = "上海"
    Private Property trig As Boolean
    Private Property font_s As Integer

    'Changefocus can enter the next cell on press Enter
    Private Sub Changefocus(e As KeyEventArgs, destination As Object)
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            e.SuppressKeyPress = True
            'MsgBox("a")
            destination.Focus()
        End If
    End Sub
    Private Sub change_F1(sender As Object, e As KeyEventArgs) Handles taxId.KeyDown
        Call Changefocus(e, taxNum)
    End Sub
    Private Sub change_F2(sender As Object, e As KeyEventArgs) Handles taxNum.KeyDown
        Call Changefocus(e, datep)
    End Sub
    Private Sub change_F3(sender As Object, e As KeyEventArgs) Handles datep.KeyDown
        Call Changefocus(e, TextBox10)
    End Sub
    Private Sub change_F5(sender As Object, e As KeyEventArgs) Handles TextBox10.KeyDown
        Call Changefocus(e, TextBox1)
    End Sub
    Private Sub change_F6(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Call Changefocus(e, TextBox2)
    End Sub
    Private Sub change_F7(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Call Changefocus(e, TextBox3)
    End Sub
    Private Sub change_F8(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        Call Changefocus(e, TextBox4)
    End Sub
    Private Sub change_F9(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        Call Changefocus(e, TextBox5)
    End Sub
    Private Sub change_F10(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        Call Changefocus(e, val)
    End Sub
    Private Sub change_F11(sender As Object, e As KeyEventArgs) Handles val.KeyDown
        Call Changefocus(e, TextBox6)
    End Sub
    Private Sub change_F12(sender As Object, e As KeyEventArgs) Handles TextBox6.KeyDown
        Call Changefocus(e, TextBox8)
    End Sub
    Private Sub change_F13(sender As Object, e As KeyEventArgs) Handles TextBox8.KeyDown
        Call Changefocus(e, TextBox9)
    End Sub
    Private Sub change_F14(sender As Object, e As KeyEventArgs) Handles TextBox9.KeyDown
        Call Changefocus(e, TextBox11)
    End Sub
    Private Sub change_F15(sender As Object, e As KeyEventArgs) Handles TextBox11.KeyDown
        Call Changefocus(e, Comment)
    End Sub
    Private Sub change_F16(sender As Object, e As KeyEventArgs) Handles Comment.KeyDown
        Call Changefocus(e, confirm)
    End Sub

    'showErr shows different error messages
    Private Sub showErr(errMsg As String)
        Display.Show()
        Display.Label1.Text = errMsg
        Display.Label1.Location = New Point(Int(Display.Size.Width - Display.Label1.Width) / 2, Display.Label1.Location.Y)
        Display.Focus()
    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Display.Close()
        Dim id As String = taxId.Text
        If id = "" Then
            Call showErr("发票代码为空白")
            Return
        Else
            Dim temptaxNum As String = taxNum.Text
            If temptaxNum = "" Then
                Call showErr("发票号码为空白")
                Return
            End If

            Dim tempttb10 = TextBox10.Text
            If tempttb10 = "" Then
                tempttb10 = "-1"
            End If

            Dim tempttb1 = TextBox1.Text
            If tempttb1 = "" Then
                tempttb1 = "-1"
            End If

            Dim tempttb2 = TextBox2.Text
            If tempttb2 = "" Then
                tempttb2 = "-1"
            End If

            Dim tempttb3 = TextBox3.Text
            If tempttb3 = "" Then
                tempttb3 = "-1"
            End If

            Dim tempttb4 = TextBox4.Text
            If tempttb4 = "" Then
                tempttb4 = "-1"
            ElseIf IsNumeric(tempttb4) = False Then
                Call showErr("数量只能含有数字")
                Return
            End If

            Dim tempttb5 = TextBox5.Text
            If tempttb5 = "" Then
                tempttb5 = "-1"
            ElseIf IsNumeric(tempttb5) = False Then
                Call showErr("单价只能含有数字")
                Return
            End If

            Dim tempval = val.Text
            If tempval = "" Then
                tempval = "-1"
            ElseIf IsNumeric(tempval) = False Then
                Call showErr("金额只能含有数字")
                Return
            End If

            Dim tempttb6 = TextBox6.Text
            If tempttb6 = "" Then
                tempttb6 = "-1"
            ElseIf IsNumeric(tempttb6) = False Then
                Call showErr("税率只能含有数字")
                Return
            End If

            Dim tempttb8 = TextBox8.Text
            If tempttb8 = "" Then
                tempttb8 = "-1"
            ElseIf IsNumeric(tempttb8) = False Then
                Call showErr("税额只能含有数字")
                Return
            End If

            Dim tempttb9 = TextBox9.Text
            If tempttb9 = "" Then
                tempttb9 = "-1"
            ElseIf IsNumeric(tempttb9) = False Then
                Call showErr("加税合计只能含有数字")
                Return
            End If

            Dim tempttb11 = TextBox11.Text
            If tempttb11 = "" Then
                tempttb11 = "-1"
            End If


            Dim tempcom = Comment.Text
            If tempcom = "" Then
                tempcom = "-1"
            End If

            If dic.ContainsKey(id) Then
                Call showErr("发票代码重复")
            Else
                dic.Add(id, New tax() With {
               .num = temptaxNum,
               .value = Convert.ToSingle(tempval),
               .datep = datep.Value,
               .type = ct.Text + If(taxcb.SelectedItem, "增值税电子普通"),
               .com = tempcom,
               .rec = RecordDate.Value,
               .buyer = tempttb10,
               .prod = tempttb1,
               .model = tempttb2,
               .unit = tempttb3,
               .amount = Convert.ToSingle(tempttb4),
               .price = Convert.ToSingle(tempttb5),
               .taxper = Convert.ToSingle(tempttb6),
               .taxamount = Convert.ToSingle(tempttb8),
               .total = Convert.ToSingle(tempttb9),
               .seller = tempttb11
               })
                If tempttb10 <> "-1" Then
                    buyerAuto.Add(tempttb10)
                End If
                If tempttb11 <> "-1" Then
                    sellerAuto.Add(tempttb11)
                End If
                taxId.Text = ""
                taxNum.Text = ""
                datep.Value = Date.Today
                val.Text = ""
                taxcb.SelectedIndex = 0
                Comment.Text = ""
                RecordDate.Value = Date.Today
                TextBox10.Text = ""
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox11.Text = ""
                'Dim objWriter As New StreamWriter("temp", True)
                Dim v1 As String = id
                Dim v2 As tax = dic(id)
                Dim temp As String = ""
                temp += v1 + ",,,,"
                temp += v2.num + ",,,,"
                temp += v2.value.ToString + ",,,,"
                temp += v2.datep.ToString("yyyy-MM-dd") + ",,,,"
                temp += v2.type + ",,,,"
                temp += v2.com + ",,,,"
                temp += v2.rec.ToString("yyyy-MM-dd") + ",,,,"
                temp += v2.buyer + ",,,,"
                temp += v2.prod + ",,,,"
                temp += v2.model + ",,,,"
                temp += v2.unit + ",,,,"
                temp += v2.amount.ToString + ",,,,"
                temp += v2.price.ToString + ",,,,"
                temp += v2.taxper.ToString + ",,,,"
                temp += v2.taxamount.ToString + ",,,,"
                temp += v2.total.ToString + ",,,,"
                temp += v2.seller + vbNewLine
                'objWriter.WriteLine(temp)
                'objWriter.Close()
                File.AppendAllText("temp", temp)
                MsgBox("保存完成")
            End If
            Display.Focus()
        End If

    End Sub

    Private Sub Check_valid(sender As Object, e As EventArgs) Handles MyBase.HandleCreated
        'Dim searcher As New ManagementObjectSearcher(
        '        "root\CIMV2",
        '        "SELECT * FROM Win32_ComputerSystemProduct")
        'For Each queryObj As ManagementObject In searcher.Get()
        '    Console.WriteLine("UUID: {0}", queryObj("UUID"))
        'Next
        'Process.Start("cmd", "/c wmic csproduct get uuid")
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("cmd", "/c wmic csproduct get uuid")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim UUID As String
        Using oStreamReader As StreamReader = oProcess.StandardOutput
            oStreamReader.ReadLine()
            oStreamReader.ReadLine()
            UUID = oStreamReader.ReadLine().Substring(0, 36)
        End Using
        'MsgBox("BA0D3A0B-0683-11EA-80DB-F875A42F7850".Length)
        If UUID <> "36323135-3966-6536-6130-336134343533" Then
            MsgBox("请购买正版，谢谢")
            Application.Exit()
        End If
    End Sub

    Public Sub load_dic()
        Dim temp As String = "temp"
        Dim TextLine As String
        If File.Exists(temp) = True Then
            Dim objReader As New StreamReader(temp)
            Dim counter As Integer = 0
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                If counter = 0 Then
                    trig = False
                    ComboBox1.SelectedItem = TextLine
                    trig = True
                    counter = 1
                    Continue Do
                End If
                Dim newstr As String() = Split(TextLine, ",,,,")
                If newstr(6) <> "-1" Then
                    buyerAuto.Add(newstr(6))
                End If
                If newstr(15) <> "-1" Then
                    sellerAuto.Add(newstr(15))
                End If
                dic.Add(newstr(0), New tax() With {
           .num = newstr(1),
           .value = Convert.ToSingle(newstr(2)),
           .datep = Date.Parse(newstr(3)),
           .type = newstr(4),
           .com = newstr(5),
           .rec = Date.Parse(newstr(6)),
           .buyer = newstr(7),
           .prod = newstr(8),
           .model = newstr(9),
           .unit = newstr(10),
           .amount = Convert.ToSingle(newstr(11)),
           .price = Convert.ToSingle(newstr(12)),
           .taxper = Convert.ToSingle(newstr(13)),
           .taxamount = Convert.ToSingle(newstr(14)),
           .total = Convert.ToSingle(newstr(15)),
           .seller = newstr(16)})
                'MsgBox(newstr(4))
                'MsgBox(newstr(4).IndexOf("增"))
                If newstr(4).Contains("增值税") Then
                    temp = newstr(4).IndexOf("增")
                Else
                    temp = newstr(4).IndexOf("其他")
                End If
                ct.Text = newstr(4).Substring(0, temp)
            Loop
            objReader.Close()
        Else
            trig = True
            Dim fs As FileStream = File.Create("temp")
            fs.Close()
            File.WriteAllLines("temp", {"9"})
            ComboBox1.SelectedItem = "9"
        End If
    End Sub

    Public Sub s_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox10.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox10.AutoCompleteCustomSource = buyerAuto
        TextBox10.AutoCompleteMode = AutoCompleteMode.Suggest
        TextBox11.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox11.AutoCompleteCustomSource = sellerAuto
        TextBox11.AutoCompleteMode = AutoCompleteMode.Suggest
        ct.AutoCompleteSource = AutoCompleteSource.CustomSource
        ct.AutoCompleteCustomSource = ctAuto
        ct.AutoCompleteMode = AutoCompleteMode.Suggest

        taxcb.SelectedIndex = 0
        Dim temp As String = "UI"
        Dim TextLine As String
        If File.Exists(temp) = True Then
            Dim objReader As New StreamReader(temp)
            Dim x, y As Integer
            x = Me.Width
            y = Me.Height
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                Dim newstr As String() = Split(TextLine, ",")
                Dim name As String = newstr(0)
                relative_s.Add(name, New eleInfo With {
                .x = Convert.ToSingle(newstr(1)),
                .y = Convert.ToSingle(newstr(2)),
                .w = Convert.ToSingle(newstr(3)),
                .h = Convert.ToSingle(newstr(4))
                })
            Loop
            objReader.Close()
            Funcresize()
        Else
            Dim x, y As Integer
            x = Me.Width
            y = Me.Height
            For Each item In Me.Controls
                relative_s.Add(item.Name, New eleInfo With {
                .x = item.Location.X / x,
                .y = item.Location.Y / y,
                .w = item.Size.Width / x,
                .h = item.Size.Height / y
                })
            Next
            MsgBox("UI文件丢失，界面可能出错")
        End If
        load_dic()
        taxId.Focus()
        'MsgBox(dic.Count)
    End Sub

    Private Sub s_resize(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Funcresize()
    End Sub

    Private Sub s_fouse(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        taxId.Focus()
    End Sub

    Private Sub Funcresize()
        Dim x, y As Integer
        x = Me.Width
        y = Me.Height
        For Each item In Me.Controls
            If relative_s.ContainsKey(item.Name) = False Then
                Continue For
            End If
            item.Location = New Point(Int(relative_s(item.Name).x * x), Int(relative_s(item.Name).y * y))
            'item.Size = New()
            item.Height = Int(relative_s(item.Name).h * y)
            item.Width = Int(relative_s(item.Name).w * x)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = "UI"
        Dim fs As FileStream = File.Create(path)
        fs.Close()
        Dim objWriter As New StreamWriter(path, False)
        For Each kvp As KeyValuePair(Of String, eleInfo) In relative_s
            Dim v1 As String = kvp.Key
            Dim v2 As eleInfo = kvp.Value
            Dim temp As String = ""
            temp += v1 + ","
            temp += v2.x.ToString + ","
            temp += v2.y.ToString + ","
            temp += v2.w.ToString + ","
            temp += v2.h.ToString + ","
            objWriter.WriteLine(temp)
        Next
        objWriter.Close()
        MsgBox("保存完成")
    End Sub

    'ComboBox1=字体大小
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim f As String = (ComboBox1.SelectedItem)
        Dim f1 As Single = Convert.ToSingle(f)
        For Each item In Me.Controls
            If {"ct", "Label7", "taxcb"}.Contains(item.Name) Then
                item.Font = New Font("SimSun", f1 * 2, FontStyle.Bold)
            ElseIf {"taxNum", "taxId", "datep", "Label1", "Label2", "Label3", "Checker", "Label9", "Label16", "ComboBox11"}.Contains(item.Name) Then
                item.Font = New Font("SimSun", Convert.ToSingle(f1 * 1.5), FontStyle.Regular)
            Else
                item.Font = New Font("SimSun", f1, FontStyle.Regular)
            End If
        Next
        If trig Then
            Dim lines() As String = File.ReadAllLines("temp")
            lines(0) = f
            File.WriteAllLines("temp", lines)
        End If
    End Sub

    Private Sub Fuck(currentDic As Dictionary(Of String, tax))
        Dim excel_app As New excel.Application
        excel_app.Visible = True
        Dim workbook As excel.Workbook = excel_app.Workbooks.Add(1)
        Dim sheet As excel.Worksheet
        Dim counter As Integer = 2
        sheet = workbook.Worksheets("sheet1")
        sheet.Cells(1, 1) = "发票代码"
        sheet.Cells(1, 2) = "发票类型"
        sheet.Cells(1, 3) = "发票号码"
        sheet.Cells(1, 4) = "开票日期"
        sheet.Cells(1, 5) = "录入日期"
        sheet.Cells(1, 6) = "购买方"
        sheet.Cells(1, 7) = "货物或应税劳务、服务名称"
        sheet.Cells(1, 8) = "规格型号"
        sheet.Cells(1, 9) = "单位"
        sheet.Cells(1, 10) = "数量"
        sheet.Cells(1, 11) = "单价"
        sheet.Cells(1, 12) = "金额"
        sheet.Cells(1, 13) = "税率"
        sheet.Cells(1, 14) = "税额"
        sheet.Cells(1, 15) = "加税合计"
        sheet.Cells(1, 16) = "销售方"
        sheet.Cells(1, 17) = "备注"

        For Each kvp As KeyValuePair(Of String, tax) In currentDic
            Dim v1 As String = kvp.Key
            Dim v2 As tax = kvp.Value
            sheet.Cells(counter, 1) = v1
            sheet.Cells(counter, 3) = v2.num
            sheet.Cells(counter, 2) = If(v2.type = "-1", "", v2.type)
            sheet.Cells(counter, 4) = v2.datep.ToString("yyyy-MM-dd")
            sheet.Cells(counter, 5) = v2.rec.ToString("yyyy-MM-dd")
            sheet.Cells(counter, 6) = If(v2.buyer = "-1", "", v2.buyer)
            sheet.Cells(counter, 7) = If(v2.prod = "-1", "", v2.prod)
            sheet.Cells(counter, 8) = If(v2.model = "-1", "", v2.model)
            sheet.Cells(counter, 9) = If(v2.unit = "-1", "", v2.unit)
            sheet.Cells(counter, 10) = If(v2.amount.ToString() = "-1", "", v2.amount.ToString())
            sheet.Cells(counter, 11) = If(v2.price.ToString() = "-1", "", v2.price.ToString())
            sheet.Cells(counter, 12) = If(v2.value.ToString() = "-1", "", v2.value.ToString())
            sheet.Cells(counter, 13) = If(v2.taxper.ToString() = "-1", "", v2.taxper.ToString())
            sheet.Cells(counter, 14) = If(v2.taxamount.ToString() = "-1", "", v2.taxamount.ToString())
            sheet.Cells(counter, 15) = If(v2.total.ToString() = "-1", "", v2.total.ToString())
            sheet.Cells(counter, 16) = If(v2.seller = "-1", "", v2.seller)
            sheet.Cells(counter, 17) = If(v2.com = "-1", "", v2.com)
            counter += 1
        Next
    End Sub

    Private Sub Exp_Click(sender As Object, e As EventArgs) Handles Exp.Click
        Call Fuck(dic)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
        If TextBox6.Text = "" Then
            Return
        End If
        If IsNumeric(TextBox6.Text) = False Then
            Call showErr("税率只能含有数字")
            Return
        End If
        TextBox6.Text = Math.Round(Convert.ToDouble(TextBox6.Text), 4).ToString()
        'TextBox6.Text = TextBox6.Text.Replace("%", "") + "%"
        If TextBox9.Text <> "" Then
            calc()
        End If
    End Sub

    Private Sub taxId_TextChanged(sender As Object, e As EventArgs) Handles taxNum.LostFocus
        If taxNum.Text = "" Then
            Return
        End If
        If IsNumeric(taxNum.Text) = False Then
            Call showErr("发票号码只能含有数字")
        End If
    End Sub

    Private Sub taxNum_TextChanged(sender As Object, e As EventArgs) Handles taxId.LostFocus
        If taxId.Text = "" Then
            Return
        End If
        If IsNumeric(taxId.Text) = False Then
            Call showErr("发票代码只能含有数字")
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        If TextBox9.Text = "" Then
            Return
        End If
        If IsNumeric(TextBox9.Text) = False Then
            Call showErr("加税合计只能含有数字")
            Return
        End If
        TextBox9.Text = Math.Round(Convert.ToDouble(TextBox9.Text), 2).ToString()
        If TextBox6.Text <> "" Then
            calc()
        End If
    End Sub

    Private Sub calc()
        Dim tot As Single = Convert.ToSingle(TextBox9.Text)
        Dim taxper As Single = Convert.ToSingle(TextBox6.Text) / 100
        Dim v As Single = Math.Round((tot / (1 + taxper)), 4)
        val.Text = v.ToString()
        TextBox8.Text = Math.Round((v * taxper), 4).ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim temp_dic As New Dictionary(Of String, tax)
        If taxId.Text <> "" Then
            If dic.ContainsKey(taxId.Text) Then
                If taxNum.Text <> "" AndAlso dic(taxId.Text).num <> taxNum.Text Then
                    Call showErr("根据发票号码" + vbNewLine + "记录中无此发票")
                Else
                    temp_dic.Add(taxId.Text, dic(taxId.Text))
                End If
            End If
        ElseIf taxNum.Text <> "" Then
            For Each kvp As KeyValuePair(Of String, tax) In dic
                If kvp.Value.num = taxNum.Text Then
                    temp_dic.Add(kvp.Key, kvp.Value)
                End If
            Next
            If temp_dic.Count = 0 Then
                Call showErr("根据发票代码" + vbNewLine + "记录中无此发票")
                Return
            End If
        ElseIf TextBox11.Text <> "" Then
            For Each kvp As KeyValuePair(Of String, tax) In dic
                If kvp.Value.seller.Contains(TextBox11.Text) Or TextBox11.Text.Contains(kvp.Value.seller) Then
                    temp_dic.Add(kvp.Key, kvp.Value)
                End If
            Next
            If temp_dic.Count = 0 Then
                Call showErr("根据销售方" + vbNewLine + "记录中无此发票")
                Return
            End If
        Else
            For Each kvp As KeyValuePair(Of String, tax) In dic
                If kvp.Value.datep.ToString("yyyy-MM-dd") = datep.Value.ToString("yyyy-MM-dd") Then
                    temp_dic.Add(kvp.Key, kvp.Value)
                End If
            Next
            If temp_dic.Count = 0 Then
                Call showErr("根据日期" + vbNewLine + "记录中无此发票")
                Return
            End If
        End If

        Call Fuck(temp_dic)

        temp_dic = New Dictionary(Of String, tax)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles clear.Click
        taxId.Text = ""
        taxNum.Text = ""
        datep.Value = Date.Today
        val.Text = ""
        taxcb.SelectedIndex = 0
        Comment.Text = ""
        RecordDate.Value = Date.Today
        TextBox10.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox11.Text = ""
    End Sub

End Class

Public Class tax
    Public Property id As String
    Public Property num As String
    Public Property value As Single
    Public Property datep As Date
    Public Property type As String
    Public Property com As String
    Public Property rec As Date
    Public Property buyer As String
    Public Property prod As String
    Public Property model As String
    Public Property unit As String
    Public Property amount As Single
    Public Property price As Single
    Public Property taxper As Single
    Public Property taxamount As Single
    Public Property total As Single
    Public Property seller As String
End Class

Public Class eleInfo
    Public Property x As Single
    Public Property y As Single
    Public Property w As Single
    Public Property h As Single

End Class