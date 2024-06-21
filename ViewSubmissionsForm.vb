Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission()
    End Sub

    Private Async Function LoadSubmission() As Task
        Using client As New HttpClient()
            Dim response = Await client.GetStringAsync($"http://localhost:3000/read?index={currentIndex}")
            Dim submission = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(response)

            txtName.ReadOnly = True
            txtName.Text = submission("name")

            txtEmail.ReadOnly = True
            txtEmail.Text = submission("email")

            txtPhone.ReadOnly = True
            txtPhone.Text = submission("phone")

            txtGitHubLink.ReadOnly = True
            txtGitHubLink.Text = submission("github_link")

            txtElapsedTime.ReadOnly = True
            txtElapsedTime.Text = submission("stopwatch_time")
        End Using
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission()
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' This is a simple check. You might want to handle the case where the index is out of bounds more gracefully
        currentIndex += 1
        Await LoadSubmission()
    End Sub
End Class
