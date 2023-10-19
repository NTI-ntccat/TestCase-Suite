<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestCaseTemplate
    Inherits System.Windows.Forms.Form

    ' ... Other form elements and code ...

    ' Define checkboxes for the listed items
    Friend WithEvents CheckBoxTestID As CheckBox
    Friend WithEvents CheckBoxSummary As CheckBox
    Friend WithEvents CheckBoxTestType As CheckBox
    Friend WithEvents CheckBoxPriority As CheckBox
    Friend WithEvents CheckBoxComponent As CheckBox
    Friend WithEvents CheckBoxDescription As CheckBox
    Friend WithEvents CheckBoxPreCondition As CheckBox
    Friend WithEvents CheckBoxStep As CheckBox
    Friend WithEvents CheckBoxAction As CheckBox
    Friend WithEvents CheckBoxData As CheckBox
    Friend WithEvents CheckBoxExpectedResult As CheckBox
    Friend WithEvents CheckBoxActualResult As CheckBox
    Friend WithEvents CheckBoxRegressionCandidate As CheckBox
    Friend WithEvents CheckBoxTimeTravel As CheckBox
    Friend WithEvents CheckBoxBusinessComments As CheckBox

    ' In the InitializeComponent method, add the checkboxes and set their properties
    Private Sub InitializeComponent()
        CheckBoxTestID = New CheckBox()
        CheckBoxSummary = New CheckBox()
        CheckBoxTestType = New CheckBox()
        CheckBoxPriority = New CheckBox()
        CheckBoxComponent = New CheckBox()
        CheckBoxDescription = New CheckBox()
        CheckBoxPreCondition = New CheckBox()
        CheckBoxStep = New CheckBox()
        CheckBoxAction = New CheckBox()
        CheckBoxData = New CheckBox()
        CheckBoxExpectedResult = New CheckBox()
        CheckBoxActualResult = New CheckBox()
        CheckBoxRegressionCandidate = New CheckBox()
        CheckBoxTimeTravel = New CheckBox()
        CheckBoxBusinessComments = New CheckBox()
        SaveTmp = New Button()
        SuspendLayout()
        ' 
        ' CheckBoxTestID
        ' 
        CheckBoxTestID.AutoSize = True
        CheckBoxTestID.Location = New Point(25, 23)
        CheckBoxTestID.Name = "CheckBoxTestID"
        CheckBoxTestID.Size = New Size(60, 19)
        CheckBoxTestID.TabIndex = 0
        CheckBoxTestID.Text = "Test ID"
        ' 
        ' CheckBoxSummary
        ' 
        CheckBoxSummary.AutoSize = True
        CheckBoxSummary.Location = New Point(25, 43)
        CheckBoxSummary.Name = "CheckBoxSummary"
        CheckBoxSummary.Size = New Size(77, 19)
        CheckBoxSummary.TabIndex = 1
        CheckBoxSummary.Text = "Summary"
        ' 
        ' CheckBoxTestType
        ' 
        CheckBoxTestType.AutoSize = True
        CheckBoxTestType.Location = New Point(25, 63)
        CheckBoxTestType.Name = "CheckBoxTestType"
        CheckBoxTestType.Size = New Size(73, 19)
        CheckBoxTestType.TabIndex = 2
        CheckBoxTestType.Text = "Test Type"
        ' 
        ' CheckBoxPriority
        ' 
        CheckBoxPriority.AutoSize = True
        CheckBoxPriority.Location = New Point(25, 83)
        CheckBoxPriority.Name = "CheckBoxPriority"
        CheckBoxPriority.Size = New Size(64, 19)
        CheckBoxPriority.TabIndex = 3
        CheckBoxPriority.Text = "Priority"
        ' 
        ' CheckBoxComponent
        ' 
        CheckBoxComponent.AutoSize = True
        CheckBoxComponent.Location = New Point(25, 103)
        CheckBoxComponent.Name = "CheckBoxComponent"
        CheckBoxComponent.Size = New Size(90, 19)
        CheckBoxComponent.TabIndex = 4
        CheckBoxComponent.Text = "Component"
        ' 
        ' CheckBoxDescription
        ' 
        CheckBoxDescription.AutoSize = True
        CheckBoxDescription.Location = New Point(25, 123)
        CheckBoxDescription.Name = "CheckBoxDescription"
        CheckBoxDescription.Size = New Size(86, 19)
        CheckBoxDescription.TabIndex = 5
        CheckBoxDescription.Text = "Description"
        ' 
        ' CheckBoxPreCondition
        ' 
        CheckBoxPreCondition.AutoSize = True
        CheckBoxPreCondition.Location = New Point(25, 143)
        CheckBoxPreCondition.Name = "CheckBoxPreCondition"
        CheckBoxPreCondition.Size = New Size(99, 19)
        CheckBoxPreCondition.TabIndex = 6
        CheckBoxPreCondition.Text = "Pre-condition"
        ' 
        ' CheckBoxStep
        ' 
        CheckBoxStep.AutoSize = True
        CheckBoxStep.Location = New Point(25, 163)
        CheckBoxStep.Name = "CheckBoxStep"
        CheckBoxStep.Size = New Size(59, 19)
        CheckBoxStep.TabIndex = 7
        CheckBoxStep.Text = "Step #"
        ' 
        ' CheckBoxAction
        ' 
        CheckBoxAction.AutoSize = True
        CheckBoxAction.Location = New Point(25, 183)
        CheckBoxAction.Name = "CheckBoxAction"
        CheckBoxAction.Size = New Size(61, 19)
        CheckBoxAction.TabIndex = 8
        CheckBoxAction.Text = "Action"
        ' 
        ' CheckBoxData
        ' 
        CheckBoxData.AutoSize = True
        CheckBoxData.Location = New Point(25, 203)
        CheckBoxData.Name = "CheckBoxData"
        CheckBoxData.Size = New Size(50, 19)
        CheckBoxData.TabIndex = 9
        CheckBoxData.Text = "Data"
        ' 
        ' CheckBoxExpectedResult
        ' 
        CheckBoxExpectedResult.AutoSize = True
        CheckBoxExpectedResult.Location = New Point(25, 223)
        CheckBoxExpectedResult.Name = "CheckBoxExpectedResult"
        CheckBoxExpectedResult.Size = New Size(109, 19)
        CheckBoxExpectedResult.TabIndex = 10
        CheckBoxExpectedResult.Text = "Expected Result"
        ' 
        ' CheckBoxActualResult
        ' 
        CheckBoxActualResult.AutoSize = True
        CheckBoxActualResult.Location = New Point(25, 243)
        CheckBoxActualResult.Name = "CheckBoxActualResult"
        CheckBoxActualResult.Size = New Size(95, 19)
        CheckBoxActualResult.TabIndex = 11
        CheckBoxActualResult.Text = "Actual Result"
        ' 
        ' CheckBoxRegressionCandidate
        ' 
        CheckBoxRegressionCandidate.AutoSize = True
        CheckBoxRegressionCandidate.Location = New Point(25, 263)
        CheckBoxRegressionCandidate.Name = "CheckBoxRegressionCandidate"
        CheckBoxRegressionCandidate.Size = New Size(193, 19)
        CheckBoxRegressionCandidate.TabIndex = 12
        CheckBoxRegressionCandidate.Text = "Regression Candidate (YES/NO)"
        ' 
        ' CheckBoxTimeTravel
        ' 
        CheckBoxTimeTravel.AutoSize = True
        CheckBoxTimeTravel.Location = New Point(25, 283)
        CheckBoxTimeTravel.Name = "CheckBoxTimeTravel"
        CheckBoxTimeTravel.Size = New Size(132, 19)
        CheckBoxTimeTravel.TabIndex = 13
        CheckBoxTimeTravel.Text = "Time Travel (yes/no)"
        ' 
        ' CheckBoxBusinessComments
        ' 
        CheckBoxBusinessComments.AutoSize = True
        CheckBoxBusinessComments.Location = New Point(25, 303)
        CheckBoxBusinessComments.Name = "CheckBoxBusinessComments"
        CheckBoxBusinessComments.Size = New Size(188, 19)
        CheckBoxBusinessComments.TabIndex = 14
        CheckBoxBusinessComments.Text = "Business Comments (optional)"
        ' 
        ' SaveTmp
        ' 
        SaveTmp.Location = New Point(25, 363)
        SaveTmp.Name = "SaveTmp"
        SaveTmp.Size = New Size(75, 23)
        SaveTmp.TabIndex = 15
        SaveTmp.Text = "Save"
        SaveTmp.UseVisualStyleBackColor = True
        ' 
        ' TestCaseTemplate
        ' 
        ClientSize = New Size(533, 466)
        Controls.Add(SaveTmp)
        Controls.Add(CheckBoxTestID)
        Controls.Add(CheckBoxSummary)
        Controls.Add(CheckBoxTestType)
        Controls.Add(CheckBoxPriority)
        Controls.Add(CheckBoxComponent)
        Controls.Add(CheckBoxDescription)
        Controls.Add(CheckBoxPreCondition)
        Controls.Add(CheckBoxStep)
        Controls.Add(CheckBoxAction)
        Controls.Add(CheckBoxData)
        Controls.Add(CheckBoxExpectedResult)
        Controls.Add(CheckBoxActualResult)
        Controls.Add(CheckBoxRegressionCandidate)
        Controls.Add(CheckBoxTimeTravel)
        Controls.Add(CheckBoxBusinessComments)
        Name = "TestCaseTemplate"
        Text = "Test Case Template"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SaveTmp As Button
End Class