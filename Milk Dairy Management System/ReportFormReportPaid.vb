Imports System.Data.SqlClient
Public Class ReportFormReportPaid
    Dim mont As String = ""
    Dim yr As String = ""
    Private Sub ReportFormReportPaid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Query_Select("select distinct(YEAR(Bill_Date)) from Bill_Master")
        ComboBox1.Items.Add("All")
        While dr.Read
            If Not IsDBNull(dr(0)) And dr(0).ToString <> "1900" Then
                ComboBox1.Items.Add(dr(0))
            End If
        End While
        ComboBox2.Items.Add("All")
        For i As Integer = 1 To 12
            ComboBox2.Items.Add(MonthName(i))
        Next
        ComboBox2.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cr As New CrystalReportBillPaid
        Dim Str As String = "select * from Customer_Master c inner join Bill_Master b on c.Cust_Id=b.Cust_Id inner join Cattle_Master cm on c.Cattle=cm.Cattle_Id where b.Bill_Date is not null and year(b.Bill_Date) like '%" & yr & "%' and MONTH(b.Bill_Date) like '%" & mont & "%'"
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

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex = 0 Then
            mont = ""
        ElseIf ComboBox2.SelectedIndex > 0 Then
            mont = ComboBox2.SelectedIndex
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            yr = ""
        ElseIf ComboBox1.SelectedIndex > 0 Then
            yr = ComboBox1.Text
        End If
    End Sub
End Class