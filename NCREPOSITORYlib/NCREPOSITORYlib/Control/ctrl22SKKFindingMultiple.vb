Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Popup

Public Class ctrl22SKKFindingMultiple
    Inherits CheckedComboBoxEdit
    Implements IDisposable

    Public Property _01prop_dtFindingComponentSKK As DataTable

    Private dvViewFindingComponentSKK As New DataView

    Public Sub _02BindingAwalDataSource()
        With Me.Properties
            .DisplayMember = "cNamaFindingFull"
            .ValueMember = "k01cKodeItemFindingComponent_v50"
            With .Appearance
                .Font = New Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point)
                .ForeColor = Color.Navy
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default
            End With
        End With

        dvViewFindingComponentSKK = dvMasterSKK()
        Properties.DataSource = dvViewFindingComponentSKK
    End Sub

    Private Function dvMasterSKK() As DataView
        Dim pcKolomData = New String() {"k01cKodeItemFindingComponent_v50", "cNamaFindingFull", "isChecked"}
        Dim dvView As DataView = New DataView(_01prop_dtFindingComponentSKK)

        Dim dtTemp As New DataTable
        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterSKK = New DataView(dtTemp)

        Return dvMasterSKK
    End Function

    Public Function _03GetEditValue() As List(Of String)
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
    Private Sub ctrl22SKKFindingMultiple_Popup(sender As Object, e As EventArgs) Handles Me.Popup
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

End Class