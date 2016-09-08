' Name: Cranston Berries Project
' Purpose: Calculate projected increase
' Programmer: Molly Trumble on 9/7/2016

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculate projected increase for each berry
        lblStraw.Text = Format(Val(txtStraw.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
        lblBlue.Text = Format(Val(txtBlue.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
        lblRasp.Text = Format(Val(txtRasp.Text) * (1 + Val(txtProjIncrease.Text)), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all labels and text boxes
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty

        lblStraw.Text = String.Empty
        lblBlue.Text = String.Empty
        lblRasp.Text = String.Empty

        txtProjIncrease.Text = String.Empty
        ' set focus to txtProjIncrease
        txtProjIncrease.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' exit the form
        Me.Close()
    End Sub
End Class