Public Class CardButton
    Inherits Button
    Public card As PlayerCard

    Public Sub New(newCard As PlayerCard)
        card = newCard
    End Sub
End Class
