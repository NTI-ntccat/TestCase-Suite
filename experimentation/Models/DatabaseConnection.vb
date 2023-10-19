Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    ' Define a MySqlConnection object and connection string
    Dim _conn As MySqlConnection
    Dim connectionString As String = "Server=localhost;Port=3306;Database=ntccat;User=root;Password=root;"

    Public Property Conn() As MySqlConnection
        Get
            Return _conn
        End Get
        Set(ByVal value As MySqlConnection)
            _conn = value
        End Set
    End Property

    Public Sub New()
        ' Initialize the MySqlConnection with the connection string
        _conn = New MySqlConnection(connectionString)
    End Sub

    Public Sub ConnectDB()
        Try
            ' Open the MySQL connection
            _conn.Open()
            'MessageBox.Show("Connected to MySQL!")
        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message)

        End Try
    End Sub

    Sub CloseDB()
        Try
            _conn.Close()
            MessageBox.Show("Connection Closed")
        Catch ex As Exception
            MessageBox.Show("Connection not closed: " & ex.Message)
        End Try
    End Sub

End Class
