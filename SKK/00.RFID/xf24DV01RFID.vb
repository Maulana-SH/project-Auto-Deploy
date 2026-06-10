
Imports ZylSoft.Serial

Public Class xf24DV01RFID
    Implements IDisposable

    Private HelperRFID As clsSKKAAU01RFID

#Region " form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HelperRFID = New clsSKKAAU01RFID
    End Sub


    Private Sub xf24DV01RFID_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' cm02LoadReaderExixt()
    End Sub

#End Region

#Region " Custome Methods "

    Private Sub cm01StartRFID()

        If HelperRFID._cm01loadReaderList() Then
            ComboBox1.DataSource = Nothing
            ComboBox1.DataSource = HelperRFID.GetreaderList
            'HelperRFID._cm02startMonitor(ComboBox1.Text)
        End If

    End Sub


    Private Sub cm02LoadReaderExixt()
        Try
            Dim ports() As String = SerialPort.GetExistingCommPortNames()
            Dim i As String
            For Each i In ports
                ComboBox1.Items.Add(i)
            Next i
        Catch ex As Exception
            MsgBox("Maaf ... tidak ada port ke Metler Toledo.")
        End Try
    End Sub

#End Region

#Region " Control Evnt "

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        cm01StartRFID()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If HelperRFID.isRunRFID Then
            HelperRFID.monitor.Cancel()
        End If

        HelperRFID._cm02startMonitor(ComboBox1.Text)

    End Sub

    Private Sub TextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim RFID_TAG As String = TextEdit1.Text

            TextEdit1.Text = ""
            TextEdit1.Text = "123"
            TextEdit1.SelectAll()
        End If
    End Sub

    Private Sub TextEdit1_MouseEnter(sender As Object, e As EventArgs) Handles TextEdit1.MouseEnter
        'currentIndex = 0
        'TextEdit1.Clear() ' Kosongkan TextBox sebelum mulai
        'timer.Start() ' Mulai timer saat mouse masuk

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Try
        '    Dim rfidData As String = SerialPort.ReadLine()
        '    txtRfidData.Text = rfidData
        'Catch ex As Exception
        '    MessageBox.Show("Gagal membaca data: " & ex.Message)
        'End Try
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        'Try
        '    Dim dataToWrite As String = txtRfidData.Text
        '    serialPort.WriteLine(dataToWrite)
        '    MessageBox.Show("Data berhasil ditulis ke tag RFID.")
        'Catch ex As Exception
        '    MessageBox.Show("Gagal menulis data: " & ex.Message)
        'End Try
    End Sub


#End Region

#Region " Grid Evnt "

#End Region


End Class