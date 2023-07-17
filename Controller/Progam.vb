Module Progam
    Sub Main()
        Dim loginForm As New Login()
        If loginForm.ShowDialog() = DialogResult.OK Then
            Application.Run(New Home())
        End If
    End Sub
End Module
