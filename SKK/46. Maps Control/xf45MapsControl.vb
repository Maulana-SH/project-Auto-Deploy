Imports DevExpress.Map.Native
Imports DevExpress.XtraCharts.Designer.Native
Imports DevExpress.XtraMap

Public Class xf45MapsControl
    Implements IDisposable

#Region " form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub xf45MapsControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cm01INitMaps()
        SvgContry()
    End Sub


#End Region

#Region " Custome Methods "

    Private Sub cm01INitMaps()
        ' Create a map control with initial settings and add it to the form.
        'Dim map As New MapControl() With {.Dock = DockStyle.Fill, .ZoomLevel = 4, .CenterPoint = New GeoPoint(43, 15)}
        'Me.Controls.Add(map)

        'Setting centewr point
        With MapControl1
            .ZoomLevel = 10
            .CenterPoint = New GeoPoint(43, 15)
        End With

        ' Create a layer to load image tiles from OpenStreetMap.
        Dim tileLayer As New ImageLayer()
        tileLayer.DataProvider = New OpenStreetMapDataProvider()
        MapControl1.Layers.Add(tileLayer)

        'Create a layer to display vector items.
        Dim itemsLayer As New VectorItemsLayer()
        MapControl1.Layers.Add(itemsLayer)


        ' Create a storage for map items And generate them.
        Dim storage As New MapItemStorage()
        Dim capitals() As MapItem = GetCapitals()
        storage.Items.AddRange(capitals)
        itemsLayer.Data = storage
    End Sub

    ' Create an array of callouts for 5 capital cities.
    Private Function GetCapitals() As MapItem()
        Return New MapItem() {
            New MapCallout() With {.Text = "London", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(51.507222, -0.1275)},
            New MapCallout() With {.Text = "Rome", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(41.9, 12.5)},
            New MapCallout() With {.Text = "Paris", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(48.8567, 2.3508)},
            New MapCallout() With {.Text = "Berlin", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(52.52, 13.38)},
            New MapCallout() With {.Text = "Madrid", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(40.4, -3.68)}
        }
    End Function

    Private Sub SvgContry()

        ' Create a layer to display SVG Items.
        'Dim itemsLayer As New VectorItemsLayer()
        'MapControl1.Layers.Add(itemsLayer)

        'itemsLayer.Colorizer = CreateColorizer()

        'Create a layer to display SVG items.
        'Dim baseUri As Uri = New Uri(Reflection.Assembly.GetExecutingAssembly().Location)
        'MapControl1.Layers.Add(New VectorItemsLayer With {.Data = New SvgFileDataAdapter With {.FileUri = New Uri(baseUri, "id.svg")}}) 'indonesia.svg

        Dim baseUri As Uri = New Uri(System.Reflection.Assembly.GetExecutingAssembly().Location)
        Dim adapter As SvgFileDataAdapter = New SvgFileDataAdapter()
        adapter.FileUri = New Uri(baseUri, "indonesia.svg") '..\..\Data\countries.svg

        AddHandler adapter.ItemsLoaded, AddressOf Adapter_ItemsLoaded


        MapControl1.Layers.Add(New VectorItemsLayer With {
              .Data = adapter,
              .Colorizer = CreateColorizer()
        })


        Console.WriteLine("URL = " & baseUri.ToString)
    End Sub

    Private Sub Adapter_ItemsLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs)
        For Each item As MapItem In e.Items
            item.Fill = Color.SeaGreen
        Next
    End Sub
    ' Create an array of callouts for 5 capital cities.
    Private Function INdoGetCapitals() As MapItem()
        Return New MapItem() {
            New MapCallout() With {.Text = "Jakarat", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(-6.1983207716318089, 106.83086926291733)},
            New MapCallout() With {.Text = "Palembang", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(-2.977251570020143, 104.77085545031272)},
            New MapCallout() With {.Text = "Bandung", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(-6.6015190881568957, 107.69622117855906)},
            New MapCallout() With {.Text = "Surabaya", .SvgImage = MySvgCol.Item(0), .Location = New GeoPoint(-7.1032785642978169, 112.83782275401411)}
        }
    End Function

    Private Function CreateColorizer() As MapColorizer
        ' Create a Choropleth colorizer
        Dim colorizer As New ChoroplethColorizer()

        ' Specify colors for the colorizer.
        colorizer.ColorItems.AddRange(New ColorizerColorItem() {
            New ColorizerColorItem(Color.FromArgb(&H5F, &H8B, &H95)),
            New ColorizerColorItem(Color.FromArgb(&H79, &H96, &H89)),
            New ColorizerColorItem(Color.FromArgb(&HA2, &HA8, &H75)),
            New ColorizerColorItem(Color.FromArgb(&HCE, &HBB, &H5F)),
            New ColorizerColorItem(Color.FromArgb(&HF2, &HCB, &H4E)),
            New ColorizerColorItem(Color.FromArgb(&HF1, &HC1, &H49)),
            New ColorizerColorItem(Color.FromArgb(&HE5, &HA8, &H4D)),
            New ColorizerColorItem(Color.FromArgb(&HD6, &H86, &H4E)),
            New ColorizerColorItem(Color.FromArgb(&HC5, &H64, &H50)),
            New ColorizerColorItem(Color.FromArgb(&HBA, &H4D, &H51))
        })

        ' Specify range stops for the colorizer.
        colorizer.RangeStops.AddRange(New Double() {0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000})

        ' Specify the attribute that provides data values for the colorizer.
        colorizer.ValueProvider = New ShapeAttributeValueProvider() With {.AttributeName = "GDP_MD_EST"}

        Return colorizer
    End Function

#End Region

#Region " Control Evnt "

#End Region

#Region " Grid Evnt "

#End Region

End Class