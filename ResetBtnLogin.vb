Public Class ResetBtnLogin
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
    Private Sub LoginSetBtn_Click(sender As Object, e As EventArgs) Handles LoginSetBtn.Click
        If PasswordTB.Text = My.Settings.password Then
            Time_Setter.Timer1.Enabled = False
            Small.Timer1.Enabled = False
            Time_Setter.AddBtn.Enabled = False
            Time_Setter.ContinueBtn.Enabled = False
            Time_Setter.ContinueBtn.Visible = False
            Time_Setter.PauseBtn.Enabled = False
            Time_Setter.PauseBtn.Visible = True
            Time_Setter.ResetBtn.Enabled = False
            Time_Setter.ResetBtn.Visible = False
            Time_Setter.SetBtn.Enabled = True
            Time_Setter.SetBtn.Visible = True
            Time_Setter.HrsTB.Text = ""
            Time_Setter.MinsTB.Text = ""
            Time_Setter.SecTB.Text = ""
            Time_Setter.HrsLbl.Text = "00"
            Time_Setter.MinsLbl.Text = "00"
            Time_Setter.SecLbl.Text = "00"
            Time_Setter.StatusHrsLbl.Text = "00"
            Time_Setter.StatusMinsLbl.Text = "00"
            Time_Setter.StatusSecLbl.Text = "00"
            Small.HrsHide.Text = "00"
            Small.MinsHide.Text = "00"
            Small.SecHide.Text = "00"
            Me.Close()
            Time_Setter.Enabled = True
        Else
            IncorrectLbl.Visible = True
            PasswordTB.Text = ""
        End If
    End Sub
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
        Time_Setter.Enabled = True
    End Sub
End Class