Imports System.IO

Public Class arisnjp02clsOthers
    Implements IDisposable

    Public Shared Function SAKA2011_NET_Version() As String
        Dim pcVersiRJS As New Version
        pcVersiRJS = My.Application.Info.Version

        SAKA2011_NET_Version = pcVersiRJS.ToString.Substring(0, 3)

        pcVersiRJS = Nothing

        Return SAKA2011_NET_Version
    End Function

    Public Shared Function SAKA2011_NET_NamaKomputer() As String
        SAKA2011_NET_NamaKomputer = My.Computer.Name
        SAKA2011_NET_NamaKomputer = SAKA2011_NET_NamaKomputer

        Return SAKA2011_NET_NamaKomputer
    End Function

    Public Shared Function HitungDiskonBertingkat(ByVal prmnHargaAwal As Double, ByVal prmcLabelDiskon As String) As Double
        'dibuat oleh : INDRA
        'Rabu, 12 Juni 2013

        Dim plSplit() As Char = {"+"}
        Dim plInputData() As String = prmcLabelDiskon.Split(plSplit)
        Dim plHasilInput As String = ""
        Dim nTempOld As Double = 1
        Dim nTempNew As Double = 0
        Dim nTempLast As Double = 0
        Dim nTotal As Double = 0

        Try
            For I As Integer = 0 To plInputData.Length - 1
                plHasilInput = Replace(plInputData(I), " ", "")
                nTempNew = 1 - (CType(plHasilInput, Double) / 100)
                nTempLast = nTempOld * nTempNew

                nTempOld = nTempLast

                nTotal = nTempLast * prmnHargaAwal
            Next

            nTotal = prmnHargaAwal - nTotal
        Catch ex As Exception
            nTotal = 0
        End Try

        Return nTotal
    End Function

    Public Shared Function GetFileTxtContents(ByVal FullPath As String, _
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

    '/***** Function for date format: YYYY-MM-DD *****/
    '/***** Created by Indra Rahmat Jatnika on 11-05-2015 21:58 *****/
    Public Shared Function TglYYYYMMDD(ByVal prmDate As Date) As String
        Dim plhasil As String = ""
        plhasil = String.Format("{0}-{1}-{2}", Format(prmDate.Year, "0000"), Format(prmDate.Month, "00"), Format(prmDate.Day, "00"))
        Return plhasil
    End Function

    'Fungsi terbilang dalam IDR dan USD (dua digit dibelakang koma)
    Public Shared Function SIMATIKAmountInWords_USD(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                    > (CLng(intAmount.ToString.Trim.Length / 3)), _
                  CLng(intAmount.ToString.Trim.Length / 3) + 1, _
                    CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, _
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount & _
                Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = SIMATIKAmountInWords_USD(CStr(CLng(nAmount) - _
                  (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount & _
                tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = _
                  Trim(SIMATIKAmountInWords_USD(CStr(Math.Round(Val(nAmount), 2) * 100), _
                  wAmount.Trim & " Dollar And ", 1)) & " Cents"
            End If
        Catch ex As Exception
            'MessageBox.Show("Error Encountered: " & ex.Message, _
            '  "Convert Numbers To Words", _
            '  MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = _
          IIf(InStr(wAmount.Trim.ToLower, "dollar"), _
          wAmount.Trim, wAmount.Trim & " Dollar")

        'Display the result
        Return wAmount
    End Function
    Public Shared Function SIMATIKAmountInWords_IDR(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
            tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                    > (CLng(intAmount.ToString.Trim.Length / 3)), _
                  CLng(intAmount.ToString.Trim.Length / 3) + 1, _
                    CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, _
                  (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String = {"", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan"}
                Dim Teens() As String = {"", "Sebelas", "Dua Belas", "Tiga Belas", "Empat Belas", "Lima Belas", "Enam Belas", "Tujuh Belas", "Delapan Belas", "Sembilan Belas"}
                Dim Tens() As String = {"", "Sepuluh", "Dua Puluh", "Tiga Puluh", "Empat Puluh", "Lima Puluh", "Enam Puluh", "Tujuh Puluh", "Delapan Puluh", "Sembilan Puluh"}
                Dim HMBT() As String = {"", "", "Ribu", "Juta", "Milyar", "Trilyun", "Quadrilyun", "Quintilyun"}
                Dim HMBT1() As String = {"", "", "ribu", "Juta", "Milyar", "Trilyun", "Quadrilyun", "Quintilyun"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                'If nHundred > 0 Then wAmount = wAmount & Ones(nHundred) & " Ratus " 'This is for hundreds  
                If nHundred > 0 Then
                    If nHundred = 1 Then
                        wAmount = wAmount & " Seratus " 'This is for hundreds
                    Else
                        wAmount = wAmount & Ones(nHundred) & " Ratus " 'This is for hundreds
                    End If
                End If

                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, " ", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If

                '****/diubah oleh indra tgl 08-06-2015
                'karena program yg sebelumnya tidak bisa membaca angka 1000 menjadi seribu
                If nAmount >= 1000 And nAmount <= 1999 Then

                    wAmount = "se" & HMBT1(nSet) & " "
                    wAmount = SIMATIKAmountInWords_IDR(CStr(CLng(nAmount) - _
                      (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
                Else
                    wAmount = wAmount & HMBT(nSet) & " "
                    wAmount = SIMATIKAmountInWords_IDR(CStr(CLng(nAmount) - _
                      (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
                End If
                '*************************************************************************
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount & _
                tempDecValue : tempDecValue = String.Empty

                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = _
                  Trim(SIMATIKAmountInWords_IDR(CStr(Math.Round(Val(nAmount), 2) * 100), _
                  wAmount.Trim & " koma ", 1)) & ""

                'If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = _
                '  Trim(SIMATIKAmountInWords_IDR(CStr(Math.Round(Val(nAmount), 2) * 100), _
                '  wAmount.Trim & " Rupiah dan ", 1)) & " Sen"
            End If
        Catch ex As Exception
            'MessageBox.Show("Error Encountered: " & ex.Message, _
            '  "Convert Numbers To Words", _
            '  MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = _
          IIf(InStr(wAmount.Trim.ToLower, "rupiah"), _
          wAmount.Trim, wAmount.Trim & " Rupiah")

        'Display the result
        Return wAmount
    End Function
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
