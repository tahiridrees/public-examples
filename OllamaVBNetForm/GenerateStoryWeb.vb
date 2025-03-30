Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.Json
Public Class GenerateStoryWeb
    Private Async Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        System.Net.ServicePointManager.Expect100Continue = False
        rtResponse.Text = "Processing..."
        btnProcess.Enabled = False

        Try
            Dim prompt As String = "Tell me a short story." ' Replace with your desired prompt
            Dim url As String = "http://127.0.0.1:11434/api/generate"

            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"

            Dim postData As String = "{""model"": ""llama3.2:1b"", ""prompt"": """ & prompt & """, ""stream"": false}" 'Important: stream: false for full response
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentLength = byteArray.Length

            Using dataStream As Stream = request.GetRequestStream()
                dataStream.Write(byteArray, 0, byteArray.Length)
            End Using

            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Dim responseString As String = ""

                Using dataStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(dataStream)
                        responseString = Await reader.ReadToEndAsync()
                        'you can also handle stream here if you set it to "true" in the postData.
                    End Using
                End Using
                Dim options As New JsonSerializerOptions() With {.IncludeFields = True}
                Dim jsonObject As Dictionary(Of String, Object) = JsonSerializer.Deserialize(Of Dictionary(Of String, Object))(responseString)
                Dim ollamaResponse As String = jsonObject("response").ToString()

                rtResponse.Text = ollamaResponse

            End Using

        Catch ex As Exception
            rtResponse.Text = "Error: " & ex.Message
        Finally
            btnProcess.Enabled = True
        End Try
    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        Dim oForm As New GenerateStoryOllama
        oForm.Show()
    End Sub

End Class