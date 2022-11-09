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
        Me.appName = New System.Windows.Forms.Label()
        Me.screen = New System.Windows.Forms.TextBox()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.oneBtn = New System.Windows.Forms.Button()
        Me.twoBtn = New System.Windows.Forms.Button()
        Me.thresBtn = New System.Windows.Forms.Button()
        Me.fourBtn = New System.Windows.Forms.Button()
        Me.fiveBtn = New System.Windows.Forms.Button()
        Me.sixBtn = New System.Windows.Forms.Button()
        Me.sevenBtn = New System.Windows.Forms.Button()
        Me.eightBtn = New System.Windows.Forms.Button()
        Me.nineBtn = New System.Windows.Forms.Button()
        Me.zeroBtn = New System.Windows.Forms.Button()
        Me.pointBtn = New System.Windows.Forms.Button()
        Me.equalBtn = New System.Windows.Forms.Button()
        Me.plusBtn = New System.Windows.Forms.Button()
        Me.minusBtn = New System.Windows.Forms.Button()
        Me.multBtn = New System.Windows.Forms.Button()
        Me.divBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'appName
        '
        Me.appName.AutoSize = True
        Me.appName.Location = New System.Drawing.Point(293, 41)
        Me.appName.Name = "appName"
        Me.appName.Size = New System.Drawing.Size(92, 15)
        Me.appName.TabIndex = 0
        Me.appName.Text = "SmartCalculator"
        '
        'screen
        '
        Me.screen.Location = New System.Drawing.Point(223, 82)
        Me.screen.Name = "screen"
        Me.screen.ReadOnly = True
        Me.screen.Size = New System.Drawing.Size(186, 23)
        Me.screen.TabIndex = 1
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(415, 82)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(48, 26)
        Me.resetBtn.TabIndex = 2
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'oneBtn
        '
        Me.oneBtn.Location = New System.Drawing.Point(223, 137)
        Me.oneBtn.Name = "oneBtn"
        Me.oneBtn.Size = New System.Drawing.Size(45, 23)
        Me.oneBtn.TabIndex = 3
        Me.oneBtn.Text = "1"
        Me.oneBtn.UseVisualStyleBackColor = True
        '
        'twoBtn
        '
        Me.twoBtn.Location = New System.Drawing.Point(289, 137)
        Me.twoBtn.Name = "twoBtn"
        Me.twoBtn.Size = New System.Drawing.Size(47, 23)
        Me.twoBtn.TabIndex = 4
        Me.twoBtn.Text = "2"
        Me.twoBtn.UseVisualStyleBackColor = True
        '
        'thresBtn
        '
        Me.thresBtn.Location = New System.Drawing.Point(355, 137)
        Me.thresBtn.Name = "thresBtn"
        Me.thresBtn.Size = New System.Drawing.Size(47, 23)
        Me.thresBtn.TabIndex = 5
        Me.thresBtn.Text = "3"
        Me.thresBtn.UseVisualStyleBackColor = True
        '
        'fourBtn
        '
        Me.fourBtn.Location = New System.Drawing.Point(416, 137)
        Me.fourBtn.Name = "fourBtn"
        Me.fourBtn.Size = New System.Drawing.Size(47, 23)
        Me.fourBtn.TabIndex = 6
        Me.fourBtn.Text = "4"
        Me.fourBtn.UseVisualStyleBackColor = True
        '
        'fiveBtn
        '
        Me.fiveBtn.Location = New System.Drawing.Point(221, 178)
        Me.fiveBtn.Name = "fiveBtn"
        Me.fiveBtn.Size = New System.Drawing.Size(47, 23)
        Me.fiveBtn.TabIndex = 7
        Me.fiveBtn.Text = "5"
        Me.fiveBtn.UseVisualStyleBackColor = True
        '
        'sixBtn
        '
        Me.sixBtn.Location = New System.Drawing.Point(289, 178)
        Me.sixBtn.Name = "sixBtn"
        Me.sixBtn.Size = New System.Drawing.Size(47, 23)
        Me.sixBtn.TabIndex = 8
        Me.sixBtn.Text = "6"
        Me.sixBtn.UseVisualStyleBackColor = True
        '
        'sevenBtn
        '
        Me.sevenBtn.Location = New System.Drawing.Point(355, 178)
        Me.sevenBtn.Name = "sevenBtn"
        Me.sevenBtn.Size = New System.Drawing.Size(47, 23)
        Me.sevenBtn.TabIndex = 9
        Me.sevenBtn.Text = "7"
        Me.sevenBtn.UseVisualStyleBackColor = True
        '
        'eightBtn
        '
        Me.eightBtn.Location = New System.Drawing.Point(416, 178)
        Me.eightBtn.Name = "eightBtn"
        Me.eightBtn.Size = New System.Drawing.Size(47, 23)
        Me.eightBtn.TabIndex = 10
        Me.eightBtn.Text = "8"
        Me.eightBtn.UseVisualStyleBackColor = True
        '
        'nineBtn
        '
        Me.nineBtn.Location = New System.Drawing.Point(221, 220)
        Me.nineBtn.Name = "nineBtn"
        Me.nineBtn.Size = New System.Drawing.Size(47, 23)
        Me.nineBtn.TabIndex = 11
        Me.nineBtn.Text = "9"
        Me.nineBtn.UseVisualStyleBackColor = True
        '
        'zeroBtn
        '
        Me.zeroBtn.Location = New System.Drawing.Point(289, 220)
        Me.zeroBtn.Name = "zeroBtn"
        Me.zeroBtn.Size = New System.Drawing.Size(47, 23)
        Me.zeroBtn.TabIndex = 12
        Me.zeroBtn.Text = "0"
        Me.zeroBtn.UseVisualStyleBackColor = True
        '
        'pointBtn
        '
        Me.pointBtn.Location = New System.Drawing.Point(355, 220)
        Me.pointBtn.Name = "pointBtn"
        Me.pointBtn.Size = New System.Drawing.Size(47, 23)
        Me.pointBtn.TabIndex = 13
        Me.pointBtn.Text = "."
        Me.pointBtn.UseVisualStyleBackColor = True
        '
        'equalBtn
        '
        Me.equalBtn.Location = New System.Drawing.Point(416, 220)
        Me.equalBtn.Name = "equalBtn"
        Me.equalBtn.Size = New System.Drawing.Size(47, 23)
        Me.equalBtn.TabIndex = 14
        Me.equalBtn.Text = "="
        Me.equalBtn.UseVisualStyleBackColor = True
        '
        'plusBtn
        '
        Me.plusBtn.Location = New System.Drawing.Point(223, 259)
        Me.plusBtn.Name = "plusBtn"
        Me.plusBtn.Size = New System.Drawing.Size(47, 23)
        Me.plusBtn.TabIndex = 15
        Me.plusBtn.Text = "+"
        Me.plusBtn.UseVisualStyleBackColor = True
        '
        'minusBtn
        '
        Me.minusBtn.Location = New System.Drawing.Point(289, 259)
        Me.minusBtn.Name = "minusBtn"
        Me.minusBtn.Size = New System.Drawing.Size(47, 23)
        Me.minusBtn.TabIndex = 16
        Me.minusBtn.Text = "-"
        Me.minusBtn.UseVisualStyleBackColor = True
        '
        'multBtn
        '
        Me.multBtn.Location = New System.Drawing.Point(355, 259)
        Me.multBtn.Name = "multBtn"
        Me.multBtn.Size = New System.Drawing.Size(47, 23)
        Me.multBtn.TabIndex = 17
        Me.multBtn.Text = "x"
        Me.multBtn.UseVisualStyleBackColor = True
        '
        'divBtn
        '
        Me.divBtn.Location = New System.Drawing.Point(415, 259)
        Me.divBtn.Name = "divBtn"
        Me.divBtn.Size = New System.Drawing.Size(47, 23)
        Me.divBtn.TabIndex = 18
        Me.divBtn.Text = "/"
        Me.divBtn.UseVisualStyleBackColor = True
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.divBtn)
        Me.Controls.Add(Me.multBtn)
        Me.Controls.Add(Me.minusBtn)
        Me.Controls.Add(Me.plusBtn)
        Me.Controls.Add(Me.equalBtn)
        Me.Controls.Add(Me.pointBtn)
        Me.Controls.Add(Me.zeroBtn)
        Me.Controls.Add(Me.nineBtn)
        Me.Controls.Add(Me.eightBtn)
        Me.Controls.Add(Me.sevenBtn)
        Me.Controls.Add(Me.sixBtn)
        Me.Controls.Add(Me.fiveBtn)
        Me.Controls.Add(Me.fourBtn)
        Me.Controls.Add(Me.thresBtn)
        Me.Controls.Add(Me.twoBtn)
        Me.Controls.Add(Me.oneBtn)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.screen)
        Me.Controls.Add(Me.appName)
        Me.Name = "calculator"
        Me.Text = "calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents appName As Label
    Friend WithEvents screen As TextBox
    Friend WithEvents resetBtn As Button
    Friend WithEvents oneBtn As Button
    Friend WithEvents twoBtn As Button
    Friend WithEvents thresBtn As Button
    Friend WithEvents fourBtn As Button
    Friend WithEvents fiveBtn As Button
    Friend WithEvents sixBtn As Button
    Friend WithEvents sevenBtn As Button
    Friend WithEvents eightBtn As Button
    Friend WithEvents nineBtn As Button
    Friend WithEvents zeroBtn As Button
    Friend WithEvents pointBtn As Button
    Friend WithEvents equalBtn As Button
    Friend WithEvents plusBtn As Button
    Friend WithEvents minusBtn As Button
    Friend WithEvents multBtn As Button
    Friend WithEvents divBtn As Button
End Class
