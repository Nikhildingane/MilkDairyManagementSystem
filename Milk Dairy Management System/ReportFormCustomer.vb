Imports System.Data.SqlClient
Public Class ReportFormCustomer

    Private Sub ReportFormCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cr As New CrystalReportCustomer
        Dim Str As String = "select * from Customer_Master c inner join Cattle_Master cm on c.Cattle=cm.Cattle_Id"
        con_close()
        con_open()
        da = New SqlDataAdapter(Str, con)
        Dim ds As New DataSet
        da.Fill(ds, "ViewCustomer")
        cr.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = cr
        CrystalReportViewer1.Refresh()
        cr.Refresh()
    End Sub
End Class