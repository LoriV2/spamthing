Imports System.IO
Public Class Form1
    'integer which stores number from text box
    Dim n As Integer
    'path to spam folder 
    Dim path As String
    'its increment for the future files 
    Dim path2 As String = ".txt"
    's will be the name of the file
    Dim s As String
    'this is the path for the future files
    Dim path_dynamic As String
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        path = path_txt_box.Text
        path += "\"
        n = n_number.Text
        While n > 0
            s = n.ToString + path2
            path_dynamic = path + s
            File.WriteAllText(path_dynamic, Spam_content.Text)
            n -= 1
        End While
    End Sub
End Class
