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
        BtnDrawCount = New Button()
        BtnDiscardCount = New Button()
        TableLayoutPanel1 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        LblPlayerInfo = New Label()
        BtnEndTurn = New Button()
        LstBoxPlayerConditions = New ListBox()
        TableLayoutPanel2 = New TableLayoutPanel()
        LstBoxLog = New ListBox()
        LblEnemyInfo = New Label()
        LstBoxEnemyConditions = New ListBox()
        TblLayMain.SuspendLayout()
        TblLayCards.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TblLayMain
        ' 
        TblLayMain.ColumnCount = 1
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TblLayMain.Controls.Add(TblLayCards, 0, 1)
        TblLayMain.Controls.Add(TableLayoutPanel1, 0, 2)
        TblLayMain.Controls.Add(TableLayoutPanel2, 0, 0)
        TblLayMain.Dock = DockStyle.Fill
        TblLayMain.Location = New Point(0, 0)
        TblLayMain.Name = "TblLayMain"
        TblLayMain.RowCount = 3
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 35.0F))
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 30.0F))
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 35.0F))
        TblLayMain.Size = New Size(800, 450)
        TblLayMain.TabIndex = 0
        ' 
        ' TblLayCards
        ' 
        TblLayCards.ColumnCount = 3
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80.0F))
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10.0F))
        TblLayCards.Controls.Add(FlwLayHand, 1, 0)
        TblLayCards.Controls.Add(BtnDrawCount, 0, 0)
        TblLayCards.Controls.Add(BtnDiscardCount, 2, 0)
        TblLayCards.Dock = DockStyle.Fill
        TblLayCards.Location = New Point(3, 160)
        TblLayCards.Name = "TblLayCards"
        TblLayCards.RowCount = 1
        TblLayCards.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
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
        ' BtnDrawCount
        ' 
        BtnDrawCount.Dock = DockStyle.Fill
        BtnDrawCount.Location = New Point(3, 3)
        BtnDrawCount.Name = "BtnDrawCount"
        BtnDrawCount.Size = New Size(73, 123)
        BtnDrawCount.TabIndex = 3
        BtnDrawCount.Text = "Draw Pile"
        BtnDrawCount.UseVisualStyleBackColor = True
        ' 
        ' BtnDiscardCount
        ' 
        BtnDiscardCount.Dock = DockStyle.Fill
        BtnDiscardCount.Location = New Point(717, 3)
        BtnDiscardCount.Name = "BtnDiscardCount"
        BtnDiscardCount.Size = New Size(74, 123)
        BtnDiscardCount.TabIndex = 4
        BtnDiscardCount.Text = "Discard Pile"
        BtnDiscardCount.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel1.Controls.Add(TableLayoutPanel3, 3, 0)
        TableLayoutPanel1.Controls.Add(LstBoxPlayerConditions, 2, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 295)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel1.Size = New Size(794, 152)
        TableLayoutPanel1.TabIndex = 4
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
        TableLayoutPanel3.Controls.Add(LblPlayerInfo, 0, 0)
        TableLayoutPanel3.Controls.Add(BtnEndTurn, 0, 1)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(677, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        TableLayoutPanel3.Size = New Size(114, 146)
        TableLayoutPanel3.TabIndex = 3
        ' 
        ' LblPlayerInfo
        ' 
        LblPlayerInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblPlayerInfo.AutoSize = True
        LblPlayerInfo.Location = New Point(51, 0)
        LblPlayerInfo.Name = "LblPlayerInfo"
        LblPlayerInfo.Size = New Size(60, 15)
        LblPlayerInfo.TabIndex = 2
        LblPlayerInfo.Text = "PlayerInfo"
        LblPlayerInfo.TextAlign = ContentAlignment.TopRight
        ' 
        ' BtnEndTurn
        ' 
        BtnEndTurn.Dock = DockStyle.Fill
        BtnEndTurn.Location = New Point(3, 76)
        BtnEndTurn.Name = "BtnEndTurn"
        BtnEndTurn.Size = New Size(108, 67)
        BtnEndTurn.TabIndex = 3
        BtnEndTurn.Text = "End Turn"
        BtnEndTurn.UseVisualStyleBackColor = True
        ' 
        ' LstBoxPlayerConditions
        ' 
        LstBoxPlayerConditions.Dock = DockStyle.Fill
        LstBoxPlayerConditions.FormattingEnabled = True
        LstBoxPlayerConditions.ItemHeight = 15
        LstBoxPlayerConditions.Location = New Point(558, 3)
        LstBoxPlayerConditions.Name = "LstBoxPlayerConditions"
        LstBoxPlayerConditions.Size = New Size(113, 146)
        LstBoxPlayerConditions.TabIndex = 4
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 4
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15.0F))
        TableLayoutPanel2.Controls.Add(LstBoxLog, 0, 0)
        TableLayoutPanel2.Controls.Add(LblEnemyInfo, 3, 0)
        TableLayoutPanel2.Controls.Add(LstBoxEnemyConditions, 2, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 1
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
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
        ' LstBoxEnemyConditions
        ' 
        LstBoxEnemyConditions.Dock = DockStyle.Fill
        LstBoxEnemyConditions.FormattingEnabled = True
        LstBoxEnemyConditions.ItemHeight = 15
        LstBoxEnemyConditions.Location = New Point(558, 3)
        LstBoxEnemyConditions.Name = "LstBoxEnemyConditions"
        LstBoxEnemyConditions.Size = New Size(113, 145)
        LstBoxEnemyConditions.TabIndex = 5
        ' 
        ' FrmWebWarriors
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TblLayMain)
        Name = "FrmWebWarriors"
        Text = "Web Warriors"
        TblLayMain.ResumeLayout(False)
        TblLayCards.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TblLayMain As TableLayoutPanel
    Friend WithEvents TblLayCards As TableLayoutPanel
    Friend WithEvents FlwLayHand As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblPlayerInfo As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LstBoxLog As ListBox
    Friend WithEvents LblEnemyInfo As Label
    Friend WithEvents BtnDrawCount As Button
    Friend WithEvents BtnDiscardCount As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BtnEndTurn As Button
    Friend WithEvents LstBoxPlayerConditions As ListBox
    Friend WithEvents LstBoxEnemyConditions As ListBox

End Class
