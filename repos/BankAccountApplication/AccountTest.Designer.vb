<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AccountTest
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
        Me.depositButton = New System.Windows.Forms.Button()
        Me.withdrawButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputTextBox = New System.Windows.Forms.TextBox()
        Me.accountBalanceValueLabel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter deposit or withdrawal amount:"
        '
        'depositButton
        '
        Me.depositButton.Location = New System.Drawing.Point(57, 52)
        Me.depositButton.Name = "depositButton"
        Me.depositButton.Size = New System.Drawing.Size(75, 23)
        Me.depositButton.TabIndex = 2
        Me.depositButton.Text = "Deposit"
        Me.depositButton.UseVisualStyleBackColor = True
        '
        'withdrawButton
        '
        Me.withdrawButton.Location = New System.Drawing.Point(153, 52)
        Me.withdrawButton.Name = "withdrawButton"
        Me.withdrawButton.Size = New System.Drawing.Size(75, 23)
        Me.withdrawButton.TabIndex = 2
        Me.withdrawButton.Text = "Withdraw"
        Me.withdrawButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(132, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Balance:"
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(250, 20)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(120, 23)
        Me.inputTextBox.TabIndex = 3
        '
        'accountBalanceValueLabel
        '
        Me.accountBalanceValueLabel.Location = New System.Drawing.Point(250, 87)
        Me.accountBalanceValueLabel.Name = "accountBalanceValueLabel"
        Me.accountBalanceValueLabel.Size = New System.Drawing.Size(120, 23)
        Me.accountBalanceValueLabel.TabIndex = 3
        '
        'AccountTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 128)
        Me.Controls.Add(Me.accountBalanceValueLabel)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.withdrawButton)
        Me.Controls.Add(Me.depositButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AccountTest"
        Me.Text = "Testing Class Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents depositButton As Button
    Friend WithEvents withdrawButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents inputTextBox As TextBox
    Friend WithEvents accountBalanceValueLabel As TextBox
End Class
