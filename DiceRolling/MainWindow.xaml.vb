Class MainWindow

    Dim x = 0
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        If ((AttackerOneDice.IsChecked <> True And AttackerTwoDice.IsChecked <> True And AttackerThreeDice.IsChecked <> True) Or (DefenderOneDice.IsChecked <> True And DefenderTwoDice.IsChecked <> True)) Then
            MessageBox.Show("Must choose # of Dice for both players!")
            Exit Sub
        End If

        If (AttackerThreeDice.IsChecked) Then

            Dim r1 = Int((6 * Rnd()) + 1)
            Dim r2 = Int((6 * Rnd()) + 1)
            Dim r3 = Int((6 * Rnd()) + 1)

            Dim results = New Integer() {r1, r2, r3}

            Array.Sort(results)
            Array.Reverse(results)

            AttackerResult1.Text = "Roll 1-  " + results(0).ToString()
            AttackerResult2.Text = "Roll 2-  " + results(1).ToString()
            AttackerResult3.Text = "Roll 3-  " + results(2).ToString()

        ElseIf (AttackerTwoDice.IsChecked) Then

            Dim r1 = Int((6 * Rnd()) + 1)
            Dim r2 = Int((6 * Rnd()) + 1)

            Dim results = New Integer() {r1, r2}

            Array.Sort(results)
            Array.Reverse(results)

            AttackerResult1.Text = "Roll 1-  " + results(0).ToString()
            AttackerResult2.Text = "Roll 2-  " + results(1).ToString()

        ElseIf (AttackerOneDice.IsChecked) Then
            AttackerResult1.Text = "Roll 1-  " + Int((6 * Rnd()) + 1).ToString()

        End If


        If (DefenderOneDice.IsChecked) Then
            DefenderResult1.Text = Int((6 * Rnd()) + 1).ToString() + "  -Roll 1"

        ElseIf (DefenderTwoDice.IsChecked) Then
            Dim r1 = Int((6 * Rnd()) + 1)
            Dim r2 = Int((6 * Rnd()) + 1)

            Dim results = New Integer() {r1, r2}

            Array.Sort(results)
            Array.Reverse(results)

            DefenderResult1.Text = results(0).ToString() + "  -Roll 1"
            DefenderResult2.Text = results(1).ToString() + "  -Roll 2"

        End If

        If (AttackerResult1.Text <> "" And DefenderResult1.Text <> "") Then
            Dim a1 = AttackerResult1.Text.Substring(9, 1)
            Dim d1 = DefenderResult1.Text.Substring(0, 1)

            a1 = Convert.ToInt32(a1)
            d1 = Convert.ToInt32(d1)

            If (a1 > d1) Then
                winner1.Text = "Attacker Won!"
                winner1.Foreground = New SolidColorBrush(Colors.Red)
            Else
                winner1.Text = "Defender Won!"
                winner1.Foreground = New SolidColorBrush(Colors.Blue)
            End If
        End If


        If (AttackerResult2.Text <> "" And DefenderResult2.Text <> "") Then
            Dim a2 = AttackerResult2.Text.Substring(9, 1)
            Dim d2 = DefenderResult2.Text.Substring(0, 1)

            a2 = Convert.ToInt32(a2)
            d2 = Convert.ToInt32(d2)

            If (a2 > d2) Then
                winner2.Text = "Attacker Won!"
                winner2.Foreground = New SolidColorBrush(Colors.Red)
            Else
                winner2.Text = "Defender Won!"
                winner2.Foreground = New SolidColorBrush(Colors.Blue)
            End If
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearButton.Click
        AttackerResult1.Text = ""
        AttackerResult2.Text = ""
        AttackerResult3.Text = ""

        DefenderResult1.Text = ""
        DefenderResult2.Text = ""

        winner1.Text = ""
        winner2.Text = ""
    End Sub
End Class