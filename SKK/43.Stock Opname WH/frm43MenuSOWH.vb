Imports DevExpress.XtraSplashScreen

Public Class frm43MenuSOWH

    Implements IDisposable

#Region " Form Evnt "

#End Region

#Region " Costume Methods "


#Region " MDI Manager Tab "

#Region "method - mditabmanager"

    Private Sub _mdi01ViewChildForm(ByVal prmFormForDisplay As Form)
        Cursor.Current = Cursors.WaitCursor

        If Not _mdi02IsFormActived(prmFormForDisplay) Then
            'prmFormForDisplay.MdiParent = oTabMDIMgr.MdiParent
            'prmFormForDisplay.Show()


            SplashScreenManager.ShowForm(Me, GetType(WaitForm2), True, True, True)
            Try
                prmFormForDisplay.MdiParent = oTabMDIMgr.MdiParent
                prmFormForDisplay.Show()
            Finally
                'Close Wait Form
                SplashScreenManager.CloseForm(False)
            End Try
        End If

        Cursor.Current = Cursors.Default
    End Sub

    Private Function _mdi02IsFormActived(ByVal prmFormForDisplay As Form) As Boolean
        Dim IsOpenend As Boolean = False

        If oTabMDIMgr.MdiParent.MdiChildren.Count() > 0 Then
            For Each item In oTabMDIMgr.MdiParent.MdiChildren
                If prmFormForDisplay.Name = item.Name Then
                    oTabMDIMgr.Pages(item).MdiChild.Activate()
                    IsOpenend = True
                End If
            Next
        End If

        Return IsOpenend
    End Function


#End Region

#End Region

#End Region

#Region " Control Evnt "


    Private Sub br01_MenuSOWH_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles br01_MenuSOWH.ItemClick
        'reprint SPK uc22JE01GridReprintSpk

        ' Dim objReprintSPK As New frm41 With {.propMaster = propMaster, .propGlobal = propGlobal, .Dock = DockStyle.Fill}
        Dim objReprintSPK As New frm41StokOpnameWH With {.Dock = DockStyle.Fill}

        ' _cmSetContentViews("uc22IVAA01ProductionOrder", "BUAT SPK", objCreateSP)

        Dim objNew As New DevExpress.XtraEditors.XtraForm

        With objNew
            .Name = "frm41StokOpnameWH"
            .Text = "Stok Opane WareHouse"
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .Controls.Add(objReprintSPK)
        End With

        _mdi01ViewChildForm(objNew)
    End Sub

    Private Sub br02_ReportSO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles br02_ReportSO.ItemClick
        ' Dim objReprintSPK As New frm41 With {.propMaster = propMaster, .propGlobal = propGlobal, .Dock = DockStyle.Fill}
        Dim objReportSO As New uc23JAA01ReprotSOWH With {.Dock = DockStyle.Fill}

        ' _cmSetContentViews("uc22IVAA01ProductionOrder", "BUAT SPK", objCreateSP)

        Dim objNew As New DevExpress.XtraEditors.XtraForm

        With objNew
            .Name = "uc23JAA01ReprotSOWH"
            .Text = "Report SO WareHouse"
            .WindowState = FormWindowState.Maximized
            .Dock = DockStyle.Fill
            .Controls.Add(objReportSO)
        End With

        _mdi01ViewChildForm(objNew)
    End Sub

    Private Sub frm43MenuSOWH_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
        Application.Exit()
    End Sub

#End Region

#Region " Grid Evnt "

#End Region

End Class