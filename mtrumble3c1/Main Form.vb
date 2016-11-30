' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Molly Trumble on 11/25/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
            Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged,
            radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged
        Dim dblMeasurment As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurment)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurment, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurment, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurment)
        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurment)
        End If

        lblResult.Text = dblResult.ToString("n2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double
        Return dblMeas * 2.54
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double) As Double
        Return dblMeas / 2.54
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' fill combo box

        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Satern")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"

    End Sub

    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        ' accept only numbers and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        ' select text when entered
        txtEarthWeight.SelectAll()
    End Sub

    Private Sub CalcWeightSub(ByVal intWeight As Integer, ByRef dblWeightOnPlanet As Double)
        Dim dblGravity As Double
        ' assign value to dblGravity
        Select Case cboPlanets.Text
            Case "Earth"
                dblGravity = 1.0
            Case "Mars", "Mercury"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        ' calculate weight on planet
        dblWeightOnPlanet = dblGravity * intWeight
    End Sub

    Private Function CalcWeightFunc(ByVal intWeight As Integer) As Double
        Dim dblGravity As Double
        ' assign value to dblGravity
        Select Case cboPlanets.Text
            Case "Earth"
                dblGravity = 1.0
            Case "Mars", "Mercury"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        ' return calculated weight on planet
        Return (dblGravity * intWeight)
    End Function

    Private Sub WeightInputChanged(sender As Object, e As EventArgs) _
        Handles txtEarthWeight.TextChanged, cboPlanets.SelectedIndexChanged, radSub.CheckedChanged, radFunction.CheckedChanged

        Dim dblPlanetWeight As Double = 0.0
        Dim intEarthWeight As Integer

        Integer.TryParse(txtEarthWeight.Text, intEarthWeight)
        ' calculate with the appropriate procedure
        If radSub.Checked Then
            CalcWeightSub(intEarthWeight, dblPlanetWeight)
        ElseIf radFunction.Checked Then
            dblPlanetWeight = CalcWeightFunc(intEarthWeight)
        End If

        lblWeight.Text = dblPlanetWeight.ToString("n2")
    End Sub
End Class
