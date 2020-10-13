Imports System.ComponentModel
Public Class DrawWithMouseForm
    Dim currentX As Integer
    Dim currentY As Integer
    Dim currentColor As Color

    'Dim formGraphics As Graphics = Me.CreateGraphics
    Dim currentBrush As New SolidBrush(currentColor)
    Dim formPen As New Pen(currentBrush)

    Private Sub DrawWithMouseForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"Button: {e.Button} X:{e.X}, Y:{e.Y}"
        Me.currentX = e.X
        Me.currentY = e.Y
        If e.Button.ToString = "Left" Then
            MouseDraw()
        End If
        'DrawVerticalCursor()
        'DrawHorizontalCursor()
        'DrawCircle()
    End Sub

    Private Sub DrawWithMouseForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Text = $"Button: {e.Button} X:{e.X}, Y:{e.Y}"

        Select Case e.Button
            Case e.Button.Left
                'MouseDraw()
            Case e.Button.Right
                ColorDialog.ShowDialog()
                currentColor = ColorDialog.Color
                currentBrush.Color = currentColor
                formPen.Brush = currentBrush
            Case e.Button.Middle

            Case Else

        End Select
    End Sub

    Sub DrawVerticalCursor()
        Dim formGraphics As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Me.BackColor)
        Static lastX As Integer
        formGraphics.DrawLine(pen, lastX, 0, lastX, Me.Height)
        pen.Color = Color.Black
        formGraphics.DrawLine(pen, Me.currentX, 0, Me.currentX, Me.Height)
        lastX = currentX
        formGraphics.Dispose()
        pen.Dispose()
    End Sub

    Sub DrawHorizontalCursor()
        Dim formGraphics As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Me.BackColor)
        Static lastY As Integer
        formGraphics.DrawLine(pen, 0, lastY, Me.Width, lastY)
        pen.Color = Color.Black
        formGraphics.DrawLine(pen, 0, Me.currentY, Me.Width, Me.currentY)
        lastY = currentY
        formGraphics.Dispose()
        pen.Dispose()
    End Sub

    Private Sub DrawWithMouseForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.currentColor = Color.Black
        Me.currentBrush.Color = currentColor
        Me.formPen.Brush = currentBrush
        DrawCircle()
    End Sub

    Sub DrawCircle() Handles Me.Click
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Green)
        g.DrawEllipse(pen, 20, 20, 100, 100)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub MouseDraw()
        Dim formGraphics As Graphics = Me.CreateGraphics
        Static lastX As Integer
        Static lastY As Integer

        If lastX = 0 And lastY = 0 Then
            lastX = Me.currentX
            lastY = Me.currentY
        End If

        formGraphics.DrawLine(formPen, lastX, lastY, Me.currentX, Me.currentY)
        lastX = Me.currentX
        lastY = Me.currentY
        formGraphics.Dispose()
    End Sub

End Class
