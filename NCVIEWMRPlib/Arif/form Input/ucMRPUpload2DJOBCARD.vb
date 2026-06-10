Imports System.IO
Imports NCMODELlib

Public Class ucMRPUpload2DJOBCARD
    Implements IDisposable
    Public Property propDataMasterGambar As New DataTable
    Public Property _01PropDataMastert35 As New DataTable
    Public Property _02PropDataMastertMRP22 As New DataTable
    Public Property _02Prop_UserID As String = "1"
    Public Property _03Prop_NamaUser As String = "Maulana"
    Public Property _04PropDataMastert30 As New DataTable

    Private ChooseImg As cls20FE01Gambar

    Private Sub ucMRPUpload2DJOBCARD_Load(sender As Object, e As EventArgs) Handles Me.Load
        ChooseImg = New cls20FE01Gambar With {
           .prop_01gcTitle = "Select IMG",
           .prop_02gcUserID = _02Prop_UserID,
           .prop_03gcNamaUser = _03Prop_NamaUser,
           .prop_04glIsDisplayMsgBox = False
           }

        _cm01Initcontrol()
    End Sub

    Private Function _cm04byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As MemoryStream = New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function

    Sub _cm01Initcontrol()

        With _01Novalidation
            ._01prop_dtDesignMasterSKK = _04PropDataMastert30
            ._02prop_fieldValueMember = "k01cKodeDesignMaster_v50"
            ._03prop_fieldDisplayMember = "f02cNamaBrand_v50"
            ._04BindingAwalDataSurce()
        End With


        With fciMultipel
            ._01prop_dtMasterSKK = _02PropDataMastertMRP22
            ._02prop_FilterKodeMasterSKK = "FCI-ITEM-007"
            ._03BindingAwalDataSource()
        End With



    End Sub

    Private Sub btnSelectIMG_Click(sender As Object, e As EventArgs) Handles btnSelectIMG.Click
        ChooseImg._cm01ChooseImage(_peIMG2D)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If _01Novalidation.EditValue <> "" Then
            'save Image
            With ChooseImg
                .prop_01gcTitle = "Pilih IMage"
                .prop_02gcUserID = _02Prop_UserID
                .prop_03gcNamaUser = _03Prop_NamaUser
                .prop_04glIsDisplayMsgBox = True
            End With
            ChooseImg._cm03SimpanImage(_peIMG2D, _01Novalidation.EditValue, _01Novalidation.EditValue & "_2D00")
            _peIMG2D.Image = Nothing
        Else
            MsgBox("Kode validation Belum Di pilih", MsgBoxStyle.Information, "Information")
        End If

    End Sub

    Private Sub _cKodeGambar_LostFocus(sender As Object, e As EventArgs) Handles _cKodeGambar.LostFocus
        If _cKodeGambar.EditValue <> "" Then
            Dim pdtHasilImage As New DataTable
            Using objGambar As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 1,
                                                                    .prop_KeyString01 = _cKodeGambar.EditValue,
                                                                    .prop_KeyString02 = ""}
                pdtHasilImage = objGambar.GetGambarMRP()
            End Using


            If pdtHasilImage.Rows.Count > 0 Then
                For Each dtRow As DataRow In pdtHasilImage.Rows

                    Dim objImgCode As String = dtRow("k01cKodeGambar_v50")
                    Dim objImgName As String = dtRow("f02cKodeFGorComponent_v50")
                    Dim objIMG As Byte() = dtRow("f01objGambar")
                    Dim _3CImgName As String = objImgName.Substring(objImgName.Length - 3)
                    Dim _1CImgName As String = objImgName.Substring(objImgName.Length - 1)

                    Select Case objImgName
                        Case objImgCode
                            If Not TypeOf dtRow("f01objGambar") Is DBNull Then
                                _peIMG2D.Image = _cm04byteArrayToImage(objIMG)
                            End If
                    End Select

                Next
            End If
        End If
    End Sub
End Class
