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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.secondNumber = New System.Windows.Forms.TextBox()
        Me.firstNumber = New System.Windows.Forms.TextBox()
        Me.resltBtn = New System.Windows.Forms.Button()
        Me.addChk = New System.Windows.Forms.CheckBox()
        Me.subChk = New System.Windows.Forms.CheckBox()
        Me.mulChk = New System.Windows.Forms.CheckBox()
        Me.divChk = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Second Number"
        '
        'secondNumber
        '
        Me.secondNumber.Location = New System.Drawing.Point(169, 66)
        Me.secondNumber.Name = "secondNumber"
        Me.secondNumber.Size = New System.Drawing.Size(149, 23)
        Me.secondNumber.TabIndex = 1
        Me.secondNumber.Text = "Enter 1st Number"
        '
        'firstNumber
        '
        Me.firstNumber.Location = New System.Drawing.Point(169, 33)
        Me.firstNumber.Name = "firstNumber"
        Me.firstNumber.Size = New System.Drawing.Size(149, 23)
        Me.firstNumber.TabIndex = 1
        Me.firstNumber.Text = "Enter 1st Number"
        '
        'resltBtn
        '
        Me.resltBtn.Location = New System.Drawing.Point(156, 140)
        Me.resltBtn.Name = "resltBtn"
        Me.resltBtn.Size = New System.Drawing.Size(75, 23)
        Me.resltBtn.TabIndex = 2
        Me.resltBtn.Text = "Result"
        Me.resltBtn.UseVisualStyleBackColor = True
        '
        'addChk
        '
        Me.addChk.AutoSize = True
        Me.addChk.Location = New System.Drawing.Point(72, 102)
        Me.addChk.Name = "addChk"
        Me.addChk.Size = New System.Drawing.Size(48, 19)
        Me.addChk.TabIndex = 3
        Me.addChk.Text = "Add"
        Me.addChk.UseVisualStyleBackColor = True
        '
        'subChk
        '
        Me.subChk.AutoSize = True
        Me.subChk.Location = New System.Drawing.Point(121, 102)
        Me.subChk.Name = "subChk"
        Me.subChk.Size = New System.Drawing.Size(70, 19)
        Me.subChk.TabIndex = 3
        Me.subChk.Text = "Subtract"
        Me.subChk.UseVisualStyleBackColor = True
        '
        'mulChk
        '
        Me.mulChk.AutoSize = True
        Me.mulChk.Location = New System.Drawing.Point(191, 102)
        Me.mulChk.Name = "mulChk"
        Me.mulChk.Size = New System.Drawing.Size(70, 19)
        Me.mulChk.TabIndex = 3
        Me.mulChk.Text = "Multiply"
        Me.mulChk.UseVisualStyleBackColor = True
        '
        'divChk
        '
        Me.divChk.AutoSize = True
        Me.divChk.Location = New System.Drawing.Point(259, 102)
        Me.divChk.Name = "divChk"
        Me.divChk.Size = New System.Drawing.Size(59, 19)
        Me.divChk.TabIndex = 3
        Me.divChk.Text = "Divide"
        Me.divChk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 202)
        Me.Controls.Add(Me.divChk)
        Me.Controls.Add(Me.mulChk)
        Me.Controls.Add(Me.subChk)
        Me.Controls.Add(Me.addChk)
        Me.Controls.Add(Me.resltBtn)
        Me.Controls.Add(Me.firstNumber)
        Me.Controls.Add(Me.secondNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Simple Desktop Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents secondNumber As TextBox
    Friend WithEvents firstNumber As TextBox
    Friend WithEvents resltBtn As Button
    Friend WithEvents addChk As CheckBox
    Friend WithEvents subChk As CheckBox
    Friend WithEvents mulChk As CheckBox
    Friend WithEvents divChk As CheckBox
End Class
