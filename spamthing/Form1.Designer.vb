<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.n_number = New System.Windows.Forms.TextBox()
        Me.Wrong_name = New System.Windows.Forms.Label()
        Me.path_txt_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Spam_content = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(12, 135)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.TabIndex = 0
        Me.ConfirmButton.Text = "Generate files"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'n_number
        '
        Me.n_number.Location = New System.Drawing.Point(12, 92)
        Me.n_number.Name = "n_number"
        Me.n_number.Size = New System.Drawing.Size(75, 23)
        Me.n_number.TabIndex = 1
        '
        'Wrong_name
        '
        Me.Wrong_name.AutoSize = True
        Me.Wrong_name.Location = New System.Drawing.Point(4, 54)
        Me.Wrong_name.Name = "Wrong_name"
        Me.Wrong_name.Size = New System.Drawing.Size(0, 15)
        Me.Wrong_name.TabIndex = 9
        '
        'path_txt_box
        '
        Me.path_txt_box.Location = New System.Drawing.Point(12, 46)
        Me.path_txt_box.Name = "path_txt_box"
        Me.path_txt_box.Size = New System.Drawing.Size(228, 23)
        Me.path_txt_box.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Path to spam folder"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "number of files"
        '
        'Spam_content
        '
        Me.Spam_content.Location = New System.Drawing.Point(112, 92)
        Me.Spam_content.Name = "Spam_content"
        Me.Spam_content.Size = New System.Drawing.Size(128, 23)
        Me.Spam_content.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Content of the spam files"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 170)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Spam_content)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.path_txt_box)
        Me.Controls.Add(Me.Wrong_name)
        Me.Controls.Add(Me.n_number)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Name = "Form1"
        Me.Text = "Spam Creator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConfirmButton As Button
    Friend WithEvents n_number As TextBox
    Friend WithEvents Wrong_name As Label
    Friend WithEvents path_txt_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Spam_content As TextBox
    Friend WithEvents Label3 As Label
End Class
