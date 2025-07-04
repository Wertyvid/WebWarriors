Public Class FrmAwardCard
    Dim rnd As Random = New Random()

    Dim closeable As Boolean = False
    Dim player As Player
    Dim owningForm As FrmWebWarriors
    Public Sub New(playerToAward As Player, ownerForm As FrmWebWarriors)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        player = playerToAward
        owningForm = ownerForm
    End Sub

    Private Sub AwardCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For n As Integer = 0 To 2
            TblLayCardRewards.Controls.Add(New CardButton(RandomCardGetter.GetRandomCard(rnd), AddressOf AwardPlayerCard), n, 0)
        Next
    End Sub

    Public Sub AwardPlayerCard(sender As CardButton, e As EventArgs)
        player.AwardCard(sender.card)
        owningForm.AwardingCardFinished()
        RemoveAwardingForm()
    End Sub

    Private Sub RemoveAwardingForm()
        closeable = True
        Close()
    End Sub

    Private Sub FrmAwardCard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closeable Then
            e.Cancel = True
        End If
    End Sub
End Class