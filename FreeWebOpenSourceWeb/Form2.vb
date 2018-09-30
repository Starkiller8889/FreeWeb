Public Class settings
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        My.Settings.search = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        My.Settings.search = 2
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        My.Settings.search = 3
    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.search = 1 Then
            RadioButton1.Checked = True
        End If
        If My.Settings.search = 2 Then
            RadioButton2.Checked = True
        End If
        If My.Settings.search = 3 Then
            RadioButton3.Checked = True
        End If
        If My.Settings.search = 4 Then
            RadioButton4.Checked = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        My.Settings.theme = 1
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        My.Settings.theme = 2
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Application.Exit()
    End Sub
End Class