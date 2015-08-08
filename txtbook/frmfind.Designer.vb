<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmfind
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtfind = New System.Windows.Forms.TextBox
        Me.btnfind = New System.Windows.Forms.Button
        Me.btncancel = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "查找内容(&N):"
        '
        'txtfind
        '
        Me.txtfind.Location = New System.Drawing.Point(102, 19)
        Me.txtfind.Name = "txtfind"
        Me.txtfind.Size = New System.Drawing.Size(206, 21)
        Me.txtfind.TabIndex = 1
        '
        'btnfind
        '
        Me.btnfind.Location = New System.Drawing.Point(324, 12)
        Me.btnfind.Name = "btnfind"
        Me.btnfind.Size = New System.Drawing.Size(91, 27)
        Me.btnfind.TabIndex = 2
        Me.btnfind.Text = "查找下一个"
        Me.btnfind.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(324, 71)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(91, 27)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "取消"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'frmfind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 138)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnfind)
        Me.Controls.Add(Me.txtfind)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmfind"
        Me.Text = "查找"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfind As System.Windows.Forms.TextBox
    Friend WithEvents btnfind As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
End Class
