' Name: Exercise 3D
' Purpose: working with arrays
' Programmer: Molly Trumble on 12/1/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private dblWholesale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}

    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Dim intNum As Integer

        Integer.TryParse(txtMonth.Text, intNum)
        If intNum <= 12 AndAlso intNum > 0 Then
            lblDays.Text = intDaysInMonth(intNum - 1).ToString
        Else
            MessageBox.Show("Invalid Input", "Days in Month", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        txtMonth.Focus()
        txtMonth.SelectAll()
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays the average number sold
        Dim intSold() As Integer = {250, 225, 193, 260}
        Dim dblTotal As Double = 0.0
        Dim dblAvg As Double = 0.0

        ' clear lables
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty

        ' add up total
        For intSub As Integer = 0 To intSold.GetUpperBound(0)
            dblTotal += intSold(intSub)
        Next intSub

        ' display average
        dblAvg = dblTotal / intSold.Length
        lblAvg.Text = dblAvg.ToString()

        ' find numbers lower than average
        For intSub As Integer = 0 To intSold.GetUpperBound(0)
            If intSold(intSub) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intSub).ToString() + ", "
            End If
        Next intSub

        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        ' displays the average number sold
        Dim intSold() As Integer = {250, 225, 193, 260}
        Dim dblTotal As Double = 0.0
        Dim dblAvg As Double = 0.0

        ' clear lables
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty

        ' add up total
        For Each intElement As Integer In intSold
            dblTotal += intElement
        Next intElement

        ' display average
        dblAvg = dblTotal / intSold.Length
        lblAvg.Text = dblAvg.ToString()

        ' find numbers lower than average
        For Each intElement As Integer In intSold
            If intElement < dblAvg Then
                lblLessThanAvg.Text &= intElement.ToString() + ", "
            End If
        Next intElement

        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays the average number sold
        Dim intSold() As Integer = {250, 225, 193, 260}
        Dim dblTotal As Double = 0.0
        Dim dblAvg As Double = 0.0

        ' clear lables
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty

        ' add up total
        Dim intSub As Integer = 0
        Do While intSub <= intSold.GetUpperBound(0)
            dblTotal += intSold(intSub)
            intSub += 1
        Loop

        ' display average
        dblAvg = dblTotal / intSold.Length
        lblAvg.Text = dblAvg.ToString()

        ' find numbers lower than average
        intSub = 0
        Do While intSub < intSold.GetUpperBound(0)
            If intSold(intSub) < dblAvg Then
                lblLessThanAvg.Text &= intSold(intSub).ToString() + ", "
            End If
            intSub += 1
        Loop

        If lblLessThanAvg.Text.EndsWith(", ") Then
            lblLessThanAvg.Text = lblLessThanAvg.Text.Substring(0, lblLessThanAvg.Text.Length - 2)
        End If
    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        Dim dblPercentage As Double = 0.00
        Dim strPercentage As String

        ' get percentage rate
        strPercentage = InputBox("Enter a Markup rate", "Mark up rate", "50")
        dblPercentage = Convert.ToDouble(strPercentage) * 0.01

        ' calculate and display retail price
        For Each dblElement As Double In dblWholesale
            dblElement += dblElement * dblPercentage
            lstRetail.Items.Add(dblElement.ToString("n2").PadLeft(6))
        Next dblElement
    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        ' returns array to the original wholesale prices

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            dblWholesale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fill lstWholesale with array values

        For intSub As Integer = 0 To dblWholesale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholesale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub
End Class
