Imports System.CodeDom
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports BCrypt
Imports System.Security.Cryptography.Xml

Public Class ProjectDAO
    Inherits DatabaseConnection

    Dim mySQLCMD As MySqlCommand
    Dim mySQLDataRdr As MySqlDataReader
    Dim strSQL As String


    Sub New()
        mySQLCMD = New MySqlCommand(strSQL, Conn)
    End Sub

    Sub AddProject(proj As Project)
        Try
            strSQL = "INSERT INTO project
                (`projectname`,
                `projectcode`)
                VALUES
                (@value1,
                @value2);"
            ConnectDB()
            mySQLCMD.CommandText = strSQL
            mySQLCMD.Parameters.AddWithValue("@value1", proj.projectname)
            mySQLCMD.Parameters.AddWithValue("@value2", proj.projectcode)

            mySQLCMD.ExecuteNonQuery()
            MessageBox.Show("Data Saved Successfully")
        Catch ex As Exception
            MessageBox.Show("Insert not successful " & ex.Message)
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try


    End Sub

    Function selectProjects()
        strSQL = "SELECT projectname
                    FROM project"
        mySQLCMD.CommandText = strSQL
        Dim adapter As New MySqlDataAdapter(strSQL, Conn)
        Dim dataSet As New DataSet()

        Try
            ConnectDB()
            ' Fill the DataSet with data from the database
            adapter.Fill(dataSet, "project")

            Return dataSet
        Catch ex As Exception
            MessageBox.Show("Failed to Select Project details: " + ex.Message)
            Return dataSet
        Finally
            CloseDB()
        End Try
    End Function

    Function selectSpecficProjectByProjectName(proj As Project)
        strSQL = "SELECT * FROM project WHERE projectname = @value"
        mySQLCMD.Parameters.AddWithValue("@value", proj.projectname)
        mySQLCMD.CommandText = strSQL

        Try
            ConnectDB()
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader()
                If reader.Read Then
                    proj.id = reader.GetInt16(0)
                    proj.projectcode = reader.GetString(1)
                    proj.projectname = reader.GetString(2)
                End If
            End Using
            Return proj
        Catch ex As Exception
            MessageBox.Show("Failed to Select Project details: " + ex.Message)
            Return proj
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try
        Return proj
    End Function

    Sub insertEmployeeProjectMapping(empID As String, project As Project)
        strSQL = "INSERT INTO employeeprojectmapping(empid, projid) VALUES(@value1,@value2)"
        mySQLCMD.Parameters.AddWithValue("@value1", empID)
        mySQLCMD.Parameters.AddWithValue("@value2", project.id)
        mySQLCMD.CommandText = strSQL

        Try
            ConnectDB()
            mySQLCMD.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Mapping of Employee to Project failed. " + ex.Message)
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try
    End Sub

End Class
