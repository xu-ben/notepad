Public Class frmfind

    Private Sub frmfind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmtxt.s = 1
        frmtxt.r = 0
        Me.txtfind.Focus()
    End Sub

    Private Sub btnfind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfind.Click
        frmtxt.r = InStr(frmtxt.s, frmtxt.txtbox.Text, txtfind.Text)
        If frmtxt.r = 0 Then
            MsgBox("’“≤ªµΩ£°")

        Else

            frmtxt.Focus()
            frmtxt.txtbox.Select(frmtxt.r - 1, txtfind.Text.Length())
            frmtxt.s = frmtxt.r + 1
        End If

    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class