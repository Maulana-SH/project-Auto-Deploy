Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass>
Public Class clsUnitest

    Private Function cm19CekKonversiKadarByItem(ByVal prmKodeItem As String, ByVal prmKodekadar As String, ByVal prop_Master51ParentChild As DataTable)
        '***************************************************************
        ' Jumat : 15 Juli 2025
        ' hanya Item Chain
        ' MTIPBX BOX CHAIN
        ' MTIPCA CABLE CHAIN
        'select * from MRP..y51VALUEMASTERPARENTCHILD where f03cGroupField_v50 ='BRJISLAND'
        '***************************************************************

        Dim permKonversiKadar As Boolean = False

        Dim pdtRow As DataRow()

        pdtRow = prop_Master51ParentChild.Select("f03cGroupField_v50 = 'CONVERTKADAR' and k01cKodeFieldParent_v50 = '" & prmKodeItem & "' and  k02cKodeFieldChild_v50 ='" & prmKodekadar & "'")

        If pdtRow.Count > 0 Then
            permKonversiKadar = True
        Else
            permKonversiKadar = False
        End If

        Return permKonversiKadar
    End Function

    Public Function GetKadarBRJ_Uji(
    prmTarget As Integer,
    prmKodeMasterKadar As String,
    prmKodeItem As String,
    prop_Master51ParentChild As DataTable,
    prmKadar_EditValue As String,
    prmKadar_Text As String
) As String

        Dim result As String = ""
        Dim prmKadarBarcode As String = ""

        Dim pdtKadarBRJ = prop_Master51ParentChild.Select("k01cKodeFieldParent_v50 = '" & prmKodeMasterKadar & "' and f03cGroupField_v50 ='KADARBRJ'")

        If pdtKadarBRJ.Count > 0 Then
            For Each itm As DataRow In pdtKadarBRJ
                If prmTarget = 1 Then
                    result = CStr(itm("k02cKodeFieldChild_v50"))
                Else
                    result = CStr(itm("f02cDescFieldChild_v50"))
                    prmKadarBarcode = result
                End If
            Next

            ' cek kadar 75.10 dan hanya chain , jika tidak kembalikan seusai akdar SPK
            If Not cm19CekKonversiKadarByItem(prmKodeItem, prmKodeMasterKadar, prop_Master51ParentChild) Then
                If prmTarget = 1 Then
                    result = prmKadar_EditValue
                Else
                    result = prmKadar_Text
                    prmKadarBarcode = prmKadar_Text
                End If
            End If

        Else
            If prmTarget = 1 Then
                result = prmKadar_EditValue
            Else
                result = prmKadar_Text
            End If
        End If

        Return result
    End Function


    <TestMethod>
    Public Sub Test_KadarKonversi_NonChain()

        ' Arrange
        Dim dt As New DataTable()
        dt.Columns.Add("k01cKodeFieldParent_v50")
        dt.Columns.Add("k02cKodeFieldChild_v50")
        dt.Columns.Add("f01cDescFieldParent_v50")
        dt.Columns.Add("f02cDescFieldChild_v50")
        dt.Columns.Add("f03cGroupField_v50")
        dt.Columns.Add("f04IsCategory")

        'Data master Group Konversi kadar = KADARBRJ
        dt.Rows.Add("MKADAR98", "MKADAR-149", "34.00%", "36.00%", "KADARBRJ", 0)
        dt.Rows.Add("MKADAR70", "MKADAR11", "67.10%", "68.00%", "KADARBRJ", 0)
        dt.Rows.Add("MKADAR122", "MKADAR4", "75.10%", "75.00%", "KADARBRJ", 0)

        'Data master Group Konversi kadarItem = CONVERTKADAR
        dt.Rows.Add("MTIPBX", "MKADAR122", "BOX CHAIN", "75.10%", "CONVERTKADAR", 0)
        dt.Rows.Add("MTIPCA", "MKADAR122", "CABLE CHAIN", "75.10%", "CONVERTKADAR", 0)

        Dim cekKonversi = Function(item As String) False

        ' Act
        Dim result As String = GetKadarBRJ_Uji(
            2,                        ' target = getNama
            "MKADAR122",              ' kode kadar yang akan di convert
            "MTIPBX",                ' kode item yg di cek
            dt,                       ' datatable
            "MKADAR122",                  ' EditValue kadar seusai SPK
            "75.10%"               ' Text kadar Seusia SPK
        )

        ' Assert
        Assert.AreEqual("75.00%", result)

    End Sub

End Class
