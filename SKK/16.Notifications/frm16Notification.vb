Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraPrinting.XamlExport
Imports DevExpress.Drawing.Internal
Imports DevExpress.Utils.Svg
Imports System.Windows
Imports Size = System.Drawing.Size
Imports DevExpress.XtraBars.Alerter
Public Class frm16Notification


    Private Sub frm16Notification_Load(sender As Object, e As EventArgs) Handles Me.Load
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim myicon As New SvgImageCollection

        myicon.Add("Succces", "image://svgimages/icon builder/actions_checkcircled.svg")
        myicon.Add("Mail", "image://svgimages/outlook inspired/glyph_mail.svg")
        myicon.Add("Error", "image://svgimages/icon builder/actions_deletecircled.svg")
        myicon.Add("Info", "image://svgimages/icon builder/actions_info.svg")
        myicon.Add("Warning", "image://svgimages/business objects/bo_attention.svg")

        'AlertControl1.FormLocation = AlertFormLocation.TopRight
        myAlert.LookAndFeel.UseDefaultLookAndFeel = False
        'myAlert.LookAndFeel.SetSkinStyle(SkinStyle.SevenClassic) 'them succes
        myAlert.LookAndFeel.SetSkinStyle(SkinStyle.Bezier) 'them succes
        myAlert.AllowHtmlText = True
        myAlert.ShowPinButton = False
        myAlert.Show(Me, "<color=white><size=11>SUCCESS</color>", "<size=9>Mutasi ZN123432 Berhasil Ke proses Berikuta", "New pesan baru", myicon.GetImage(1, New System.Drawing.Size(45, 45)))
        ' myAlert.Show(Me, "<color=Green><size=12>SUCCESS</color>", "<size=10>Mutasi ZN123432 Berhasil Ke proses Berikuta", "", iconSucces)


    End Sub

    'Private Sub AlertControl1_BeforeFormShow(sender As Object, e As AlertFormEventArgs)
    '    'Make the Alert Window opaque
    '    e.AlertForm.OpacityLevel = 1
    'End Sub

    'Private Sub AlertControl1_AlertClick(sender As Object, e As AlertClickEventArgs)
    '    Dim msg As Message = TryCast(e.Info.Tag, Message)
    '    XtraMessageBox.Show(msg.Text, msg.Caption)
    'End Sub

    Public Class Message
        Public Sub New()
            Me.Caption = "INi Caotion Nya"
            Me.Text = "INi tek pesan nya di isi apa aja"
            Me.Image = My.Resources.DM
        End Sub
        Public Property Caption() As String
        Public Property Text() As String
        Public Property Image() As Image
    End Class

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim _cxNotif As New clsAlertNotif

        _cxNotif.ShowPesan(Me, clsAlertNotif.TypeMsg.Msg_Success, "Berhasil di amutasikan")
        _cxNotif.ShowPesan(Me, clsAlertNotif.TypeMsg.Msg_Error, "Gagal di amutasikan")
        _cxNotif.ShowPesan(Me, clsAlertNotif.TypeMsg.Msg_Warning, "TErjadi Gagal di amutasikan")
        _cxNotif.ShowPesan(Me, clsAlertNotif.TypeMsg.Msg_Info, "PEringantan")

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        'Dim action As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() With {.Caption = "Confirm", .Description = "Close the application?"}
        'Dim predicate As Predicate(Of DialogResult) = AddressOf canCloseFunc
        'Dim command1 As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() With {.Text = "Close", .Result = System.Windows.Forms.DialogResult.Yes}
        'Dim command2 As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() With {.Text = "Cancel", .Result = System.Windows.Forms.DialogResult.No}
        'action.Commands.Add(command1)
        'action.Commands.Add(command2)
        'Dim properties As New FlyoutProperties()
        'properties.ButtonSize = New Size(100, 40)
        'properties.Style = FlyoutStyle.MessageBox
        'FlyoutDialog.Show()

        'If FlyoutDialog.Show(Me, action, properties, predicate) = System.Windows.Forms.DialogResult.Yes Then
        '    Me.Cancel = False
        'Else
        '    e.Cancel = True
        'End If
    End Sub
    Private Shared Function canCloseFunc(ByVal parameter As DialogResult) As Boolean
        Return parameter <> DialogResult.Cancel
    End Function

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        'ToastNotificationsManager1.ShowNotification(ToastNotificationsManager1.Notifications(3))
        'or
        ToastNotificationsManager1.ShowNotification("d8119aee-e777-456f-a635-9ea91c09dbdf")

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click

        MsgBox("skrng wkt tanggal " & Today + TimeOfDay)

    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        '    Dim args As New XtraMessageBoxArgs() With {
        '    ' Sets the caption of the message box.
        '    .Caption = "Warning",
        '    ' Sets the message of the message box.
        '    .Text = "Do you want to install this software?",
        '    ' Sets the buttons of the message box.
        '    .Buttons = {DialogResult.Yes, DialogResult.No},
        '    ' Sets the icon of the message box from the collection.
        '    .ImageOptions = New MessageBoxImageOptions() With {
        '        .SvgImage = svgImageCollection1(0),
        '        .SvgImageSize = New Size(24, 24)
        '    }
        '}
        '' Displays the message box and checks if a user clicked "No".
        'If XtraMessageBox.Show(args) = DialogResult.Yes Then
        '        e.Cancel = True
        '    End If

        'If XtraMessageBox.Show("Do you want to quit the application?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.No Then
        '    'e.Cancel = True
        'End If

        Dim myicon As New SvgImageCollection

        ' urutan jgn di balik harus sama senagn ENUM di atas untuk akases Image SVG nya
        myicon.Add("Succces", "image://svgimages/icon builder/actions_checkcircled.svg")
        myicon.Add("Error", "image://svgimages/icon builder/actions_deletecircled.svg")
        myicon.Add("Info", "image://svgimages/icon builder/actions_info.svg")
        myicon.Add("Warning", "image://svgimages/business objects/bo_attention.svg")

        'Dim args As New XtraMessageBoxArgs() With {.Caption = "Warning",
        '    .AllowHtmlText = True,
        '    .Text = " Do you want to install this software?",
        '    .Buttons = {DialogResult.Yes, DialogResult.No},
        '.ImageOptions = New MessageBoxImageOptions() With {
        '    .SvgImage = myicon(1),
        '    .SvgImageSize = New Size(50, 50)
        '}}

        '' Displays the message box and checks if a user clicked "No".
        'If XtraMessageBox.Show(args) = DialogResult.Yes Then
        '    'e.Cancel = True
        'End If

    End Sub

    Private Sub myAlert_BeforeFormShow(sender As Object, e As AlertFormEventArgs) Handles myAlert.BeforeFormShow
        'Make the Alert Window opaque
        e.AlertForm.OpacityLevel = 1
    End Sub
End Class