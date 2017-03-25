Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PCNumber.Text = My.Settings.pcno
        CCTime.Text = Date.Now.ToLongTimeString
        CCDate.Text = Date.Now.ToLongDateString
    End Sub
    Private Sub ShowLoginBtn_Click(sender As Object, e As EventArgs) Handles ShowLoginBtn.Click
        ShowLoginBtn.Enabled = False
        ShowLoginBtn.Visible = False
        HideLoginBtn.Visible = True
        Label1.Visible = True
        PasswordTB.Visible = True
        WarningLoginError.Visible = False
        ExitLoginBtn.Visible = True
        LoginPasswordBtn.Visible = True
        HideLoginBtn.Enabled = True
        PasswordTB.Enabled = True
        ExitLoginBtn.Enabled = True
        LoginPasswordBtn.Enabled = True
        PasswordTB.Text = ""
    End Sub
    Private Sub HideLoginBtn_Click(sender As Object, e As EventArgs) Handles HideLoginBtn.Click
        ShowLoginBtn.Enabled = True
        ShowLoginBtn.Visible = True
        HideLoginBtn.Visible = False
        Label1.Visible = False
        PasswordTB.Visible = False
        WarningLoginError.Visible = False
        ExitLoginBtn.Visible = False
        LoginPasswordBtn.Visible = False
        HideLoginBtn.Enabled = False
        PasswordTB.Enabled = False
        ExitLoginBtn.Enabled = False
        LoginPasswordBtn.Enabled = False
        PasswordTB.Text = ""
    End Sub
    Private Sub ExitLoginBtn_Click(sender As Object, e As EventArgs) Handles ExitLoginBtn.Click
        If PasswordTB.Text = My.Settings.password Then
            Me.Close()
        Else
            WarningLoginError.Visible = True
        End If
    End Sub
    Private Sub LoginPasswordBtn_Click(sender As Object, e As EventArgs) Handles LoginPasswordBtn.Click
        If PasswordTB.Text = My.Settings.password Then
            Me.Hide()
            ShowLoginBtn.Enabled = True
            ShowLoginBtn.Visible = True
            HideLoginBtn.Visible = False
            Label1.Visible = False
            PasswordTB.Visible = False
            WarningLoginError.Visible = False
            ExitLoginBtn.Visible = False
            LoginPasswordBtn.Visible = False
            HideLoginBtn.Enabled = False
            PasswordTB.Enabled = False
            ExitLoginBtn.Enabled = False
            LoginPasswordBtn.Enabled = False
            Time_Setter.Show()
        Else
            WarningLoginError.Visible = True
        End If
    End Sub
    Private Sub PasswordTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTB.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If PasswordTB.Text = My.Settings.password Then
                Me.Hide()
                ShowLoginBtn.Enabled = True
                ShowLoginBtn.Visible = True
                HideLoginBtn.Visible = False
                Label1.Visible = False
                PasswordTB.Visible = False
                WarningLoginError.Visible = False
                ExitLoginBtn.Visible = False
                LoginPasswordBtn.Visible = False
                HideLoginBtn.Enabled = False
                PasswordTB.Enabled = False
                ExitLoginBtn.Enabled = False
                LoginPasswordBtn.Enabled = False
                Time_Setter.Show()
            Else
                WarningLoginError.Visible = True
            End If
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.username = "" And My.Settings.password = "" And My.Settings.pcno = "" Then
            SetupRelease.Show()
            Me.Hide()
        End If
    End Sub
End Class