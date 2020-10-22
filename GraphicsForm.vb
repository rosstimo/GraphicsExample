
Imports System.Math 'make math functions work

Public Class GraphicsForm


    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click, DisplayPictureBox.Click
        'test()
        DrawSinWave()
        'DrawLine()
        'DrawCircle()
        'DrawRectangle()
        'DrawString()
    End Sub




    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, 0, 0, 150, 50)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawLine(x1 As Integer, x2 As Integer, y1 As Integer, y2 As Integer)
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, x1, y1, x2, y2)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Green)
        g.DrawEllipse(pen, 20, 20, 100, 100)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim aBrush As SolidBrush = New SolidBrush(Color.Blue)
        Dim pen As New Pen(Color.Red)
        g.FillRectangle(aBrush, 20, 20, 100, 100)
        g.DrawRectangle(pen, 20, 20, 100, 100)
        aBrush.Dispose()
        pen.Dispose()
        g.Dispose()
    End Sub

    Public Sub DrawString()
        Dim drawString As String = "Sample Text"
        Dim x As Single = 150.0
        Dim y As Single = 50.0

        Dim g As Graphics = Me.CreateGraphics()
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim drawFormat As New StringFormat '???

        g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat)

        drawFont.Dispose()
        drawBrush.Dispose()
        g.Dispose()
    End Sub

    Private Sub GraphicsForm_Paint(sender As Object, e As PaintEventArgs) ' Handles Me.Paint
        'DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.Clear(Me.BackColor)
        g.DrawLine(pen, 0, 0, Me.Width \ 2, Me.Height \ 2)
        pen.Dispose()
        g.Dispose()

        'e.Graphics.
    End Sub

    Sub DrawSinWave()
        'vi = vp * sin(w*t+theta)+DC
        'w = 2 * PI * f
        'w = 360 * f
        Me.Width = 1000
        DisplayPictureBox.Width = 720
        Dim theta As Integer = 90I
        Dim vi As Double
        Dim vp As Double = (DisplayPictureBox.Height / 2) * -1
        Dim oldVi As Double = DisplayPictureBox.Height / 2
        Dim oldTheta As Integer
        Dim pixelsPerDegree As Double = DisplayPictureBox.Width / 360
        'DisplayPictureBox.Image = Nothing
        Dim numberOfSteps As Double = DisplayPictureBox.Width / pixelsPerDegree

        For theta = 0 To CInt(numberOfSteps) Step CInt(pixelsPerDegree)

            vi = vp * Sin((PI / 180) * theta) + (DisplayPictureBox.Height / 2)
            'Console.WriteLine(vi)

            DrawLine(theta, oldTheta, CInt(vi), CInt(oldVi))
            oldTheta = theta
            oldVi = vi

        Next


    End Sub


    Sub test()
        Dim yMiddle As Integer = Me.Height \ 2
        Dim xOneFourth As Integer = Me.Width \ 4
        Dim xMiddle As Integer = Me.Width \ 2
        Dim xThreeFourth As Integer = xOneFourth + xMiddle

        DrawLine(0, xOneFourth, yMiddle, yMiddle)


    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayPictureBox.BackColor = Color.LightBlue
    End Sub
End Class
