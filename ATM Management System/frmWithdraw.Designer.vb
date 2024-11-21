<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWithdraw
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
        lblAmount = New Label()
        txtWithdrawAmount = New TextBox()
        btnConfirmWithdraw = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(229, 131)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(189, 20)
        lblAmount.TabIndex = 0
        lblAmount.Text = "Enter Amount to Withdraw:"
        ' 
        ' txtWithdrawAmount
        ' 
        txtWithdrawAmount.Location = New Point(435, 131)
        txtWithdrawAmount.Name = "txtWithdrawAmount"
        txtWithdrawAmount.Size = New Size(162, 27)
        txtWithdrawAmount.TabIndex = 1
        ' 
        ' btnConfirmWithdraw
        ' 
        btnConfirmWithdraw.Location = New Point(311, 218)
        btnConfirmWithdraw.Name = "btnConfirmWithdraw"
        btnConfirmWithdraw.Size = New Size(94, 29)
        btnConfirmWithdraw.TabIndex = 2
        btnConfirmWithdraw.Text = "Confirm"
        btnConfirmWithdraw.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(450, 218)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 3
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmWithdraw
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnConfirmWithdraw)
        Controls.Add(txtWithdrawAmount)
        Controls.Add(lblAmount)
        Name = "frmWithdraw"
        Text = "Withdrawal Screen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents txtWithdrawAmount As TextBox
    Friend WithEvents btnConfirmWithdraw As Button
    Friend WithEvents btnBack As Button
End Class
