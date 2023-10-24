<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestCaseCreation
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
        dgvTestCase = New DataGridView()
        btnSave = New Button()
        btnClose = New Button()
        lblTestCaseName = New Label()
        txtbxTestCaseName = New TextBox()
        txtbxSprint = New TextBox()
        lblSprint = New Label()
        lblTemplate = New Label()
        cbxTemplate = New ComboBox()
        btnExport = New Button()
        txtbxJiraTicketNumber = New TextBox()
        lblJiraTicketNumber = New Label()
        txtbxProject = New TextBox()
        lblProject = New Label()
        btnImport = New Button()
        CType(dgvTestCase, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvTestCase
        ' 
        dgvTestCase.BorderStyle = BorderStyle.Fixed3D
        dgvTestCase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTestCase.Location = New Point(12, 169)
        dgvTestCase.Name = "dgvTestCase"
        dgvTestCase.RowHeadersWidth = 51
        dgvTestCase.RowTemplate.Height = 29
        dgvTestCase.Size = New Size(984, 315)
        dgvTestCase.TabIndex = 0
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(195, 502)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(335, 502)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(94, 29)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' lblTestCaseName
        ' 
        lblTestCaseName.AutoSize = True
        lblTestCaseName.Location = New Point(37, 21)
        lblTestCaseName.Name = "lblTestCaseName"
        lblTestCaseName.Size = New Size(110, 20)
        lblTestCaseName.TabIndex = 3
        lblTestCaseName.Text = "TestCase Name"
        ' 
        ' txtbxTestCaseName
        ' 
        txtbxTestCaseName.Location = New Point(153, 21)
        txtbxTestCaseName.Name = "txtbxTestCaseName"
        txtbxTestCaseName.Size = New Size(228, 27)
        txtbxTestCaseName.TabIndex = 4
        ' 
        ' txtbxSprint
        ' 
        txtbxSprint.Location = New Point(153, 54)
        txtbxSprint.Name = "txtbxSprint"
        txtbxSprint.Size = New Size(228, 27)
        txtbxSprint.TabIndex = 6
        ' 
        ' lblSprint
        ' 
        lblSprint.AutoSize = True
        lblSprint.Location = New Point(37, 54)
        lblSprint.Name = "lblSprint"
        lblSprint.Size = New Size(48, 20)
        lblSprint.TabIndex = 5
        lblSprint.Text = "Sprint"
        ' 
        ' lblTemplate
        ' 
        lblTemplate.AutoSize = True
        lblTemplate.Location = New Point(598, 21)
        lblTemplate.Name = "lblTemplate"
        lblTemplate.Size = New Size(71, 20)
        lblTemplate.TabIndex = 7
        lblTemplate.Text = "Template"
        ' 
        ' cbxTemplate
        ' 
        cbxTemplate.FormattingEnabled = True
        cbxTemplate.Location = New Point(675, 18)
        cbxTemplate.Name = "cbxTemplate"
        cbxTemplate.Size = New Size(321, 28)
        cbxTemplate.TabIndex = 8
        ' 
        ' btnExport
        ' 
        btnExport.Location = New Point(493, 502)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(94, 29)
        btnExport.TabIndex = 9
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' txtbxJiraTicketNumber
        ' 
        txtbxJiraTicketNumber.Location = New Point(153, 87)
        txtbxJiraTicketNumber.Name = "txtbxJiraTicketNumber"
        txtbxJiraTicketNumber.Size = New Size(228, 27)
        txtbxJiraTicketNumber.TabIndex = 11
        ' 
        ' lblJiraTicketNumber
        ' 
        lblJiraTicketNumber.AutoSize = True
        lblJiraTicketNumber.Location = New Point(37, 87)
        lblJiraTicketNumber.Name = "lblJiraTicketNumber"
        lblJiraTicketNumber.Size = New Size(101, 20)
        lblJiraTicketNumber.TabIndex = 10
        lblJiraTicketNumber.Text = "Jira Ticket No."
        ' 
        ' txtbxProject
        ' 
        txtbxProject.Location = New Point(675, 52)
        txtbxProject.Name = "txtbxProject"
        txtbxProject.Size = New Size(321, 27)
        txtbxProject.TabIndex = 13
        ' 
        ' lblProject
        ' 
        lblProject.AutoSize = True
        lblProject.Location = New Point(598, 54)
        lblProject.Name = "lblProject"
        lblProject.Size = New Size(55, 20)
        lblProject.TabIndex = 12
        lblProject.Text = "Project"
        ' 
        ' btnImport
        ' 
        btnImport.Location = New Point(638, 502)
        btnImport.Name = "btnImport"
        btnImport.Size = New Size(94, 29)
        btnImport.TabIndex = 14
        btnImport.Text = "Import"
        btnImport.UseVisualStyleBackColor = True
        ' 
        ' TestCaseCreation
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1008, 551)
        Controls.Add(btnImport)
        Controls.Add(txtbxProject)
        Controls.Add(lblProject)
        Controls.Add(txtbxJiraTicketNumber)
        Controls.Add(lblJiraTicketNumber)
        Controls.Add(btnExport)
        Controls.Add(cbxTemplate)
        Controls.Add(lblTemplate)
        Controls.Add(txtbxSprint)
        Controls.Add(lblSprint)
        Controls.Add(txtbxTestCaseName)
        Controls.Add(lblTestCaseName)
        Controls.Add(btnClose)
        Controls.Add(btnSave)
        Controls.Add(dgvTestCase)
        Name = "TestCaseCreation"
        Text = "TestCaseCreation"
        CType(dgvTestCase, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvTestCase As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblTestCaseName As Label
    Friend WithEvents txtbxTestCaseName As TextBox
    Friend WithEvents txtbxSprint As TextBox
    Friend WithEvents lblSprint As Label
    Friend WithEvents lblTemplate As Label
    Friend WithEvents cbxTemplate As ComboBox
    Friend WithEvents btnExport As Button
    Friend WithEvents txtbxJiraTicketNumber As TextBox
    Friend WithEvents lblJiraTicketNumber As Label
    Friend WithEvents txtbxProject As TextBox
    Friend WithEvents lblProject As Label
    Friend WithEvents btnImport As Button
End Class
