Public Class Project

    Private _id As Integer
    Private _projectname As String
    Private _projectcode As String
    Public Property projectcode() As String
        Get
            Return _projectcode
        End Get
        Set(ByVal value As String)
            _projectcode = value
        End Set
    End Property
    Public Property projectname() As String
        Get
            Return _projectname
        End Get
        Set(ByVal value As String)
            _projectname = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

End Class
