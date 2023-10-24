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

    Function getSpecificEmployeeRole(emp As Employee, empRole As EmployeeRole)
        strSQL = "SELECT r.id,r.accesslevelname, r.accesslevel
                FROM employeerolesmapping er
                JOIN employeeroles r 
                ON er.accesslevelid = r.id
                WHERE er.empid = @value"
        mySQLCMD.Parameters.AddWithValue("@value", emp.id)
        mySQLCMD.CommandText = strSQL

        Try
            ConnectDB()
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader
                If reader.Read Then
                    empRole.id = reader.GetInt16(0)
                    empRole.accesslevelname = reader.GetString(1)
                    empRole.accesslevel = reader.GetInt16(2)

                    Return empRole
                Else
                    MessageBox.Show("Employee has no role")
                    Return empRole
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return empRole
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try
    End Function

    Function getSpecificEmployeeRoleViaAccessLevel(empRole As EmployeeRole)
        strSQL = "SELECT * FROM employeeroles WHERE accesslevel = @value"
        mySQLCMD.Parameters.AddWithValue("@value", empRole.accesslevel)
        mySQLCMD.CommandText = strSQL

        Try
            ConnectDB()
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader
                If reader.Read Then
                    empRole.id = reader.GetInt16(0)
                    empRole.accesslevelname = reader.GetString(1)
                    empRole.accesslevel = reader.GetInt16(2)
                    Return empRole
                Else
                    MessageBox.Show("Nothing was fetched")
                    Return empRole
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return empRole
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try
    End Function
End Class
