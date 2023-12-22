<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BtnStartGame = New Button()
        txtUserID = New TextBox()
        txtUserName = New TextBox()
        ToolTip1 = New ToolTip(components)
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' BtnStartGame
        ' 
        BtnStartGame.Location = New Point(340, 278)
        BtnStartGame.Name = "BtnStartGame"
        BtnStartGame.Size = New Size(75, 23)
        BtnStartGame.TabIndex = 0
        BtnStartGame.Text = "Start Game"
        BtnStartGame.UseVisualStyleBackColor = True
        ' 
        ' txtUserID
        ' 
        txtUserID.Location = New Point(330, 230)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(100, 23)
        txtUserID.TabIndex = 1
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(330, 201)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(100, 23)
        txtUserName.TabIndex = 2
        ' 
        ' ToolTip1
        ' 
        ToolTip1.BackColor = Color.Ivory
        ToolTip1.Tag = ""
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(277, 230)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(47, 23)
        TextBox1.TabIndex = 3
        TextBox1.Text = "User ID:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(258, 201)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(66, 23)
        TextBox2.TabIndex = 4
        TextBox2.Text = "User Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(208, 9)
        Label1.Name = "Label1"
        Label1.RightToLeft = RightToLeft.No
        Label1.Size = New Size(355, 165)
        Label1.TabIndex = 5
        Label1.Text = resources.GetString("Label1.Text")
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(154, 332)
        Label2.Name = "Label2"
        Label2.Size = New Size(452, 75)
        Label2.TabIndex = 6
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(txtUserName)
        Controls.Add(txtUserID)
        Controls.Add(BtnStartGame)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnStartGame As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtUserName As TextBox
    Public WithEvents ToolTip1 As ToolTip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
