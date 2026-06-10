Public Class uc03GridMasterStone
    Implements IDisposable
    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""

    Public Property prop_01dt23MCSTONES As New DataTable   'ambil 23


#Region "Costum Color Code"

    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = ""

    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""
#End Region

#Region " Costume : Method"

    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function

    Sub _cm01initFillGrid()

        With _gvMasterStones

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

            col01_k01cKodeStones_v50.FieldName = "k01cKodeStones_v50"
            col02_f03cStonesTypeDesc_v50.FieldName = "f03cStonesTypeDesc_v50"
            col03_f05cShapeDesc_v50.FieldName = "f05cShapeDesc_v50"
            col04_f07cWarnaDesc_v50.FieldName = "f07cWarnaDesc_v50"
            col05_f09cSizeDesc_v50.FieldName = "f09cSizeDesc_v50"
            col06_f11cQualityDesc_v50.FieldName = "f11cQualityDesc_v50"
            col07_f13cBrandDesc_v50.FieldName = "f13cBrandDesc_v50"
            col08_f14nBeratPerButir_n92.FieldName = "f14nBeratPerButir_n92"
            col09_f15nHargaPerGram_n92.FieldName = "f15nHargaPerGram_n92"
            col010_f32dCreatedDate.FieldName = "f32dCreatedDate"

        End With

        _gcMasterStone.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        _gcMasterStone.LookAndFeel.UseDefaultLookAndFeel = False
        _gcMasterStone.DataSource = Nothing
        _gcMasterStone.DataSource = prop_01dt23MCSTONES
        _gcMasterStone.Refresh()

    End Sub

#End Region

#Region " From : Evnt"

    Private Sub ucGridMasterStone_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm01initFillGrid()
    End Sub

    Private Sub _gcMasterStone_Click(sender As Object, e As EventArgs) Handles _gcMasterStone.Click
        _gcMasterStone.ShowPrintPreview()
    End Sub

#End Region

End Class
