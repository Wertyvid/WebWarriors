Public Class Condition
    Public Amount = 0

    Overridable Function AffectIncomingDamage(damage As Integer) As Integer
        Return damage
    End Function

    Overridable Function AffectOutcomingDamage(damage As Integer)
        Return damage
    End Function

    Overridable Sub EndTurnEffect(effected As Object)
        DecrementAmount()
    End Sub

    Public Overridable Sub DecrementAmount(Optional decrement As Integer = 1)
        Amount -= decrement
    End Sub
End Class

Public Class VulnerableCondition
    Inherits Condition
    Public Overrides Function AffectIncomingDamage(damage As Integer) As Integer
        Return damage * 1.25
    End Function
End Class

Public Class PowerCondition
    Inherits Condition
    Public Overrides Function AffectOutcomingDamage(damage As Integer) As Object
        Return damage + Amount
    End Function

    Public Overrides Sub DecrementAmount(Optional decrement As Integer = 1)
        'do nothing lol
    End Sub
End Class