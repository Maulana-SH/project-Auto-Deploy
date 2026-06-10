Imports System.Net
Imports System.Text
Imports Newtonsoft.Json


Public Class clsMdlPostAPI

    '   Private urlToPost As String = "http://backoffice.sandradewigold.com/api-productcode/product-code/addproductcode"
    Private urlToPost As String = "http://jims.sentralkreasikencana.com/api-staging/product-code/addproductcode"

    Private URL_Add As String = "http://backoffice.sandradewigold.com/api-productcode/product-code/addproductcode"
    Private URL_GetByID As String = "http://backoffice.sandradewigold.com/api-productcode/product-code/getbyproductcode?productCode="
    Private URL_All As String = "http://backoffice.sandradewigold.com/api-productcode/product-code/getall"

    Private prm01_UserName As String = "citrix"
    Private prm02_password As String = "citrixpassword"

    Private EndPoint_Add As String = "addproductcode"

    Public Sub New(ByVal urlToPost As String)
        Me.urlToPost = urlToPost
    End Sub

    ' Public Function postData(ByVal dictData As Dictionary(Of String, Object)) As Boolean
    Public Function postData(ByVal dictData As Object) As Boolean
        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte

        Try
            Dim authInfo As String = prm01_UserName + ":" + prm02_password
            authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
            'webClient.Headers("content-type") = "application/json"
            webClient.Headers("Authorization") = "Basic " & authInfo
            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))
            resByte = webClient.UploadData(Me.urlToPost, "POST", reqString)
            resString = Encoding.Default.GetString(resByte)
            Console.WriteLine(resString)
            MsgBox("response = " & resString)
            webClient.Dispose()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return False
    End Function

End Class
