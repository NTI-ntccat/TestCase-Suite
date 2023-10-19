Imports System.CodeDom
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports BCrypt

Public Class EmployeeDAO
    Inherits DatabaseConnection

    Dim mySQLCMD As MySqlCommand
    Dim mySQLDataRdr As MySqlDataReader
    Dim strSQL As String


    Sub New()
        mySQLCMD = New MySqlCommand(strSQL, Conn)
    End Sub

    Sub AddEmployee(emp As Employee)
        Try
            strSQL = "INSERT INTO `ntccat`.`employee`
                (`firstname`,
                `lastname`,
                `username`,
                `email`,
                `password`,
                `salt`,
                `isactive`)
                VALUES
                (@value1,
                @value2,
                @value3,
                @value4,
                @value5,
                @value6,
                @value7);"
            ConnectDB()
            mySQLCMD.CommandText = strSQL
            mySQLCMD.Parameters.AddWithValue("@value1", emp.firstName)
            mySQLCMD.Parameters.AddWithValue("@value2", emp.lastName)
            mySQLCMD.Parameters.AddWithValue("@value3", emp.userName)
            mySQLCMD.Parameters.AddWithValue("@value4", emp.eMail)
            mySQLCMD.Parameters.AddWithValue("@value5", emp.password)
            mySQLCMD.Parameters.AddWithValue("@value6", emp.salt)
            mySQLCMD.Parameters.AddWithValue("@value7", emp.isActive)
            mySQLCMD.ExecuteNonQuery()
            MessageBox.Show("Data Saved Successfully")
        Catch ex As Exception
            MessageBox.Show("Insert not successful " & ex.Message)
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try


    End Sub

    Function selectAllEmployee(emp As Employee)
        strSQL = "SELECT id, firstname, lastname, username, email, isactive 
                    FROM employee"
        mySQLCMD.CommandText = strSQL
        Dim adapter As New MySqlDataAdapter(strSQL, Conn)
        Dim dataSet As New DataSet()

        Try
            ConnectDB()
            ' Fill the DataSet with data from the database
            adapter.Fill(dataSet, "employee")

            Return dataSet
        Catch ex As Exception
            MessageBox.Show("Failed to Select Employee details: " + ex.Message)
            Return dataSet
        Finally
            CloseDB()
        End Try


    End Function

    Sub updateEmployee(emp As Employee, colName As String, newValue As String)
        Try
            strSQL = "Update employee set " & colName & " = @value WHERE id = @id"
            ConnectDB()
            mySQLCMD.CommandText = strSQL
            mySQLCMD.Parameters.AddWithValue("@columnName", colName)
            mySQLCMD.Parameters.AddWithValue("@value", newValue)
            mySQLCMD.Parameters.AddWithValue("@id", emp.id)
            mySQLCMD.ExecuteNonQuery()
            MessageBox.Show("Update successful")
        Catch ex As Exception
            MessageBox.Show("Update failed " + ex.Message)
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try

    End Sub

    Function selectAnEmployee(userName As String)

        strSQL = "SELECT id, firstname, lastname, username, email, isactive, password, salt
                    FROM employee WHERE username = @value"
        mySQLCMD.Parameters.AddWithValue("@value", userName)
        mySQLCMD.CommandText = strSQL

        Dim adapter As New MySqlDataAdapter(strSQL, Conn)
        Dim emp As New Employee

        Try
            'fetch the id of the employee
            ConnectDB()
            Using reader As MySqlDataReader = mySQLCMD.ExecuteReader()
                If reader.Read() Then
                    emp.id = reader.GetString(0).Trim
                    emp.firstName = reader.GetString(1).Trim
                    emp.lastName = reader.GetString(2).Trim
                    emp.userName = reader.GetString(3).Trim
                    emp.eMail = reader.GetString(4).Trim
                    emp.isActive = reader.GetBoolean(5)
                    emp.password = reader.GetString(6).Trim
                    emp.salt = reader.GetString(7).Trim
                    Return emp
                Else
                    MessageBox.Show("Nothing was fetched ")
                    Return emp
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to fetch Employee details: " + ex.Message)
            Return 0
        Finally
            mySQLCMD.Parameters.Clear()
            CloseDB()
        End Try


    End Function

End Class
