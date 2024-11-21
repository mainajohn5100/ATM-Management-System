Public Class frmWithdraw
    Private Sub btnConfirmWithdraw_Click(sender As Object, e As EventArgs) Handles btnConfirmWithdraw.Click
        Dim withdrawAmount As Decimal

        If Decimal.TryParse(txtWithdrawAmount.Text, withdrawAmount) AndAlso withdrawAmount > 0 Then
            If withdrawAmount <= currentBalance Then
                currentBalance -= withdrawAmount
                MessageBox.Show("Withdrawal Successful! New Balance: " & currentBalance.ToString("C"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Log transaction (to be implemented with database later)
            Else
                MessageBox.Show("Insufficient funds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainMenu As New frmMainMenu()
        Me.Hide()
        mainMenu.Show()
    End Sub


End Class