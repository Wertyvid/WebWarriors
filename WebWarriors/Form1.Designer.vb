<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        FlwLayHand = New FlowLayoutPanel()
        LblPlayerInfo = New Label()
        LblEnemyInfo = New Label()
        TblLayMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' TblLayMain
        ' 
        TblLayMain.ColumnCount = 3
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayMain.Controls.Add(FlwLayHand, 1, 2)
        TblLayMain.Controls.Add(LblPlayerInfo, 2, 2)
        TblLayMain.Controls.Add(LblEnemyInfo, 2, 0)
        TblLayMain.Dock = DockStyle.Fill
        TblLayMain.Location = New Point(0, 0)
        TblLayMain.Name = "TblLayMain"
        TblLayMain.RowCount = 3
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TblLayMain.RowStyles.Add(New RowStyle(SizeType.Percent, 45F))
        TblLayMain.Size = New Size(800, 450)
        TblLayMain.TabIndex = 0
        ' 
        ' FlwLayHand
        ' 
        FlwLayHand.Dock = DockStyle.Fill
        FlwLayHand.Location = New Point(269, 250)
        FlwLayHand.Name = "FlwLayHand"
        FlwLayHand.Size = New Size(260, 197)
        FlwLayHand.TabIndex = 0
        ' 
        ' LblPlayerInfo
        ' 
        LblPlayerInfo.AutoSize = True
        LblPlayerInfo.Location = New Point(535, 247)
        LblPlayerInfo.Name = "LblPlayerInfo"
        LblPlayerInfo.Size = New Size(60, 15)
        LblPlayerInfo.TabIndex = 1
        LblPlayerInfo.Text = "PlayerInfo"
        ' 
        ' LblEnemyInfo
        ' 
        LblEnemyInfo.AutoSize = True
        LblEnemyInfo.Location = New Point(535, 0)
        LblEnemyInfo.Name = "LblEnemyInfo"
        LblEnemyInfo.Size = New Size(41, 15)
        LblEnemyInfo.TabIndex = 2
        LblEnemyInfo.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TblLayMain)
        Name = "Form1"
        Text = "Form1"
        TblLayMain.ResumeLayout(False)
        TblLayMain.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TblLayMain As TableLayoutPanel
    Friend WithEvents FlwLayHand As FlowLayoutPanel
    Friend WithEvents LblPlayerInfo As Label
    Friend WithEvents LblEnemyInfo As Label

End Class
