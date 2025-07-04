<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAwardCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TblLayCardRewards = New TableLayoutPanel()
        SuspendLayout()
        ' 
        ' TblLayCardRewards
        ' 
        TblLayCardRewards.ColumnCount = 3
        TblLayCardRewards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayCardRewards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayCardRewards.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayCardRewards.Dock = DockStyle.Fill
        TblLayCardRewards.Location = New Point(0, 0)
        TblLayCardRewards.Name = "TblLayCardRewards"
        TblLayCardRewards.RowCount = 1
        TblLayCardRewards.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TblLayCardRewards.Size = New Size(741, 319)
        TblLayCardRewards.TabIndex = 0
        ' 
        ' FrmAwardCard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(741, 319)
        Controls.Add(TblLayCardRewards)
        Name = "FrmAwardCard"
        Text = "AwardCard"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TblLayCardRewards As TableLayoutPanel
End Class
