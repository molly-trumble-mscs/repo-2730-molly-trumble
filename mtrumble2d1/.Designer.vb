<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Convert2 = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtDollar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.btnCalcTea = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBill = New System.Windows.Forms.Label()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnCalcElectric = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblQuotient = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnCalcQuot = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Convert2)
        Me.GroupBox1.Controls.Add(Me.btnConvert)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.txtDollar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Currency Converter"
        '
        'Convert2
        '
        Me.Convert2.Location = New System.Drawing.Point(140, 74)
        Me.Convert2.Name = "Convert2"
        Me.Convert2.Size = New System.Drawing.Size(115, 33)
        Me.Convert2.TabIndex = 6
        Me.Convert2.Text = "Convert <>"
        Me.Convert2.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(140, 35)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(115, 33)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "&Convert ="
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(494, 35)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(135, 20)
        Me.label7.TabIndex = 5
        Me.label7.Text = "South African &rand:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(376, 35)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(100, 20)
        Me.label6.TabIndex = 4
        Me.label6.Text = "British &pound:"
        '
        'txtDollar
        '
        Me.txtDollar.Location = New System.Drawing.Point(18, 63)
        Me.txtDollar.Name = "txtDollar"
        Me.txtDollar.Size = New System.Drawing.Size(100, 27)
        Me.txtDollar.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "&Euro:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "American &dollar:"
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(498, 63)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(114, 27)
        Me.lblRand.TabIndex = 2
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(379, 63)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(114, 27)
        Me.lblPound.TabIndex = 1
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(261, 63)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(114, 27)
        Me.lblEuro.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(573, 467)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 33)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtPounds)
        Me.GroupBox2.Controls.Add(Me.btnCalcTea)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 90)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tea Time"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(378, 50)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(114, 27)
        Me.lblTotalDue.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(136, 50)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 27)
        Me.txtPrice.TabIndex = 5
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(17, 50)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(100, 27)
        Me.txtPounds.TabIndex = 4
        '
        'btnCalcTea
        '
        Me.btnCalcTea.Location = New System.Drawing.Point(257, 47)
        Me.btnCalcTea.Name = "btnCalcTea"
        Me.btnCalcTea.Size = New System.Drawing.Size(115, 33)
        Me.btnCalcTea.TabIndex = 3
        Me.btnCalcTea.Text = "Calculate"
        Me.btnCalcTea.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(378, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Due:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(132, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Price/lb:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Pounds:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnCalcElectric)
        Me.GroupBox3.Controls.Add(Me.txtCurrent)
        Me.GroupBox3.Controls.Add(Me.txtPrevious)
        Me.GroupBox3.Controls.Add(Me.lblBill)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(647, 97)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Triple County Electric"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Previous:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(129, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Current:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(375, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Monthly bill:"
        '
        'lblBill
        '
        Me.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBill.Location = New System.Drawing.Point(375, 57)
        Me.lblBill.Name = "lblBill"
        Me.lblBill.Size = New System.Drawing.Size(114, 27)
        Me.lblBill.TabIndex = 3
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(14, 57)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(100, 27)
        Me.txtPrevious.TabIndex = 5
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(133, 57)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 27)
        Me.txtCurrent.TabIndex = 6
        '
        'btnCalcElectric
        '
        Me.btnCalcElectric.Location = New System.Drawing.Point(253, 54)
        Me.btnCalcElectric.Name = "btnCalcElectric"
        Me.btnCalcElectric.Size = New System.Drawing.Size(115, 33)
        Me.btnCalcElectric.TabIndex = 7
        Me.btnCalcElectric.Text = "Calculate"
        Me.btnCalcElectric.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCalcQuot)
        Me.GroupBox4.Controls.Add(Me.txtNum2)
        Me.GroupBox4.Controls.Add(Me.txtNum1)
        Me.GroupBox4.Controls.Add(Me.lblQuotient)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 359)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(638, 98)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Division"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "First:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(123, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Second:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(370, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Quotient:"
        '
        'lblQuotient
        '
        Me.lblQuotient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotient.Location = New System.Drawing.Point(368, 53)
        Me.lblQuotient.Name = "lblQuotient"
        Me.lblQuotient.Size = New System.Drawing.Size(114, 27)
        Me.lblQuotient.TabIndex = 3
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(9, 51)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 27)
        Me.txtNum1.TabIndex = 4
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(127, 51)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 27)
        Me.txtNum2.TabIndex = 5
        '
        'btnCalcQuot
        '
        Me.btnCalcQuot.Location = New System.Drawing.Point(247, 48)
        Me.btnCalcQuot.Name = "btnCalcQuot"
        Me.btnCalcQuot.Size = New System.Drawing.Size(115, 33)
        Me.btnCalcQuot.TabIndex = 6
        Me.btnCalcQuot.Text = "Calculate"
        Me.btnCalcQuot.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 512)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ex1D"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label7 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRand As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDollar As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalcTea As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Convert2 As Button
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents lblBill As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalcElectric As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents lblQuotient As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCalcQuot As Button
End Class
