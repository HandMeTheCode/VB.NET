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
        btnSTART = New Button()
        btnDelete = New Button()
        btnDeleteAll = New Button()
        btnNext = New Button()
        btnRN1 = New Button()
        btnRN2 = New Button()
        btnRN3 = New Button()
        btnRN4 = New Button()
        btnDIVIDE = New Button()
        btnPLUS = New Button()
        btnFOR = New Button()
        btnMINUS = New Button()
        txtbxN1 = New TextBox()
        txtbxO1 = New TextBox()
        txtbxN2 = New TextBox()
        txtbxO2 = New TextBox()
        txtbxN3 = New TextBox()
        txtbxO3 = New TextBox()
        txtbxN4 = New TextBox()
        txtbxSYSTRESULT = New TextBox()
        Label1 = New Label()
        btnSolve = New Button()
        TextBox10 = New TextBox()
        txtbxUSERRESULT = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        TextBox11 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' btnSTART
        ' 
        btnSTART.Location = New Point(960, 93)
        btnSTART.Name = "btnSTART"
        btnSTART.Size = New Size(75, 23)
        btnSTART.TabIndex = 0
        btnSTART.Tag = "btnSTART"
        btnSTART.Text = "INICIO"
        btnSTART.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(960, 171)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 1
        btnDelete.Tag = "btnDelete "
        btnDelete.Text = "BORRAR"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteAll
        ' 
        btnDeleteAll.Location = New Point(960, 200)
        btnDeleteAll.Name = "btnDeleteAll"
        btnDeleteAll.Size = New Size(75, 38)
        btnDeleteAll.TabIndex = 2
        btnDeleteAll.Tag = "btnDeleteAll"
        btnDeleteAll.Text = "BORRAR TODO"
        btnDeleteAll.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(960, 270)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 23)
        btnNext.TabIndex = 3
        btnNext.Tag = "btnNext"
        btnNext.Text = "SIGUIENTE"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnRN1
        ' 
        btnRN1.Location = New Point(447, 208)
        btnRN1.Name = "btnRN1"
        btnRN1.Size = New Size(75, 23)
        btnRN1.TabIndex = 4
        btnRN1.Tag = "btnRN1"
        btnRN1.UseVisualStyleBackColor = True
        ' 
        ' btnRN2
        ' 
        btnRN2.Location = New Point(528, 208)
        btnRN2.Name = "btnRN2"
        btnRN2.Size = New Size(75, 23)
        btnRN2.TabIndex = 5
        btnRN2.Tag = "btnRN2"
        btnRN2.UseVisualStyleBackColor = True
        ' 
        ' btnRN3
        ' 
        btnRN3.Location = New Point(609, 208)
        btnRN3.Name = "btnRN3"
        btnRN3.Size = New Size(75, 23)
        btnRN3.TabIndex = 6
        btnRN3.Tag = "btnRN3"
        btnRN3.UseVisualStyleBackColor = True
        ' 
        ' btnRN4
        ' 
        btnRN4.Location = New Point(690, 208)
        btnRN4.Name = "btnRN4"
        btnRN4.Size = New Size(75, 23)
        btnRN4.TabIndex = 7
        btnRN4.Tag = "btnRN4"
        btnRN4.UseVisualStyleBackColor = True
        ' 
        ' btnDIVIDE
        ' 
        btnDIVIDE.Location = New Point(652, 255)
        btnDIVIDE.Name = "btnDIVIDE"
        btnDIVIDE.Size = New Size(37, 23)
        btnDIVIDE.TabIndex = 8
        btnDIVIDE.Tag = "btnDIVIDE"
        btnDIVIDE.Text = "/"
        btnDIVIDE.UseVisualStyleBackColor = True
        ' 
        ' btnPLUS
        ' 
        btnPLUS.Location = New Point(523, 255)
        btnPLUS.Name = "btnPLUS"
        btnPLUS.Size = New Size(37, 23)
        btnPLUS.TabIndex = 9
        btnPLUS.Tag = "btnPLUS"
        btnPLUS.Text = "+"
        btnPLUS.UseVisualStyleBackColor = True
        ' 
        ' btnFOR
        ' 
        btnFOR.Location = New Point(609, 255)
        btnFOR.Name = "btnFOR"
        btnFOR.Size = New Size(37, 23)
        btnFOR.TabIndex = 10
        btnFOR.Tag = "btnFOR"
        btnFOR.Text = "*"
        btnFOR.UseVisualStyleBackColor = True
        ' 
        ' btnMINUS
        ' 
        btnMINUS.Location = New Point(566, 255)
        btnMINUS.Name = "btnMINUS"
        btnMINUS.Size = New Size(37, 23)
        btnMINUS.TabIndex = 11
        btnMINUS.Tag = "btnMINUS"
        btnMINUS.Text = "-"
        btnMINUS.UseVisualStyleBackColor = True
        ' 
        ' txtbxN1
        ' 
        txtbxN1.Location = New Point(428, 138)
        txtbxN1.Name = "txtbxN1"
        txtbxN1.Size = New Size(43, 23)
        txtbxN1.TabIndex = 12
        txtbxN1.Tag = "txtbxN"
        ' 
        ' txtbxO1
        ' 
        txtbxO1.Location = New Point(477, 138)
        txtbxO1.Name = "txtbxO1"
        txtbxO1.Size = New Size(43, 23)
        txtbxO1.TabIndex = 13
        txtbxO1.Tag = "txtbxO"
        ' 
        ' txtbxN2
        ' 
        txtbxN2.Location = New Point(526, 137)
        txtbxN2.Name = "txtbxN2"
        txtbxN2.Size = New Size(43, 23)
        txtbxN2.TabIndex = 14
        txtbxN2.Tag = "txtbxN"
        ' 
        ' txtbxO2
        ' 
        txtbxO2.Location = New Point(575, 137)
        txtbxO2.Name = "txtbxO2"
        txtbxO2.Size = New Size(43, 23)
        txtbxO2.TabIndex = 15
        txtbxO2.Tag = "txtbxO"
        ' 
        ' txtbxN3
        ' 
        txtbxN3.Location = New Point(624, 138)
        txtbxN3.Name = "txtbxN3"
        txtbxN3.Size = New Size(43, 23)
        txtbxN3.TabIndex = 16
        txtbxN3.Tag = "txtbxN"
        ' 
        ' txtbxO3
        ' 
        txtbxO3.Location = New Point(673, 138)
        txtbxO3.Name = "txtbxO3"
        txtbxO3.Size = New Size(43, 23)
        txtbxO3.TabIndex = 17
        txtbxO3.Tag = "txtbxO"
        ' 
        ' txtbxN4
        ' 
        txtbxN4.Location = New Point(722, 138)
        txtbxN4.Name = "txtbxN4"
        txtbxN4.Size = New Size(43, 23)
        txtbxN4.TabIndex = 18
        txtbxN4.Tag = "txtbxN"
        ' 
        ' txtbxSYSTRESULT
        ' 
        txtbxSYSTRESULT.Location = New Point(792, 94)
        txtbxSYSTRESULT.Name = "txtbxSYSTRESULT"
        txtbxSYSTRESULT.ReadOnly = True
        txtbxSYSTRESULT.Size = New Size(100, 23)
        txtbxSYSTRESULT.TabIndex = 19
        txtbxSYSTRESULT.Tag = "txtbxSYSTRESULT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(771, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(15, 15)
        Label1.TabIndex = 20
        Label1.Text = "="
        ' 
        ' btnSolve
        ' 
        btnSolve.Location = New Point(960, 132)
        btnSolve.Name = "btnSolve"
        btnSolve.Size = New Size(75, 23)
        btnSolve.TabIndex = 23
        btnSolve.Tag = "btnSolve "
        btnSolve.Text = "RESOLVER"
        btnSolve.UseVisualStyleBackColor = True
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(1062, 20)
        TextBox10.Name = "TextBox10"
        TextBox10.ReadOnly = True
        TextBox10.Size = New Size(46, 23)
        TextBox10.TabIndex = 25
        TextBox10.Tag = "TextBox10"
        ' 
        ' txtbxUSERRESULT
        ' 
        txtbxUSERRESULT.Location = New Point(792, 138)
        txtbxUSERRESULT.Name = "txtbxUSERRESULT"
        txtbxUSERRESULT.ReadOnly = True
        txtbxUSERRESULT.Size = New Size(100, 23)
        txtbxUSERRESULT.TabIndex = 27
        txtbxUSERRESULT.Tag = "txtbxUSERRESULT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(665, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 15)
        Label3.TabIndex = 28
        Label3.Text = "Resultado esperado ="
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(951, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 15)
        Label2.TabIndex = 29
        Label2.Text = "Puntaje LLevado ="
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(899, 20)
        TextBox11.Name = "TextBox11"
        TextBox11.ReadOnly = True
        TextBox11.Size = New Size(46, 23)
        TextBox11.TabIndex = 30
        TextBox11.Tag = "TextBox11"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(849, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 15)
        Label4.TabIndex = 31
        Label4.Text = "Reloj ="
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(330, 30)
        Label5.TabIndex = 32
        Label5.Text = "UNIVERSIDAD TECNOLÓGICA DE PANAMÁ" & vbCrLf & "FACULTAD DE INGENIERÍA DE SISTEMAS COMPUTACIONALES" & vbCrLf
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(2, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(355, 45)
        Label6.TabIndex = 33
        Label6.Text = "DEPARTAMENTO DE COMPUTACION Y SIMULACION DE SISTEMAS" & vbCrLf & vbCrLf & "Licenciatura en Desarrollo de Software" & vbCrLf
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(99, 97)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 15)
        Label7.TabIndex = 34
        Label7.Text = "Desarrollo de Software VIII" & vbCrLf
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(98, 132)
        Label8.Name = "Label8"
        Label8.Size = New Size(145, 45)
        Label8.TabIndex = 35
        Label8.Text = "Integrantes: " & vbCrLf & "Nombre: Cristian Andrade" & vbCrLf & "Cedula: 3-749-573"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1128, 549)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(TextBox11)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(txtbxUSERRESULT)
        Controls.Add(TextBox10)
        Controls.Add(btnSolve)
        Controls.Add(Label1)
        Controls.Add(txtbxSYSTRESULT)
        Controls.Add(txtbxN4)
        Controls.Add(txtbxO3)
        Controls.Add(txtbxN3)
        Controls.Add(txtbxO2)
        Controls.Add(txtbxN2)
        Controls.Add(txtbxO1)
        Controls.Add(txtbxN1)
        Controls.Add(btnMINUS)
        Controls.Add(btnFOR)
        Controls.Add(btnPLUS)
        Controls.Add(btnDIVIDE)
        Controls.Add(btnRN4)
        Controls.Add(btnRN3)
        Controls.Add(btnRN2)
        Controls.Add(btnRN1)
        Controls.Add(btnNext)
        Controls.Add(btnDeleteAll)
        Controls.Add(btnDelete)
        Controls.Add(btnSTART)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSTART As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnDeleteAll As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnRN1 As Button
    Friend WithEvents btnRN2 As Button
    Friend WithEvents btnRN3 As Button
    Friend WithEvents btnRN4 As Button
    Friend WithEvents btnDIVIDE As Button
    Friend WithEvents btnPLUS As Button
    Friend WithEvents btnFOR As Button
    Friend WithEvents btnMINUS As Button
    Friend WithEvents txtbxN1 As TextBox
    Friend WithEvents txtbxO1 As TextBox
    Friend WithEvents txtbxN2 As TextBox
    Friend WithEvents txtbxO2 As TextBox
    Friend WithEvents txtbxN3 As TextBox
    Friend WithEvents txtbxO3 As TextBox
    Friend WithEvents txtbxN4 As TextBox
    Friend WithEvents txtbxSYSTRESULT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSolve As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents txtbxUSERRESULT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
