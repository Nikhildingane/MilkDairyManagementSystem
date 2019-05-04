Public Class add_customer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If cbPaymentMode.SelectedIndex = 0 Then

                If tbFirstName.Text <> "" And tbSurname.Text <> "" And tbContactNo.Text <> "" And tbAddress.Text <> "" Then
                    If Query_Inser_Update_Delete("insert into Customer_Master values(" & tbCustId.Text & ",'" & tbFirstName.Text & "','" & tbSurname.Text & "','" & tbContactNo.Text & "','" & tbAddress.Text & "'," & cbCattle.SelectedIndex & ",	'" & cbPaymentMode.SelectedItem.ToString & "','" & Today.ToString("yyyy-MM-dd") & "')") Then

                        MessageBox.Show("Customer Successfully Added")
                        tbCustId.Text = Double.Parse(tbCustId.Text) + 1
                        tbFirstName.Clear()
                        tbSurname.Clear()
                        tbContactNo.Clear()
                        tbAddress.Clear()
                        cbCattle.SelectedIndex = 0
                        cbPaymentMode.SelectedIndex = 0
                        cbBankName.Text = ""
                        tbIFSCCode.Clear()
                        tbAccountNo.Clear()
                    Else

                        MessageBox.Show("Can't Add Customer")

                    End If
                Else
                    MessageBox.Show("Please First Fill All Fields")
                End If
            ElseIf cbPaymentMode.SelectedIndex = 1 Then
                If tbFirstName.Text <> "" And tbSurname.Text <> "" And tbContactNo.Text <> "" And tbAddress.Text <> "" And cbBankName.Text <> "" And tbAccountNo.Text <> "" And tbIFSCCode.Text <> "" Then
                    If Query_Inser_Update_Delete("insert into Customer_Master values(" & tbCustId.Text & ",'" & tbFirstName.Text & "','" & tbSurname.Text & "','" & tbContactNo.Text & "','" & tbAddress.Text & "'," & cbCattle.SelectedIndex & ",	'" & cbPaymentMode.SelectedItem.ToString & "','" & Today.ToString("yyyy-MM-dd") & "')") And Query_Inser_Update_Delete("insert into Bank_Account_Master(Cust_Id,Bank_Name,Account_No,IFSC_Code) values(" & tbCustId.Text & ",'" & cbBankName.Text & "','" & tbAccountNo.Text & "','" & tbIFSCCode.Text & "')") Then

                        MessageBox.Show("Customer Successfully Added")
                        tbCustId.Text = Double.Parse(tbCustId.Text) + 1
                        tbFirstName.Clear()
                        tbSurname.Clear()
                        tbContactNo.Clear()
                        tbAddress.Clear()
                        cbCattle.SelectedIndex = 0
                        cbPaymentMode.SelectedIndex = 0
                        cbBankName.Text = ""
                        tbIFSCCode.Clear()
                    Else

                        MessageBox.Show("Can't Add Customer")

                    End If
                Else
                    MessageBox.Show("Please First Fill All Fields")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        

    End Sub

    Private Sub add_customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Query_Select("select Name from Cattle_Master")
            While dr.Read
                cbCattle.Items.Add(dr(0))
            End While
            cbCattle.SelectedIndex = 0
            cbPaymentMode.SelectedIndex = 0
            If Not IsDBNull(Query_ExecuteScalar("select MAX(Cust_Id) from Customer_Master")) Then
                tbCustId.Text = Double.Parse(Query_ExecuteScalar("select MAX(Cust_Id) from Customer_Master")) + 1
            Else
                tbCustId.Text = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub cbPaymentMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbPaymentMode.SelectedIndexChanged
        Try
            If cbPaymentMode.SelectedIndex = 0 Then
                cbBankName.Enabled = False
                tbAccountNo.Enabled = False
                tbIFSCCode.Enabled = False
            ElseIf cbPaymentMode.SelectedIndex = 1 Then
                cbBankName.Enabled = True
                tbAccountNo.Enabled = True
                tbIFSCCode.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub tbContactNo_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tbContactNo.Leave
        Try
            If Not IsNumeric(tbContactNo.Text) Then
                MessageBox.Show("Please enter valid contact no")
                tbContactNo.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub tbAccountNo_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tbAccountNo.Leave
        Try
            If Not IsNumeric(tbAccountNo.Text) Then
                MessageBox.Show("Please enter valid Account no")
                tbAccountNo.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            tbFirstName.Clear()
            tbSurname.Clear()
            tbContactNo.Clear()
            tbAddress.Clear()
            cbCattle.SelectedIndex = 0
            cbPaymentMode.SelectedIndex = 0
            cbBankName.Text = ""
            tbIFSCCode.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
       
    End Sub
End Class