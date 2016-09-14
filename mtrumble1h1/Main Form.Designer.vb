<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblFica = New System.Windows.Forms.Label()
        Me.lblFwt = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPayRate = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Location = New System.Drawing.Point(400, 144)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(86, 27)
        Me.lblNet.TabIndex = 48
        '
        'lblState
        '
        Me.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblState.Location = New System.Drawing.Point(308, 144)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(86, 27)
        Me.lblState.TabIndex = 47
        '
        'lblFica
        '
        Me.lblFica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFica.Location = New System.Drawing.Point(216, 144)
        Me.lblFica.Name = "lblFica"
        Me.lblFica.Size = New System.Drawing.Size(86, 27)
        Me.lblFica.TabIndex = 46
        '
        'lblFwt
        '
        Me.lblFwt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFwt.Location = New System.Drawing.Point(124, 144)
        Me.lblFwt.Name = "lblFwt"
        Me.lblFwt.Size = New System.Drawing.Size(86, 27)
        Me.lblFwt.TabIndex = 45
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGross.Location = New System.Drawing.Point(32, 144)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(86, 27)
        Me.lblGross.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 20)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Net:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(215, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "FICA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "FWT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Gross:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Pay &Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "&Hours:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "&Name:"
        '
        'txtPayRate
        '
        Me.txtPayRate.Location = New System.Drawing.Point(424, 55)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(63, 27)
        Me.txtPayRate.TabIndex = 40
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(340, 55)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(63, 27)
        Me.txtHours.TabIndex = 39
        Me.txtHours.Text = "0.00"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(32, 55)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(283, 27)
        Me.txtName.TabIndex = 38
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(308, 210)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 29)
        Me.btnExit.TabIndex = 43
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(216, 210)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 29)
        Me.btnClear.TabIndex = 42
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(124, 210)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(86, 29)
        Me.btnCalc.TabIndex = 41
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 271)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFica)
        Me.Controls.Add(Me.lblFwt)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Photo Workshop Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNet As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblFica As Label
    Friend WithEvents lblFwt As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPayRate As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalc As Button
End Class
