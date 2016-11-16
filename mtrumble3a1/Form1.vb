Public Class Form1
    Private Sub btnPreDoWhile_Click(sender As Object, e As EventArgs) Handles btnPreDoWhile.Click
        Dim intEven As Integer
        lblEven.Text = "Do While Pretest" & ControlChars.NewLine
        Do While intEven <= 20
            lblEven.Text = lblEven.Text & intEven & ControlChars.NewLine
            intEven += 2
        Loop
    End Sub

    Private Sub btnPreDoUntil_Click(sender As Object, e As EventArgs) Handles btnPreDoUntil.Click
        Dim intEven As Integer
        lblEven.Text = "Do Until Pretest" & ControlChars.NewLine
        Do Until intEven > 20
            lblEven.Text = lblEven.Text & intEven & ControlChars.NewLine
            intEven += 2
        Loop
    End Sub

    Private Sub btnPostLoopWhile_Click(sender As Object, e As EventArgs) Handles btnPostLoopWhile.Click
        Dim intEven As Integer
        lblEven.Text = "Loop While Posttest" & ControlChars.NewLine
        Do
            lblEven.Text = lblEven.Text & intEven & ControlChars.NewLine
            intEven += 2
        Loop While intEven <= 20
    End Sub

    Private Sub PostLoopUntil_Click(sender As Object, e As EventArgs) Handles PostLoopUntil.Click
        Dim intEven As Integer
        lblEven.Text = "Loop Until Posttest" & ControlChars.NewLine
        Do
            lblEven.Text = lblEven.Text & intEven & ControlChars.NewLine
            intEven += 2
        Loop Until intEven > 20
    End Sub

    Private Sub btnPreFor_Click(sender As Object, e As EventArgs) Handles btnPreFor.Click
        Dim intEven As Integer
        lblEven.Text = "For Next Pretest" & ControlChars.NewLine
        For intEven = 0 To 20 Step 2
            lblEven.Text = lblEven.Text & intEven & ControlChars.NewLine
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' clear screen
        txtList.Text = String.Empty
        lblAverage.Text = String.Empty
        lblCount.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number" &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        Do While strNum <> String.Empty
            ' convert input to a number
            Int32.TryParse(strNum, intNum)

            ' display input in textbox
            txtList.Text = txtList.Text & intNum & ControlChars.NewLine

            ' update counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' get next sales amount
            strNum = InputBox(strPROMPT, strTITLE, "0")
        Loop


        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAverage.Text = dblAvg.ToString
        Else
            lblAverage.Text = "N/A"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' clear screen
        txtList.Text = String.Empty
        lblAverage.Text = String.Empty
        lblCount.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number" &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        Do
            ' convert input to a number
            Int32.TryParse(strNum, intNum)

            ' display input in textbox
            txtList.Text = txtList.Text & intNum & ControlChars.NewLine

            ' update counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' get next sales amount
            strNum = InputBox(strPROMPT, strTITLE, "0")
        Loop Until strNum = String.Empty


        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAverage.Text = dblAvg.ToString
        Else
            lblAverage.Text = "N/A"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' clear screen
        txtList.Text = String.Empty
        lblAverage.Text = String.Empty
        lblCount.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a number" &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end"
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim strNumInput As String
        Dim intNumInput As Integer
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get number of inputs
        strNumInput = InputBox("Enter number of input: ", strTITLE, "1")
        Int32.TryParse(strNumInput, intNumInput)

        For i As Integer = 1 To intNumInput

            ' get next sales amount
            strNum = InputBox(strPROMPT, strTITLE, "0")

            ' convert input to a number
            Int32.TryParse(strNum, intNum)

            ' display input in textbox
            txtList.Text = txtList.Text & intNum & ControlChars.NewLine

            ' update counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

        Next i


        lblCount.Text = intCount.ToString
        ' verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAverage.Text = dblAvg.ToString
        Else
            lblAverage.Text = "N/A"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
