Imports System.Timers
Public Class PLEProcessMonitor
    Public Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Public Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Const MOUSEEVENTF_LEFTDOWN As Integer = &H2
    Public Const MOUSEEVENTF_LEFTUP As Integer = &H4
    Public Const MOUSEEVENTF_MIDDLEDOWN As Integer = &H20
    Public Const MOUSEEVENTF_MIDDLEUP As Integer = &H40
    Public Const MOUSEEVENTF_RIGHTDOWN As Integer = &H8
    Public Const MOUSEEVENTF_RIGHTUP As Integer = &H10
    Public AzyraRow As DataRow
    Public TimedMonitorRow As DataRow
    Private Sub PLEProcessMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show()
        Application.DoEvents()
        Call FirstRun()
    End Sub

    Private Sub CheckTimedEvent(source As Object, e As ElapsedEventArgs)
        Call DoStuffThread()
    End Sub

    Private Sub TimedMonitorTimedEvent(source As Object, e As ElapsedEventArgs)
        Call ExportTimedMonitorData()
    End Sub
    Private Sub BtnAzyra_Click(sender As Object, e As EventArgs) Handles BtnAzyra.Click
        Call AzyraChecker()
    End Sub

    Private Function CheckAzyra() As Boolean
        Try
            AppActivate("Azyra - Primeline Live")
            'SendKeys.SendWait("~")
            BtnAzyra.BackColor = Color.DarkGreen
            lblAzyra.Text = "Azyra running"
            CheckAzyra = True
        Catch ex As Exception
            BtnAzyra.BackColor = Color.DarkRed
            lblAzyra.Text = "Azyra not running"
            CheckAzyra = False
        End Try
        lblLastAzyra.Text = DateTime.Now
        AzyraRow("NextRun") = DateTime.Now.AddSeconds(5)
        lblNextAzyra.Text = AzyraRow("NextRun").ToString
    End Function
    Public Sub AzyraChecker()
        If Not CheckAzyra() Then
            Call LaunchAzyra()
        End If
        Show()
    End Sub
    Private Sub LaunchAzyra()
        Dim proc As New System.Diagnostics.Process()
        proc = Process.Start("\\APOLLO1\Azyra\Azyra.EXE", "")
        Threading.Thread.Sleep(3000)
        AppActivate("Azyra")
        SendKeys.SendWait("{TAB}")
        SendKeys.SendWait("+jason +casey")
        'SendKeys.SendWait("a")
        'SendKeys.SendWait("s")
        'SendKeys.SendWait("o")
        'SendKeys.SendWait("n")
        'SendKeys.SendWait(" ")
        'SendKeys.SendWait("^c")
        'SendKeys.SendWait("a")
        'SendKeys.SendWait("s")
        'SendKeys.SendWait("e")
        'SendKeys.SendWait("y")
        SendKeys.SendWait("{TAB}")
        SendKeys.SendWait("teacher")
        'SendKeys.SendWait("e")
        'SendKeys.SendWait("a")
        'SendKeys.SendWait("c")
        'SendKeys.SendWait("h")
        'SendKeys.SendWait("e")
        'SendKeys.SendWait("r")
        SendKeys.SendWait("~")
    End Sub

    Private Sub BtnTimedMonitor_Click(sender As Object, e As EventArgs) Handles BtnTimedMonitor.Click
        Call ExportTimedMonitorData()
    End Sub

    Public Sub ExportTimedMonitorData()
        Dim strExportFrom As String
        strExportFrom = Format(AddWorkingDays(Today(), -2), "dd/MM/yy")
        AppActivate("Azyra")
        SendKeys.SendWait("~")
        Threading.Thread.Sleep(3000)
        'Right click 75, 140 FREIGHT
        SetCursorPos(75, 140) 'x and y position
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
        'Left click 170, 150 Freight Menu
        SetCursorPos(170, 150) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Left click 200, 500 Reporting
        SetCursorPos(200, 500) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Double click 500, 170 Job Reporting Spreadsheet
        SetCursorPos(500, 170) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Send TAB
        Threading.Thread.Sleep(2000)
        SendKeys.SendWait("{TAB}")
        'Send Ctrl+V, 2 working days ago
        'ActiveWorkbook.Sheets("Controls").Range("C1").Copy
        SendKeys.SendWait(strExportFrom)
        Threading.Thread.Sleep(2000)
        'Right click 575, 310 calendar
        SetCursorPos(575, 310) 'x and y position
        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)
        'Left click 625, 320 TODAY
        SetCursorPos(625, 320) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Left click 800, 635 EXPORT
        SetCursorPos(800, 635) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Left click 530, 355 xml
        SetCursorPos(530, 355) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Send TAB
        SendKeys.SendWait("{TAB}")
        'Send testjobdata.xml
        SendKeys.SendWait("testjobdata.xml")
        'Left click 570, 540 EXPORT
        SetCursorPos(570, 540) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Wait 45 seconds
        Threading.Thread.Sleep(45000)
        'Send enter
        SendKeys.SendWait("{enter}")
        'Left click 155, 680 BACK
        SetCursorPos(155, 680) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        'Left click 155, 680 CLOSE
        SetCursorPos(155, 680) 'x and y position
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Activate()
        lblLastTimedData.Text = DateTime.Now
        TimedMonitorRow("NextRun") = DateTime.Now.AddMinutes(60)
        lblNextTimedData.Text = TimedMonitorRow("NextRun").ToString
        Show()
    End Sub
    Public Function AddWorkingDays(ByVal DateIn As DateTime,
        ByVal ShiftDate As Integer) As DateTime
        ' Adds the [ShiftDate] number of working days to DateIn
        Dim datDate As DateTime = DateIn.AddDays(ShiftDate)
        ' Loop around until we get the need non-weekend day
        While Weekday(datDate) = 1 Or Weekday(datDate) = 7
            datDate = datDate.AddDays(IIf(ShiftDate < 0, -1, 1))
        End While
        Return datDate
    End Function
    Private Sub DoStuffThread()
        If AzyraRow("NextRun") < Now Then
            Call AzyraChecker()
        End If
        If TimedMonitorRow("NextRun") < Now Then
            Call ExportTimedMonitorData()
        End If
    End Sub

    Private Sub FirstRun()
        AzyraRow = tblReport.Rows.Add(New Object() {"AzyraChecker", "05:48"})
        TimedMonitorRow = tblReport.Rows.Add(New Object() {"ExportTimedMonitorData", "15:32"})
        lblNextAzyra.Text = AzyraRow("NextRun").ToString
        lblNextTimedData.Text = TimedMonitorRow("NextRun").ToString
        Dim TimerCheck As System.Timers.Timer = New Timer((2 * 60000))
        AddHandler TimerCheck.Elapsed, AddressOf CheckTimedEvent
        TimerCheck.Enabled = True
        Call AzyraChecker()
        Call DoStuffThread()
    End Sub

End Class