Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' declare variables
        Const decEURO_RATE As Decimal = 0.8976D
        Const decPOUND_RATE As Decimal = 0.8049D
        Const decRAND_RATE As Decimal = 13.9071D
        Const strMSG As String = "Please enter an American dollar amount"
        Dim decDollar As Decimal
        Dim decEuro As Decimal
        Dim decPound As Decimal
        Dim decRand As Decimal

        Decimal.TryParse(txtDollar.Text, decDollar)

        If txtDollar.Text = String.Empty Then
            MessageBox.Show(strMSG, "Currecy Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' calculate conversions
            decEuro = decDollar * decEURO_RATE
            decPound = decDollar * decPOUND_RATE
            decRand = decDollar * decRAND_RATE

            ' display results
            lblEuro.Text = decEuro.ToString("n2")
            lblPound.Text = decPound.ToString("n2")
            lblRand.Text = decRand.ToString("n2")
        End If
    End Sub

    Private Sub Convert2_Click(sender As Object, e As EventArgs) Handles Convert2.Click
        ' declare variables
        Const decEURO_RATE As Decimal = 0.8976D
        Const decPOUND_RATE As Decimal = 0.8049D
        Const decRAND_RATE As Decimal = 13.9071D
        Const strMSG As String = "Please enter an American dollar amount"
        Dim decDollar As Decimal
        Dim decEuro As Decimal
        Dim decPound As Decimal
        Dim decRand As Decimal

        Decimal.TryParse(txtDollar.Text, decDollar)

        If txtDollar.Text <> String.Empty Then
            ' calculate conversions
            decEuro = decDollar * decEURO_RATE
            decPound = decDollar * decPOUND_RATE
            decRand = decDollar * decRAND_RATE

            ' display results
            lblEuro.Text = decEuro.ToString("n2")
            lblPound.Text = decPound.ToString("n2")
            lblRand.Text = decRand.ToString("n2")
        Else
            MessageBox.Show(strMSG, "Currecy Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtDollar_TextChanged(sender As Object, e As EventArgs) Handles txtDollar.TextChanged
        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click
        ' declare variables
        Const dblSHIPING_FEE As Double = 15
        Const strSHIPPING_MSG As String = "Should the customber be charged $15 for shipping?"
        Dim dblPounds As Double
        Dim dblPrice As Double
        Dim dblTotal As Double
        Dim dlgButton As DialogResult

        ' convert text to numbers
        Double.TryParse(txtPounds.Text, dblPounds)
        Double.TryParse(txtPrice.Text, dblPrice)

        ' calculate total
        dblTotal = dblPounds * dblPrice

        ' ask user if customer shouold be charged for shipping and apply accordingly. Then display result
        dlgButton = MessageBox.Show(strSHIPPING_MSG, "Tea Time", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        If dlgButton = DialogResult.Yes Then
            dblTotal = dblTotal + dblSHIPING_FEE
            lblTotalDue.Text = dblTotal.ToString()
        Else
            lblTotalDue.Text = dblTotal.ToString()
        End If
    End Sub

    Private Sub teaTime_TextChanged(sender As Object, e As EventArgs
            ) Handles txtPounds.TextChanged, txtPrice.TextChanged
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalcElectric_Click(sender As Object, e As EventArgs) Handles btnCalcElectric.Click
        ' declare variables
        Const dblCHG_PER_UNIT As Double = 0.13
        Const strMSG As String = "Current reading must be greater than or equal to the previous reading."
        Dim dblCurrent As Double
        Dim dblPrevious As Double
        Dim dblBill As Double

        ' convert text to numbers
        Double.TryParse(txtCurrent.Text, dblCurrent)
        Double.TryParse(txtPrevious.Text, dblPrevious)

        ' display error message if text boxes are empty or the current reading is less thean the previous.
        ' Otherwise caculate and display the result
        If dblPrevious >= dblCurrent OrElse
            txtPrevious.Text = String.Empty OrElse
            txtCurrent.Text = String.Empty Then

            MessageBox.Show(strMSG, "Triple County Electric",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dblBill = (dblCurrent - dblPrevious) * dblCHG_PER_UNIT
            lblBill.Text = dblBill.ToString
        End If
    End Sub

    Private Sub electric_TextChanged(sender As Object, e As EventArgs
                ) Handles txtCurrent.TextChanged, txtPrevious.TextChanged
        lblBill.Text = String.Empty
    End Sub

    Private Sub btnCalcQuot_Click(sender As Object, e As EventArgs) Handles btnCalcQuot.Click
        Dim dblNum1 As Double
        Dim dblNum2 As Double
        Dim dblQuotient As Double

        ' convert text to numbers
        Double.TryParse(txtNum1.Text, dblNum1)
        Double.TryParse(txtNum2.Text, dblNum2)

        ' swap numbers if necessary.
        If dblNum1 < dblNum2 Then
            Dim dblTemp As Double
            dblTemp = dblNum1
            dblNum1 = dblNum2
            dblNum2 = dblTemp
        End If

        ' display error when smaller number is 0. Otherwise calculate.
        If dblNum2 = 0 Then
            MessageBox.Show("Cannot divide by 0", "Quotient", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            dblQuotient = dblNum1 / dblNum2
            lblQuotient.Text = dblQuotient.ToString()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class