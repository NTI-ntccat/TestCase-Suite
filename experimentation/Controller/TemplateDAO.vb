Imports System.CodeDom
Imports System.Net.Http.Headers
Imports System.Reflection.Metadata.Ecma335
Imports MySql.Data.MySqlClient

Public Class TemplateDAO
    Inherits DatabaseConnection

    Dim mySQLCMD As MySqlCommand
    Dim mySQLDataRdr As MySqlDataReader
    Dim strSQL As String


    Sub New()
        mySQLCMD = New MySqlCommand(strSQL, Conn)
    End Sub

    Function selectTemplateNames()
        Try
            strSQL = "SELECT templatename FROM testcasetemplate"
            mySQLCMD.CommandText = strSQL

            ConnectDB()
            Dim adapter As New MySqlDataAdapter(strSQL, Conn)
            Dim dataSet As New DataSet()

            adapter.Fill(dataSet, "templates")
            Return dataSet
        Catch ex As Exception
            MessageBox.Show("Failed to fetch Template names " + ex.Message)
            Return Nothing
        Finally
            CloseDB()
        End Try
    End Function

    Function selectTemplateByName(template As Template)
        Try
            strSQL = "SELECT * FROM testcasetemplate WHERE templatename = @value"
            mySQLCMD.CommandText = strSQL
            mySQLCMD.Parameters.AddWithValue("@value", template.templateName)

            ConnectDB()
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader()
                If reader.Read Then
                    template.id = reader.GetInt16(0)
                    template.templateName = reader.GetString(1)
                    Return template
                Else
                    MessageBox.Show(template.templateName & " does not exist")
                    Return template
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to fetch template details " + ex.Message)
            Return template
        Finally
            CloseDB()
            mySQLCMD.Parameters.Clear()
        End Try

    End Function

    Function selectFieldsOfTemplate(template As Template)
        Dim dataset As New DataSet()
        Try
            strSQL = "CALL dynamicpivot(@value)"
            mySQLCMD.CommandText = strSQL
            mySQLCMD.Parameters.AddWithValue("@value", template.id)

            ConnectDB()
            Dim adapter As New MySqlDataAdapter(strSQL, Conn)
            adapter.SelectCommand = mySQLCMD
            MessageBox.Show(dataset.GetType().ToString)
            MessageBox.Show(dataset.Tables.GetType().ToString)


            adapter.Fill(dataset, "testcasefields")

            Return dataset
        Catch ex As Exception
            MessageBox.Show("failed to fetch fieldnames of template" & template.templateName & " " & ex.Message)
            Return dataset
        Finally
            CloseDB()
            mySQLCMD.Parameters.Clear()
        End Try
    End Function
End Class
