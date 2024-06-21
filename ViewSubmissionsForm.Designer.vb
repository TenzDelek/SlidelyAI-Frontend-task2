<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtElapsedTime = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        btnNext = New Button()
        btnPrevious = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(222, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(225, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 25)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(205, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 2
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(168, 265)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 25)
        Label4.TabIndex = 3
        Label4.Text = "Github Link for task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(180, 331)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 25)
        Label5.TabIndex = 4
        Label5.Text = "Stop watch time"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.InactiveCaption
        txtName.Location = New Point(383, 86)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.InactiveCaption
        txtEmail.Location = New Point(383, 143)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 5
        ' 
        ' txtElapsedTime
        ' 
        txtElapsedTime.BackColor = SystemColors.InactiveCaption
        txtElapsedTime.Location = New Point(383, 325)
        txtElapsedTime.Name = "txtElapsedTime"
        txtElapsedTime.Size = New Size(150, 31)
        txtElapsedTime.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.InactiveCaption
        txtPhone.Location = New Point(383, 213)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 5
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.BackColor = SystemColors.InactiveCaption
        txtGitHubLink.Location = New Point(383, 262)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(150, 31)
        txtGitHubLink.TabIndex = 5
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(383, 388)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(112, 34)
        btnNext.TabIndex = 6
        btnNext.Text = "&Next"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(225, 388)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(112, 34)
        btnPrevious.TabIndex = 6
        btnPrevious.Text = "&Previous"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(205, 35)
        Label6.Name = "Label6"
        Label6.Size = New Size(381, 25)
        Label6.TabIndex = 7
        Label6.Text = "Tenzin Delek SlidelyAI Task2 - View Submission"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        Controls.Add(txtPhone)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtElapsedTime)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtElapsedTime As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label6 As Label
End Class
