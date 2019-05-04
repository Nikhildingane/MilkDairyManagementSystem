<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class collect_milk
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTiming = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbAddress = New System.Windows.Forms.Label()
        Me.lbDate = New System.Windows.Forms.Label()
        Me.lbName = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbCattle = New System.Windows.Forms.TextBox()
        Me.tbCustId = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCollect = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbAllPrice = New System.Windows.Forms.Label()
        Me.lbAllLtr = New System.Windows.Forms.Label()
        Me.lbSCTPrice = New System.Windows.Forms.Label()
        Me.lbSCTLtr = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgAllCustomer = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgSingleCustomer = New System.Windows.Forms.DataGridView()
        Me.tbTotalPrice = New System.Windows.Forms.TextBox()
        Me.tbFat = New System.Windows.Forms.TextBox()
        Me.tbPricePLtr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbLtr = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgAllCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSingleCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(571, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(229, 26)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Daily Milk Collection"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.lbTiming)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lbAddress)
        Me.Panel2.Controls.Add(Me.lbDate)
        Me.Panel2.Controls.Add(Me.lbName)
        Me.Panel2.Controls.Add(Me.label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.tbCattle)
        Me.Panel2.Controls.Add(Me.tbCustId)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1370, 105)
        Me.Panel2.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(44, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 26)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Cattle :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1094, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 26)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Date :"
        '
        'lbTiming
        '
        Me.lbTiming.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTiming.AutoSize = True
        Me.lbTiming.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiming.Location = New System.Drawing.Point(1094, 64)
        Me.lbTiming.Name = "lbTiming"
        Me.lbTiming.Size = New System.Drawing.Size(71, 26)
        Me.lbTiming.TabIndex = 55
        Me.lbTiming.Text = "timing"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(383, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 26)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Address :"
        '
        'lbAddress
        '
        Me.lbAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAddress.AutoSize = True
        Me.lbAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAddress.Location = New System.Drawing.Point(514, 63)
        Me.lbAddress.Name = "lbAddress"
        Me.lbAddress.Size = New System.Drawing.Size(71, 24)
        Me.lbAddress.TabIndex = 55
        Me.lbAddress.Text = "Name :"
        '
        'lbDate
        '
        Me.lbDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDate.AutoSize = True
        Me.lbDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDate.Location = New System.Drawing.Point(1176, 18)
        Me.lbDate.Name = "lbDate"
        Me.lbDate.Size = New System.Drawing.Size(71, 24)
        Me.lbDate.TabIndex = 55
        Me.lbDate.Text = "Name :"
        '
        'lbName
        '
        Me.lbName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(514, 18)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(71, 24)
        Me.lbName.TabIndex = 55
        Me.lbName.Text = "Name :"
        '
        'label2
        '
        Me.label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(407, 17)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(89, 26)
        Me.label2.TabIndex = 55
        Me.label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 26)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Customer ID :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(304, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 26)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbCattle
        '
        Me.tbCattle.BackColor = System.Drawing.Color.White
        Me.tbCattle.Enabled = False
        Me.tbCattle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCattle.ForeColor = System.Drawing.Color.Purple
        Me.tbCattle.Location = New System.Drawing.Point(162, 60)
        Me.tbCattle.Name = "tbCattle"
        Me.tbCattle.Size = New System.Drawing.Size(136, 30)
        Me.tbCattle.TabIndex = 11
        '
        'tbCustId
        '
        Me.tbCustId.BackColor = System.Drawing.Color.White
        Me.tbCustId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCustId.ForeColor = System.Drawing.Color.Purple
        Me.tbCustId.Location = New System.Drawing.Point(162, 15)
        Me.tbCustId.Name = "tbCustId"
        Me.tbCustId.Size = New System.Drawing.Size(136, 30)
        Me.tbCustId.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._69c8734ae12303fe9cf295d423f494a0
        Me.Panel3.Controls.Add(Me.btnCollect)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lbAllPrice)
        Me.Panel3.Controls.Add(Me.lbAllLtr)
        Me.Panel3.Controls.Add(Me.lbSCTPrice)
        Me.Panel3.Controls.Add(Me.lbSCTLtr)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.dgAllCustomer)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.dgSingleCustomer)
        Me.Panel3.Controls.Add(Me.tbTotalPrice)
        Me.Panel3.Controls.Add(Me.tbFat)
        Me.Panel3.Controls.Add(Me.tbPricePLtr)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.tbLtr)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 159)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1370, 527)
        Me.Panel3.TabIndex = 9
        '
        'btnCollect
        '
        Me.btnCollect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCollect.Location = New System.Drawing.Point(622, 459)
        Me.btnCollect.Name = "btnCollect"
        Me.btnCollect.Size = New System.Drawing.Size(126, 46)
        Me.btnCollect.TabIndex = 71
        Me.btnCollect.Text = "Collect"
        Me.btnCollect.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(697, 413)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 20)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Total = "
        '
        'lbAllPrice
        '
        Me.lbAllPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAllPrice.AutoSize = True
        Me.lbAllPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbAllPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAllPrice.ForeColor = System.Drawing.Color.White
        Me.lbAllPrice.Location = New System.Drawing.Point(1226, 413)
        Me.lbAllPrice.Name = "lbAllPrice"
        Me.lbAllPrice.Size = New System.Drawing.Size(44, 20)
        Me.lbAllPrice.TabIndex = 70
        Me.lbAllPrice.Text = "Price"
        '
        'lbAllLtr
        '
        Me.lbAllLtr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAllLtr.AutoSize = True
        Me.lbAllLtr.BackColor = System.Drawing.Color.Transparent
        Me.lbAllLtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAllLtr.ForeColor = System.Drawing.Color.White
        Me.lbAllLtr.Location = New System.Drawing.Point(918, 413)
        Me.lbAllLtr.Name = "lbAllLtr"
        Me.lbAllLtr.Size = New System.Drawing.Size(28, 20)
        Me.lbAllLtr.TabIndex = 70
        Me.lbAllLtr.Text = "Ltr"
        '
        'lbSCTPrice
        '
        Me.lbSCTPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSCTPrice.AutoSize = True
        Me.lbSCTPrice.BackColor = System.Drawing.Color.Transparent
        Me.lbSCTPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSCTPrice.ForeColor = System.Drawing.Color.White
        Me.lbSCTPrice.Location = New System.Drawing.Point(581, 413)
        Me.lbSCTPrice.Name = "lbSCTPrice"
        Me.lbSCTPrice.Size = New System.Drawing.Size(44, 20)
        Me.lbSCTPrice.TabIndex = 70
        Me.lbSCTPrice.Text = "Price"
        '
        'lbSCTLtr
        '
        Me.lbSCTLtr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSCTLtr.AutoSize = True
        Me.lbSCTLtr.BackColor = System.Drawing.Color.Transparent
        Me.lbSCTLtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSCTLtr.ForeColor = System.Drawing.Color.White
        Me.lbSCTLtr.Location = New System.Drawing.Point(340, 413)
        Me.lbSCTLtr.Name = "lbSCTLtr"
        Me.lbSCTLtr.Size = New System.Drawing.Size(28, 20)
        Me.lbSCTLtr.TabIndex = 70
        Me.lbSCTLtr.Text = "Ltr"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 413)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Total = "
        '
        'dgAllCustomer
        '
        Me.dgAllCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAllCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAllCustomer.Location = New System.Drawing.Point(695, 67)
        Me.dgAllCustomer.Name = "dgAllCustomer"
        Me.dgAllCustomer.Size = New System.Drawing.Size(648, 323)
        Me.dgAllCustomer.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(695, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 24)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Today Session List :"
        '
        'dgSingleCustomer
        '
        Me.dgSingleCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgSingleCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSingleCustomer.Location = New System.Drawing.Point(20, 124)
        Me.dgSingleCustomer.Name = "dgSingleCustomer"
        Me.dgSingleCustomer.Size = New System.Drawing.Size(640, 266)
        Me.dgSingleCustomer.TabIndex = 67
        '
        'tbTotalPrice
        '
        Me.tbTotalPrice.BackColor = System.Drawing.Color.White
        Me.tbTotalPrice.Enabled = False
        Me.tbTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotalPrice.ForeColor = System.Drawing.Color.Purple
        Me.tbTotalPrice.Location = New System.Drawing.Point(498, 70)
        Me.tbTotalPrice.Name = "tbTotalPrice"
        Me.tbTotalPrice.Size = New System.Drawing.Size(122, 30)
        Me.tbTotalPrice.TabIndex = 64
        '
        'tbFat
        '
        Me.tbFat.BackColor = System.Drawing.Color.White
        Me.tbFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFat.ForeColor = System.Drawing.Color.Purple
        Me.tbFat.Location = New System.Drawing.Point(115, 67)
        Me.tbFat.Name = "tbFat"
        Me.tbFat.Size = New System.Drawing.Size(122, 30)
        Me.tbFat.TabIndex = 63
        '
        'tbPricePLtr
        '
        Me.tbPricePLtr.BackColor = System.Drawing.Color.White
        Me.tbPricePLtr.Enabled = False
        Me.tbPricePLtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPricePLtr.ForeColor = System.Drawing.Color.Purple
        Me.tbPricePLtr.Location = New System.Drawing.Point(498, 26)
        Me.tbPricePLtr.Name = "tbPricePLtr"
        Me.tbPricePLtr.Size = New System.Drawing.Size(122, 30)
        Me.tbPricePLtr.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(324, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 20)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Total Price :"
        '
        'tbLtr
        '
        Me.tbLtr.BackColor = System.Drawing.Color.White
        Me.tbLtr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLtr.ForeColor = System.Drawing.Color.Purple
        Me.tbLtr.Location = New System.Drawing.Point(115, 26)
        Me.tbLtr.Name = "tbLtr"
        Me.tbLtr.Size = New System.Drawing.Size(122, 30)
        Me.tbLtr.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(328, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Price / Ltr. :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 20)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Fat :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 20)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Ltr. :"
        '
        'collect_milk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 686)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "collect_milk"
        Me.Text = "collect_milk1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgAllCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSingleCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents tbCustId As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents tbTotalPrice As System.Windows.Forms.TextBox
    Private WithEvents tbFat As System.Windows.Forms.TextBox
    Private WithEvents tbPricePLtr As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents tbLtr As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgSingleCustomer As System.Windows.Forms.DataGridView
    Private WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgAllCustomer As System.Windows.Forms.DataGridView
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCollect As System.Windows.Forms.Button
    Private WithEvents lbTiming As Label
    Private WithEvents Label12 As Label
    Private WithEvents lbAddress As Label
    Private WithEvents lbDate As Label
    Private WithEvents lbName As Label
    Private WithEvents tbCattle As TextBox
    Private WithEvents Label11 As Label
    Private WithEvents lbSCTPrice As Label
    Private WithEvents lbSCTLtr As Label
    Private WithEvents lbAllPrice As Label
    Private WithEvents lbAllLtr As Label
    Private WithEvents Label13 As System.Windows.Forms.Label
End Class
