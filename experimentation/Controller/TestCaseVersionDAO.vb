Public Class TestCaseVersionDAO
    Inherits DatabaseConnection

    Sub insertTestCaseVersion(testCaseVersion As TestCaseVersion, testCase As TestCase)
        Try
            strSQL = "INSERT INTO testcaseversion (testcaseid, versionnumber, modificationdate,modifiedby)
                VALUES(@testcaseid, @versionnumber, @modificationdate, @modifiedby)"
            mySQLCMD.CommandText = strSQL
            mySQLCMD.Parameters.AddWithValue("@testcaseid", testCase.id)
            mySQLCMD.Parameters.AddWithValue("@versionnumber", testCaseVersion.versionNumber)
            mySQLCMD.Parameters.AddWithValue("@modificationdate", testCaseVersion.modificationDate)
            mySQLCMD.Parameters.AddWithValue("@modifiedby", testCaseVersion.modifiedBy)

            ConnectDB()
            mySQLCMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("TestCase Version Creation failed " + ex.Message)
        Finally

        End Try
    End Sub
End Class
