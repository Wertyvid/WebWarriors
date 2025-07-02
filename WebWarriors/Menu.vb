Public Class Menu
    Private Sub StartGame(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fightForm As FrmWebWarriors = New FrmWebWarriors()
        fightForm.Show()
    End Sub
End Class