Public Class PauseBtnLogin
    Dim mouse_move As System.Drawing.Point
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub
    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        If PasswordTB.Text = My.Settings.password Then
            Time_Setter.Timer1.Enabled = False
            Small.Timer1.Enabled = False
            Time_Setter.PauseBtn.Enabled = False
            Time_Setter.PauseBtn.Visible = False
            Time_Setter.ContinueBtn.Enabled = True
            Time_Setter.ContinueBtn.Visible = True
            Time_Setter.Enabled = True
            Me.Close()
        Else
            IncorrectLbl.Visible = True
            PasswordTB.Text = ""
        End If
    End Sub
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Time_Setter.Enabled = True
        Me.Close()
    End Sub
End Class