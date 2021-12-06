Public Class DailyTask
    Private _Description As String = Nothing
    Private _Time As String = Nothing
    Private _NextDue As DateTime = Nothing
    Private _Weekdays As Array = Nothing
    Private _id As Integer = Nothing
    Public Done As String = Nothing

    Public Property Description As String
        Get
            Return _Description
        End Get
        Private Set(value As String)
            _Description = value
        End Set
    End Property

    Public Property Time As String
        Get
            Return _Time
        End Get
        Private Set(value As String)
            _Time = value
        End Set
    End Property

    Public Property NextDue As DateTime
        Get
            Return _NextDue
        End Get
        Private Set(value As DateTime)
            _NextDue = value
        End Set
    End Property

    Public Property Weekdays As Array
        Get
            Return _Weekdays
        End Get
        Private Set(value As Array)
            _Weekdays = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Private Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Sub New(ID_ As Integer, Description_ As String, Time_ As String, Optional Weekdays_ As Array = Nothing, Optional Done_ As String = Nothing, Optional NextDue_ As DateTime = Nothing)
        _id = ID_
        _Description = Description_
        _Time = Time_
        _Weekdays = Weekdays_
        _NextDue = NextDue_
        Done = Done_
        If _Weekdays Is Nothing Then _Weekdays = New Short() {1, 1, 1, 1, 1, 1, 1}

        Dim Times As String() = Time_.Split(":")
        Dim Due As New DateTime(Date.Now.Year, Date.Now.Month, Date.Now.Day, Int(Times.GetValue(0)), Int(Times.GetValue(1)), 0)
        If Done Is Nothing Then
            If Date.Now > Due Then
                Done = "x"
            Else
                Done = "o"
            End If
        End If
        If _NextDue = Nothing Then
            _NextDue = Due
            GetNextDue()
        End If
    End Sub

    Public Sub GetNextDue()
        If Date.Now > _NextDue Then
            While Date.Now > _NextDue And _Weekdays.GetValue(Date.Now.DayOfWeek) = 0
                _NextDue = DateAdd(DateInterval.Day, 1, _NextDue)
            End While
        End If
        Done = "o"
    End Sub

    Public Sub Postpone()
        While Date.Now > _NextDue
            _NextDue = DateAdd(DateInterval.Minute, 5, _NextDue)
        End While
    End Sub
End Class
