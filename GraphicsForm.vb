
Imports System.Math 'make math functions work

Public Class GraphicsForm




    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click, DisplayPictureBox.Click
        'test()
        'DrawSinWave()
        'DrawLine()
        'DrawCircle()
        'DrawRectangle()
        DrawString()
    End Sub

    Sub DrawLine()
        'Constructor for an instance of a Graphics object called "g"
        Dim g As Graphics = DisplayPictureBox.CreateGraphics 'Me.CreateGraphics

        'Constructor for an instance of a Pen object to use with the graphics object
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 255))
        pen.Width() = 10
        'actually draw a line with the defined pen from the origin (0,0) to (150,150) in pixels
        g.DrawLine(pen, 20, 20, 150, 150)

        'clean up, release all RAM/Resources
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawLine(x1 As Integer, y1 As Integer, x2 As Integer, y2 As Integer)
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, x1, y1, x2, y2)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Green)
        g.DrawEllipse(pen, 20, 20, 100, 200)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        Dim aBrush As SolidBrush = New SolidBrush(Color.Blue)
        'Dim pen As New Pen(Color.Red)
        g.FillRectangle(aBrush, 20, 20, 100, 200)
        'g.DrawRectangle(pen, 20, 20, 100, 200)
        aBrush.Dispose()
        'pen.Dispose()
        g.Dispose()
    End Sub

    Public Sub DrawString()
        Dim drawString As String = "Sample Text"
        Dim x As Single = 150.0
        Dim y As Single = 50.0

        Dim g As Graphics = DisplayPictureBox.CreateGraphics()
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim drawFormat As New StringFormat '???

        g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat)

        drawFont.Dispose()
        drawBrush.Dispose()
        drawFormat.Dispose()
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
        Dim g As Graphics = DisplayPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Black)

        Dim xMax As Single = 360 ' 100 made up units wide
        Dim xScale As Single = DisplayPictureBox.Width / xMax
        Dim xCurrent As Double
        Dim xOld As Double

        Dim yMax As Single = 100 ' 100 made up units high 
        Dim yScale As Single = CSng(DisplayPictureBox.Height / 2) / yMax * -1
        Dim yCurrent As Double
        Dim yOld As Double

        g.Clear(Color.LightBlue)
        g.ScaleTransform(xScale, yScale)
        g.TranslateTransform(0, yMax * -1)

        For xCurrent = 0 To 360 Step 1
            yCurrent = yMax * Sin((PI / 180) * xCurrent)

            g.DrawLine(pen, CInt(xOld), CInt(yOld), CInt(xCurrent), CInt(yCurrent))

            xOld = xCurrent
            yOld = yCurrent

        Next
        pen.Dispose()
        g.Dispose()

    End Sub

    Sub test()
        Dim yMiddle As Integer = Me.Height \ 2
        Dim xOneFourth As Integer = Me.Width \ 4
        Dim xMiddle As Integer = Me.Width \ 2
        Dim xThreeFourth As Integer = xOneFourth + xMiddle

        DrawLine(0, xOneFourth, yMiddle, yMiddle)


    End Sub

    Private Sub GraphicsForm_Load(sender As Object, e As EventArgs) Handles Me.Load, Me.Resize
        DisplayPictureBox.BackColor = Color.LightBlue
        'DrawSinWave()
    End Sub

    Private Sub DisplayPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DisplayPictureBox.MouseMove
        Me.Text = $"({e.X},{e.Y}) Button:{e.Button}"
        DrawLine(0, 0, e.X, e.Y)
    End Sub
End Class
