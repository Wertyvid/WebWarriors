Public Class CardButton
    Inherits Button
    Public card As PlayerCard

    Public Sub New(newCard As PlayerCard, eventHandler As EventHandler)
        card = newCard
        Text = card.ToString()
        AutoSize = True
        AddHandler Click, eventHandler
    End Sub

    Public Sub New(newCard As PlayerCard, eventHandler As EventHandler, target As Enemy, player As Player)
        card = newCard
        Text = card.ToString(target, player)
        AutoSize = True
        AddHandler Click, eventHandler
    End Sub
End Class