Imports Microsoft.Extensions.Configuration
Imports System.IO

Public Class xf56LoadAppSettings

    Implements IDisposable

#Region " form Evnt "

#End Region

#Region " Custome Methods "

    Private Sub cm01Get()
        ' Membaca konfigurasi dari appsettings.json
        Dim builder As New ConfigurationBuilder()
        builder.SetBasePath(Directory.GetCurrentDirectory()) _
               .AddJsonFile("AppSetting.json", optional:=False, reloadOnChange:=True)

        ' Mengambil konfigurasi
        Dim configuration As IConfiguration = builder.Build()

        ' Mengambil nilai dari AppSettings
        Dim connectionString As String = configuration.GetSection("AppSettings:ConnectionString").Value
        Dim apiKey As String = configuration.GetSection("AppSettings:ApiKey").Value

        ' Menampilkan nilai
        Console.WriteLine($"Connection String: {connectionString}")
        Console.WriteLine($"API Key: {apiKey}")
    End Sub

#End Region

#Region " Control Evnt "

    Private Sub btnGEt_Click(sender As Object, e As EventArgs) Handles btnGEt.Click
        cm01Get()
    End Sub

#End Region

#Region " Grid Evnt "

#End Region


End Class