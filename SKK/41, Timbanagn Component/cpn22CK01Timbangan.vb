Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports ZylSoft.Serial

Public Class cpn22CK01Timbangan
    Implements IDisposable

    Public _01prop_BeratTimbngan As SpinEdit

    Public _02JenisTimbangan As String ' A&D, METLER Toledo

    Public _03StatusTimbangan As String

    Private pcAlamatPrinter As String

    '************** AUto Wite
    Private Declare Function keybd_event Lib "user32.dll" (
        ByVal bVk As Byte,
        ByVal bScan As Byte,
        ByVal dwFlags As Integer,
        ByVal dwExtraInfo As Integer) As Integer

    Private Const KEYEVENTF_KEYUP As Integer = &H2
    Private Const VK_RETURN As Byte = &HD
    '************** AUto Wite

#Region " How To Used "

    'With _cpnTimibangan  'Nama component
    '._01prop_BeratTimbngan = _03Berat  ' display input  di form yang menggunkan
    'End With

#End Region

#Region "  wite Other Mous plcae"

    Private Sub SendKeysToActiveWindow(text As String)
        For Each c As Char In text
            ' Kirim karakter ke aplikasi aktif
            keybd_event(Asc(c), 0, 0, 0)
            keybd_event(Asc(c), 0, KEYEVENTF_KEYUP, 0)
            Threading.Thread.Sleep(100) ' Tunggu sejenak sebelum mengirim karakter berikutnya
        Next
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

        Select Case _05SCbJenisTimbangan.SelectedIndex
            Case 0
                ' "AND"
                comSerialPort.Port = SerialPort.StringToSerialCommPort(_04CbListPort.Items(_04CbListPort.SelectedIndex).ToString())
                ' comSerialPort.Port = SerialCommPort.COM1     'SerialPort.StringToSerialCommPort(lstPorts.Items(lstPorts.SelectedIndex).ToString())
                comSerialPort.BaudRate = SerialBaudRate.Br002400 'CType(Convert.ToInt32(lstBaudRates.Items(lstBaudRates.SelectedIndex).ToString()), SerialBaudRate)
                comSerialPort.DataWidth = SerialDataWidth.Dw7Bits 'CType(lstDataWidth.SelectedIndex + 5, SerialDataWidth)
                comSerialPort.ParityBits = SerialParityBits.Even 'CType(lstParity.SelectedIndex, SerialParityBits)

                'And
                'METLER TOLEDO
                If _06Cable.SelectedIndex = 0 Then
                    comSerialPort.StopBits = SerialStopBits.Sb1Bit ' USB Converter To Rs232 
                Else
                    comSerialPort.StopBits = SerialStopBits.Sb2Bits ' RS232 To RS232
                End If

                comSerialPort.HardwareFlowControl = SerialHardwareFlowControl.RtsCts 'CType(lstHrdwFlow.SelectedIndex, SerialHardwareFlowControl)
                comSerialPort.SoftwareFlowControl = SerialSoftwareFlowControl.None 'CType(lstSoftFlow.SelectedIndex, SerialSoftwareFlowControl)

                comSerialPort.EnableDtrOnOpen = True ' Default False
                comSerialPort.EnableRtsOnOpen = True
            Case 1 ' 
                'METLER TOLEDO
                comSerialPort.Port = SerialPort.StringToSerialCommPort(_04CbListPort.Items(_04CbListPort.SelectedIndex).ToString())
                comSerialPort.BaudRate = SerialBaudRate.Br009600 'CType(Convert.ToInt32(lstBaudRates.Items(lstBaudRates.SelectedIndex).ToString()), SerialBaudRate)
                comSerialPort.DataWidth = SerialDataWidth.Dw8Bits 'CType(lstDataWidth.SelectedIndex + 5, SerialDataWidth)
                comSerialPort.ParityBits = SerialParityBits.None 'CType(lstParity.SelectedIndex, SerialParityBits)
                comSerialPort.StopBits = SerialStopBits.Sb1Bit 'CType(lstStopBits.SelectedIndex, SerialStopBits)
        End Select


        Dim plHasil As Boolean = comSerialPort.Open()
        If Not plHasil Then
            MessageBox.Show(String.Format("GAGAL koneksi ke timbangan ... ", vbOKOnly + vbInformation, "NEW RJS @" + CType(Year(Now.Date), String)))
        End If

        Return plHasil
    End Function

    Private Sub comSerialPort_Received(sender As Object, e As DataEventArgs) Handles comSerialPort.Received
        'MsgBox(" outputnya = " & CStr(SerialPort.AsciiByteArrayToString(e.Buffer)))
        '' MsgBox(" outputnya = " & CStr(SerialPort.ByteArrayToDecimalString(e.Buffer)))
        Console.WriteLine("e.buffer =", e.Buffer.ToString)

        Set_textDisplay(txtDisplay.Text & SerialPort.AsciiByteArrayToString(e.Buffer))
    End Sub

    Private Sub _cm01SettingTimbangan()
        'Timbangan
        If Not comSerialPort.IsConnected() Then
            Dim plOpenPort As Boolean = OpenPortTimbangan()

            If _06Cable.Text <> "" Then

                If plOpenPort Then
                    MessageBox.Show(String.Format("CONNECT ke Timbangan ... SUKSES...", vbOKOnly + vbInformation, "NEW RJS @" + CType(Year(Now.Date), String)))
                    cm07LockCombo(1)


                    _03StatusTimbangan = " Timbangan ( Connect ) "
                End If
            Else
                MessageBox.Show(String.Format("Silahkan pilih Cabel Connection ..", vbOKOnly + vbInformation, "NEW RJS @" + CType(Year(Now.Date), String)))
            End If


        End If
    End Sub

    Private Sub _cm02GetDataTimbangan()
        txtDisplay.Text = ""
        dGauge1.Text = "0.00"
        'SI  => Metler Tolede
        'PRT => A&D

        Dim prmKeyGet As String = ""

        Select Case _05SCbJenisTimbangan.SelectedIndex
            Case 0 ' "A&D"
                prmKeyGet = "PRT"'"PRT"
            Case 1 ' "METLER-TOLEDO"
                prmKeyGet = "SI"
        End Select

        Console.WriteLine("key GEt = " & prmKeyGet)
        If comSerialPort.IsConnected() Then

            Select Case _05SCbJenisTimbangan.SelectedIndex
                Case 0 ' "A&D"
                    comSerialPort.SendAsciiString(prmKeyGet & vbCrLf)
                    comSerialPort.SendAsciiString(vbCrLf)
                Case 1 ' "METLER-TOLEDO"
                    comSerialPort.SendAsciiString(prmKeyGet & vbCrLf)
            End Select

        Else
            MessageBox.Show("Maaf ... silahkan setting timbangan dulu ...", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub _cm03DisconnectTimbangan()
        'Timbangan
        If comSerialPort.IsConnected() Then
            comSerialPort.Close()

            If Not comSerialPort.IsConnected() Then
                dGauge1.Text = "00.000"
                MessageBox.Show(String.Format("DISCONNECT ke Timbangan ... SUKSES...", vbOKOnly + vbInformation, "NEW RJS @" + CType(Year(Now.Date), String)))
                cm07LockCombo(2)

                _03StatusTimbangan = " Timbangan ( Disconnect ) "
            End If
        End If
    End Sub

    Private Sub _cm04SettingPrinter()
        pcAlamatPrinter = ""
        Using pd As New PrintDialog() With {.PrinterSettings = New PrinterSettings()}
            If (pd.ShowDialog() = DialogResult.OK) Then
                pcAlamatPrinter = pd.PrinterSettings.PrinterName
            End If
        End Using
    End Sub

    Private Sub _cm05CetakDataTimbangan(ByVal prmKodePohon As String, ByVal prmJenis As String)
        If pcAlamatPrinter <> "" Then

            Const _path As String = "C:\NEWRJS"
            If Not Directory.Exists(_path) Then
                Directory.CreateDirectory(_path)
            End If

            Const _pathFile As String = _path + "\cpn22CK01Timbangan.txt"

            If File.Exists(_pathFile) Then
                File.Delete(_pathFile)
            End If

            Dim fs As New FileStream(_pathFile, FileMode.Create, FileAccess.Write, FileShare.None)
            Dim _objstreamwriter As New StreamWriter(fs)

            _objstreamwriter.WriteLine(DateTime.Now)
            _objstreamwriter.WriteLine("--------------------")
            _objstreamwriter.WriteLine("ID.Pohon : " + prmKodePohon)
            _objstreamwriter.WriteLine(prmJenis)
            _objstreamwriter.WriteLine("Berat : " & dGauge1.Text)
            _objstreamwriter.WriteLine(Space(10))
            _objstreamwriter.WriteLine(Space(10))
            _objstreamwriter.WriteLine("--------------------")
            _objstreamwriter.WriteLine(Space(10))

            _objstreamwriter.Close()
            fs.Close()

            Dim plPrint As String = GetFileTxtContents(_pathFile)
            RawPrinterHelper.rawPrinterHelper.PrintRaw(pcAlamatPrinter, plPrint)

        End If
    End Sub

    Private Sub _cm06GetExistingPort()
        Try
            Dim ports() As String = SerialPort.GetExistingCommPortNames()
            Dim i As String
            For Each i In ports
                _04CbListPort.Items.Add(i)
            Next i
        Catch ex As Exception
            MsgBox("Maaf ... tidak ada port ke Metler Toledo.")
        End Try

    End Sub

    Private Sub cm07LockCombo(ByVal prmtarget As Integer)
        '1' konek
        '2' Dicskonek

        If prmtarget = 1 Then
            _04CbListPort.Enabled = False
            _05SCbJenisTimbangan.Enabled = False
            _06Cable.Enabled = False
        Else
            _04CbListPort.Enabled = True
            _05SCbJenisTimbangan.Enabled = True
            _06Cable.Enabled = True
        End If
    End Sub

#End Region

#Region "Control Evnt"

    Private Sub txtDisplay_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged
        '' A&D
        'Dim pdHasil As Double = CDbl(txtDisplay.Text.Substring(4, 10))
        '' METLER
        'Dim prmData01 As String = txtDisplay.Text.Trim.Substring(0, txtDisplay.Text.Trim.Length - 1)
        'Dim prmData02 As String = prmData01.Trim.Substring(4)

        'New Function (Jumat. 22/04/2022)
        Dim pdHasil As Double
        If txtDisplay.Text <> "" Then


            Select Case _05SCbJenisTimbangan.SelectedIndex
                Case 0 ' "A&D"
                    Dim prmData01 As String = txtDisplay.Text.Substring(4, 10)
                    pdHasil = CDbl(prmData01)

                Case 1 ' "METLER-TOLEDO"
                    Dim prmData01 As String = txtDisplay.Text.Trim.Substring(0, txtDisplay.Text.Trim.Length - 1)
                    Dim prmData02 As String = prmData01.Trim.Substring(4)
                    pdHasil = CDbl(prmData02)
            End Select

            'Display to DG
            dGauge1.Text = pdHasil '.ToString '+ "Gr"

            _01prop_BeratTimbngan.EditValue = 0
            _01prop_BeratTimbngan.EditValue = CDbl(pdHasil)

            txtDisplay.EditValue = ""
        End If
    End Sub

    Private Sub cpn22CK01Timbangan_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Right Then
            PopupMenu1.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Public Shared Function GetFileTxtContents(ByVal FullPath As String,
                        Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String = ""
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try

        Return strContents
    End Function

#Region " Menu Popup "

    Private Sub objConnectPrinter_ItemClick(sender As Object, e As ItemClickEventArgs) Handles objConnectPrinter.ItemClick
        _cm04SettingPrinter()
    End Sub

    Private Sub objConnectTimbangan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles objConnectTimbangan.ItemClick
        _cm01SettingTimbangan()
    End Sub

    Private Sub objDisconnetTimbangan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles objDisconnetTimbangan.ItemClick
        _cm03DisconnectTimbangan()
    End Sub

#End Region

#End Region

#Region " public Methods"

    Public Sub cm00BindingAwal()
        _cm06GetExistingPort()
        _06Cable.SelectedIndex = 0
        _05SCbJenisTimbangan.SelectedIndex = 0
        lyt_txtDisplay.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
    End Sub

    Public Sub _cm01GetDataTimbangan()
        _cm02GetDataTimbangan()
    End Sub


    Public Sub _cm03CetakBon(ByVal prmKodePohon As String, ByVal prmJenisBerat As String)
        _cm05CetakDataTimbangan(prmKodePohon, prmJenisBerat)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        _cm02GetDataTimbangan()
    End Sub

    Private Sub txtDisplay_EditValueChanged(sender As Object, e As EventArgs) Handles txtDisplay.EditValueChanged
        Dim prmData01 As String = txtDisplay.Text.Substring(4, 10)
        ' pdHasil = CDbl(prmData01)
        SendKeys.Send(CDbl(prmData01))
        SendKeys.SendWait("{ENTER}")
        'SendKeys.SendWait(CDbl(prmData01) + "{ENTER}")
        'If txtDisplay.EditValue > 0 Then
        'End If
    End Sub


#End Region

End Class
