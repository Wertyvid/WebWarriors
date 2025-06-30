Public Class PlayerCard
    Public name As String = "Placeholder"
    Public Overridable Sub Play(player As Player, target As Enemy)

    End Sub
End Class

Public Class CardBitSlash
    Inherits PlayerCard
    Sub New()
        name = "BitSlash"
    End Sub
    Public Overrides Sub Play(player As Player, target As Enemy)
        target.TakeDamage(10)
    End Sub
End Class

Public Class CardHealSelf
    Inherits PlayerCard
    Sub New()
        name = "Heal"
    End Sub
    Public Overrides Sub Play(player As Player, target As Enemy)
        player.TakeDamage(-5)
    End Sub
End Class