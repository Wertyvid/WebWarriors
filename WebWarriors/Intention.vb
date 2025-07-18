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
		player.TakeDamage(enemy.GetRealOutcomingDamage(damageToDeal))
	End Sub

	Public Overrides Function ToString() As String
		Return $"The enemy attacks for {damageToDeal} hp"
	End Function

	Public Overrides Function AsPremonition() As String
		Return $"Attack for {damageToDeal} hp"
	End Function
End Class

Public Class WeakenIntention
	Inherits EnemyIntention
	Dim amounttoWeaken As Integer
	Public Sub New(weakenAmount As Integer)
		amounttoWeaken = weakenAmount
	End Sub
	Public Overrides Sub Act(player As Player, enemy As Enemy)
		player.ApplyCondition(New PowerCondition(), -amounttoWeaken)
	End Sub

	Public Overrides Function AsPremonition() As String
		Return $"Remove {amounttoWeaken} power"
	End Function

	Public Overrides Function ToString() As String
		Return $"The enemy removes {amounttoWeaken} power"
	End Function
End Class

Public Class ConfuseIntention
	Inherits EnemyIntention
	Dim amounttoConfuse As Integer
	Public Sub New(confusionAmount As Integer)
		amounttoConfuse = confusionAmount
	End Sub

	Public Overrides Sub Act(player As Player, enemy As Enemy)
		For n As Integer = 1 To amounttoConfuse
			player.GiveCardForBattleToDrawPile(New CardConfused())
		Next
	End Sub

	Public Overrides Function AsPremonition() As String
		Return "Confuse the player"
	End Function

	Public Overrides Function ToString() As String
		Return $"The enemy adds {amounttoConfuse} confused cards to your deck"
	End Function
End Class