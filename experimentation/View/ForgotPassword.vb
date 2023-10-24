Imports System.ComponentModel

Public Class ForgotPassword
    Dim empDAO As New EmployeeDAO

    'confirm if password is correct, hash the new password and save as new password
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim providedPassword As String = txtbxCurrentPassword.Text
        'get employee details based on the given username
        Login.currentUser.empDetails.userName = txtbxUserName.Text
        Login.currentUser.empDetails = empDAO.selectAnEmployee(Login.currentUser.empDetails.userName)
        If ValidateCurrentPassword() Then
            If ValidateNewPassword() Then
                'hash the password
                hashPassword(txtbxNewPassword.Text)
                'update the password
                empDAO.updatePassword(Login.currentUser.empDetails)
            Else
                MessageBox.Show("Please confirm password again.")
            End If
        End If

    End Sub

    'check if new password is the same with confirmpassword txtbox
    Function ValidateNewPassword()
        Dim newPassword As String = txtbxNewPassword.Text
        Dim confirmPassword As String = txtbxConfirmPassword.Text

        If newPassword.Equals(confirmPassword) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function ValidateCurrentPassword()
        Dim password = txtbxCurrentPassword.Text
        Dim providedPasswordWithSalt As String

        providedPasswordWithSalt = Login.currentUser.empDetails.salt & password
        If (BCrypt.Net.BCrypt.Verify(providedPasswordWithSalt, Login.currentUser.empDetails.password)) Then
            Return True
        Else
            MessageBox.Show("Wrong Password")
            Return False
        End If
    End Function

    Sub hashPassword(password As String)
        Dim salt As String = BCrypt.Net.BCrypt.GenerateSalt()
        Dim passwordToHash As String = salt & password
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(passwordToHash)

        Login.currentUser.empDetails.password = hashedPassword
        Login.currentUser.empDetails.salt = salt

    End Sub

End Class