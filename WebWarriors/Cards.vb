Public Class PlayerCard
    Public name As String = "Placeholder"
    Public playable As Boolean = True
    Public cost As Integer = 1
    Public description As String = "Placeholder card"
    Public Overridable Sub Play(player As Player, target As Enemy)

    End Sub

    Public Overloads Function ToString(target As Enemy, player As Player) As String
        Return $"{name}:{cost.ToString}{vbCrLf}{GetDescription(target, player)}"
    End Function

    Public Overrides Function ToString() As String
        Return $"{name}:{cost.ToString}{vbCrLf}{description}"
    End Function

    Public Overridable Function GetDescription(target As Enemy, player As Player)
        Return description
    End Function

End Class

Public Class RandomCardGetter
    Public Shared Function GetRandomCard(rnd As Random) As PlayerCard
        Dim allCards As List(Of PlayerCard) = New List(Of PlayerCard) From {New CardBitSlash(), New CardVulnerable(), New CardHealSelf()}
        Return allCards(rnd.Next(0, allCards.Count))
    End Function
End Class

Public Class CardBitSlash
    Inherits PlayerCard
    Dim basedamage As Integer = 10
    Sub New()
        name = "BitSlash"
        description = "Deal 10 damage to an enemy"
    End Sub
    Public Overrides Sub Play(player As Player, target As Enemy)
        target.TakeDamage(player.GetRealOutcomingDamage(basedamage))
    End Sub

    Public Overrides Function GetDescription(target As Enemy, player As Player) As Object
        Return Replace(description, "10", target.GetRealIncomingDamage(player.GetRealOutcomingDamage(basedamage)).ToString())
    End Function
End Class

Public Class CardHealSelf
    Inherits PlayerCard
    Sub New()
        name = "Heal"
        description = "Heal 5 health"
    End Sub
    Public Overrides Sub Play(player As Player, target As Enemy)
        player.TakeDamage(-5)
    End Sub
End Class

Public Class CardVulnerable
    Inherits PlayerCard
    Sub New()
        name = "Disable Firewall"
        description = "Apply vulnerable"
    End Sub

    Public Overrides Sub Play(player As Player, target As Enemy)
        target.ApplyCondition(New VulnerableCondition())
    End Sub
End Class

Public Class CardConfused
    Inherits PlayerCard
    Sub New()
        name = "Confusion"
        description = "Unplayable"
        playable = False
    End Sub
End Class