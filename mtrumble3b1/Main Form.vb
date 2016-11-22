' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Molly Trumble on 11/19/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Const dblTAX_RATE As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim intNumber, intProduct, intCount As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("Do loop:")
        Integer.TryParse(txtNumber.Text, intNumber)

        intCount = 1
        Do
            intProduct = intNumber * intCount
            Dim strOutput As String = "    " & intNumber.ToString() & " * " & intCount & " = " & intProduct
            lstMultTable.Items.Add(strOutput)

            intCount += 1
        Loop While intCount < 10
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim intNumber, intProduct, intCount As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, intNumber)

        For intCount = 1 To 9
            intProduct = intNumber * intCount
            Dim strOutput As String = "    " & intNumber.ToString() & " * " & intCount & " = " & intProduct
            lstMultTable.Items.Add(strOutput)
        Next

    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load list with text data
        Dim intIndex As Integer
        Dim strSelectedItem As String
        Dim dblSalesPrice As Double
        Dim dblTax As Double

        For intIndex = 1 To 4
            lstPrices.Items.Add(intIndex.ToString("n2"))
        Next intIndex

        ' calculate pretax total
        Dim dblPretax As Double
        For intIndex = 0 To lstPrices.Items.Count - 1
            ' calculate pretax
            lstPrices.SelectedIndex = intIndex
            strSelectedItem = lstPrices.SelectedItem.ToString()
            dblSalesPrice = Convert.ToDouble(strSelectedItem)
            dblPretax += dblSalesPrice
            ' calculate tax
            dblTax += dblSalesPrice * dblTAX_RATE

            lblPretax.Text = dblPretax.ToString("C2")
            lblTax.Text = dblTax.ToString("C2")
            lblTotal.Text = (dblPretax + dblTax).ToString("C2")
            lstPrices.SelectedIndex = -1
        Next intIndex
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Const strPROMPT As String = "Enter a Price:" & ControlChars.NewLine & "Valid Prices: 1.00 to 9.99"
        Const strTITLE As String = "Price Entry"
        Const strINVALID_TITLE As String = "Invalid Entry"
        Dim strPrice As String
        Dim dblPrice As Double

        strPrice = InputBox(strPROMPT, strTITLE, "1.00")
        Double.TryParse(strPrice, dblPrice)

        Do While dblPrice < 1.0 OrElse dblPrice > 9.99
            strPrice = InputBox(strPROMPT, strINVALID_TITLE, "1.00")
            Double.TryParse(strPrice, dblPrice)
        Loop

        lstPrices.Items.Add(dblPrice.ToString("N2"))

        Dim intIndex As Integer
        Dim strSelectedItem As String
        Dim dblSalesPrice As Double
        Dim dblTax As Double

        ' calculate pretax total
        Dim dblPretax As Double
        For intIndex = 0 To lstPrices.Items.Count - 1
            ' calculate pretax
            lstPrices.SelectedIndex = intIndex
            strSelectedItem = lstPrices.SelectedItem.ToString()
            dblSalesPrice = Convert.ToDouble(strSelectedItem)
            dblPretax += dblSalesPrice
            ' calculate tax
            dblTax += dblSalesPrice * dblTAX_RATE

            lblPretax.Text = dblPretax.ToString("C2")
            lblTax.Text = dblTax.ToString("C2")
            lblTotal.Text = (dblPretax + dblTax).ToString("C2")
            lstPrices.SelectedIndex = -1
        Next intIndex
    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        If lstPrices.SelectedIndex <> -1 AndAlso (e.KeyCode = Keys.Back OrElse e.KeyValue = Keys.Delete) Then
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)
        End If

        Dim intIndex As Integer
        Dim strSelectedItem As String
        Dim dblSalesPrice As Double
        Dim dblTax As Double

        ' calculate pretax total
        Dim dblPretax As Double
        For intIndex = 0 To lstPrices.Items.Count - 1
            ' calculate pretax
            lstPrices.SelectedIndex = intIndex
            strSelectedItem = lstPrices.SelectedItem.ToString()
            dblSalesPrice = Convert.ToDouble(strSelectedItem)
            dblPretax += dblSalesPrice
            ' calculate tax
            dblTax += dblSalesPrice * dblTAX_RATE

            lblPretax.Text = dblPretax.ToString("C2")
            lblTax.Text = dblTax.ToString("C2")
            lblTotal.Text = (dblPretax + dblTax).ToString("C2")
            lstPrices.SelectedIndex = -1
        Next intIndex
    End Sub
End Class
