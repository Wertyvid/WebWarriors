Public Class EnemyIntention
	Public intentionText = "Placeholder"
	Overridable Sub Act(player As Player, enemy As Enemy)

	End Sub
End Class

Public Class AttackIntention
	Inherits EnemyIntention
	Overrides Sub Act(player As Player, enemy As Enemy)
		player.TakeDamage(5)
	End Sub

	Public Overrides Function ToString() As String
		Return "The enemy attacks for 5 hp"
	End Function
End Class