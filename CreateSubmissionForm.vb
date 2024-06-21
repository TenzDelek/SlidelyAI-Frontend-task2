Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub btnTimer_Click(sender As Object, e As EventArgs) Handles btnTimer.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnTimer.Text = "Resume"

        Else
            stopwatch.Start()
            btnTimer.Text = "Pause"

        End If
        UpdateTimerDisplay()
    End Sub

    Private Sub UpdateTimerDisplay()
        txtTimer.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect data
        Dim submission = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithub.Text,
            .stopwatch_time = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }

        ' Convert to JSON
        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Send to backend
        Using client As New HttpClient()
            Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Clear fields
                txtName.Clear()
                txtEmail.Clear()
                txtPhone.Clear()
                txtGithub.Clear()
                stopwatch.Reset()
                btnTimer.Text = "Start"

                UpdateTimerDisplay()
            Else
                MessageBox.Show("Submission failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub


End Class
