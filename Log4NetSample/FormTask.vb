Public Class FormTask

    Private tokenSource As Threading.CancellationTokenSource = Nothing

    Private Class ProgressDto
        Public ReadOnly Property Max As Integer
        Public ReadOnly Property Done As Integer
        Public Sub New(max As Integer, done As Integer)
            Me.Max = max
            Me.Done = done
        End Sub
    End Class

    Private Sub FormTask_Load(sender As Object, e As EventArgs) Handles Me.Load
        Debug.WriteLine(My.Application.Log.DefaultFileLogWriter.FullLogFileName)
        WriteLog("load")
    End Sub

    Private Async Sub FormTask_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        WriteLog("Shown start")
        Await DosomethingAsync()
        WriteLog("Shown end")
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WriteLog("Button1_Click start")
        Await DosomethingAsync()
        WriteLog("Button1_Click end")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WriteLog("Button2_Click start")
        tokenSource.Cancel()
        WriteLog("Button2_Click end")
    End Sub

    Private Async Function DosomethingAsync() As Task
        WriteLog("DosomethingAsync start")
        Button1.Enabled = False
        Button2.Enabled = True
        Dim currendDan As New Progress(Of Integer)(New Action(Of Integer)(AddressOf UpdateDanText))
        Dim totalProgress As New Progress(Of ProgressDto)(New Action(Of ProgressDto)(AddressOf UpdateToalProgress))
        Dim danText As New Progress(Of Tuple(Of Integer, Integer))(New Action(Of Tuple(Of Integer, Integer))(AddressOf UpdateDanText))
        Dim danProgress As New Progress(Of ProgressDto)(New Action(Of ProgressDto)(AddressOf UpdateDanProgress))
        tokenSource = New Threading.CancellationTokenSource
        Try
            Await Task.Run(Sub() DoSomething(currendDan, totalProgress, danText, danProgress, tokenSource.Token))
        Catch ex As OperationCanceledException
            'キャンセルされた場合
            WriteLog($"Canceled {ex.ToString}")
            MessageBox.Show("中止されました")
        End Try

        Button2.Enabled = False
        Button1.Enabled = True
        WriteLog("DosomethingAsync end")
    End Function

    Private Sub DoSomething(currentDan As IProgress(Of Integer), totalProgress As IProgress(Of ProgressDto), danTtext As IProgress(Of Tuple(Of Integer, Integer)), danProgress As IProgress(Of ProgressDto), token As Threading.CancellationToken)
        WriteLog("Dosomething start")
        token.ThrowIfCancellationRequested()
        totalProgress.Report(New ProgressDto(9, 0))
        danProgress.Report(New ProgressDto(9, 0))
        For i = 1 To 9
            token.ThrowIfCancellationRequested()
            currentDan.Report(i)
            danProgress.Report(New ProgressDto(9, 0))
            For j = 1 To 9
                token.ThrowIfCancellationRequested()
                WriteLog($"Dosomething processing {i} × {j}")
                danTtext.Report(New Tuple(Of Integer, Integer)(i, j))
                Threading.Thread.Sleep(100)
                danProgress.Report(New ProgressDto(9, j))
            Next
            Threading.Thread.Sleep(1000)
            totalProgress.Report(New ProgressDto(9, i))
        Next
        WriteLog("Dosomething end")
    End Sub

    Private Sub UpdateDanText(dan As Integer)
        WriteLog("UpdateDanText start")
        ProgressLabel1.Text = String.Format("{0}の段", dan)
        WriteLog("UpdateDanText end")
    End Sub

    Private Sub UpdateToalProgress(status As ProgressDto)
        WriteLog("UpdateToalProgress start")
        ProgressBar1.Maximum = status.Max
        ProgressBar1.Value = status.Done
        WriteLog("UpdateToalProgress end")
    End Sub

    Private Sub UpdateDanText(curren As Tuple(Of Integer, Integer))
        WriteLog("UpdateDanText start")
        ProgressLabel2.Text = String.Format("{0} × {1} = {2}", curren.Item1, curren.Item2, curren.Item1 * curren.Item2)
        WriteLog("UpdateDanText end")
    End Sub

    Private Sub UpdateDanProgress(status As ProgressDto)
        WriteLog("UpdateDanProgress start")
        ProgressBar2.Maximum = status.Max
        ProgressBar2.Value = status.Done
        WriteLog("UpdateDanProgress end")
    End Sub

    Private Sub WriteLog(message As String)
        'Const format = "{2} Thread:{0},message:{1}"
        'Dim text = String.Format(format, Threading.Thread.CurrentThread.ManagedThreadId, message, DateTime.Now.ToString("yyyyMMdd HH:mm:ss.fff"))
        'My.Application.Log.WriteEntry(text)
        'My.Application.Log.DefaultFileLogWriter.Flush()
    End Sub

End Class