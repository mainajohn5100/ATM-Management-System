Public Class frmMainMenu
    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        Dim balanceForm As New frmBalanceInquiry()
        balanceForm.txtBalance.Text = currentBalance.ToString("C") ' Format as currency
        Me.Hide()
        balanceForm.Show()
    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click
        Dim withdrawForm As New frmWithdraw()
        Me.Hide()
        withdrawForm.Show()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim depositForm As New frmDeposit()
        Me.Hide()
        depositForm.Show()
    End Sub

    Private Sub btnMiniStatement_Click(sender As Object, e As EventArgs) Handles btnMiniStatement.Click
        Dim miniStatementForm As New frmMiniStatement()
        Me.Hide()
        miniStatementForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


End Class