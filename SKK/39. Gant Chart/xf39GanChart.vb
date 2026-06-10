Imports System.Runtime.InteropServices.ComTypes
Imports DevExpress.Utils.Html
Imports DevExpress.XtraGantt
Imports DevExpress.XtraScheduler.Commands
Imports DevExpress.XtraTreeList
Imports NCMODELlib

'https://docs.devexpress.com/WindowsForms/401712/controls-and-libraries/gantt-control/interactive-editing
Public Class xf39GanChart
    Implements IDisposable

    Private pdtTAsk As New DataTable

    Private prmNamaSP As String = "spGetdataForGantSele"

#Region " form Evnt "

    Private Sub xf39GanChart_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm02initField()
    End Sub

#End Region

#Region " Custome Methods "

    Private Sub cm02initField()

        GanttControl1.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.True
        GanttControl1.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.True
        GanttControl1.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.True

        GanttControl1.OptionsBehavior.TaskDateChangeMode = Options.TaskDateChangeMode.UpdateDuration
        GanttControl1.OptionsBehavior.ScheduleMode = DevExpress.XtraGantt.Options.ScheduleMode.Auto

        ' Setting hiutungan Hari tidak ad jam nya
        GanttControl1.OptionsMainTimeRuler.Unit = GanttTimescaleUnit.Day

        With GanttControl1
            .TreeListMappings.KeyFieldName = "Id"
            .TreeListMappings.ParentFieldName = "ParentId"
            .ChartMappings.TextFieldName = "Task"
            .ChartMappings.StartDateFieldName = "StartDate"
            .ChartMappings.FinishDateFieldName = "FinishDate"
            .ChartMappings.BaselineStartDateFieldName = "StartDate"
            .ChartMappings.BaselineFinishDateFieldName = "FinishDate"
            .ChartMappings.PredecessorsFieldName = "Predecessors"
            .ChartMappings.DurationFieldName = "Duration"
            .OptionsView.ShowBaselines = True
        End With

        'default FieldName Gant Chart
        'With GanttControl1
        '    .TreeListMappings.KeyFieldName = "ID"
        '    .TreeListMappings.ParentFieldName = "ParentID"
        '    .ChartMappings.TextFieldName = "Text"
        '    .ChartMappings.StartDateFieldName = "StartDate"
        '    .ChartMappings.FinishDateFieldName = "FinishDate"
        '    .ChartMappings.BaselineStartDateFieldName = "BaseLineStartDate"
        '    .ChartMappings.BaselineFinishDateFieldName = "BaseLineFinishDate"
        '    .OptionsView.ShowBaselines = True
        '    .ChartMappings.PredecessorsFieldName = "Predecessors"
        'End With

        ' GanttControl1.DataSource = GetTasks()

    End Sub

    Private Sub cm03DisplayData()
        'pdtTAsk.Clear()
        'pdtTAsk = GetTasks()
        'GanttControl1.DataSource = pdtTAsk

        pdtTAsk.Clear()

        Using objGet As clsSUPPORTCENTER_iface = New clsSUPPORTCENTER_impl
            pdtTAsk = objGet.selectNoparam(prmNamaSP)
        End Using

        GanttControl1.DataSource = pdtTAsk

    End Sub

    Private Function GetTasks() As DataTable
        Dim table As New DataTable()
        Dim id As New DataColumn("ID", GetType(Integer))
        Dim parentId As New DataColumn("ParentID", GetType(Integer))
        Dim taskText As New DataColumn("Text", GetType(String))
        Dim start As New DataColumn("StartDate", GetType(DateTime))
        Dim finish As New DataColumn("FinishDate", GetType(DateTime))
        Dim startBaseline As New DataColumn("BaselineStartDate", GetType(DateTime))
        Dim finishBaseline As New DataColumn("BaselineFinishDate", GetType(DateTime))
        Dim predecessors As New DataColumn("Predecessors", GetType(String))
        table.Columns.AddRange(New DataColumn() {id, parentId, taskText, start, finish, startBaseline, finishBaseline, predecessors})

        table.Rows.Add(New Object() {1, 0, "Task 1", DateTime.Now, DateTime.Now.AddDays(1), DateTime.Now, DateTime.Now.AddDays(1.5), Nothing})
        table.Rows.Add(New Object() {2, 0, "Task 2", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(1), DateTime.Now.AddDays(1.5), 1})
        table.Rows.Add(New Object() {3, 0, "Task 3", DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3), "1, 2"})
        Return table
    End Function

    Private Sub cm04LopingData()

        Dim log As String = ""
        For Each itm As Object In pdtTAsk.Rows

            log += "id Task = " & itm("ID") & " Nama Task = " & itm("Text") & " Start Date = " & itm("StartDate") & " finis Date = " & itm("FinishDate") & vbNewLine

        Next

        logText.Text = ""
        logText.Text = log

    End Sub


#End Region

#Region " Control Evnt "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm03DisplayData()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        cm04LopingData()
    End Sub

#End Region

#Region " Gant Evnt "
    Private deadLine As New DateTime(2023, 11, 20)
    Private Sub GanttControl1_CustomDrawTask(sender As Object, e As CustomDrawTaskEventArgs) Handles GanttControl1.CustomDrawTask
        If e.FinishDate > deadLine Then
            e.Info.Appearance.BackColor = Color.Green
        End If
    End Sub

    Private Sub GanttControl1_TaskDependencyModified(sender As Object, e As TaskDependencyModificationEventArgs) Handles GanttControl1.TaskDependencyModified
        MsgBox("evnt TaskDependencyModified")
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        HtmlContentPopup1.Show(SimpleButton1, New Rectangle(MousePosition.X, MousePosition.Y, 250, 600))
    End Sub


    Private Sub HtmlContentPopup1_ElementMouseClick(sender As Object, e As DxHtmlElementMouseEventArgs) Handles HtmlContentPopup1.ElementMouseClick

        If e.ElementId = "btnViewParticipan" Then
            MsgBox("View Participan")
        End If

        If e.ElementId = "btnDeatilTask" Then
            MsgBox("View Detail")
        End If

        If e.ElementId = "btnInfo" Then
            MsgBox("View Info")
        End If

    End Sub

#End Region

End Class
