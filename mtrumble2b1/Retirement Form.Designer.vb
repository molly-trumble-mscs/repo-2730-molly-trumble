<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblEmpeAnnCont = New System.Windows.Forms.Label()
        Me.lblEmprAnnCont = New System.Windows.Forms.Label()
        Me.lblTotalCont = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtEmpeContRate = New System.Windows.Forms.TextBox()
        Me.txtEmprContRate = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Weekly &Gross Pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employe&e Contribution Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employe&r Contribution Rate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Em&ployee Annual Contribution: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(251, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Employer &Annual Contribution: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "&Total Annual Contribution:"
        '
        'lblEmpeAnnCont
        '
        Me.lblEmpeAnnCont.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmpeAnnCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpeAnnCont.Location = New System.Drawing.Point(298, 187)
        Me.lblEmpeAnnCont.Name = "lblEmpeAnnCont"
        Me.lblEmpeAnnCont.Size = New System.Drawing.Size(100, 30)
        Me.lblEmpeAnnCont.TabIndex = 6
        Me.lblEmpeAnnCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmprAnnCont
        '
        Me.lblEmprAnnCont.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmprAnnCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmprAnnCont.Location = New System.Drawing.Point(298, 223)
        Me.lblEmprAnnCont.Name = "lblEmprAnnCont"
        Me.lblEmprAnnCont.Size = New System.Drawing.Size(100, 30)
        Me.lblEmprAnnCont.TabIndex = 7
        Me.lblEmprAnnCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalCont
        '
        Me.lblTotalCont.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalCont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCont.Location = New System.Drawing.Point(298, 259)
        Me.lblTotalCont.Name = "lblTotalCont"
        Me.lblTotalCont.Size = New System.Drawing.Size(100, 30)
        Me.lblTotalCont.TabIndex = 8
        Me.lblTotalCont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(298, 32)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(100, 30)
        Me.txtGrossPay.TabIndex = 9
        Me.txtGrossPay.Text = "0.00"
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmpeContRate
        '
        Me.txtEmpeContRate.Location = New System.Drawing.Point(338, 68)
        Me.txtEmpeContRate.Name = "txtEmpeContRate"
        Me.txtEmpeContRate.Size = New System.Drawing.Size(60, 30)
        Me.txtEmpeContRate.TabIndex = 10
        Me.txtEmpeContRate.Text = "0.05"
        Me.txtEmpeContRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmprContRate
        '
        Me.txtEmprContRate.Location = New System.Drawing.Point(338, 104)
        Me.txtEmprContRate.Name = "txtEmprContRate"
        Me.txtEmprContRate.Size = New System.Drawing.Size(60, 30)
        Me.txtEmprContRate.TabIndex = 11
        Me.txtEmprContRate.Text = "0.05"
        Me.txtEmprContRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(66, 322)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(98, 34)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(170, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 34)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(274, 322)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 34)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 388)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtEmprContRate)
        Me.Controls.Add(Me.txtEmpeContRate)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblTotalCont)
        Me.Controls.Add(Me.lblEmprAnnCont)
        Me.Controls.Add(Me.lblEmpeAnnCont)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblEmpeAnnCont As Label
    Friend WithEvents lblEmprAnnCont As Label
    Friend WithEvents lblTotalCont As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtEmpeContRate As TextBox
    Friend WithEvents txtEmprContRate As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
