Imports System.Windows.Forms
Imports NCMODELlib
Imports PCSC
Imports PCSC.Iso7816
Imports PCSC.Monitoring

Public Class clsSKKAAU01RFID
    Implements IDisposable

    Private Shared ReadOnly _contextFactory As IContextFactory = ContextFactory.Instance
    Private _hContext As ISCardContext
    Dim readerName As String
    Dim readingMode As String
    Dim isstart As Boolean = False
    Dim prmReadeMode As Int32 = 2

    Public Property monitor
    Public isRunRFID As Boolean = False

    Public Property GetreaderList As String()

    '----Untuk RFID Tukang
    Public Get01NIKTukang As String
    Public Get02IdProses As String


#Region " Methodes"

    Public Function _cm01loadReaderList()
        Dim resultList As String()
        Dim resultListGROUP As Integer
        Try

            _hContext = _contextFactory.Establish(SCardScope.System)
            resultList = _hContext.GetReaders()

            resultListGROUP = _hContext.GetHashCode

            _hContext.Release()

            If resultList.Length > 0 Then
                GetreaderList = resultList
            Else
                resultList = Nothing
                MessageBox.Show("No card reader detected!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If

            Return True
        Catch ex As Exceptions.PCSCException
            MessageBox.Show("Error: getReaderList() : " & ex.Message & " (" & ex.SCardError.ToString() & ")")
            Return False
        End Try

    End Function

    Public Sub _cm02startMonitor(ByVal prmReaderName As String)
        Dim monitorFactory As MonitorFactory = monitorFactory.Instance
        monitor = monitorFactory.Create(SCardScope.System)
        AttachToAllEvents(monitor)
        'monitor.Start(cbxReaderList.Text)
        monitor.Start(prmReaderName)
        isRunRFID = True
        '  readerName = cbxReaderList.Text
        readerName = prmReaderName
        readingMode = prmReadeMode
    End Sub

    Public Function _cm03RFIDGetSKU(ByVal prmRFIDTag As String) As String

        Dim prmSKU As String = ""
        Dim pdtHasil As DataTable

        Using objGetSKUByRFID As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 2, .prop_KeyString01 = prmRFIDTag}
            pdtHasil = objGetSKUByRFID.Sele30RFIDCODE
        End Using

        If pdtHasil.Rows.Count > 0 Then
            For Each dtRow As DataRow In pdtHasil.Rows

                prmSKU = CStr(dtRow("k02cSKU_v50")).Trim

            Next

        Else
            prmSKU = ""
            MsgBox("Maaff.. TAG RFID & SKU TIDAK Ditemukan..", MsgBoxStyle.Exclamation, "RFID MODEL Class")

        End If
        Return prmSKU
    End Function

    Public Function _cm04RFIDGetPRODUCTCODE(ByVal prmRFIDTag As String) As String

        Dim prmPRODUCTCODE As String = ""
        Dim pdtHasil As DataTable

        Using objGetSKUByRFID As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 2, .prop_KeyString01 = prmRFIDTag}
            pdtHasil = objGetSKUByRFID.Sele30RFIDCODE
        End Using

        If pdtHasil.Rows.Count > 0 Then
            For Each dtRow As DataRow In pdtHasil.Rows

                prmPRODUCTCODE = CStr(dtRow("f01cDESIGNMASTERCODE_v50")).Trim

            Next

        Else
            prmPRODUCTCODE = ""
            MsgBox("Maaff.. TAG RFID & SKU TIDAK Ditemukan..", MsgBoxStyle.Exclamation, "RFID MODEL Class")

        End If
        Return prmPRODUCTCODE
    End Function

    Public Sub _cm05RFIDGetNikTukang(ByVal prmRFIDTag As String)

        Dim pdtHasil As DataTable

        Using objGetSKUByRFID As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 3, .prop_KeyString01 = prmRFIDTag}
            pdtHasil = objGetSKUByRFID.Sele30RFIDCODE
        End Using

        If pdtHasil.Rows.Count > 0 Then

            Get01NIKTukang = ""
            Get02IdProses = ""

            For Each dtRow As DataRow In pdtHasil.Rows
                Get01NIKTukang = CStr(dtRow("k01cKodeFieldValueMaster_v50")).Trim
                Get02IdProses = CStr(dtRow("f03cReserve01_v50")).Trim
            Next
        Else
            MsgBox("Maaff.. TAG RFID TUKANG TIDAK Ditemukan..", MsgBoxStyle.Exclamation, "RFID MODEL Class")
        End If
    End Sub

    Private Sub AttachToAllEvents(monitor As ISCardMonitor)
        AddHandler monitor.CardInserted, AddressOf cardInit
    End Sub

    Sub cardInit(eventName As SCardMonitor, unknown As CardStatusEventArgs)
        If readingMode = 1 OrElse readingMode = 2 Then
            SendUID4Byte()
        End If
    End Sub

    Function SendUID4Byte()
        Try
            Using context = _contextFactory.Establish(SCardScope.System)
                Using rfidReader = context.ConnectReader(readerName, SCardShareMode.Shared, SCardProtocol.Any)
                    Using rfidReader.Transaction(SCardReaderDisposition.Leave)

                        Dim apdu As Byte() = {&HFF, &HCA, &H0, &H0, &H4}
                        Dim sendPci = SCardPCI.GetPci(rfidReader.Protocol)
                        Dim receivePci = New SCardPCI()

                        Dim receiveBuffer = New Byte(255) {}
                        Dim command = apdu.ToArray()
                        Dim bytesReceived = rfidReader.Transmit(sendPci, command, command.Length, receivePci, receiveBuffer, receiveBuffer.Length)
                        Dim responseApdu = New ResponseApdu(receiveBuffer, bytesReceived, IsoCase.Case2Short, rfidReader.Protocol)

                        If readingMode = 1 Then
                            Dim uid As String = BitConverter.ToString(responseApdu.GetData())
                            uid = uid.Replace("-", "")

                            'SendKeys.SendWait(uid + "{ENTER}")
                        ElseIf readingMode = 2 Then
                            Dim uid As Byte() = New Byte(3) {}
                            Dim revuid As Byte() = New Byte(3) {}
                            Array.Copy(responseApdu.GetData(), uid, 4)
                            Array.Copy(uid, revuid, 4)
                            Array.Reverse(revuid, 0, 4)

                            Dim uid2 As String = BitConverter.ToString(revuid)
                            uid2 = uid2.Replace("-", "")
                            SendKeys.SendWait(uid2 + "{ENTER}")
                        End If

                    End Using
                End Using
            End Using
        Catch
            '  MsgBox("error pada procedure : SendUID4Byte()")
        End Try

        Return True
    End Function

#End Region

#Region " DISPOSE"

    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
