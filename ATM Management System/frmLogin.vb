Imports System.Data.SQLite

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim accountNumber As String = txtAccountNumber.Text
        Dim pin As String = txtPIN.Text

        ' Mock database lookup (replace with actual database query later)
        If accountNumber = "12345" And pin = "1234" Then
            ' Successful login
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim mainMenu As New frmMainMenu()
            Me.Hide()
            mainMenu.Show()
        Else
            ' Failed login
            MessageBox.Show("Invalid Account Number or PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
