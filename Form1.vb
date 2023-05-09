Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim num1, num2 As Double
        If Not (Double.TryParse(txtNum1.Text, num1) AndAlso Double.TryParse(txtNum2.Text, num2)) Then
            MessageBox.Show("Please enter valid numbers in both input fields.")
            Return
        End If

        If rdoAddition.Checked Or rdoSubtraction.Checked Or rdoMultiplication.Checked Or rdoDivision.Checked Then
            If rdoAddition.Checked Then
                If num1 = Math.Floor(num1) AndAlso num2 = Math.Floor(num2) AndAlso num1 >= 0 AndAlso num2 >= 0 Then
                    Dim increment As Double = 1
                    Dim result As Double = num1
                    For i As Integer = 1 To num2 Step increment
                        result += increment
                    Next
                    lblResult.Text = result
                Else
                    lblResult.Text = num1 + num2
                End If
            ElseIf rdoSubtraction.Checked Then
                lblResult.Text = num1 - num2
            ElseIf rdoMultiplication.Checked Then
                lblResult.Text = num1 * num2
            ElseIf rdoDivision.Checked Then
                If num2 = 0 Then
                    MessageBox.Show("Division by zero is undefined ^_^.")
                Else
                    lblResult.Text = num1 / num2
                End If
            End If
        Else
            MessageBox.Show("Please select: Addition, Subtraction, Multiplication, or Division.")
        End If

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNum1.Clear()
        txtNum2.Clear()
        lblResult.Text = ""
        rdoAddition.Checked = False
        rdoDivision.Checked = False
        rdoSubtraction.Checked = False
        rdoMultiplication.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If ConfirmExit() Then
            Me.Close()
        End If
    End Sub

    Private Function ConfirmExit() As Boolean
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Return result = DialogResult.Yes
    End Function
End Class