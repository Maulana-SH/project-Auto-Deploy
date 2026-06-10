Imports DevExpress.Pdf.Native
Imports DevExpress.XtraGrid.Views.Base
Imports NCMODELlib

Public Class frm58VerisonHistori
    Implements IDisposable

    Private pdtVerison As DataTable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtVerison = New DataTable
    End Sub

#Region " form Evnt "

    Private Sub frm58VerisonHistori_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm02InitField()
    End Sub
#End Region

#Region " Custome Methods "

    Private Sub cm02InitField()
        ' Di Form_Load
        'TileView1.OptionsTiles.ItemSize.Height = 0 ' Wajib 0 untuk Auto-Height
        'TileView1.OptionsTiles.ItemAutoHeightMode = DevExpress.XtraGrid.Views.Tile.TileItemAutoHeightMode.CalculateViaHtml
        'TileView1.OptionsTiles.Orientation = Orientation.Vertical 

        TileView1.OptionsHtmlTemplate.AllowContentSelection = DevExpress.Utils.DefaultBoolean.True
        TileView1.OptionsHtmlTemplate.ItemAutoHeight = True


        col01_f03nPatchVersion_int.FieldName = "f03nPatchVersion_int"
        col02_f00cBuildNumber_v50.FieldName = "f00cBuildNumber_v50"
        col03_f04cNotesBuild_vMax.FieldName = "f04cNotesBuild_vMax"
        col04_f10dCreated_datetime.FieldName = "f10dCreated_datetime"
        col05_f11cPatchCode_v50.FieldName = "f11cPatchCode_v50"
        col06_k01cVersionApp_v50.FieldName = "k01cVersionApp_v50"
        col07_f01nMajorVersion_int.FieldName = "f01nMajorVersion_int"
        col08_f02nMinorVersion_int.FieldName = "f02nMinorVersion_int"

    End Sub

    Private Sub cm03loadData()
        pdtVerison.Clear()

        Using objGet As clsSUPPORTCENTER_iface = New clsSUPPORTCENTER_impl With {.prop_keyInt01 = 6,
                                                                                .prop_keyString01 = "V2",
                                                                                .prop_keyString02 = "APP-001"}
            pdtVerison = objGet.select01targte_02String("sp100SIMATICBUILDVERSIONINGAPPSele")
        End Using

        If pdtVerison.Rows.Count > 0 Then

            'For Each row As DataRow In pdtVerison.Rows
            '    row("f04cNotesBuild_vMax") = FormatNotesToHtml(row("f04cNotesBuild_vMax").ToString())
            'Next

            GridControl1.DataSource = Nothing
            GridControl1.DataSource = pdtVerison
            GridControl1.Refresh()
        Else
            MsgBox("Tidak ada Di Temukan")
        End If
    End Sub

    Private Function FormatNotesToHtml(text As String) As String
        If String.IsNullOrEmpty(text) Then Return ""

        Dim lines = text.Split({vbCrLf, vbLf}, StringSplitOptions.None)
        Dim sb As New System.Text.StringBuilder()

        For Each line In lines
            Dim t = line.Trim()

            If t.StartsWith("#") Then
                Dim content = t.Substring(1).Trim()
                sb.Append("<b>" & EncodeHtml(content) & "</b><br/>")
            Else
                sb.Append(EncodeHtml(line) & "<br/>")
            End If
        Next

        Return sb.ToString()
    End Function

    Private Function EncodeHtml(text As String) As String
        If text Is Nothing Then Return ""
        Return text.Replace("&", "&amp;") _
               .Replace("<", "&lt;") _
               .Replace(">", "&gt;")
    End Function
#End Region

#Region " Control Evnt "


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm03loadData()
    End Sub

    'Private Sub TileView1_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles TileView1.CustomColumnDisplayText
    '    If e.Column.FieldName = "f04cNotesBuild_vMax" AndAlso e.Value IsNot Nothing Then
    '        e.DisplayText = FormatNotesToHtml(e.Value.ToString())
    '    End If
    'End Sub

#End Region

#Region " Grid Evnt "

#End Region


End Class