Imports System.Net
Imports System.Net.Http.MultipartContent
Imports System.IO
Imports System.Net.Http
Imports System.Threading.Tasks
Public Class Upload
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = My.Settings.fullLogLocation
        t0.Text = My.Settings.MixcloudTag0
        t1.Text = My.Settings.MixcloudTag1
        t2.Text = My.Settings.MixcloudTag2
        t3.Text = My.Settings.MixcloudTag3
    End Sub
    Dim charactersDisallowed As String = ",^*><#:;\/ "

    Private Sub showtag_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showtag.TextChanged
        Dim theText As String = showtag.Text
        Dim Letter As String

        For x As Integer = 0 To showtag.Text.Length - 1
            Letter = showtag.Text.Substring(x, 1)
            If charactersDisallowed.Contains(Letter) Then
                theText = theText.Replace(Letter, String.Empty)
            End If
        Next

        showtag.Text = theText
        showtag.Select(showtag.Text.Length, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If showname.Text = Nothing Then
            MsgBox("Please enter a show name.")
        ElseIf showtag.Text = Nothing Then
            MsgBox("Please enter a tag for the show (PRO TIP: If you are stuck for ideas, just enter the show name without any spaces!).")

        Else
            Dim response As Task(Of Boolean) = UploadFile(Label2.Text, showname.Text, My.Settings.MixcloudToken)
            Main.Close()
            Splash.Close()
            Form2.Close()
            Me.Close()
        End If
    End Sub

    Private Async Function UploadFile(ByVal filePath As String, ByVal showName As String, ByVal accessToken As String) As Task(Of Boolean)

        Dim fileData As Byte() = File.ReadAllBytes(filePath)
        Dim url As Uri = New Uri($"https://api.mixcloud.com/upload/?access_token={accessToken}")

        Try

            Using client As HttpClient = New HttpClient()
                Dim formData As MultipartFormDataContent = New MultipartFormDataContent()
                formData.Add(New ByteArrayContent(fileData, 0, fileData.Length), "mp3", Path.GetFileName(filePath))
                formData.Add(New StringContent(showName), "name")
                formData.Add(New StringContent(My.Settings.MixcloudTag0), "tags-0-tag")
                formData.Add(New StringContent(My.Settings.MixcloudTag1), "tags-1-tag")
                formData.Add(New StringContent(My.Settings.MixcloudTag2), "tags-2-tag")
                formData.Add(New StringContent(My.Settings.MixcloudTag3), "tags-3-tag")
                formData.Add(New StringContent(showtag.Text), "tags-4-tag")
                formData.Add(New StringContent(showdesc.Text), "description")
                Dim response As HttpResponseMessage = Await client.PostAsync(url, formData)

                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Return False
                End If
            End Using

        Catch __unusedException1__ As Exception
            Return False
        End Try
        If True Then
            MsgBox("Upload Successful!")
        Else
            MsgBox("Upload Error - Please try again. If the problem persists, contact your System Administrator.")
        End If
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub showname_TextChanged(sender As Object, e As EventArgs) Handles showname.TextChanged

    End Sub
End Class
