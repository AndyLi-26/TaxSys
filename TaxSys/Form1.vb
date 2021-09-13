﻿'(add reference :microsoft excel)
Imports System.IO
Imports System.Text
'Imports excel = Microsoft.Office.Interop.Excel
Public Class s
    Private Property dic = New Dictionary(Of String, tax)
    Private Property relative_s As New Dictionary(Of String, eleInfo)
    Private Sub Funcsave()
        Dim path As String = "temp"
        Dim objWriter As New StreamWriter(path, False)
        For Each kvp As KeyValuePair(Of String, tax) In dic
            Dim v1 As String = kvp.Key
            Dim v2 As tax = kvp.Value
            Dim temp As String = ""
            temp += v1 + ",,,,"
            temp += v2.num + ",,,,"
            temp += v2.value.ToString + ",,,,"
            temp += v2.datep.ToString("yyyy-MM-dd") + ",,,,"
            temp += v2.type + ",,,,"
            temp += v2.com + ",,,,"
            temp += v2.checker + ",,,,"
            temp += v2.buyer + ",,,,"
            temp += v2.prod + ",,,,"
            temp += v2.model + ",,,,"
            temp += v2.unit + ",,,,"
            temp += v2.amount.ToString + ",,,,"
            temp += v2.price.ToString + ",,,,"
            temp += v2.taxper.ToString + ",,,,"
            temp += v2.taxamount.ToString + ",,,,"
            temp += v2.total.ToString + ",,,,"
            temp += v2.seller + ",,,,"
            objWriter.WriteLine(temp)
        Next
        objWriter.Close()
        MsgBox("保存完成")
    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        'Dim temp As New tax()
        Dim temp As String = taxId.Text
        If temp = "" Then
            MsgBox("发票号码为空白")
        ElseIf IsNumeric(temp) = False Then
            MsgBox("发票号码只能含有数字")
        Else
            Dim temptaxNum As String = taxNum.Text
            If temptaxNum = "" Then
                temptaxNum = "-1"
            ElseIf IsNumeric(temptaxNum) = False Then
                MsgBox("发票代码只能含有数字")
                Return
            ElseIf CStr(CLng(temptaxNum)) <> temptaxNum Then
                MsgBox("发票代码只能含有数字")
                Return
            End If

            Dim tempChecker As String = Checker.Text
            If tempChecker = "" Then
                tempChecker = "-1"
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
                MsgBox("数量只能含有数字")
                Return
            End If

            Dim tempttb5 = TextBox5.Text
            If tempttb5 = "" Then
                tempttb5 = "-1"
            ElseIf IsNumeric(tempttb5) = False Then
                MsgBox("单价只能含有数字")
                Return
            End If

            Dim tempval = val.Text
            If tempval = "" Then
                tempval = "-1"
            ElseIf IsNumeric(tempval) = False Then
                MsgBox("金额只能含有数字")
                Return
            End If

            Dim tempttb6 = TextBox6.Text
            If tempttb6 = "" Then
                tempttb6 = "-1"
            ElseIf IsNumeric(tempttb6) = False Then
                MsgBox("税率只能含有数字")
                Return
            End If

            Dim tempttb8 = TextBox8.Text
            If tempttb8 = "" Then
                tempttb8 = "-1"
            ElseIf IsNumeric(tempttb8) = False Then
                MsgBox("税额只能含有数字")
                Return
            End If

            Dim tempttb9 = TextBox9.Text
            If tempttb9 = "" Then
                tempttb9 = "-1"
            ElseIf IsNumeric(tempttb9) = False Then
                MsgBox("加税合计只能含有数字")
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


            If dic.ContainsKey(taxId.Text) Then
                MsgBox("重复了")
            Else
                dic.Add(taxId.Text, New tax() With {
               .num = temptaxNum,
               .value = Convert.ToSingle(tempval),
               .datep = datep.Value,
               .type = taxcb.SelectedItem,
               .com = tempcom,
               .checker = tempChecker,
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
                taxNum.Text = ""
                taxId.Text = ""
                datep.Value = Date.Today
                val.Text = ""
                taxcb.SelectedIndex = 0
                Comment.Text = ""
                Checker.Text = ""
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
                Funcsave()
            End If
        End If

    End Sub

    Private Sub s_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        taxcb.SelectedIndex = 0
        Dim temp As String = "UI.txt"
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
        temp = "temp"
        If File.Exists(temp) = True Then
            Dim objReader As New StreamReader(temp)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                Dim newstr As String() = Split(TextLine, ",,,,")
                dic.Add(newstr(0), New tax() With {
           .num = newstr(1),
           .value = Convert.ToSingle(newstr(2)),
           .datep = Date.Parse(newstr(3)),
           .type = newstr(4),
           .com = newstr(5),
           .checker = newstr(6),
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
            Loop
            objReader.Close()
        Else
            Dim fs As FileStream = File.Create(temp)
            fs.Close()
        End If
    End Sub
    Private Sub s_resize(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        Funcresize()
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
        Dim path As String = "UI.txt"
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim f As String = (ComboBox1.SelectedItem)
        Dim f1 As Single = Convert.ToSingle(f)
        For Each item In Me.Controls
            If {"Label5", "Label7", "taxcb"}.Contains(item.Name) Then
                item.Font = New Font("SimSun", f1 * 2, FontStyle.Bold)
            ElseIf {"taxNum", "taxId", "datep", "Label1", "Label2", "Label3", "Checker", "Label9"}.Contains(item.Name) Then
                item.Font = New Font("SimSun", Convert.ToSingle(f1 * 1.5), FontStyle.Regular)
            Else
                item.Font = New Font("SimSun", f1, FontStyle.Regular)
            End If
        Next
    End Sub


    'Private Sub Exp_Click(sender As Object, e As EventArgs) Handles Exp.Click
    'Dim excel_app As New excel.Application
    '   excel_app.Visible = True
    'Dim workbook As excel.Workbook = excel_app.Workbooks.Add(1)
    'Dim sheet As excel.Worksheet
    'Dim counter As Integer = 2
    'sheet = workbook.Worksheets("sheet1")
    '   sheet.Cells(1, 1) = "发票代码"
    '  sheet.Cells(1, 2) = "发票号码"
    ' sheet.Cells(1, 3) = "开票日期"
    'sheet.Cells(1, 4) = "发票类型"
    'sheet.Cells(1, 5) = "备注"
    'For Each kvp As KeyValuePair(Of String, tax) In dic
    'Dim v1 As String = kvp.Key
    'Dim v2 As tax = kvp.Value
    '       sheet.Cells(counter, 1) = v1
    '      sheet.Cells(counter, 2) = v2.num
    '     sheet.Cells(counter, 3) = v2.datep.ToString("yyyy-MM-dd")
    '    sheet.Cells(counter, 4) = v2.type
    '   sheet.Cells(counter, 5) = v2.com
    '  counter += 1
    'Next
    '    workbook.SaveAs("税务发票.xlsx")
    'End Sub
End Class

Public Class tax
    Public Property id As String
    Public Property num As String
    Public Property value As Single
    Public Property datep As Date
    Public Property type As String
    Public Property com As String
    Public Property checker As String
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