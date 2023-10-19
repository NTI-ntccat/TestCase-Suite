Public Class EmployeeRole
    Private _id As Integer
    Private _accesslevelname As String
    Private _accesslevel As Integer
    Public Property accesslevel() As Integer
        Get
            Return _accesslevel
        End Get
        Set(ByVal value As Integer)
            _accesslevel = value
        End Set
    End Property
    Public Property accesslevelname() As String
        Get
            Return _accesslevelname
        End Get
        Set(ByVal value As String)
            _accesslevelname = value
        End Set
    End Property

    Public Property id() As Integer
        Get
            Return id
        End Get
        Set(ByVal value As Integer)
            id = value
        End Set
    End Property

End Class
