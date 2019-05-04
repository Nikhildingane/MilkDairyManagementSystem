Public Class update_delete_customer
    Dim mode As String
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If cbPaymentMode.SelectedIndex = 0 Then
            If tbFirstName.Text <> "" And tbSurname.Text <> "" And tbContactNo.Text <> "" And tbAddress.Text <> "" And cbPaymentMode.Text <> "" Then
                If Query_Inser_Update_Delete("update  Customer_Master set First_Name='" & tbFirstName.Text & "',Surname='" & tbSurname.Text & "',Contact_No=" & tbContactNo.Text & ",Address='" & tbAddress.Text & "',Payment_Mode='" & cbPaymentMode.Text & "' where Cust_Id=1") Then
                    MessageBox.Show("Customer Successfully Updated")
                Else
                    MessageBox.Show("Can't Update Customer")
                End If
            Else
                MessageBox.Show("Please Fill all mandotory fields!!!!!!!!!!")

            End If

        ElseIf cbPaymentMode.SelectedIndex = 1 Then
            If tbFirstName.Text <> "" And tbSurname.Text <> "" And tbContactNo.Text <> "" And tbAddress.Text <> "" And cbPaymentMode.Text <> "" And cbBankName.Text <> "" And tbAccountNo.Text <> "" And tbIFSCCode.Text <> "" Then
                Query_Select("select Payment_Mode from Customer_Master where Cust_Id = " & tbCustId.Text & "")
                If dr.Read Then
                    If dr(0) = "Cash" Then
                        If Query_Inser_Update_Delete("update  Customer_Master set First_Name='" & tbFirstName.Text & "',Surname='" & tbSurname.Text & "',Contact_No=" & tbContactNo.Text & ",Address='" & tbAddress.Text & "',Payment_Mode='" & cbPaymentMode.Text & "' where Cust_Id=1") And Query_Inser_Update_Delete("insert into Bank_Account_Master(Cust_Id,Bank_Name,Account_No,IFSC_Code) values(" & tbCustId.Text & ",'" & cbBankName.Text & "','" & tbAccountNo.Text & "','" & tbIFSCCode.Text & "')") Then
                            MessageBox.Show("Customer Successfully Updated")
                        Else
                            MessageBox.Show("Can't Update Customer")
                        End If
                    ElseIf dr(0) = "Bank" Then
                        If Query_Inser_Update_Delete("update  Customer_Master set First_Name='" & tbFirstName.Text & "',Surname='" & tbSurname.Text & "',Contact_No=" & tbContactNo.Text & ",Address='" & tbAddress.Text & "',Payment_Mode='" & cbPaymentMode.Text & "' where Cust_Id=1") And Query_Inser_Update_Delete("update Bank_Account_Master set Bank_Name='" & cbBankName.Text & "',Account_No=" & tbAccountNo.Text & ",IFSC_Code='" & tbIFSCCode.Text & "' where Cust_Id = " & tbCustId.Text & "") Then
                            MessageBox.Show("Customer Successfully Updated")
                        Else
                            MessageBox.Show("Can't Update Customer")
                        End If
                    End If
                End If
            Else
                MessageBox.Show("Please Fill all mandotory fields!!!!!!!!!!")
            End If

        End If


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If IsNumeric(tbCustId.Text) Then
            Query_Select("select * from Customer_Master where Cust_Id=" & tbCustId.Text & "")
            If dr.Read Then
                MessageBox.Show("Customer Found")

                tbFirstName.Text = dr(1)
                tbSurname.Text = dr(2)
                tbContactNo.Text = dr(3)
                tbAddress.Text = dr(4)
                If 0 = dr(5) Then
                    cbCattle.SelectedIndex = 0
                ElseIf 1 = dr(5) Then
                    cbCattle.SelectedIndex = 1
                End If
                mode = dr(6)
                cbPaymentMode.Text = dr(6)

                Query_Select("select * from Bank_Account_Master where Cust_Id=" & tbCustId.Text & "")
                If dr.Read Then
                    cbBankName.Text = dr(2)
                    tbAccountNo.Text = dr(3)
                    tbIFSCCode.Text = dr(4)

                End If
                enable()
            Else
                MessageBox.Show("Customer Not found")
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tbAccountNo_Leave(sender As Object, e As EventArgs) Handles tbAccountNo.Leave
        If Not IsNumeric(tbAccountNo.Text) Then
            tbAccountNo.Clear()
            MessageBox.Show("Please Enter Valid Account NUmber")
        End If
    End Sub

    Private Sub tbContactNo_Leave(sender As Object, e As EventArgs) Handles tbContactNo.Leave
        If Not IsNumeric(tbContactNo.Text) Then
            tbContactNo.Clear()
            MessageBox.Show("Please Enter Valid Mobile NUmber")
        End If
    End Sub

    Private Sub btnClere_Click(sender As Object, e As EventArgs) Handles btnClere.Click
        clr()
        disable()
    End Sub

    Private Sub enable()
        tbFirstName.Enabled = True
        tbSurname.Enabled = True
        tbContactNo.Enabled = True
        tbAddress.Enabled = True
        cbPaymentMode.Enabled = True
        cbBankName.Enabled = True
        tbAccountNo.Enabled = True
        tbIFSCCode.Enabled = True
    End Sub
    Private Sub disable()
        tbFirstName.Enabled = False
        tbSurname.Enabled = False
        tbContactNo.Enabled = False
        tbAddress.Enabled = False
        cbPaymentMode.Enabled = False
        cbBankName.Enabled = False
        tbAccountNo.Enabled = False
        tbIFSCCode.Enabled = False
    End Sub
    Private Sub clr()
        tbFirstName.Clear()
        tbSurname.Clear()
        tbContactNo.Clear()
        tbAddress.Clear()
        cbPaymentMode.SelectedIndex = 0
        cbBankName.SelectedIndex = 0
        tbAccountNo.Clear()
        tbIFSCCode.Clear()
    End Sub

    Private Sub tbCustId_TextChanged(sender As Object, e As EventArgs) Handles tbCustId.TextChanged
        clr()
        disable()
    End Sub

    Private Sub update_delete_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Query_Select("select Name from Cattle_Master")
        While dr.Read
            cbCattle.Items.Add(dr(0))
        End While
        cbCattle.SelectedIndex = 0
        cbPaymentMode.SelectedIndex = 0
        cbBankName.SelectedIndex = 0
    End Sub
End Class