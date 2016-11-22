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
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDoLoop = New System.Windows.Forms.Button()
        Me.lstMultTable = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstPrices = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPretax = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(97, 25)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(42, 32)
        Me.txtNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Multiplication table:"
        '
        'btnForNext
        '
        Me.btnForNext.Location = New System.Drawing.Point(28, 63)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(111, 33)
        Me.btnForNext.TabIndex = 2
        Me.btnForNext.Text = "&For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(342, 366)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(111, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDoLoop
        '
        Me.btnDoLoop.Location = New System.Drawing.Point(28, 102)
        Me.btnDoLoop.Name = "btnDoLoop"
        Me.btnDoLoop.Size = New System.Drawing.Size(111, 33)
        Me.btnDoLoop.TabIndex = 3
        Me.btnDoLoop.Text = "&Do...Loop"
        Me.btnDoLoop.UseVisualStyleBackColor = True
        '
        'lstMultTable
        '
        Me.lstMultTable.FormattingEnabled = True
        Me.lstMultTable.ItemHeight = 25
        Me.lstMultTable.Location = New System.Drawing.Point(163, 53)
        Me.lstMultTable.Name = "lstMultTable"
        Me.lstMultTable.Size = New System.Drawing.Size(148, 254)
        Me.lstMultTable.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstMultTable)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDoLoop)
        Me.GroupBox1.Controls.Add(Me.txtNumber)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnForNext)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 348)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Multiplication Table"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblTax)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblPretax)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lstPrices)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(332, 323)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Barclay w/Validation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Prices:"
        '
        'lstPrices
        '
        Me.lstPrices.FormattingEnabled = True
        Me.lstPrices.ItemHeight = 25
        Me.lstPrices.Location = New System.Drawing.Point(11, 75)
        Me.lstPrices.Name = "lstPrices"
        Me.lstPrices.Size = New System.Drawing.Size(120, 204)
        Me.lstPrices.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(168, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pretax Total: "
        '
        'lblPretax
        '
        Me.lblPretax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPretax.Location = New System.Drawing.Point(173, 82)
        Me.lblPretax.Name = "lblPretax"
        Me.lblPretax.Size = New System.Drawing.Size(116, 28)
        Me.lblPretax.TabIndex = 10
        Me.lblPretax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(173, 142)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(116, 28)
        Me.lblTax.TabIndex = 12
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(168, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Tax:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(173, 205)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(116, 28)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(168, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 25)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Total: "
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(173, 248)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 34)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 413)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiplication Table"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnForNext As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDoLoop As Button
    Friend WithEvents lstMultTable As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPretax As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstPrices As ListBox
    Friend WithEvents Label3 As Label
End Class
