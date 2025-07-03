Imports System.ComponentModel

Public Class Menu
    Dim fightOpen As Boolean = False
    Private Sub StartGame(sender As Object, e As EventArgs) Handles Button1.Click
        If Not fightOpen Then
            Dim fightForm As FrmWebWarriors = New FrmWebWarriors()
            AddHandler fightForm.FormClosed, AddressOf FightFormClosed
            fightForm.Show()
            fightOpen = True
        End If
    End Sub

    Private Sub FightFormClosed(sender As FrmWebWarriors, e As EventArgs)
        fightOpen = False
    End Sub
End Class