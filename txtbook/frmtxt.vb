Imports System.IO
Public Class frmtxt
    Public s As Integer = 1
    Public r As Integer = 0
    Dim fn As String
    Dim temp As Integer
    Private Sub frmtxt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtbox.Height = Me.ClientSize.Height - mnu.Height
        txtbox.Width = Me.ClientSize.Width
        temp = 1
    End Sub

    Private Sub frmtxt_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        txtbox.Height = Me.ClientSize.Height - mnu.Height
        txtbox.Width = Me.ClientSize.Width

    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        End
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        Dim line As String, sr As StreamReader
        OFD.FileName = ""
        OFD.InitialDirectory = "D:\"
        OFD.Filter = "所有文本(*.txt)|*.txt"
        If OFD.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        txtbox.Text = ""
        fn = OFD.FileName
        sr = New StreamReader(fn)
        Do While sr.Peek() <> -1
            line = sr.ReadLine()
            txtbox.Text = txtbox.Text & line & vbCrLf
        Loop
        sr.Close()
    End Sub

    Private Sub mnuSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        If fn = "" Then
            Dim sr As StreamWriter
            SFD.FileName = ""
            SFD.InitialDirectory = "D:\"
            SFD.Filter = "所有文本(*.txt)|*.txt"
            If SFD.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
            fn = SFD.FileName
            sr = New StreamWriter(fn)
            Dim i As Integer
            For i = 0 To txtbox.Lines.Length() - 1
                sr.WriteLine(txtbox.Lines(i))
            Next i
            sr.Close()
            Exit Sub
        End If
        Dim j As Integer
        Dim sw As StreamWriter
        sw = New StreamWriter(fn)
        For j = 0 To txtbox.Lines.Length() - 1
            sw.WriteLine(txtbox.Lines(j))
        Next j
        sw.Close()
    End Sub

    Private Sub mnuAS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAS.Click
        Dim sr As StreamWriter
        SFD.FileName = ""
        SFD.InitialDirectory = "D:\"
        SFD.Filter = "所有文本(*.txt)|*.txt"
        If SFD.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        fn = SFD.FileName
        sr = New StreamWriter(fn)
        Dim i As Integer
        For i = 0 To txtbox.Lines.Length() - 1
            sr.WriteLine(txtbox.Lines(i))
        Next i
        sr.Close()
    End Sub

    Private Sub mnuNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        txtbox.Text = ""
        fn = ""
    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        txtbox.Cut()
    End Sub

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        txtbox.Copy()
    End Sub

    Private Sub mnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaste.Click
        txtbox.Paste()
    End Sub

    Private Sub mnuAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAll.Click
        txtbox.SelectAll()
    End Sub

    Private Sub mnuDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDate.Click
        txtbox.Text = txtbox.Text & Now()
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        txtbox.SelectedText = ""
    End Sub

    Private Sub mnuW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuW.Click
        If temp = 1 Then
            temp = 0
            mnuW.Checked = False
            txtbox.WordWrap = False
        Else
            temp = 1
            mnuW.Checked = True
            txtbox.WordWrap = True
        End If
    End Sub

    Private Sub mnuFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFont.Click
        If FD.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtbox.Font = FD.Font
        End If
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        Dim mytxtbook As String, msg As String
        msg = "关于我的记事本"
        mytxtbook = "请注意，本软件为徐犇同学开发，版权所有，但翻录不究！^_^"
        MsgBox(mytxtbook, MsgBoxStyle.OkOnly, msg)
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        frmfind.Show()
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub mnuU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuU.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub mnuFindAnother_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFindAnother.Click
        Me.r = InStr(Me.s, txtbox.Text, frmfind.txtfind.Text)
        If Me.r = 0 Then
            MsgBox("找不到！")

        Else

            txtbox.Select(Me.r - 1, frmfind.txtfind.Text.Length())
            Me.s = Me.r + 1
        End If

    End Sub

    Private Sub mnuReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReplace.Click
        Dim temp As String
        temp = InputBox("请输入要替换为的文本：", "替换")
        txtbox.SelectedText = temp
    End Sub

    Private Sub mnuGoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGoto.Click
        Dim temp As Integer
        temp = Val(InputBox("位置", "转到？位置", "0"))
        txtbox.SelectionStart = temp
    End Sub

    Private Sub mnuChexiao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChexiao.Click
        txtbox.Undo()
    End Sub
End Class
