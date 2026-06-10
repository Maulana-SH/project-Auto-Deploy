
Imports System.Drawing.Printing

Public Class cls240619HelperPrinting

    Public Function cm01GenerateLabelSKK()

        Dim quantity As Integer = 0
        Dim codeZPL As String = ""

#Region " Template "


        '*****************************************************************
        ' Created : Kamis, 20 Juni 2024 (Arif)
        'SIZE label W:60mm H:20mm
        'Full Code tempaklet untuk print label nya berikut ini
        ' link Untuk Preview ZPL code = https://labelary.com/viewer.html
        ' copy paste ZPL code nya -> pilih redraws
        '*****************************************************************
        '^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD30^JUS^LRN^CI0^XZ
        '^XA
        '^MMT
        '^PW480
        '^LL0160
        '^LS0
        '^FT221,41^AAR,18,10^FB97,1,0,C^FH\^FDBRACELET^FS
        '^FT262,55^AAN,18,10^FH\^FDQTY:1 40-43sz^FS^FT262,80^AAN,18,10^FH\^FD2.35gr^FS
        '^FT262,102^AAN,18,10^FH\^FDROSE GOLD^FS
        '^FT262,125^AAN,18,10^FH\^FDBC210349-001^FS
        '^FT75,55^AAN,18,10^FH\^FDSDW 755^FS
        '^FT33,120^AAN,18,10^FH\^FDZN23245423-099^FS
        '^BY1,3,35^FT20,100^BCN,N,N,N^FDZN23245423-099^FS
        '^PQ1,0,1,Y^XZ
        '*****************************************************************

#End Region

        ' Format V1
        codeZPL = String.Concat(codeZPL, "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD30^JUS^LRN^CI0^XZ") ' --> Setting ketebalan tinta ( SD30 )
        codeZPL = String.Concat(codeZPL, "^XA") ' tag Open
        codeZPL = String.Concat(codeZPL, "^MMT")
        codeZPL = String.Concat(codeZPL, "^PW480")
        codeZPL = String.Concat(codeZPL, "^LL0160")
        codeZPL = String.Concat(codeZPL, "^LS0")
        codeZPL = String.Concat(codeZPL, "^FT221,41^AAR,18,10^FB97,1,0,C^FH\^FD", "BRACELET", "^FS") ' Setting item
        codeZPL = String.Concat(codeZPL, "^FT262,55^AAN,18,10^FH\^FD", "QTY:1 40-43sz", "^FS") ' Setting Qty, Size
        codeZPL = String.Concat(codeZPL, "^FT262,80^AAN,18,10^FH\^FD", "2.35gr", "^FS") ' Setting berat
        codeZPL = String.Concat(codeZPL, "^FT262,102^AAN,18,10^FH\^FD", "ROSE GOLD", "^FS") ' Setting Warna
        codeZPL = String.Concat(codeZPL, "^FT262,125^AAN,18,10^FH\^FD", "BC210349-001", "^FS") ' Setting Prodcut Code
        codeZPL = String.Concat(codeZPL, "^FT75,55^AAN,18,10^FH\^FD", "SDW 755", "^FS") ' Setting Brand kadar
        codeZPL = String.Concat(codeZPL, "^FT33,130^AAN,18,10^FH\^FD", "ZN23245423-099", "^FS") ' Setting SKU
        codeZPL = String.Concat(codeZPL, "^BY 1,2,70^FO25,60^BC,50,N,N,N,N^FD", "ZN23245423-099", "^FS") ' Setting BARCODE ()
        codeZPL = String.Concat(codeZPL, "^PQ1,0,1,Y^XZ") ' Tag CLose Zpl


        Dim printDialog As System.Windows.Forms.PrintDialog = New System.Windows.Forms.PrintDialog() With
            {
                .PrinterSettings = New PrinterSettings()
            }
        If (DialogResult.OK = printDialog.ShowDialog()) Then
            Dim printerName As String = printDialog.PrinterSettings.PrinterName
            'RawPrinterHelper.Se
            RawPrinterHelper.rawPrinterHelper.PrintRaw(printDialog.PrinterSettings.PrinterName, codeZPL)
        End If

        Return codeZPL
    End Function

    Public Function cm02GenerateLabelCMK()

        Dim quantity As Integer = 0
        Dim codeZPL As String = ""

#Region " Tempalte "


        '*****************************************************************
        ' Created : Kamis, 20 Juni 2024 (Arif)
        'SIZE label W:60mm H:20mm
        'Full Code tempaklet untuk print label nya berikut ini
        ' link Untuk Preview ZPL code = https://labelary.com/viewer.html
        ' copy paste ZPL code nya dibaWAH INI -> pilih redraws
        '*****************************************************************
        '^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD30^JUS^LRN^CI0^XZ
        '^XA
        '^MMT
        '^PW480
        '^LL0160
        '^LS0
        '^FT221,41^AAR,18,10^FB97,1,0,C^FH\^FDRI2345678^FS
        '^FT262,55^AAN,18,10^FH\^FDRING QTY:1^FS
        '^FT262,80^AAN,18,10^FH\^FD6.67gr 13sz^FS
        '^FT262,102^AAN,18,10^FH\^FDYELLOW^FS
        '^FT262,125^AAN,18,10^FH\^FDRp. 7.680.000^FS
        '^FT75,55^AAN,18,10^FH\^FDPGE 755^FS
        '^FT33,130^AAN,18,10^FH\^FDZN23252674-012^FS
        '^BY 1,2,70^FO15,60^BC,50,N,N,N,N^FDZN244084-012^FS
        '^PQ1,0,1,Y^XZ
        '*****************************************************************
#End Region

        ' Format V1
        codeZPL = String.Concat(codeZPL, "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD30^JUS^LRN^CI0^XZ") ' --> Setting ketebalan tinta ( SD30 )
        codeZPL = String.Concat(codeZPL, "^XA") ' tag Open
        codeZPL = String.Concat(codeZPL, "^MMT")
        codeZPL = String.Concat(codeZPL, "^PW480")
        codeZPL = String.Concat(codeZPL, "^LL0160")
        codeZPL = String.Concat(codeZPL, "^LS0")
        codeZPL = String.Concat(codeZPL, "^FT221,41^AAR,18,10^FB97,1,0,C^FH\^FD", "RI1234567", "^FS") ' Setting Master Code
        codeZPL = String.Concat(codeZPL, "^FT262,55^AAN,18,10^FH\^FD", "RING", " ", "QTY:1", "^FS") ' Setting item , Qty (sepasi baut pemisah)
        codeZPL = String.Concat(codeZPL, "^FT262,80^AAN,18,10^FH\^FD", "2.35gr", " ", "13sz", "^FS") ' Setting berat, size (sepasi baut pemisah)
        codeZPL = String.Concat(codeZPL, "^FT262,102^AAN,18,10^FH\^FD", "YELLOW", "^FS") ' Setting Warna
        codeZPL = String.Concat(codeZPL, "^FT262,125^AAN,18,10^FH\^FD", "Rp. ", "7.680.000", "^FS") ' Setting Prodcut Code
        codeZPL = String.Concat(codeZPL, "^FT75,55^AAN,18,10^FH\^FD", "PGE 755", "^FS") ' Setting Brand kadar
        codeZPL = String.Concat(codeZPL, "^FT33,130^AAN,18,10^FH\^FD", "ZN12345678-099", "^FS") ' Setting SKU
        codeZPL = String.Concat(codeZPL, "^BY 1,2,70^FO25,60^BC,50,N,N,N,N^FD", "ZN12345678-099", "^FS") ' Setting BARCODE ()
        codeZPL = String.Concat(codeZPL, "^PQ1,0,1,Y^XZ") ' Tag CLose Zpl


        Dim printDialog As System.Windows.Forms.PrintDialog = New System.Windows.Forms.PrintDialog() With
            {
                .PrinterSettings = New PrinterSettings()
            }
        If (DialogResult.OK = printDialog.ShowDialog()) Then
            Dim printerName As String = printDialog.PrinterSettings.PrinterName
            'RawPrinterHelper.Se
            RawPrinterHelper.rawPrinterHelper.PrintRaw(printDialog.PrinterSettings.PrinterName, codeZPL)
        End If

        Return codeZPL
    End Function


    Public Function cm03GenerateLabelBelalai()

        Dim quantity As Integer = 0
        Dim codeZPL As String = ""

#Region " Tempalte "


        '*****************************************************************
        ' Created : Kamis, 20 Juni 2024 (Arif)
        'SIZE label W:60mm H:20mm
        'Full Code tempaklet untuk print label nya berikut ini
        ' link Untuk Preview ZPL code = https://labelary.com/viewer.html
        ' copy paste ZPL code nya dibaWAH INI -> pilih redraws
        '*****************************************************************
        '^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD30^JUS^LRN^CI0^XZ
        '^XA
        '^MMT
        '^PW480
        '^LL0160
        '^LS0
        '^FT221,41^AAR,18,10^FB97,1,0,C^FH\^FDRI2345678^FS
        '^FT262,55^AAN,18,10^FH\^FDRING QTY:1^FS
        '^FT262,80^AAN,18,10^FH\^FD6.67gr 13sz^FS
        '^FT262,102^AAN,18,10^FH\^FDYELLOW^FS
        '^FT262,125^AAN,18,10^FH\^FDRp. 7.680.000^FS
        '^FT75,55^AAN,18,10^FH\^FDPGE 755^FS
        '^FT33,130^AAN,18,10^FH\^FDZN23252674-012^FS
        '^BY 1,2,70^FO15,60^BC,50,N,N,N,N^FDZN244084-012^FS
        '^PQ1,0,1,Y^XZ
        '*****************************************************************
#End Region

        ' Format V1
        'codeZPL = String.Concat(codeZPL, "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD30^JUS^LRN^CI0^XZ")
        'codeZPL = String.Concat(codeZPL, "^XA") ' tag Open
        ''codeZPL = String.Concat(codeZPL, "^MMT")
        ''codeZPL = String.Concat(codeZPL, "^PW480")
        ''codeZPL = String.Concat(codeZPL, "^LL0160")
        ''codeZPL = String.Concat(codeZPL, "^LS0")
        'codeZPL = String.Concat(codeZPL, "^BY1,3,85^FT17,100^BCN,,Y,N")
        'codeZPL = String.Concat(codeZPL, "^FD", ">:ZN>523123457>6-099", "^FS") '--> SKU
        'codeZPL = String.Concat(codeZPL, "^FT29,226^ADB,18,10^FH\^FD", "RI230408", "^FS") ' --> master Code
        'codeZPL = String.Concat(codeZPL, "^FT47,227^ADB,18,10^FH\^FD", "SINGLE", "sz^FS") '--> Size
        'codeZPL = String.Concat(codeZPL, "^FT52,146^ADN,18,10^FH\^FD", "ZN23123457-099", "^FS") '--> SKU
        'codeZPL = String.Concat(codeZPL, "^FT52,169^ADN,18,10^FH\^FD", String.Format("{0}gr QTY: {1}", 1.42, 1), "^FS")
        'codeZPL = String.Concat(codeZPL, "^FT52,196^ADN,18,10^FH\^FD", "ROSE GOLD", "^FS")
        'codeZPL = String.Concat(codeZPL, "^FT52,222^ADN,18,10^FH\^FD", "SDW 755", "^FS")
        'codeZPL = String.Concat(codeZPL, "^PQ1,0,1,Y^XZ") ' Tag CLose Zpl

        codeZPL = "^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD30^JUS^LRN^CI0^XZ
                    ^XA
                    ^MMT
                    ^PW623
                    ^LL0240
                    ^LS0
                    ^BY1,3,85^FT17,100^BCN,,Y,N
                    ^FD>:ZN>523123457>6-099^FS
                    ^FT29,226^ADB,18,10^FH\^FDRI230408^FS
                    ^FT47,227^ADB,18,10^FH\^FDSINGLEsz^FS
                    ^FT52,146^ADN,18,10^FH\^FDZN23123457-099^FS
                    ^FT52,169^ADN,18,10^FH\^FD1.42gr QTY: 1^FS
                    ^FT52,196^ADN,18,10^FH\^FDROSE GOLD^FS
                    ^FT52,222^ADN,18,10^FH\^FDSDW 755^FS
                    ^PQ1,0,1,Y^XZ"


        Dim printDialog As System.Windows.Forms.PrintDialog = New System.Windows.Forms.PrintDialog() With
            {
                .PrinterSettings = New PrinterSettings()
            }
        If (DialogResult.OK = printDialog.ShowDialog()) Then
            Dim printerName As String = printDialog.PrinterSettings.PrinterName
            'RawPrinterHelper.Se
            RawPrinterHelper.rawPrinterHelper.PrintRaw(printDialog.PrinterSettings.PrinterName, codeZPL)
        End If

        Return codeZPL
    End Function




    Public Function cm03PembulatanHarga(ByVal prmHarga As Decimal)
        Dim hasil As Decimal
        Dim kelipatan As Decimal = 10000

        ' price = CInt(Math.Ceiling(price / New Decimal(10000))) * 10000
        Dim numberFormatInfo As System.Globalization.NumberFormatInfo = New System.Globalization.NumberFormatInfo() With {.NumberDecimalDigits = 0, .NumberGroupSeparator = "."
                        }
        hasil = Math.Ceiling(prmHarga / kelipatan) * kelipatan

        Return hasil.ToString("N0", numberFormatInfo)
    End Function

End Class
