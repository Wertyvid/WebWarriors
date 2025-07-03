Public Class Player
	Dim rnd As New Random()
	Dim battleForm As FrmWebWarriors

	Dim maxHP As Integer = 10
	Dim hp As Integer = 10
	Public currentMana = 0
	Dim maxMana = 3
	Public drawPile As List(Of PlayerCard) = New List(Of PlayerCard)
	Dim fullDeck As List(Of PlayerCard) = New List(Of PlayerCard)
	Public DiscardPile As List(Of PlayerCard) = New List(Of PlayerCard)
	Public hand As List(Of PlayerCard) = New List(Of PlayerCard)

	Public Sub New(form As FrmWebWarriors)
		battleForm = form
	End Sub

	Public Sub Setup()
		hp = maxHP
		currentMana = maxMana
		fullDeck.Add(New CardBitSlash())
		fullDeck.Add(New CardBitSlash())
		fullDeck.Add(New CardBitSlash())
		fullDeck.Add(New CardBitSlash())
		fullDeck.Add(New CardBitSlash())
		fullDeck.Add(New CardHealSelf())
		fullDeck.Add(New CardHealSelf())
		fullDeck.Add(New CardHealSelf())
		drawPile = fullDeck.ToList()
		Shuffle(drawPile)
	End Sub

	Public Sub StartTurn()
		currentMana = maxMana
		DrawHand()
	End Sub
	Public Sub EndTurn()
		DiscardHand()

	End Sub

	Private Sub DrawHand()
		Dim amountToDraw As Integer = 5
		For n As Integer = 1 To amountToDraw
			If drawPile.Count > 0 Then
				hand.Add(drawPile(0))
				drawPile.RemoveAt(0)
			Else
				ReshuffleDrawPile()
				hand.Add(drawPile(0))
				drawPile.RemoveAt(0)
			End If
		Next
	End Sub

	Private Sub ReshuffleDrawPile()
		drawPile = DiscardPile.ToList
		DiscardPile = New List(Of PlayerCard)
		Shuffle(drawPile)
	End Sub
	Private Sub Shuffle(cards As List(Of PlayerCard))
		Dim shuffledCards As List(Of PlayerCard) = New List(Of PlayerCard)
		Dim randomindex As Integer
		For n As Integer = 0 To cards.Count - 1
			randomindex = rnd.Next(0, cards.Count - 1)
			shuffledCards.Add(cards(randomindex))
			cards.RemoveAt(randomindex)
		Next
		cards.AddRange(shuffledCards)
	End Sub

	Public Sub HandtoDiscard(card As PlayerCard)
		DiscardPile.Add(card)
		hand.Remove(card)
	End Sub

	Public Sub DiscardHand()
		DiscardPile.AddRange(hand)
		hand.Clear()
	End Sub

	Public Sub TakeDamage(damage As Integer)
		hp -= damage
		hp = Math.Clamp(hp, 0, maxHP)
		If hp = 0 Then
			battleForm.Lose()
		End If
	End Sub

	Public Sub UseMana(amount As Integer)
		currentMana -= amount
	End Sub

	Public Overrides Function ToString() As String
		Return $"Player{vbCrLf}Hp: {hp}{vbCrLf}Mana: {currentMana}"
	End Function
End Class




Public Class Enemy
	Dim intentionList As List(Of EnemyIntention) = New List(Of EnemyIntention)
	Dim battleForm As FrmWebWarriors

	Dim maxHP As Integer = 20
	Dim hp As Integer = 20

	Public Sub Setup()
		intentionList.Add(New AttackIntention)
	End Sub
	Public Sub New(form As FrmWebWarriors)
		battleForm = form
	End Sub

	Public Sub TakeDamage(damage As Integer)
		hp -= damage
		hp = Math.Clamp(hp, 0, maxHP)
		If hp = 0 Then
			battleForm.Win()
		End If
	End Sub

	Public Overrides Function ToString() As String
		Return $"Enemy{vbCrLf}HP: {hp}"
	End Function

	Public Sub StartTurn()
		Dim currentIntention = intentionList(battleForm.turncount Mod intentionList.Count)
		battleForm.LogEvent(currentIntention.ToString)
		currentIntention.Act(battleForm.player, Me)

	End Sub
End Class

