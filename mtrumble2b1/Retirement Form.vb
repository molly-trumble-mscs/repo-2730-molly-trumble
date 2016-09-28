Option Explicit On
Option Strict On
Option Infer Off

Public Class frmRetirement

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' declare variables
        Dim decGrossPay As Decimal
        Dim decContRate As Decimal
        Dim decEmprContRate As Decimal
        Dim decAnnCont As Decimal
        Dim decEmprAnnCont As Decimal
        Dim decTotalCont As Decimal

        ' convert text to decimal and assign to variables
        Decimal.TryParse(txtGrossPay.Text, decGrossPay)
        Decimal.TryParse(txtEmpeContRate.Text, decContRate)
        Decimal.TryParse(txtEmprContRate.Text, decEmprContRate)

        ' perform calculations
        decAnnCont = (decGrossPay * decContRate) * 52
        decEmprAnnCont = (decGrossPay * decEmprContRate) * 52
        decTotalCont = decAnnCont + decEmprAnnCont

        ' display results
        lblEmpeAnnCont.Text = decAnnCont.ToString("C2")
        lblEmprAnnCont.Text = decEmprAnnCont.ToString("C2")
        lblTotalCont.Text = decTotalCont.ToString("C2")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear generated and inputed content
        txtGrossPay.Text = "0.00"
        txtEmpeContRate.Text = "0.05"
        txtEmprContRate.Text = "0.05"
        lblEmpeAnnCont.Text = String.Empty
        lblEmprAnnCont.Text = String.Empty
        lblTotalCont.Text = String.Empty

        ' set focus
        txtGrossPay.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmMain.Close()
    End Sub

    Private Sub ChangedText(sender As Object, e As EventArgs) _
        Handles txtGrossPay.TextChanged, txtEmpeContRate.TextChanged, txtEmprContRate.TextChanged
        ' clear generated and inputed content
        lblEmpeAnnCont.Text = String.Empty
        lblEmprAnnCont.Text = String.Empty
        lblTotalCont.Text = String.Empty
    End Sub
End Class