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
        LblEnemyInfo = New Label()
        TblLayCards = New TableLayoutPanel()
        FlwLayHand = New FlowLayoutPanel()
        TableLayoutPanel1 = New TableLayoutPanel()
        LblPlayerInfo = New Label()
        BtnEndTurn = New Button()
        TblLayMain.SuspendLayout()
        TblLayCards.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TblLayMain
        ' 
        TblLayMain.ColumnCount = 1
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TblLayMain.Controls.Add(LblEnemyInfo, 0, 0)
        TblLayMain.Controls.Add(TblLayCards, 0, 1)
        TblLayMain.Controls.Add(TableLayoutPanel1, 0, 2)
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
        ' LblEnemyInfo
        ' 
        LblEnemyInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        LblEnemyInfo.AutoSize = True
        LblEnemyInfo.Location = New Point(756, 0)
        LblEnemyInfo.Name = "LblEnemyInfo"
        LblEnemyInfo.Size = New Size(41, 15)
        LblEnemyInfo.TabIndex = 2
        LblEnemyInfo.Text = "Label1"
        LblEnemyInfo.TextAlign = ContentAlignment.TopRight
        ' 
        ' TblLayCards
        ' 
        TblLayCards.ColumnCount = 3
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80F))
        TblLayCards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TblLayCards.Controls.Add(FlwLayHand, 1, 0)
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
        ' FrmWebWarriors
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TblLayMain)
        Name = "FrmWebWarriors"
        Text = "Web Warriors"
        TblLayMain.ResumeLayout(False)
        TblLayMain.PerformLayout()
        TblLayCards.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TblLayMain As TableLayoutPanel
    Friend WithEvents LblEnemyInfo As Label
    Friend WithEvents TblLayCards As TableLayoutPanel
    Friend WithEvents FlwLayHand As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblPlayerInfo As Label
    Friend WithEvents BtnEndTurn As Button

End Class
