Public Class EnemyIntention
	Public intentionText = "Placeholder"
	Overridable Sub Act(player As Player, enemy As Enemy)

	End Sub

	Public Overridable Function AsPremonition() As String
		Return "Placeholder"
	End Function
End Class

Public Class AttackIntention
	Inherits EnemyIntention
	Dim damageToDeal

	Public Sub New(damage As Integer)
		damageToDeal = damage
	End Sub
	Overrides Sub Act(player As Player, enemy As Enemy)
		player.TakeDamage(damageToDeal)
	End Sub

	Public Overrides Function ToString() As String
		Return $"The enemy attacks for {damageToDeal} hp"
	End Function

	Public Overrides Function AsPremonition() As String
		Return $"Attack for {damageToDeal} hp"
	End Function
End Class