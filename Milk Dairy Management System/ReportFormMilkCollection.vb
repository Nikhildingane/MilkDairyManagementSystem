Imports System.Data.SqlClient
Public Class ReportFormMilkCollection
    Dim mont As String = ""
    Dim yr As String = ""
    Private Sub ReportFornMilkCollection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Query_Select("select distinct(YEAR(Collection_Date)) from Collection_Master")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cr As New CrystalReportMilkCollection
        Dim Str As String = "select * from Customer_Master c inner join Collection_Master cm on c.Cust_Id =cm.Cust_Id inner join Cattle_Master ctm on c.Cattle=ctm.Cattle_Id where year(cm.Collection_Date) like '%" & yr & "%' and MONTH(cm.Collection_Date) like '%" & mont & "%'"
        con_close()
        con_open()
        da = New SqlDataAdapter(Str, con)
        Dim ds As New DataSet
        da.Fill(ds, "ViewCollection")
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