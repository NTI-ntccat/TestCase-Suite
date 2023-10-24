Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports BCrypt
Public Class Login

    Dim emp As New Employee
    Dim empDAO As New EmployeeDAO
    Dim empRole As New EmployeeRole
    Dim empRoleDAO As New EmployeeRolesDAO
    Dim empRoleMappingDAO As New EmployeeRolesMappingDAO
    Dim projDAO As New ProjectDAO
    Public Property currentUser As New User

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'get emp/proj/emprole
        currentUser.empDetails = empDAO.selectAnEmployee(txtbxUserName.Text)
        currentUser.projDetails.projectname = cbxProject.SelectedValue
        currentUser.projDetails = projDAO.selectSpecficProjectByProjectName(currentUser.projDetails)
        'get employee role
        currentUser.employeeRoleDetails = empRoleDAO.getSpecificEmployeeRole(currentUser.empDetails, currentUser.employeeRoleDetails)
        'validate login creds
        If ValidateLogin(currentUser.projDetails, currentUser.empDetails) Then
            Me.Visible = False
            If LandingPage.Visible Then
                LandingPage.Visible = False
            End If
            LandingPage.ShowDialog()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add default --------- to the project dropdown and populates based on data on backend
        Dim dataTable As New DataTable
        dataTable = projDAO.selectProjects().tables("Project")

        Dim defaultRow As DataRow = dataTable.NewRow()
        defaultRow("projectname") = "------------------"
        dataTable.Rows.InsertAt(defaultRow, 0)

        cbxProject.DataSource = dataTable
        'cbxProject.DisplayMember = "projectname"
        cbxProject.ValueMember = "projectname"
        'for testing purposes only
        txtbxUserName.Text = "employee1"
        txtbxPassword.Text = "password"

    End Sub

    'validates login creds by checking the salt and hashed password
    Function ValidateLogin(proj As Project, emp As Employee)
        Dim password = txtbxPassword.Text
        Dim userName = txtbxUserName.Text
        Dim providedPasswordWithSalt As String

        providedPasswordWithSalt = currentUser.empDetails.salt & password

        If IsNothing(currentUser.empDetails.password) Then
            Return False
        Else
            If (BCrypt.Net.BCrypt.Verify(providedPasswordWithSalt, currentUser.empDetails.password)) Then
                If (empRoleMappingDAO.IsEmployeeProjectMappingExist(currentUser.empDetails, currentUser.projDetails)) Then
                    Return True
                Else
                    MessageBox.Show("Employee has no role")
                End If
            Else
                MessageBox.Show("Wrong Password/UserName")
                Return False
            End If
        End If

    End Function

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnPasswordReset_Click(sender As Object, e As EventArgs) Handles btnPasswordReset.Click
        Me.Hide()
        If ForgotPassword.Visible Then
            ForgotPassword.Visible = False
        Else
            ForgotPassword.ShowDialog()
            Me.Show()
        End If

    End Sub
End Class