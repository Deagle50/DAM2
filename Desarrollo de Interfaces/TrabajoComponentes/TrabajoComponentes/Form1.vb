Public Class Form1


    Dim car As Char() = {"*", "/", "+", "-"}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click
        TextBox1.Text += CType(sender, Button).Text

    End Sub


    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown

        Console.WriteLine("Has pulsado" + e.KeyCode.ToString)


    End Sub

    Private Sub TextBox5_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyUp
        Console.WriteLine("has liberado" + e.KeyCode.ToString)
    End Sub


    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress, TextBox1.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress

        If e.KeyChar < "0" Or e.KeyChar > "9" Then

            e.Handled = True
            Console.WriteLine("has pulsado el carácter " + e.KeyChar)
        End If

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Me.Text = "(" + e.X.ToString + "," + e.Y.ToString + ")"
        If e.Button = Windows.Forms.MouseButtons.Left And e.X > 500 And e.X < 943 And e.Y > 500 And e.Y < 750 Then
            Me.CreateGraphics.DrawString("=", Me.Font, Brushes.Red, e.X, e.Y)
        ElseIf e.Button = Windows.Forms.MouseButtons.Right And e.X > 500 And e.X < 943 And e.Y > 500 And e.Y < 750 Then
            Me.CreateGraphics.DrawString("=", Me.Font, Brushes.Yellow, e.X, e.Y)
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            Dim c As Integer = CInt(Asc(e.KeyChar)) Mod 4
            SendKeys.Send(car(c).ToString)
            e.Handled = True
        End If
    End Sub






    'Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
    '    Button1.Left = CInt(100 * Rnd(Now.Millisecond))
    '    Button1.Top = CInt(100 * Rnd(Now.Millisecond))
    'End Sub




End Class
