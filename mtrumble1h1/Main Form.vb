' Name: Photo Workshop Payroll Project
' Purpose: Calculate net income, displays gross income, FWT, FICA, & state tax 
' Programmer: Molly Trumble on 9/14/2016

Option Strict On

Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate gross pay & whitholding taxes
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "fixed")
        lblFwt.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFica.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        ' calculate
        lblNet.Text = Format(Val(lblGross.Text) - (Val(lblFwt.Text) + Val(lblFica.Text) + Val(lblState.Text)), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all entered content
        txtName.Text = String.Empty
        txtHours.Text = Format(Val(0.00), "fixed")
        txtPayRate.Text = String.Empty

        lblGross.Text = String.Empty
        lblFwt.Text = String.Empty
        lblFica.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty

        ' set focus to Name text box
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
