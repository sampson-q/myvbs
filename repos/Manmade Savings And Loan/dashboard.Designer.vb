<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.accountBalanceTxt = New System.Windows.Forms.TextBox()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.dashboardTabs = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.withdrawBtn = New System.Windows.Forms.Button()
        Me.withdrawalAmount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.withdrawalLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.depositBtn = New System.Windows.Forms.Button()
        Me.depositAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.depositLabel = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.applyLoan = New System.Windows.Forms.Button()
        Me.loanAmount = New System.Windows.Forms.TextBox()
        Me.loanPeriod = New System.Windows.Forms.TextBox()
        Me.interest = New System.Windows.Forms.TextBox()
        Me.currentLoan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.logoutBtn = New System.Windows.Forms.Button()
        Me.dashboardTabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(364, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Account Balance:"
        '
        'accountBalanceTxt
        '
        Me.accountBalanceTxt.Location = New System.Drawing.Point(527, 9)
        Me.accountBalanceTxt.MinimumSize = New System.Drawing.Size(4, 20)
        Me.accountBalanceTxt.Name = "accountBalanceTxt"
        Me.accountBalanceTxt.ReadOnly = True
        Me.accountBalanceTxt.Size = New System.Drawing.Size(96, 23)
        Me.accountBalanceTxt.TabIndex = 2
        Me.accountBalanceTxt.TabStop = False
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.usernameLabel.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.usernameLabel.ForeColor = System.Drawing.Color.White
        Me.usernameLabel.Location = New System.Drawing.Point(2, 6)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(86, 19)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "Username"
        '
        'dashboardTabs
        '
        Me.dashboardTabs.Controls.Add(Me.TabPage1)
        Me.dashboardTabs.Controls.Add(Me.TabPage2)
        Me.dashboardTabs.Controls.Add(Me.TabPage3)
        Me.dashboardTabs.Font = New System.Drawing.Font("Gadugi", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dashboardTabs.ItemSize = New System.Drawing.Size(83, 22)
        Me.dashboardTabs.Location = New System.Drawing.Point(12, 36)
        Me.dashboardTabs.Multiline = True
        Me.dashboardTabs.Name = "dashboardTabs"
        Me.dashboardTabs.SelectedIndex = 0
        Me.dashboardTabs.Size = New System.Drawing.Size(611, 262)
        Me.dashboardTabs.TabIndex = 0
        Me.dashboardTabs.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.withdrawBtn)
        Me.TabPage1.Controls.Add(Me.withdrawalAmount)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.withdrawalLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(603, 232)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Withdrawal"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'withdrawBtn
        '
        Me.withdrawBtn.Location = New System.Drawing.Point(255, 115)
        Me.withdrawBtn.Name = "withdrawBtn"
        Me.withdrawBtn.Size = New System.Drawing.Size(104, 29)
        Me.withdrawBtn.TabIndex = 3
        Me.withdrawBtn.Text = "Withdraw"
        Me.withdrawBtn.UseVisualStyleBackColor = True
        '
        'withdrawalAmount
        '
        Me.withdrawalAmount.Location = New System.Drawing.Point(194, 82)
        Me.withdrawalAmount.Name = "withdrawalAmount"
        Me.withdrawalAmount.Size = New System.Drawing.Size(242, 25)
        Me.withdrawalAmount.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(186, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Withdrawal Amount:"
        '
        'withdrawalLabel
        '
        Me.withdrawalLabel.AutoSize = True
        Me.withdrawalLabel.Location = New System.Drawing.Point(332, 3)
        Me.withdrawalLabel.Name = "withdrawalLabel"
        Me.withdrawalLabel.Size = New System.Drawing.Size(0, 18)
        Me.withdrawalLabel.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.depositBtn)
        Me.TabPage2.Controls.Add(Me.depositAmount)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.depositLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(603, 232)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Deposit"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'depositBtn
        '
        Me.depositBtn.Location = New System.Drawing.Point(255, 115)
        Me.depositBtn.Name = "depositBtn"
        Me.depositBtn.Size = New System.Drawing.Size(104, 29)
        Me.depositBtn.TabIndex = 6
        Me.depositBtn.Text = "Deposit"
        Me.depositBtn.UseVisualStyleBackColor = True
        '
        'depositAmount
        '
        Me.depositAmount.Location = New System.Drawing.Point(194, 82)
        Me.depositAmount.Name = "depositAmount"
        Me.depositAmount.Size = New System.Drawing.Size(242, 25)
        Me.depositAmount.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(204, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter Deposit Amount:"
        '
        'depositLabel
        '
        Me.depositLabel.AutoSize = True
        Me.depositLabel.Location = New System.Drawing.Point(376, 3)
        Me.depositLabel.Name = "depositLabel"
        Me.depositLabel.Size = New System.Drawing.Size(0, 18)
        Me.depositLabel.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.applyLoan)
        Me.TabPage3.Controls.Add(Me.loanAmount)
        Me.TabPage3.Controls.Add(Me.loanPeriod)
        Me.TabPage3.Controls.Add(Me.interest)
        Me.TabPage3.Controls.Add(Me.currentLoan)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 26)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(603, 232)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "My Loans"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'applyLoan
        '
        Me.applyLoan.Enabled = False
        Me.applyLoan.Location = New System.Drawing.Point(270, 142)
        Me.applyLoan.Name = "applyLoan"
        Me.applyLoan.Size = New System.Drawing.Size(75, 30)
        Me.applyLoan.TabIndex = 4
        Me.applyLoan.Text = "Apply"
        Me.applyLoan.UseVisualStyleBackColor = True
        '
        'loanAmount
        '
        Me.loanAmount.Location = New System.Drawing.Point(227, 77)
        Me.loanAmount.Name = "loanAmount"
        Me.loanAmount.PlaceholderText = "Amount ($)"
        Me.loanAmount.Size = New System.Drawing.Size(167, 25)
        Me.loanAmount.TabIndex = 3
        '
        'loanPeriod
        '
        Me.loanPeriod.Location = New System.Drawing.Point(227, 46)
        Me.loanPeriod.Name = "loanPeriod"
        Me.loanPeriod.PlaceholderText = "Time / Period (Years)"
        Me.loanPeriod.Size = New System.Drawing.Size(167, 25)
        Me.loanPeriod.TabIndex = 2
        '
        'interest
        '
        Me.interest.Location = New System.Drawing.Point(227, 110)
        Me.interest.Name = "interest"
        Me.interest.PlaceholderText = "Interest:"
        Me.interest.ReadOnly = True
        Me.interest.Size = New System.Drawing.Size(167, 25)
        Me.interest.TabIndex = 1
        Me.interest.TabStop = False
        '
        'currentLoan
        '
        Me.currentLoan.Location = New System.Drawing.Point(511, 10)
        Me.currentLoan.Name = "currentLoan"
        Me.currentLoan.ReadOnly = True
        Me.currentLoan.Size = New System.Drawing.Size(86, 25)
        Me.currentLoan.TabIndex = 1
        Me.currentLoan.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(415, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Current Loan:"
        '
        'logoutBtn
        '
        Me.logoutBtn.Font = New System.Drawing.Font("Arial Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.logoutBtn.Location = New System.Drawing.Point(556, 305)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(75, 30)
        Me.logoutBtn.TabIndex = 5
        Me.logoutBtn.Text = "Logout"
        Me.logoutBtn.UseVisualStyleBackColor = True
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 337)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.dashboardTabs)
        Me.Controls.Add(Me.accountBalanceTxt)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manmade Savings and Loan"
        Me.dashboardTabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents accountBalanceTxt As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents dashboardTabs As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents withdrawalLabel As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents depositLabel As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents logoutBtn As Button
    Friend WithEvents withdrawBtn As Button
    Friend WithEvents withdrawalAmount As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents depositBtn As Button
    Friend WithEvents depositAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents applyLoan As Button
    Friend WithEvents loanAmount As TextBox
    Friend WithEvents loanPeriod As TextBox
    Friend WithEvents interest As TextBox
    Friend WithEvents currentLoan As TextBox
    Friend WithEvents Label4 As Label
End Class
