Option Strict On
Option Explicit On
Public Class GraphicsExampleForm

    Sub DrawLine()
        'Constructor for an instance of graphics called "g"
        Dim g As Graphics = PictureBox.CreateGraphics

        'Constructor for an instance of a pen object to use with the graphics object
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        pen.Width() = 5

        'Draws a line with the defined pen. Starts at pixels (0,0) and ends at pixels (150,150)
        g.DrawLine(pen, 0, 0, 150, 150)

        'Closes or disposes of the pen and graphics when they are no longer being used
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = PictureBox.CreateGraphics
        Dim pen As New Pen(Color.Green)
        pen.Width() = 5
        g.DrawEllipse(pen, 125, 150, 100, 100)
        pen.Dispose()
        g.Dispose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
        DrawLine()
        DrawCircle()
    End Sub

    Private Sub GraphicsExampleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox.BackColor = Color.Orange
    End Sub
End Class
