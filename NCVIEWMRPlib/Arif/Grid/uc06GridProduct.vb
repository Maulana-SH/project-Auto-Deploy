Public Class uc06GridProduct
    Implements IDisposable

    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""
    Public Property prop_objPicture As Byte()

    Public Property prop_01dt32PRODUCT As New DataTable   'ambil 32


#Region "Costum Color Code"

    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = ""

    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""
#End Region

#Region "form : Event"

    Private Sub ucGridProduct_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm01InitGrid()
    End Sub

#End Region

#Region "Costume : Public Methods"

    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function

    Sub _cm01InitGrid()

        With _gvProduct

            With .Appearance

                With .GroupPanel
                    .Options.UseBackColor = True
                    .BackColor = _cmColorByHtml(Backcolor_Panel01)
                End With

                With .HeaderPanel
                    .Options.UseBackColor = True
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                    .BackColor = _cmColorByHtml(Backcolor_Panel01)
                    .ForeColor = _cmColorByHtml(Textcolor_01)
                End With

            End With

            col01_k01cKodeProduct_v50.FieldName = "k01cKodeProduct_v50"
            col02_f01cNamaProduct_v50.FieldName = "f01cNamaProduct_v50"
            col03_f04cNamaItemProduct_v50.FieldName = "f04cNamaItemProduct_v50"
            col04_f06cNamaBrand_v50.FieldName = "f06cNamaBrand_v50"
            col05_f08cNamaMaterial_v50.FieldName = "f08cNamaMaterial_v50"
            col06_f10cNamaKadar_v50.FieldName = "f10cNamaKadar_v50"
            col07_f12cNamaColor_v50.FieldName = "f12cNamaColor_v50"
            col08_f14cNamaSize_v50.FieldName = "f14cNamaSize_v50"
            col09_f16cNamaEngrave_v50.FieldName = "f16cNamaEngrave_v50"
            col010_f18cNamaGender_v50.FieldName = "f18cNamaGender_v50"
            col011_f20cNamaPlating_v50.FieldName = "f20cNamaPlating_v50"
            col012_f22cNamaFinishing_v50.FieldName = "f22cNamaFinishing_v50"
            col013_f24cNamaStoneType_v50.FieldName = "f24cNamaStoneType_v50"
            col014_f26cNamaStoneColor_v50.FieldName = "f26cNamaStoneColor_v50"
            col015_f28cNamaFinding_v50.FieldName = "f28cNamaFinding_v50"
            col016_f01objGambar.VisibleIndex = -1
            col017_f42dCreatedDate.FieldName = "f42dCreatedDate"

        End With

        _gcProduct.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        _gcProduct.LookAndFeel.UseDefaultLookAndFeel = False
        _gcProduct.DataSource = Nothing
        _gcProduct.DataSource = prop_01dt32PRODUCT
        _gcProduct.Refresh()

    End Sub

#End Region

#Region "Grid : Event"

    Private Sub _gcProduct_DoubleClick(sender As Object, e As EventArgs) Handles _gcProduct.DoubleClick
        _gcProduct.ShowPrintPreview()
    End Sub

#End Region

End Class
