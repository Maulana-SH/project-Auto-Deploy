Imports DevExpress.XtraEditors
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports Markdig
Imports Mscc.GenerativeAI

Public Class frm53GEMINIAI

    Private prmAPIKEY As String = "AIzaSyB_HBtYZ_FUOmM7dOFOwWy0ZVU8YNBedf0"
    Private prmTYPEMODEL As String = "gemini-1.5-flash" ' "gemini-1.5-pro"
    Private googleAI As GoogleAI
    Private Model As New GenerativeModel()

    Private isSkipGenerate As Boolean = False

    Private pdtChat As DataTable
    Private mdlChat As cls24Chat

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtChat = New DataTable
        mdlChat = New cls24Chat With {.prop_dtChat = pdtChat}
        mdlChat.dtInitChat()
    End Sub

    Private Sub frm53GEMINIAI_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm00InitField()


    End Sub

    Private Sub cm00InitField()

        col01_K01IdUser_v50.FieldName = "K01IdUser_v50"
        col02_f01Pesan.FieldName = "f01Pesan"
        col03_f30SendDate.FieldName = "f30SendDate"

        GridControl1.DataSource = mdlChat.prop_dtChat
    End Sub

    Private Async Sub cmChatAI()
        'Dim googleAI = New GoogleAI(apiKey:=Environment.GetEnvironmentVariable("GOOGLE_API_KEY"))
        ' Dim model = googleAI.GenerativeModel(model:=prModel.Gemini15Pro)

        Dim googleAI = New GoogleAI(apiKey:=prmAPIKEY)
        Dim prmMDL = googleAI.GenerativeModel(model:=prmTYPEMODEL)

        Dim response = Await Model.GenerateContent(_01prompt.Text)

        _02Response.Text = response.Text
        'Console.WriteLine(response.Text)

    End Sub

    Private Async Sub cm021ChatAI()
        Try
            ' Inisialisasi GoogleAI dengan API Key dan Model
            Dim googleAI = New GoogleAI(apiKey:=prmAPIKEY)
            Dim prmMDL = googleAI.GenerativeModel(model:=prmTYPEMODEL)

            ' Kirim prompt ke model generatif
            Dim response = Await prmMDL.GenerateContent(_01prompt.Text)

            ' Ambil teks respons
            Dim responseText As String = response.Text

            ' Bersihkan kontrol sebelum menampilkan teks
            _02Response.Text = ""
            ' Tampilkan respons dengan efek mengetik
            For Each c As Char In responseText
                _02Response.Text &= c
                Await Task.Delay(10) ' Kecepatan mengetik dalam milidetik (50 ms)
            Next
        Catch ex As Exception
            ' Tangani error jika terjadi
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub cm03ChatAI()
        Try
            Me.Cursor = Cursors.WaitCursor
            ' Inisialisasi GoogleAI dengan API Key dan Model
            Dim googleAI = New GoogleAI(apiKey:=prmAPIKEY)
            Dim systemInstruction = New Content("berikan pernyataan dulu dari perintah yang di tanyakan, minimal 2 baris kalimat, dan jika diminta buat tabel, buatkan dalam format tabel HTML, tanpa tambahan ```HTML ```")
            Dim prmMDL = googleAI.GenerativeModel(model:=prmTYPEMODEL, systemInstruction:=systemInstruction)

            ' DIsplay IN chat

            mdlChat.dtAddNewChat("User", _01prompt.Text, Now)
            mdlChat.dtAddNewChat("AI-Answer", "Oke.. Tunggu sebentar..", Now)
            mdlChat.prop_dtChat.AcceptChanges()

            GridControl1.RefreshDataSource()
            TileView1.RefreshData()

            ' Kirim prompt ke model generatif
            Dim response = Await prmMDL.GenerateContent(_01prompt.Text)

            ' Ambil teks respons
            Dim responseText As String = response.Text
            ' Konversi Markdown ke HTML
            Dim forConvertHTMLText As String = ""

            ' Bersihkan kontrol sebelum menampilkan teks
            _02Response.Text = ""
            _03RichEdit.Text = ""
            _04RichTextbox.Text = ""

            btnSend.Text = "Generate..."

            Me.Cursor = Cursors.Default
            ' Tampilkan respons dengan efek mengetik
            For Each c As Char In responseText

                If isSkipGenerate Then

                    _02Response.Text = ""
                    _02Response.Text &= responseText

                    ' Tampilkan HTML di richEditControl
                    forConvertHTMLText &= responseText
                    LoadHtmlToRichEditControl(_03RichEdit, Markdown.ToHtml(forConvertHTMLText))


                    Exit For
                End If

                _02Response.Text &= c

                ' Tampilkan HTML di richEditControl
                forConvertHTMLText += c
                LoadHtmlToRichEditControl(_03RichEdit, Markdown.ToHtml(forConvertHTMLText))

                cm05Updatejawaban(forConvertHTMLText)

                GridControl1.RefreshDataSource()
                TileView1.RefreshData()

                Await Task.Delay(1) ' Kecepatan mengetik dalam milidetik (50 ms)
            Next

            btnSend.Text = "Send"
        Catch ex As Exception
            ' Tangani error jika terjadi
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadHtmlToRichEditControl(richEditControl As RichEditControl, htmlText As String)
        Dim bytes() As Byte = System.Text.Encoding.UTF8.GetBytes(htmlText)
        Using stream As New System.IO.MemoryStream(bytes)
            richEditControl.LoadDocument(stream, DocumentFormat.Html)
        End Using
    End Sub

    'Private Sub Iterate(ByVal visitor As IDocumentVisitor)
    '    Dim iterator As New DocumentIterator(richEditControl1.Document, True)
    '    Do While iterator.MoveNext()
    '        iterator.Current.Accept(visitor)
    '    Loop
    'End Sub

    'Private Sub cm03COnvertMD()
    '    Dim visitor As New MarkdownVisitor()
    '    Iterate(visitor)

    '    _02Response.Text = visitor.Text
    'End Sub

    Private Sub cm04AddChat()

        mdlChat.dtAddNewChat("User", "testing from User Prompt", Now)
        mdlChat.dtAddNewChat("AI", "Response AI from User Prompt", Now)

        mdlChat.prop_dtChat.AcceptChanges()

        GridControl1.RefreshDataSource()
        TileView1.RefreshData()
    End Sub

    Private Sub cm05Updatejawaban(ByVal prmPesan As String)

        For Each itm As Object In mdlChat.prop_dtChat.Rows
            If itm("K01IdUser_v50") = "AI-Answer" Then

                itm("f01Pesan") += prmPesan
            End If
        Next
        mdlChat.prop_dtChat.AcceptChanges()

        GridControl1.RefreshDataSource()
        TileView1.RefreshData()

    End Sub

    Private Sub btnSend_Click_1(sender As Object, e As EventArgs) Handles btnSend.Click
        'cm04AddChat()

        cm03ChatAI()

        ' Markdown Text
        'Dim markdownText As String = "### Langkah-langkah penting:" & vbCrLf &
        '                              "1. **Instalasi dan konfigurasi:** Pastikan ekstensi MySQLi ..." & vbCrLf &
        '                              "2. **Data koneksi:** Ganti placeholder ..." & vbCrLf &
        '                              "3. **Penanganan kesalahan:** ..." & vbCrLf &
        '                              "4. **Keamanan:** Jangan pernah menyimpan kredensial ..."


        '    Dim markdownText As String = _02Response.Text
        '    ' Konversi Markdown ke HTML
        '    Dim htmlText As String = Markdown.ToHtml(markdownText)

        '    ' Tampilkan HTML di richEditControl
        '    LoadHtmlToRichEditControl(RichEditControl1, htmlText)

        '    Console.WriteLine(" data _ " & htmlText)

    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        isSkipGenerate = True
    End Sub

End Class