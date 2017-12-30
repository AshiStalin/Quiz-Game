Public Class Form1
    Dim u As String
    Dim a As Integer = 51
    Dim ee As Integer = 51
    Dim ii As Integer = 41
    Dim aei As Integer = 41
    Dim w As Integer = 31
    Dim ai As Integer = 31
    Dim aii As Integer = 21
    Dim aai As Integer = 21
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
        RadioButton16.Checked = False
        RadioButton17.Checked = False
        RadioButton18.Checked = False
        RadioButton19.Checked = False
        RadioButton20.Checked = False

        Button7.Enabled = True
        Button8.Enabled = True
        Button11.Enabled = True
        Button12.Enabled = True
        Button15.Enabled = True
        Button16.Enabled = True
        Button19.Enabled = True
        Button20.Enabled = True

        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
        RadioButton5.Enabled = True
        RadioButton6.Enabled = True
        RadioButton7.Enabled = True
        RadioButton8.Enabled = True
        RadioButton9.Enabled = True
        RadioButton10.Enabled = True
        RadioButton11.Enabled = True
        RadioButton12.Enabled = True
        RadioButton13.Enabled = True
        RadioButton14.Enabled = True
        RadioButton15.Enabled = True
        RadioButton16.Enabled = True
        RadioButton17.Enabled = True
        RadioButton18.Enabled = True

        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False
        Chart4.Visible = False

        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        u = TextBox1.Text()

        TabControl1.SelectTab(2)
        Label5.Text = "Welcome Ms./Mr. : " & u
        RadioButton21.Checked = False
        RadioButton22.Checked = False
        RadioButton23.Checked = False
        RadioButton24.Checked = False
        RadioButton25.Checked = False
        RadioButton26.Checked = False
        RadioButton27.Checked = False
        RadioButton28.Checked = False
        RadioButton29.Checked = False
        RadioButton30.Checked = False
        RadioButton31.Checked = False
        RadioButton32.Checked = False

        Button23.Enabled = True
        Button24.Enabled = True
        Button27.Enabled = True
        Button28.Enabled = True
        Button31.Enabled = True
        Button32.Enabled = True
        Button35.Enabled = True
        Button36.Enabled = True

        RadioButton19.Enabled = True
        RadioButton20.Enabled = True
        RadioButton21.Enabled = True
        RadioButton22.Enabled = True
        RadioButton23.Enabled = True
        RadioButton24.Enabled = True
        RadioButton25.Enabled = True
        RadioButton26.Enabled = True
        RadioButton27.Enabled = True
        RadioButton28.Enabled = True
        RadioButton29.Enabled = True
        RadioButton30.Enabled = True
        RadioButton31.Enabled = True
        RadioButton32.Enabled = True

        Chart5.Visible = False
        Chart6.Visible = False
        Chart7.Visible = False
        Chart8.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.SelectTab(3)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(4)
        a = 51
        Timer1.Start()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton2.Checked Then
            MessageBox.Show("CORRECT! Headed on to the round 2 with Rs.10,000")
            TabControl1.SelectTab(5)
            ee = 51
            Timer2.Start()

            If Button7.Enabled = False Then
                Button11.Enabled = False
            End If

            If Button8.Enabled = False Then
                Button12.Enabled = False
            End If

        ElseIf RadioButton1.Checked Or RadioButton3.Checked Or RadioButton4.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.0. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""


        Else
            MessageBox.Show("Select an option.")
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton3.Enabled = False
        RadioButton4.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Enabled = False

        Chart1.Series("Votes").Points.AddXY("A", 15)
        Chart1.Series("Votes").Points.AddXY("B", 30)
        Chart1.Series("Votes").Points.AddXY("C", 10)
        Chart1.Series("Votes").Points.AddXY("D", 5)
        Chart1.Visible = True
    End Sub



    Private Sub Button13_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Button12.Enabled = False

        Chart2.Series("Votes").Points.AddXY("A", 25)
        Chart2.Series("Votes").Points.AddXY("B", 15)
        Chart2.Series("Votes").Points.AddXY("C", 2)
        Chart2.Series("Votes").Points.AddXY("D", 14)
        Chart2.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton7.Enabled = False
        RadioButton8.Enabled = False
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        ii = 41
        Timer5.Start()
        If RadioButton5.Checked Then
            MessageBox.Show("CORRECT!LEVEL 1 COMPLETED! Headed on to the round 3 with Rs.20,000")
            TabControl1.SelectTab(6)


            If Button11.Enabled = False Then
                Button15.Enabled = False
            End If
            If Button12.Enabled = False Then
                Button16.Enabled = False
            End If


        ElseIf RadioButton6.Checked Or RadioButton7.Checked Or RadioButton8.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.10,000. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""
        Else
            MessageBox.Show("Select an option.")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Button15.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton9.Enabled = False
        RadioButton12.Enabled = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Button16.Enabled = False

        Chart3.Series("Votes").Points.AddXY("A", 5)
        Chart3.Series("Votes").Points.AddXY("B", 15)
        Chart3.Series("Votes").Points.AddXY("C", 28)
        Chart3.Series("Votes").Points.AddXY("D", 12)
        Chart3.Visible = True
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        aei = 41
        Timer6.Start()
        If RadioButton11.Checked Then
            MessageBox.Show("CORRECT! Headed on to the round 4 with Rs.30,000")
            TabControl1.SelectTab(7)


            If Button15.Enabled = False Then
                Button19.Enabled = False
            End If
            If Button16.Enabled = False Then
                Button20.Enabled = False
            End If


        ElseIf RadioButton9.Checked Or RadioButton10.Checked Or RadioButton12.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.20,000. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""
        Else
            MessageBox.Show("Select an option.")
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Button19.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton15.Enabled = False
        RadioButton13.Enabled = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Button20.Enabled = False

        Chart4.Series("Votes").Points.AddXY("A", 2)
        Chart4.Series("Votes").Points.AddXY("B", 10)
        Chart4.Series("Votes").Points.AddXY("C", 5)
        Chart4.Series("Votes").Points.AddXY("D", 20)
        Chart4.Visible = True
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        w = 31
        Timer8.Start()

        If RadioButton16.Checked Then
            MessageBox.Show("CORRECT!LEVEL 2 COMPLETED! Headed on to the round 5 with Rs.40,000")
            TabControl1.SelectTab(8)

            If Button19.Enabled = False Then
                Button23.Enabled = False
            End If

            If Button20.Enabled = False Then
                Button24.Enabled = False
            End If


        ElseIf RadioButton13.Checked Or RadioButton14.Checked Or RadioButton15.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.30,000. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""
        Else
            MessageBox.Show("Select an option.")
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Button24.Enabled = False

        Chart5.Series("Votes").Points.AddXY("A", 30)
        Chart5.Series("Votes").Points.AddXY("B", 12)
        Chart5.Series("Votes").Points.AddXY("C", 15)
        Chart5.Series("Votes").Points.AddXY("D", 10)
        Chart5.Visible = True
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Button23.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton18.Enabled = False
        RadioButton17.Enabled = False
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ai = 31
        Timer3.Start()
        If RadioButton20.Checked Then
            MessageBox.Show("CORRECT! Headed on to the round 6 with Rs.50,000")
            TabControl1.SelectTab(9)

            If Button23.Enabled = False Then
                Button27.Enabled = False
            End If
            If Button24.Enabled = False Then
                Button28.Enabled = False
            End If


        ElseIf RadioButton18.Checked Or RadioButton19.Checked Or RadioButton17.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.40,000. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""
        Else
            MessageBox.Show("Select an option.")
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Button28.Enabled = False

        Chart6.Series("Votes").Points.AddXY("A", 30)
        Chart6.Series("Votes").Points.AddXY("B", 20)
        Chart6.Series("Votes").Points.AddXY("C", 5)
        Chart6.Series("Votes").Points.AddXY("D", 10)
        Chart6.Visible = True
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Button27.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton23.Enabled = False
        RadioButton24.Enabled = False
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        aii = 21
        Timer7.Start()

        If RadioButton21.Checked Then
            MessageBox.Show("CORRECT!LEVEL 3 COMPLETED! Headed on to the round 7 with Rs.60,000")
            TabControl1.SelectTab(10)

            If Button27.Enabled = False Then
                Button31.Enabled = False
            End If
            If Button28.Enabled = False Then
                Button32.Enabled = False
            End If


        ElseIf RadioButton22.Checked Or RadioButton23.Checked Or RadioButton24.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.50,000. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""
        Else
            MessageBox.Show("Select an option.")
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Button31.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton26.Enabled = False
        RadioButton27.Enabled = False
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Button32.Enabled = False

        Chart7.Series("Votes").Points.AddXY("A", 0)
        Chart7.Series("Votes").Points.AddXY("B", 2)
        Chart7.Series("Votes").Points.AddXY("C", 27)
        Chart7.Series("Votes").Points.AddXY("D", 10)
        Chart7.Visible = True
    End Sub



    Private Sub Button37_Click_1(sender As Object, e As EventArgs)

        MessageBox.Show("Thank You for playing.")
        Close()
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Button36.Enabled = False

        Chart8.Series("Votes").Points.AddXY("A", 12)
        Chart8.Series("Votes").Points.AddXY("B", 2)
        Chart8.Series("Votes").Points.AddXY("C", 0)
        Chart8.Series("Votes").Points.AddXY("D", 30)
        Chart8.Visible = True
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Button35.Enabled = False

        MessageBox.Show("Two options are eliminated!")
        RadioButton29.Enabled = False
        RadioButton31.Enabled = False
    End Sub



    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        aai = 21
        Timer4.Start()

        If RadioButton25.Checked Then
            MessageBox.Show("CORRECT!Headed on to the last, round 8 with Rs.70,000")
            TabControl1.SelectTab(11)

            If Button31.Enabled = False Then
                Button35.Enabled = False
            End If
            If Button32.Enabled = False Then
                Button36.Enabled = False
            End If


        ElseIf RadioButton27.Checked Or RadioButton26.Checked Or RadioButton28.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.60,000. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""
        Else
            MessageBox.Show("Select an option.")
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click

        If RadioButton32.Checked Then
            MessageBox.Show("CORRECT!LEVEL 4 completed! You have earned Rs.90,000")
            TabControl1.SelectTab(12)

        ElseIf RadioButton29.Checked Or RadioButton30.Checked Or RadioButton31.Checked Then
            MessageBox.Show("WRONG! You have earned Rs.80,000. Play again to find the correct answer.")
            TabControl1.SelectTab(0)
            TextBox1.Text = ""
        Else
            MessageBox.Show("Select an option.")
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        RadioButton5.BackColor = Color.DarkTurquoise
        Timer2.Stop()

        If RadioButton5.Checked = False Then
            RadioButton5.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        RadioButton6.BackColor = Color.DarkTurquoise
        Timer2.Stop()
        If RadioButton6.Checked = False Then
            RadioButton6.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        RadioButton7.BackColor = Color.DarkTurquoise
        Timer2.Stop()
        If RadioButton7.Checked = False Then
            RadioButton7.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        RadioButton8.BackColor = Color.DarkTurquoise
        Timer2.Stop()
        If RadioButton8.Checked = False Then
            RadioButton8.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        RadioButton13.BackColor = Color.DarkTurquoise
        Timer6.Stop()
        If RadioButton13.Checked = False Then
            RadioButton13.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        Timer6.Stop()
        RadioButton14.BackColor = Color.DarkTurquoise

        If RadioButton14.Checked = False Then
            RadioButton14.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        RadioButton15.BackColor = Color.DarkTurquoise
        Timer6.Stop()
        If RadioButton15.Checked = False Then
            RadioButton15.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        RadioButton16.BackColor = Color.DarkTurquoise
        Timer6.Stop()
        If RadioButton16.Checked = False Then
            RadioButton16.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        RadioButton21.BackColor = Color.DarkTurquoise
        Timer3.Stop()
        If RadioButton21.Checked = False Then
            RadioButton21.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        RadioButton22.BackColor = Color.DarkTurquoise
        Timer3.Stop()
        If RadioButton22.Checked = False Then
            RadioButton22.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        RadioButton23.BackColor = Color.DarkTurquoise
        Timer3.Stop()
        If RadioButton23.Checked = False Then
            RadioButton23.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        RadioButton24.BackColor = Color.DarkTurquoise
        Timer3.Stop()
        If RadioButton24.Checked = False Then
            RadioButton24.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        RadioButton29.BackColor = Color.DarkTurquoise
        Timer4.Stop()
        If RadioButton29.Checked = False Then
            RadioButton29.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        RadioButton30.BackColor = Color.DarkTurquoise
        Timer4.Stop()
        If RadioButton30.Checked = False Then
            RadioButton30.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        RadioButton31.BackColor = Color.DarkTurquoise
        Timer4.Stop()
        If RadioButton31.Checked = False Then
            RadioButton31.BackColor = Color.SlateBlue
        End If
    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        RadioButton32.BackColor = Color.DarkTurquoise
        Timer4.Stop()
        If RadioButton32.Checked = False Then
            RadioButton32.BackColor = Color.SlateBlue
        End If
    End Sub


    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        aai = aai - 1
        Label24.Text = aai.ToString + "Seconds"

        If aai = 0 Then
            Timer4.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub


    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ai = ai - 1
        Label25.Text = ai.ToString + "Seconds"

        If ai = 0 Then
            Timer3.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub

    Private Sub Button39_Click_1(sender As Object, e As EventArgs) Handles Button39.Click
        Timer9.Start()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Form2.Show()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Form2.Show()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Form2.Show()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Form2.Show()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        Form2.Show()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Form2.Show()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Form2.Show()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Form2.Show()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a = a - 1
        Label26.Text = a.ToString + "Seconds"


        If a = 0 Then
            Timer1.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ee = ee - 1
        Label27.Text = ee.ToString + "Seconds"

        If ee = 0 Then
            Timer2.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub


    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        ii = ii - 1
        Label28.Text = ii.ToString + "Seconds"

        If ii = 0 Then
            Timer5.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub


    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        aii = aii - 1
        Label4.Text = aii.ToString + "Seconds"

        If aii = 0 Then
            Timer7.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Timer1.Stop()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Timer1.Stop()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Timer1.Stop()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Timer1.Stop()
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        Timer5.Stop()
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Timer5.Stop()
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        Timer5.Stop()
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        Timer5.Stop()
    End Sub


    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        aei = aei - 1
        Label22.Text = aei.ToString + "Seconds"

        If aei = 0 Then
            Timer6.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub


    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        w = w - 1
        Label2.Text = w.ToString + "Seconds"

        If w = 0 Then
            Timer8.Stop()
            MessageBox.Show("TIME'S UP!")

            Close()
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        Timer8.Stop()
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        Timer8.Stop()
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        Timer8.Stop()
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        Timer8.Stop()
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        Timer7.Stop()
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        Timer7.Stop()
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        Timer7.Stop()
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        Timer7.Stop()
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        ProgressBar1.Increment(10)

        If ProgressBar1.Value = 100 Then
            Close()
        End If
    End Sub


End Class