Public Class SetupRelease
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
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub AgreeBtn_Click(sender As Object, e As EventArgs) Handles AgreeBtn.Click
        TabControl1.SelectedTab = CredentialTab
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If SetupUsernameTB.Text = "" And SetupPasswordTB.Text = "" Then
            SetupUsernameLbl.Enabled = True
            SetupPasswordLbl.Enabled = True
        ElseIf SetupUsernameTB.Text <> "" And SetupPasswordTB.Text = "" Then
            SetupUsernameLbl.Enabled = False
            SetupPasswordLbl.Enabled = True
        ElseIf SetupUsernameTB.Text = "" And SetupPasswordTB.Text <> "" Then
            SetupUsernameLbl.Enabled = True
            SetupPasswordLbl.Enabled = True
        Else
            If SetupPasswordTB.Text = SetupConfirmPasswordTB.Text Then
                My.Settings.username = SetupUsernameTB.Text
                My.Settings.password = SetupPasswordTB.Text
                My.Settings.pcno = SetupPCnoTB.Text

                TabControl1.SelectedTab = ThanksTab
            Else
                SetupConfirmPasswordLbl.Visible = True
                SetupPasswordLbl.Visible = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PcNo.Text = My.Settings.pcno
    End Sub

    Private Sub StartProgramBtn_Click(sender As Object, e As EventArgs) Handles StartProgramBtn.Click
        Time_Setter.Show()
        Me.Close()
    End Sub
End Class