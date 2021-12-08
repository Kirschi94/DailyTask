Public Class Stgs
    Public Shared ReadOnly Done As String = "🗸"
    Public Shared ReadOnly NotDone As String = "x"
    Public Shared ReadOnly Unclear As String = "?"
    Public Shared ReadOnly Pending As String = "o"

    Public Shared ReadOnly PostponingInMinutes As Short = 5

    Public Shared Function GetDayOfYearFormatted()
        Return DateTime.Now.ToString("yyyy") & ", " & DateTime.Now.DayOfYear.ToString
    End Function
End Class
