<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageEmployees
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtbxFirstName = New TextBox()
        lblFName = New Label()
        lblLName = New Label()
        txtbxLastName = New TextBox()
        lblUserName = New Label()
        txtbxUserName = New TextBox()
        lblEmail = New Label()
        txtbxEmail = New TextBox()
        chbxIsActive = New CheckBox()
        lblAccessLevel = New Label()
        dgvEmployee = New DataGridView()
        DatabaseConnectionBindingSource = New BindingSource(components)
        btnTestConnection = New Button()
        btnAdd = New Button()
        DatabaseConnectionBindingSource1 = New BindingSource(components)
        btnUpdate = New Button()
        lblID = New Label()
        txtbxID = New TextBox()
        cbxAccessLevel = New ComboBox()
        btnDone = New Button()
        btnBack = New Button()
        CType(dgvEmployee, ComponentModel.ISupportInitialize).BeginInit()
        CType(DatabaseConnectionBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(DatabaseConnectionBindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtbxFirstName
        ' 
        txtbxFirstName.Location = New Point(198, 55)
        txtbxFirstName.Name = "txtbxFirstName"
        txtbxFirstName.Size = New Size(272, 27)
        txtbxFirstName.TabIndex = 0
        ' 
        ' lblFName
        ' 
        lblFName.AutoSize = True
        lblFName.ForeColor = Color.Transparent
        lblFName.Location = New Point(78, 55)
        lblFName.Name = "lblFName"
        lblFName.Size = New Size(86, 20)
        lblFName.TabIndex = 1
        lblFName.Text = "First Name"
        ' 
        ' lblLName
        ' 
        lblLName.AutoSize = True
        lblLName.ForeColor = Color.Transparent
        lblLName.Location = New Point(78, 106)
        lblLName.Name = "lblLName"
        lblLName.Size = New Size(84, 20)
        lblLName.TabIndex = 3
        lblLName.Text = "Last Name"
        ' 
        ' txtbxLastName
        ' 
        txtbxLastName.Location = New Point(198, 106)
        txtbxLastName.Name = "txtbxLastName"
        txtbxLastName.Size = New Size(272, 27)
        txtbxLastName.TabIndex = 2
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.ForeColor = Color.Transparent
        lblUserName.Location = New Point(78, 157)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(87, 20)
        lblUserName.TabIndex = 5
        lblUserName.Text = "User Name"
        ' 
        ' txtbxUserName
        ' 
        txtbxUserName.Location = New Point(198, 157)
        txtbxUserName.Name = "txtbxUserName"
        txtbxUserName.Size = New Size(272, 27)
        txtbxUserName.TabIndex = 4
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = Color.Transparent
        lblEmail.Location = New Point(74, 209)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(47, 20)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email"
        ' 
        ' txtbxEmail
        ' 
        txtbxEmail.Location = New Point(195, 209)
        txtbxEmail.Name = "txtbxEmail"
        txtbxEmail.Size = New Size(272, 27)
        txtbxEmail.TabIndex = 6
        ' 
        ' chbxIsActive
        ' 
        chbxIsActive.AutoSize = True
        chbxIsActive.ForeColor = Color.Transparent
        chbxIsActive.Location = New Point(195, 242)
        chbxIsActive.Name = "chbxIsActive"
        chbxIsActive.Size = New Size(75, 24)
        chbxIsActive.TabIndex = 9
        chbxIsActive.Text = "Active"
        chbxIsActive.UseVisualStyleBackColor = True
        ' 
        ' lblAccessLevel
        ' 
        lblAccessLevel.AutoSize = True
        lblAccessLevel.ForeColor = Color.Transparent
        lblAccessLevel.Location = New Point(562, 55)
        lblAccessLevel.Name = "lblAccessLevel"
        lblAccessLevel.Size = New Size(96, 20)
        lblAccessLevel.TabIndex = 14
        lblAccessLevel.Text = "Access Level"
        ' 
        ' dgvEmployee
        ' 
        dgvEmployee.AllowUserToAddRows = False
        dgvEmployee.AllowUserToDeleteRows = False
        dgvEmployee.BackgroundColor = Color.FromArgb(CByte(204), CByte(204), CByte(204))
        dgvEmployee.BorderStyle = BorderStyle.Fixed3D
        dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmployee.Location = New Point(63, 289)
        dgvEmployee.Name = "dgvEmployee"
        dgvEmployee.ReadOnly = True
        dgvEmployee.RowHeadersWidth = 51
        dgvEmployee.RowTemplate.Height = 29
        dgvEmployee.Size = New Size(1001, 262)
        dgvEmployee.TabIndex = 16
        ' 
        ' DatabaseConnectionBindingSource
        ' 
        DatabaseConnectionBindingSource.DataSource = GetType(DatabaseConnection)
        ' 
        ' btnTestConnection
        ' 
        btnTestConnection.BackColor = Color.Silver
        btnTestConnection.ForeColor = Color.White
        btnTestConnection.Location = New Point(669, 97)
        btnTestConnection.Name = "btnTestConnection"
        btnTestConnection.Size = New Size(197, 29)
        btnTestConnection.TabIndex = 17
        btnTestConnection.Text = "TestConnection"
        btnTestConnection.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.FromArgb(CByte(0), CByte(255), CByte(200))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(669, 132)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(197, 29)
        btnAdd.TabIndex = 18
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' DatabaseConnectionBindingSource1
        ' 
        DatabaseConnectionBindingSource1.DataSource = GetType(DatabaseConnection)
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(255), CByte(107), CByte(107))
        btnUpdate.Location = New Point(669, 167)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(197, 29)
        btnUpdate.TabIndex = 19
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.ForeColor = Color.Transparent
        lblID.Location = New Point(78, 22)
        lblID.Name = "lblID"
        lblID.Size = New Size(25, 20)
        lblID.TabIndex = 21
        lblID.Text = "ID"
        ' 
        ' txtbxID
        ' 
        txtbxID.Enabled = False
        txtbxID.Location = New Point(198, 22)
        txtbxID.Name = "txtbxID"
        txtbxID.Size = New Size(272, 27)
        txtbxID.TabIndex = 20
        ' 
        ' cbxAccessLevel
        ' 
        cbxAccessLevel.FormattingEnabled = True
        cbxAccessLevel.Location = New Point(696, 54)
        cbxAccessLevel.Name = "cbxAccessLevel"
        cbxAccessLevel.Size = New Size(169, 28)
        cbxAccessLevel.TabIndex = 22
        ' 
        ' btnDone
        ' 
        btnDone.BackColor = Color.AntiqueWhite
        btnDone.BackgroundImageLayout = ImageLayout.None
        btnDone.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        btnDone.FlatAppearance.BorderSize = 0
        btnDone.FlatStyle = FlatStyle.Popup
        btnDone.ForeColor = Color.Crimson
        btnDone.Location = New Point(669, 202)
        btnDone.Margin = New Padding(0)
        btnDone.Name = "btnDone"
        btnDone.Size = New Size(197, 29)
        btnDone.TabIndex = 23
        btnDone.Text = "Done"
        btnDone.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.AntiqueWhite
        btnBack.BackgroundImageLayout = ImageLayout.None
        btnBack.FlatAppearance.BorderColor = SystemColors.ControlDarkDark
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Popup
        btnBack.ForeColor = Color.Crimson
        btnBack.Location = New Point(1031, 13)
        btnBack.Margin = New Padding(0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(82, 29)
        btnBack.TabIndex = 24
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' ManageEmployees
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(1122, 739)
        Controls.Add(btnBack)
        Controls.Add(btnDone)
        Controls.Add(cbxAccessLevel)
        Controls.Add(lblID)
        Controls.Add(txtbxID)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(btnTestConnection)
        Controls.Add(dgvEmployee)
        Controls.Add(lblAccessLevel)
        Controls.Add(chbxIsActive)
        Controls.Add(lblEmail)
        Controls.Add(txtbxEmail)
        Controls.Add(lblUserName)
        Controls.Add(txtbxUserName)
        Controls.Add(lblLName)
        Controls.Add(txtbxLastName)
        Controls.Add(lblFName)
        Controls.Add(txtbxFirstName)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.Black
        Name = "ManageEmployees"
        Text = "Manage Employees"
        CType(dgvEmployee, ComponentModel.ISupportInitialize).EndInit()
        CType(DatabaseConnectionBindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(DatabaseConnectionBindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbxFirstName As TextBox
    Friend WithEvents lblFName As Label
    Friend WithEvents lblLName As Label
    Friend WithEvents txtbxLastName As TextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents txtbxUserName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents chbxIsActive As CheckBox
    Friend WithEvents lblAccessLevel As Label
    Friend WithEvents dgvEmployee As DataGridView
    Friend WithEvents btnTestConnection As Button
    Friend WithEvents DatabaseConnectionBindingSource As BindingSource
    Friend WithEvents btnAdd As Button
    Friend WithEvents DatabaseConnectionBindingSource1 As BindingSource
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblID As Label
    Friend WithEvents txtbxID As TextBox
    Friend WithEvents cbxAccessLevel As ComboBox
    Friend WithEvents btnDone As Button
    Friend WithEvents btnBack As Button
End Class
