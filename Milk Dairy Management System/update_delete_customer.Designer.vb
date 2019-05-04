<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_delete_customer
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbBankName = New System.Windows.Forms.ComboBox()
        Me.tbIFSCCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnClere = New System.Windows.Forms.Button()
        Me.cbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cbCattle = New System.Windows.Forms.ComboBox()
        Me.tbAccountNo = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tbSurname = New System.Windows.Forms.TextBox()
        Me.tbCustId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbContactNo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 54)
        Me.Panel1.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(583, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(205, 26)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Update  Customer"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 632)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Panel3.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.Panel3.Controls.Add(Me.cbBankName)
        Me.Panel3.Controls.Add(Me.tbIFSCCode)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.btnClere)
        Me.Panel3.Controls.Add(Me.cbPaymentMode)
        Me.Panel3.Controls.Add(Me.btnUpdate)
        Me.Panel3.Controls.Add(Me.cbCattle)
        Me.Panel3.Controls.Add(Me.tbAccountNo)
        Me.Panel3.Controls.Add(Me.btnSearch)
        Me.Panel3.Controls.Add(Me.tbSurname)
        Me.Panel3.Controls.Add(Me.tbCustId)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.tbAddress)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.tbContactNo)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.tbFirstName)
        Me.Panel3.Controls.Add(Me.label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 632)
        Me.Panel3.TabIndex = 0
        '
        'cbBankName
        '
        Me.cbBankName.Enabled = False
        Me.cbBankName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBankName.FormattingEnabled = True
        Me.cbBankName.Items.AddRange(New Object() {"State Bank of India", "Bank of India", "HDFC Bank", "Axis Bank", "Bank of Maharashtra", "ICICI Bank", "IDBI Bank"})
        Me.cbBankName.Location = New System.Drawing.Point(968, 213)
        Me.cbBankName.Name = "cbBankName"
        Me.cbBankName.Size = New System.Drawing.Size(247, 32)
        Me.cbBankName.TabIndex = 74
        '
        'tbIFSCCode
        '
        Me.tbIFSCCode.Enabled = False
        Me.tbIFSCCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIFSCCode.Location = New System.Drawing.Point(968, 389)
        Me.tbIFSCCode.Name = "tbIFSCCode"
        Me.tbIFSCCode.Size = New System.Drawing.Size(247, 29)
        Me.tbIFSCCode.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(759, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 26)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "IFSC Code :"
        '
        'btnClere
        '
        Me.btnClere.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClere.Location = New System.Drawing.Point(805, 534)
        Me.btnClere.Name = "btnClere"
        Me.btnClere.Size = New System.Drawing.Size(108, 49)
        Me.btnClere.TabIndex = 66
        Me.btnClere.Text = "Clear"
        Me.btnClere.UseVisualStyleBackColor = True
        '
        'cbPaymentMode
        '
        Me.cbPaymentMode.Enabled = False
        Me.cbPaymentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPaymentMode.FormattingEnabled = True
        Me.cbPaymentMode.Items.AddRange(New Object() {"Cash", "Bank"})
        Me.cbPaymentMode.Location = New System.Drawing.Point(968, 126)
        Me.cbPaymentMode.Name = "cbPaymentMode"
        Me.cbPaymentMode.Size = New System.Drawing.Size(247, 32)
        Me.cbPaymentMode.TabIndex = 59
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(457, 534)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(108, 49)
        Me.btnUpdate.TabIndex = 64
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'cbCattle
        '
        Me.cbCattle.Enabled = False
        Me.cbCattle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCattle.FormattingEnabled = True
        Me.cbCattle.Location = New System.Drawing.Point(967, 39)
        Me.cbCattle.Name = "cbCattle"
        Me.cbCattle.Size = New System.Drawing.Size(247, 32)
        Me.cbCattle.TabIndex = 58
        '
        'tbAccountNo
        '
        Me.tbAccountNo.Enabled = False
        Me.tbAccountNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountNo.Location = New System.Drawing.Point(968, 302)
        Me.tbAccountNo.MaxLength = 25
        Me.tbAccountNo.Name = "tbAccountNo"
        Me.tbAccountNo.Size = New System.Drawing.Size(247, 29)
        Me.tbAccountNo.TabIndex = 57
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(638, 42)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(71, 26)
        Me.btnSearch.TabIndex = 73
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tbSurname
        '
        Me.tbSurname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSurname.Enabled = False
        Me.tbSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSurname.Location = New System.Drawing.Point(375, 215)
        Me.tbSurname.Name = "tbSurname"
        Me.tbSurname.Size = New System.Drawing.Size(247, 29)
        Me.tbSurname.TabIndex = 69
        '
        'tbCustId
        '
        Me.tbCustId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCustId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustId.Location = New System.Drawing.Point(374, 41)
        Me.tbCustId.Name = "tbCustId"
        Me.tbCustId.Size = New System.Drawing.Size(247, 29)
        Me.tbCustId.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 26)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Surname :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 26)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Account ID :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(752, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 26)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Bank Name :"
        '
        'tbAddress
        '
        Me.tbAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAddress.Enabled = False
        Me.tbAddress.Location = New System.Drawing.Point(375, 390)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(247, 98)
        Me.tbAddress.TabIndex = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(732, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 26)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Payment Mod :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 26)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(810, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 26)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Cattle :"
        '
        'tbContactNo
        '
        Me.tbContactNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContactNo.Enabled = False
        Me.tbContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbContactNo.Location = New System.Drawing.Point(375, 302)
        Me.tbContactNo.MaxLength = 10
        Me.tbContactNo.Name = "tbContactNo"
        Me.tbContactNo.Size = New System.Drawing.Size(247, 29)
        Me.tbContactNo.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(748, 303)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 26)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Account No. :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(155, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 26)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Contact No. :"
        '
        'tbFirstName
        '
        Me.tbFirstName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFirstName.Enabled = False
        Me.tbFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFirstName.Location = New System.Drawing.Point(375, 128)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(247, 29)
        Me.tbFirstName.TabIndex = 68
        '
        'label2
        '
        Me.label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(163, 129)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(131, 26)
        Me.label2.TabIndex = 67
        Me.label2.Text = "First Name :"
        '
        'update_delete_customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 686)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "update_delete_customer"
        Me.Text = "Update or Delete Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbPaymentMode As System.Windows.Forms.ComboBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents cbCattle As System.Windows.Forms.ComboBox
    Friend WithEvents tbAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tbSurname As System.Windows.Forms.TextBox
    Friend WithEvents tbCustId As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbAddress As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbContactNo As System.Windows.Forms.TextBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbFirstName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents btnClere As System.Windows.Forms.Button
    Friend WithEvents tbIFSCCode As TextBox
    Private WithEvents Label12 As Label
    Friend WithEvents cbBankName As ComboBox
End Class
