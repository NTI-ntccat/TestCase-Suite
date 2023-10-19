Public Class TestCaseSetting
    Dim _testID As String
    Dim _summary As String
    Dim _testType As String
    Dim _priority As String
    Dim _component As String
    Dim _description As String
    Dim _preCondition As String
    Dim _stepNumber As Integer
    Dim _action As String
    Dim _data As String
    Dim _expectedResult As String
    Dim _actualResult As String
    Dim _regressionCandidate As Boolean
    Dim _timeTravel As String
    Dim _businessComments As String

    Public Property TestID As String
        Get
            Return _testID
        End Get
        Set(value As String)
            _testID = value
        End Set
    End Property

    Public Property Summary As String
        Get
            Return _summary
        End Get
        Set(value As String)
            _summary = value
        End Set
    End Property

    Public Property TestType As String
        Get
            Return _testType
        End Get
        Set(value As String)
            _testType = value
        End Set
    End Property

    Public Property Priority As String
        Get
            Return _priority
        End Get
        Set(value As String)
            _priority = value
        End Set
    End Property

    Public Property Component As String
        Get
            Return _component
        End Get
        Set(value As String)
            _component = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property PreCondition As String
        Get
            Return _preCondition
        End Get
        Set(value As String)
            _preCondition = value
        End Set
    End Property

    Public Property StepNumber As Integer
        Get
            Return _stepNumber
        End Get
        Set(value As Integer)
            _stepNumber = value
        End Set
    End Property

    Public Property Action As String
        Get
            Return _action
        End Get
        Set(value As String)
            _action = value
        End Set
    End Property

    Public Property Data As String
        Get
            Return _data
        End Get
        Set(value As String)
            _data = value
        End Set
    End Property

    Public Property ExpectedResult As String
        Get
            Return _expectedResult
        End Get
        Set(value As String)
            _expectedResult = value
        End Set
    End Property

    Public Property ActualResult As String
        Get
            Return _actualResult
        End Get
        Set(value As String)
            _actualResult = value
        End Set
    End Property

    Public Property RegressionCandidate As Boolean
        Get
            Return _regressionCandidate
        End Get
        Set(value As Boolean)
            _regressionCandidate = value
        End Set
    End Property

    Public Property TimeTravel As Boolean
        Get
            Return _timeTravel
        End Get
        Set(value As Boolean)
            _timeTravel = value
        End Set
    End Property

    Public Property BusinessComments As String
        Get
            Return _businessComments
        End Get
        Set(value As String)
            _businessComments = value
        End Set
    End Property
End Class
