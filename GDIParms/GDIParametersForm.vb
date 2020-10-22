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

    Sub update() Handles UpdateTabPage.Click, XOffsetTrackBar.ValueChanged, XScaleTrackBar.ValueChanged,
                        YOffsetTrackBar.ValueChanged, YScaleTrackBar.ValueChanged, RotateTrackBar.ValueChanged,
                        LocationTrackBar.ValueChanged
        Dim loc As Point
        loc.X = LocationTrackBar.Value
        loc.Y = loc.X
        Dim loc2 As Point
        loc2.X = UpdateTabPage.Width \ 2
        loc2.Y = UpdateTabPage.Height \ 2
        Dim xScale As Single = CSng(XScaleTrackBar.Value * 0.1)
        Dim yScale As Single = CSng(YScaleTrackBar.Value * 0.1)
        Dim g As Graphics = UpdateTabPage.CreateGraphics()
        Try
            g.Clear(Me.BackColor)
            g.PageUnit = GraphicsUnit.Millimeter

            g.ScaleTransform(xScale, yScale)
            g.TranslateTransform(XOffsetTrackBar.Value, YOffsetTrackBar.Value)
            g.RotateTransform(RotateTrackBar.Value)
            g.RenderingOrigin = loc2
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
            Dim infoString As String =
    $"Current Unit: {g.PageUnit}
Current Location: ({loc.X},{loc.Y})
Current Offset: ({XOffsetTrackBar.Value},{YOffsetTrackBar.Value})
Current Size: ({UpdateTabPage.Width},{UpdateTabPage.Height})
Current Page Scale: {g.PageScale}
Current X Scale: {xScale}
Current Y Scale: {yScale}
Current Rotation: {RotateTrackBar.Value}"

            DrawText(g, loc, infoString)
        Catch
        End Try
        g.Dispose()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
