Public Class Small
    Dim mouse_move As System.Drawing.Point
    Private Sub ShowBtn_Click(sender As Object, e As EventArgs) Handles ShowBtn.Click
        Me.Hide()
        Time_Setter.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Enabled = Time_Setter.Timer1.Enabled

        If HrsHide.Text = "" Then
            HrsHide.Text = "0"
        End If
        If MinsHide.Text = "" Then
            MinsHide.Text = "0"
        End If
        If SecHide.Text = "" Then
            SecHide.Text = "0"
        End If
        If HrsHide.Text = "00" Then
            HrsHide.Text = "0"
        End If
        If MinsHide.Text = "00" Then
            MinsHide.Text = "0"
        End If
        If SecHide.Text = "00" Then
            SecHide.Text = "0"
        End If

        If SecHide.Text > "0" Then
            SecHide.Text = SecHide.Text - 1
        End If
        If MinsHide.Text > "0" Then
            If SecHide.Text = "0" Then
                MinsHide.Text = MinsHide.Text - 1
                SecHide.Text = "59"
            End If
        Else

        End If
        If HrsHide.Text > "0" Then
            If MinsHide.Text = "0" Then
                If SecHide.Text = "0" Then
                    HrsHide.Text = HrsHide.Text - 1
                    MinsHide.Text = "59"
                    SecHide.Text = "59"
                End If
            End If
        End If

    End Sub
    Private Sub Small_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If (e.Button = MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub
    Private Sub Small_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub
End Class