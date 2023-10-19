Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class EmployeeRolesMappingDAO
    Inherits DatabaseConnection

    Dim mySQLCMD As MySqlCommand
    Dim mySQLDataRdr As MySqlDataReader
    Dim strSQL As String


    Sub New()
        mySQLCMD = New MySqlCommand(strSQL, Conn)
    End Sub

    Function getLatestEmpID()
        strSQL = "select id from employee order by 1 desc LIMIT 1"
        mySQLCMD.CommandText = strSQL

        Dim adapter As New MySqlDataAdapter(strSQL, Conn)

        Try
            'fetch the id of the employee
            ConnectDB()
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader()
                If reader.Read() Then
                    Return reader.GetInt32(0)
                Else
                    MessageBox.Show("Nothing was fetched ")
                    Return 0
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to Select Employee details: " + ex.Message)
            Return 0
        Finally
            CloseDB()
        End Try
    End Function

    Sub insertEmployeeRoleMapping(empID As Integer, empRoleLevel As String)
        strSQL = "select id from employeeroles where accesslevel = @value"
        mySQLCMD.CommandText = strSQL
        mySQLCMD.Parameters.AddWithValue("@value", empRoleLevel)

        Dim adapter As New MySqlDataAdapter(strSQL, Conn)
        Dim empRolesID As String = 0

        Try
            'fetch the id of the emproles
            ConnectDB()
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader()
                If reader.Read() Then
                    ' Create an Employee object and map the data
                    empRolesID = reader.GetString(0)
                Else
                    MessageBox.Show("Nothing was fetched ")

                End If
            End Using

            'insert mapping to emprolesmapping
            strSQL = "insert into employeerolesmapping(empid,accesslevelid) values(@value1,@value2)"
            mySQLCMD.CommandText = strSQL
            mySQLCMD.Parameters.AddWithValue("@value1", empID)
            mySQLCMD.Parameters.AddWithValue("@value2", empRolesID)
            mySQLCMD.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try
    End Sub


End Class
