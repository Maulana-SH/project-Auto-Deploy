Imports DevExpress.Schedule
Imports DevExpress.XtraScheduler

Public Class xfrm36ShcedulerWorkDays
    Implements IDisposable

    Private pdtTglKerja As DataTable

#Region " form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtTglKerja = New DataTable

    End Sub

    Private Sub xfrm36ShcedulerWorkDays_Load(sender As Object, e As EventArgs) Handles Me.Load
         cm01INitControl()


    End Sub


#End Region

#Region " Custome Methods "


    Private Sub cm01INitControl()
        SchedulerControl1.BeginUpdate()
        Dim limitInterval As Integer = 5 ' untuk ambil 5 tahun seblum dan yg akan datang
        Dim targetYear As Integer = 2026
        Dim startDate As New DateTime(targetYear, 1, 1)

        SchedulerControl1.Start = startDate

        ' Anchor navigator
        DateNavigator1.DateTime = startDate

        ' Penting: supaya align minggu tidak mundur terlalu jauh
        SchedulerControl1.OptionsView.FirstDayOfWeek = FirstDayOfWeek.Monday

        ' Lock supaya tidak keluar tahun
        SchedulerControl1.LimitInterval.Start = New DateTime(targetYear, 1, 1)
        SchedulerControl1.LimitInterval.End = New DateTime(targetYear, 12, 31)

        'SchedulerControl1.LimitInterval.Start = New DateTime(targetYear - limitInterval, 1, 1)
        'SchedulerControl1.LimitInterval.End = New DateTime(targetYear + limitInterval, 12, 31)

        SchedulerControl1.ActiveViewType = SchedulerViewType.Year

        SchedulerControl1.EndUpdate()

        ' DateEdit hanya pilih tahun
        DateEdit1.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView
        DateEdit1.Properties.MaskSettings.MaskExpression = "yyyy"
        DateEdit1.Properties.UseMaskAsDisplayFormat = True
    End Sub

    Private Sub getKalender()
        ' labelKey Type = https://docs.devexpress.com/WindowsForms/1754/controls-and-libraries/scheduler/appointments/appointment-labels-and-statuses
        pdtTglKerja.Clear()


        Using objGet As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_06nTahun_int = DateEdit1.Text}
            pdtTglKerja = objGet.Seley100Kalenderkerja
        End Using

        'Dim Tahun As Integer
        'Dim Bulan As Integer
        'Dim Hari As Integer

        SchedulerDataStorage1.Appointments.Clear()

        'For Each itm As DataRow In pdtTglKerja.Rows

        '    Tahun = Year(itm("K01dTglKerja"))
        '    Bulan = Month(itm("K01dTglKerja"))
        '    Hari = CInt(Format(itm("K01dTglKerja"), "dd"))
        '    'SchedulerControl1.WorkDays.Add(New Holiday(New DateTime(Tahun, Bulan, Hari), itm("f02cStatus_v50")))

        '    Dim newAppointment As Appointment = SchedulerDataStorage1.Appointments.CreateAppointment(AppointmentType.Normal)
        '    Dim startDate As Date = New DateTime(Tahun, Bulan, Hari, 7, 45, 0)
        '    Dim endDate As Date = startDate.AddHours(9)

        '    newAppointment.Start = startDate
        '    newAppointment.End = endDate
        '    newAppointment.Subject = itm("f02cStatus_v50")


        '    ' JIka Hari kerja Hijau Jika Libur merah
        '    newAppointment.LabelKey = If(itm("f04nStatusKerja_int") = 1, 3, 1)

        '    SchedulerDataStorage1.Appointments.Add(newAppointment)

        'Next

        'Custome Jam Kamis
        'For Each itm As DataRow In pdtTglKerja.Rows

        '    Tahun = Year(itm("K01dTglKerja"))
        '    Bulan = Month(itm("K01dTglKerja"))
        '    Hari = CInt(Format(itm("K01dTglKerja"), "dd"))

        '    Dim currentDate As New DateTime(Tahun, Bulan, Hari)

        '    Dim newAppointment As Appointment = SchedulerDataStorage1.Appointments.CreateAppointment(AppointmentType.Normal)

        '    Dim startDate As Date = New DateTime(Tahun, Bulan, Hari, 7, 45, 0)
        '    Dim endDate As Date

        '    ' 👉 Cek kalau hari Kamis
        '    If currentDate.DayOfWeek = DayOfWeek.Thursday Then
        '        endDate = New DateTime(Tahun, Bulan, Hari, 17, 15, 0)
        '        newAppointment.Subject = itm("f02cStatus_v50") & " - Ganti jam Jumat"
        '    Else
        '        endDate = startDate.AddHours(9)
        '        newAppointment.Subject = itm("f02cStatus_v50")
        '    End If

        '    newAppointment.Start = startDate
        '    newAppointment.End = endDate

        '    ' Label warna
        '    newAppointment.LabelKey = If(itm("f04nStatusKerja_int") = 1, 3, 1)

        '    SchedulerDataStorage1.Appointments.Add(newAppointment)

        'Next

        ' 03
        ' ==============================
        ' PREPARE LOOKUP STATUS HARI
        ' ==============================
        Dim dictStatus As New Dictionary(Of Date, Integer)

        For Each row As DataRow In pdtTglKerja.Rows
            Dim tgl As Date = CDate(row("K01dTglKerja")).Date
            dictStatus(tgl) = row("f04nStatusKerja_int")
        Next


        ' ==============================
        ' LOOP INSERT APPOINTMENT
        ' ==============================
        For Each itm As DataRow In pdtTglKerja.Rows

            Dim currentDate As Date = CDate(itm("K01dTglKerja")).Date

            Dim Tahun As Integer = currentDate.Year
            Dim Bulan As Integer = currentDate.Month
            Dim Hari As Integer = currentDate.Day

            Dim newAppointment As Appointment = SchedulerDataStorage1.Appointments.CreateAppointment(AppointmentType.Normal)

            ' Jam mulai default
            Dim startDate As Date = New DateTime(Tahun, Bulan, Hari, 7, 45, 0)
            Dim endDate As Date

            Dim isKamis As Boolean = (currentDate.DayOfWeek = DayOfWeek.Thursday)
            Dim isHariKerja As Boolean = (itm("f04nStatusKerja_int") = 1)

            If isKamis Then

                Dim jumatDate As Date = currentDate.AddDays(1)

                Dim isJumatKerja As Boolean =
            dictStatus.ContainsKey(jumatDate) AndAlso dictStatus(jumatDate) = 1

                ' 👉 HANYA kalau Kamis & Jumat kerja
                If isHariKerja AndAlso isJumatKerja Then

                    endDate = New DateTime(Tahun, Bulan, Hari, 17, 15, 0)

                    newAppointment.Subject = itm("f02cStatus_v50") & vbNewLine & "30 Mnt, Ganti jam Jumat"

                    ' ==============================
                    ' REMINDER
                    ' ==============================
                    'Dim reminder As Reminder = newAppointment.CreateReminder()
                    'reminder.TimeBeforeStart = TimeSpan.Zero
                    'reminder.AlertTime = startDate

                    ' ==============================
                    ' KETERANGAN TAMBAHAN
                    ' ==============================
                    'newAppointment.Description = " Ganti jam Jumat"

                Else
                    ' fallback normal
                    endDate = startDate.AddHours(9)
                    newAppointment.Subject = itm("f02cStatus_v50")
                End If

            Else
                ' hari biasa
                endDate = startDate.AddHours(9)
                newAppointment.Subject = itm("f02cStatus_v50")
            End If

            ' ==============================
            ' SET WAKTU
            ' ==============================
            newAppointment.Start = startDate
            newAppointment.End = endDate

            ' ==============================
            ' WARNA (LABEL)
            ' ==============================
            newAppointment.LabelKey =
        If(itm("f04nStatusKerja_int") = 1, 3, 1)

            ' ==============================
            ' INSERT
            ' ==============================
            SchedulerDataStorage1.Appointments.Add(newAppointment)

        Next

        SchedulerControl1.RefreshData()


    End Sub

    Private Sub cm03IndoNationalDays2025()
        Dim indoDaysNational As Holiday() = {New Holiday(New DateTime(2025, 1, 1), "Tahun Earu Masehi 2025"),
                                              New Holiday(New DateTime(2025, 1, 27), "lsra Mi'raj Nabi Muhammad SAW"),
                                              New Holiday(New DateTime(2025, 1, 29), "Tahun Baru lmlek2576"),
                                              New Holiday(New DateTime(2025, 3, 29), "Hari Raya Nyepi 1947"),
                                              New Holiday(New DateTime(2025, 3, 31), "Hari Raya ldul Fitri 1446 Hijriah"),
                                              New Holiday(New DateTime(2025, 4, 18), " Wafatnya lsa Alnasih"),
                                              New Holiday(New DateTime(2025, 4, 20), "HariPaskah"),
                                              New Holiday(New DateTime(2025, 5, 1), "HariBuruh"),
                                              New Holiday(New DateTime(2025, 5, 12), "Hari Raya Waisak2S"),
                                              New Holiday(New DateTime(2025, 6, 1), "Hari Lahir Pancasila"),
                                              New Holiday(New DateTime(2025, 6, 27), "Tahun Baru Hijriyah 1 Muhanan 1447 H"),
                                              New Holiday(New DateTime(2025, 8, 17), "Hari Kemerdekaan Republik lndonesia"),
                                              New Holiday(New DateTime(2025, 9, 8), "Maulid Nabi MuhanmadS AW"),
                                              New Holiday(New DateTime(2025, 12, 25), "Hari Raya Natal")}

        For Each item As Holiday In indoDaysNational
            SchedulerControl1.WorkDays.Add(item)
        Next

        '01 Januari: Tahun Earu Masehi 2025
        ' 27 Januari: lsra Mi?aj Nabi Muhammad SAW
        ' 29 Januari: Tahun Baru lmlek2576
        ' 29 Maret:  Hari Raya Nyepi 1947
        ' 31 Maret, 1 April : Hari Raya ldul Fitri 1446 Hijriah
        ' 18 April:  Wafatnya lsa Alnasih
        ' 20 April: HariPaskah
        '1 Mei:    HariBuruh
        '12 Mei :HariRayaWaisak2S\ 9
        ' 29 Mei:    Kenaikan lsa Al Masih
        ' 1 Juni:   Hari Lahir Pancasila
        ' 6Juni : ldut Adha(10 Dzulhijjah 1446 H)
        ' 27 Juni:   Tahun Baru Hijriyah 1 Muhanan 1447 H
        ' 17 Agu&us : Hari Kemerdekaan Republik lndonesia
        ' Septenfur: MaufidNabiMuhanmadSAW
        '25 Desenfut : Hari Raya Natal
    End Sub

#End Region

#Region " Control Evnt "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        getKalender()
    End Sub

    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit1.EditValueChanged

    End Sub

#End Region

#Region " Grid Evnt "

#End Region

End Class