<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.label6 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbCattle = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCureentFatPrice = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.btnSetPrice = New System.Windows.Forms.Button()
        Me.tbNewFatPrice = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.label7 = New System.Windows.Forms.Label()
        Me.gvedit = New System.Windows.Forms.GroupBox()
        Me.tbConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.label10 = New System.Windows.Forms.Label()
        Me.tbOldPassword = New System.Windows.Forms.TextBox()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.tbUsername = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.gvedit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 54)
        Me.Panel1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(636, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settings"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.Panel2.Controls.Add(Me.tabControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 632)
        Me.Panel2.TabIndex = 9
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.ItemSize = New System.Drawing.Size(90, 30)
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1370, 632)
        Me.tabControl1.TabIndex = 6
        '
        'tabPage1
        '
        Me.tabPage1.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.tabPage1.Controls.Add(Me.label6)
        Me.tabPage1.Controls.Add(Me.groupBox2)
        Me.tabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabPage1.Location = New System.Drawing.Point(4, 34)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(1362, 594)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "FAT SETTING"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(588, 18)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(187, 26)
        Me.label6.TabIndex = 7
        Me.label6.Text = "SET FAT PRICE"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.cbCattle)
        Me.groupBox2.Controls.Add(Me.Label5)
        Me.groupBox2.Controls.Add(Me.tbCureentFatPrice)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.btnSetPrice)
        Me.groupBox2.Controls.Add(Me.tbNewFatPrice)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(258, 60)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(846, 468)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        '
        'cbCattle
        '
        Me.cbCattle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCattle.FormattingEnabled = True
        Me.cbCattle.Location = New System.Drawing.Point(458, 57)
        Me.cbCattle.Name = "cbCattle"
        Me.cbCattle.Size = New System.Drawing.Size(247, 32)
        Me.cbCattle.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 26)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Cattle :"
        '
        'tbCureentFatPrice
        '
        Me.tbCureentFatPrice.Enabled = False
        Me.tbCureentFatPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCureentFatPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbCureentFatPrice.Location = New System.Drawing.Point(460, 141)
        Me.tbCureentFatPrice.Name = "tbCureentFatPrice"
        Me.tbCureentFatPrice.ReadOnly = True
        Me.tbCureentFatPrice.Size = New System.Drawing.Size(245, 29)
        Me.tbCureentFatPrice.TabIndex = 11
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(141, 142)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(208, 26)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Current Fat Price :"
        '
        'btnSetPrice
        '
        Me.btnSetPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPrice.Location = New System.Drawing.Point(343, 298)
        Me.btnSetPrice.Name = "btnSetPrice"
        Me.btnSetPrice.Size = New System.Drawing.Size(160, 33)
        Me.btnSetPrice.TabIndex = 9
        Me.btnSetPrice.Text = "SET PRICE"
        Me.btnSetPrice.UseVisualStyleBackColor = True
        '
        'tbNewFatPrice
        '
        Me.tbNewFatPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewFatPrice.Location = New System.Drawing.Point(460, 227)
        Me.tbNewFatPrice.Name = "tbNewFatPrice"
        Me.tbNewFatPrice.Size = New System.Drawing.Size(245, 29)
        Me.tbNewFatPrice.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(165, 224)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(176, 26)
        Me.label2.TabIndex = 0
        Me.label2.Text = "New Fat Price :"
        '
        'tabPage2
        '
        Me.tabPage2.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.tabPage2.Controls.Add(Me.label7)
        Me.tabPage2.Controls.Add(Me.gvedit)
        Me.tabPage2.Location = New System.Drawing.Point(4, 34)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(1362, 594)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "PASSWORD"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(491, 15)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(380, 26)
        Me.label7.TabIndex = 9
        Me.label7.Text = "CHANGE ACCOUNT PASSWORD"
        '
        'gvedit
        '
        Me.gvedit.Controls.Add(Me.tbConfirmPassword)
        Me.gvedit.Controls.Add(Me.Label8)
        Me.gvedit.Controls.Add(Me.Label4)
        Me.gvedit.Controls.Add(Me.label11)
        Me.gvedit.Controls.Add(Me.btnEdit)
        Me.gvedit.Controls.Add(Me.label10)
        Me.gvedit.Controls.Add(Me.tbUsername)
        Me.gvedit.Controls.Add(Me.tbOldPassword)
        Me.gvedit.Controls.Add(Me.tbNewPassword)
        Me.gvedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvedit.Location = New System.Drawing.Point(258, 63)
        Me.gvedit.Name = "gvedit"
        Me.gvedit.Size = New System.Drawing.Size(846, 468)
        Me.gvedit.TabIndex = 8
        Me.gvedit.TabStop = False
        '
        'tbConfirmPassword
        '
        Me.tbConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmPassword.Location = New System.Drawing.Point(441, 292)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmPassword.Size = New System.Drawing.Size(245, 29)
        Me.tbConfirmPassword.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(171, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Old Password :"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.Location = New System.Drawing.Point(161, 223)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(184, 26)
        Me.label11.TabIndex = 0
        Me.label11.Text = "New Password :"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(353, 360)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(141, 33)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "CHANGE PASS"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(175, 293)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(170, 26)
        Me.label10.TabIndex = 6
        Me.label10.Text = "Confirm Pass :"
        '
        'tbOldPassword
        '
        Me.tbOldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbOldPassword.Location = New System.Drawing.Point(441, 150)
        Me.tbOldPassword.Name = "tbOldPassword"
        Me.tbOldPassword.Size = New System.Drawing.Size(245, 29)
        Me.tbOldPassword.TabIndex = 4
        '
        'tbNewPassword
        '
        Me.tbNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewPassword.Location = New System.Drawing.Point(441, 222)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNewPassword.Size = New System.Drawing.Size(245, 29)
        Me.tbNewPassword.TabIndex = 4
        '
        'tbUsername
        '
        Me.tbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUsername.Location = New System.Drawing.Point(441, 76)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.Size = New System.Drawing.Size(245, 29)
        Me.tbUsername.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Username :"
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 686)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "settings"
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.gvedit.ResumeLayout(False)
        Me.gvedit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPage1 As System.Windows.Forms.TabPage
    Private WithEvents tabPage2 As System.Windows.Forms.TabPage
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents gvedit As System.Windows.Forms.GroupBox
    Private WithEvents tbConfirmPassword As System.Windows.Forms.TextBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents tbNewPassword As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents tbOldPassword As System.Windows.Forms.TextBox
    Private WithEvents label6 As Label
    Private WithEvents groupBox2 As GroupBox
    Friend WithEvents cbCattle As ComboBox
    Private WithEvents Label5 As Label
    Private WithEvents tbCureentFatPrice As TextBox
    Private WithEvents label3 As Label
    Private WithEvents btnSetPrice As Button
    Private WithEvents tbNewFatPrice As TextBox
    Private WithEvents label2 As Label
    Private WithEvents Label8 As Label
    Private WithEvents tbUsername As TextBox
End Class
