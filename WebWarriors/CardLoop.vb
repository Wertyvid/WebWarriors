Imports System.Drawing.Text

Public Class FrmWebWarriors
    Dim closeable As Boolean = False

    Public player As Player
    Public enemy As Enemy

    Public turncount As Integer = 0


    Public Sub New(battlePlayer As Player)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        player = battlePlayer

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player.battleForm = Me
        enemy = New Enemy(Me)

        player.Setup()
        enemy.Setup()

        UpdateDisplay()

        HandlePlayerTurn()

    End Sub

    Private Sub DisplayPlayer()
        LblPlayerInfo.Text = player.ToString()
        LblDiscardCount.Text = player.DiscardPile.Count.ToString()
        LblDrawCount.Text = player.drawPile.Count.ToString()
    End Sub

    Private Sub DisplayEnemy()
        LblEnemyInfo.Text = enemy.ToString()
    End Sub

    Private Sub UpdateDisplay()
        DisplayPlayer()
        DisplayEnemy()
    End Sub

    Public Sub LogEvent(eventText As String)
        LstBoxLog.Items.Add(eventText)
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
            LogEvent(sender.card.description)
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
        enemy.StartTurn()
        turncount += 1
        UpdateDisplay()
        HandlePlayerTurn()
    End Sub

    Private Sub HandlePlayerTurn()
        player.StartTurn()
        LoadHand()
        UpdateDisplay()
    End Sub

    Public Sub Lose()
        Controls.Clear()
        Dim LblLost As Label = New Label()
        LblLost.Text = "You lose!"
        LblLost.Dock = DockStyle.Fill
        LblLost.TextAlign = ContentAlignment.MiddleCenter
        Controls.Add(LblLost)
    End Sub

    Public Sub Win()
        Controls.Clear()
        Dim LblLost As Label = New Label()
        LblLost.Text = "You win!"
        LblLost.Dock = DockStyle.Fill
        LblLost.TextAlign = ContentAlignment.MiddleCenter
        player.FinishBattle()
        Controls.Add(LblLost)
        CreateAwardCardMenu()
    End Sub

    Private Sub CreateAwardCardMenu()
        Dim awardCardForm As FrmAwardCard = New FrmAwardCard(player, Me)
        awardCardForm.Show()
    End Sub

    Public Sub AwardingCardFinished()
        RemoveBattle()
    End Sub

    Public Sub RemoveBattle()
        closeable = True
        Close()

    End Sub

    Private Sub FrmWebWarriors_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closeable Then
            e.Cancel = True
        End If
    End Sub
End Class

