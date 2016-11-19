Public Class Run
    Dim time As Decimal = 21
    Dim distance As Decimal = 0
    Dim ticks As Decimal = 0
    Private Sub Atletismo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AcceptButton = Button1
        PictureBox2.Image = My.Resources.correrP
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        distance = distance + 1
        Label3.Text = distance & " meters"
        Button1.Text = "Run"
        Timer3.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        distance = 0
        Button2.Visible = False
        Button3.Visible = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        time = time - 1
        Label1.Text = "Time: " & time & "s"
        If time = 20 Then
            Button1.Text = "Get ready!"
        ElseIf time = 19 Then
            Button1.Text = "Ready?"
        ElseIf time = 18 Then
            Button1.Text = "In 3"
        ElseIf time = 17 Then
            Button1.Text = "2"
            Label1.Visible = True
            Label3.Visible = True
        ElseIf time = 16 Then
            Button1.Text = "1"
        ElseIf time >= 15 Then
            Button1.Text = "Start!"
            Button1.Enabled = True
        End If
        If time <= 0 Then
            Button1.Enabled = False
            Label1.Visible = False
            Timer2.Stop()
            Timer3.Stop()
            Timer1.Stop()
            time = 21
            Button2.Visible = True
            Button3.Visible = True
            PictureBox2.Image = My.Resources.correrP
            MsgBox("You ran " & distance & " meters in 15 seconds!", MsgBoxStyle.Information, "Good job!")
            Label3.Visible = False
            Label3.Text = "0 meters"
            distance = 0
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox2.Image = My.Resources.correrP
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ticks = ticks + 1
        PictureBox2.Image = My.Resources.correr
        If ticks > 3 Then
            Timer3.Stop()
        End If
    End Sub
End Class
