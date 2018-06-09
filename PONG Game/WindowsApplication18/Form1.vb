Public Class Form1
    Dim gameball As String
    Dim vertMovement As Integer = 7
    Dim horMovement As Integer = 7
    Dim input
    Dim input1
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            PictureBox2.Top -= 10
        End If
        If e.KeyCode = Keys.Down Then
            PictureBox2.Top += 10
        End If
        If e.KeyCode = Keys.W Then
            PictureBox1.Top -= 10
        End If
        If e.KeyCode = Keys.S Then
            PictureBox1.Top += 10
        End If
        
        Call wallbound()

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox7.Location = New Point(PictureBox7.Location.X + horMovement, PictureBox7.Location.Y + vertMovement)
        Call wallbound()


    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer5.Enabled = True
        Timer6.Enabled = True
        Timer7.Enabled = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        'Windows.Forms.Cursor.Hide()
        'Timer2.Enabled = True
        Me.Show()
        MessageBox.Show("Press Enter To Start the game, W=up, S=Down, Up Arrow, Down Arrow", "PONG")
        Me.Show()
        input = InputBox("Player 1, Please Enter Your Name")
        input1 = InputBox("Player 2, Please Enter Your Name")
        'input = Label6.Text
        'input1 = Label7.Text
        Label6.Text = input
        Label7.Text = input1
        If input = "" Then
            Label6.Text = "Player 1"
        End If
        If input1 = "" Then
            Label7.Text = "Player 2"
        End If


    End Sub
    Private Sub wallbound()
        If PictureBox7.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            PictureBox7.Top = 354
            PictureBox7.Left = 217
            Label2.Text = Label2.Text + 1
            If Label2.Text = "5" Then
                Timer1.Enabled = False
                MessageBox.Show("Player 2 Has Won!", "Winner")
                Label2.Text = "0"
                PictureBox7.Top = 229
                PictureBox7.Left = 357
                PictureBox1.Height = 142
                PictureBox1.Width = 13
                PictureBox1.Top = 206
                PictureBox1.Left = 12
                PictureBox2.Height = 142
                PictureBox2.Width = 13
                PictureBox2.Top = 206
                PictureBox2.Left = 721

            End If
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            PictureBox7.Top = 354
            PictureBox7.Left = 217
            Label1.Text = Label1.Text + 1
            If Label1.Text = "5" Then
                Timer1.Enabled = False
                MessageBox.Show("Player 1 Has Won!", "Winner")
                Label1.Text = "0"
                PictureBox7.Top = 229
                PictureBox7.Left = 357
                PictureBox1.Height = 142
                PictureBox1.Width = 13
                PictureBox1.Top = 206
                PictureBox1.Left = 12
                PictureBox2.Height = 142
                PictureBox2.Width = 13
                PictureBox2.Top = 206
                PictureBox2.Left = 721
            End If
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox6.Bounds) Or PictureBox7.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            vertMovement = 0 - vertMovement
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox1.Bounds) Or PictureBox7.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            horMovement = 0 - horMovement
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            PictureBox2.Top = 86
            PictureBox2.Left = 721
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            PictureBox2.Top = 376
            PictureBox2.Left = 721
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            PictureBox1.Top = 90 '375
            PictureBox1.Left = 12
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            PictureBox1.Top = 375 '90
            PictureBox1.Left = 12
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            Timer1.Interval = 75 - 5
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            Timer1.Interval = 75 - 5
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            PictureBox1.Height = 86
            PictureBox1.Width = 13
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            PictureBox2.Height = 86
            PictureBox2.Width = 13
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            PictureBox12.Visible = True
            Timer3.Enabled = True
        End If
        If PictureBox7.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            PictureBox12.Visible = True
            Timer4.Enabled = True
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            PictureBox1.Height = 270
            PictureBox1.Width = 49
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            PictureBox2.Height = 270
            PictureBox2.Width = 49
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label5.ForeColor = Color.Cyan Then
            Label5.ForeColor = Color.Black
        End If
        If Label9.ForeColor = Color.Cyan Then
            Label9.ForeColor = Color.Black
        End If
        If Label8.ForeColor = Color.Cyan Then
            Label8.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Label5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.MouseHover
        Label5.ForeColor = Color.Cyan
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        PictureBox7.Top = 229
        PictureBox7.Left = 357
        Label1.Text = 0
        Label2.Text = 0
        PictureBox1.Height = 142
        PictureBox1.Width = 13
        PictureBox1.Top = 206
        PictureBox1.Left = 12
        PictureBox2.Height = 142
        PictureBox2.Width = 13
        PictureBox2.Top = 206
        PictureBox2.Left = 721
        PictureBox12.Visible = False
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        Me.Close()
    End Sub

    Private Sub Label9_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseHover
        Label9.ForeColor = Color.Cyan
    End Sub

    Private Sub Label8_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseHover
        Label8.ForeColor = Color.Cyan
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        PictureBox12.Left -= 5
        If PictureBox12.Left <= -Width Then
            PictureBox12.Left = Width
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        PictureBox12.Left += 5
        If PictureBox12.Left <= -Width Then
            PictureBox12.Left = Width
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Label5.ForeColor = Color.Cyan Then
            Label5.ForeColor = Color.Black
        End If
        If Label9.ForeColor = Color.Cyan Then
            Label9.ForeColor = Color.Black
        End If
        If Label8.ForeColor = Color.Cyan Then
            Label8.ForeColor = Color.Black
        End If
    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseMove
        If Label5.ForeColor = Color.Cyan Then
            Label5.ForeColor = Color.Black
        End If
        If Label9.ForeColor = Color.Cyan Then
            Label9.ForeColor = Color.Black
        End If
        If Label8.ForeColor = Color.Cyan Then
            Label8.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Label10.Top += 1
        If Label10.Top <= -Height Then
            Label10.Top = Height
        End If
        If Label10.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            Label10.Top = 3
            Label10.Left = 179
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        If Label10.ForeColor = Color.Black Then
            Label10.ForeColor = Color.Blue
        ElseIf Label10.ForeColor = Color.Blue Then
            Label10.ForeColor = Color.Red
        ElseIf Label10.ForeColor = Color.Red Then
            Label10.ForeColor = Color.Green
        ElseIf Label10.ForeColor = Color.Green Then
            Label10.ForeColor = Color.Yellow
        ElseIf Label10.ForeColor = Color.Yellow Then
            Label10.ForeColor = Color.Black
        End If
        If Label11.ForeColor = Color.Black Then
            Label11.ForeColor = Color.Blue
        ElseIf Label11.ForeColor = Color.Blue Then
            Label11.ForeColor = Color.Red
        ElseIf Label11.ForeColor = Color.Red Then
            Label11.ForeColor = Color.Green
        ElseIf Label11.ForeColor = Color.Green Then
            Label11.ForeColor = Color.Yellow
        ElseIf Label11.ForeColor = Color.Yellow Then
            Label11.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        Label11.Top += 1
        If Label11.Top <= -Height Then
            Label11.Top = Height
        End If
        If Label11.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            Label11.Top = 3
            Label11.Left = 460
        End If
    End Sub
End Class
