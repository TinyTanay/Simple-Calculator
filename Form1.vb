Public Class Form1

    Dim Firstvalue, Secondvalue, result As Double
    Dim op As String

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn1.Click, btn2.Click, btn3.Click, btn0.Click, btnDP.Click
        Dim b As Button = sender

        If (txtDisplay.Text) = "0" Then
            txtDisplay.Text = ""
            txtDisplay.Text = b.Text

        ElseIf b.Text = "." Then
            If (Not txtDisplay.Text.Contains(".")) Then
                txtDisplay.Text = txtDisplay.Text + b.Text

            End If
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub btnBS_Click(sender As Object, e As EventArgs) Handles btnBS.Click
        If txtDisplay.Text.Length > 0 Then
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
        End If

        If txtDisplay.Text.Length = "" Then
            txtDisplay.Text = "0"

        End If

    End Sub

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles btnP.Click, btnM.Click, btnT.Click, btnD.Click

        Dim b As Button = sender
        Firstvalue = txtDisplay.Text
        op = b.Text
        txtDisplay.Text = ""

    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click

        Secondvalue = txtDisplay.Text

        If op = "+" Then

            result = Firstvalue + Secondvalue
            txtDisplay.Text = result

        ElseIf op = "-" Then

            result = Firstvalue - Secondvalue
            txtDisplay.Text = result

        ElseIf op = "×" Then

            result = Firstvalue * Secondvalue
            txtDisplay.Text = result

        ElseIf op = "÷" Then

            result = Firstvalue / Secondvalue
            txtDisplay.Text = result

        End If

    End Sub

    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click

        If (txtDisplay.Text.Contains("-")) Then
            txtDisplay.Text = txtDisplay.Text.Remove(0, 1)

        Else
            txtDisplay.Text = "-" + txtDisplay.Text

        End If

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

        txtDisplay.Text = "0"

    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click

        txtDisplay.Text = "0"

    End Sub
End Class