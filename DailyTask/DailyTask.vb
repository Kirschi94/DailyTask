Imports Newtonsoft.Json
Public Class DailyTask
    Private _Description As String = Nothing
    Private _Time As String = Nothing
    Private _OriginalDue As DateTime = Nothing
    Public _NextDue As DateTime = Nothing
    Private _Weekdays As Short() = Nothing
    Private _id As Integer = Nothing
    <JsonProperty("done")>
    Public _Done As String = Nothing


    <JsonProperty("description")>
    Public Property Description As String
        Get
            Return _Description
        End Get
        Private Set(value As String)
            _Description = value
        End Set
    End Property

    <JsonProperty("time")>
    Public Property Time As String
        Get
            Return _Time
        End Get
        Private Set(value As String)
            _Time = value
        End Set
    End Property

    <JsonProperty("originaldue")>
    Public Property OriginalDue As DateTime
        Get
            Return _OriginalDue
        End Get
        Private Set(value As DateTime)
            _OriginalDue = value
        End Set
    End Property

    <JsonProperty("weekdays")>
    Public Property Weekdays As Short()
        Get
            Return _Weekdays
        End Get
        Private Set(value As Short())
            _Weekdays = value
        End Set
    End Property

    <JsonProperty("id")>
    Public Property ID As Integer
        Get
            Return _id
        End Get
        Private Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Sub New(ID As Integer, Description As String, Time As String, Optional Weekdays As Short() = Nothing, Optional Done As String = Nothing,
                   Optional NextDue As DateTime = Nothing, Optional OriginalDue As DateTime = Nothing)
        _id = ID
        _Description = Description
        _Time = Time
        _Weekdays = Weekdays
        _NextDue = NextDue
        _OriginalDue = OriginalDue
        _Done = Done
        If _Weekdays Is Nothing Then _Weekdays = New Short() {1, 1, 1, 1, 1, 1, 1}

        'MessageBox.Show(_OriginalDue.ToString("dd/MM/yyyy, HH:mm"))

        Dim Times As String() = Time.Split(":")
        Dim Due As New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Int(Times.GetValue(0)), Int(Times.GetValue(1)), 0)
        If Done Is Nothing Then
            If DateTime.Now > Due And Not _Done = Stgs.Done Then
                _Done = "x"
            ElseIf Not _Done = Stgs.Done Then
                _Done = "o"
            End If
        End If

        If _NextDue = Nothing Or _NextDue.Year < 1900 Then
            _NextDue = Due
            GetNextDue()
            If _OriginalDue = Nothing Or _OriginalDue.Year < 1900 Then _OriginalDue = _NextDue
        End If
    End Sub

    Public Sub GetNextDue()
        If DateTime.Now > _NextDue OrElse _Weekdays.GetValue(DateTime.Now.DayOfWeek) = 0 OrElse _NextDue < _OriginalDue Then
            Dim Extrarun As Boolean = _NextDue < _OriginalDue
            _NextDue = OriginalDue
            While DateTime.Now > _NextDue OrElse _Weekdays.GetValue(_NextDue.DayOfWeek) = 0 OrElse Extrarun
                _NextDue = DateAdd(DateInterval.Day, 1, _NextDue)
                Extrarun = False
            End While
            _OriginalDue = _NextDue
        End If
        _Done = "o"
    End Sub

    Public Sub Postpone()
        While DateTime.Now > _NextDue
            _NextDue = DateAdd(DateInterval.Minute, Stgs.PostponingInMinutes, DateTime.Now)
        End While
    End Sub

    Public Function ToJson()
        Return FromClass(Me)
    End Function

    Public Function Clone()
        Dim TempTask As New DailyTask(_id, _Description, _Time, _Weekdays, _Done, _NextDue, _OriginalDue)
        Return TempTask
    End Function
End Class
