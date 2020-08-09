Imports System.IO
Imports System.IO.Ports
Imports System.Threading


Public Class Form1
    Shared _continue As Boolean
    Shared _serialPort As SerialPort



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        Timer1.Enabled = True

        Dim myPort As Array
        Button6.Enabled = False
        Button7.Enabled = False
        TextBox3.Enabled = False

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox2.Items.AddRange(myPort)

        'SerialPort1.Close()
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

        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        SerialPort1.Open()
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
        SerialPort1.Write("w")
        SerialPort1.Write("w")
        SerialPort1.Write("w")
        SerialPort1.Write("w")
        SerialPort1.Write("w")
        SerialPort1.Write("w")
        SerialPort1.Write("w")
        SerialPort1.Write("w")
        SerialPort1.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SerialPort1.Open()
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
        SerialPort1.Write("z")
        SerialPort1.Write("z")
        SerialPort1.Write("z")
        SerialPort1.Write("z")
        SerialPort1.Write("z")
        SerialPort1.Write("z")
        SerialPort1.Write("z")
        SerialPort1.Write("z")
        SerialPort1.Close()

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SerialPort1.Open()
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
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        


        SerialPort1.Open()
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
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        SerialPort1.Open()
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

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        If TextBox3.Text = "front" Or TextBox3.Text = "up" Or TextBox3.Text = "forward" Or TextBox3.Text = "w" Or TextBox3.Text = "red" Then
            SerialPort1.Open()
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
            SerialPort1.Write("w")
            SerialPort1.Write("w")
            SerialPort1.Write("w")
            SerialPort1.Write("w")
            SerialPort1.Write("w")
            SerialPort1.Write("w")
            SerialPort1.Write("w")
            SerialPort1.Write("w")
            SerialPort1.Close()
        End If

        If TextBox3.Text = "back" Or TextBox3.Text = "down" Or TextBox3.Text = "backward" Or TextBox3.Text = "s" Or TextBox3.Text = "white" Then
            SerialPort1.Open()
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
        End If

        If TextBox3.Text = "right" Or TextBox3.Text = "d" Or TextBox3.Text = "green" Then
            SerialPort1.Open()
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
        End If

        If TextBox3.Text = "left" Or TextBox3.Text = "a" Or TextBox3.Text = "yellow" Then
            SerialPort1.Open()
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
        End If

        If TextBox3.Text = "stop" Or TextBox3.Text = "z" Then
            SerialPort1.Open()
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
            SerialPort1.Write("z")
            SerialPort1.Write("z")
            SerialPort1.Write("z")
            SerialPort1.Write("z")
            SerialPort1.Write("z")
            SerialPort1.Write("z")
            SerialPort1.Write("z")
            SerialPort1.Write("z")
            SerialPort1.Close()
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox3.Text = ""
    End Sub


    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Button6.Enabled = True          'Activate Manual commands
        Button7.Enabled = True          'Activate Manual commands
        TextBox3.Enabled = True         'Activate Manual commands

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Button6.Enabled = False         'Deactivate Manual/Voice Commands
        Button7.Enabled = False         'Deactivate Manual/Voice Commands
        TextBox3.Enabled = False        'Deactivate Manual/Voice Commands

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        RichTextBox1.Text = "First activate the manual command window by clicking the radio button 'Activate Manual Commands'. Type the appropriate keywords in the text window and hit the 'Send Command' button. Clear the text in the textbox. You could use any of the mentioned manual commands:                                                         Forward Direction: w, front, forward                 Backward Direction: s, back, backward                 Right Direction: d, right                                        Left Direction: a, left                                         Stop: z, stop"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
