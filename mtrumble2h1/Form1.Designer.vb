<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotoalDue = New System.Windows.Forms.Label()
        Me.chkOver10 = New System.Windows.Forms.CheckBox()
        Me.chkTraveling = New System.Windows.Forms.CheckBox()
        Me.btnIf = New System.Windows.Forms.Button()
        Me.btnNested = New System.Windows.Forms.Button()
        Me.btnElseIf = New System.Windows.Forms.Button()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Commission only:"
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(21, 165)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(100, 23)
        Me.lblCommission.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Additional amount:"
        '
        'lblAdditional
        '
        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditional.Location = New System.Drawing.Point(21, 228)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditional.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total due salesperson:"
        '
        'lblTotoalDue
        '
        Me.lblTotoalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotoalDue.Location = New System.Drawing.Point(24, 296)
        Me.lblTotoalDue.Name = "lblTotoalDue"
        Me.lblTotoalDue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotoalDue.TabIndex = 7
        '
        'chkOver10
        '
        Me.chkOver10.AutoSize = True
        Me.chkOver10.Location = New System.Drawing.Point(24, 79)
        Me.chkOver10.Name = "chkOver10"
        Me.chkOver10.Size = New System.Drawing.Size(120, 21)
        Me.chkOver10.TabIndex = 8
        Me.chkOver10.Text = "Over 10 years"
        Me.chkOver10.UseVisualStyleBackColor = True
        '
        'chkTraveling
        '
        Me.chkTraveling.AutoSize = True
        Me.chkTraveling.Location = New System.Drawing.Point(24, 114)
        Me.chkTraveling.Name = "chkTraveling"
        Me.chkTraveling.Size = New System.Drawing.Size(89, 21)
        Me.chkTraveling.TabIndex = 9
        Me.chkTraveling.Text = "Traveling"
        Me.chkTraveling.UseVisualStyleBackColor = True
        '
        'btnIf
        '
        Me.btnIf.Location = New System.Drawing.Point(159, 44)
        Me.btnIf.Name = "btnIf"
        Me.btnIf.Size = New System.Drawing.Size(93, 29)
        Me.btnIf.TabIndex = 10
        Me.btnIf.Text = "If Then"
        Me.btnIf.UseVisualStyleBackColor = True
        '
        'btnNested
        '
        Me.btnNested.Location = New System.Drawing.Point(159, 79)
        Me.btnNested.Name = "btnNested"
        Me.btnNested.Size = New System.Drawing.Size(93, 29)
        Me.btnNested.TabIndex = 11
        Me.btnNested.Text = "Nested If"
        Me.btnNested.UseVisualStyleBackColor = True
        '
        'btnElseIf
        '
        Me.btnElseIf.Location = New System.Drawing.Point(159, 114)
        Me.btnElseIf.Name = "btnElseIf"
        Me.btnElseIf.Size = New System.Drawing.Size(93, 29)
        Me.btnElseIf.TabIndex = 12
        Me.btnElseIf.Text = "If ElseIf"
        Me.btnElseIf.UseVisualStyleBackColor = True
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(159, 149)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(93, 29)
        Me.btnSelectCase.TabIndex = 13
        Me.btnSelectCase.Text = "Select case"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 184)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 29)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 251)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reference"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(189, 193)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 17)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "$700"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(189, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 17)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "$500"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 193)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Traveling"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 17)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "> 10 years"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 17)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Additional amounts"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(189, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "$3120 + 14% of sales > 30,000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(189, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 17)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "$120 + 13% of sales > 6,000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(189, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "10%of sales"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "30,000 and over"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "6,000-29,999.99"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "1-5,999.99"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(189, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Commission:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(25, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sales $:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(24, 44)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 22)
        Me.txtSales.TabIndex = 16
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 350)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectCase)
        Me.Controls.Add(Me.btnElseIf)
        Me.Controls.Add(Me.btnNested)
        Me.Controls.Add(Me.btnIf)
        Me.Controls.Add(Me.chkTraveling)
        Me.Controls.Add(Me.chkOver10)
        Me.Controls.Add(Me.lblTotoalDue)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCommission)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCommission As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotoalDue As Label
    Friend WithEvents chkOver10 As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents btnIf As Button
    Friend WithEvents btnNested As Button
    Friend WithEvents btnElseIf As Button
    Friend WithEvents btnSelectCase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
End Class
