<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class users
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.label6 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.tbADUPassword2 = New System.Windows.Forms.TextBox()
        Me.tbANUPassword = New System.Windows.Forms.TextBox()
        Me.tbANUserName = New System.Windows.Forms.TextBox()
        Me.tbANULN = New System.Windows.Forms.TextBox()
        Me.tbANUFN = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.gvedit = New System.Windows.Forms.GroupBox()
        Me.gvupdate = New System.Windows.Forms.GroupBox()
        Me.tbEUPassword = New System.Windows.Forms.TextBox()
        Me.tbEULN = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.tbEUFN = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.cbEUUsername = New System.Windows.Forms.ComboBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.tabPage3 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.tbDUPassword = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbDULastName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbDUFirstName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cbDUUsername = New System.Windows.Forms.ComboBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.tabPage4 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        Me.gvedit.SuspendLayout()
        Me.gvupdate.SuspendLayout()
        Me.tabPage3.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.tabPage4.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(648, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Users"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 54)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 632)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.Panel3.Controls.Add(Me.tabControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 632)
        Me.Panel3.TabIndex = 0
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl1.ItemSize = New System.Drawing.Size(90, 30)
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(1370, 632)
        Me.tabControl1.TabIndex = 7
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
        Me.tabPage1.Text = "ADD USER"
        Me.tabPage1.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(583, 19)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(197, 26)
        Me.label6.TabIndex = 7
        Me.label6.Text = "ADD NEW USER"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.btnadduser)
        Me.groupBox2.Controls.Add(Me.Label18)
        Me.groupBox2.Controls.Add(Me.label5)
        Me.groupBox2.Controls.Add(Me.label4)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Controls.Add(Me.tbADUPassword2)
        Me.groupBox2.Controls.Add(Me.tbANUPassword)
        Me.groupBox2.Controls.Add(Me.tbANUserName)
        Me.groupBox2.Controls.Add(Me.tbANULN)
        Me.groupBox2.Controls.Add(Me.tbANUFN)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox2.Location = New System.Drawing.Point(258, 63)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(846, 468)
        Me.groupBox2.TabIndex = 0
        Me.groupBox2.TabStop = False
        '
        'btnadduser
        '
        Me.btnadduser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadduser.Location = New System.Drawing.Point(404, 388)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(117, 33)
        Me.btnadduser.TabIndex = 9
        Me.btnadduser.Text = "ADD USER"
        Me.btnadduser.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(111, 331)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(221, 26)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Confirm Password :"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(202, 262)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(130, 26)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Password :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(193, 191)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(139, 26)
        Me.label4.TabIndex = 7
        Me.label4.Text = "UserName :"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(191, 120)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(141, 26)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Last Name :"
        '
        'tbADUPassword2
        '
        Me.tbADUPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbADUPassword2.Location = New System.Drawing.Point(489, 330)
        Me.tbADUPassword2.Name = "tbADUPassword2"
        Me.tbADUPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbADUPassword2.Size = New System.Drawing.Size(247, 29)
        Me.tbADUPassword2.TabIndex = 5
        '
        'tbANUPassword
        '
        Me.tbANUPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbANUPassword.Location = New System.Drawing.Point(489, 261)
        Me.tbANUPassword.Name = "tbANUPassword"
        Me.tbANUPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbANUPassword.Size = New System.Drawing.Size(247, 29)
        Me.tbANUPassword.TabIndex = 5
        '
        'tbANUserName
        '
        Me.tbANUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbANUserName.Location = New System.Drawing.Point(489, 190)
        Me.tbANUserName.Name = "tbANUserName"
        Me.tbANUserName.Size = New System.Drawing.Size(247, 29)
        Me.tbANUserName.TabIndex = 4
        '
        'tbANULN
        '
        Me.tbANULN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbANULN.Location = New System.Drawing.Point(489, 119)
        Me.tbANULN.Name = "tbANULN"
        Me.tbANULN.Size = New System.Drawing.Size(247, 29)
        Me.tbANULN.TabIndex = 3
        '
        'tbANUFN
        '
        Me.tbANUFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbANUFN.Location = New System.Drawing.Point(489, 48)
        Me.tbANUFN.Name = "tbANUFN"
        Me.tbANUFN.Size = New System.Drawing.Size(247, 29)
        Me.tbANUFN.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(189, 49)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(143, 26)
        Me.label2.TabIndex = 0
        Me.label2.Text = "First Name :"
        '
        'tabPage2
        '
        Me.tabPage2.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.tabPage2.Controls.Add(Me.Label16)
        Me.tabPage2.Controls.Add(Me.label7)
        Me.tabPage2.Controls.Add(Me.gvedit)
        Me.tabPage2.Location = New System.Drawing.Point(4, 34)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(1362, 594)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "UPDATE USER"
        Me.tabPage2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(560, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(243, 26)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "EDIT USER DETAILS"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.Maroon
        Me.label7.Location = New System.Drawing.Point(270, 44)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(0, 26)
        Me.label7.TabIndex = 9
        '
        'gvedit
        '
        Me.gvedit.Controls.Add(Me.gvupdate)
        Me.gvedit.Controls.Add(Me.cbEUUsername)
        Me.gvedit.Controls.Add(Me.label9)
        Me.gvedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvedit.Location = New System.Drawing.Point(258, 63)
        Me.gvedit.Name = "gvedit"
        Me.gvedit.Size = New System.Drawing.Size(846, 468)
        Me.gvedit.TabIndex = 8
        Me.gvedit.TabStop = False
        '
        'gvupdate
        '
        Me.gvupdate.Controls.Add(Me.tbEUPassword)
        Me.gvupdate.Controls.Add(Me.tbEULN)
        Me.gvupdate.Controls.Add(Me.label11)
        Me.gvupdate.Controls.Add(Me.btnEdit)
        Me.gvupdate.Controls.Add(Me.tbEUFN)
        Me.gvupdate.Controls.Add(Me.Label19)
        Me.gvupdate.Controls.Add(Me.label10)
        Me.gvupdate.ForeColor = System.Drawing.SystemColors.Control
        Me.gvupdate.Location = New System.Drawing.Point(120, 134)
        Me.gvupdate.Name = "gvupdate"
        Me.gvupdate.Size = New System.Drawing.Size(606, 303)
        Me.gvupdate.TabIndex = 11
        Me.gvupdate.TabStop = False
        '
        'tbEUPassword
        '
        Me.tbEUPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEUPassword.Location = New System.Drawing.Point(279, 178)
        Me.tbEUPassword.Name = "tbEUPassword"
        Me.tbEUPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbEUPassword.Size = New System.Drawing.Size(247, 30)
        Me.tbEUPassword.TabIndex = 3
        '
        'tbEULN
        '
        Me.tbEULN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEULN.Location = New System.Drawing.Point(279, 106)
        Me.tbEULN.Name = "tbEULN"
        Me.tbEULN.Size = New System.Drawing.Size(247, 30)
        Me.tbEULN.TabIndex = 3
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label11.Location = New System.Drawing.Point(80, 36)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(143, 26)
        Me.label11.TabIndex = 0
        Me.label11.Text = "First Name :"
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.Location = New System.Drawing.Point(218, 235)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(141, 33)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "UPDATE USER"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'tbEUFN
        '
        Me.tbEUFN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEUFN.Location = New System.Drawing.Point(279, 34)
        Me.tbEUFN.Name = "tbEUFN"
        Me.tbEUFN.Size = New System.Drawing.Size(247, 30)
        Me.tbEUFN.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label19.Location = New System.Drawing.Point(82, 180)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 26)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Password  :"
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label10.Location = New System.Drawing.Point(82, 108)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(141, 26)
        Me.label10.TabIndex = 6
        Me.label10.Text = "Last Name :"
        '
        'cbEUUsername
        '
        Me.cbEUUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEUUsername.FormattingEnabled = True
        Me.cbEUUsername.Location = New System.Drawing.Point(395, 66)
        Me.cbEUUsername.Name = "cbEUUsername"
        Me.cbEUUsername.Size = New System.Drawing.Size(247, 33)
        Me.cbEUUsername.TabIndex = 10
        Me.cbEUUsername.Text = "  "
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(205, 69)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(139, 26)
        Me.label9.TabIndex = 7
        Me.label9.Text = "UserName :"
        '
        'tabPage3
        '
        Me.tabPage3.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.tabPage3.Controls.Add(Me.Label17)
        Me.tabPage3.Controls.Add(Me.label8)
        Me.tabPage3.Controls.Add(Me.groupBox3)
        Me.tabPage3.Location = New System.Drawing.Point(4, 34)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage3.Size = New System.Drawing.Size(1362, 594)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "DELETE USER"
        Me.tabPage3.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(532, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(298, 26)
        Me.Label17.TabIndex = 12
        Me.Label17.Text = "DELETE USER ACCOUNT"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.Maroon
        Me.label8.Location = New System.Drawing.Point(222, 54)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(0, 26)
        Me.label8.TabIndex = 11
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.tbDUPassword)
        Me.groupBox3.Controls.Add(Me.Label20)
        Me.groupBox3.Controls.Add(Me.tbDULastName)
        Me.groupBox3.Controls.Add(Me.Label13)
        Me.groupBox3.Controls.Add(Me.tbDUFirstName)
        Me.groupBox3.Controls.Add(Me.Label15)
        Me.groupBox3.Controls.Add(Me.btnDelete)
        Me.groupBox3.Controls.Add(Me.cbDUUsername)
        Me.groupBox3.Controls.Add(Me.label14)
        Me.groupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.groupBox3.Location = New System.Drawing.Point(258, 77)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(846, 468)
        Me.groupBox3.TabIndex = 10
        Me.groupBox3.TabStop = False
        '
        'tbDUPassword
        '
        Me.tbDUPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDUPassword.Location = New System.Drawing.Point(430, 294)
        Me.tbDUPassword.Name = "tbDUPassword"
        Me.tbDUPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbDUPassword.Size = New System.Drawing.Size(247, 30)
        Me.tbDUPassword.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(176, 296)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 26)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Password  :"
        '
        'tbDULastName
        '
        Me.tbDULastName.Enabled = False
        Me.tbDULastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDULastName.Location = New System.Drawing.Point(430, 218)
        Me.tbDULastName.Name = "tbDULastName"
        Me.tbDULastName.Size = New System.Drawing.Size(247, 30)
        Me.tbDULastName.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(170, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 26)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "First Name :"
        '
        'tbDUFirstName
        '
        Me.tbDUFirstName.Enabled = False
        Me.tbDUFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDUFirstName.Location = New System.Drawing.Point(430, 142)
        Me.tbDUFirstName.Name = "tbDUFirstName"
        Me.tbDUFirstName.Size = New System.Drawing.Size(247, 30)
        Me.tbDUFirstName.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(172, 220)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 26)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Last Name :"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(353, 380)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 33)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "DELETE USER"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'cbDUUsername
        '
        Me.cbDUUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDUUsername.FormattingEnabled = True
        Me.cbDUUsername.Location = New System.Drawing.Point(429, 65)
        Me.cbDUUsername.Name = "cbDUUsername"
        Me.cbDUUsername.Size = New System.Drawing.Size(247, 33)
        Me.cbDUUsername.TabIndex = 10
        Me.cbDUUsername.Text = "  "
        '
        'label14
        '
        Me.label14.AutoSize = True
        Me.label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label14.Location = New System.Drawing.Point(174, 68)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(139, 26)
        Me.label14.TabIndex = 7
        Me.label14.Text = "UserName :"
        '
        'tabPage4
        '
        Me.tabPage4.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.tabPage4.Controls.Add(Me.Label12)
        Me.tabPage4.Controls.Add(Me.groupBox4)
        Me.tabPage4.Location = New System.Drawing.Point(4, 34)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage4.Size = New System.Drawing.Size(1362, 594)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "VIEW USER"
        Me.tabPage4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(547, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(268, 26)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "VIEW USER ACCOUNT"
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.DataGridView1)
        Me.groupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox4.Location = New System.Drawing.Point(258, 63)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(846, 468)
        Me.groupBox4.TabIndex = 12
        Me.groupBox4.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(789, 397)
        Me.DataGridView1.TabIndex = 0
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 686)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "users"
        Me.Text = "users"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.tabPage2.ResumeLayout(False)
        Me.tabPage2.PerformLayout()
        Me.gvedit.ResumeLayout(False)
        Me.gvedit.PerformLayout()
        Me.gvupdate.ResumeLayout(False)
        Me.gvupdate.PerformLayout()
        Me.tabPage3.ResumeLayout(False)
        Me.tabPage3.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.tabPage4.ResumeLayout(False)
        Me.tabPage4.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents btnadduser As System.Windows.Forms.Button
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents tbANUPassword As System.Windows.Forms.TextBox
    Private WithEvents tbANULN As System.Windows.Forms.TextBox
    Private WithEvents tbANUFN As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents gvedit As System.Windows.Forms.GroupBox
    Private WithEvents gvupdate As System.Windows.Forms.GroupBox
    Private WithEvents tbEULN As System.Windows.Forms.TextBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Private WithEvents tbEUFN As System.Windows.Forms.TextBox
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents cbEUUsername As System.Windows.Forms.ComboBox
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents tbDULastName As System.Windows.Forms.TextBox
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents tbDUFirstName As System.Windows.Forms.TextBox
    Private WithEvents Label15 As System.Windows.Forms.Label
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents cbDUUsername As System.Windows.Forms.ComboBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents groupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Public WithEvents tabPage1 As TabPage
    Public WithEvents tabPage2 As TabPage
    Public WithEvents tabPage3 As TabPage
    Public WithEvents tabPage4 As TabPage
    Private WithEvents tbANUserName As TextBox
    Private WithEvents Label18 As Label
    Private WithEvents tbADUPassword2 As TextBox
    Private WithEvents tbEUPassword As TextBox
    Private WithEvents Label19 As Label
    Private WithEvents tbDUPassword As TextBox
    Private WithEvents Label20 As Label
End Class
