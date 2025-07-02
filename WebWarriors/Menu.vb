Public Class Menu
    Dim fightOpen As Boolean = False
    Private Sub StartGame(sender As Object, e As EventArgs) Handles Button1.Click
        If Not fightOpen Then
            Dim fightForm As FrmWebWarriors = New FrmWebWarriors()
            fightForm.Show()
            fightOpen = True
        End If
    End Sub
End Class