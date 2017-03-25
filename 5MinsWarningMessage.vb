Public Class _5MinsWarningMessage
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
    Private Sub OkBtn_Click(sender As Object, e As EventArgs) Handles OkBtn.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub
    Private Sub _5MinsWarningMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.WarningAlarm, AudioPlayMode.Background)
    End Sub
End Class