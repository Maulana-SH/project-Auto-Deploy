Imports System.IO
Imports DevExpress.XtraEditors

Public Class cls20FE01Gambar

    Public Property prop_01gcTitle As String
    Public Property prop_02gcUserID As String
    Public Property prop_03gcNamaUser As String
    Public Property prop_04glIsDisplayMsgBox As Boolean = True

#Region "custom : method picture"

    Public Sub _cm01ChooseImage(ByVal prmobjPicture As PictureEdit)
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"
        ofd.Title = "Please Upload Image"

        If ofd.ShowDialog() = DialogResult.OK Then
            Dim fileSize As Long = New FileInfo(ofd.FileName.ToString).Length
            Dim fSize As Integer = fileSize / 1024
            If fSize > 51 Then
                MsgBox("Maaf ... ukuran filenya terlalu besar ... (harus < 50 kb).", vbOKOnly, prop_01gcTitle)
            Else
                prmobjPicture.Image = Image.FromFile(ofd.FileName)
            End If
        Else
            prmobjPicture.Image = Nothing
        End If
    End Sub

    Public Sub _cm02SimpanImage(ByVal prmobjPicture As PictureEdit, ByVal prmcKodeFG As String, ByVal prmcKodeColor As String)

        Try
            If prmobjPicture.Image IsNot Nothing Then

                Dim ImageData As Byte() = Nothing
                ImageData = _cm11imgToByteArray(prmobjPicture.Image)

                Dim pcKodeGambar As String = prmcKodeFG.Trim
                If prmcKodeColor.Trim <> "" Then
                    pcKodeGambar = pcKodeGambar + "-" + prmcKodeColor.Trim
                End If

                Using objGbr As NCMODELlib.clsMRP1_iface = New NCMODELlib.clsMRP1_impl With {.prop_KeyString01 = pcKodeGambar,
                                                                                             .prop_Gambar01 = ImageData,
                                                                                             .prop_KeyString02 = prmcKodeFG,
                                                                                             .prop_KeyString03 = prmcKodeColor,
                                                                                             .prop_KeyString04 = prop_02gcUserID,
                                                                                             .prop_KeyString05 = prop_03gcNamaUser}
                    objGbr.AddNewGambar()
                End Using

                If prop_04glIsDisplayMsgBox Then
                    MsgBox("Upload Image ... SUKSES ... ", vbOKOnly, prop_01gcTitle)
                End If

            End If
        Catch ex As Exception
            MsgBox("maaf.. ada error : " + ex.Message, vbOKOnly, prop_01gcTitle)
        End Try
    End Sub

    Public Sub _cm03SimpanImage(ByVal prmobjPicture As PictureEdit, ByVal prmcKodeGambar As String, ByVal prmcKodeFGFCI As String)

        Try
            If prmobjPicture.Image IsNot Nothing Then

                Dim ImageData As Byte() = Nothing
                ImageData = _cm11imgToByteArray(prmobjPicture.Image)

                Using objGbr As NCMODELlib.clsMRP1_iface = New NCMODELlib.clsMRP1_impl With {.prop_KeyString01 = prmcKodeGambar,
                                                                                             .prop_Gambar01 = ImageData,
                                                                                             .prop_KeyString02 = prmcKodeFGFCI,
                                                                                             .prop_KeyString03 = "",
                                                                                             .prop_KeyString04 = prop_02gcUserID,
                                                                                             .prop_KeyString05 = prop_03gcNamaUser}
                    objGbr.AddNewGambar()
                End Using

                If prop_04glIsDisplayMsgBox Then
                    MsgBox("Upload Image ... SUKSES ... ", vbOKOnly, prop_01gcTitle)
                End If

            End If
        Catch ex As Exception
            MsgBox("maaf.. ada error : " + ex.Message, vbOKOnly, prop_01gcTitle)
        End Try
    End Sub

    Private Function _cm10GetImageData(ByVal prmobjPicture As PictureEdit) As Byte()
        Dim ImageData As Byte() = Nothing

        If prmobjPicture.Image IsNot Nothing Then
            ImageData = _cm11imgToByteArray(prmobjPicture.Image)
        End If

        Return ImageData
    End Function

    Private Function _cm11imgToByteArray(ByVal img As Image) As Byte()
        Using mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

#End Region
End Class