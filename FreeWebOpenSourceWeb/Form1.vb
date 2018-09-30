Public Class Home
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate("https://www.google.com/")
    End Sub

    Private Sub go_Click(sender As Object, e As EventArgs) Handles go.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        settings.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If My.Settings.search = 1 Then
            WebBrowser1.Navigate("https://www.google.com/#sclient=psy?h1=en&site=&source=hp&q=" + TextBox1.Text)
        End If
        If My.Settings.search = 2 Then
            WebBrowser1.Navigate("https://www.youtube.com/results?search_query=" + TextBox1.Text)
        End If
        If My.Settings.search = 3 Then
            WebBrowser1.Navigate("https://www.bing.com/search?q=" + TextBox1.Text)
        End If
        If My.Settings.search = 4 Then
            WebBrowser1.Navigate("https://search.yahoo.com/search;_ylt=" + TextBox1.Text)
        End If
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.google.com/")
    End Sub
End Class
