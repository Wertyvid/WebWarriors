Public Class Player
    Dim rnd As New Random()
    Dim hp As Integer = 10
    Public drawPile As List(Of PlayerCard) = New List(Of PlayerCard)
    Dim fullDeck As List(Of PlayerCard) = New List(Of PlayerCard)
    Public DiscardPile As List(Of PlayerCard) = New List(Of PlayerCard)
    Public hand As List(Of PlayerCard) = New List(Of PlayerCard)

    Public Sub Setup()
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
        DrawHand()
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
        cards.InsertRange(0, shuffledCards)
    End Sub

    Public Sub TakeDamage(damage As Integer)
        hp -= damage
    End Sub

    Public Overrides Function ToString() As String
        Return $"Player{vbCrLf}Hp: {hp}"
    End Function
End Class


Public Class Enemy
    Dim hp As Integer

    Public Sub TakeDamage(damage As Integer)
        hp -= damage
    End Sub

    Public Overrides Function ToString() As String
        Return $"Enemy{vbCrLf}HP: {hp}"
    End Function
End Class