Imports System.IO
Imports System.Reflection.Emit
Imports System.Text

Public Class GenerateStoryOllama
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim prompt As String = "Tell me a short story." ' Replace with your desired prompt
        lblResponse.Text = "Processing..."
        btnProcess.Enabled = False
        Task.Run(Sub()
                     ProcessOllamaAndDisplay(prompt)
                 End Sub)
    End Sub

    Private Sub ProcessOllamaAndDisplay(prompt As String)
        Try
            Dim startInfo As New ProcessStartInfo
            startInfo.FileName = "ollama" ' Assuming ollama is in your PATH, otherwise provide full path
            startInfo.Arguments = $"run llama3.2:1b ""{prompt}""" ' Replace llama2 with your model if needed
            startInfo.RedirectStandardOutput = True
            startInfo.RedirectStandardError = True
            startInfo.UseShellExecute = False
            startInfo.CreateNoWindow = True

            Using process As New Process
                process.StartInfo = startInfo
                process.Start()

                Using reader As StreamReader = process.StandardOutput
                    Dim outputBuilder As New StringBuilder()
                    Dim buffer(1024) As Char
                    Dim readCount As Integer

                    While Not reader.EndOfStream
                        readCount = reader.Read(buffer, 0, buffer.Length)
                        If readCount > 0 Then
                            outputBuilder.Append(buffer, 0, readCount)
                            Me.Invoke(Sub() rtResponse.Text = outputBuilder.ToString()) ' Update label on UI thread
                        End If

                    End While

                    process.WaitForExit()
                    lblResponse.Text = "Done."
                    If process.ExitCode <> 0 Then
                        Dim errorOutput = process.StandardError.ReadToEnd()
                        Me.Invoke(Sub() lblResponse.Text = "Error: " & errorOutput)
                    End If

                End Using

            End Using

        Catch ex As Exception
            Me.Invoke(Sub() lblResponse.Text = "Exception: " & ex.Message)
        Finally
            Me.Invoke(Sub() btnProcess.Enabled = True)
        End Try

    End Sub
End Class
