Public Class Form1
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnIf_Click(sender As Object, e As EventArgs) Handles btnIf.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotoalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000 AndAlso dblSales < 30000 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000.0) * 0.14
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotalDue = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotoalDue.Text = dblTotalDue.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnNested_Click(sender As Object, e As EventArgs) Handles btnNested.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotoalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If dblSales >= 30000 Then
                dblCommissionOnly = 3120.0 + (dblSales - 30000.0) * 0.14
            Else
                If dblSales >= 6000 Then
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Else
                    If dblSales >= 1.0 Then
                        dblCommissionOnly = dblSales * 0.1
                    Else
                        If dblSales < 1.0 Then
                            dblCommissionOnly = 0.0
                        End If
                    End If
                End If
            End If
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotalDue = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotoalDue.Text = dblTotalDue.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnElseIf_Click(sender As Object, e As EventArgs) Handles btnElseIf.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotoalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dblSales >= 30000 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000.0) * 0.14
        ElseIf dblSales >= 6000 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf dblSales >= 1.0 Then
            dblCommissionOnly = dblSales * 0.1
        ElseIf dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If chkOver10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotalDue = dblCommissionOnly + dblAdditional

        lblCommission.Text = dblCommissionOnly.ToString("c2")
        lblAdditional.Text = dblAdditional.ToString("c2")
        lblTotoalDue.Text = dblTotalDue.ToString("c2")

        txtSales.Focus()
    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotoalDue.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalDue As Double = 0.0
        Dim boolSalesOK As Boolean =
        Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Format error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Select Case dblSales
                Case Is >= 30000
                    dblCommissionOnly = 3120.0 + (dblSales - 30000.0) * 0.14
                Case Is >= 6000
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Case Is >= 1.0
                    dblCommissionOnly = dblSales * 0.1
                Case Is < 1.0
                    dblCommissionOnly = 0.0
            End Select

            If chkOver10.Checked Then
                dblAdditional = dblAdditional + 500
            End If

            If chkTraveling.Checked Then
                dblAdditional = dblAdditional + 700
            End If

            dblTotalDue = dblCommissionOnly + dblAdditional

            If boolSalesOK Then
                lblCommission.Text = dblCommissionOnly.ToString("c2")
                lblAdditional.Text = dblAdditional.ToString("c2")
                lblTotoalDue.Text = dblTotalDue.ToString("c2")
            End If

            txtSales.Focus()
        End If
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub clear(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkOver10.CheckedChanged, chkTraveling.CheckedChanged
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotoalDue.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
