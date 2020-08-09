Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Speech

Public Class Form2

    Dim WithEvents reco As New Recognition.SpeechRecognitionEngine
    'Initializes a new instance of the SpeechRecognitionEngine class using the default speech recognizer for the system



    
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        Label1.Text = "Speaking....."
        TextBox1.Text = "Voice Recognition activated "
        SAPI.speak("Voice Recognition is now activated.")
        TextBox1.Text = " "
        Label1.Text = "Speak Now....."

        Dim Comport As String
        Dim Baudrate As Integer


        Comport = "COM6"

        Baudrate = 57600


        SerialPort1.Close()
        SerialPort1.PortName = Comport
        SerialPort1.BaudRate = Baudrate
        SerialPort1.DataBits = 8
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.Handshake = Handshake.None
        SerialPort1.Encoding = System.Text.Encoding.Default
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label1.Text = "Listening....."

        reco.SetInputToDefaultAudioDevice()


        Dim gram As New Recognition.SrgsGrammar.SrgsDocument

        Dim SetOfInstructions As New Recognition.SrgsGrammar.SrgsRule("SOI")

        Dim SubSets As New Recognition.SrgsGrammar.SrgsOneOf("front", "forward", "w", "backward", "back", "s", "right", "d", "left", "a", "stop", "B 45")

        SetOfInstructions.Add(SubSets)

        gram.Rules.Add(SetOfInstructions)

        gram.Root = SetOfInstructions

        reco.LoadGrammar(New Recognition.Grammar(gram))

        reco.RecognizeAsync()

    End Sub

    Private Sub reco_RecognizeCompleted(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognizeCompletedEventArgs) Handles reco.RecognizeCompleted

        reco.RecognizeAsyncStop()

    End Sub

    Private Sub reco_SpeechRecognized(ByVal sender As Object, ByVal e As System.Speech.Recognition.RecognitionEventArgs) Handles reco.SpeechRecognized

        Select e.Result.Text



            Case "front"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "Front "
                'SerialPort1.Open()
                SAPI.speak("Front .  ")
                'SerialPort1.Write("w")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "forward"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "Forward "
                'SerialPort1.Open()
                SAPI.speak("Forward .  ")
                'SerialPort1.Write("w")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "w"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "W "
                'SerialPort1.Open()
                SAPI.speak("Dub lew .  ")
                'SerialPort1.Write("w")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "back"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "Back "
                'SerialPort1.Open()
                SAPI.speak("Back .  ")
                'SerialPort1.Write("s")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "backward"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "Backward "
                'SerialPort1.Open()
                SAPI.speak("Backward .  ")
                'SerialPort1.Write("s")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "s"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "S "
                'SerialPort1.Open()
                SAPI.speak("s .  ")
                'SerialPort1.Write("s")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "left"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "Left "
                'SerialPort1.Open()
                SAPI.speak("Left .  ")
                'SerialPort1.Write("a")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "a"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "A "
                'SerialPort1.Open()
                SAPI.speak("A .  ")
                'SerialPort1.Write("a")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Listening...."

            Case "right"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "Right "
                'SerialPort1.Open()
                SAPI.speak("Right .  ")
                'SerialPort1.Write("d")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "d"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "D "
                'SerialPort1.Open()
                SAPI.speak("De .  ")
                'SerialPort1.Write("d")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "stop"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "Stop "
                'SerialPort1.Open()
                SAPI.speak("Stop .  ")
                'SerialPort1.Write("z")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

            Case "B 45"
                Dim SAPI
                Label1.Text = "Speaking...."
                SAPI = CreateObject("SAPI.spvoice")
                TextBox1.Text = "B 45 "
                'SerialPort1.Open()
                SAPI.speak("B fourty five ")
                'SerialPort1.Write("z")
                'SerialPort1.Close()
                TextBox1.Text = " "
                Label1.Text = "Stopped"

        End Select


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        'Dim SAPI
        'SAPI = CreateObject("SAPI.spvoice")
        'Label1.Text = "Speaking....."
        'TextBox1.Text = "Voice Recognition deactivated "
        'SAPI.speak("Voice Recognition deactivated.")

        Me.Close()

    End Sub
End Class
  