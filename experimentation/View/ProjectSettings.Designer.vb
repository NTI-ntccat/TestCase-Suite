<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectSettings
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
        txtbxProjCode = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtbxProjName = New TextBox()
        btnAdd = New Button()
        btnAddEmployees = New Button()
        SuspendLayout()
        ' 
        ' txtbxProjCode
        ' 
        txtbxProjCode.Location = New Point(192, 55)
        txtbxProjCode.Name = "txtbxProjCode"
        txtbxProjCode.Size = New Size(150, 27)
        txtbxProjCode.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(92, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 1
        Label1.Text = "Project Code"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 3
        Label2.Text = "Project Name"
        ' 
        ' txtbxProjName
        ' 
        txtbxProjName.Location = New Point(192, 88)
        txtbxProjName.Name = "txtbxProjName"
        txtbxProjName.Size = New Size(150, 27)
        txtbxProjName.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(97, 121)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnAddEmployees
        ' 
        btnAddEmployees.Location = New Point(197, 121)
        btnAddEmployees.Name = "btnAddEmployees"
        btnAddEmployees.Size = New Size(145, 29)
        btnAddEmployees.TabIndex = 5
        btnAddEmployees.Text = "Add Employees"
        btnAddEmployees.UseVisualStyleBackColor = True
        ' 
        ' ProjectSettings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(408, 200)
        Controls.Add(btnAddEmployees)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(txtbxProjName)
        Controls.Add(Label1)
        Controls.Add(txtbxProjCode)
        Name = "ProjectSettings"
        Text = "ProjectSettings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbxProjCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbxProjName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddEmployees As Button
End Class
