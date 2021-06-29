Public Class Form1
    Dim num1, num2, resultado As Double
    Dim simbolo As String

    Private Sub btnNumeros_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click, btnDecimal.Click
        Me.txtPantalla.Text += sender.text
        Me.lblCuentas.Text += sender.text
    End Sub

    Private Sub btnSimbolos(sender As Object, e As EventArgs) Handles btnSumar.Click, btnRestar.Click, btnMultiplicar.Click, btnDividir.Click, btnPorcentaje.Click, btnRaizCuadrada.Click
        num1 = txtPantalla.Text
        simbolo = sender.text
        If simbolo = "SQR" Then
            resultado = Math.Sqrt(num1)
            Me.txtPantalla.Text = resultado
            Me.lblCuentas.Text = resultado
        Else
            Me.txtPantalla.Text = Nothing
            Me.lblCuentas.Text += " " + sender.text + " "
        End If
    End Sub

    Private Sub btnSimb_Click(sender As Object, e As EventArgs) Handles btnSimb.Click
        If CDbl(txtPantalla.Text) >= 0 Then
            txtPantalla.Text = "-" + txtPantalla.Text
        Else
            txtPantalla.Text = Replace(txtPantalla.Text, "-", "")
        End If
        lblCuentas.Text = txtPantalla.Text
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        num2 = txtPantalla.Text

        Select Case simbolo
            Case "+"
                resultado = num1 + num2
            Case "-"
                resultado = num1 - num2
            Case "x"
                resultado = num1 * num2
            Case "/"
                resultado = num1 / num2
            Case "%"
                resultado = (num1 * num2) / 100
        End Select

        Me.txtPantalla.Text = resultado
        Me.lblCuentas.Text = resultado

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtPantalla.Text = Nothing
        Me.lblCuentas.Text = Nothing
    End Sub

End Class
