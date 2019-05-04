<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent_Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CollectMilkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentUnpaidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MilkCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Wheat
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.CollectionToolStripMenuItem, Me.ToolStripMenuItem1, Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.HelpToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(911, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(78, 29)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.UpdateCustomerToolStripMenuItem, Me.ViewCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'UpdateCustomerToolStripMenuItem
        '
        Me.UpdateCustomerToolStripMenuItem.Name = "UpdateCustomerToolStripMenuItem"
        Me.UpdateCustomerToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.UpdateCustomerToolStripMenuItem.Text = "Update Customer"
        '
        'ViewCustomerToolStripMenuItem
        '
        Me.ViewCustomerToolStripMenuItem.Name = "ViewCustomerToolStripMenuItem"
        Me.ViewCustomerToolStripMenuItem.Size = New System.Drawing.Size(240, 30)
        Me.ViewCustomerToolStripMenuItem.Text = "View Customer"
        '
        'CollectionToolStripMenuItem
        '
        Me.CollectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CollectMilkToolStripMenuItem})
        Me.CollectionToolStripMenuItem.Name = "CollectionToolStripMenuItem"
        Me.CollectionToolStripMenuItem.Size = New System.Drawing.Size(113, 29)
        Me.CollectionToolStripMenuItem.Text = "Collection"
        '
        'CollectMilkToolStripMenuItem
        '
        Me.CollectMilkToolStripMenuItem.Name = "CollectMilkToolStripMenuItem"
        Me.CollectMilkToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.CollectMilkToolStripMenuItem.Text = "Collect Milk"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(72, 29)
        Me.ToolStripMenuItem1.Text = "Users"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(102, 29)
        Me.HelpToolStripMenuItem.Text = "Payment"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(96, 29)
        Me.HelpToolStripMenuItem1.Text = "Settings"
        '
        'HelpToolStripMenuItem2
        '
        Me.HelpToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem1, Me.ToolStripMenuItem2, Me.PaymentToolStripMenuItem, Me.PaymentUnpaidToolStripMenuItem, Me.MilkCollectionToolStripMenuItem})
        Me.HelpToolStripMenuItem2.Name = "HelpToolStripMenuItem2"
        Me.HelpToolStripMenuItem2.Size = New System.Drawing.Size(94, 29)
        Me.HelpToolStripMenuItem2.Text = "Reports"
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(241, 30)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(241, 30)
        Me.ToolStripMenuItem2.Text = "Customer(Bank)"
        '
        'PaymentToolStripMenuItem
        '
        Me.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        Me.PaymentToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
        Me.PaymentToolStripMenuItem.Text = "Payment(Paid)"
        '
        'PaymentUnpaidToolStripMenuItem
        '
        Me.PaymentUnpaidToolStripMenuItem.Name = "PaymentUnpaidToolStripMenuItem"
        Me.PaymentUnpaidToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
        Me.PaymentUnpaidToolStripMenuItem.Text = "Payment(Unpaid)"
        '
        'MilkCollectionToolStripMenuItem
        '
        Me.MilkCollectionToolStripMenuItem.Name = "MilkCollectionToolStripMenuItem"
        Me.MilkCollectionToolStripMenuItem.Size = New System.Drawing.Size(241, 30)
        Me.MilkCollectionToolStripMenuItem.Text = "Milk Collection"
        '
        'MDIParent_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Milk_Dairy_Management_System.My.Resources.Resources._0_98328200_1508333683_milk_production
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 540)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MDIParent_Main"
        Me.Text = "Milk Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CollectMilkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentUnpaidToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MilkCollectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
