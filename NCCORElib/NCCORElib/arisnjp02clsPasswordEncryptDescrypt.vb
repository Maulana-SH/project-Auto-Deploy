Imports System.Security.Cryptography
Public Class arisnjp02clsPasswordEncryptDescrypt
    Implements IDisposable

    Private Shared m_strPassPhrase As String = "@R!$Nu6r0h070N!Pr4s3ty0" '---- any text string is good here
    Private Shared m_strHashAlgorithm As String = "MD5"                '--- we are doing MD5 encryption - can be "SHA1"
    Private Shared m_strPasswordIterations As Integer = 2              '--- can be any number
    Private Shared m_strInitVector As String = "@R!sN3NyD4n!D!k4"      '--- must be 16 bytes
    Private Shared m_intKeySize As Integer = 256                       '--- can be 192 or 128
    Private Shared m_sEncryptKey As String = "K!3vS@k@2012Rh3n@55@$h@nTh4l@$$@5h@^^enPuj!@5tut!$!$!m@t!k"

    Private Function EncryptPasswordMD5(ByVal plainText As String, ByVal p_strSaltValue As String) As String

        Dim strReturn As String = String.Empty

        Try
            Dim initVectorBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(m_strInitVector)
            Dim saltValueBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(p_strSaltValue)

            Dim plainTextBytes As Byte() = System.Text.Encoding.UTF8.GetBytes(plainText)

            Dim password As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(m_strPassPhrase, _
                                                                        saltValueBytes, _
                                                                        m_strPasswordIterations)

            Dim keyBytes As Byte()
            Dim intKeySize As Integer = CType((m_intKeySize / 8), Integer)

            keyBytes = password.GetBytes(intKeySize)

            Dim symmetricKey As RijndaelManaged = New RijndaelManaged() With {.Mode = CipherMode.CBC}

            Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

            Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream

            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, encryptor, _
                                                                CryptoStreamMode.Write)
            ' Start encrypting.
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)

            ' Finish encrypting.
            cryptoStream.FlushFinalBlock()

            ' Convert our encrypted data from a memory stream into a byte array.
            Dim cipherTextBytes As Byte() = memoryStream.ToArray()

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert encrypted data into a base64-encoded string.
            Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)

            ' Return encrypted string.
            strReturn = cipherText

        Catch ex As Exception
            strReturn = Nothing
        End Try

        Return strReturn

    End Function

    'Decrypt Function: 

    Private Function DecryptPasswordMD5(ByVal cipherText As String, ByVal p_strSaltValue As String) As String

        Dim strReturn As String = String.Empty

        Try

            Dim initVectorBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(m_strInitVector)

            Dim saltValueBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(p_strSaltValue)

            Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

            Dim password As Rfc2898DeriveBytes = New Rfc2898DeriveBytes(m_strPassPhrase, _
                                                                        saltValueBytes, _
                                                                        m_strPasswordIterations)

            Dim keyBytes As Byte()
            Dim intKeySize As Integer = CType((m_intKeySize / 8), Integer)

            keyBytes = password.GetBytes(intKeySize)

            Dim symmetricKey As RijndaelManaged = New RijndaelManaged() With {.Mode = CipherMode.CBC}

            Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

            Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream(cipherTextBytes)

            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, _
                                                                decryptor, _
                                                                CryptoStreamMode.Read)
            Dim plainTextBytes As Byte()
            ReDim plainTextBytes(cipherTextBytes.Length)

            ' Start decrypting.
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, _
                                                                  0, plainTextBytes.Length)

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert decrypted data into a string. 
            ' Let us assume that the original plaintext string was UTF8-encoded.
            Dim plainText As String = System.Text.Encoding.UTF8.GetString(plainTextBytes, _
                                                                          0, decryptedByteCount)

            ' Return decrypted string.
            strReturn = plainText

        Catch ex As Exception
            strReturn = Nothing
        End Try

        Return strReturn


    End Function

    Public Function EncryptPassword(ByVal Password As String) As String

        'Encrypt the Password
        Dim sEncryptedPassword As String = ""
        'Dim sEncryptKey As String = "P@SSW@RD@09" 'Should be minimum 8 characters

        Try
            sEncryptedPassword = EncryptPasswordMD5(Password, m_sEncryptKey)

        Catch ex As Exception
            Return sEncryptedPassword
        End Try

        Return sEncryptedPassword
    End Function

    Public Function DecryptPassword(ByVal Password As String) As String
        'Encrypt the Password
        Dim sDecryptedPassword As String = ""
        'Dim sEncryptKey As String = "P@SSW@RD@09" 'Should be minimum 8 characters

        Try
            sDecryptedPassword = DecryptPasswordMD5(Password, m_sEncryptKey)

        Catch ex As Exception
            Return sDecryptedPassword
        End Try

        Return sDecryptedPassword
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


