Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports ZylSoft.Serial

Public Class ucGetTimbanganRS232

#Region " From Event"

    Private Sub ucGetTimbanganRS232_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm06GetExistingPort()
    End Sub

#End Region


#Region " Costume Methods "

    'Delegate Sub SetDisplayCallback(ByVal text As String)
    Delegate Sub SetDisplayCallback(ByVal text As String)

    Private Sub Set_textDisplay(ByVal txtGram As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.

        If Me.txtDisplay.InvokeRequired Then
            Dim d As New SetDisplayCallback(AddressOf Set_textDisplay)
            Me.Invoke(d, New Object() {txtGram})
        Else
            Me.txtDisplay.Text = txtGram
            Me.txtDisplay.SelectionStart = txtDisplay.Text.Length
            Me.txtDisplay.SelectionLength = 0
            Me.txtDisplay.ScrollToCaret()
        End If
    End Sub

    Private Function OpenPortTimbangan() As Boolean

        ' "A&D"
        comSerialPort.Port = SerialPort.StringToSerialCommPort(_03CbListPort.Items(_03CbListPort.SelectedIndex).ToString())
        ' comSerialPort.Port = SerialCommPort.COM1     'SerialPort.StringToSerialCommPort(lstPorts.Items(lstPorts.SelectedIndex).ToString())
        comSerialPort.BaudRate = SerialBaudRate.Br002400 'CType(Convert.ToInt32(lstBaudRates.Items(lstBaudRates.SelectedIndex).ToString()), SerialBaudRate)
        comSerialPort.DataWidth = SerialDataWidth.Dw7Bits 'CType(lstDataWidth.SelectedIndex + 5, SerialDataWidth)
        comSerialPort.ParityBits = SerialParityBits.Even 'CType(lstParity.SelectedIndex, SerialParityBits)
        comSerialPort.StopBits = SerialStopBits.Sb1Bit 'CType(lstStopBits.SelectedIndex, SerialStopBits)
        comSerialPort.HardwareFlowControl = SerialHardwareFlowControl.RtsCts 'CType(lstHrdwFlow.SelectedIndex, SerialHardwareFlowControl)
        comSerialPort.SoftwareFlowControl = SerialSoftwareFlowControl.None 'CType(lstSoftFlow.SelectedIndex, SerialSoftwareFlowControl)

        comSerialPort.EnableDtrOnOpen = False

        'Select Case _02SCbJenisTimbangan.SelectedIndex
        '    Case 0
        '        ' "A&D"
        '        comSerialPort.Port = SerialPort.StringToSerialCommPort(_03CbListPort.Items(_03CbListPort.SelectedIndex).ToString())
        '        ' comSerialPort.Port = SerialCommPort.COM1     'SerialPort.StringToSerialCommPort(lstPorts.Items(lstPorts.SelectedIndex).ToString())
        '        comSerialPort.BaudRate = SerialBaudRate.Br002400 'CType(Convert.ToInt32(lstBaudRates.Items(lstBaudRates.SelectedIndex).ToString()), SerialBaudRate)
        '        comSerialPort.DataWidth = SerialDataWidth.Dw7Bits 'CType(lstDataWidth.SelectedIndex + 5, SerialDataWidth)
        '        comSerialPort.ParityBits = SerialParityBits.Even 'CType(lstParity.SelectedIndex, SerialParityBits)
        '        comSerialPort.StopBits = SerialStopBits.Sb2Bits 'CType(lstStopBits.SelectedIndex, SerialStopBits)
        '        comSerialPort.HardwareFlowControl = SerialHardwareFlowControl.RtsCts 'CType(lstHrdwFlow.SelectedIndex, SerialHardwareFlowControl)
        '        comSerialPort.SoftwareFlowControl = SerialSoftwareFlowControl.None 'CType(lstSoftFlow.SelectedIndex, SerialSoftwareFlowControl)

        '        comSerialPort.EnableDtrOnOpen = False
        '        comSerialPort.EnableRtsOnOpen = True
        '    Case 1 ' 
        '        'METLER TOLEDO
        '        comSerialPort.Port = SerialPort.StringToSerialCommPort(_03CbListPort.Items(_03CbListPort.SelectedIndex).ToString())
        '        comSerialPort.BaudRate = SerialBaudRate.Br009600 'CType(Convert.ToInt32(lstBaudRates.Items(lstBaudRates.SelectedIndex).ToString()), SerialBaudRate)
        '        comSerialPort.DataWidth = SerialDataWidth.Dw8Bits 'CType(lstDataWidth.SelectedIndex + 5, SerialDataWidth)
        '        comSerialPort.ParityBits = SerialParityBits.None 'CType(lstParity.SelectedIndex, SerialParityBits)
        '        comSerialPort.StopBits = SerialStopBits.Sb1Bit 'CType(lstStopBits.SelectedIndex, SerialStopBits)
        'End Select



        Dim plHasil As Boolean = comSerialPort.Open()
        If Not plHasil Then
            MessageBox.Show(String.Format("GAGAL koneksi ke timbangan ... ", vbOKOnly + vbInformation, "NEW RJS @" + CType(Year(Now.Date), String)))
        End If

        Return plHasil
    End Function

    Private Sub comSerialPort_Received(sender As Object, e As DataEventArgs) Handles comSerialPort.Received
        'MsgBox(" outputnya = " & CStr(SerialPort.AsciiByteArrayToString(e.Buffer)))
        Set_textDisplay(txtDisplay.Text & SerialPort.AsciiByteArrayToString(e.Buffer))
    End Sub

    Private Sub _cm01SettingTimbangan()
        'Timbangan
        If Not comSerialPort.IsConnected() Then
            Dim plOpenPort As Boolean = OpenPortTimbangan()

            If plOpenPort Then
                MessageBox.Show(String.Format("CONNECT ke Timbangan ... SUKSES...", vbOKOnly + vbInformation, "NEW RJS @" + CType(Year(Now.Date), String)))
            End If

        End If
    End Sub

    Private Sub _cm02GetDataTimbangan()
        ' dGauge1.Text = "0.00"
        'SI  => Metler Tolede
        'PRT => A&D

        Dim prmKeyGet As String = ""
        prmKeyGet = "PRT"

        'Select Case _02SCbJenisTimbangan.SelectedIndex
        '    Case 0 ' "A&D"
        '        prmKeyGet = "PRT"
        '    Case 1 ' "METLER-TOLEDO"
        '        prmKeyGet = "SI"
        'End Select


        If comSerialPort.IsConnected() Then

            'A&D
            comSerialPort.SendAsciiString(prmKeyGet & vbCrLf)
            comSerialPort.SendAsciiString(vbCrLf)

            'Select Case _02SCbJenisTimbangan.SelectedIndex
            '    Case 0 ' "A&D"
            '        comSerialPort.SendAsciiString(prmKeyGet & vbCrLf)
            '        comSerialPort.SendAsciiString(vbCrLf)
            '    Case 1 ' "METLER-TOLEDO"
            '        comSerialPort.SendAsciiString(prmKeyGet & vbCrLf)
            'End Select

        Else
            MessageBox.Show("Maaf ... silahkan setting timbangan dulu ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub _cm03DisconnectTimbangan()
        'Timbangan
        If comSerialPort.IsConnected() Then
            comSerialPort.Close()

            If Not comSerialPort.IsConnected() Then
                'dGauge1.Text = "00.000"
                '_03Berat.EditValue = 0
                MessageBox.Show(String.Format("DISCONNECT ke Timbangan ... SUKSES...", vbOKOnly + vbInformation, "NEW RJS @" + CType(Year(Now.Date), String)))
            End If
        End If
    End Sub

    'Private Sub _cm04SettingPrinter()
    '    pcAlamatPrinter = ""
    '    Using pd As New PrintDialog() With {.PrinterSettings = New PrinterSettings()}
    '        If (pd.ShowDialog() = DialogResult.OK) Then
    '            pcAlamatPrinter = pd.PrinterSettings.PrinterName
    '        End If
    '    End Using
    'End Sub

    'Private Sub _cm05CetakDataTimbangan(ByVal prmKodePohon As String, ByVal prmJenis As String)
    '    If pcAlamatPrinter <> "" Then

    '        Const _path As String = "C:\NEWRJS"
    '        If Not Directory.Exists(_path) Then
    '            Directory.CreateDirectory(_path)
    '        End If

    '        Const _pathFile As String = _path + "\cpn22CK01Timbangan.txt"

    '        If File.Exists(_pathFile) Then
    '            File.Delete(_pathFile)
    '        End If

    '        Dim fs As New FileStream(_pathFile, FileMode.Create, FileAccess.Write, FileShare.None)
    '        Dim _objstreamwriter As New StreamWriter(fs)

    '        _objstreamwriter.WriteLine(DateTime.Now)
    '        _objstreamwriter.WriteLine("--------------------")
    '        _objstreamwriter.WriteLine("ID.Pohon : " + prmKodePohon)
    '        _objstreamwriter.WriteLine(prmJenis)
    '        _objstreamwriter.WriteLine("Berat : " & dGauge1.Text)
    '        _objstreamwriter.WriteLine(Space(10))
    '        _objstreamwriter.WriteLine(Space(10))
    '        _objstreamwriter.WriteLine("--------------------")
    '        _objstreamwriter.WriteLine(Space(10))

    '        _objstreamwriter.Close()
    '        fs.Close()

    '        Dim plPrint As String = GetFileTxtContents(_pathFile)
    '        RawPrinterHelper.rawPrinterHelper.PrintRaw(pcAlamatPrinter, plPrint)

    '    End If
    'End Sub

    Private Sub _cm06GetExistingPort()
        Try
            Dim ports() As String = SerialPort.GetExistingCommPortNames()
            Dim i As String
            For Each i In ports
                _03CbListPort.Items.Add(i)
            Next
        Catch ex As Exception
            MsgBox("Maaf ... tidak ada port ke Metler Toledo.")
        End Try

    End Sub


#End Region

#Region " Cntl Evnt "

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged
        '' A&D
        'Dim pdHasil As Double = CDbl(txtDisplay.Text.Substring(4, 10))
        '' METLER
        'Dim prmData01 As String = txtDisplay.Text.Trim.Substring(0, txtDisplay.Text.Trim.Length - 1)
        'Dim prmData02 As String = prmData01.Trim.Substring(4)

        'New Function (Jumat. 22/04/2022)
        Dim pdHasil As Double

        textOutput.Text = ""
        textOutput.Text = txtDisplay.Text

        pdHasil = CDbl(txtDisplay.Text.Substring(4, 10))

        Dim output As String = ""
        output = txtDisplay.Text

        'Select Case _02SCbJenisTimbangan.SelectedIndex
        '    Case 0 ' "A&D"
        '        pdHasil = CDbl(txtDisplay.Text.Substring(4, 10))

        '        Dim output As String = ""
        '        output = txtDisplay.Text

        '    Case 1 ' "METLER-TOLEDO"
        '        Dim prmData01 As String = txtDisplay.Text.Trim.Substring(0, txtDisplay.Text.Trim.Length - 1)
        '        Dim prmData02 As String = prmData01.Trim.Substring(4)
        '        pdHasil = prmData02
        'End Select

        'Display to DG
        'dGauge1.Text = pdHasil.ToString '+ "Gr"

        txtViewBerat.EditValue = 0
        txtViewBerat.EditValue = pdHasil

        'txtDisplay.Text = ""
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        _cm01SettingTimbangan()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        _cm03DisconnectTimbangan()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        _cm02GetDataTimbangan()
    End Sub

#End Region

End Class