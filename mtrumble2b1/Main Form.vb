' Name: Cranston Berries Project
' Purpose: Calculate projected increase
' Programmer: Molly Trumble on 9/7/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' declare variables
        Dim decProjIncrease As Decimal
        Dim decStraw As Decimal
        Dim decBlue As Decimal
        Dim decRasp As Decimal
        Dim decProjStraw As Decimal
        Dim decProjBLue As Decimal
        Dim decProjRasp As Decimal

        ' convert input to decimal and assign to variables
        Decimal.TryParse(txtProjIncrease.Text, decProjIncrease)
        Decimal.TryParse(txtStraw.Text, decStraw)
        Decimal.TryParse(txtBlue.Text, decBlue)
        Decimal.TryParse(txtRasp.Text, decRasp)

        ' calculate projected increase
        decProjStraw = decStraw * (1 + decProjIncrease)
        decProjBlue = decBlue * (1 + decProjIncrease)
        decProjRasp = decRasp * (1 + decProjIncrease)

        ' display projected increase
        lblStraw.Text = decProjStraw.ToString("C2")
        lblBlue.Text = decProjBLue.ToString("C2")
        lblRasp.Text = decProjRasp.ToString("C2")

        'lblStraw.Text = Format(Val(txtStraw.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
        'lblBlue.Text = Format(Val(txtBlue.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
        'lblRasp.Text = Format(Val(txtRasp.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all labels and text boxes
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty

        lblStraw.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty

        txtProjIncrease.Text = "0.05"
        ' set focus to txtProjIncrease
        txtProjIncrease.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' exit the form
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmRetirement.Show()
    End Sub
End Class