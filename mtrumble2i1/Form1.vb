Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: insert/remove
        Dim strWord As String
        strWord = txt03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03.Text = strWord

        '#04: substring
        Dim strItem As String
        Dim strColor As String
        strItem = txt04.Text
        strColor = strItem.Substring(2, 4)
        lbl04.Text = strColor

        '#05a: length
        Dim strMsg As String
        Dim intChars As Integer
        strMsg = txt05a.Text
        intChars = strMsg.Length
        lbl05a.Text = intChars.ToString

        '05b: Trim
        Dim strState As String
        strState = txt05b.Text
        lbl05b.Text = strState.Trim

        '#05c: Insert/Remove
        Dim strReplace As String
        strReplace = txt05c.Text
        strReplace = strReplace.Remove(1, 1)
        strReplace = strReplace.Insert(1, "rit")
        lbl05c.Text = strReplace

        '#05d: insert
        Dim strDay As String
        strDay = txt05d.Text
        strDay = strDay.Insert(0, "Mon")
        lbl05d.Text = strDay

        '#05e: Pad
        Dim strPay As String
        strPay = txt05e.Text
        lbl05e.Text = strPay.PadLeft(10, "*"c)

        '#06: remove
        Dim strAmount As String
        strAmount = txt06.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06.Text = strAmount

        '#07: Contains
        Dim strAddress As String
        Dim blnIsContained As Boolean
        strAddress = txt07.Text
        blnIsContained = strAddress.ToLower.Contains("jefferson street")
        If blnIsContained Then
            lbl07.Text = "Jef. St. found"
        Else
            lbl07.Text = "Jef. St. not found"
        End If

        '#12: Len/Remove
        Dim strRate As String
        Dim intLength As Integer
        Dim dblTax As Double
        Dim dblRate As Double
        strRate = txt12.Text
        intLength = strRate.Length
        strRate = strRate.Remove(intLength - 2, 2)
        Double.TryParse(strRate, dblRate)
        lbl12.Text = (dblRate * 1000 * 0.01).ToString("c2")

        '#13: like
        Dim strZip As String
        strZip = txt13.Text
        If strZip Like "605##" Then
            lbl13.Text = "Shipping $25"
        ElseIf strZip Like "606##" Then
            lbl13.Text = "Shipping $30"
        Else
            lbl13.Text = "Invalid Zip"
        End If
    End Sub
End Class
