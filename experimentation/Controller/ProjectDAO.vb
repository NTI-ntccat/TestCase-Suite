Imports System.CodeDom
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports BCrypt

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



End Class
