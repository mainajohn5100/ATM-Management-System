<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblAccountNumber = New Label()
        lblPIN = New Label()
        txtAccountNumber = New TextBox()
        txtPIN = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblAccountNumber
        ' 
        lblAccountNumber.AutoSize = True
        lblAccountNumber.Location = New Point(374, 161)
        lblAccountNumber.Name = "lblAccountNumber"
        lblAccountNumber.Size = New Size(121, 20)
        lblAccountNumber.TabIndex = 0
        lblAccountNumber.Text = "Account Number"
        ' 
        ' lblPIN
        ' 
        lblPIN.AutoSize = True
        lblPIN.Location = New Point(463, 217)
        lblPIN.Name = "lblPIN"
        lblPIN.Size = New Size(32, 20)
        lblPIN.TabIndex = 1
        lblPIN.Text = "PIN"
        ' 
        ' txtAccountNumber
        ' 
        txtAccountNumber.Location = New Point(565, 161)
        txtAccountNumber.Name = "txtAccountNumber"
        txtAccountNumber.Size = New Size(178, 27)
        txtAccountNumber.TabIndex = 2
        ' 
        ' txtPIN
        ' 
        txtPIN.Location = New Point(565, 217)
        txtPIN.Name = "txtPIN"
        txtPIN.PasswordChar = "*"c
        txtPIN.Size = New Size(178, 27)
        txtPIN.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(401, 325)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(565, 325)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(417, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 20)
        Label1.TabIndex = 6
        Label1.Text = "ATM MANAGEMENT SYSTEM"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(990, 546)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(txtPIN)
        Controls.Add(txtAccountNumber)
        Controls.Add(lblPIN)
        Controls.Add(lblAccountNumber)
        Name = "frmLogin"
        Text = "Login Screen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblPIN As Label
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label

End Class
