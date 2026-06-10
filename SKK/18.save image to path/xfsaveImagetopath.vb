
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.XtraEditors
Imports NCCONTROLLERlib

Public Class xfsaveImagetopath
    Implements IDisposable

    Private pdtImage As New DataTable
#Region "from load"

    Private Sub xfsaveImagetopath_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm01InitField()
    End Sub
#End Region

#Region "Custome Methods"

    Private Function _cm04byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As MemoryStream = New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function

    Private Sub cm01InitField()

        col01_f01objGambar.FieldName = "f01objGambar"
        col02_f02cKodeFGorComponent_v50.FieldName = "f02cKodeFGorComponent_v50"
        col03_k01cKodeGambar_v50.FieldName = "k01cKodeGambar_v50"

        ' _02Loading.EditValue = 500

        With _02Loading
            .Properties.Step = 1
            .Properties.PercentView = True
            .Properties.Minimum = 0
        End With
    End Sub

    Private Sub cm02LoadData(ByVal prmProdcutCode As String)
        Me.Cursor = Cursors.WaitCursor
        pdtImage.Clear()

        Using objGambar As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl With {.prop_KeyInt01 = 4,
                                                                .prop_KeyString01 = prmProdcutCode,
                                                                .prop_KeyString02 = ""}
            pdtImage = objGambar.GetGambarMRP()
        End Using

        If pdtImage.Rows.Count > 0 Then
            _03labelData.Text = "Total data " & CStr(pdtImage.Rows.Count.ToString)

            '
            _02Loading.Properties.Maximum = pdtImage.Rows.Count

            gcImage.DataSource = Nothing
            gcImage.DataSource = pdtImage
            gcImage.RefreshDataSource()
        Else
            MsgBox("Maaf data Gambar tidak di temukan...")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cm03saveimage(ByVal prmName As String, ByVal prmIMG As Image)

        ' Dim dist As New Bitmap(prmIMG.Width, prmIMG.Height)
        Dim dist As Bitmap

        Const _path As String = "D:\TesGambar"

        If Not Directory.Exists(_path) Then
            Directory.CreateDirectory(_path)
        End If

        dist = prmIMG
        dist.Save(_path & "\" & prmName & ".png", System.Drawing.Imaging.ImageFormat.Jpeg)
        dist = Nothing
        MsgBox("simpan gambar berhasil")
    End Sub

    Sub examp()
        ' Compose the picture's base file name.
        Dim file_name As String = Application.ExecutablePath
        file_name = file_name.Substring(0,
            file_name.LastIndexOf("\bin")) &
            "\test."

        ' Get a Bitmap.
        '  Dim bm As Bitmap = picImage.Image

        ' Save the picture as a bitmap, JPEG, and GIF.
        ' bm.Save(file_name & "bmp",
        'System.Drawing.Imaging.ImageFormat.Bmp)
        ' bm.Save(file_name & "jpg",
        'tem.Drawing.Imaging.ImageFormat.Jpeg)
        ' bm.Save(file_name & "gif",
        ' System.Drawing.Imaging.ImageFormat.Gif)

        MsgBox("Ok")
        '===================================
        'Dim strBasePath As String
        'Dim strFilePath As String
        'Dim strFileName As String

        'strFileName = "A.jpg"
        'strBasePath = Application.StartupPath & "\Photos"
        '' >> Check if Folder Exists 
        'If Directory.Exists(strBasePath) = False Then
        '    Call Directory.CreateDirectory(strBasePath)
        'End If
        '' >> Save Picture 
        'Call PictureBox1.Image.Save(strBasePath & "\" & strFileName, System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

#End Region

#Region "Control Event"

    Private Sub btnGetdate_Click(sender As Object, e As EventArgs) Handles btnGetdate.Click
        If _01ProductCode.EditValue <> "" Then
            cm02LoadData(_01ProductCode.EditValue)
        Else
            MsgBox("Maaf silahkan isi Kode Gambar...")
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Me.Cursor = Cursors.WaitCursor


        Dim prmFileName As String = ""
        lblNama.Text = ""

        Dim pdtIMG As New DataTable
        Dim ctrlGambar As New clsController100GambarDone With {.prop_dt100GambarDone = pdtIMG}
        ctrlGambar.dtInit100GambarDone()

        For Each itm As Object In pdtImage.Rows

            prmFileName = "E:\Image-Product\" & CStr(itm("f02cKodeFGorComponent_v50")) & ".bmp"
            'prmFileName = "D:\Image-Product\" & CStr(itm("f02cKodeFGorComponent_v50")) & ".bmp"

            _CreateRawImage(_cm04byteArrayToImage(itm("f01objGambar")), prmFileName)

            ctrlGambar.prop_dt100GambarDone.Clear()
            ctrlGambar.dtAddNew100GambarDone(itm("k01cKodeGambar_v50"), itm("f02cKodeFGorComponent_v50"), "DONE")

            Using objSave As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl With {.prop_KeyDataTable01 = ctrlGambar.prop_dt100GambarDone}
                objSave.SaveGambarDONE()
            End Using

            'progress
            _02Loading.PerformStep()
            _02Loading.Update()

        Next
        MsgBox("Simpan Berhasil")

        Me.Cursor = Cursors.Default
    End Sub

    ' from tutoriL https://www.vishalon.net/blog/bitmapsave-a-generic-error-occurred-in-gdi
    Private Sub _CreateRawImage(ByRef objImage As Image, ByVal prmcPath As String)
        Dim oBitmap As Bitmap
        oBitmap = New Bitmap(objImage)
        Dim oGraphic As Graphics
        ' Here create a new bitmap object of the same height and width of the image.
        Dim bmpNew As Bitmap = New Bitmap(oBitmap.Width, oBitmap.Height)
        oGraphic = Graphics.FromImage(bmpNew)
        oGraphic.DrawImage(oBitmap, New Rectangle(0, 0,
        bmpNew.Width, bmpNew.Height), 0, 0, oBitmap.Width,
        oBitmap.Height, GraphicsUnit.Pixel)
        ' Release the lock on the image file. Of course,
        ' image from the image file is existing in Graphics object
        oBitmap.Dispose()
        oBitmap = bmpNew

        Dim oBrush As New SolidBrush(Color.Black)
        Dim ofont As New Font("Arial", 8)
        oGraphic.DrawString("Some text to write", ofont, oBrush, 10, 10)
        oGraphic.Dispose()
        ofont.Dispose()
        oBrush.Dispose()
        oBitmap.Save(prmcPath, System.Drawing.Imaging.ImageFormat.Bmp)
        oBitmap.Dispose()
    End Sub
#End Region

End Class