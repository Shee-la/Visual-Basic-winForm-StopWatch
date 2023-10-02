Public Class frmStopWatch
    Public Property StartTime As Date
    Public Property EndTime As Date
    Public Property ElapsedTime As TimeSpan

    Private Sub frmStopWatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StartTime As Object
        Dim EndTime As Object
        Dim ElapsedTime As Object

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTime = Now
        lblStart.Text = Format(StartTime, "hh:mm:ss")
        lblEnd.Text = ""
        Lable3.Text = ""
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        'Find the ending time, compute the elapsed time ‘Put both values in label boxes'
        EndTime = Now
        ElapsedTime = EndTime - StartTime
        lblEnd.Text = Format(EndTime, "hh:mm:ss”)
        lblElapsedTime.Text = ElapsedTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
