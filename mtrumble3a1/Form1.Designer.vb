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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.btnPreDoWhile = New System.Windows.Forms.Button()
        Me.btnPreDoUntil = New System.Windows.Forms.Button()
        Me.btnPostLoopWhile = New System.Windows.Forms.Button()
        Me.PostLoopUntil = New System.Windows.Forms.Button()
        Me.btnPreFor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lable2 = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPreFor)
        Me.GroupBox1.Controls.Add(Me.PostLoopUntil)
        Me.GroupBox1.Controls.Add(Me.btnPostLoopWhile)
        Me.GroupBox1.Controls.Add(Me.btnPreDoUntil)
        Me.GroupBox1.Controls.Add(Me.btnPreDoWhile)
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loops"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(7, 32)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(85, 223)
        Me.lblEven.TabIndex = 0
        '
        'btnPreDoWhile
        '
        Me.btnPreDoWhile.Location = New System.Drawing.Point(109, 32)
        Me.btnPreDoWhile.Name = "btnPreDoWhile"
        Me.btnPreDoWhile.Size = New System.Drawing.Size(155, 37)
        Me.btnPreDoWhile.TabIndex = 1
        Me.btnPreDoWhile.Text = "Pretest: Do While"
        Me.btnPreDoWhile.UseVisualStyleBackColor = True
        '
        'btnPreDoUntil
        '
        Me.btnPreDoUntil.Location = New System.Drawing.Point(109, 75)
        Me.btnPreDoUntil.Name = "btnPreDoUntil"
        Me.btnPreDoUntil.Size = New System.Drawing.Size(155, 37)
        Me.btnPreDoUntil.TabIndex = 2
        Me.btnPreDoUntil.Text = "Pretest: Do Until"
        Me.btnPreDoUntil.UseVisualStyleBackColor = True
        '
        'btnPostLoopWhile
        '
        Me.btnPostLoopWhile.Location = New System.Drawing.Point(109, 118)
        Me.btnPostLoopWhile.Name = "btnPostLoopWhile"
        Me.btnPostLoopWhile.Size = New System.Drawing.Size(155, 37)
        Me.btnPostLoopWhile.TabIndex = 3
        Me.btnPostLoopWhile.Text = "Posttest: Loop While"
        Me.btnPostLoopWhile.UseVisualStyleBackColor = True
        '
        'PostLoopUntil
        '
        Me.PostLoopUntil.Location = New System.Drawing.Point(109, 161)
        Me.PostLoopUntil.Name = "PostLoopUntil"
        Me.PostLoopUntil.Size = New System.Drawing.Size(155, 37)
        Me.PostLoopUntil.TabIndex = 4
        Me.PostLoopUntil.Text = "Posttest: Loop Until"
        Me.PostLoopUntil.UseVisualStyleBackColor = True
        '
        'btnPreFor
        '
        Me.btnPreFor.Location = New System.Drawing.Point(109, 204)
        Me.btnPreFor.Name = "btnPreFor"
        Me.btnPreFor.Size = New System.Drawing.Size(155, 37)
        Me.btnPreFor.TabIndex = 5
        Me.btnPreFor.Text = "Pretest: For Next"
        Me.btnPreFor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(255, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 28)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAverage)
        Me.GroupBox2.Controls.Add(Me.lable2)
        Me.GroupBox2.Controls.Add(Me.label1)
        Me.GroupBox2.Location = New System.Drawing.Point(332, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 277)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Addition"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(134, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(65, 17)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Average:"
        '
        'lable2
        '
        Me.lable2.AutoSize = True
        Me.lable2.Location = New System.Drawing.Point(204, 22)
        Me.lable2.Name = "lable2"
        Me.lable2.Size = New System.Drawing.Size(49, 17)
        Me.lable2.TabIndex = 1
        Me.lable2.Text = "Count:"
        '
        'lblAverage
        '
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAverage.Location = New System.Drawing.Point(137, 44)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(64, 33)
        Me.lblAverage.TabIndex = 2
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(207, 44)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(67, 33)
        Me.lblCount.TabIndex = 3
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(7, 23)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ReadOnly = True
        Me.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtList.Size = New System.Drawing.Size(121, 192)
        Me.txtList.TabIndex = 4
        Me.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 35)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Sum, Do While"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Sum, Loop Until"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(137, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 35)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Sum, For Next"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 385)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPreFor As Button
    Friend WithEvents PostLoopUntil As Button
    Friend WithEvents btnPostLoopWhile As Button
    Friend WithEvents btnPreDoUntil As Button
    Friend WithEvents btnPreDoWhile As Button
    Friend WithEvents lblEven As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtList As TextBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lable2 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
