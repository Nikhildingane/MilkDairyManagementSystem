Imports System.Data.SqlClient
Public Class ReportFormReportUnpaid
    
    Private Sub ReportFormReportPaid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cr As New CrystalReportUnpaid
        Dim Str As String = "select * from Customer_Master c inner join Bill_Master b on c.Cust_Id=b.Cust_Id inner join Cattle_Master cm on c.Cattle=cm.Cattle_Id where b.Bill_Date is null"
        con_close()
        con_open()
        da = New SqlDataAdapter(Str, con)
        Dim ds As New DataSet
        da.Fill(ds, "ViewBill")
        cr.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Refresh()
        cr.Refresh()
    End Sub

End Class