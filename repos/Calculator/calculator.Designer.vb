<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class calculator
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnPoint = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(180, 10)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(43, 23)
        Me.btnReset.TabIndex = 20
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 23)
        Me.TextBox1.TabIndex = 19
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(178, 208)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(47, 44)
        Me.btnDivide.TabIndex = 17
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(178, 156)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(47, 44)
        Me.btnEquals.TabIndex = 16
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(178, 104)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(47, 44)
        Me.btn8.TabIndex = 15
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(122, 208)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(47, 44)
        Me.btnMultiply.TabIndex = 14
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(178, 51)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(47, 44)
        Me.btn4.TabIndex = 13
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(67, 208)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(47, 44)
        Me.btnMinus.TabIndex = 12
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(122, 104)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(47, 44)
        Me.btn7.TabIndex = 3
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btnPoint
        '
        Me.btnPoint.Location = New System.Drawing.Point(122, 156)
        Me.btnPoint.Name = "btnPoint"
        Me.btnPoint.Size = New System.Drawing.Size(47, 44)
        Me.btnPoint.TabIndex = 10
        Me.btnPoint.Text = "."
        Me.btnPoint.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(67, 104)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(47, 44)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(12, 208)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(47, 44)
        Me.btnPlus.TabIndex = 8
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(122, 51)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(47, 44)
        Me.btn3.TabIndex = 7
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(67, 156)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(47, 44)
        Me.btn0.TabIndex = 6
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(12, 104)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(47, 44)
        Me.btn5.TabIndex = 5
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(12, 156)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(47, 44)
        Me.btn9.TabIndex = 4
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(67, 51)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(47, 44)
        Me.btn2.TabIndex = 18
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 51)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(47, 44)
        Me.btn1.TabIndex = 11
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 262)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnPoint)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnPoint As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
End Class
