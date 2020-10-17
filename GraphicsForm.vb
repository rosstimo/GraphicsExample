Public Class GraphicsForm


    Private Sub GraphicsForm_Click(sender As Object, e As EventArgs) Handles Me.Click
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

        e.Graphics.
    End Sub
End Class
