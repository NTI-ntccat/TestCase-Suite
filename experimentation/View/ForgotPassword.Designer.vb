<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        lblCurrentPassword = New Label()
        txtbxCurrentPassword = New TextBox()
        txtbxNewPassword = New TextBox()
        lblNewPassword = New Label()
        txtbxConfirmPassword = New TextBox()
        lblConfirmPassword = New Label()
        btnConfirm = New Button()
        btnCancel = New Button()
        txtbxUserName = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblCurrentPassword
        ' 
        lblCurrentPassword.AutoSize = True
        lblCurrentPassword.Location = New Point(38, 67)
        lblCurrentPassword.Name = "lblCurrentPassword"
        lblCurrentPassword.Size = New Size(122, 20)
        lblCurrentPassword.TabIndex = 0
        lblCurrentPassword.Text = "Current Password"
        ' 
        ' txtbxCurrentPassword
        ' 
        txtbxCurrentPassword.Location = New Point(166, 64)
        txtbxCurrentPassword.Name = "txtbxCurrentPassword"
        txtbxCurrentPassword.PasswordChar = "*"c
        txtbxCurrentPassword.Size = New Size(233, 27)
        txtbxCurrentPassword.TabIndex = 1
        ' 
        ' txtbxNewPassword
        ' 
        txtbxNewPassword.Location = New Point(166, 97)
        txtbxNewPassword.Name = "txtbxNewPassword"
        txtbxNewPassword.PasswordChar = "*"c
        txtbxNewPassword.Size = New Size(233, 27)
        txtbxNewPassword.TabIndex = 3
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Location = New Point(38, 100)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(104, 20)
        lblNewPassword.TabIndex = 2
        lblNewPassword.Text = "New Password"
        ' 
        ' txtbxConfirmPassword
        ' 
        txtbxConfirmPassword.Location = New Point(166, 130)
        txtbxConfirmPassword.Name = "txtbxConfirmPassword"
        txtbxConfirmPassword.PasswordChar = "*"c
        txtbxConfirmPassword.Size = New Size(233, 27)
        txtbxConfirmPassword.TabIndex = 5
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Location = New Point(38, 133)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(127, 20)
        lblConfirmPassword.TabIndex = 4
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' btnConfirm
        ' 
        btnConfirm.Location = New Point(132, 163)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(94, 29)
        btnConfirm.TabIndex = 6
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(277, 163)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(94, 29)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtbxUserName
        ' 
        txtbxUserName.Location = New Point(166, 31)
        txtbxUserName.Name = "txtbxUserName"
        txtbxUserName.Size = New Size(233, 27)
        txtbxUserName.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(38, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 8
        Label1.Text = "User Name"
        ' 
        ' ForgotPassword
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(467, 226)
        Controls.Add(txtbxUserName)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(txtbxConfirmPassword)
        Controls.Add(lblConfirmPassword)
        Controls.Add(txtbxNewPassword)
        Controls.Add(lblNewPassword)
        Controls.Add(txtbxCurrentPassword)
        Controls.Add(lblCurrentPassword)
        Name = "ForgotPassword"
        Text = "ForgotPassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents txtbxCurrentPassword As TextBox
    Friend WithEvents txtbxNewPassword As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtbxConfirmPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtbxUserName As TextBox
    Friend WithEvents Label1 As Label
End Class
