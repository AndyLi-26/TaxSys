'(add reference :microsoft excel)
Imports System.IO
Imports System.Text
Imports excel = Microsoft.Office.Interop.Excel
Public Class s
    Private Property dic = New Dictionary(Of String, tax)
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim path As String = "temp"
        Dim fs As FileStream = File.Create(path)
        fs.Close()
        Dim objWriter As New StreamWriter(path, False)
        'Dim temp As New StreamReader(My.Computer.FileSystem.OpenTextFileReader)
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
        Dim ttype As Integer
        s1 = taxId.Text
        s2 = taxNum.Text
        s3 = datep.Value
        s4 = val.Text
        s5 = Comment.Text
        ttype = taxcb.SelectedIndex
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
        taxId.Text = ""
        taxNum.Text = ""
        datep.Value = Date.Today
        val.Text = ""
        taxcb.SelectedIndex = 0
        Comment.Text = ""
    End Sub

    Private Sub s_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim temp As String = "temp"
        Dim TextLine As String
        If File.Exists(temp) = True Then
            Dim objReader As New StreamReader(temp)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                Dim newstr As String() = Split(TextLine, ",,,,")
                'Dim newstr As String() = TextLine.Split(New String() {",,,,"})
                Dim s1 As String = newstr(0)
                MsgBox(newstr(0))
                Dim s2 As String = newstr(1)

                Dim s3 As Integer = CInt(newstr(2))
                Dim s4 As Date = Date.Parse(newstr(4))
                Dim s5 As Integer = CInt(newstr(3))
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

    Private Sub Exp_Click(sender As Object, e As EventArgs) Handles Exp.Click
        Dim excel_app As New excel.Application
        excel_app.Visible = True
        Dim workbook As excel.Workbook = excel_app.Workbooks.Open("税务发票.xlsx")
        Dim sheet As excel.Worksheet
        sheet = workbook.Worksheets("sheet1")
        sheet.Cells(1, 1) = "发票代码"
        sheet.Cells(1, 2) = "发票号码"
        sheet.Cells(1, 3) = "开票日期"
        sheet.Cells(1, 4) = "发票类型"
        sheet.Cells(1, 5) = "备注"
        For Each kvp As KeyValuePair(Of String, tax) In dic
            Dim v1 As String = kvp.Key
            Dim v2 As tax = kvp.Value
            sheet.Cells(2, 1) = v1
            temp += v2.num + ",,,,"
            temp += v2.value.ToString + ",,,,"
            temp += v2.type.ToString + ",,,,"
            temp += v2.datep.ToString("yyyy-MM-dd") + ",,,,"
            temp += v2.com
            objWriter.WriteLine(temp)
        Next
    End Sub
End Class

Public Class tax
    Public Property id As String
    Public Property num As String
    Public Property value As Integer
    Public Property datep As Date
    Public Property type As Integer
    Public Property buyer_name As String
    Public Property com As String
End Class
