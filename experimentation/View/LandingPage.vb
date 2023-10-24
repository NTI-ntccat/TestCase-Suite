Public Class LandingPage
    Private Sub btnManageEmployees_Click(sender As Object, e As EventArgs) Handles btnManageEmployees.Click
        Me.Hide()
        If ManageEmployees.Visible Then
            ManageEmployees.Visible = False
        Else
            ManageEmployees.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub btnaddProj_Click(sender As Object, e As EventArgs) Handles btnaddProj.Click
        Me.Hide()
        If ProjectSettings.Visible Then
            ProjectSettings.Visible = False
        Else
            Dim projectSettings As New ProjectSettings
            projectSettings.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub LandingPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub LandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login.currentUser.employeeRoleDetails.accesslevel = 3 Then
            btnaddProj.Hide()
            btnManageEmployees.Hide()
        ElseIf Login.currentUser.employeeRoleDetails.accesslevel = 2 Then
            btnaddProj.Hide()
        End If
    End Sub
End Class