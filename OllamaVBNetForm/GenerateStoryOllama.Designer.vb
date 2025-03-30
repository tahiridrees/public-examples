<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenerateStoryOllama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnProcess = New Button()
        lblResponse = New Label()
        rtResponse = New RichTextBox()
        SuspendLayout()
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(12, 12)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(122, 23)
        btnProcess.TabIndex = 0
        btnProcess.Text = "Generate a Story"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' lblResponse
        ' 
        lblResponse.AutoSize = True
        lblResponse.Location = New Point(12, 35)
        lblResponse.Name = "lblResponse"
        lblResponse.Size = New Size(230, 15)
        lblResponse.TabIndex = 1
        lblResponse.Text = "Please click the button to generate a story."
        ' 
        ' rtResponse
        ' 
        rtResponse.Location = New Point(12, 63)
        rtResponse.Name = "rtResponse"
        rtResponse.Size = New Size(1084, 375)
        rtResponse.TabIndex = 2
        rtResponse.Text = ""
        ' 
        ' GenerateStoryOllama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1108, 450)
        Controls.Add(rtResponse)
        Controls.Add(lblResponse)
        Controls.Add(btnProcess)
        Name = "GenerateStoryOllama"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnProcess As Button
    Friend WithEvents lblResponse As Label
    Friend WithEvents rtResponse As RichTextBox

End Class
