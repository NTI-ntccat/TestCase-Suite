Imports BCrypt
Public Class Login

    Dim emp As New Employee
    Dim empDAO As New EmployeeDAO
    Dim empRole As New EmployeeRole
    Dim empRoleDAO As New EmployeeRolesDAO
    Dim empRoleMappingDAO As New EmployeeRolesMappingDAO
    Dim projDAO As New ProjectDAO

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim password = txtbxPassword.Text
        Dim userName = txtbxUserName.Text
        Dim providedPasswordWithSalt As String

        emp = empDAO.selectAnEmployee(userName)
        providedPasswordWithSalt = emp.salt & password

        MessageBox.Show(BCrypt.Net.BCrypt.Verify(providedPasswordWithSalt, emp.password))

        If BCrypt.Net.BCrypt.Verify(providedPasswordWithSalt, emp.password) Then
            MessageBox.Show("Password Correct")
        Else
            MessageBox.Show("WrongPassword")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxProject.DataSource = projDAO.selectProjects().tables("Project")
        cbxProject.DisplayMember = "projectname"
        cbxProject.ValueMember = "projectname"
    End Sub

    Function ValidateLogin()
        Dim password = txtbxPassword.Text
        Dim userName = txtbxUserName.Text
        Dim providedPasswordWithSalt As String

        emp = empDAO.selectAnEmployee(userName)
        providedPasswordWithSalt = emp.salt & password

        MessageBox.Show(BCrypt.Net.BCrypt.Verify(providedPasswordWithSalt, emp.password))

        If BCrypt.Net.BCrypt.Verify(providedPasswordWithSalt, emp.password) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class