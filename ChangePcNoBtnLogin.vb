Public Class ChangePcNoBtnLogin
    Dim mouse_move As System.Drawing.Point
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub
    Private Sub ChangePcNoBtn_Click(sender As Object, e As EventArgs) Handles ChangePcNoBtn.Click
        If PasswordTB.Text = My.Settings.password Then
            My.Settings.pcno = Time_Setter.PCnoTB.Text
            Time_Setter.PCnoTB.Text = ""
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