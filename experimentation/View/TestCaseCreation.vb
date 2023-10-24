Public Class TestCaseCreation
    Dim templateDAO As New TemplateDAO
    Dim template As New Template
    Dim projectDAO As New ProjectDAO
    Dim project As New Project
    Dim testCase As New TestCase
    Dim testCaseDAO As New TestCaseDAO



    Private Sub TestCaseCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'populate template dropdown
        cbxTemplate.DataSource = templateDAO.selectTemplateNames.Tables("templates")
        cbxTemplate.ValueMember = "templatename"
        cbxTemplate.DisplayMember = "templatename"

        'set properties of template obj based on selected template.
        If cbxTemplate.Items.Count > 0 Then
            cbxTemplate.SelectedItem = cbxTemplate.Items(0)
            template.templateName = cbxTemplate.SelectedValue
            template = templateDAO.selectTemplateByName(template)
        End If


        'populate the grid initially with columns from the chosen template
        dgvTestCase.DataSource = templateDAO.selectFieldsOfTemplate(template).tables("testcasefields")
        dgvTestCase.Refresh()

        'populate project textfield
        'project = projectDAO.selectSpecficProjectByProjectName(Login.currentUser.projDetails)
        txtbxProject.Text = "Test Project 1"
        MessageBox.Show(project.projectname)


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'populate testcase obj properties
        testCase.jiraticketnumber = txtbxJiraTicketNumber.Text
        testCase.sprint = txtbxSprint.Text
        testCase.name = txtbxTestCaseName.Text

        'for testing purposes only
        project.id = 1
        project.projectname = "Test Project 1"
        project.projectcode = "abc123"

        'insert testcase to database
        testCaseDAO.insertTestCase(testCase, template, project)
        testCaseDAO.selectLatestTestCase(testCase)
    End Sub
End Class