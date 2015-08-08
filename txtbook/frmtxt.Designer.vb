<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmtxt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtxt))
        Me.txtbox = New System.Windows.Forms.TextBox
        Me.mnu = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuAS = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuU = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuChexiao = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuFind = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFindAnother = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuReplace = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuGoto = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuAll = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDate = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuW = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFont = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuS = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelptheme = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.SFD = New System.Windows.Forms.SaveFileDialog
        Me.FD = New System.Windows.Forms.FontDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbox
        '
        Me.txtbox.Location = New System.Drawing.Point(0, 24)
        Me.txtbox.Multiline = True
        Me.txtbox.Name = "txtbox"
        Me.txtbox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtbox.Size = New System.Drawing.Size(607, 423)
        Me.txtbox.TabIndex = 0
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuo, Me.mnuView, Me.mnuHelp})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(607, 24)
        Me.mnu.TabIndex = 1
        Me.mnu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuAS, Me.ToolStripMenuItem2, Me.mnuU, Me.mnuPrint, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(66, 20)
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(168, 22)
        Me.mnuNew.Text = "新建(&N)"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(168, 22)
        Me.mnuOpen.Text = "打开(&O)..."
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(168, 22)
        Me.mnuSave.Text = "保存(&S)"
        '
        'mnuAS
        '
        Me.mnuAS.Name = "mnuAS"
        Me.mnuAS.Size = New System.Drawing.Size(168, 22)
        Me.mnuAS.Text = "另存为(&A)..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 6)
        '
        'mnuU
        '
        Me.mnuU.Name = "mnuU"
        Me.mnuU.Size = New System.Drawing.Size(168, 22)
        Me.mnuU.Text = "页面设置(&U)..."
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(168, 22)
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(168, 22)
        Me.mnuExit.Text = "退出(&X)"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChexiao, Me.ToolStripMenuItem3, Me.mnuCut, Me.mnuCopy, Me.mnuPaste, Me.mnuDelete, Me.ToolStripMenuItem4, Me.mnuFind, Me.mnuFindAnother, Me.mnuReplace, Me.mnuGoto, Me.ToolStripMenuItem5, Me.mnuAll, Me.mnuDate})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(66, 20)
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuChexiao
        '
        Me.mnuChexiao.Name = "mnuChexiao"
        Me.mnuChexiao.Size = New System.Drawing.Size(160, 22)
        Me.mnuChexiao.Text = "撤消(&U)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(157, 6)
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(160, 22)
        Me.mnuCut.Text = "剪切(&T)"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(160, 22)
        Me.mnuCopy.Text = "复制(&C)"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(160, 22)
        Me.mnuPaste.Text = "粘贴(&P)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(160, 22)
        Me.mnuDelete.Text = "删除(&L)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(157, 6)
        '
        'mnuFind
        '
        Me.mnuFind.Name = "mnuFind"
        Me.mnuFind.Size = New System.Drawing.Size(160, 22)
        Me.mnuFind.Text = "查找(&F)..."
        '
        'mnuFindAnother
        '
        Me.mnuFindAnother.Name = "mnuFindAnother"
        Me.mnuFindAnother.Size = New System.Drawing.Size(160, 22)
        Me.mnuFindAnother.Text = "查找下一个(&N)"
        '
        'mnuReplace
        '
        Me.mnuReplace.Name = "mnuReplace"
        Me.mnuReplace.Size = New System.Drawing.Size(160, 22)
        Me.mnuReplace.Text = "替换(&R)..."
        '
        'mnuGoto
        '
        Me.mnuGoto.Name = "mnuGoto"
        Me.mnuGoto.Size = New System.Drawing.Size(160, 22)
        Me.mnuGoto.Text = "转到(&G)"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(157, 6)
        '
        'mnuAll
        '
        Me.mnuAll.Name = "mnuAll"
        Me.mnuAll.Size = New System.Drawing.Size(160, 22)
        Me.mnuAll.Text = "全选(&A)"
        '
        'mnuDate
        '
        Me.mnuDate.Name = "mnuDate"
        Me.mnuDate.Size = New System.Drawing.Size(160, 22)
        Me.mnuDate.Text = "日期时间(&D)"
        '
        'mnuo
        '
        Me.mnuo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuW, Me.mnuFont})
        Me.mnuo.Name = "mnuo"
        Me.mnuo.Size = New System.Drawing.Size(66, 20)
        Me.mnuo.Text = "格式(&O)"
        '
        'mnuW
        '
        Me.mnuW.Checked = True
        Me.mnuW.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuW.Name = "mnuW"
        Me.mnuW.Size = New System.Drawing.Size(147, 22)
        Me.mnuW.Text = "自动换行(&W)"
        '
        'mnuFont
        '
        Me.mnuFont.Name = "mnuFont"
        Me.mnuFont.Size = New System.Drawing.Size(147, 22)
        Me.mnuFont.Text = "字体(&F)..."
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuS})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(66, 20)
        Me.mnuView.Text = "查看(&V)"
        '
        'mnuS
        '
        Me.mnuS.Name = "mnuS"
        Me.mnuS.Size = New System.Drawing.Size(134, 22)
        Me.mnuS.Text = "状态栏(&S)"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelptheme, Me.ToolStripMenuItem6, Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(66, 20)
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'mnuHelptheme
        '
        Me.mnuHelptheme.Name = "mnuHelptheme"
        Me.mnuHelptheme.Size = New System.Drawing.Size(160, 22)
        Me.mnuHelptheme.Text = "帮助主题(&H)"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(157, 6)
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(160, 22)
        Me.mnuAbout.Text = "关于记事本(&A)"
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmtxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 451)
        Me.Controls.Add(Me.txtbox)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "frmtxt"
        Me.Text = "我的记事本"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbox As System.Windows.Forms.TextBox
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuU As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuChexiao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFindAnother As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReplace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGoto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuW As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFont As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelptheme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FD As System.Windows.Forms.FontDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog

End Class
