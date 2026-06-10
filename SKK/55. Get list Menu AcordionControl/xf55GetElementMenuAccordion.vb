Imports System.Runtime.ConstrainedExecution
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraTreeList.Columns
Imports NCVIEWMRPlib

Public Class xf55GetElementMenuAccordion
    Implements IDisposable

    Dim currentId As Integer = 1 ' Variabel untuk ID unik
    Private MenuMaster As New List(Of (bCheck As Boolean, Id As Integer, Name As String, ParentId As Integer, SvgImage As Image)) ' Menyimpan data menu

    Private dataTable As New DataTable()

#Region " form Evnt "

    Private Sub xf55GetElementMenuAccordion_Load(sender As Object, e As EventArgs) Handles Me.Load

        DataTable.Columns.Add("bCheck", GetType(Boolean))
        dataTable.Columns.Add("ID", GetType(Integer))
        dataTable.Columns.Add("Name", GetType(String))
        dataTable.Columns.Add("ParentID", GetType(Integer))
        dataTable.Columns.Add("SvgImage", GetType(Image))
    End Sub
#End Region

#Region " Custome Methods "

    Private Sub cm02GetListElement()
        'As List(Of AccordionControlElement)
        '/*********************************************
        'Acrodion Lits data

        'Tye Element
        '  AccordionControlElement.Style(Group, Item)

        '        Name -> AccordionControlElement.Name(acTbl01Home)
        'Text -> AccordionControlElement.Text(Home)

        'Untuk Cek Group nya
        'AccordionControlElement.HeaderVisible


        '        AccordionControlElement.ImageOptions --> (AllowGlyphSkinning = False, SvglmageSize = 15; 15)

        'AccordionControlElement.ImageUri --> (Uri = 'business%20objects/bo_product_group')
        '***************************************************/

        Dim listMenu As List(Of AccordionControlElement)

        listMenu = acMenu.GetElements

        _Result.Text = ""

        For Each dtMasterMenu As AccordionControlElement In listMenu

            '   _Result.Text &= " --> " & dtMasterMenu.Text & vbNewLine
            If dtMasterMenu.HeaderVisible = True Then

                '' Cek apakah element menu memiliki sub menu
                'If dtMasterMenu.Elements.Count > 0 Then

                '    _Result.Text &= " # " & dtMasterMenu.Text & vbNewLine
                '    'Lomping sub menu nya
                '    For Each subMenu As AccordionControlElement In dtMasterMenu.Elements
                '        If subMenu.HeaderVisible = True Then
                '            _Result.Text &= Chr(9) & " +--> " & subMenu.Text & vbNewLine
                '        End If
                '    Next

                'Else
                '    _Result.Text &= " - " & dtMasterMenu.Text & vbNewLine
                'End If

                If dtMasterMenu.Style = ElementStyle.Group Then
                    ' Group
                    _Result.Text &= " # " & dtMasterMenu.Text & vbNewLine
                    If dtMasterMenu.Elements.Count > 0 Then
                        'Lomping sub menu nya
                        For Each subMenu As AccordionControlElement In dtMasterMenu.Elements
                            If subMenu.HeaderVisible = True Then
                                _Result.Text &= Chr(9) & " +--> " & subMenu.Text & vbNewLine
                            End If
                        Next
                    Else
                        _Result.Text &= Chr(9) & " -- " & dtMasterMenu.Text & vbNewLine
                    End If
                Else
                    ' Item

                    _Result.Text &= " * " & dtMasterMenu.Text & vbNewLine
                End If

            End If



        Next


    End Sub

    Private Sub cm03GetMenuTolist(ByVal element As AccordionControlElement, ByVal parentId As Integer)
        ' Ambil properti SVG image (jika ada)
        Dim svgImage As Image = If(element.ImageOptions.GetImage IsNot Nothing, element.ImageOptions.GetImage, Nothing)

        ' Tambahkan elemen saat ini ke daftar
        MenuMaster.Add((0, currentId, element.Text, parentId, svgImage))

        ' Simpan ID elemen saat ini
        Dim thisId As Integer = currentId

        ' Increment ID untuk elemen berikutnya
        currentId += 1

        ' Proses sub-menu jika ada
        If element.Elements.Count > 0 Then
            For Each subElement As AccordionControlElement In element.Elements
                'cm03GetMenuTolist(subElement, thisId)
                Dim parentID_SUB As Integer = 0

                '*************************************
                ' karna ada sub di dalam sub yang di hide cuman untuk item agar kedalam (Tidak sejajar dengan menu induk)
                '*************************************
                If subElement.HeaderVisible = False Then
                    parentID_SUB = thisId - 1
                Else
                    parentID_SUB = thisId
                    currentId += 1
                End If

                ' hanya tambahakan menu yang di Set True saja
                If subElement.HeaderVisible = True Then
                    'cm03GetMenuTolist(subElement, parentID_SUB)

                    MenuMaster.Add((0, currentId, subElement.Text, parentID_SUB, svgImage))
                End If
            Next
        End If

    End Sub

#End Region

#Region " Control Evnt "
    Private Sub btnGEt_Click(sender As Object, e As EventArgs) Handles btnGEt.Click
        'cm02GetListElement()

        Dim listMenu As List(Of AccordionControlElement)
        listMenu = acMenu.GetElements()

        MenuMaster.Clear()

        For Each element As AccordionControlElement In listMenu
            cm03GetMenuTolist(element, 0)
            'If element.HeaderVisible = True Then
            '    ' Parent ID untuk menu utama adalah 0


            '    'SVG { element.ImageOptions.GetImage }
            '    Console.WriteLine($" name { element.Text } ")

            '    'PictureEdit1.Image = element.ImageOptions.GetImage
            'End If

        Next

        '' Menampilkan hasil
        'Console.WriteLine("| ID | Name      | Parent ID | SVG Image   |")
        'Console.WriteLine("|----|-----------|-----------|-------------|")
        'For Each prmdata In MenuMaster
        '    Console.WriteLine($"| {prmdata.Id,2} | {prmdata.Name,-9} | {prmdata.ParentId,9} | {prmdata.SvgImage,-11} |")
        'Next
        ''****************************************************************
        ' Menampilkan trelist
        '****************************************************************



        dataTable.Clear()

        For Each prmdata In MenuMaster
            '         dataTable.Rows.Add(0, prmdata.Id, prmdata.Name, prmdata.ParentId, prmdata.SvgImage)
        Next


        ' Bind TreeList ke DataTable
        TreeListMenu.DataSource = dataTable
        TreeListMenu.KeyFieldName = "ID"
        TreeListMenu.ParentFieldName = "ParentID"

        ' Menambahkan kolom ke TreeList
        TreeListMenu.Columns.AddVisible("Name")
        TreeListMenu.Columns.AddVisible("SvgImage")

    End Sub




#End Region

#Region " Grid Evnt "

#End Region


End Class