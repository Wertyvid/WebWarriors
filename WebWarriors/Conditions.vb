Public Class Condition
    Public Amount = 0

    Overridable Function AffectDamage(damage As Integer) As Integer
        Return damage
    End Function

    Overridable Sub EndTurnEffect(effected As Object)

    End Sub

    Public Sub DecrementAmount(Optional decrement As Integer = 1)
        Amount -= decrement
    End Sub
End Class

Public Class VulnerableCondition
    Inherits Condition
    Public Overrides Function AffectDamage(damage As Integer) As Integer
        Return damage * 1.25
    End Function

    Public Overrides Sub EndTurnEffect(effected As System.Object)
        Me.DecrementAmount()
    End Sub
End Class