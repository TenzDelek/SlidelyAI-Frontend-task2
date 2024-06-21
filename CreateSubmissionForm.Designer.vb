<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        btnSubmit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnTimer = New Button()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithub = New TextBox()
        txtTimer = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(326, 391)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "&Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 25)
        Label1.TabIndex = 1
        Label1.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(224, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 25)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(224, 221)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 25)
        Label3.TabIndex = 1
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(224, 274)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 25)
        Label4.TabIndex = 1
        Label4.Text = "Github"
        ' 
        ' btnTimer
        ' 
        btnTimer.Location = New Point(224, 340)
        btnTimer.Name = "btnTimer"
        btnTimer.Size = New Size(112, 34)
        btnTimer.TabIndex = 2
        btnTimer.Text = "&Timer"
        btnTimer.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(414, 95)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(414, 156)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 3
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(414, 215)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(150, 31)
        txtPhone.TabIndex = 3
        ' 
        ' txtGithub
        ' 
        txtGithub.Location = New Point(414, 274)
        txtGithub.Name = "txtGithub"
        txtGithub.Size = New Size(150, 31)
        txtGithub.TabIndex = 3
        ' 
        ' txtTimer
        ' 
        txtTimer.Location = New Point(414, 343)
        txtTimer.Name = "txtTimer"
        txtTimer.Size = New Size(150, 31)
        txtTimer.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(224, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(394, 25)
        Label5.TabIndex = 4
        Label5.Text = "Tenzin Delek SlidelyAI Task2 - Create Submission"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(txtTimer)
        Controls.Add(txtGithub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(btnTimer)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnTimer As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents Label5 As Label
End Class
