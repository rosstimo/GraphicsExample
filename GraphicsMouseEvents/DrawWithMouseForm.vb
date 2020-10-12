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
        DrawVerticalCursor()
        DrawHorizontalCursor()
    End Sub

    Private Sub DrawWithMouseForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        Me.Text = $"Button: {e.Button} X:{e.X}, Y:{e.Y}"
        Select Case e.Button
            Case e.Button.Left

            Case e.Button.Right
                ColorDialog.ShowDialog()
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

    End Sub


End Class
