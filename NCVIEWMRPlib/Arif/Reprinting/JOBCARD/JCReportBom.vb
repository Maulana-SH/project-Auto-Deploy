Imports System.Drawing.Printing

Public Class JCReportBom
    Implements IDisposable

    Public Property prop_01MaterialCode As String
    Public Property prop_02MaterialDesc As String
    Public Property prop_03Qty As Integer
    Public Property prop_04Gram As Double
    Public Property prop_05TableName As String
    Public Property prop_06FGCODE As String
    Public Property prop_07DataTable As DataTable

    Private Sub SpkReportBom_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01InitPrint()
    End Sub

#Region " Private : Method"

    Private Sub _cm01InitPrint()
        _col01MaterialCode.Text = "[f01cKodeMaterial_v50]"
        _col02MaterialDecs.Text = "[f02cMaterialDesc_v50]"
        _col03Qty.Text = "[f03nQty]"
        _col04Gram.Text = "[f04nGram_n92]"
    End Sub

#End Region


End Class