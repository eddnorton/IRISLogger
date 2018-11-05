Public Class Splash
    Dim directory As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim currentTime As System.DateTime = System.DateTime.Now
        Dim GetYear As String = currentTime.Year()
        Dim GetMonth As String = currentTime.Month()
        Dim GetDay As String = currentTime.Day()
        Dim GetHour As Integer = System.DateTime.Now.Hour()
        Dim GetNewHour As String
        If GetHour = "00" Then
            Dim ystTime As System.DateTime = System.DateTime.Now.AddDays(-1)
            GetYear = ystTime.Year()
            GetMonth = ystTime.Month()
            GetDay = ystTime.Day()
            GetHour = "23"
        Else
            GetHour = GetHour - 1
            GetNewHour = GetHour.ToString("00")
        End If
        MsgBox(GetYear)
        MsgBox(GetMonth)
        MsgBox(GetDay)
        MsgBox(GetHour)

        directory = (My.Settings.LogLocation + "\" + GetYear + "\" + GetMonth + "\" + GetDay + "\" + GetYear + "-" + GetMonth + "-" + GetDay + "-" + GetNewHour + "-00-00.mp3")
        MsgBox(directory)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GetYear, GetMonth, GetDay As String
        GetYear = MonthCalendar1.SelectionStart.ToString("yyyy")
        GetMonth = MonthCalendar1.SelectionStart.ToString("MM")
        GetDay = MonthCalendar1.SelectionStart.ToString("dd")
        My.Settings.fullLogLocation = (My.Settings.LogLocation + "\" + GetYear + "\" + GetMonth + "\" + GetDay)
        Main.Show()
        Me.Hide()


    End Sub



    Public Sub Start_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim GetNewHour As String
        Dim currentTime As System.DateTime = System.DateTime.Now
        Dim GetYear As String = currentTime.Year()
        Dim GetMonth As String = currentTime.Month()
        Dim GetDay As String = currentTime.Day()
        Dim GetHour As Integer = System.DateTime.Now.Hour()
        MsgBox(GetHour)
        If GetHour = "00" Then
            Dim ystTime As System.DateTime = System.DateTime.Now.AddDays(-1)
            GetYear = ystTime.Year()
            GetMonth = ystTime.Month()
            GetDay = ystTime.Day()
            GetHour = "23"
        Else
            GetHour = GetHour - 1
            GetNewHour = GetHour.ToString("00")
        End If
        My.Settings.fullLogLocation = (My.Settings.LogLocation + "\" + GetYear + "\" + GetMonth + "\" + GetDay + "\" + GetYear + "-" + GetMonth + "-" + GetDay + "-" + GetNewHour + "-00-00.mp3")
        SaveFileDialog1.ShowDialog()

    End Sub
End Class