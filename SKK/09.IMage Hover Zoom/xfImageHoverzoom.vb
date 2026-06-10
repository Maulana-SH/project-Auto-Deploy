Public Class xfImageHoverzoom

    ' Save the original image.
    Private OriginalImage, ShadedImage As Bitmap
    Private SmallWidth, SmallHeight As Integer
    Private ScaleX, ScaleY As Single

    ' Display a closeup of this area.
    Private ViewingRectangle As Rectangle

    Private Sub xfImageHoverzoom_Load(sender As Object, e As EventArgs) Handles Me.Load

        OriginalImage = DirectCast(picWhole.Image, Bitmap)
        picCloseup.Image = OriginalImage
        picCloseup.SizeMode = PictureBoxSizeMode.AutoSize

        ' Make a shaded version of the image.
        ShadedImage = New Bitmap(OriginalImage)
        Using gr As Graphics = Graphics.FromImage(ShadedImage)
            Using br As New SolidBrush(Color.FromArgb(128, 255, 255, 255))
                Dim rect As New Rectangle(0, 0, ShadedImage.Width, ShadedImage.Height)
                gr.FillRectangle(br, rect)
            End Using
        End Using

        ' Get scale factors to map from big scale to small scale.
        ScaleX = CSng(panCloseup.ClientSize.Width) / OriginalImage.Width
        ScaleY = CSng(panCloseup.ClientSize.Height) / OriginalImage.Height

        ' See how big the closeup is on the small scale.
        SmallWidth = CInt(ScaleX * picWhole.ClientSize.Width)
        SmallHeight = CInt(ScaleY * picWhole.ClientSize.Height)
    End Sub

    Private Sub picWhole_MouseMove(sender As Object, e As MouseEventArgs) Handles picWhole.MouseMove
        ' Position picCloseup inside its parent Panel.
        Dim x As Single = CSng(e.X) / picWhole.ClientSize.Width * OriginalImage.Width - CSng(panCloseup.ClientSize.Width) / 2
        Dim y As Single = CSng(e.Y) / picWhole.ClientSize.Height * OriginalImage.Height - CSng(panCloseup.ClientSize.Height) / 2
        If (x < 0) Then x = 0
        If (y < 0) Then y = 0
        If (x > OriginalImage.Width - panCloseup.ClientSize.Width) Then
            x = OriginalImage.Width - panCloseup.ClientSize.Width
        End If
        If (y > OriginalImage.Height - panCloseup.ClientSize.Height) Then
            y = OriginalImage.Height - panCloseup.ClientSize.Height
        End If

        picCloseup.Location = New Point(-CInt(x), -CInt(y))

        ' Record the position we are viewing.
        ' ViewingRectangle = New Rectangle(CInt(x), CInt(y), panCloseup.ClientSize.Width, panCloseup.ClientSize.Height)
        ' ViewingRectangle = New Rectangle(CInt(x), CInt(y), 100, 100)

        ' Draw the closeup area.
        picWhole.Invalidate()
    End Sub

    Private Sub picWhole_Paint(sender As Object, e As PaintEventArgs) Handles picWhole.Paint
        ' Scale so we can draw in the full scale coordinates.
        e.Graphics.ScaleTransform(ScaleX, ScaleY)

        ' Draw the viewing area using the original image.
        e.Graphics.DrawImage(OriginalImage, ViewingRectangle,
            ViewingRectangle, GraphicsUnit.Pixel)
        'e.Graphics.DrawRectangle(Pens.Red, ViewingRectangle)
    End Sub

    Private Sub picWhole_MouseEnter(sender As Object, e As EventArgs) Handles picWhole.MouseEnter
        Cursor = Cursors.Cross
        picWhole.Image = ShadedImage
        panCloseup.Visible = True
    End Sub

    Private Sub picWhole_MouseLeave(sender As Object, e As EventArgs) Handles picWhole.MouseLeave
        Cursor = Cursors.Default
        picWhole.Image = OriginalImage
        panCloseup.Visible = False
    End Sub
End Class



