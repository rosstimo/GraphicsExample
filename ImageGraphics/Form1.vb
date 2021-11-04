Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox1.Image = Me.image
        draw()
    End Sub

    Sub draw()
        Dim image As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Dim g As Graphics = Graphics.FromImage(image) 'PictureBox1.CreateGraphics.FromImage(image)
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 255))
        pen.Width() = 10
        g.DrawLine(pen, 20, 20, 150, 150)
        pen.Dispose()
        g.Dispose()
        PictureBox1.BackgroundImage = image
        PictureBox1.BackgroundImage.Save("test.png")
    End Sub



End Class
