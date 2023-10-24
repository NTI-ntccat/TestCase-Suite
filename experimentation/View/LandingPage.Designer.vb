<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LandingPage
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
        btnManageEmployees = New Button()
        btnaddProj = New Button()
        btnSearch = New Button()
        btnCreateTestCase = New Button()
        SuspendLayout()
        ' 
        ' btnManageEmployees
        ' 
        btnManageEmployees.Location = New Point(132, 69)
        btnManageEmployees.Name = "btnManageEmployees"
        btnManageEmployees.Size = New Size(151, 29)
        btnManageEmployees.TabIndex = 0
        btnManageEmployees.Text = "ManageEmployees"
        btnManageEmployees.UseVisualStyleBackColor = True
        ' 
        ' btnaddProj
        ' 
        btnaddProj.Location = New Point(132, 104)
        btnaddProj.Name = "btnaddProj"
        btnaddProj.Size = New Size(151, 29)
        btnaddProj.TabIndex = 1
        btnaddProj.Text = "Add Project"
        btnaddProj.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(132, 139)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(151, 29)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnCreateTestCase
        ' 
        btnCreateTestCase.Location = New Point(132, 174)
        btnCreateTestCase.Name = "btnCreateTestCase"
        btnCreateTestCase.Size = New Size(151, 29)
        btnCreateTestCase.TabIndex = 3
        btnCreateTestCase.Text = "Create Test Case"
        btnCreateTestCase.UseVisualStyleBackColor = True
        ' 
        ' LandingPage
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(428, 299)
        Controls.Add(btnCreateTestCase)
        Controls.Add(btnSearch)
        Controls.Add(btnaddProj)
        Controls.Add(btnManageEmployees)
        Name = "LandingPage"
        Text = "LandingPage"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnManageEmployees As Button
    Friend WithEvents btnaddProj As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCreateTestCase As Button
End Class
