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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAvgScore = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblScore1 = New System.Windows.Forms.TextBox()
        Me.lblScore2 = New System.Windows.Forms.TextBox()
        Me.lblScore3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Test score 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Test score 2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 23)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Test score 3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Average score:"
        '
        'lblAvgScore
        '
        Me.lblAvgScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgScore.Location = New System.Drawing.Point(163, 209)
        Me.lblAvgScore.Name = "lblAvgScore"
        Me.lblAvgScore.Size = New System.Drawing.Size(72, 30)
        Me.lblAvgScore.TabIndex = 6
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(237, 70)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(95, 33)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(237, 111)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 33)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(237, 152)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 33)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblScore1
        '
        Me.lblScore1.Location = New System.Drawing.Point(142, 70)
        Me.lblScore1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(64, 30)
        Me.lblScore1.TabIndex = 0
        '
        'lblScore2
        '
        Me.lblScore2.Location = New System.Drawing.Point(142, 108)
        Me.lblScore2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(64, 30)
        Me.lblScore2.TabIndex = 1
        '
        'lblScore3
        '
        Me.lblScore3.Location = New System.Drawing.Point(142, 146)
        Me.lblScore3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(64, 30)
        Me.lblScore3.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(46, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 38)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Average Test Score "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(365, 274)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblAvgScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test Score Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAvgScore As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblScore1 As TextBox
    Friend WithEvents lblScore2 As TextBox
    Friend WithEvents lblScore3 As TextBox
    Friend WithEvents Label5 As Label
End Class
