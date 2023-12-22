Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form3
    Private userName As String
    Private userID As String
    Private YouLose As Image ' Load ship

    Public Sub New(ByVal uName As String, ByVal uID As String)
        InitializeComponent()
        userName = uName
        userID = uID

        ' Additional code
        InitializeSpaceElements() ' Additional code Call the method to initialize behavior

        ' Additional code

    End Sub
    Private Sub InitializeSpaceElements()
        YouLose = My.Resources._6591069_game_over
        Me.BackgroundImage = My.Resources.infinite_space
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Form2(userName, userID)
        form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Close()
    End Sub

End Class