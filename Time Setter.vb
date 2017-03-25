Public Class Time_Setter
    Dim mouse_move As System.Drawing.Point
    Dim AddHrsLbltime As Decimal
    Dim AddMinsLbltime As Decimal
    Dim AddSecLbltime As Decimal
    Dim AddHrsTBtime As Decimal
    Dim AddMinsTBtime As Decimal
    Dim AddSecTBtime As Decimal
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
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Timer1.Enabled = False
        AddBtn.Enabled = False
        ContinueBtn.Enabled = False
        ContinueBtn.Visible = False
        PauseBtn.Enabled = False
        PauseBtn.Visible = True
        ResetBtn.Enabled = False
        ResetBtn.Visible = False
        SetBtn.Enabled = True
        SetBtn.Visible = True
        HrsTB.Text = ""
        MinsTB.Text = ""
        SecTB.Text = ""
        HrsLbl.Text = "00"
        MinsLbl.Text = "00"
        SecLbl.Text = "00"
        StatusHrsLbl.Text = "00"
        StatusMinsLbl.Text = "00"
        StatusSecLbl.Text = "00"
    End Sub
    Private Sub SetBtn_Click(sender As Object, e As EventArgs) Handles SetBtn.Click

        Timer1.Enabled = False
        AddBtn.Enabled = False
        ContinueBtn.Enabled = False
        ContinueBtn.Visible = False
        PauseBtn.Enabled = False
        PauseBtn.Visible = True
        ResetBtn.Enabled = True
        ResetBtn.Visible = True
        SetBtn.Enabled = False
        SetBtn.Visible = False

        My.Settings.Hours = HrsTB.Text
        My.Settings.Minutes = MinsTB.Text
        My.Settings.Seconds = SecTB.Text

        HrsLbl.Text = My.Settings.Hours
        MinsLbl.Text = My.Settings.Minutes
        SecLbl.Text = My.Settings.Seconds

        StatusHrsLbl.Text = My.Settings.Hours
        StatusMinsLbl.Text = My.Settings.Minutes
        StatusSecLbl.Text = My.Settings.Seconds

        If HrsLbl.Text = "" Then
            HrsLbl.Text = "0"
        End If
        If MinsLbl.Text = "" Then
            MinsLbl.Text = "0"
        End If
        If SecLbl.Text = "" Then
            SecLbl.Text = "0"
        End If
        If HrsLbl.Text = "00" Then
            HrsLbl.Text = "0"
        End If
        If MinsLbl.Text = "00" Then
            MinsLbl.Text = "0"
        End If
        If SecLbl.Text = "00" Then
            SecLbl.Text = "0"
        End If

        If StatusHrsLbl.Text = "" Then
            StatusHrsLbl.Text = "0"
        End If
        If StatusMinsLbl.Text = "" Then
            StatusMinsLbl.Text = "0"
        End If
        If StatusSecLbl.Text = "" Then
            StatusSecLbl.Text = "0"
        End If
        If StatusHrsLbl.Text = "00" Then
            StatusHrsLbl.Text = "0"
        End If
        If StatusMinsLbl.Text = "00" Then
            StatusMinsLbl.Text = "0"
        End If
        If StatusSecLbl.Text = "00" Then
            StatusSecLbl.Text = "0"
        End If

        HrsTB.Text = ""
        MinsTB.Text = ""
        SecTB.Text = ""

        StartBtn.Enabled = True
        ClearBtn.Enabled = True

    End Sub

    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles StartBtn.Click

        Timer1.Enabled = True
        ClearBtn.Enabled = False
        AddBtn.Enabled = True
        StartBtn.Enabled = False
        PauseBtn.Enabled = True

        HrsLbl.Text = My.Settings.Hours
        MinsLbl.Text = My.Settings.Minutes
        SecLbl.Text = My.Settings.Seconds

        StatusHrsLbl.Text = My.Settings.Hours
        StatusMinsLbl.Text = My.Settings.Minutes
        StatusSecLbl.Text = My.Settings.Seconds

        HrsTB.Text = ""
        MinsTB.Text = ""
        SecTB.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If HrsLbl.Text = "" Then
            HrsLbl.Text = "0"
        End If
        If MinsLbl.Text = "" Then
            MinsLbl.Text = "0"
        End If
        If SecLbl.Text = "" Then
            SecLbl.Text = "0"
        End If
        If HrsLbl.Text = "00" Then
            HrsLbl.Text = "0"
        End If
        If MinsLbl.Text = "00" Then
            MinsLbl.Text = "0"
        End If
        If SecLbl.Text = "00" Then
            SecLbl.Text = "0"
        End If

        If SecLbl.Text > "0" Then
            SecLbl.Text = SecLbl.Text - 1
            StatusSecLbl.Text = SecLbl.Text
        End If
        If MinsLbl.Text > "0" Then
            If SecLbl.Text = "0" Then
                MinsLbl.Text = MinsLbl.Text - 1
                SecLbl.Text = "59"
                StatusSecLbl.Text = SecLbl.Text
                StatusMinsLbl.Text = MinsLbl.Text
            End If
        Else

        End If
        If HrsLbl.Text > "0" Then
            If MinsLbl.Text = "0" Then
                If SecLbl.Text = "0" Then
                    HrsLbl.Text = HrsLbl.Text - 1
                    MinsLbl.Text = "59"
                    SecLbl.Text = "59"
                    StatusSecLbl.Text = SecLbl.Text
                    StatusMinsLbl.Text = MinsLbl.Text
                    StatusHrsLbl.Text = HrsLbl.Text
                End If
            End If
        End If

        If HrsLbl.Text = "0" And MinsLbl.Text = "5" And SecLbl.Text = "1" Then
            MsgBox("Last 5 Mins")
        End If
        If HrsLbl.Text = "0" And MinsLbl.Text = "0" And SecLbl.Text = "0" Then
            Me.Close()
            Form1.Show()
        End If

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click

        HrsTB.Text = ""
        MinsTB.Text = ""
        SecTB.Text = ""
    End Sub

    Private Sub VerifyUserPassBtn_Click(sender As Object, e As EventArgs) Handles VerifyUserPassBtn.Click
        If ChangeUsername.Text = My.Settings.username And ChangePassword.Text = My.Settings.password Then

            VerifyUserPassBtn.Enabled = False
            VerifyUserPassBtn.Visible = False
            ConfirmChangeBtn.Enabled = True
            ConfirmChangeBtn.Visible = True

            ChangeUsernameLbl.Text = "New Username"
            ChangePasswordLbl.Text = "New Password"
            ChangeUsername.Text = ""
            ChangePassword.Text = ""




        ElseIf ChangeUsername.Text <> My.Settings.username And ChangePassword.Text = My.Settings.password Then
            MsgBox("Username not Matched")

            ChangeUsername.Text = ""
            ChangePassword.Text = ""

        ElseIf ChangeUsername.Text = My.Settings.username And ChangePassword.Text <> My.Settings.password Then
            MsgBox("Password not Matched")

            ChangeUsername.Text = ""
            ChangePassword.Text = ""


        ElseIf ChangeUsername.Text <> My.Settings.username And ChangePassword.Text <> My.Settings.password Then
            MsgBox("Username and Password not Matched")

            ChangeUsername.Text = ""
            ChangePassword.Text = ""

        End If
    End Sub

    Private Sub ConfirmChangeBtn_Click(sender As Object, e As EventArgs) Handles ConfirmChangeBtn.Click

        My.Settings.username = ChangeUsername.Text
        My.Settings.password = ChangePassword.Text
        MsgBox("Successfully Updated")
        ConfirmChangeBtn.Enabled = False
        ConfirmChangeBtn.Visible = False
        VerifyUserPassBtn.Visible = True
        VerifyUserPassBtn.Enabled = True
        ChangeUsername.Text = ""
        ChangePassword.Text = ""

    End Sub

    Private Sub ChangeBtn_Click(sender As Object, e As EventArgs) Handles ChangeBtn.Click
        My.Settings.pcno = PCnoTB.Text
        MsgBox("Successfully Changed")
        PCnoTB.Text = ""
    End Sub
    Private Sub SystemUpdateTimer_Tick(sender As Object, e As EventArgs) Handles SystemUpdateTimer.Tick
        PcNoTitle.Text = My.Settings.pcno

        If HrsTB.Text = "" And MinsTB.Text = "" And SecTB.Text = "" Then
            ClearBtn.Enabled = False
        End If
        If HrsTB.Text <> "" And MinsTB.Text = "" And SecTB.Text = "" Then
            ClearBtn.Enabled = True
        End If
        If HrsTB.Text = "" And MinsTB.Text <> "" And SecTB.Text = "" Then
            ClearBtn.Enabled = True
        End If
        If HrsTB.Text = "" And MinsTB.Text = "" And SecTB.Text <> "" Then
            ClearBtn.Enabled = True
        End If
        If HrsTB.Text <> "" And MinsTB.Text <> "" And SecTB.Text = "" Then
            ClearBtn.Enabled = True
        End If
        If HrsTB.Text <> "" And MinsTB.Text = "" And SecTB.Text <> "" Then
            ClearBtn.Enabled = True
        End If
        If HrsTB.Text = "" And MinsTB.Text <> "" And SecTB.Text <> "" Then
            ClearBtn.Enabled = True
        End If
        If HrsTB.Text <> "" And MinsTB.Text <> "" And SecTB.Text <> "" Then
            ClearBtn.Enabled = True
        End If
    End Sub
    Private Sub AdminSettingsBtn_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = AdminTB
    End Sub
    Private Sub SetTimeBtn_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = SetTimeTB
    End Sub

    Private Sub StatusBtn_Click(sender As Object, e As EventArgs)
        TabControl1.SelectedTab = StatusTB
    End Sub

    Private Sub HideBtn_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PauseBtn_Click(sender As Object, e As EventArgs) Handles PauseBtn.Click
        Timer1.Enabled = False
        PauseBtn.Enabled = False
        PauseBtn.Visible = False
        ContinueBtn.Enabled = True
        ContinueBtn.Visible = True
    End Sub
    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click
        Timer1.Enabled = True
        PauseBtn.Visible = True
        PauseBtn.Enabled = True
        ContinueBtn.Enabled = False
        ContinueBtn.Visible = False
    End Sub

    Private Sub ClientLogoutBtn_Click(sender As Object, e As EventArgs) Handles ClientLogoutBtn.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If HrsTB.Text = "" Then
            HrsTB.Text = "0"
        End If
        If MinsTB.Text = "" Then
            MinsTB.Text = "0"
        End If
        If SecTB.Text = "" Then
            SecTB.Text = "0"
        End If
        AddHrsLbltime = HrsLbl.Text
        AddMinsLbltime = MinsLbl.Text
        AddSecLbltime = SecLbl.Text

        AddHrsTBtime = HrsTB.Text
        AddMinsTBtime = MinsTB.Text
        AddSecTBtime = SecTB.Text

        AddHrsLbltime = AddHrsLbltime + AddHrsTBtime
        AddMinsLbltime = AddMinsLbltime + AddMinsTBtime
        AddSecLbltime = AddSecLbltime + AddSecTBtime

        HrsLbl.Text = AddHrsLbltime
        MinsLbl.Text = AddMinsLbltime
        SecLbl.Text = AddSecLbltime

        StatusHrsLbl.Text = AddHrsLbltime
        StatusMinsLbl.Text = AddMinsLbltime
        StatusSecLbl.Text = AddSecLbltime

        HrsTB.Text = ""
        MinsTB.Text = ""
        SecTB.Text = ""

    End Sub

    Private Sub AdminSettingsBtn_Click_1(sender As Object, e As EventArgs) Handles AdminSettingsBtn.Click
        TabControl1.SelectedTab = AdminTB
    End Sub

    Private Sub SetTimeBtn_Click_1(sender As Object, e As EventArgs) Handles SetTimeBtn.Click
        TabControl1.SelectedTab = SetTimeTB
    End Sub

    Private Sub StatusBtn_Click_1(sender As Object, e As EventArgs) Handles StatusBtn.Click
        TabControl1.SelectedTab = StatusTB
    End Sub

    Private Sub HideBtn_Click_1(sender As Object, e As EventArgs) Handles HideBtn.Click
        Me.Hide()
    End Sub

    Private Sub LogoutBtn_Click_1(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class