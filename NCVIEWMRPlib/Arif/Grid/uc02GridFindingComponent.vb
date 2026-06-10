Imports NCCONTROLLERlib
Imports NCREPOSITORYlib
Public Class uc02GridFindingComponent
    Implements IDisposable

    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""

    Public Property prop_01dt22MCFINDINGCOMPONENT As New DataTable   'ambil 21

#Region "Costum Color Code"

    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = ""

    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""
#End Region

#Region "from :Event"

    Private Sub ucGridFindingComponent_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm01InitfillGrid()
    End Sub

#End Region

#Region "Costum : Meyhods"

    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function

    Sub _cm01InitfillGrid()

        With _gvFindingComponent

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

            col01_k01cKodeItemFindingComponent_v50.FieldName = "k01cKodeItemFindingComponent_v50"
            col02_f03cJenisFindingComponentDesc_v50.FieldName = "f03cJenisFindingComponentDesc_v50"
            col03_f04cSize_v50.FieldName = "f04cSize_v50"
            col04_f06cKadarDesc_v50.FieldName = "f06cKadarDesc_v50"
            col05_f08cWarnaDesc_v50.FieldName = "f08cWarnaDesc_v50"
            col06_f09nBeratPerPcs_n92.FieldName = "f09nBeratPerPcs_n92"
            col07_f32dCreatedDate.FieldName = "f32dCreatedDate"

        End With

        _gcFindingComponent.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        _gcFindingComponent.LookAndFeel.UseDefaultLookAndFeel = False
        _gcFindingComponent.DataSource = Nothing
        _gcFindingComponent.DataSource = prop_01dt22MCFINDINGCOMPONENT
        _gcFindingComponent.Refresh()

    End Sub

    Private Sub _gcFindingComponent_Click(sender As Object, e As EventArgs) Handles _gcFindingComponent.Click
        _gcFindingComponent.ShowPrintPreview()
    End Sub

#End Region

End Class
