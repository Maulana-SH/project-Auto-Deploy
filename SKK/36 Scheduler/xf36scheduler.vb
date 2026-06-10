Imports System.Data.SqlClient
Imports DevExpress.XtraScheduler

Public Class xf36scheduler
    'https://docs.devexpress.com/WindowsForms/2949/controls-and-libraries/scheduler/getting-started

    'https://github.dev/DevExpress-Examples/winforms-scheduler-bind-to-ms-sql-server/tree/18.1.3%2B/VB

    '### NOTES
    ' Datenavigator 1 otomatis saat di drop ke from bisa setting view Schaduler control
    ' atau propertis nya di set
    '  DateNavigator1.SchedulerControl = SchedulerControl1

    Implements IDisposable

    ' Modify this string if required to connect to your database.
    'Private Const SchedulerDBConnection As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Data\DXDBScheduler.mdf;Integrated Security=True;Connect Timeout=30"
    Private Const prmcNASA_Server As String = "MAULANADEV"
    Private Const prmcNamaDatabase As String = "SUPPORTCENTER"
    Private Const pcAdmin As String = "sa"
    Private Const pcKey As String = "asdf@123"

    Private Const SchedulerDBConnection As String = "Server =MAULANADEV;Database = SUPPORTCENTER;USER ID = sa;PASSWORD= asdf@123"



    Private DXSchedulerDataset As DataSet
    Private AppointmentDataAdapter As SqlDataAdapter
    Private ResourceDataAdapter As SqlDataAdapter
    Private DXSchedulerConn As SqlConnection

#Region " form Evnt "
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler Me.SchedulerDataStorage1.AppointmentsInserted, AddressOf OnApptChangedInsertedDeleted
        AddHandler Me.SchedulerDataStorage1.AppointmentsChanged, AddressOf OnApptChangedInsertedDeleted
        AddHandler Me.SchedulerDataStorage1.AppointmentsDeleted, AddressOf OnApptChangedInsertedDeleted

    End Sub


    Private Sub xf36scheduler_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm02INitCotrol()
    End Sub



#End Region

#Region " Custome Methods "

    Private Sub cm02INitCotrol()

        ' DateNavigator1.SchedulerControl = SchedulerControl1
        Me.SchedulerDataStorage1.Appointments.ResourceSharing = True
        Me.SchedulerControl1.GroupType = SchedulerGroupType.Resource
        Me.SchedulerControl1.Start = Date.Today

        DXSchedulerDataset = New DataSet()
        Dim selectAppointments As String = "SELECT * FROM Appointments"
        Dim selectResources As String = "SELECT * FROM resources"

        DXSchedulerConn = New SqlConnection(SchedulerDBConnection)
        DXSchedulerConn.Open()

        AppointmentDataAdapter = New SqlDataAdapter(selectAppointments, DXSchedulerConn)
        ' Subscribe to RowUpdated event to retrieve identity value for an inserted row.
        AddHandler AppointmentDataAdapter.RowUpdated, AddressOf AppointmentDataAdapter_RowUpdated
        AppointmentDataAdapter.Fill(DXSchedulerDataset, "Appointments")

        ResourceDataAdapter = New SqlDataAdapter(selectResources, DXSchedulerConn)
        ResourceDataAdapter.Fill(DXSchedulerDataset, "Resources")

        ' Specify mappings.
        MapAppointmentData()
        MapResourceData()

        ' Generate commands using CommandBuilder.  
        Dim cmdBuilder As New SqlCommandBuilder(AppointmentDataAdapter)
        AppointmentDataAdapter.InsertCommand = cmdBuilder.GetInsertCommand()
        AppointmentDataAdapter.DeleteCommand = cmdBuilder.GetDeleteCommand()
        AppointmentDataAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand()

        DXSchedulerConn.Close()

        Me.SchedulerDataStorage1.Appointments.DataSource = DXSchedulerDataset
        Me.SchedulerDataStorage1.Appointments.DataMember = "Appointments"
        Me.SchedulerDataStorage1.Resources.DataSource = DXSchedulerDataset
        Me.SchedulerDataStorage1.Resources.DataMember = "Resources"

    End Sub


    Private Sub MapAppointmentData()
        Me.SchedulerDataStorage1.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerDataStorage1.Appointments.Mappings.Description = "Description"
        ' Required mapping.
        Me.SchedulerDataStorage1.Appointments.Mappings.End = "EndDate"
        Me.SchedulerDataStorage1.Appointments.Mappings.Label = "Label"
        Me.SchedulerDataStorage1.Appointments.Mappings.Location = "Location"
        Me.SchedulerDataStorage1.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        Me.SchedulerDataStorage1.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        ' Required mapping.
        Me.SchedulerDataStorage1.Appointments.Mappings.Start = "StartDate"
        Me.SchedulerDataStorage1.Appointments.Mappings.Status = "Status"
        Me.SchedulerDataStorage1.Appointments.Mappings.Subject = "Subject"
        Me.SchedulerDataStorage1.Appointments.Mappings.Type = "Type"
        Me.SchedulerDataStorage1.Appointments.Mappings.ResourceId = "ResourceIDs"
        Me.SchedulerDataStorage1.Appointments.CustomFieldMappings.Add(New AppointmentCustomFieldMapping("MyNote", "CustomField1"))
    End Sub

    Private Sub MapResourceData()
        Me.SchedulerDataStorage1.Resources.Mappings.Id = "ResourceID"
        Me.SchedulerDataStorage1.Resources.Mappings.Caption = "ResourceName"
    End Sub

#End Region

#Region " Control Evnt "

    ' Retrieve identity value for an inserted appointment.
    Private Sub AppointmentDataAdapter_RowUpdated(ByVal sender As Object, ByVal e As SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.Continue AndAlso e.StatementType = StatementType.Insert Then
            Dim id As Integer = 0
            Using cmd As New SqlCommand("SELECT IDENT_CURRENT('Appointments')", DXSchedulerConn)
                id = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            e.Row("UniqueID") = id
        End If
    End Sub

    ' Store modified data in the database
    Private Sub OnApptChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs)
        AppointmentDataAdapter.Update(DXSchedulerDataset.Tables("Appointments"))
        DXSchedulerDataset.AcceptChanges()
    End Sub

    '// Uncomment the code below to demonstrate how to store and retrieve data in the appointment custom field.
    '// Do not forget to uncomment event subscription code in the form constructor.

    '// Store a custom value in the newly created appointment.
    'private void schedulerControl1_InitNewAppointment(object sender, AppointmentEventArgs e)
    '{
    '    e.Appointment.CustomFields["MyNote"] = String.Format("Created on {0:d} at {0:t} \n", DateTime.Now);
    '}

    ' Modify default appointment text to display a custom value.
    'private void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e)
    '{
    '    e.Text = (e.Appointment.CustomFields["MyNote"] is DBNull) ? String.Empty : (string)e.Appointment.CustomFields["MyNote"];
    '}
#End Region

#Region " Grid Evnt "

#End Region

End Class