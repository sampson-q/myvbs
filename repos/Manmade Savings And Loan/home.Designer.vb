<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.accountPassword = New System.Windows.Forms.TextBox()
        Me.accountNumber = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'accountPassword
        '
        Me.accountPassword.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.accountPassword.Location = New System.Drawing.Point(253, 146)
        Me.accountPassword.MaximumSize = New System.Drawing.Size(30, 40)
        Me.accountPassword.MinimumSize = New System.Drawing.Size(130, 23)
        Me.accountPassword.Name = "accountPassword"
        Me.accountPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.accountPassword.PlaceholderText = "Password"
        Me.accountPassword.Size = New System.Drawing.Size(130, 23)
        Me.accountPassword.TabIndex = 0
        '
        'accountNumber
        '
        Me.accountNumber.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.accountNumber.Location = New System.Drawing.Point(253, 117)
        Me.accountNumber.MaximumSize = New System.Drawing.Size(30, 40)
        Me.accountNumber.MinimumSize = New System.Drawing.Size(130, 23)
        Me.accountNumber.Name = "accountNumber"
        Me.accountNumber.PlaceholderText = "Account Number"
        Me.accountNumber.Size = New System.Drawing.Size(130, 23)
        Me.accountNumber.TabIndex = 0
        '
        'loginBtn
        '
        Me.loginBtn.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.loginBtn.Location = New System.Drawing.Point(278, 176)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 26)
        Me.loginBtn.TabIndex = 1
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 337)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.accountNumber)
        Me.Controls.Add(Me.accountPassword)
        Me.DoubleBuffered = True
        Me.Name = "home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manmade Savings and Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents accountPassword As TextBox
    Friend WithEvents accountNumber As TextBox
    Friend WithEvents loginBtn As Button
End Class
