Imports System.Configuration
Imports System.IO
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Windows.Media
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.Data
Imports Color = System.Drawing.Color
Imports System.Threading
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.CodeParser
Imports System.ComponentModel
Imports DevExpress.XtraGrid

Public Class xf54ShcedulerBackup

    Implements IDisposable

    Private pdtCOpy As DataTable
    Private MDLCOPY As clsModel

    Private prmISCencel As Boolean = False
    ' Deklarasi CancellationTokenSource di form
    Private cancellationTokenSource As CancellationTokenSource

    Private prmTimeBACKUP As DateTime
    Private isScheduled As Boolean = False ' Status apakah jadwal telah diset


#Region " form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtCOpy = New DataTable
        MDLCOPY = New clsModel With {.prop_dtclsModel = pdtCOpy}
        MDLCOPY.dtInitTabel()
    End Sub


    Private Sub xf54ShcedulerBackup_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnCopyFile.Text = "RUN BACKUP"

        ' Membuat jam sekarang
        tmJam.Interval = 1000
        tmJam.Start()

        ' Timmer Backup
        tmBackUp.Interval = 1000
        tmBackUp.Enabled = False

        ' Set format DateTimePicker untuk hanya memilih waktu
        _03JamSiang.Format = DateTimePickerFormat.Time
        _03JamSiang.ShowUpDown = True

        ' Set format DateTimePicker untuk hanya memilih waktu
        '_04JamMalam.Format = DateTimePickerFormat.Time
        '_04JamMalam.ShowUpDown = True

        cm00InitFild()
    End Sub

#End Region

#Region " Custome Methods "

    Private Sub cm00InitFild()

        GridView1.IndicatorWidth = 50
        col00_bCheck.FieldName = "bCheck"
        col02_k01cNamafile.FieldName = "k01cNamafile"
        col03_f01cFileSize.FieldName = "f01cFileSize"
        col04_f02dTglBackUp.FieldName = "f02dTglBackUp"
        col05_f03cStatusCopy.FieldName = "f03cStatusCopy"

        col00_bCheck.SummaryItem.SummaryType = SummaryItemType.Custom
        col00_bCheck.SummaryItem.DisplayFormat = "{0:n0} File"
        col00_bCheck.SummaryItem.FieldName = "bCheck"

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = MDLCOPY.prop_dtclsModel
    End Sub


    ''' <summary>
    ''' Memuat semua file dari direktori tertentu.
    ''' </summary>
    ''' <param name="directoryPath">Path direktori</param>
    ''' <returns>List file dengan informasi nama dan ukuran</returns>
    Function cm01LoadFilesFromDirectory(directoryPath As String) As List(Of FileInfo)
        Dim fileList As New List(Of FileInfo)

        Try
            If Directory.Exists(directoryPath) Then
                Dim files As String() = Directory.GetFiles(directoryPath)
                For Each filePath As String In files
                    Dim fileInfo As New FileInfo(filePath)
                    fileList.Add(fileInfo)
                Next
            Else
                Console.WriteLine("Direktori tidak ditemukan: " & directoryPath)
            End If
        Catch ex As Exception
            Console.WriteLine("Terjadi kesalahan: " & ex.Message)
        End Try

        Return fileList
    End Function

    Private Sub cm02AddFileNameToGrid()

        MDLCOPY.prop_dtclsModel.Clear()


        ' Dim Dir As String = "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup"
        Dim Dir As String = _01PathAsal.Text.Trim
        Dim sortedList = cm01LoadFilesFromDirectory(Dir)

        Dim files As List(Of FileInfo) = cm01LoadFilesFromDirectory(Dir)

        If files.Count > 0 Then

            'Console.WriteLine("Nama File".PadRight(40) & "Ukuran (KB)")
            'Console.WriteLine(New String("-"c, 50))

            For Each file As FileInfo In files
                'Console.WriteLine(file.Name.PadRight(40) & " --- " & (file.Length / 1024).ToString("N2") & " Date Modife")

                MDLCOPY.dtAddNewaldoStonesMEI(False, file.Name.PadRight(40), (file.Length / 1024).ToString("N2"),
                                              file.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss"), "")
            Next

            MDLCOPY.prop_dtclsModel.AcceptChanges()

            GridControl1.RefreshDataSource()
            GridView1.RefreshData()

        Else
            'Console.WriteLine("Tidak ada file di direktori.")
            MsgBox("Tidak ada File yang Di temukan Di Dalam folder Asal...")
        End If

    End Sub



    'Private Function cm04CopyFileWithProgress(ByVal prmFileName As String) As Integer
    '    Dim SourceFile As String = _01PathAsal.EditValue
    '    Dim destinationFile As String = _02PathTujuan.EditValue

    '    Const bufferSize As Integer = 1024 * 1024 ' Buffer 1 MB
    '    Dim buffer(bufferSize - 1) As Byte


    '    '### Cek File yang akan di Copy ada atau Tidak di folder Asal
    '    Dim fileForCopy As String = SourceFile & "\" & prmFileName

    '    If Not File.Exists(fileForCopy) Then
    '        MessageBox.Show("Source file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return 0
    '    End If

    '    ' Dim fileName As String = Path.GetFileName(SourceFile)

    '    Try
    '        SplashScreenManager.Default.SetWaitFormCaption($"Copy File: {prmFileName} ...")

    '        Using sourceStream As New FileStream(SourceFile & "\" & prmFileName, FileMode.Open, FileAccess.Read)
    '            Using destinationStream As New FileStream(destinationFile & "\" & prmFileName, FileMode.Create, FileAccess.Write)
    '                Dim totalBytes As Long = sourceStream.Length
    '                Dim totalCopied As Long = 0

    '                Dim bytesRead As Integer
    '                Do
    '                    bytesRead = sourceStream.Read(buffer, 0, buffer.Length)
    '                    destinationStream.Write(buffer, 0, bytesRead)

    '                    totalCopied += bytesRead

    '                    ' Hitung progres
    '                    Dim progress As Double = (totalCopied / totalBytes) * 100
    '                    Console.WriteLine($"Menyalin {prmFileName}: {progress:F2}%")

    '                    SplashScreenManager.Default.SetWaitFormDescription($"{prmFileName.Substring(0, 15)}: {progress:F2} %")
    '                Loop While bytesRead > 0
    '            End Using
    '        End Using

    '        Return 1 ' Berhasil menyalin
    '    Catch ex As Exception
    '        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return 0 ' Gagal menyalin
    '    Finally
    '    End Try
    'End Function

    Private Async Function cm04CopyFileWithProgressAsync(ByVal prmFileName As String, ByVal cancellationToken As CancellationToken) As Task(Of Integer)
        Dim SourceFile As String = _01PathAsal.EditValue
        Dim destinationFile As String = _02PathTujuan.EditValue

        Const bufferSize As Integer = 1024 * 1024 ' Buffer 1 MB
        Dim buffer(bufferSize - 1) As Byte

        '### Cek File yang akan di Copy ada atau Tidak di folder Asal
        Dim fileForCopy As String = SourceFile & "\" & prmFileName

        If Not File.Exists(fileForCopy) Then
            MessageBox.Show("Source file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If

        ' Dim fileName As String = Path.GetFileName(SourceFile)

        Try
            SplashScreenManager.Default.SetWaitFormCaption($"Copy File: {prmFileName} ...")

            Using sourceStream As New FileStream(SourceFile & "\" & prmFileName, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous)
                Using destinationStream As New FileStream(destinationFile & "\" & prmFileName, FileMode.Create, FileAccess.Write, FileShare.None, 4096, FileOptions.Asynchronous)
                    Dim totalBytes As Long = sourceStream.Length
                    Dim totalCopied As Long = 0

                    Dim bytesRead As Integer
                    Do

                        ' Cek jika pembatalan diminta
                        cancellationToken.ThrowIfCancellationRequested()


                        bytesRead = Await sourceStream.ReadAsync(buffer, 0, buffer.Length)
                        If bytesRead > 0 Then
                            Await destinationStream.WriteAsync(buffer, 0, bytesRead)
                            totalCopied += bytesRead

                            ' Hitung progres
                            Dim progress As Double = (totalCopied / totalBytes) * 100
                            Console.WriteLine($"Menyalin {prmFileName}: {progress:F2}%")

                            SplashScreenManager.Default.SetWaitFormDescription($"{prmFileName.Substring(0, 15)}: {progress:F2} %")
                        End If
                    Loop While bytesRead > 0
                End Using
            End Using

            Return 1 ' Berhasil menyalin
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0 ' Gagal menyalin
        Finally
        End Try
    End Function



    Private Async Sub cm05copyfile()
        ' Direktori sumber dan tujuan 
        'Dim Dir As String = "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup"
        Dim sourceDirectory As String = _01PathAsal.Text
        ' Dim destinationDirectory As String = "D:\VB\BACKUP-DB"
        Dim destinationDirectory As String = _02PathTujuan.Text

        ' Buat folder tujuan jika belum ada
        If Not Directory.Exists(destinationDirectory) Then
            Directory.CreateDirectory(destinationDirectory)
        End If

        ' Ambil daftar file dari direktori sumber
        Dim files As String() = Directory.GetFiles(sourceDirectory)

        If files.Length > 0 Then

            Console.WriteLine("Menyalin file...")

            ' Buat instance CancellationTokenSource
            cancellationTokenSource = New CancellationTokenSource()

            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True)

            For i As Integer = 0 To GridView1.RowCount - 1

                If GridView1.GetRowCellValue(i, col00_bCheck) Then

                    Dim sourceFile As String = files(i)
                    Dim destinationFile As String = Path.Combine(destinationDirectory, Path.GetFileName(sourceFile))
                    Dim prmFileName As String = GridView1.GetRowCellValue(i, col02_k01cNamafile)

                    '' Salin file dengan progres
                    ' Dim resultCopy As Integer = cm04CopyFileWithProgress(prmFileName)
                    Dim resultCopy As Integer = Await cm04CopyFileWithProgressAsync(prmFileName, cancellationTokenSource.Token)

                    GridView1.SetRowCellValue(i, col05_f03cStatusCopy, If(resultCopy = 1, "BERHASIL", "GAGAL"))
                    GridView1.FocusedRowHandle = i + 1 ' set focus cursor proses indikator
                    GridView1.RefreshData()

                    ' Beri jeda untuk memastikan UI terlihat diperbarui
                    Application.DoEvents()
                    Thread.Sleep(1000) ' Jeda 500 ms

                    'Console.WriteLine($"sourceFIle {sourceFile}  - destinationFile {destinationFile} ")

                    'Console.WriteLine($"file name {GridView1.GetRowCellValue(i, col02_k01cNamafile)}")
                    If prmISCencel Then
                        GridView1.SetRowCellValue(i, col05_f03cStatusCopy, "CENCEL")
                        SplashScreenManager.CloseForm()
                        LabelStatus.Text = ""
                        LabelStatus.Text = "Copy File Di Batalkan..."
                        Exit For
                    End If

                End If


            Next

            SplashScreenManager.CloseForm()
            ' Console.WriteLine("Proses selesai.")
            MsgBox("Proses Copy File Selesai")
            ' Tampilkan status
            LabelStatus.Text = "Proses copy selesai pada: " & DateTime.Now.ToString("HH:mm:ss")

            cm07CencelShceduleBackup()
        Else
            Console.WriteLine("Tidak ada file di direktori sumber.")
        End If

        Console.ReadLine()
    End Sub

    Private Sub cm06ShceduleBackup()

        prmTimeBACKUP = _03JamSiang.Value
        isScheduled = True
        prmISCencel = False

        ' Tampilkan jadwal di label
        'LabelStatus.Text = "Jadwal telah diset: " & scheduleTime.ToString("HH:mm:ss")

        ' Aktifkan Timer
        tmBackUp.Enabled = True
        _03JamSiang.Enabled = False
        btnCopyFile.Text = "CANCEL"
    End Sub

    Private Sub cm07CencelShceduleBackup()
        ' Minta pembatalan
        If cancellationTokenSource IsNot Nothing Then
            cancellationTokenSource.Cancel()
        End If

        prmTimeBACKUP = DateTime.Now.ToString("HH:mm:ss")
        isScheduled = False
        prmISCencel = True
        ' Tampilkan jadwal di label
        'LabelStatus.Text = "Jadwal telah diset: " & scheduleTime.ToString("HH:mm:ss")

        ' Matikan Timer
        tmBackUp.Enabled = False
        _03JamSiang.Enabled = True
        btnCopyFile.Text = "RUN BACKUP"
    End Sub

    Private Sub cmpe07SelectAll()

        Dim isSelected As Boolean
        Dim isSelectedInt As Boolean

        If ocSelectAll.CheckState = CheckState.Checked Then
            isSelected = True
            isSelectedInt = 1
        Else
            isSelected = False
            isSelectedInt = 0
        End If

        For i As Integer = 0 To GridView1.RowCount - 1

            GridView1.SetRowCellValue(i, "bCheck", isSelected)

        Next i


        GridControl1.RefreshDataSource()
        GridView1.RefreshData()

    End Sub
#End Region

#Region " Control Evnt "


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        cm02AddFileNameToGrid()
    End Sub

    Private Sub btnCopyFile_Click(sender As Object, e As EventArgs) Handles btnCopyFile.Click

        If btnCopyFile.Text = "RUN BACKUP" Then
            cm06ShceduleBackup()
        Else
            cm07CencelShceduleBackup()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmJam.Tick

        lblJAM.Text = DateTime.Now.ToString("HH:mm:ss")

    End Sub

    Private Sub tmBackUp_Tick(sender As Object, e As EventArgs) Handles tmBackUp.Tick
        If isScheduled Then
            ' Periksa apakah waktu saat ini sesuai dengan jadwal
            If DateTime.Now.ToString("HH:mm:ss") >= prmTimeBACKUP.ToString("HH:mm:ss") Then
                tmBackUp.Enabled = False ' Nonaktifkan timer untuk mencegah pengulangan

                ' Jalankan proses copy file
                'CopyFiles("C:\Path\To\Source", "C:\Path\To\Destination")

                cm05copyfile()

            End If
        End If
    End Sub

    Private Sub GridView1_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        If e.RowHandle >= 0 Then

            If GridView1.GetRowCellValue(e.RowHandle, "bCheck") = True Then
                e.Appearance.BackColor = Color.GreenYellow
                e.Appearance.ForeColor = Color.Black
            Else
                e.Appearance.BackColor = Color.Transparent
                e.Appearance.ForeColor = Color.Black
            End If

            If e.Column.FieldName = "f03cStatusCopy" Then
                'col05_f03cStatusCopy
                Dim statusCopy As String = ""
                statusCopy = GridView1.GetRowCellValue(e.RowHandle, "f03cStatusCopy")

                Select Case statusCopy
                    Case "BERHASIL"
                        e.Appearance.BackColor = Color.GreenYellow
                        e.Appearance.ForeColor = Color.Black
                    Case "GAGAL"
                        e.Appearance.BackColor = Color.Red
                        e.Appearance.ForeColor = Color.White
                    Case Else
                        e.Appearance.BackColor = Color.Transparent
                        e.Appearance.ForeColor = Color.Black
                End Select

            End If

        End If
    End Sub

    Private Sub ocSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles ocSelectAll.CheckedChanged
        cmpe07SelectAll()
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        ' Put This code in Init FieldName    
        ' GridView1.IndicatorWidth = 50 

        '# Methods In GridView
        'CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1 'e.RowHandle.ToString()
        End If
    End Sub


#End Region

#Region " Grid Evnt "

    Dim _nTotalSelect As Integer = 0

    Private Sub GridView1_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles GridView1.CustomSummaryCalculate
        'CUstom SUmmary Berat BAtu
        Dim view As GridView = TryCast(sender, GridView)

        'col00_bCheck

        If e.IsTotalSummary AndAlso (TryCast(e.Item, GridSummaryItem)).FieldName = "bCheck" Then

            Dim item As GridSummaryItem = TryCast(e.Item, GridSummaryItem)

            If item.FieldName = "bCheck" Then

                Select Case e.SummaryProcess

                    Case CustomSummaryProcess.Start
                        _nTotalSelect = 0
                    Case CustomSummaryProcess.Calculate

                        Dim prmDipilih As Boolean = CBool(view.GetRowCellValue(e.RowHandle, "bCheck"))

                        If prmDipilih Then

                            _nTotalSelect += 1
                        End If

                    Case CustomSummaryProcess.Finalize

                        e.TotalValue = _nTotalSelect


                End Select
            End If

        End If
    End Sub

    Private Sub rscol00_bCheck_CheckedChanged(sender As Object, e As EventArgs) Handles rscol00_bCheck.CheckedChanged
        GridView1.PostEditor()
        GridView1.RefreshData()
    End Sub

#End Region

End Class