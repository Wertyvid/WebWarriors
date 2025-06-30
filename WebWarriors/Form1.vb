Public Class FrmWebWarriors
    Dim player As Player
    Dim enemy As Enemy
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player = New Player()
        enemy = New Enemy()

        player.Setup()

        DisplayPlayer()
        DisplayEnemy()

        player.StartTurn()
        LoadHand()

    End Sub

    Private Sub DisplayPlayer()
        LblPlayerInfo.Text = player.ToString()
    End Sub

    Private Sub DisplayEnemy()
        LblEnemyInfo.Text = enemy.ToString()
    End Sub

    Private Sub LoadHand()
        For Each cardInHand In player.hand
            Dim cardButton As CardButton
            cardButton = New CardButton(cardInHand, AddressOf PlayCard)
            FlwLayHand.Controls.Add(cardButton)
        Next
    End Sub

    Public Sub PlayCard(sender As CardButton, e As EventArgs)
        sender.card.Play(player, enemy)
        DisplayEnemy()
        DisplayPlayer()
    End Sub
End Class

