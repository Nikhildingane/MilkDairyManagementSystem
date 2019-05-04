Public Class view_customer
    Private Sub view_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Query_FillDG("select c.First_Name as 'First Name',c.Surname,c.Contact_No as 'Contact No',c.Address,c.Cattle,c.Payment_Mode as 'Payment Mode',b.Bank_Name as 'Bank Name',b.Account_No as 'Account No',b.IFSC_Code as 'IFSC Code' from Customer_Master c left join Bank_Account_Master b on c.Cust_Id = b.Cust_Id order by c.Cust_Id desc")
        DataGridView1.DataSource = dt
        da.Update(dt)
    End Sub
End Class