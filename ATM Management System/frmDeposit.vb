Public Class frmDeposit
    Private Sub btnConfirmDeposit_Click(sender As Object, e As EventArgs) Handles btnConfirmDeposit.Click
        Dim depositAmount As Decimal

        If Decimal.TryParse(txtDepositAmount.Text, depositAmount) AndAlso depositAmount > 0 Then
            currentBalance += depositAmount
            MessageBox.Show("Deposit Successful! New Balance: " & currentBalance.ToString("C"), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Log transaction (to be implemented with database later)
        Else
            MessageBox.Show("Enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim mainMenu As New frmMainMenu()
        Me.Hide()
        mainMenu.Show()
    End Sub

    Private Sub frmDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class