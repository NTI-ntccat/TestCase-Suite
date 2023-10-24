Imports MySql.Data.MySqlClient

Public Class TestCaseDAO
    Inherits DatabaseConnection

    Dim mySQLCMD As MySqlCommand
    Dim mySQLDataRdr As MySqlDataReader
    Dim strSQL As String


    Sub New()
        mySQLCMD = New MySqlCommand(strSQL, Conn)
    End Sub

    Sub insertTestCase(testcase As TestCase, template As Template, project As Project)
        strSQL = "INSERT INTO testcase (projid,name,sprint,jiraticketnumber,templateid)
            VALUES(@projid,@name,@sprint,@jiraticketnumber,@templateid)"
        mySQLCMD.CommandText = strSQL
        mySQLCMD.Parameters.AddWithValue("@projid", project.id)
        mySQLCMD.Parameters.AddWithValue("@name", testcase.name)
        mySQLCMD.Parameters.AddWithValue("@sprint", testcase.sprint)
        mySQLCMD.Parameters.AddWithValue("@jiraticketnumber", testcase.jiraticketnumber)
        mySQLCMD.Parameters.AddWithValue("@templateid", template.id)

        Try
            ConnectDB()
            mySQLCMD.ExecuteNonQuery()

            MessageBox.Show("Test case saved successfully")
        Catch ex As Exception
            MessageBox.Show("Test case insert failed: " + ex.Message)
        Finally
            CloseDB()
            mySQLCMD.Parameters.Clear()
        End Try

    End Sub

    Function selectLatestTestCase(testcase As TestCase)
        strSQL = "SELECT id, name, sprint, jiraticketnumber FROM testcase ORDER BY 1 DESC LIMIT 1"
        mySQLCMD.CommandText = strSQL

        Try
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader
                If mySQLDataRdr.Read Then
                    testcase.id = reader.GetString(0)
                    testcase.name = reader.GetString(1)
                    testcase.sprint = reader.GetString(2)
                    testcase.jiraticketnumber = reader.GetString(3)
                    Return testcase
                Else
                    Return testcase
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Getting Latest TestCase failed " + ex.Message)
            Return testcase
        Finally
            CloseDB()
        End Try
    End Function

End Class
