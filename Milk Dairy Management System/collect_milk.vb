Public Class collect_milk
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            Query_Select("select c.First_Name,c.Surname,c.Address,cm.Name from Customer_Master c inner join Cattle_Master cm on c.Cattle=cm.Cattle_Id where c.Cust_Id=" & tbCustId.Text & "")
            If dr.Read Then
                lbName.Text = dr(0) + " " + dr(1)
                lbAddress.Text = dr(2)
                tbCattle.Text = dr(3)
                fill_dg_single()
                total_all()
            Else
                MessageBox.Show("Customer Not Found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub collect_milk_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            lbDate.Text = Date.Today.Date
            If Hour(DateAndTime.TimeOfDay) <= 13 Then
                lbTiming.Text = "Morning"
            ElseIf Hour(DateAndTime.TimeOfDay) > 13 Then
                lbTiming.Text = "Evening"
                lbName.Text = ""
                lbAddress.Text = ""
                tbCattle.Clear()
                total_all()
            End If
            fill_dg_all()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub btnCollect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCollect.Click
        Try
            If IsNumeric(tbLtr.Text) And IsNumeric(tbFat.Text) Then
                If Query_Inser_Update_Delete("insert into Collection_Master(Cust_Id,Timing,Litter,Fat,Price,Collection_Date,Status) values(" & tbCustId.Text & ",'" & lbTiming.Text & "'," & tbLtr.Text & "," & tbFat.Text & "," & tbTotalPrice.Text & ",'" & Today.ToString("yyyy-MM-dd") & "',0)") Then
                    MessageBox.Show("Milk Collected")
                    fill_dg_single()
                    fill_dg_all()
                    total_all()
                    Query_Select("select * from Bill_Master where Cust_Id =" & tbCustId.Text & " and Bill_Date is null")
                    If dr.Read Then
                        'MessageBox.Show("Found")
                        Query_Select("select max(Collection_Date),COUNT(distinct(Collection_Date)),SUM(Litter),SUM(Price) from Collection_Master where Status=0 and Cust_Id=" & tbCustId.Text & "")
                        If dr.Read Then
                            Dim d As Date
                            d = dr(0)
                            Dim tdays As Integer = dr(1)
                            Dim tlitter As Integer = dr(2)
                            Dim tprice As Integer = dr(3)
                            If Query_Inser_Update_Delete("update Bill_Master set To_Date='" & d.ToString("yyyy-MM-dd") & "', Days=" & tdays & ",Litter=" & tlitter & ",Ammount=" & tprice & " where Cust_Id=" & tbCustId.Text & " and Bill_Date is null") Then
                                'MessageBox.Show("done")
                            Else
                                ' MessageBox.Show("not done")
                            End If
                        End If
                    Else
                        If Query_Inser_Update_Delete("insert into Bill_Master(Cust_Id,From_Date,To_Date,Days,Litter,Ammount) select " & tbCustId.Text & ",min(Collection_Date),max(Collection_Date),COUNT(distinct(Collection_Date)),SUM(Litter),SUM(Price) from Collection_Master where Status=0 and Cust_Id=" & tbCustId.Text & "") Then
                            'MessageBox.Show("done")
                        Else
                            'MessageBox.Show("not done")
                        End If
                    End If
                Else
                    MessageBox.Show("Pleas First Fill All Fields!!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        

    End Sub

    Private Sub tbLtr_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tbLtr.Leave
        Try
            If IsNumeric(tbLtr.Text) Then
                If IsNumeric(tbFat.Text) Then
                    cal()
                End If
            Else
                MessageBox.Show("Please Enter Valid Values!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub tbFat_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles tbFat.Leave
        Try
            If IsNumeric(tbFat.Text) Then
                If IsNumeric(tbLtr.Text) Then
                    cal()
                End If
            Else
                MessageBox.Show("Please Enter Valid Values!!!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub
    Private Sub cal()
        Try
            Query_Select("select Fat_Rate from Cattle_Master where Name='" & tbCattle.Text & "'")
            If dr.Read Then
                tbPricePLtr.Text = Double.Parse(tbFat.Text) * dr(0)
                tbTotalPrice.Text = Double.Parse(tbPricePLtr.Text) * (tbLtr.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub
    Private Sub fill_dg_single()
        Try
            Query_FillDG("select  Collection_Date as 'Collection Date',Timing as 'Time',Litter as 'Ltr',Fat,Price from Collection_Master where Status=0 and Cust_Id=" & tbCustId.Text & " order by id desc")
            dgSingleCustomer.DataSource = dt
            da.Update(dt)
            Query_Select("select sum(Litter),sum(Price) from Collection_Master where Cust_Id=" & tbCustId.Text & " and Status=0")
            If dr.Read And Not IsDBNull(dr(0)) And Not IsDBNull(dr(1)) Then
                lbSCTLtr.Text = dr(0)
                lbSCTPrice.Text = dr(1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub fill_dg_all()
        Try
            Query_FillDG("select Cust_Id as 'Customer ID',Litter,Fat,Price from Collection_Master where Status=0 and Collection_Date = '" & Today.ToString("yyyy-MM-dd") & "' order by id desc")
            dgAllCustomer.DataSource = dt
            da.Update(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub tbCustId_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tbCustId.TextChanged
        Try
            clr()
            dgSingleCustomer.DataSource = vbNull
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub
    Private Sub total_all()
        Try
            Query_Select("select SUM(Litter) from Collection_Master where Collection_Date='" & Today.ToString("MM-dd-yyyy") & "' and Status=0")
            If dr.Read Then
                If Not IsDBNull(dr(0)) Then

                    lbAllLtr.Text = dr(0)
                Else
                    lbAllLtr.Text = "0"
                End If
            End If
            Query_Select("select SUM(Price) from Collection_Master where Collection_Date='" & Today.ToString("MM-dd-yyyy") & "' and Status=0")

            If dr.Read Then
                If Not IsDBNull(dr(0)) Then
                    lbAllPrice.Text = dr(0)
                Else
                    lbAllPrice.Text = "0"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub
    Private Sub clr()
        Try
            lbName.Text = ""
            lbAddress.Text = ""
            tbCattle.Clear()
            dt.Clear()
            fill_dg_all()
            tbLtr.Clear()
            tbFat.Clear()
            tbPricePLtr.Clear()
            tbTotalPrice.Clear()
            lbSCTLtr.Text = ""
            lbSCTPrice.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        

    End Sub

    Private Sub tbLtr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLtr.TextChanged
        Try
            If IsNumeric(tbLtr.Text) And IsNumeric(tbFat.Text) Then
                cal()
            Else
                tbPricePLtr.Clear()
                tbTotalPrice.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub tbFat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFat.TextChanged
        Try
            If IsNumeric(tbLtr.Text) And IsNumeric(tbFat.Text) Then
                cal()
            Else
                tbPricePLtr.Clear()
                tbTotalPrice.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    
End Class