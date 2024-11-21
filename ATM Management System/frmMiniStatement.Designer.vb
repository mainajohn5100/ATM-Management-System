<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiniStatement
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
        lvwMiniStatement = New ListView()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lvwMiniStatement
        ' 
        lvwMiniStatement.Location = New Point(25, 12)
        lvwMiniStatement.Name = "lvwMiniStatement"
        lvwMiniStatement.Size = New Size(745, 391)
        lvwMiniStatement.TabIndex = 0
        lvwMiniStatement.UseCompatibleStateImageBehavior = False
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(340, 409)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 1
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmMiniStatement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnBack)
        Controls.Add(lvwMiniStatement)
        Name = "frmMiniStatement"
        Text = "Mini Statement"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lvwMiniStatement As ListView
    Friend WithEvents btnBack As Button
End Class
