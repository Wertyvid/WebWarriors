<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWebWarriors
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TblLayMain = New TableLayoutPanel()
        TblLayCards = New TableLayoutPanel()
        FlwLayHand = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        LblPlayerInfo = New Label()
        BtnEndTurn = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        LstBoxLog = New ListBox()
        LblEnemyInfo = New Label()
        LblDrawCount = New Label()
        LblDiscardCount = New Label()
        TblLayMain.SuspendLayout()
        TblLayCards.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TblLayMain
        ' 
        TblLayMain.ColumnCount = 1
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TblLayMain.Controls.Add(TblLayCards, 0, 1)
        TblLayMain.Controls.Add(TableLayoutPanel1, 0, 2)
        TblLayMain.Controls.Add(TableLayoutPanel2, 0, 0)
        TblLayMain.Dock = DockStyle.Fill
        TblLayMain.Location = New Point(0, 0)
        TblLayMain.Name = "TblLayMain"
        TblLayMain.RowCount = 3
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 35F))
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 30F))
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 35F))
        TblLayMain.Size = New Size(800, 450)
        TblLayMain.TabIndex = 0
        ' 
        ' TblLayCards
        ' 
        TblLayCards.ColumnCount = 3
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TblLayCards.Controls.Add(LblDiscardCount, 2, 0)
        TblLayCards.Controls.Add(FlwLayHand, 1, 0)
        TblLayCards.Controls.Add(LblDrawCount, 0, 0)
        TblLayCards.Dock = DockStyle.Fill
        TblLayCards.Location = New Point(3, 160)
        TblLayCards.Name = "TblLayCards"
        TblLayCards.RowCount = 1
        TblLayCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TblLayCards.Size = New Size(794, 129)
        TblLayCards.TabIndex = 3
        ' 
        ' FlwLayHand
        ' 
        FlwLayHand.Dock = DockStyle.Fill
        FlwLayHand.Location = New Point(82, 3)
        FlwLayHand.Name = "FlwLayHand"
        FlwLayHand.Size = New Size(629, 123)
        FlwLayHand.TabIndex = 0
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(LblPlayerInfo, 1, 0)
        TableLayoutPanel1.Controls.Add(BtnEndTurn, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 295)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(794, 152)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' LblPlayerInfo
        ' 
        LblPlayerInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblPlayerInfo.AutoSize = True
        LblPlayerInfo.Location = New Point(731, 0)
        LblPlayerInfo.Name = "LblPlayerInfo"
        LblPlayerInfo.Size = New Size(60, 15)
        LblPlayerInfo.TabIndex = 2
        LblPlayerInfo.Text = "PlayerInfo"
        LblPlayerInfo.TextAlign = ContentAlignment.TopRight
        ' 
        ' BtnEndTurn
        ' 
        BtnEndTurn.Dock = DockStyle.Right
        BtnEndTurn.Location = New Point(716, 79)
        BtnEndTurn.Name = "BtnEndTurn"
        BtnEndTurn.Size = New Size(75, 70)
        BtnEndTurn.TabIndex = 3
        BtnEndTurn.Text = "End Turn"
        BtnEndTurn.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 3
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30F))
        TableLayoutPanel2.Controls.Add(LstBoxLog, 0, 0)
        TableLayoutPanel2.Controls.Add(LblEnemyInfo, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel2.Size = New Size(794, 151)
        TableLayoutPanel2.TabIndex = 5
        ' 
        ' LstBoxLog
        ' 
        LstBoxLog.Dock = DockStyle.Fill
        LstBoxLog.FormattingEnabled = True
        LstBoxLog.ItemHeight = 15
        LstBoxLog.Location = New Point(3, 3)
        LstBoxLog.Name = "LstBoxLog"
        LstBoxLog.Size = New Size(311, 145)
        LstBoxLog.TabIndex = 4
        ' 
        ' LblEnemyInfo
        ' 
        LblEnemyInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblEnemyInfo.AutoSize = True
        LblEnemyInfo.Location = New Point(750, 0)
        LblEnemyInfo.Name = "LblEnemyInfo"
        LblEnemyInfo.Size = New Size(41, 15)
        LblEnemyInfo.TabIndex = 3
        LblEnemyInfo.Text = "Label1"
        LblEnemyInfo.TextAlign = ContentAlignment.TopRight
        ' 
        ' LblDrawCount
        ' 
        LblDrawCount.AutoSize = True
        LblDrawCount.Dock = DockStyle.Fill
        LblDrawCount.Location = New Point(3, 0)
        LblDrawCount.Name = "LblDrawCount"
        LblDrawCount.Size = New Size(73, 129)
        LblDrawCount.TabIndex = 1
        LblDrawCount.Text = "Label1"
        LblDrawCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblDiscardCount
        ' 
        LblDiscardCount.AutoSize = True
        LblDiscardCount.Dock = DockStyle.Fill
        LblDiscardCount.Location = New Point(717, 0)
        LblDiscardCount.Name = "LblDiscardCount"
        LblDiscardCount.Size = New Size(74, 129)
        LblDiscardCount.TabIndex = 2
        LblDiscardCount.Text = "Label2"
        LblDiscardCount.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FrmWebWarriors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TblLayMain)
        Name = "FrmWebWarriors"
        Text = "Web Warriors"
        TblLayMain.ResumeLayout(False)
        TblLayCards.ResumeLayout(False)
        TblLayCards.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TblLayMain As TableLayoutPanel
    Friend WithEvents TblLayCards As TableLayoutPanel
    Friend WithEvents FlwLayHand As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblPlayerInfo As Label
    Friend WithEvents BtnEndTurn As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LstBoxLog As ListBox
    Friend WithEvents LblEnemyInfo As Label
    Friend WithEvents LblDrawCount As Label
    Friend WithEvents LblDiscardCount As Label

End Class
