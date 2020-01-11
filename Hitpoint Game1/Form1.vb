Public Class Form1
    Dim selectedPlayer As Integer = 1
    Dim crownsopponent = 0
    Dim crownsplayer = 0

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'Set the Form's KeyPreview property to True
        If selectedPlayer = 1 Then
            Select Case e.KeyCode
                Case Keys.Up
                    player1.Top = player1.Top - 2
                Case Keys.Left
                    player1.Left = player1.Left - 2
                Case Keys.Right
                    player1.Left = player1.Left + 2
                Case Keys.Down
                    player1.Top = player1.Top + 2
            End Select
        ElseIf selectedPlayer = 2 Then
            Select Case e.KeyCode
                Case Keys.Up
                    player2.Top = player2.Top - 2
                Case Keys.Left
                    player2.Left = player2.Left - 2
                Case Keys.Right
                    player2.Left = player2.Left + 2
                Case Keys.Down
                    player2.Top = player2.Top + 2
            End Select
        ElseIf selectedPlayer = 3 Then
            Select Case e.KeyCode
                Case Keys.Up
                    player3.Top = player3.Top - 2
                Case Keys.Left
                    player3.Left = player3.Left - 2
                Case Keys.Right
                    player3.Left = player3.Left + 2
                Case Keys.Down
                    player3.Top = player3.Top + 2
            End Select
        End If

    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Function Chase(ByRef Object1 As Object, ByRef Object2 As Object)
        If Object1.Left + Object1.Width > Object2.Left Then
            Object1.Left -= 2
        End If
        If Object1.Left + Object1.Width < Object2.Left Then
            Object1.Left += 2
        End If
        If Object1.Top + Object1.Height > Object2.Top Then
            Object1.Top -= 2
        End If
        If Object1.Top + Object1.Height < Object2.Top Then
            Object1.Top += 2
        End If
    End Function
    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And
                Object2.Top + Object2.Height >= Object1.Top And
                Object1.Left + Object1.Width >= Object2.Left And
                Object2.Left + Object2.Width >= Object1.Left Then
            Collided = True
        End If
        Return Collided
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If opponent1.Visible = True Then
            Chase(opponent1, plus1scorerace)
        End If
        If opponent2.Visible = True AndAlso opponent1.Visible = False Then
            Chase(opponent2, plus1scorerace)
        End If
        If opponent3.Visible = True And opponent2.Visible = False And opponent1.Visible = False Then
            Chase(opponent3, plus1scorerace)
        End If
        If Collision(opponent1, plus1scorerace) = True Then
            opponent1.Visible = False
            opponent1.Location = New Point(0, 0)
            crownsopponent += 1
        End If
        If Collision(opponent2, plus1scorerace) = True Then
            opponent2.Visible = False
            opponent2.Location = New Point(0, 0)
            crownsopponent += 1
        End If
        If Collision(opponent3, plus1scorerace) = True Then
            Timer1.Enabled = False
            opponent3.Visible = False
            opponent3.Location = New Point(0, 0)
            crownsopponent += 1
            MsgBox("Defeat! You Lost! Total Crowns: " & crownsplayer & "-" & crownsopponent, MsgBoxStyle.Information, "Opponent Wins!")
            Application.Restart()
        End If
        If Collision(player1, plus1scorerace) = True Then
            player1.Visible = False
            player1.Location = New Point(0, 0)
            selectedPlayer = 2
            crownsplayer += 1
        End If
        If Collision(player2, plus1scorerace) = True Then
            player2.Visible = False
            player2.Location = New Point(0, 0)
            selectedPlayer = 3
            crownsplayer += 1
        End If
        If Collision(player3, plus1scorerace) = True Then
            Timer1.Enabled = False
            player3.Visible = False
            player3.Location = New Point(0, 0)
            crownsplayer += 1
            MsgBox("Victory! You Won! Total Crowns: " & crownsplayer & "-" & crownsopponent, MsgBoxStyle.Information, "You Win!")
            Application.Restart()
        End If
        ToolStripStatusLabel2.Text = "Opponent's Crowns: " & crownsopponent
        ToolStripStatusLabel1.Text = "Player's Crowns: " & crownsplayer
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Move your first player to the green in order for you to score a crown." + Chr(13) + "If you score a crown, your player will disappear and you will move to your second player." + Chr(13) + "If you get 3 crowns, you win.", MsgBoxStyle.Information, "Game Rules")
        Timer1.Start()
    End Sub
End Class
