
Imports System.Drawing
    Imports System.Windows.Forms
    Imports DevExpress.Utils.Win
    Imports DevExpress.XtraEditors
    Imports DevExpress.XtraEditors.Controls
    Imports DevExpress.XtraEditors.Popup

Public Class clsMltp22FCI
    Inherits CheckedComboBoxEdit
    Implements IDisposable

    Public Property _01prop_dtMasterSKK As DataTable
    Public Property _02prop_FilterKodeMasterSKK As String

    Private dvViewMasterSKK As New DataView

    Public Sub _03BindingAwalDataSource()
        With Me.Properties
            .DisplayMember = "f01cItemFindingComponentDesc_v50"
            .ValueMember = "k01cKodeItemFindingComponent_v50"
            With .Appearance
                .Font = New Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point)
                .ForeColor = Color.Navy
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
            End With
        End With

        dvViewMasterSKK = dvMasterSKK()
        Properties.DataSource = dvViewMasterSKK
    End Sub

    Private Function dvMasterSKK() As DataView
        Dim pcKolomData = New String() {"f03cJenisFindingComponentDesc_v50", "k01cKodeItemFindingComponent_v50",
                                        "f01cItemFindingComponentDesc_v50"}
        Dim dvView As DataView = New DataView(_01prop_dtMasterSKK)

        Dim dtTemp As New DataTable
        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterSKK = New DataView(dtTemp)

        Return dvMasterSKK
    End Function

    Public Sub _04FilterDataViewMasterSKK()
        With dvViewMasterSKK
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterSKK
            .Sort = "f03cJenisFindingComponentDesc_v50"
            .RowFilter = String.Format(" f03cJenisFindingComponentDesc_v50 = '{0}' ", _02prop_FilterKodeMasterSKK)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        'Alter field table "isChecked", jika belum ada kolom tsb.
        Dim pdtTableTemp As New DataTable
        pdtTableTemp = dvViewMasterSKK.ToTable()

        If Not pdtTableTemp.Columns.Contains("isChecked") Then
            Dim dcChecked = New DataColumn("isChecked", GetType(Boolean))
            pdtTableTemp.Columns.Add(dcChecked)
        End If

        If pdtTableTemp.Rows.Count > 0 Then
            For Each dtRow As DataRow In pdtTableTemp.Rows
                dtRow("isChecked") = False
            Next
        End If

        dvViewMasterSKK = pdtTableTemp.AsDataView

        Properties.DataSource = Nothing
        Properties.DataSource = dvViewMasterSKK
    End Sub

    Public Function _05GetEditValue() As List(Of String)
        Dim displayValues As String = Me.Properties.GetCheckedItems(Me.EditValue)
        Dim valuesCode As List(Of String) = displayValues.Split(Me.Properties.SeparatorChar).ToList()

        Return valuesCode

        '**** PEMAKAIAN ****
        'For Each itm As String In valuesCode
        '    MsgBox(itm)
        'Next
        '**** PEMAKAIAN ****
    End Function

    Private list As New CheckedListBoxControl()
    Private subscribe As Boolean = True
    Private checkedItems As New List(Of CheckedListBoxItem)()
    Private Sub ctrl51SKKValueMasterMultiple_Popup(sender As Object, e As EventArgs) Handles Me.Popup

        If subscribe Then ' 1st approach
            Dim f As CheckedPopupContainerForm = TryCast((TryCast(sender, IPopupControl)).PopupWindow, CheckedPopupContainerForm)
            list = TryCast(f.ActiveControl, CheckedListBoxControl)
            AddHandler list.ItemCheck, AddressOf list_ItemCheck

            subscribe = False
        End If
    End Sub

    Private Sub list_ItemCheck(sender As Object, e As Controls.ItemCheckEventArgs)
        Dim listBox As CheckedListBoxControl = TryCast(sender, CheckedListBoxControl)
        Dim checkedComboBoxEdit As CheckedComboBoxEdit = TryCast((CType(listBox.Parent, DevExpress.XtraEditors.PopupContainerControl)).OwnerEdit, CheckedComboBoxEdit)

        If e.Index = 0 Then
            For Each dtRow As DataRowView In checkedComboBoxEdit.Properties.DataSource
                If e.State = CheckState.Checked Then dtRow("isChecked") = True
                If e.State = CheckState.Unchecked OrElse e.State = CheckState.Indeterminate Then dtRow("isChecked") = False
            Next
        Else
            Dim dtRow As DataRowView = TryCast((TryCast(checkedComboBoxEdit.Properties.DataSource, IList))(e.Index - 1), DataRowView)
            If e.State = CheckState.Checked Then dtRow("isChecked") = True
            If e.State = CheckState.Unchecked OrElse e.State = CheckState.Indeterminate Then dtRow("isChecked") = False
        End If

    End Sub

#Region "Disposible"
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub



#End Region

End Class
