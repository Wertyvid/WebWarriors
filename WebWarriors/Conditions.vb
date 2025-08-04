Public Class Condition
    Public Amount = 0
    Public Overridable ReadOnly Property Name As String
        Get
            Return "Placeholder"
        End Get
    End Property


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

    Public Overrides Function ToString() As String
        Return Name + " " + Amount.ToString()
    End Function
End Class

Public Class VulnerableCondition
    Inherits Condition
    Public Overrides ReadOnly Property Name As String
        Get
            Return "Vulnerable"
        End Get
    End Property
    Public Overrides Function AffectIncomingDamage(damage As Integer) As Integer
        Return damage * 1.25
    End Function
End Class

Public Class PowerCondition
    Inherits Condition
    Public Overrides ReadOnly Property Name As String
        Get
            Return "Power"
        End Get
    End Property
    Public Overrides Function AffectOutcomingDamage(damage As Integer) As Object
        Return damage + Amount
    End Function

    Public Overrides Sub DecrementAmount(Optional decrement As Integer = 1)
        'do nothing lol
    End Sub
End Class