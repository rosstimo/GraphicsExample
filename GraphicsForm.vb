
Imports System.Math 'make math functions work

Public Class GraphicsForm


    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawSinWave()
        DrawLine()
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
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, x1, y1, x1, y1)
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

    Private Sub GraphicsForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
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
        Dim theta As Integer = 90I
        Dim vi As Double
        Dim vp As Integer = CInt(Me.Height / 2)
        Dim oldVi As Double = Me.Height / 2
        Dim oldTheta As Integer

        For theta = 0 To 360 Step 1

            vi = vp * Sin((PI / 180) * theta)
            'Console.WriteLine(vi)

            DrawLine(theta, oldTheta, CInt(vi), CInt(oldVi))
            oldTheta = theta
            oldVi = vi

        Next


    End Sub


End Class
