Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports NCMODELlib
Imports NCVIEWMRPlib

Public Class clsReprintTD

    Public Property prop01_ProductCode As String

#Region "Custom - Methods"

    Private Function _pm01GetDataSource()

        Dim pdDataMasterSKKGambar As DataTable
        Using objSKKMasterGambar As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = prop01_ProductCode
            }
            pdDataMasterSKKGambar = objSKKMasterGambar.GetGambar()
        End Using

        Return pdDataMasterSKKGambar
    End Function
    Private Function _pm02ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

    Public Sub _02DisplayPreview()
        Dim pdCopy As DataTable
        pdCopy = _pm01GetDataSource()
        Dim objReport As New ReportTecknicalDrawing

        With objReport
            ._01prop_ProdcutCode = prop01_ProductCode

            If pdCopy.Rows.Count > 0 Then
                For Each itemRow As Object In pdCopy.Rows
                    Dim objImgName As String = itemRow("f02cKodeFGorComponent_v50")
                    Dim objIMG As Byte() = itemRow("f01objGambar")
                    Dim _3CImgName As String = objImgName.Substring(objImgName.Length - 3)

                    Select Case _3CImgName
                        Case "TD1"
                            ._02prop_IMG_SP = _pm02ByteArrayToImage(objIMG)
                        Case "TD2"
                            ._03prop_IMG_As = _pm02ByteArrayToImage(objIMG)
                    End Select
                Next
            Else
                MsgBox("data gambar tidak ada")
                '._02prop_IMG_SP = My.Resources.CN21
                '._03prop_IMG_As = My.Resources.CN21
            End If

            .Margins = New Margins(25, 25, 25, 25)
            .PaperKind = PaperKind.A4
            .ShowPreview
        End With

    End Sub

#End Region

End Class
