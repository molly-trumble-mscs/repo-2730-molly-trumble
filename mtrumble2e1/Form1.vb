Public Class Form1
    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Const dblSHIPPING_FEE As Double = 9
        Const dblNO_SHIPPING_FEE As Double = 0
        Dim dblOrder As Double
        Dim strCreditCard As String

        Double.TryParse(txtOrder.Text, dblOrder)
        strCreditCard = txtCreditCard.Text

        If dblOrder >= 100 AndAlso strCreditCard.ToUpper = "Y" Then
            lblShipping.Text = dblNO_SHIPPING_FEE.ToString("c2")
        Else
            lblShipping.Text = dblSHIPPING_FEE.ToString("c2")
        End If

        If txtCreditCard.Text = String.Empty OrElse txtOrder.Text = String.Empty Then
            MessageBox.Show("Please enter an order amount!", "Savannah's website", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Const dblSHIPPING_FEE As Double = 9
        Const dblNO_SHIPPING_FEE As Double = 0
        Dim dblOrder As Double
        Dim strCreditCard As String

        Double.TryParse(txtOrder.Text, dblOrder)
        strCreditCard = txtCreditCard.Text

        If dblOrder < 100 OrElse strCreditCard.ToUpper <> "Y" Then
            lblShipping.Text = dblSHIPPING_FEE.ToString("c2")
        Else
            lblShipping.Text = dblNO_SHIPPING_FEE.ToString("c2")
        End If

        If txtCreditCard.Text = String.Empty OrElse txtOrder.Text = String.Empty Then
            MessageBox.Show("Please enter an order amount!", "Savannah's website", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ChangedText(sender As Object, e As EventArgs
                            ) Handles txtOrder.TextChanged, txtCreditCard.TextChanged
        lblShipping.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalcEqual_Click(sender As Object, e As EventArgs) Handles btnCalcEqual.Click
        Const dblMORE_ID_COM As Double = 0.15
        Const dblLESS_ID_COM As Double = 0.12
        Dim strId As String
        Dim dblSales As Double
        Dim dblCommission As Double

        Double.TryParse(txtSales.Text, dblSales)
        strId = txtId.Text

        If (dblSales >= 25000) AndAlso
            (strId.ToUpper = "A1" OrElse strId.ToUpper = "B2" OrElse strId.ToUpper = "C3") Then

            dblCommission = (dblSales * dblMORE_ID_COM)
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            dblCommission = (dblSales * dblLESS_ID_COM)
            lblCommission.Text = dblCommission.ToString("c2")
        End If
    End Sub

    Private Sub btnNotEqual_Click(sender As Object, e As EventArgs) Handles btnNotEqual.Click
        Const dblMORE_ID_COM As Double = 0.15
        Const dblLESS_ID_COM As Double = 0.12
        Dim strId As String
        Dim dblSales As Double
        Dim dblCommission As Double

        Double.TryParse(txtSales.Text, dblSales)
        strId = txtId.Text

        If (strId.ToUpper <> "A1" AndAlso strId.ToUpper <> "B2" AndAlso strId.ToUpper <> "C3") OrElse
            ((strId.ToUpper = "A1" OrElse strId.ToUpper = "B2" OrElse strId.ToUpper = "C3") AndAlso
            (dblSales < 25000)) Then

            dblCommission = (dblSales * dblLESS_ID_COM)
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            dblCommission = (dblSales * dblMORE_ID_COM)
            lblCommission.Text = dblCommission.ToString("c2")
        End If
    End Sub

    Private Sub ComTextChange(sender As Object, e As EventArgs) Handles txtId.TextChanged, txtSales.TextChanged
        lblCommission.Text = String.Empty
    End Sub

End Class
