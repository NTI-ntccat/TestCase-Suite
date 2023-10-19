Public Class Employee

    Dim _id As Integer
    Dim _firstName As String
    Dim _lastName As String
    Dim _userName As String
    Dim _eMail As String
    Dim _password As String
    Private _salt As String
    Dim _isActive As Boolean


    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property firstName As String
        Get
            Return _firstName
        End Get
        Set(value As String)
            _firstName = value
        End Set
    End Property

    Public Property lastName() As String
        Get
            Return _lastName
        End Get
        Set(ByVal value As String)
            _lastName = value
        End Set
    End Property

    Public Property userName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property

    Public Property eMail() As String
        Get
            Return _eMail
        End Get
        Set(ByVal value As String)
            _eMail = value
        End Set
    End Property

    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property

    Public Property isActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            _isActive = value
        End Set
    End Property

    Public Property salt() As String
        Get
            Return _salt
        End Get
        Set(ByVal value As String)
            _salt = value
        End Set
    End Property

End Class
