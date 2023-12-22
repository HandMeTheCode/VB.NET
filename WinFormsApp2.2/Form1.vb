Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles BtnStartGame.Click
        Dim userName As String = txtUserName.Text
        Dim userID As String = txtUserID.Text

        ' Check if the userID matches the specified format (##-###-###)
        If Regex.IsMatch(userName, "^[a-zA-Z]+$") AndAlso Regex.IsMatch(userID, "^\d{2}-\d{3}-\d{3}$") Then
            ' If the format is correct, open Form2
            Dim form2 As New Form2(userName, userID)
            Dim form3 As New Form2(userName, userID)
            form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please enter a valid user ID in the format ##-###-### and use letters only for the username.", "Invalid User ID or Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub txtUserID_MouseHover(sender As Object, e As EventArgs) Handles txtUserID.MouseHover
        ToolTip1.Show("Please enter a valid user ID in the format ##-###-###", txtUserID)
    End Sub

    Private Sub txtUserName_MouseHover(sender As Object, e As EventArgs) Handles txtUserName.MouseHover
        ToolTip1.Show("Please enter a valid user Name use letters only for the username", txtUserName)
    End Sub

    Private Sub BtnStartGame_MouseHover(sender As Object, e As EventArgs) Handles BtnStartGame.MouseHover
        ToolTip1.Show("when you ready to start the game press this button", BtnStartGame)
    End Sub

End Class
