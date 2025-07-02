Imports System.Drawing.Text

Public Class FrmWebWarriors
    Dim player As Player
    Dim enemy As Enemy
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player = New Player(Me)
        enemy = New Enemy()

        player.Setup()

        UpdateDisplay()

        HandlePlayerTurn()

    End Sub

    Private Sub DisplayPlayer()
        LblPlayerInfo.Text = player.ToString()
    End Sub

    Private Sub DisplayEnemy()
        LblEnemyInfo.Text = enemy.ToString()
    End Sub

    Private Sub UpdateDisplay()
        DisplayPlayer()
        DisplayEnemy()
    End Sub

    Private Sub LoadHand()
        For Each cardInHand In player.hand
            Dim cardButton As CardButton
            cardButton = New CardButton(cardInHand, AddressOf PlayCard)
            FlwLayHand.Controls.Add(cardButton)
        Next
    End Sub

    Public Sub PlayCard(sender As CardButton, e As EventArgs)
        If player.currentMana - sender.card.cost >= 0 Then
            player.UseMana(sender.card.cost)
            sender.card.Play(player, enemy)
            player.HandtoDiscard(sender.card)
            sender.Dispose()
            UpdateDisplay()
        Else
            sender.BackColor = Color.Red
        End If
    End Sub

    Private Sub EndTurn(sender As Object, e As EventArgs) Handles BtnEndTurn.Click
        FlwLayHand.Controls.Clear()
        player.EndTurn()
        HandleEnemyTurn()

    End Sub
    Private Sub HandleEnemyTurn()
        HandlePlayerTurn()
    End Sub

    Private Sub HandlePlayerTurn()
        player.StartTurn()
        LoadHand()
    End Sub

    Public Sub Finish()
        LblPlayerInfo.Text = "ooo dead"
        Close()
    End Sub
End Class

