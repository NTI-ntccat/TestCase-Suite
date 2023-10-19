<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        lblUserName = New Label()
        txtbxUserName = New TextBox()
        txtbxPassword = New TextBox()
        lblPassword = New Label()
        btnLogin = New Button()
        btnPasswordReset = New Button()
        cbxProject = New ComboBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Location = New Point(44, 45)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(78, 20)
        lblUserName.TabIndex = 0
        lblUserName.Text = "UserName"
        ' 
        ' txtbxUserName
        ' 
        txtbxUserName.Location = New Point(128, 42)
        txtbxUserName.Name = "txtbxUserName"
        txtbxUserName.Size = New Size(159, 27)
        txtbxUserName.TabIndex = 1
        ' 
        ' txtbxPassword
        ' 
        txtbxPassword.Location = New Point(128, 75)
        txtbxPassword.Name = "txtbxPassword"
        txtbxPassword.PasswordChar = "*"c
        txtbxPassword.Size = New Size(159, 27)
        txtbxPassword.TabIndex = 3
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Location = New Point(44, 78)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(70, 20)
        lblPassword.TabIndex = 2
        lblPassword.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(44, 156)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Log-In"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnPasswordReset
        ' 
        btnPasswordReset.Location = New Point(163, 156)
        btnPasswordReset.Name = "btnPasswordReset"
        btnPasswordReset.Size = New Size(128, 29)
        btnPasswordReset.TabIndex = 5
        btnPasswordReset.Text = "Password Reset"
        btnPasswordReset.UseVisualStyleBackColor = True
        ' 
        ' cbxProject
        ' 
        cbxProject.FormattingEnabled = True
        cbxProject.Location = New Point(128, 108)
        cbxProject.Name = "cbxProject"
        cbxProject.Size = New Size(159, 28)
        cbxProject.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 7
        Label1.Text = "Project"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(344, 245)
        Controls.Add(Label1)
        Controls.Add(cbxProject)
        Controls.Add(btnPasswordReset)
        Controls.Add(btnLogin)
        Controls.Add(txtbxPassword)
        Controls.Add(lblPassword)
        Controls.Add(txtbxUserName)
        Controls.Add(lblUserName)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents txtbxUserName As TextBox
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnPasswordReset As Button
    Friend WithEvents cbxProject As ComboBox
    Friend WithEvents Label1 As Label
End Class
