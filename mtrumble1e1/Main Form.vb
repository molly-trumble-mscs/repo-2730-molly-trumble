' Name:         Richardson Project
' Purpose:      Calculates tax
' Programmer:   Molly Trumble on 9/2/2016
Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' caculate tax
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all text for next input
        lblTax.Text = String.Empty
        txtAssessed.Text = String.Empty

        ' set focus to txtAssessed
        txtAssessed.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
