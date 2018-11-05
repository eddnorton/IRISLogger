Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Main.Label2.Text
        AxWindowsMediaPlayer1.URL = Label2.Text
    End Sub
End Class