Public Class FrmDisplayCardList
    Dim cardList As List(Of PlayerCard)
    Public Sub New(cardsToDisplay As List(Of PlayerCard))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        cardList = cardsToDisplay
    End Sub

    Public Sub FrmDisplayCardListLoad() Handles MyBase.Load
        For Each card In cardList
            FlwLayCardContainer.Controls.Add(card.GetCardButton())
        Next
    End Sub
End Class