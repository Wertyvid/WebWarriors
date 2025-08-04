Imports System.Drawing.Text

Public Class FrmWebWarriors
    Dim closeable As Boolean = False

    Public player As Player
    Public enemy As Enemy

    Public turncount As Integer = 0


    Public Sub New(battlePlayer As Player, battleEnemy As Enemy)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        player = battlePlayer
        enemy = battleEnemy

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        player.battleForm = Me
        enemy.battleForm = Me

        player.Setup()
        enemy.Setup()

        UpdateDisplay()

        HandlePlayerTurn()

    End Sub

    Private Sub DisplayPlayer()
        LblPlayerInfo.Text = player.ToString()
        BtnDiscardCount.Text = player.DiscardPile.Count.ToString()
        BtnDrawCount.Text = player.drawPile.Count.ToString()
        LstBoxPlayerConditions.Items.Clear()
        For Each condition In player.GetConditionsAsStrings()
            LstBoxPlayerConditions.Items.Add(condition)
        Next

    End Sub

    Private Sub DisplayEnemy()
        LblEnemyInfo.Text = enemy.ToString()
        LstBoxEnemyConditions.Items.Clear()
        For Each condition In enemy.GetConditionsAsStrings()
            LstBoxEnemyConditions.Items.Add(condition)
        Next
    End Sub

    Private Sub UpdateDisplay()
        DisplayPlayer()
        DisplayEnemy()
    End Sub

    Public Sub LogEvent(eventText As String)
        LstBoxLog.Items.Add(eventText)
    End Sub

    Private Sub LoadHand()
        FlwLayHand.Controls.Clear()
        For Each cardInHand In player.hand
            FlwLayHand.Controls.Add(cardInHand.GetCardButton(AddressOf PlayCard, enemy, player))
        Next
    End Sub

    Public Sub PlayCard(sender As CardButton, e As EventArgs)
        If sender.card.playable Then
            If player.currentMana - sender.card.cost >= 0 Then
                player.UseMana(sender.card.cost)
                sender.card.Play(player, enemy)
                LogEvent(sender.card.description)
                player.HandtoDiscard(sender.card)
                sender.Dispose()
                UpdateDisplay()
                LoadHand()
            Else
                sender.BackColor = Color.Red
            End If
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

    Private Sub BtnDrawCount_Click(sender As Object, e As EventArgs) Handles BtnDrawCount.Click
        Dim drawPileDisplayForm = New FrmDisplayCardList(player.drawPile)
        drawPileDisplayForm.Show()
    End Sub

    Private Sub BtnDiscardCount_Click(sender As Object, e As EventArgs) Handles BtnDiscardCount.Click
        Dim discardPileDisplayForm = New FrmDisplayCardList(player.DiscardPile)
        discardPileDisplayForm.Show()
    End Sub
End Class

