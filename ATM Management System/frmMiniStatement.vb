Public Class frmMiniStatement
    Private Sub frmMiniStatement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mock data for transactions
        lvwMiniStatement.Items.Clear()
        lvwMiniStatement.Items.Add(New ListViewItem({"01/01/2024", "Deposit", "500"}))
        lvwMiniStatement.Items.Add(New ListViewItem({"02/01/2024", "Withdrawal", "200"}))
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainMenu As New frmMainMenu()
        Me.Hide()
        mainMenu.Show()
    End Sub

    Private Sub lvwMiniStatement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwMiniStatement.SelectedIndexChanged

    End Sub
End Class