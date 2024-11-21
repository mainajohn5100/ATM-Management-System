<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblWelcome = New Label()
        btnBalance = New Button()
        btnWithdraw = New Button()
        btnDeposit = New Button()
        btnMiniStatement = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(323, 39)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(199, 20)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome to the ATM System"
        ' 
        ' btnBalance
        ' 
        btnBalance.Location = New Point(275, 130)
        btnBalance.Name = "btnBalance"
        btnBalance.Size = New Size(94, 29)
        btnBalance.TabIndex = 1
        btnBalance.Text = "Balance Inquiry"
        btnBalance.UseVisualStyleBackColor = True
        ' 
        ' btnWithdraw
        ' 
        btnWithdraw.Location = New Point(275, 204)
        btnWithdraw.Name = "btnWithdraw"
        btnWithdraw.Size = New Size(94, 29)
        btnWithdraw.TabIndex = 2
        btnWithdraw.Text = "Withdraw"
        btnWithdraw.UseVisualStyleBackColor = True
        ' 
        ' btnDeposit
        ' 
        btnDeposit.Location = New Point(492, 130)
        btnDeposit.Name = "btnDeposit"
        btnDeposit.Size = New Size(94, 29)
        btnDeposit.TabIndex = 3
        btnDeposit.Text = "Deposit"
        btnDeposit.UseVisualStyleBackColor = True
        ' 
        ' btnMiniStatement
        ' 
        btnMiniStatement.Location = New Point(492, 204)
        btnMiniStatement.Name = "btnMiniStatement"
        btnMiniStatement.Size = New Size(129, 29)
        btnMiniStatement.TabIndex = 4
        btnMiniStatement.Text = "Mini Statement"
        btnMiniStatement.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(389, 277)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnMiniStatement)
        Controls.Add(btnDeposit)
        Controls.Add(btnWithdraw)
        Controls.Add(btnBalance)
        Controls.Add(lblWelcome)
        Name = "frmMainMenu"
        Text = "Main Screen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnBalance As Button
    Friend WithEvents btnWithdraw As Button
    Friend WithEvents btnDeposit As Button
    Friend WithEvents btnMiniStatement As Button
    Friend WithEvents btnExit As Button
End Class
