Public Class frmBalanceInquiry
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainMenu As New frmMainMenu()
        Me.Hide()
        mainMenu.Show()
    End Sub

End Class