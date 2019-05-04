<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payment
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMakePayment = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCustomerId = New System.Windows.Forms.TextBox()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbLtr = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(632, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Payment"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.Panel3.Controls.Add(Me.lbPrice)
        Me.Panel3.Controls.Add(Me.lbLtr)
        Me.Panel3.Controls.Add(Me.btnMakePayment)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 518)
        Me.Panel3.TabIndex = 10
        '
        'btnMakePayment
        '
        Me.btnMakePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakePayment.Location = New System.Drawing.Point(1140, 395)
        Me.btnMakePayment.Name = "btnMakePayment"
        Me.btnMakePayment.Size = New System.Drawing.Size(177, 38)
        Me.btnMakePayment.TabIndex = 61
        Me.btnMakePayment.Text = "Make Payment"
        Me.btnMakePayment.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1034, 409)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.tbCustomerId)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 69)
        Me.Panel2.TabIndex = 9
        '
        'btnSearch
        '
        Me.btnSearch.Enabled = False
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(863, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(71, 26)
        Me.btnSearch.TabIndex = 53
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(437, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 24)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Customer ID :"
        '
        'tbCustomerId
        '
        Me.tbCustomerId.BackColor = System.Drawing.Color.White
        Me.tbCustomerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustomerId.ForeColor = System.Drawing.Color.Purple
        Me.tbCustomerId.Location = New System.Drawing.Point(586, 23)
        Me.tbCustomerId.Name = "tbCustomerId"
        Me.tbCustomerId.Size = New System.Drawing.Size(206, 30)
        Me.tbCustomerId.TabIndex = 62
        '
        'lbPrice
        '
        Me.lbPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbPrice.AutoSize = True
        Me.lbPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrice.ForeColor = System.Drawing.Color.White
        Me.lbPrice.Location = New System.Drawing.Point(966, 458)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(44, 20)
        Me.lbPrice.TabIndex = 71
        Me.lbPrice.Text = "Price"
        '
        'lbLtr
        '
        Me.lbLtr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLtr.AutoSize = True
        Me.lbLtr.BackColor = System.Drawing.Color.Transparent
        Me.lbLtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLtr.ForeColor = System.Drawing.Color.White
        Me.lbLtr.Location = New System.Drawing.Point(829, 458)
        Me.lbLtr.Name = "lbLtr"
        Me.lbLtr.Size = New System.Drawing.Size(28, 20)
        Me.lbLtr.TabIndex = 72
        Me.lbLtr.Text = "Ltr"
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 641)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "payment"
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnMakePayment As Button
    Private WithEvents Panel2 As Panel
    Private WithEvents Label6 As Label
    Friend WithEvents btnSearch As Button
    Private WithEvents tbCustomerId As TextBox
    Private WithEvents lbPrice As Label
    Private WithEvents lbLtr As Label
End Class
