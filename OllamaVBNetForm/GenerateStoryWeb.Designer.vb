<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateStoryWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateStoryWeb))
        btnProcess = New Button()
        rtResponse = New RichTextBox()
        Label1 = New Label()
        btnSwitch = New Button()
        SuspendLayout()
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(16, 15)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(119, 23)
        btnProcess.TabIndex = 0
        btnProcess.Text = "Generate Story"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' rtResponse
        ' 
        rtResponse.Location = New Point(12, 79)
        rtResponse.Name = "rtResponse"
        rtResponse.Size = New Size(1102, 359)
        rtResponse.TabIndex = 1
        rtResponse.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(1101, 15)
        Label1.TabIndex = 2
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' btnSwitch
        ' 
        btnSwitch.Location = New Point(953, 12)
        btnSwitch.Name = "btnSwitch"
        btnSwitch.Size = New Size(161, 23)
        btnSwitch.TabIndex = 3
        btnSwitch.Text = "Alternate Approach"
        btnSwitch.UseVisualStyleBackColor = True
        ' 
        ' GenerateStoryWeb
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1126, 450)
        Controls.Add(btnSwitch)
        Controls.Add(Label1)
        Controls.Add(rtResponse)
        Controls.Add(btnProcess)
        Name = "GenerateStoryWeb"
        Text = "GenerateStoryWeb"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnProcess As Button
    Friend WithEvents rtResponse As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSwitch As Button
End Class
