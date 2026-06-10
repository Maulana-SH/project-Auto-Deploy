Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraPrinting.Preview

Public Class clsAlertNotif
    Inherits DevExpress.XtraBars.Alerter.AlertControl

    Enum TypeMsg
        Msg_Success = 0
        Msg_Error = 1
        Msg_Info = 2
        Msg_Warning = 3
    End Enum

    Public Sub ShowPesan(ByVal prmFormName As Form, ByVal prmType As TypeMsg, ByVal prmPesan As String)


        Dim myicon As New SvgImageCollection

        myicon.Add("Succces", "image://svgimages/icon builder/actions_checkcircled.svg")
        myicon.Add("Error", "image://svgimages/icon builder/actions_deletecircled.svg")
        myicon.Add("Info", "image://svgimages/icon builder/actions_info.svg")
        myicon.Add("Warning", "image://svgimages/business objects/bo_attention.svg")

        'AlertControl1.FormLocation = AlertFormLocation.TopRight
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.LookAndFeel.SetSkinStyle(SkinStyle.SevenClassic) 'them succes
        Me.AllowHtmlText = True
        Me.ShowPinButton = False

        Dim Caption As String = ""

        Select Case prmType
            Case TypeMsg.Msg_Success
                Caption = "<color=Green><size=12>SUCCESS</color>"
            Case TypeMsg.Msg_Error
                Caption = "<color=Red><size=12>ERROR</color>"
            Case TypeMsg.Msg_Info
                Caption = "<color=blue><size=12>Infromation</color>"
            Case TypeMsg.Msg_Warning
                Caption = "<color=Orange><size=12>Infromation</color>"
        End Select



        Show(prmFormName, Caption, "<size=10>" & prmPesan, "", myicon.GetImage(prmType, New Size(65, 65)))


        ''FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight
        ''Show(prmFormName, msg.Caption, msg.Text, "", msg.Image, msg)


    End Sub
End Class
