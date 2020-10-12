Public Class DrawWithMouseForm
    Private Sub DrawWithMouseForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"Button: {e.Button} X:{e.X}, Y:{e.Y}"
    End Sub

    Private Sub DrawWithMouseForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Text = $"Button: {e.Button} X:{e.X}, Y:{e.Y}"
        Select Case e.Button
            Case e.Button.Left

            Case e.Button.Right

            Case e.Button.Middle

            Case Else

        End Select

    End Sub
End Class
