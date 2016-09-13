' Name: Average Project
' Purpose: Calculate Average Test Score
' Programmer: Molly Trumble on 9/13/2016

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate test score average
        lblAvgScore.Text = Format((Val(lblScore1.Text) + Val(lblScore2.Text) + Val(lblScore3.Text)) / 3, "standard")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear all generated content 
        lblScore1.Text = String.Empty
        lblScore2.Text = String.Empty
        lblScore3.Text = String.Empty
        lblAvgScore.Text = String.Empty
        'set focus to lblScore1
        lblScore1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
