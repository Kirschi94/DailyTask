Public Class DailyTask
    Private _Description As String = Nothing
    Private _Time As String = Nothing
    Public _NextDue As DateTime = Nothing
    Private _Weekdays As Array = Nothing

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

    Public Sub New(ByVal Description_ As String, ByVal Time_ As String, ByVal Optional Weekdays_ As Array = Nothing, ByVal Optional NextDue_ As DateTime = Nothing)
        _Description = Description_
        _Time = Time_
        _Weekdays = Weekdays_
        _NextDue = NextDue_
        If _Weekdays Is Nothing Then _Weekdays = New Short() {1, 1, 1, 1, 1, 1, 1}
        If _NextDue = Nothing Then GetNextDue()
    End Sub

    Public Sub GetNextDue()
        If Date.Now > _NextDue Then
            While Date.Now > _NextDue And _Weekdays.GetValue(Date.Now.DayOfWeek) = 0
                _NextDue = DateAdd(DateInterval.Day, 1, _NextDue)
            End While
        End If
    End Sub

    Public Sub Postpone()
        While Date.Now > _NextDue
            _NextDue = DateAdd(DateInterval.Minute, 5, _NextDue)
        End While
    End Sub
End Class
