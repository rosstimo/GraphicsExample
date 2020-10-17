Public Class GDIParametersForm

    Private Sub PaintEventTabPage_Paint(sender As Object, e As PaintEventArgs) Handles PaintEventTabPage.Paint
        Dim loc As Point
        loc.X = 0 'PaintEventTabPage.Width \ 2
        loc.Y = 0 'PaintEventTabPage.Height \ 2
        'e.Graphics.PageUnit = GraphicsUnit.Inch

        Dim infoString As String =
            $"Current Unit: {e.Graphics.PageUnit}
Current Location: ({loc.X},{loc.Y})
Current Size: ({PaintEventTabPage.Width},{PaintEventTabPage.Height})
Current Scale: {e.Graphics.PageScale}
Current Origin: {e.Graphics.RenderingOrigin}
Current Offset: {e.Graphics.PixelOffsetMode}"

        DrawText(e.Graphics, loc, infoString)
    End Sub

    Sub DrawText(ByRef g As Graphics, ByRef loc As Point, ByRef drawString As String)
        Dim drawFont As New Font("Arial", 16)
        Dim drawBrush As New SolidBrush(Color.Black)
        Dim drawFormat As New StringFormat '???
        g.DrawString(drawString, drawFont, drawBrush, loc.X, loc.Y, drawFormat)
        drawFont.Dispose()
        drawBrush.Dispose()
    End Sub

    Sub update() Handles UpdateTabPage.Click
        Dim loc As Point
        Dim loc2 As Point
        loc2.X = UpdateTabPage.Width \ 2
        loc2.Y = UpdateTabPage.Height \ 2
        Dim g As Graphics = UpdateTabPage.CreateGraphics()
        g.PageUnit = GraphicsUnit.Millimeter
        g.ScaleTransform(2, 2)
        g.TranslateTransform(10, 10)
        g.RotateTransform(20)
        g.RenderingOrigin = loc2
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
        Dim infoString As String =
            $"Current Unit: {g.PageUnit}
Current Location: ({loc.X},{loc.Y})
Current Size: ({PaintEventTabPage.Width},{PaintEventTabPage.Height})
Current Scale: {g.PageScale}
Current Origin: {g.RenderingOrigin}
Current Offset: {g.PixelOffsetMode}"

        DrawText(g, loc, infoString)
        g.Dispose()
    End Sub

End Class
