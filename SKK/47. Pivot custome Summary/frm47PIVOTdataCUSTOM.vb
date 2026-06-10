Imports DevExpress.XtraPivotGrid

Public Class frm47PIVOTdataCUSTOM
    Implements IDisposable

#Region " form Evnt "

    Private Sub frm47PIVOTdataCUSTOM_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm02InitField()
    End Sub
#End Region

#Region " Custome Methods "
    Private Sub cm02InitField()
        '*** Pivot Field *** 
        pcCol01_f02Int.FieldName = "f02Int"  ' tahun
        pcCol02_f03Int.FieldName = "f03Int"  ' bulan
        pcCol03_f02String.FieldName = "f02String" ' Brand
        pcCol04_f01Double.FieldName = "f01Double" ' beraty

        col_2024.FieldName = "2024" ' beraty
        col_2023.FieldName = "2023" ' beraty

        pcCol03_f02String.Options.ShowTotals = False

        'sutome filed
        Dim _colTotalTahun24 As New PivotGridField() With {.FieldName = "nSegmentPersen", .Area = PivotArea.DataArea, .Caption = "% Segment", .Name = "PersentSegment"}

        _colTotalTahun24.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        _colTotalTahun24.CellFormat.FormatString = "{0:n2} %"
        PivotGridControl1.Fields.Add(_colTotalTahun24)
    End Sub

    Private Sub getdata()
        'getTEst
        Dim pthasil As New DataTable
        pthasil.Clear()

        Using objget As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl
            pthasil = objget.GetTEST
        End Using

        If pthasil.Rows.Count > 0 Then
            PivotGridControl1.DataSource = pthasil
        End If

    End Sub

#End Region

#Region " Control Evnt "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        getdata()
    End Sub


#End Region

#Region " Grid Evnt "


    Private Sub PivotGridControl1_CustomCellValue(sender As Object, e As PivotCellValueEventArgs) Handles PivotGridControl1.CustomCellValue

        'Dim summaryValue1 As Double = e.GetFieldValue(_da04nTotCarat)
        'Dim summaryValue2 As Double = e.GetFieldValue(_da01f03nUnit)

        'Dim summaryValue = PivotGridControl.GetCellValue(Nothing, Nothing, _da04nTotCarat)
        If e.DataField.Name = "PersentSegment" Then
            If e.RowValueType = PivotGridValueType.GrandTotal Then
                e.Value = Nothing
                Return
            End If

            ' Total semua berat
            'Dim summaryValue = PivotGridControl1.GetCellValue(Nothing, Nothing, pcCol04_f01Double)
            Dim summaryValue = e.GetFieldValue(pcCol04_f01Double)

            ' Total Berat by value
            ' https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.GetCellValue(System.Object---System.Object--)
            Dim total = e.GetFieldValue(col_2024)
            e.Value = total
        Else
            Return
        End If
    End Sub

#End Region

End Class