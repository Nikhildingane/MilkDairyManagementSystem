Public Class MDIParent_Main
    Private Sub FatRateToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
         If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCustomerToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
        add_customer.MdiParent = Me
        add_customer.WindowState = FormWindowState.Maximized
        add_customer.Show()
    End Sub

    Private Sub UpdateCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCustomerToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
        update_delete_customer.MdiParent = Me
        update_delete_customer.WindowState = FormWindowState.Maximized
        update_delete_customer.Show()
    End Sub

    Private Sub ViewCustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
        view_customer.MdiParent = Me
        view_customer.WindowState = FormWindowState.Maximized
        view_customer.Show()
    End Sub

    Private Sub CollectMilkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CollectMilkToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
        collect_milk.MdiParent = Me
        collect_milk.WindowState = FormWindowState.Maximized
        collect_milk.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
        users.MdiParent = Me
        users.WindowState = FormWindowState.Maximized
        users.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
        payment.MdiParent = Me
        payment.WindowState = FormWindowState.Maximized
        payment.Show()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        If ActiveMdiChild IsNot Nothing Then
            ActiveMdiChild.Close()
        End If
        settings.MdiParent = Me
        settings.WindowState = FormWindowState.Maximized
        settings.Show()
    End Sub

    Private Sub MDIParent_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If user_id = "admin" Then
            ToolStripMenuItem1.Enabled = True
        Else
            ToolStripMenuItem1.Enabled = False
        End If
    End Sub

    Private Sub CustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem1.Click
        ReportFormCustomer.MdiParent = Me
        ReportFormCustomer.WindowState = FormWindowState.Maximized
        ReportFormCustomer.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        ReportFormCustomerBank.MdiParent = Me
        ReportFormCustomerBank.WindowState = FormWindowState.Maximized
        ReportFormCustomerBank.Show()
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        ReportFormReportPaid.MdiParent = Me
        ReportFormReportPaid.WindowState = FormWindowState.Maximized
        ReportFormReportPaid.Show()

    End Sub

    Private Sub PaymentUnpaidToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentUnpaidToolStripMenuItem.Click
        ReportFormReportUnpaid.MdiParent = Me
        ReportFormReportUnpaid.WindowState = FormWindowState.Maximized
        ReportFormReportUnpaid.Show()
    End Sub

    Private Sub MilkCollectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MilkCollectionToolStripMenuItem.Click
        ReportFormMilkCollection.MdiParent = Me
        ReportFormMilkCollection.WindowState = FormWindowState.Maximized
        ReportFormMilkCollection.Show()
    End Sub

    Private Sub MDIParent_Main_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        user_id = ""
    End Sub
End Class
