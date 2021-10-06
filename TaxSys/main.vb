Imports System.IO
Public Class main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        record.Show()
        record.company.Text = Button1.Text
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        record.Show()
        record.company.Text = Button2.Text
        Me.Hide()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.HandleCreated
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
        Dim uuids() As String = {"BA0D3A0B-0683-11EA-80DB-F875A42F7850", "36323135-3966-6536-6130-336134343533"}
        If Not uuids.Contains(UUID) Then
            MsgBox("请购买正版，谢谢")
            Application.Exit()
        End If
    End Sub

    Private Sub main_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        record.load_dic()
    End Sub
End Class