
Public Class ProjectSettings
    Dim project As New Project
    Dim projectDAO As New ProjectDAO
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        project.projectcode = txtbxProjCode.Text
        project.projectname = txtbxProjName.Text

        projectDAO.AddProject(project)
    End Sub

    Private Sub btnAddEmployees_Click(sender As Object, e As EventArgs) Handles btnAddEmployees.Click
        Form1.ShowDialog()
        Me.Close()
    End Sub

End Class