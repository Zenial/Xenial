Public Class AddBtnLogin
    Dim AddHrsLbltime As Decimal
    Dim AddMinsLbltime As Decimal
    Dim AddSecLbltime As Decimal

    Dim AddHrsTBtime As Decimal
    Dim AddMinsTBtime As Decimal
    Dim AddSecTBtime As Decimal
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
        Time_Setter.Enabled = True
        Me.Close()
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If PasswordTB.Text = My.Settings.password Then
            If Time_Setter.HrsTB.Text = "" Then
                Time_Setter.HrsTB.Text = "0"
            End If
            If Time_Setter.MinsTB.Text = "" Then
                Time_Setter.MinsTB.Text = "0"
            End If
            If Time_Setter.SecTB.Text = "" Then
                Time_Setter.SecTB.Text = "0"
            End If
            AddHrsLbltime = Time_Setter.HrsLbl.Text
            AddMinsLbltime = Time_Setter.MinsLbl.Text
            AddSecLbltime = Time_Setter.SecLbl.Text

            AddHrsTBtime = Time_Setter.HrsTB.Text
            AddMinsTBtime = Time_Setter.MinsTB.Text
            AddSecTBtime = Time_Setter.SecTB.Text

            AddHrsLbltime = AddHrsLbltime + AddHrsTBtime
            AddMinsLbltime = AddMinsLbltime + AddMinsTBtime
            AddSecLbltime = AddSecLbltime + AddSecTBtime

            Time_Setter.HrsLbl.Text = AddHrsLbltime
            Time_Setter.MinsLbl.Text = AddMinsLbltime
            Time_Setter.SecLbl.Text = AddSecLbltime

            Time_Setter.StatusHrsLbl.Text = AddHrsLbltime
            Time_Setter.StatusMinsLbl.Text = AddMinsLbltime
            Time_Setter.StatusSecLbl.Text = AddSecLbltime

            Small.HrsHide.Text = AddHrsLbltime
            Small.MinsHide.Text = AddMinsLbltime
            Small.SecHide.Text = AddSecLbltime

            Time_Setter.HrsTB.Text = ""
            Time_Setter.MinsTB.Text = ""
            Time_Setter.SecTB.Text = ""

            Time_Setter.Enabled = True
            Me.Close()
        Else
            IncorrectLbl.Visible = True
            PasswordTB.Text = ""
        End If
    End Sub
End Class