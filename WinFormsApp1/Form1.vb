Imports System.Threading

Public Class Form1
    Private rand As New Random()
    Private txtbxNArray As New List(Of TextBox)()
    Private txtbxOArray As New List(Of TextBox)()
    Private btnArray As New List(Of Button)()
    Private sysResult As Double ' Track the Resultado Matematico
    Private textBox10Count As Integer = 0 ' Initialize TextBox10 count
    Private countdownTime As Integer = 60 ' Initialize countdown time to 60 seconds
    Private isCountdownRunning As Boolean = False ' Track if the countdown timer is running



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Adds text boxes to the txtbxNArray
        txtbxNArray.Add(txtbxN1)
        txtbxNArray.Add(txtbxN2)
        txtbxNArray.Add(txtbxN3)
        txtbxNArray.Add(txtbxN4)

        ' Adds text boxes to the txtbxOArray
        txtbxOArray.Add(txtbxO1)
        txtbxOArray.Add(txtbxO2)
        txtbxOArray.Add(txtbxO3)

        ' Adds buttons to the btnArray
        btnArray.Add(btnRN1)
        btnArray.Add(btnRN2)
        btnArray.Add(btnRN3)
        btnArray.Add(btnRN4)

        ' Disable buttons, text boxes, and other controls
        DisableControls()

        ' Initialize Timer1
        Timer1.Interval = 1000 ' 1 second
        Timer1.Enabled = False ' Initially, the timer is disabled
    End Sub

    ' Handle the Tick event of Timer1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If countdownTime > 0 Then
            countdownTime -= 1
            TextBox11.Text = countdownTime.ToString()
        Else
            ' Countdown has reached 0
            Timer1.Enabled = False ' Disable the timer
            DisableControls() ' Disable all controls
            countdownTime = 60 ' Reset countdown to 60 seconds
            TextBox11.Text = countdownTime.ToString()
            btnSTART.Enabled = True ' Enable btnSTART
        End If
    End Sub

    Private Sub DisableControls()
        ' Disable buttons in array "a" (txtbxN1, txtbxO1, txtbxN2, txtbxO2, txtbxN3, txtbxO3, txtbxN4)
        For Each txtbx In txtbxNArray
            txtbx.Enabled = False
        Next

        For Each txtbx In txtbxOArray
            txtbx.Enabled = False
        Next

        ' Disable buttons in array "b" (btnRN1, btnRN2, btnRN3, btnRN4)
        For Each btn In btnArray
            btn.Enabled = False
        Next

        ' Disable buttons in array "c" (btnPLUS, btnMINUS, btnFOR, btnDIVIDE)
        btnPLUS.Enabled = False
        btnMINUS.Enabled = False
        btnFOR.Enabled = False
        btnDIVIDE.Enabled = False

        ' Disable other controls
        txtbxSYSTRESULT.Enabled = False
        txtbxUSERRESULT.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        btnDelete.Enabled = False
        btnDeleteAll.Enabled = False
        btnNext.Enabled = False
        btnSolve.Enabled = False


    End Sub

    Private Sub EnableControls()
        ' Enable buttons in array "b" (btnRN1, btnRN2, btnRN3, btnRN4)
        For Each btn In btnArray
            btn.Enabled = True
        Next

        ' Enable btnDELETE, btnDELETEALL, btnNEXT, and btnSOLVE
        btnDelete.Enabled = True
        btnDeleteAll.Enabled = True
        btnNext.Enabled = True
        btnSolve.Enabled = True
    End Sub

    Private Sub btnSTART_Click(sender As Object, e As EventArgs) Handles btnSTART.Click
        ' Start the countdown timer
        Timer1.Enabled = True
        If Not isCountdownRunning Then
            ' Start the countdown timer
            Timer1.Enabled = True
            isCountdownRunning = True
        End If

        ' Clear data from array "a" (txtbxNArray)
        For Each txtbx In txtbxNArray
            txtbx.Text = ""
        Next

        ' Clear data from array "a" (txtbxOArray)
        For Each txtbx In txtbxOArray
            txtbx.Text = ""
        Next

        ' Clear txtbxUSERRESULT
        TextBox10.Text = ""

        ' Clear txtbxSYSTRESULT
        txtbxSYSTRESULT.Text = ""

        ' Clear txtbxUSERRESULT
        txtbxUSERRESULT.Text = ""

        ' Generate random numbers for each button in array "b" (btnRN1, btnRN2, btnRN3, btnRN4)
        For Each btn In btnArray
            Dim randomValue As Integer = rand.Next(1, 10) ' Range (1, 10)
            btn.Text = randomValue.ToString()

            ' Accumulate the random values to calculate the mathematical result
            sysResult += randomValue
        Next

        ' Display the mathematical result in txtbxSYSTRESULT
        txtbxSYSTRESULT.Text = sysResult.ToString()

        ' Enable controls for user interaction
        EnableControls()

        ' Disable btnSTART
        btnSTART.Enabled = False

        ' Display btnNEXT
        btnNext.Enabled = False
    End Sub

    Private Sub btnRN_Click(sender As Object, e As EventArgs) Handles btnRN1.Click, btnRN2.Click, btnRN3.Click, btnRN4.Click
        Dim clickedButton As Button = CType(sender, Button)

        ' Find the first available txtbxN and display the number
        For Each txtbx In txtbxNArray
            If txtbx.Text = "" Then
                txtbx.Text = clickedButton.Text
                clickedButton.Enabled = False
                Exit For
            End If
        Next

        ' Enable buttons in array "c" (btnPLUS, btnMINUS, btnFOR, btnDIVIDE)
        btnPLUS.Enabled = True
        btnMINUS.Enabled = True
        btnFOR.Enabled = True
        btnDIVIDE.Enabled = True
    End Sub

    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnPLUS.Click, btnMINUS.Click, btnFOR.Click, btnDIVIDE.Click
        Dim clickedButton As Button = CType(sender, Button)

        ' Find the first available txtbxO and display the operator
        For Each txtbx In txtbxOArray
            If txtbx.Text = "" Then
                txtbx.Text = clickedButton.Text
                clickedButton.Enabled = False
                Exit For
            End If
        Next
    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = 0

        ' Find the last filled txtbxN and clear it
        For i = txtbxNArray.Count - 1 To 0 Step -1
            If txtbxNArray(i).Text <> "" Then
                txtbxNArray(i).Text = ""
                btnArray(i).Enabled = True ' Enable the corresponding btnRN
                Exit For
            End If
        Next

        ' Enable the corresponding btnRN for the cleared txtbxN
        If i >= 0 AndAlso i < btnArray.Count Then
            btnArray(i).Enabled = True
        End If

        ' Find the last filled txtbxO and clear it
        For i = txtbxOArray.Count - 1 To 0 Step -1
            If txtbxOArray(i).Text <> "" Then
                txtbxOArray(i).Text = ""
                Exit For
            End If
        Next

        ' Enable buttons in array "c" (btnPLUS, btnMINUS, btnFOR, btnDIVIDE)
        btnPLUS.Enabled = True
        btnMINUS.Enabled = True
        btnFOR.Enabled = True
        btnDIVIDE.Enabled = True
    End Sub

    Private Sub btnDELETEALL_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        ' Clear all txtbxO elements and enable them
        For i = 0 To txtbxOArray.Count - 1
            txtbxOArray(i).Text = ""
            btnArray(i).Enabled = True ' Enable the corresponding btnRN
        Next

        For i = 0 To txtbxNArray.Count - 1
            txtbxNArray(i).Text = ""
            btnArray(i).Enabled = True ' Enable the corresponding btnRN
        Next
    End Sub

    Private Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Clear data from array "a" (txtbxNArray)
        For Each txtbx In txtbxNArray
            txtbx.Text = ""
        Next

        ' Clear data from array "a" (txtbxOArray)
        For Each txtbx In txtbxOArray
            txtbx.Text = ""
        Next

        ' Enable array "b" (btnArray)
        For Each btn In btnArray
            btn.Enabled = True
        Next

        ' Clear txtbxSYSTRESULT
        txtbxSYSTRESULT.Text = ""

        ' Clear txtbxUSERRESULT
        txtbxUSERRESULT.Text = ""

        ' Generate random numbers for each button in array "b" (btnArray)
        For Each btn In btnArray
            Dim randomValue As Integer = rand.Next(1, 10) ' Range (1, 10)
            btn.Text = randomValue.ToString()

            ' Accumulate the random values to calculate the mathematical result
            sysResult = randomValue
        Next

        ' Display the mathematical result in txtbxSYSTRESULT
        txtbxSYSTRESULT.Text = sysResult.ToString()

        ' Enabled btnSOLVE until btnNEXT is clicked again
        btnSolve.Enabled = True

        ' Enabled btnDELETE and btnDELETEALL
        btnDelete.Enabled = True
        btnDeleteAll.Enabled = True

        ' Display btnNEXT
        btnNext.Enabled = False
    End Sub


    Private Sub btnSOLVE_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        ' Disable array "b" (btnArray)
        For Each btn In btnArray
            btn.Enabled = False
        Next

        ' Disable array "c" (btnPLUS, btnMINUS, btnFOR, btnDIVIDE)
        btnPLUS.Enabled = False
        btnMINUS.Enabled = False
        btnFOR.Enabled = False
        btnDIVIDE.Enabled = False

        ' Disable btnDELETE and btnDELETEALL
        btnDelete.Enabled = False
        btnDeleteAll.Enabled = False

        ' Check if there are any empty txtbxN or txtbxO elements
        Dim isNEmpty As Boolean = False
        Dim isOEmpty As Boolean = False

        For Each txtbx In txtbxNArray
            If txtbx.Text = "" Then
                isNEmpty = True
                Exit For
            End If
        Next

        For Each txtbx In txtbxOArray
            If txtbx.Text = "" Then
                isOEmpty = True
                Exit For
            End If
        Next

        If Not isNEmpty AndAlso Not isOEmpty Then
            ' Create lists to store numbers and operators
            Dim numbers As New List(Of Double)
            Dim operators As New List(Of String)

            ' Initialize the first number
            numbers.Add(Double.Parse(txtbxNArray(0).Text))

            ' Process the expression from left to right
            For i = 0 To txtbxNArray.Count - 2
                operators.Add(txtbxOArray(i).Text)
                numbers.Add(Double.Parse(txtbxNArray(i + 1).Text))
                If operators.Count >= 1 Then
                    If operators(0) = "+" Then
                        numbers(0) += numbers(1)
                    ElseIf operators(0) = "-" Then
                        numbers(0) -= numbers(1)
                    ElseIf operators(0) = "*" Then
                        numbers(0) *= numbers(1)
                    ElseIf operators(0) = "/" Then
                        numbers(0) /= numbers(1)
                    End If
                    operators.RemoveAt(0)
                    numbers.RemoveAt(1)
                End If
            Next

            ' The result is in numbers(0)
            Dim result As Double = numbers(0)

            ' Display the result in txtbxUSERRESULT
            txtbxUSERRESULT.Text = result.ToString()

            ' Check if txtbxSYSTRESULT is equal to txtbxUSERRESULT
            If sysResult = result Then
                ' Increment TextBox10 count by 1
                textBox10Count += 1
                TextBox10.Text = textBox10Count.ToString()

                ' Increase countdown time by 40 seconds
                countdownTime += 40

                ' Update TextBox11 with the new countdown time
                TextBox11.Text = countdownTime.ToString()
            End If

            ' Enable btnNEXT to allow the user to proceed
            btnNext.Enabled = True
        Else
            MessageBox.Show("Please fill all the boxes before solving.")
        End If

        ' Disable btnSOLVE until btnNEXT is clicked again
        btnSolve.Enabled = False

        ' Enable btnNEXT
        btnNext.Enabled = True
    End Sub


    ' Helper function to Evaluacion Matematica expression
    Private Function EvaluateExpression(expression As String) As Double
        Dim table As New DataTable()
        table.Columns.Add("expression", GetType(String), expression)
        Dim row As DataRow = table.NewRow()
        table.Rows.Add(row)
        Return CDbl(row("expression"))
    End Function

End Class