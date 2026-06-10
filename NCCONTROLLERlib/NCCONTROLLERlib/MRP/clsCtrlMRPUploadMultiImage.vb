Public Class clsCtrlMRPUploadMultiImage
    Implements IDisposable

    Public Property prop_dtImage As DataTable

    Private Function creatMASTERIMAGEMultipel() As DataTable
        Dim dtDataTable As New DataTable

        Dim ImgName As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "ImageName", .DefaultValue = ""}
        dtDataTable.Columns.Add(ImgName)

        Dim objImage As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Byte[]"), .ColumnName = "objImage"}
        dtDataTable.Columns.Add(objImage)

        Dim nCheck As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "nCheck", .DefaultValue = 0}
        dtDataTable.Columns.Add(nCheck)

        Dim bCheck As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Byte"), .ColumnName = "bCheck", .DefaultValue = 0}
        dtDataTable.Columns.Add(bCheck)

        Return dtDataTable
    End Function

    Public Sub dtInitMASTERIMAGEMULTIPLE()
        prop_dtImage = Nothing
        prop_dtImage = creatMASTERIMAGEMultipel()
        prop_dtImage.Clear()
    End Sub

    Public Sub dtAddNewMASTERIMAGEMULTIPLE(ByVal prmIMGName As String, ByVal prmObjImage As Byte())

        Dim objdDatarow As DataRow = prop_dtImage.NewRow()

        objdDatarow("ImageName") = prmIMGName
        objdDatarow("objImage") = prmObjImage
        objdDatarow("nCheck") = 0
        objdDatarow("bCheck") = 0

        prop_dtImage.Rows.Add(objdDatarow)
    End Sub


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
