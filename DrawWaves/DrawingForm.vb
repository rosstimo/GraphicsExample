Option Strict On
Option Explicit On
Imports System.Math
Public Class DrawingForm
    Dim currentPosition As Point
    Dim currentColor As Color

    Private Sub DrawingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub

    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        currentPosition = e.Location
        LocationStatusLabel.Text = $"(X:{e.X},Y:{e.Y})"
        ColorStatusLabel.Text = $"Color: {currentColor.Name} (A:{currentColor.A},R:{currentColor.R},G:{currentColor.G},B:{currentColor.B})"
    End Sub

    Private Sub DrawingForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        currentColor = Color.Black
    End Sub

    Sub Draw()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics()
        g.Clear(Me.BackColor)
        g.PageUnit = GraphicsUnit.Pixel
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed

        g.ScaleTransform(1, 1)
        g.TranslateTransform(0, 0)
        g.RotateTransform(0)

    End Sub

    Sub DrawLine(x1 As Integer, x2 As Integer, y1 As Integer, y2 As Integer)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(currentColor)
        g.DrawLine(pen, x1, y1, x2, y2)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawLine(ByRef x1 As Integer, ByRef y1 As Integer,
                 ByRef x2 As Integer, ByRef y2 As Integer,
                 ByRef sx As Single, ByRef sy As Single,
                 ByRef dx As Single, ByRef dy As Single,
                 ByRef R As Single)

        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(currentColor)
        g.PageUnit = GraphicsUnit.Pixel
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
        g.ScaleTransform(sx, sy)
        g.TranslateTransform(dx, dy)
        g.RotateTransform(R)


        g.DrawLine(pen, x1, y1, x2, y2)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawSinWave()
        'vi = vp * sin(w*t+theta)+DC
        'w = 2 * PI * f
        'w = 360 * f

        Dim xCurrent As Double
        Dim xMax As Single = 360 'This will be the width of the scaled graphics object 
        Dim xOld As Double
        Dim xScale As Single = CSng(DrawingPictureBox.Width / xMax)
        Dim xOffset As Single

        Dim yCurrent As Double
        Dim yMax As Single = 100 'This will be the height of the scaled graphics object 
        Dim yOld As Double
        Dim yScale As Single = CSng(((DrawingPictureBox.Height) / 2) / yMax)
        Dim yOffset As Single = CSng(yMax)

        Dim numberOfPoints As Integer = 360 'This will be the resolution of the drawn shape
        Dim xPerPoints As Integer = CInt(xMax / numberOfPoints)


        For xCurrent = 0 To xMax Step xPerPoints
            'xCurrent = currentPoint '
            yCurrent = yMax * Sin((PI / 180) * xCurrent) * -1
            Try
                DrawLine(CInt(xOld), CInt(yOld), CInt(xCurrent), CInt(yCurrent), xScale, yScale, xOffset, yOffset, 0)

                xOld = xCurrent
                yOld = yCurrent
            Catch
            End Try
        Next


    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        DrawSinWave()
    End Sub
End Class
