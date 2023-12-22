Public Class Form2
    Private userName As String
    Private userID As String

    ' Additional code
    ' Define variables to keep track of the last serial number and the base element
    Private WithEvents baseElementTimer As New Timer()

    ' Additional code
    'Private WithEvents debrisTimer As New Timer()
    'Private WithEvents asteroidTimer As New Timer()

    ' Additional code
    Private WithEvents movementTimer As New Timer()
    Private shipSpeedX As Integer = 0
    Private shipSpeedY As Integer = 0
    Private Const maxSpeed As Integer = 50
    Private Const acceleration As Integer = 5

    ' Additional code
    Private shipImageUp As Image ' Load ship image for upward direction
    Private shipImageDown As Image ' Load ship image for downward direction
    Private shipImageLeft As Image ' Load ship image for left direction
    Private shipImageRight As Image ' Load ship image for right direction

    ' Additional code
    Private shipImageUpRight As Image ' Load ship image for up-right direction
    Private shipImageUpLeft As Image ' Load ship image for up-left direction
    Private shipImageDownRight As Image ' Load ship image for down-right direction
    Private shipImageDownLeft As Image ' Load ship image for down-left direction

    ' Additional code
    Private spaceshipHP As Integer = 5

    ' Additional code
    Private asteroidImage As Image ' Load image
    Private spaceDebrisImage As Image ' Load image
    Private baseElementUpDown As Image ' Load image
    Private baseElementLeftRight As Image ' Load image

    ' Additional code
    ' Private isImmune As Boolean = False ' Flag to indicate spaceship immunity
    ' Private immunityTimer As New Timer() ' Timer for immunity duration

    ' Additional code
    Private WithEvents fuelTimer As New Timer()
    Private fuelTime As Integer = 60 ' Initial fuel time in seconds

    ' Additional code
    Private spaceshipStorageRoom As Integer = 0 ' Declaration and initialization

    ' Additional code
    Private baseStorageRoom As Integer = 0 ' Declaration and initialization

    ' Additional code
    Private atmosphereLevel As Integer = 1 ' Declaration and initialization

    ' Additional code
    Private WithEvents debrisTimer As New Timer()
    Private debrisList As New List(Of PictureBox)()
    Private debrisSpeeds As New Dictionary(Of PictureBox, Point)() ' Store X and Y speeds for each debris

    ' Additional code
    Private WithEvents asteroidTimer As New Timer()
    Private WithEvents asteroidTimers As New List(Of Timer)()

    ' Additional code
    Private asteroids As New List(Of PictureBox)()
    Private asteroidSpeeds As New Dictionary(Of PictureBox, Point)()

    ' Additional code
    Private baseElement As New PictureBox()

    ' Additional code
    Private asteroidCount As Integer = 2 ' Set initial asteroid count

    Public Sub New(ByVal uName As String, ByVal uID As String)
        InitializeComponent()
        userName = uName
        userID = uID

        ' Additional code
        InitializeSpaceElements() ' Additional code Call the method to initialize behavior

        ' Additional code

    End Sub

    ' Additional code for Form2 goes here

    Private Sub InitializeSpaceElements()
        ' Creating and configuring the spacecraft PictureBox
        Dim spacecraft As New PictureBox()
        spacecraft.Size = New Size(61, 52)
        spacecraft.BackColor = Color.Blue ' Set the color as an example
        ' Add spacecraft to the form
        Me.Controls.Add(spacecraft)

        ' Creating and configuring the space debris PictureBox
        Dim spaceDebris As New PictureBox()
        spaceDebris.Size = New Size(20, 17) ' Adjust size as needed, keeping it within 1/3 of spacecraft size
        spaceDebris.BackColor = Color.Red ' Set the color as an example
        ' Add space debris to the form
        ' Me.Controls.Add(spaceDebris)

        ' Creating and configuring the asteroid PictureBox
        Dim asteroid As New PictureBox()
        asteroid.Size = New Size(122, 104) ' Adjust size as needed, keeping it within twice the spacecraft size
        asteroid.BackColor = Color.Gray ' Set the color as an example
        ' Add asteroid to the form
        ' Me.Controls.Add(asteroid)

        ' Creating and configuring the base PictureBox
        Dim baseElement As New PictureBox()
        baseElement.Name = "baseElement" ' Set the name to access it later
        baseElement.Size = New Size(100, 280) ' Adjust size as needed, keeping it within 1.5 times the spacecraft size
        baseElement.BackColor = Color.Green ' Set the color as an example
        ' baseElement.Location = New Point(0, Me.Height / 2 - baseElement.Height / 2)
        ' Add base to the form
        Me.Controls.Add(baseElement)

        ' Additional code
        ' Start the timers for space debris and asteroids
        debrisTimer.Interval = 5000 ' 5 seconds
        asteroidTimer.Interval = 5000 ' 5 seconds
        debrisTimer.Start()
        asteroidTimer.Start()

        ' Additional code
        ' Load ship images for different directions
        shipImageUp = My.Resources.spaceship__1_classic___up ' alternatively use Image.FromFile("") ' Replace with your image path
        shipImageDown = My.Resources.spaceship__1_classic___down ' Replace with your image path
        shipImageLeft = My.Resources.spaceship__1_classic___left ' Replace with your image path
        shipImageRight = My.Resources.spaceship__1_classic___right ' Replace with your image path

        ' Additional code
        shipImageUpRight = My.Resources.spaceship__1_classic___upright
        shipImageUpLeft = My.Resources.spaceship__1_classic___upleft
        shipImageDownRight = My.Resources.spaceship__1_classic___downright
        shipImageDownLeft = My.Resources.spaceship__1_classic___downleft

        ' Additional code
        ' Add this in your initialization method or constructor
        fuelTimer.Interval = 1000 ' 1 second
        fuelTimer.Start()

        ' Additional code
        ' Load images for asteroid, space debris, and base element
        asteroidImage = My.Resources.asteroid ' Replace with your image path
        spaceDebrisImage = My.Resources.SPACEJUNK_NASA ' Replace with your image path
        baseElementUpDown = My.Resources.base_UpDown ' Replace with your image path
        baseElementLeftRight = My.Resources.base_LeftRight ' Replace with your image path

        ' Additional code
        Me.BackColor = Color.Black ' Set the color as an example
        ' Me.BackgroundImage = Image.FromFile("C:\Users\white\source\repos\WinFormsApp2.2\WinFormsApp2.2\src\img\infinite-space.jpg") ' Replace with your image path

        ' Determine the direction for base movement based on the last digit of userID
        Dim lastDigit As Integer = Integer.Parse(userID(userID.Length - 1))

        ' Move the base according to the specified behavior
        Select Case lastDigit
            Case 0, 1
                ' Set base direction for bottom to top movement on the left edge
                baseElement.Image = baseElementUpDown
                ' Adjust base size for top-down orientation
                baseElement.Size = New Size(100, 280)
                ' Move base from bottom to top on the left edge
                Dim timer As New Timer With {
                    .Interval = 50 ' Adjust the speed of movement if needed
                }
                AddHandler timer.Tick, Sub(sender As Object, e As EventArgs)
                                           ' Move the base along the left edge
                                           If baseElement.Top > 0 - baseElement.Height Then
                                               baseElement.Top -= 1 ' Adjust the speed of movement
                                           Else
                                               baseElement.Top = Me.Height ' Reset the position at the bottom
                                           End If
                                       End Sub
                timer.Start()
                Exit Select

            Case 2, 3
                ' Set base direction for right to left movement on the top edge
                baseElement.Image = baseElementLeftRight
                ' Adjust base size for left-right orientation
                baseElement.Size = New Size(280, 100)
                ' Move base from right to left on the top edge
                Dim timer As New Timer With {
                    .Interval = 50 ' Adjust the speed of movement if needed
                }
                AddHandler timer.Tick, Sub(sender As Object, e As EventArgs)
                                           ' Move the base along the top edge
                                           If baseElement.Left > 0 - baseElement.Width Then
                                               baseElement.Left -= 1 ' Adjust the speed of movement
                                           Else
                                               baseElement.Left = Me.Width ' Reset the position at the right edge
                                           End If
                                       End Sub
                timer.Start()
                Exit Select

            Case 4, 5
                ' Set base direction for bottom to top movement on the left edge
                baseElement.Image = baseElementUpDown
                ' Adjust base size for top-down orientation
                baseElement.Size = New Size(100, 280)
                ' Move base from top to bottom on the right edge
                baseElement.Location = New Point(Me.Width - baseElement.Width, 0) ' Initial position at the top-right corner

                Dim timer As New Timer With {
                    .Interval = 50 ' Adjust the speed of movement if needed
                }
                AddHandler timer.Tick, Sub(sender As Object, e As EventArgs)
                                           ' Move the base along the right edge
                                           If baseElement.Top < Me.Height Then
                                               baseElement.Top += 1 ' Adjust the speed of movement
                                           Else
                                               baseElement.Top = 0 - baseElement.Height ' Reset the position at the top
                                           End If
                                       End Sub
                timer.Start()
                Exit Select

            Case 6, 7
                ' Set base direction for bottom to top movement on the left edge
                baseElement.Image = baseElementUpDown
                ' Adjust base size for top-down orientation
                baseElement.Size = New Size(100, 280)
                ' Move base from top to bottom on the left edge
                baseElement.Location = New Point(0, 0) ' Initial position at the top-left corner

                Dim timer As New Timer With {
                    .Interval = 50 ' Adjust the speed of movement if needed
                }
                AddHandler timer.Tick, Sub(sender As Object, e As EventArgs)
                                           ' Move the base along the left edge
                                           If baseElement.Top < Me.Height Then
                                               baseElement.Top += 1 ' Adjust the speed of movement
                                           Else
                                               baseElement.Top = 0 - baseElement.Height ' Reset the position at the top
                                           End If
                                       End Sub
                timer.Start()
                Exit Select

            Case 8, 9
                ' Set base direction for bottom to top movement on the left edge
                baseElement.Image = baseElementUpDown
                ' Adjust base size for top-down orientation
                baseElement.Size = New Size(100, 280)
                ' Move base from bottom to top on the right edge
                baseElement.Location = New Point(Me.Width - baseElement.Width, Me.Height - baseElement.Height) ' Initial position at the bottom-right corner

                Dim timer As New Timer With {
                    .Interval = 50 ' Adjust the speed of movement if needed
                }
                AddHandler timer.Tick, Sub(sender As Object, e As EventArgs)
                                           ' Move the base along the right edge
                                           If baseElement.Top > 0 - baseElement.Height Then
                                               baseElement.Top -= 1 ' Adjust the speed of movement
                                           Else
                                               baseElement.Top = Me.Height ' Reset the position at the bottom
                                           End If
                                       End Sub
                timer.Start()
                Exit Select

                ' Add more cases for different behaviors based on other digits if needed

            Case Else
                ' Handle default behavior or other cases
                Exit Select
        End Select

        ' Additional code
        ' Set up the timer for spacecraft movement
        movementTimer.Interval = 50  ' Timer interval (in milliseconds) for movement update
        movementTimer.Start()

    End Sub

    ' Additional code for Form2 goes here

    ' Private WithEvents debrisTimer As New Timer()
    Private debrisSpeed As Integer = 10 ' Speed in pixels per second for debris movement

    Private Sub debrisTimer_Tick(sender As Object, e As EventArgs) Handles debrisTimer.Tick
        ' Generate space debris
        If Me.Controls.OfType(Of PictureBox).Where(Function(pb) pb.Tag = "Debris").Count() < 10 Then
            Dim debris As New PictureBox()
            debris.Size = New Size(20, 17) ' Adjust size as needed
            debris.BackColor = Color.Red ' Set the color as an example
            debris.Tag = "Debris" ' Tag to identify space debris
            debris.Image = spaceDebrisImage
            debris.Location = New Point(New Random().Next(0, Me.Width - debris.Width), New Random().Next(0, Me.Height - debris.Height))
            Me.Controls.Add(debris)

            ' Add debris to the form and the debrisList
            Me.Controls.Add(debris)
            debrisList.Add(debris)

            ' Set initial speeds for the debris
            Dim speedX As Integer = 10 ' Initial X speed
            Dim speedY As Integer = 10 ' Initial Y speed
            debrisSpeeds.Add(debris, New Point(speedX, speedY))

            ' Move debris using separate timers for each debris
            Dim debrisMoveTimer As New Timer()
            debrisMoveTimer.Interval = 100 ' Timer interval (in milliseconds) for movement update
            AddHandler debrisMoveTimer.Tick, Sub(moveSender As Object, moveArgs As EventArgs)
                                                 Dim currentDebris = DirectCast(moveSender, Timer).Tag
                                                 Dim speed As Point = debrisSpeeds(currentDebris)

                                                 Dim newX As Integer = currentDebris.Location.X + speed.X
                                                 Dim newY As Integer = currentDebris.Location.Y + speed.Y

                                                 ' Check if debris touches the edges
                                                 If newX < 0 OrElse newX + currentDebris.Width > Me.ClientSize.Width Then
                                                     speed.X = -speed.X ' Reverse X direction
                                                 End If

                                                 If newY < 0 OrElse newY + currentDebris.Height > Me.ClientSize.Height Then
                                                     speed.Y = -speed.Y ' Reverse Y direction
                                                 End If

                                                 ' Update debris position and speed
                                                 currentDebris.Location = New Point(newX, newY)
                                                 debrisSpeeds(currentDebris) = speed

                                                 ' Check collision with other debris
                                                 For Each otherDebris As PictureBox In debrisList
                                                     If otherDebris IsNot currentDebris AndAlso currentDebris.Bounds.IntersectsWith(otherDebris.Bounds) Then
                                                         ' Collision detected, adjust speeds to simulate bounce
                                                         Dim otherSpeed As Point = debrisSpeeds(otherDebris)
                                                         debrisSpeeds(currentDebris) = New Point(-speed.X, -speed.Y)
                                                         debrisSpeeds(otherDebris) = New Point(-otherSpeed.X, -otherSpeed.Y)
                                                     End If
                                                 Next

                                                 ' Add collision detection and bouncing behavior for space debris
                                                 For Each baseElement As Control In Me.Controls
                                                     If TypeOf baseElement Is PictureBox AndAlso baseElement.Name = "baseElement" Then
                                                         Dim pictureBoxBaseElement As PictureBox = DirectCast(baseElement, PictureBox)

                                                         For Each debrisPictureBox As PictureBox In debrisList
                                                             If debrisPictureBox.Bounds.IntersectsWith(pictureBoxBaseElement.Bounds) Then
                                                                 ' Collision detected with the base element (UpDown or LeftRight)
                                                                 ' Implement bouncing behavior for debris
                                                                 Dim debrisSpeed As Point = debrisSpeeds(debrisPictureBox)

                                                                 If pictureBoxBaseElement.Image Is baseElementUpDown Then
                                                                     ' Reverse Y direction
                                                                     debrisSpeed = New Point(debrisSpeed.X, -debrisSpeed.Y)
                                                                 ElseIf pictureBoxBaseElement.Image Is baseElementLeftRight Then
                                                                     ' Reverse X direction
                                                                     debrisSpeed = New Point(-debrisSpeed.X, debrisSpeed.Y)
                                                                 End If

                                                                 debrisSpeeds(debrisPictureBox) = debrisSpeed
                                                             End If
                                                         Next
                                                     End If
                                                 Next
                                             End Sub
            debrisMoveTimer.Tag = debris ' Pass debris object as a tag to the timer
            debrisMoveTimer.Start()
        End If
    End Sub



    ' Private WithEvents asteroidTimer As New Timer()
    Private asteroidSpeed As Integer = 8 ' Speed in pixels per second for asteroid movement

    Private Sub asteroidTimer_Tick(sender As Object, e As EventArgs) Handles asteroidTimer.Tick
        ' Generate asteroids
        If Me.Controls.OfType(Of PictureBox).Where(Function(pb) pb.Tag = "Asteroid").Count() < asteroidCount Then
            Dim asteroid As New PictureBox()
            asteroid.Size = New Size(122, 104) ' Adjust size as needed
            asteroid.BackColor = Color.Gray ' Set the color as an example
            asteroid.Tag = "Asteroid" ' Tag to identify asteroids
            asteroid.Image = asteroidImage
            asteroid.Location = New Point(New Random().Next(0, Me.Width - asteroid.Width), New Random().Next(0, Me.Height - asteroid.Height))
            Me.Controls.Add(asteroid)

            ' Add asteroid to the form
            Me.Controls.Add(asteroid)

            ' Move asteroid using a separate timer for each asteroid
            Dim asteroidMoveTimer As New Timer()
            asteroidMoveTimer.Interval = 100 ' Timer interval (in milliseconds) for movement update

            AddHandler asteroidMoveTimer.Tick, Sub(moveSender As Object, moveArgs As EventArgs)
                                                   Dim currentAsteroid = DirectCast(moveSender, Timer).Tag

                                                   ' Set initial speed for the asteroid if it's not already set
                                                   If Not asteroidSpeeds.ContainsKey(currentAsteroid) Then
                                                       asteroidSpeeds(currentAsteroid) = New Point(10, 10) ' Adjust initial speed here
                                                   End If

                                                   ' Move the asteroid
                                                   Dim speed = asteroidSpeeds(currentAsteroid)
                                                   Dim newX As Integer = currentAsteroid.Location.X + speed.X
                                                   Dim newY As Integer = currentAsteroid.Location.Y + speed.Y

                                                   ' Check if asteroid touches the edges and handle bouncing
                                                   If newX < 0 OrElse newX + currentAsteroid.Width > Me.ClientSize.Width Then
                                                       speed = New Point(-speed.X, speed.Y) ' Reverse X direction
                                                   End If

                                                   If newY < 0 OrElse newY + currentAsteroid.Height > Me.ClientSize.Height Then
                                                       speed = New Point(speed.X, -speed.Y) ' Reverse Y direction
                                                   End If

                                                   ' Update asteroid position and speed
                                                   currentAsteroid.Location = New Point(newX, newY)
                                                   asteroidSpeeds(currentAsteroid) = speed

                                                   ' Check for collision with other asteroids
                                                   For Each otherAsteroid As Control In Me.Controls.OfType(Of PictureBox).Where(Function(pb) pb.Tag = "Asteroid" AndAlso pb IsNot currentAsteroid)
                                                       If currentAsteroid.Bounds.IntersectsWith(otherAsteroid.Bounds) Then
                                                           ' Reverse the direction of both asteroids
                                                           speed = New Point(-speed.X, -speed.Y)
                                                           asteroidSpeeds(currentAsteroid) = speed
                                                           asteroidSpeeds(DirectCast(otherAsteroid, PictureBox)) = New Point(-speed.X, -speed.Y)
                                                       End If
                                                   Next

                                                   For Each baseElement As Control In Me.Controls
                                                       If TypeOf baseElement Is PictureBox AndAlso baseElement.Name = "baseElement" Then
                                                           Dim pictureBoxBaseElement As PictureBox = DirectCast(baseElement, PictureBox)

                                                           If currentAsteroid.Bounds.IntersectsWith(pictureBoxBaseElement.Bounds) Then
                                                               ' Collision detected with the base element (UpDown or LeftRight)
                                                               ' Reverse the direction of the asteroid upon collision with the base element
                                                               If pictureBoxBaseElement.Image Is baseElementUpDown Then
                                                                   ' Reverse Y direction
                                                                   speed = New Point(speed.X, -speed.Y)
                                                               ElseIf pictureBoxBaseElement.Image Is baseElementLeftRight Then
                                                                   ' Reverse X direction
                                                                   speed = New Point(-speed.X, speed.Y)
                                                               End If
                                                               asteroidSpeeds(currentAsteroid) = speed
                                                           End If
                                                       End If
                                                   Next
                                               End Sub

            asteroidMoveTimer.Tag = asteroid ' Pass asteroid object as a tag to the timer
            asteroidTimers.Add(asteroidMoveTimer)
            asteroidMoveTimer.Start()
        End If
    End Sub

    ' Additional code for Form2 goes here

    ' Additional code
    ' Private Sub InitializeImmunityTimer()
    ' Set up the immunity timer
    ' immunityTimer.Interval = 500 ' 0.5 seconds immunity
    ' AddHandler() immunityTimer.Tick, AddressOf EndImmunity
    ' End Sub

    ' Additional code
    ' Private Sub StartImmunity()
    ' Start the immunity period
    ' isImmune = True
    ' immunityTimer.Start()
    ' End Sub

    ' Additional code
    ' Private Sub EndImmunity(sender As Object, e As EventArgs)
    ' End the immunity period
    ' isImmune = False
    ' immunityTimer.Stop()
    ' End Sub

    ' Additional code
    ' Event handler for the fuel timer's tick event
    Private Sub FuelTimer_Tick(sender As Object, e As EventArgs) Handles fuelTimer.Tick
        fuelTime -= 1 ' Decrement the fuel time by 1 second
        ToolStripLabel2.Text = "Fuel: " & fuelTime.ToString() & " sec"

        ' Check if fuel is depleted
        If fuelTime <= 0 Then
            ' Reset spaceship or perform an action when fuel is depleted
            ResetSpaceship() ' Example function to reset the spaceship
            fuelTimer.Stop() ' Stop the fuel timer
            DisableCommandKeys() ' Disable movement keys
            InertiaDrift() ' Continue the spaceship's movement based on the last command
        End If
    End Sub

    ' Method to reset the spaceship (Assuming you have a function to reset spaceship position)
    Private Sub ResetSpaceship()
        ' Code to reset the spaceship position or perform other reset actions
        ' For example:
        ' Reset spaceship position to default starting point
        ' Reset fuel time to 60 seconds
        fuelTime = 60
        ToolStripLabel2.Text = "Fuel: " & fuelTime.ToString() & " sec"
    End Sub

    Private Sub DisableCommandKeys()
        ' Disable arrow key commands
        Me.KeyPreview = True ' Allow form to capture key events
        RemoveHandler Me.KeyDown, AddressOf Form_KeyDown ' Remove the movement event handler

        ' Additional code to disable movement commands if needed
    End Sub

    Private Sub InertiaDrift()
        ' Continue the spaceship's movement at 10 pixels per second based on the last command
        ' Additional code to continue movement
    End Sub


    Private Sub movementTimer_Tick(sender As Object, e As EventArgs) Handles movementTimer.Tick
        ' Move the spacecraft based on the current speed
        Dim spacecraft As PictureBox = Me.Controls.OfType(Of PictureBox).FirstOrDefault(Function(pb) pb.BackColor = Color.Blue)
        If spacecraft IsNot Nothing Then
            Dim newX As Integer = spacecraft.Location.X + shipSpeedX
            Dim newY As Integer = spacecraft.Location.Y + shipSpeedY

            ' Check boundaries and handle edge bouncing
            If newX < 0 OrElse newX + spacecraft.Width > Me.ClientSize.Width Then
                shipSpeedX = -shipSpeedX ' Reverse X direction
            End If

            If newY < 0 OrElse newY + spacecraft.Height > Me.ClientSize.Height Then
                shipSpeedY = -shipSpeedY ' Reverse Y direction
            End If

            ' Update position based on the current speed
            spacecraft.Location = New Point(newX, newY)

            ' Calculate spaceship truster speed
            Dim trusterSpeed As Integer = Math.Abs(shipSpeedX) + Math.Abs(shipSpeedY)
            ToolStripLabel6.Text = "Truster Speed: " & trusterSpeed.ToString()

            ' Additional code
            ' Check collision with asteroids
            ' If Not isImmune Then
            ' For Each asteroid As Control In Me.Controls
            ' If TypeOf asteroid Is PictureBox AndAlso asteroid.Tag = "Asteroid" Then
            ' spacecraft.Bounds.IntersectsWith(asteroid.Bounds) Then
            ' Collision detected with an asteroid, reduce spaceship HP
            ' spaceshipHP -= 1
            ' ToolStripLabel1.Text = "HP: " & spaceshipHP.ToString()
            ' Start immunity period
            ' StartImmunity()
            ' Reset to Form1 if spaceship HP reaches 0
            ' If spaceshipHP <= 0 Then
            ' Reset spaceship HP counter
            ' spaceshipHP = 5
            ' ToolStripLabel1.Text = "HP: " & spaceshipHP.ToString()
            ' Reset to Form1 (Assuming Form1 is the startup form)
            ' Dim form1 As New Form1()
            ' Form1.Show()
            ' Me.Close()
            ' Exit Sub ' Exit the timer as the form is closing
            ' End If
            ' End If
            ' End If
            ' Next
            ' End If

            ' Game level increase
            If baseStorageRoom >= 100 Then
                atmosphereLevel += 1
                ToolStripLabel5.Text = "Atmosphere Level: " & atmosphereLevel.ToString()
                baseStorageRoom -= 100 ' Deduct 100 from the baseStorageRoom
                ToolStripLabel4.Text = "Base Storage Room: " & baseStorageRoom.ToString()

                ' Increase debris and asteroids speed by 10 pixels per second for each atmosphere level
                debrisSpeed += 10
                asteroidSpeed += 10

                ' Increase asteroid count by 1
                asteroidCount += 1
            End If

            ' Check collision with the spaceship to baseElement
            Dim baseElement As PictureBox = TryCast(Me.Controls("baseElement"), PictureBox)
            If baseElement IsNot Nothing AndAlso spacecraft.Bounds.IntersectsWith(baseElement.Bounds) Then
                ' Collision detected with the base, reset the fuel timer
                fuelTime = 60 ' Reset fuel time to initial value
                ToolStripLabel2.Text = "Fuel: " & fuelTime.ToString() & " sec"
            End If

            ' Check collision with the base
            ' Dim baseElement As PictureBox = Me.Controls.OfType(Of PictureBox).FirstOrDefault(Function(pb) pb.Name = "baseElement")
            If baseElement IsNot Nothing AndAlso spacecraft.Bounds.IntersectsWith(baseElement.Bounds) Then
                ' Collision detected with the base
                If spaceshipStorageRoom > 0 Then
                    baseStorageRoom += spaceshipStorageRoom * 10
                    ToolStripLabel4.Text = "Base Storage Room: " & baseStorageRoom.ToString()
                    spaceshipStorageRoom = 0
                    ToolStripLabel3.Text = "Spaceship Storage Room: " & spaceshipStorageRoom.ToString()
                End If
            End If

            ' Check collision with asteroids
            For Each asteroid As Control In Me.Controls
                If TypeOf asteroid Is PictureBox AndAlso asteroid.Tag = "Asteroid" Then
                    If spacecraft.Bounds.IntersectsWith(asteroid.Bounds) Then
                        ' Collision detected with an asteroid, reduce spaceship HP
                        spaceshipHP -= 1
                        ToolStripLabel1.Text = "HP: " & spaceshipHP.ToString()

                        ' Reset to Form1 if spaceship HP reaches 0
                        If spaceshipHP <= 0 Then
                            ' Reset spaceship HP counter
                            spaceshipHP = 5
                            ToolStripLabel1.Text = "HP: " & spaceshipHP.ToString()

                            ' Reset to Form1 (Assuming Form1 is the startup form)
                            Dim form3 As New Form3(userName, userID)
                            form3.Show()
                            Me.Close()
                            Exit Sub ' Exit the timer as the form is closing
                        End If
                    End If
                End If
            Next

            ' Check collision with debris
            For Each debris As Control In Me.Controls
                If TypeOf debris Is PictureBox AndAlso debris.Tag = "Debris" Then
                    If spacecraft.Bounds.IntersectsWith(debris.Bounds) Then
                        ' Collision detected with debris, add to spaceship storage room
                        If spaceshipStorageRoom < 3 Then
                            spaceshipStorageRoom += 1
                            ToolStripLabel3.Text = "Storage: " & spaceshipStorageRoom.ToString()

                            ' Remove debris from screen
                            Me.Controls.Remove(debris)
                            debris.Dispose()
                            ' Trigger creation of new debris after 5 seconds
                            debrisTimer.Interval = 5000
                            debrisTimer.Start()
                        End If
                    End If
                End If
            Next

            ' Additional code
            ' Rotate the ship image based on the direction
            If shipSpeedX > 0 Then
                spacecraft.Image = shipImageRight
            ElseIf shipSpeedX < 0 Then
                spacecraft.Image = shipImageLeft
            ElseIf shipSpeedY > 0 Then
                spacecraft.Image = shipImageDown
            ElseIf shipSpeedY < 0 Then
                spacecraft.Image = shipImageUp

                ' Additional code
            ElseIf shipSpeedX > 0 AndAlso shipSpeedY = 0 Then
                spacecraft.Image = shipImageRight ' Right
            ElseIf shipSpeedX < 0 AndAlso shipSpeedY = 0 Then
                spacecraft.Image = shipImageLeft ' Left
            ElseIf shipSpeedY > 0 AndAlso shipSpeedX = 0 Then
                spacecraft.Image = shipImageDown ' Down
            ElseIf shipSpeedY < 0 AndAlso shipSpeedX = 0 Then
                spacecraft.Image = shipImageUp ' Up
            ElseIf shipSpeedX > 0 AndAlso shipSpeedY > 0 Then
                spacecraft.Image = shipImageDownRight ' Down-Right
            ElseIf shipSpeedX > 0 AndAlso shipSpeedY < 0 Then
                spacecraft.Image = shipImageUpRight ' Up-Right
            ElseIf shipSpeedX < 0 AndAlso shipSpeedY > 0 Then
                spacecraft.Image = shipImageDownLeft ' Down-Left
            ElseIf shipSpeedX < 0 AndAlso shipSpeedY < 0 Then
                spacecraft.Image = shipImageUpLeft ' Up-Left

                ' Additional code
            End If
        End If
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Control spacecraft movement speed with arrow keys
        If fuelTime > 0 Then
            Select Case e.KeyCode
                Case Keys.Up
                    shipSpeedY -= acceleration
                    If shipSpeedY < -maxSpeed Then shipSpeedY = -maxSpeed
                Case Keys.Down
                    shipSpeedY += acceleration
                    If shipSpeedY > maxSpeed Then shipSpeedY = maxSpeed
                Case Keys.Left
                    shipSpeedX -= acceleration
                    If shipSpeedX < -maxSpeed Then shipSpeedX = -maxSpeed
                Case Keys.Right
                    shipSpeedX += acceleration
                    If shipSpeedX > maxSpeed Then shipSpeedX = maxSpeed
                Case Keys.Up Or Keys.Left ' Diagonal Up-Left
                    shipSpeedY -= acceleration
                    shipSpeedX -= acceleration
                    If shipSpeedY < -maxSpeed Then shipSpeedY = -maxSpeed
                    If shipSpeedX < -maxSpeed Then shipSpeedX = -maxSpeed
                Case Keys.Up Or Keys.Right ' Diagonal Up-Right
                    shipSpeedY -= acceleration
                    shipSpeedX += acceleration
                    If shipSpeedY < -maxSpeed Then shipSpeedY = -maxSpeed
                    If shipSpeedX > maxSpeed Then shipSpeedX = maxSpeed
                Case Keys.Down Or Keys.Left ' Diagonal Down-Left
                    shipSpeedY += acceleration
                    shipSpeedX -= acceleration
                    If shipSpeedY > maxSpeed Then shipSpeedY = maxSpeed
                    If shipSpeedX < -maxSpeed Then shipSpeedX = -maxSpeed
                Case Keys.Down Or Keys.Right ' Diagonal Down-Right
                    shipSpeedY += acceleration
                    shipSpeedX += acceleration
                    If shipSpeedY > maxSpeed Then shipSpeedY = maxSpeed
                    If shipSpeedX > maxSpeed Then shipSpeedX = maxSpeed
            End Select
        End If
    End Sub

    Private Sub Form_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' Reset the speed when arrow keys are released
        If fuelTime > 0 Then
            Select Case e.KeyCode
                Case Keys.Up
                    If shipSpeedY < 0 Then shipSpeedY = 0
                Case Keys.Down
                    If shipSpeedY > 0 Then shipSpeedY = 0
                Case Keys.Left
                    If shipSpeedX < 0 Then shipSpeedX = 0
                Case Keys.Right
                    If shipSpeedX > 0 Then shipSpeedX = 0
                Case Keys.Up Or Keys.Left ' Diagonal Up-Left
                    If shipSpeedY < 0 Or shipSpeedX < 0 Then
                        shipSpeedY = 0
                        shipSpeedX = 0
                    End If
                Case Keys.Up Or Keys.Right ' Diagonal Up-Right
                    If shipSpeedY < 0 Or shipSpeedX > 0 Then
                        shipSpeedY = 0
                        shipSpeedX = 0
                    End If
                Case Keys.Down Or Keys.Left ' Diagonal Down-Left
                    If shipSpeedY > 0 Or shipSpeedX < 0 Then
                        shipSpeedY = 0
                        shipSpeedX = 0
                    End If
                Case Keys.Down Or Keys.Right ' Diagonal Down-Right
                    If shipSpeedY > 0 Or shipSpeedX > 0 Then
                        shipSpeedY = 0
                        shipSpeedX = 0
                    End If
            End Select
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' Additional code for Form2 goes here



End Class
