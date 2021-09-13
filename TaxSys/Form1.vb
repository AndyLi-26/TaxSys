'(add reference :microsoft excel)
Imports System.IO
Imports System.Text
'Imports excel = Microsoft.Office.Interop.Excel
Public Class s
    Private Property dic = New Dictionary(Of String, tax)
    Private Property relative_s As New Dictionary(Of String, eleInfo)
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim path As String = "temp"
        Dim fs As FileStream = File.Create(path)
        fs.Close()
        Dim objWriter As New StreamWriter(path, False)
        For Each kvp As KeyValuePair(Of String, tax) In dic
            Dim v1 As String = kvp.Key
            Dim v2 As tax = kvp.Value
            Dim temp As String = ""
            temp += v1 + ",,,,"
            temp += v2.num + ",,,,"
            temp += v2.value.ToString + ",,,,"
            temp += v2.type.ToString + ",,,,"
            temp += v2.datep.ToString("yyyy-MM-dd") + ",,,,"
            temp += v2.com
            objWriter.WriteLine(temp)
        Next
        objWriter.Close()
        MsgBox("保存完成")
    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        'Dim temp As New tax()
        Dim s1, s2, s4, s5 As String
        Dim s3 As Date
        Dim ttype As String
        s1 = taxId.Text
        s2 = taxNum.Text
        s3 = datep.Value
        s4 = val.Text
        s5 = Comment.Text
        ttype = taxcb.SelectedItem
        If dic.ContainsKey(s1) Then
            MsgBox("重复了")
        Else
            dic.Add(s1, New tax() With {
           .num = s2,
           .value = s4,
           .datep = s3,
           .type = ttype,
           .com = s5})
            MsgBox("已录入")
        End If
        taxNum.Text = ""
        taxId.Text = ""
        datep.Value = Date.Today
        val.Text = ""
        taxcb.SelectedIndex = 0
        Comment.Text = ""
    End Sub

    Private Sub s_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            MsgBox("UI文件丢失，界面可能出错")
        End If
        temp = "temp"
        If File.Exists(temp) = True Then
            Dim objReader As New StreamReader(temp)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                Dim newstr As String() = Split(TextLine, ",,,,")
                'Dim newstr As String() = TextLine.Split(New String() {",,,,"})
                Dim s1 As String = newstr(0)
                Dim s2 As String = newstr(1)

                Dim s3 As Integer = CInt(newstr(2))
                Dim s4 As Date = Date.Parse(newstr(4))
                Dim s5 As String = newstr(3)
                Dim s6 As String = newstr(5)
                dic.Add(s1, New tax() With {
           .num = s2,
           .value = s3,
           .datep = s4,
           .type = s5,
           .com = s6})
            Loop
            objReader.Close()
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
            ElseIf {}.Contains(item.Name) Then
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
    Public Property value As Integer
    Public Property datep As Date
    Public Property type As String
    Public Property buyer_name As String
    Public Property com As String
End Class

Public Class eleInfo
    Public Property x As Single
    Public Property y As Single
    Public Property w As Single
    Public Property h As Single

End Class