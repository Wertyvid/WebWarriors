Public Class Enemy
    Public intentionList As List(Of EnemyIntention) = New List(Of EnemyIntention)
    Public battleForm As FrmWebWarriors

    Dim maxHP As Integer = 0
    Dim hp As Integer = 0

    Dim conditions As List(Of Condition) = New List(Of Condition)

    Public Overridable Sub Setup()

    End Sub

    Public Sub SetMaxHP(newMaxHP)
        maxHP = newMaxHP
        hp = maxHP
    End Sub

    Public Sub TakeDamage(damage As Integer)
        Dim damageAfterConditions = GetRealIncomingDamage(damage)
        hp -= damageAfterConditions
        hp = Math.Clamp(hp, 0, maxHP)
        If hp = 0 Then
            battleForm.Win()
        End If
    End Sub

    Public Function GetRealIncomingDamage(damage As Integer)
        Dim damageAfterConditions = damage
        For Each condition As Condition In conditions
            damageAfterConditions = condition.AffectIncomingDamage(damageAfterConditions)
        Next
        Return damageAfterConditions
    End Function

    Public Function GetRealOutcomingDamage(damage As Integer)
        Dim damageAfterConditions = damage
        For Each condition As Condition In conditions
            damageAfterConditions = condition.AffectOutcomingDamage(damageAfterConditions)
        Next
        Return damageAfterConditions
    End Function

    Public Sub ApplyCondition(condition As Condition, Optional amount As Integer = 1)
        Dim newConditionType As Type = condition.GetType()
        Dim newConditionUnused As Boolean = True
        Dim preexistingConditionOfType As Condition
        For Each currentCondition In conditions
            If currentCondition.GetType() = newConditionType Then
                newConditionUnused = False
                preexistingConditionOfType = currentCondition
            End If
        Next
        If newConditionUnused Then
            condition.Amount = amount
            conditions.Add(condition)
        Else
            preexistingConditionOfType.Amount += amount
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return $"Enemy{vbCrLf}HP: {hp}{vbCrLf}{intentionList(battleForm.turncount Mod intentionList.Count).AsPremonition()}"
    End Function

    Public Function GetConditionsAsStrings() As List(Of String)
        Dim conditionStringList As List(Of String) = New List(Of String)
        For Each condition In conditions
            conditionStringList.Add(condition.ToString())
        Next
        Return conditionStringList
    End Function

    Public Sub StartTurn()
        Dim currentIntention = intentionList(battleForm.turncount Mod intentionList.Count)
        battleForm.LogEvent(currentIntention.ToString())
        currentIntention.Act(battleForm.player, Me)

        For Each condition As Condition In conditions
            condition.EndTurnEffect(Me)
        Next
    End Sub



End Class

Public Class SillyEnemy
    Inherits Enemy

    Public Overrides Sub Setup()
        SetMaxHP(40)
        intentionList.Add(New WeakenIntention(4))
        intentionList.Add(New AttackIntention(7))
        intentionList.Add(New AttackIntention(4))
        intentionList.Add(New AttackIntention(12))
    End Sub
End Class

Public Class RandomEnemyGetter
    Public Shared Function GetRandomEnemy(rnd As Random) As Enemy
        Dim allEnemies As List(Of Enemy) = New List(Of Enemy) From {New SillyEnemy(), New SentryEnemy()}
        Return allEnemies(rnd.Next(0, allEnemies.Count))
    End Function
End Class

Public Class SentryEnemy
    Inherits Enemy

    Public Overrides Sub Setup()
        SetMaxHP(40)
        intentionList.Add(New ConfuseIntention(2))
        intentionList.Add(New AttackIntention(9))
    End Sub
End Class
