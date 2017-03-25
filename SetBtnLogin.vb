Public Class SetBtnLogin
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
    Private Sub LoginSetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click
        If PasswordTB.Text = My.Settings.password Then
            Time_Setter.Timer1.Enabled = False
            Small.Timer1.Enabled = False
            Time_Setter.AddBtn.Enabled = False
            Time_Setter.ContinueBtn.Enabled = False
            Time_Setter.ContinueBtn.Visible = False
            Time_Setter.PauseBtn.Enabled = False
            Time_Setter.PauseBtn.Visible = True
            Time_Setter.ResetBtn.Enabled = True
            Time_Setter.ResetBtn.Visible = True
            Time_Setter.SetBtn.Enabled = False
            Time_Setter.SetBtn.Visible = False

            My.Settings.Hours = Time_Setter.HrsTB.Text
            My.Settings.Minutes = Time_Setter.MinsTB.Text
            My.Settings.Seconds = Time_Setter.SecTB.Text

            Time_Setter.HrsLbl.Text = My.Settings.Hours
            Time_Setter.MinsLbl.Text = My.Settings.Minutes
            Time_Setter.SecLbl.Text = My.Settings.Seconds

            Time_Setter.StatusHrsLbl.Text = My.Settings.Hours
            Time_Setter.StatusMinsLbl.Text = My.Settings.Minutes
            Time_Setter.StatusSecLbl.Text = My.Settings.Seconds

            Small.HrsHide.Text = My.Settings.Hours
            Small.MinsHide.Text = My.Settings.Minutes
            Small.SecHide.Text = My.Settings.Seconds

            If Time_Setter.HrsLbl.Text = "" Then
                Time_Setter.HrsLbl.Text = "0"
            End If
            If Time_Setter.MinsLbl.Text = "" Then
                Time_Setter.MinsLbl.Text = "0"
            End If
            If Time_Setter.SecLbl.Text = "" Then
                Time_Setter.SecLbl.Text = "0"
            End If
            If Time_Setter.HrsLbl.Text = "00" Then
                Time_Setter.HrsLbl.Text = "0"
            End If
            If Time_Setter.MinsLbl.Text = "00" Then
                Time_Setter.MinsLbl.Text = "0"
            End If
            If Time_Setter.SecLbl.Text = "00" Then
                Time_Setter.SecLbl.Text = "0"
            End If

            If Time_Setter.StatusHrsLbl.Text = "" Then
                Time_Setter.StatusHrsLbl.Text = "0"
            End If
            If Time_Setter.StatusMinsLbl.Text = "" Then
                Time_Setter.StatusMinsLbl.Text = "0"
            End If
            If Time_Setter.StatusSecLbl.Text = "" Then
                Time_Setter.StatusSecLbl.Text = "0"
            End If
            If Time_Setter.StatusHrsLbl.Text = "00" Then
                Time_Setter.StatusHrsLbl.Text = "0"
            End If
            If Time_Setter.StatusMinsLbl.Text = "00" Then
                Time_Setter.StatusMinsLbl.Text = "0"
            End If
            If Time_Setter.StatusSecLbl.Text = "00" Then
                Time_Setter.StatusSecLbl.Text = "0"
            End If

            If Small.HrsHide.Text = "" Then
                Small.HrsHide.Text = "0"
            End If
            If Small.MinsHide.Text = "" Then
                Small.MinsHide.Text = "0"
            End If
            If Small.SecHide.Text = "" Then
                Small.SecHide.Text = "0"
            End If
            If Small.HrsHide.Text = "00" Then
                Small.HrsHide.Text = "0"
            End If
            If Small.MinsHide.Text = "00" Then
                Small.MinsHide.Text = "0"
            End If
            If Small.SecHide.Text = "00" Then
                Small.SecHide.Text = "0"
            End If

            Time_Setter.HrsTB.Text = ""
            Time_Setter.MinsTB.Text = ""
            Time_Setter.SecTB.Text = ""

            Time_Setter.StartBtn.Enabled = True
            Time_Setter.ClearBtn.Enabled = True

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