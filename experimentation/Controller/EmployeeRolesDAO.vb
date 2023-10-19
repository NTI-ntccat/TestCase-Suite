Imports MySql.Data.MySqlClient

Public Class EmployeeRolesDAO
    Inherits DatabaseConnection

    Dim mySQLCMD As MySqlCommand
    Dim mySQLDataRdr As MySqlDataReader
    Dim strSQL As String

    Sub New()
        mySQLCMD = New MySqlCommand(strSQL, Conn)
    End Sub

    Function selectEmployeeRoles(empRoles As EmployeeRole)
        strSQL = "SELECT concat(accesslevel, ' - ', accesslevelname) as roleinfo FROM employeeroles WHERE id <> 1;"
        mySQLCMD.CommandText = strSQL

        Dim adapter As New MySqlDataAdapter(strSQL, Conn)
        Dim dataset As New DataSet()

        Try
            ConnectDB()
            adapter.Fill(dataset, "employeeroles")
            Return dataset
        Catch ex As Exception
            MessageBox.Show("Failed to retreive Employee Roles: " + ex.Message)
            Return dataset
        Finally
            CloseDB()
        End Try

    End Function
End Class
