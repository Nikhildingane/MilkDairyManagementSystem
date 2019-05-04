Public Class payment
    Private Sub payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_dg("")
        ' total("")
    End Sub

    Private Sub tbCustomerId_TextChanged(sender As Object, e As EventArgs) Handles tbCustomerId.TextChanged
        If tbCustomerId.Text = "" Then
            fill_dg("")
            ' total("")
            btnSearch.Enabled = False
        ElseIf IsNumeric(tbCustomerId.Text) Then
            btnSearch.Enabled = True
            btnMakePayment.Enabled = False
        End If
    End Sub
    Private Function fill_dg(ByVal s As String)
        Query_FillDG("select Bill_Id as 'Bill ID',Cust_Id as 'Customer_Id',From_Date as 'From Date',To_Date as 'To Date',Days,Litter as 'Ltr',Ammount from Bill_Master where Cust_Id like '%" & s & "%' and Bill_Date is null")
        DataGridView1.DataSource = dt
        da.Update(dt)
        total(s)
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If IsNumeric(tbCustomerId.Text) Then
            fill_dg(tbCustomerId.Text)
            btnMakePayment.Enabled = True
        End If
    End Sub

    Private Sub btnMakePayment_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click
        If tbCustomerId.Text = "" Then
            If Query_Inser_Update_Delete("update Collection_Master set Status = 1 where Status=0") And Query_Inser_Update_Delete("update Bill_Master set Bill_Date='" & Today.ToString("yyyy-MM-dd") & "' where Bill_Date is null") Then
                MessageBox.Show("Payment Successfull")
                fill_dg("")
            End If
        ElseIf IsNumeric(tbCustomerId.Text) Then
            If Query_Inser_Update_Delete("update Collection_Master set Status = 1 where Status=0 and Cust_Id=" & tbCustomerId.Text & "") And Query_Inser_Update_Delete("update Bill_Master set Bill_Date='" & Today.ToString("yyyy-MM-dd") & "' where Bill_Date is null and Cust_Id=" & tbCustomerId.Text & "") Then
                MessageBox.Show("Payment Successfull")
                fill_dg("")
                tbCustomerId.Clear()
            End If
        End If
    End Sub
    Private Function total(ByVal s As String)
        Query_Select("select sum(Litter),sum(Ammount) from Bill_Master where Cust_Id like '%" & s & "%' and Bill_Date is null")
        If dr.Read Then
            If Not IsDBNull(dr(0)) And Not IsDBNull(dr(1)) Then
                lbLtr.Text = dr(0)
                lbPrice.Text = dr(1)
            End If
        End If
    End Function
End Class