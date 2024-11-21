<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceInquiry
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
        lblBalance = New Label()
        txtBalance = New TextBox()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblBalance
        ' 
        lblBalance.AutoSize = True
        lblBalance.Location = New Point(295, 133)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(111, 20)
        lblBalance.TabIndex = 0
        lblBalance.Text = "Your Balance is:"
        ' 
        ' txtBalance
        ' 
        txtBalance.Location = New Point(424, 133)
        txtBalance.Name = "txtBalance"
        txtBalance.ReadOnly = True
        txtBalance.Size = New Size(167, 27)
        txtBalance.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(355, 253)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(156, 29)
        btnBack.TabIndex = 2
        btnBack.Text = "Back to Main Screen"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmBalanceInquiry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(txtBalance)
        Controls.Add(lblBalance)
        Name = "frmBalanceInquiry"
        Text = "Balance Inquiry"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBalance As Label
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents btnBack As Button
End Class
