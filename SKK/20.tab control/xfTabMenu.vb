Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Public Class xfTabMenu
    Implements IDisposable

    Dim cxMsgbox As New XtraMessageBoxArgs
    Dim pageActive As Integer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pageActive = 0
    End Sub

    Private Sub xfTabMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        _01pageActive.EditValue = pageActive
    End Sub


#Region "Costume Methods"

    Private Sub _cm01AddMenu(ByVal prmTitel As String)
        Dim prmBatasPage As Integer = 5 - 1

        'pageActive = tabMain.TabPages.Count

        If pageActive > prmBatasPage Then
            MsgBox("TabPage Maximal (5) page")
        Else
            Dim prmNew As New XtraTabPage

            With prmNew
                .Text = prmTitel
                .Tag = prmTitel
            End With
            tabMain.TabPages.Add(prmNew)
            pageActive = pageActive + 1
        End If

        _01pageActive.EditValue = pageActive
        _01pageActive.Refresh()
    End Sub

    Private Sub _cm02RmvTab(ByVal prmIndex As Integer)
        tabMain.TabPages.RemoveAt(prmIndex)
    End Sub

    Private Sub _cm03Msg()
        cxMsgbox.Caption = "Message"
        cxMsgbox.Text = "Buttons in this message box show have custom images."
        cxMsgbox.Buttons = New DialogResult() {DialogResult.OK, DialogResult.Cancel, DialogResult.Retry}
        AddHandler cxMsgbox.Showing, AddressOf cxMsgbox_show
    End Sub

    Private Sub cxMsgbox_show(sender As Object, e As XtraMessageShowingArgs)
        For Each control In e.Form.Controls

            Dim button As SimpleButton = TryCast(control, SimpleButton)

            If button IsNot Nothing Then
                button.ImageOptions.SvgImageSize = New Size(16, 16)
                'button.Height = 25;
                Select Case button.DialogResult.ToString()
                    Case ("OK")
                        button.ImageOptions.SvgImage = SvgImageCollection1(0)
                    Case ("Cancel")
                        button.ImageOptions.SvgImage = SvgImageCollection1(1)
                    Case ("Retry")
                        button.ImageOptions.SvgImage = SvgImageCollection1(2)
                End Select
            End If

        Next control
    End Sub


#End Region

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim prmIidx As Integer = 0
        Dim prmTitel As String = ""
        prmIidx = pageActive + 1

        prmTitel = "menu Tab " & prmIidx

        _cm01AddMenu(prmTitel)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        _cm02RmvTab(tabMain.SelectedTabPageIndex)
        pageActive = pageActive - 1
        _01pageActive.EditValue = pageActive
    End Sub

    Private Sub tabMain_CloseButtonClick(sender As Object, e As EventArgs) Handles tabMain.CloseButtonClick
        ' _cm02RmvTab(tabMain.SelectedTabPageIndex)
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)
        TryCast(arg.Page, XtraTabPage).PageVisible = False
        pageActive = pageActive - 1
        _01pageActive.EditValue = pageActive
    End Sub

End Class