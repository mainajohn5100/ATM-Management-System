<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeposit
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
        txtDepositAmount = New TextBox()
        btnConfirmDeposit = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(218, 144)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(177, 20)
        lblAmount.TabIndex = 0
        lblAmount.Text = "Enter Amount to Deposit:"
        ' 
        ' txtDepositAmount
        ' 
        txtDepositAmount.Location = New Point(424, 144)
        txtDepositAmount.Name = "txtDepositAmount"
        txtDepositAmount.Size = New Size(170, 27)
        txtDepositAmount.TabIndex = 1
        ' 
        ' btnConfirmDeposit
        ' 
        btnConfirmDeposit.Location = New Point(301, 230)
        btnConfirmDeposit.Name = "btnConfirmDeposit"
        btnConfirmDeposit.Size = New Size(94, 29)
        btnConfirmDeposit.TabIndex = 2
        btnConfirmDeposit.Text = "Confirm"
        btnConfirmDeposit.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(439, 230)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 3
        btnBack.Text = "Back "
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmDeposit
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(btnConfirmDeposit)
        Controls.Add(txtDepositAmount)
        Controls.Add(lblAmount)
        Name = "frmDeposit"
        Text = "Deposit Screen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents txtDepositAmount As TextBox
    Friend WithEvents btnConfirmDeposit As Button
    Friend WithEvents btnBack As Button
End Class
