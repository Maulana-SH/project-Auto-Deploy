'*** GENERATE FROM CASE 2022 *** 
'===============================
'INFORMATION  
'Author : Maulana SH 
'VISUAL STUDIo Version : 2022  
'Devexpress Version : V21.2.5  
'******************************* 
Imports DevExpress.XtraGrid.Views.Grid
Imports NCMODELlib

Public Class uc23JAA01ReprotSOWH


#Region "From Event"
    Private Sub uc23JAA01ReprotSOWH_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cm01InitControl()
        cm02InitField()
    End Sub

#End Region

#Region "Custome Methods"

    Private Sub cm02InitField()
        '*** Pivot Field ***
        pcCol01_k01String.FieldName = "k01String"
        pcCol02_k03String.FieldName = "k03String"
        pcCol03_k04String.FieldName = "k04String"
        pcCol04_k05String.FieldName = "k05String"
        pcCol05_f01Int.FieldName = "f01Int"
        pcCol06_f01Double.FieldName = "f01Double"
        pcCol07_f01Date.FieldName = "f01Date"
        pcCol08_f01Datetime.FieldName = "f01Datetime"
        pcCol09_f01IDUser.FieldName = "f01IDUser"
        pcCol10_f01NamaUser.FieldName = "f01NamaUser"

        '*** Pivot Field ***
        GridView1.OptionsView.ShowFooter = True
        GridView1.IndicatorWidth = 50
        gcCol01_k01String.FieldName = "k01String"
        gcCol02_k03String.FieldName = "k03String"
        gcCol03_k04String.FieldName = "k04String"
        gcCol04_k05String.FieldName = "k05String"
        gcCol05_f01Int.FieldName = "f01Int"
        gcCol06_f01Double.FieldName = "f01Double"
        gcCol07_f01Date.FieldName = "f01Date"
        gcCol08_f01Datetime.FieldName = "f01Datetime"
        gcCol09_f01IDUser.FieldName = "f01IDUser"
        gcCol10_f01NamaUser.FieldName = "f01NamaUser"

        gcCol05_f01Int.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gcCol05_f01Int.SummaryItem.FieldName = "f01Int"
        gcCol05_f01Int.SummaryItem.DisplayFormat = "{0:n0} Pcs"

        gcCol06_f01Double.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        gcCol06_f01Double.SummaryItem.FieldName = "f01Double"
        gcCol06_f01Double.SummaryItem.DisplayFormat = "{0:n2} Grm"
    End Sub

    Private Sub cm03GetDataSO()
        Me.Cursor = Cursors.WaitCursor
        ' 1. Get All
        ' 2. Get data By SPK
        ' 3. Get By Nik User
        Dim pdtHasil As New DataTable
        pdtHasil.Clear()

        Using objData As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 1,
                                                            .prop_KeyString01 = "",
                                                            .prop_KeyString02 = ""}
            pdtHasil = objData.sele01WS
        End Using

        If pdtHasil.Rows.Count > 0 Then

            GridControl1.DataSource = pdtHasil
            GridControl1.RefreshDataSource()

            PivotGridControl1.DataSource = pdtHasil
            PivotGridControl1.RefreshData()
        Else
            MsgBox("Maaf... Tidak ada Data yang di temukan ...")
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Function cm02GetDataSO(ByVal prmnTarget As Integer, ByVal prmSKU As String, ByVal prmNIKUser As String) As DataTable
        ' 1. Get All
        ' 2. Get data By SPK
        ' 3. Get By Nik User

        Dim pdtHasil As New DataTable
        pdtHasil.Clear()

        Using objData As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = prmnTarget,
                                                            .prop_KeyString01 = prmSKU,
                                                            .prop_KeyString02 = prmNIKUser}
            pdtHasil = objData.sele01WS
        End Using

        Return pdtHasil
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cm03GetDataSO()
    End Sub


#End Region

#Region "Control Event"


    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                PivotGridControl1.ShowPrintPreview()
            Case 1
                GridView1.ShowPrintPreview()
        End Select
    End Sub

#End Region

#Region "Grid Evnt"

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        ' Put This code in Init FieldName    
        ' GridView1.IndicatorWidth = 50 

        '# Methods In GridView
        'CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1 'e.RowHandle.ToString()
        End If
    End Sub


#End Region
End Class
