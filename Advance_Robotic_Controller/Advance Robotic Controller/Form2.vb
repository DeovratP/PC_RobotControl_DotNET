Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Speech

Public Class Form2

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    'Initializes a new instance of the SpeechRecognitionEngine class using the default speech recognizer for the system


    
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim myPort As Array
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox2.Items.AddRange(myPort)
        


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            reco.SetInputToDefaultAudioDevice()

            'Default language is English. Other languages can be downloaded from the web.

            Dim gram As New Recognition.SrgsGrammar.SrgsDocument

            Dim SetOfInstructions As New Recognition.SrgsGrammar.SrgsRule("SOI")

            Dim SubSets As New Recognition.SrgsGrammar.SrgsOneOf("front", "forward", "w", "backward", "back", "s", "right", "d", "left", "a", "stop", "close", "one", "two", "three", "four")

            SetOfInstructions.Add(SubSets)

            gram.Rules.Add(SetOfInstructions)

            gram.Root = SetOfInstructions

            reco.LoadGrammar(New Recognition.Grammar(gram))

            reco.RecognizeAsync()

        Catch
            MessageBox.Show("Initialize the baud rate and COM port first.", "ERROR")
        End Try

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsyncStop()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Try

            Select Case e.Result.Text

                Case "front"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Front "
                    SerialPort1.Open()
                    SAPI.speak("Front .  ")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."


                Case "forward"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Forward "
                    SerialPort1.Open()
                    SAPI.speak("Forward .  ")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "w"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "W "
                    SerialPort1.Open()
                    SAPI.speak("Dub lew .  ")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Write("w")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "back"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Back "
                    SerialPort1.Open()
                    SAPI.speak("Back .  ")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "backward"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Backward "
                    SerialPort1.Open()
                    SAPI.speak("Backward .  ")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "s"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "S "
                    SerialPort1.Open()
                    SAPI.speak("s .  ")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Write("s")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "left"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Left "
                    SerialPort1.Open()
                    SAPI.speak("Left .  ")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "a"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "A "
                    SerialPort1.Open()
                    SAPI.speak("A .  ")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Write("a")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "right"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Right "
                    SerialPort1.Open()
                    SAPI.speak("Right .  ")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "d"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "D "
                    SerialPort1.Open()
                    SAPI.speak("De .  ")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Write("d")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "stop"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Stop "
                    SerialPort1.Open()
                    SAPI.speak("Stop .  ")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                    'Case "one"
                    '    Dim SAPI
                    '    Label1.Text = "Speaking...."
                    '    SAPI = CreateObject("SAPI.spvoice")
                    '    TextBox1.Text = "Red "
                    '    SerialPort1.Open()
                    '    SAPI.speak("Red .  ")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Write("w")
                    '    SerialPort1.Close()
                    '    TextBox1.Text = " "
                    '    Label1.Text = "Listening...."

                    'Case "two"
                    '    Dim SAPI
                    '    Label1.Text = "Speaking...."
                    '    SAPI = CreateObject("SAPI.spvoice")
                    '    TextBox1.Text = "Yellow "
                    '    SerialPort1.Open()
                    '    SAPI.speak("Yellow .  ")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Write("a")
                    '    SerialPort1.Close()
                    '    TextBox1.Text = " "
                    '    Label1.Text = "Listening...."

                    'Case "three"
                    '    Dim SAPI
                    '    Label1.Text = "Speaking...."
                    '    SAPI = CreateObject("SAPI.spvoice")
                    '    TextBox1.Text = "Green "
                    '    SerialPort1.Open()
                    '    SAPI.speak("Green  ")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Write("d")
                    '    SerialPort1.Close()
                    '    TextBox1.Text = " "
                    '    Label1.Text = "Listening...."

                    'Case "four"
                    '    Dim SAPI
                    '    Label1.Text = "Speaking...."
                    '    SAPI = CreateObject("SAPI.spvoice")
                    '    TextBox1.Text = "White "
                    '    SerialPort1.Open()
                    '    SAPI.speak("White  ")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Write("s")
                    '    SerialPort1.Close()
                    '    TextBox1.Text = " "
                    '    Label1.Text = "Listening...."

                Case "stop"
                    Dim SAPI
                    Label1.Text = "Speaking...."
                    SAPI = CreateObject("SAPI.spvoice")
                    TextBox1.Text = "Stop "
                    SerialPort1.Open()
                    SAPI.speak("Stop .  ")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Write("z")
                    SerialPort1.Close()
                    TextBox1.Text = " "
                    Label1.Text = "Listening...."

                Case "close"
                    Me.Close()


            End Select

        Catch

            MessageBox.Show("Possible baud rate or COM port error", "ERROR")

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            SerialPort1.PortName = ComboBox2.Text
            SerialPort1.BaudRate = ComboBox1.Text
            SerialPort1.DataBits = 8
            'Gets or sets the standard length of data bits per byte
            'The range of values for this property is from 5 through 8. The default value is 8
            SerialPort1.Parity = Parity.None
            'Gets or sets the parity-checking protocol (No of 1's during transmission)
            SerialPort1.StopBits = StopBits.One
            'Gets or sets the standard number of stopbits per byte
            SerialPort1.Handshake = Handshake.None
            'Gets or sets the handshaking protocol for serial port transmission of data (No of bits in Buffer)
            SerialPort1.Encoding = System.Text.Encoding.Default
            'Gets or sets the byte encoding for pre- and post-transmission conversion of text

            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            TextBox1.Text = "Welcome to iARC speech recognition window."
            SAPI.speak("Welcome to the speech recognition window.")
        Catch

            MessageBox.Show("An error occured during initialization. Please check whether the baud rate and COM port values are selected properly.", "ERROR")
        End Try


    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        TextBox1.Text = ""
    End Sub
End Class
  