Imports System.IO
Imports System.Net
Imports System.Text

Module mslAPI

    Private apiURL As String = "https://ilygold.cuan.co/web/product-citrix"
    Private prm01_UserName As String = "nv0001"
    Private prm02_password As String = "qwerty"

    Sub Main()

        Dim JsonData As String = "{""type"":""Point"",""coordinates"":[-105.01628,39.57422]}"
        Dim myRequest As HttpWebRequest = PostJSON(JsonData)

        Console.WriteLine("Response of Request:{0}", GetResponse(myRequest))
        MsgBox("Response of Request:{0}", GetResponse(myRequest))

        Console.ReadKey()
    End Sub

    Private Function PostJSON(ByVal JsonData As String) As HttpWebRequest
        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create(apiURL), HttpWebRequest)
            Dim authInfo As String = prm01_UserName + ":" + prm02_password
            authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
            httpWebRequest.ContentType = "text/json"
            httpWebRequest.Method = "POST"
            httpWebRequest.Headers("Authorization") = "Basic " & authInfo


            Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())


                streamWriter.Write(JsonData)
                streamWriter.Flush()
                streamWriter.Close()
            End Using

            objhttpWebRequest = httpWebRequest

        Catch ex As Exception
            Console.WriteLine("Send Request Error[{0}]", ex.Message)

            Return Nothing
        End Try

        Return objhttpWebRequest

    End Function

    Private Function GetResponse(ByVal httpWebRequest As HttpWebRequest) As String
        Dim strResponse As String = "Bad Request:400"
        Try
            Dim httpResponse = DirectCast(httpWebRequest.GetResponse(), HttpWebResponse)
            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                Dim result = streamReader.ReadToEnd()

                strResponse = result.ToString()
            End Using
        Catch ex As Exception
            Console.WriteLine("GetResponse Error[{0}]", ex.Message)

            Return ex.Message
        End Try

        Return strResponse

    End Function
End Module
