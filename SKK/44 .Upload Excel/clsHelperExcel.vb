'Imports DevExpress.DataAccess.Excel
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.DataAccess.Excel

Public Class clsHelperExcel

    Dim objDialog As New OpenFileDialog

    Public Property PactLabel As String = ""

    Public Function cm01UploadFileExecl(ByVal prmSheetName As String)

        Dim PdtHasil As New DataTable
        PdtHasil.Clear()

        objDialog.Filter = "(*.xlsx)|*.xlsx|(*.xls)|*.xls|All files (*.*)|*.*"
        ' objDialog.ShowDialog()

        Dim myExcelSource As New ExcelDataSource()
        If objDialog.ShowDialog() = DialogResult.OK Then

            PactLabel = objDialog.FileName.ToString

            myExcelSource.FileName = PactLabel '"D:\Aris\ArisCode\JATINOM\Trial\20200701.xlsx"
            'Dim worksheetSettings As New ExcelWorksheetSettings("MasterOrder")
            Dim worksheetSettings As New ExcelWorksheetSettings(prmSheetName)
            myExcelSource.SourceOptions = New ExcelSourceOptions(worksheetSettings)
            myExcelSource.SourceOptions.SkipEmptyRows = True
            myExcelSource.SourceOptions.UseFirstRowAsHeader = True
            myExcelSource.Fill()
            ' gcExcel.DataSource = myExcelSource

            'pdtUpload = _cmUP00COpyDataTabelForcek(ToDataTable(myExcelSource))
            'gcExcel.DataSource = Nothing
            'gcExcel.DataSource = pdtUpload
            'gcExcel.RefreshDataSource()

            '_02LabelTotal.Text = ""
            '_02LabelTotal.Text = CStr(gvExcel.RowCount) & " data "
        End If

        Return ToDataTable(myExcelSource)
    End Function

    Public Function ToDataTable(ByVal excelDataSource As ExcelDataSource) As DataTable
        Dim list As IList = (CType(excelDataSource, IListSource)).GetList()
        Dim dataView As DevExpress.DataAccess.Native.Excel.DataView = CType(list, DevExpress.DataAccess.Native.Excel.DataView)
        Dim props As List(Of DevExpress.DataAccess.Native.Excel.ViewColumn) = dataView.Columns

        Dim table As New DataTable()
        For i As Integer = 0 To props.Count - 1
            Dim prop As PropertyDescriptor = props(i)
            table.Columns.Add(prop.Name, prop.PropertyType)
        Next i
        Dim values(props.Count - 1) As Object
        For Each item As DevExpress.DataAccess.Native.Excel.ViewRow In list
            For i As Integer = 0 To values.Length - 1
                values(i) = props(i).GetValue(item)
            Next i
            table.Rows.Add(values)
        Next item
        Return table
    End Function

End Class
