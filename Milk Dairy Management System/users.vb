Public Class users
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Query_Select("select UName from Users")
        cbEUUsername.Items.Add("Select Username")
        cbDUUsername.Items.Add("Select Username")
        While dr.Read
            cbEUUsername.Items.Add(dr(0))
            cbDUUsername.Items.Add(dr(0))
        End While
        cbEUUsername.SelectedIndex = 0
        cbDUUsername.SelectedIndex = 0
        fill_dg()
    End Sub

    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        If tbANUFN.Text <> "" And tbANULN.Text <> "" And tbANUserName.Text <> "" And tbANUPassword.Text <> "" Then
            If tbANUPassword.Text = tbADUPassword2.Text Then
                If Query_Inser_Update_Delete("insert into Users(First_Name,Last_Name,UName,PWord) values('" & tbANUFN.Text & "','" & tbANULN.Text & "','" & tbANUserName.Text & "','" & tbANUPassword.Text & "')") Then
                    MessageBox.Show("User Created")
                    cbDUUsername.Items.Clear()
                    cbEUUsername.Items.Clear()
                    Query_Select("select UName from Users")
                    cbEUUsername.Items.Add("Select Username")
                    cbDUUsername.Items.Add("Select Username")
                    While dr.Read
                        cbEUUsername.Items.Add(dr(0))
                        cbDUUsername.Items.Add(dr(0))
                    End While
                    cbEUUsername.SelectedIndex = 0
                    cbDUUsername.SelectedIndex = 0
                    fill_dg()
                Else
                    MessageBox.Show("Can't Add")
                End If
            Else
                MessageBox.Show("Password Did Not Match!!!")
            End If
        Else
            MessageBox.Show("Please Fill All Fields!!!")
        End If



    End Sub
    Private Sub cbEUUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEUUsername.SelectedIndexChanged
        If cbEUUsername.Items.Contains(cbEUUsername.Text) Then
            If cbEUUsername.SelectedIndex > 0 Then
                Query_Select("select * from Users where UName='" & cbEUUsername.Text & "'")
                If dr.Read Then
                    tbEUFN.Text = dr(1)
                    tbEULN.Text = dr(2)
                End If
            End If
        Else
            MessageBox.Show("Wrong Username!!")
        End If

    End Sub


    Private Sub cbEUUsername_Leave(sender As Object, e As EventArgs) Handles cbEUUsername.Leave
        If cbEUUsername.Items.Contains(cbEUUsername.Text) Then
            If cbEUUsername.SelectedIndex > 0 Then
                Query_Select("select * from Users where UName='" & cbEUUsername.Text & "'")
                If dr.Read Then
                    tbEUFN.Text = dr(1)
                    tbEULN.Text = dr(2)
                    btnEdit.Enabled = True
                End If
            End If
        Else
            MessageBox.Show("Wrong Username!!")
            cbEUUsername.SelectedIndex = 0
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If tbEUFN.Text <> "" And tbEULN.Text <> "" And tbEUPassword.Text <> "" Then
            Query_Select("select * from Users where UName='" & cbEUUsername.Text & "' and PWord='" & tbEUPassword.Text & "'")
            If dr.Read Then
                If Query_Inser_Update_Delete("update Users set First_Name='" & tbEUFN.Text & "',Last_Name='" & tbEULN.Text & "' where UName='" & cbEUUsername.Text & "'") Then
                    MessageBox.Show("User Updated")
                    tbEUFN.Clear()
                    tbEULN.Clear()
                    tbEUPassword.Clear()
                    fill_dg()
                Else
                    MessageBox.Show("Wrong Password!!!")
                End If
            Else
                MessageBox.Show("Wrong Password!!!")
            End If
        Else
            MessageBox.Show("Please Fill All Fields!!!")
        End If
    End Sub
    Private Sub cbDUUsername_Leave(sender As Object, e As EventArgs) Handles cbDUUsername.Leave
        If cbDUUsername.Items.Contains(cbDUUsername.Text) Then
            If cbDUUsername.SelectedIndex > 0 Then
                Query_Select("select * from Users where UName='" & cbDUUsername.Text & "'")
                If dr.Read Then
                    tbDUFirstName.Text = dr(1)
                    tbDULastName.Text = dr(2)
                    btnDelete.Enabled = True
                End If
            End If
        Else
            MessageBox.Show("Wrong Username!!")
            cbDUUsername.SelectedIndex = 0
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub cbDUUsername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDUUsername.SelectedIndexChanged
        If cbDUUsername.Items.Contains(cbDUUsername.Text) Then
            If cbDUUsername.SelectedIndex > 0 Then
                Query_Select("select * from Users where UName='" & cbDUUsername.Text & "'")
                If dr.Read Then
                    tbDUFirstName.Text = dr(1)
                    tbDULastName.Text = dr(2)
                    btnDelete.Enabled = True
                End If
            End If
        Else
            MessageBox.Show("Wrong Username!!")
            cbDUUsername.SelectedIndex = 0
            btnDelete.Enabled = False
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If tbDUFirstName.Text <> "" And tbDULastName.Text <> "" And tbDUPassword.Text <> "" Then
            If Query_Inser_Update_Delete("delete from Users where UName='" & cbDUUsername.Text & "' and PWord='" & tbDUPassword.Text & "'") Then
                MessageBox.Show("User Deleted")
                tbDUFirstName.Clear()
                tbDULastName.Clear()
                tbDUPassword.Clear()
                cbDUUsername.Items.Clear()
                cbEUUsername.Items.Clear()
                Query_Select("select UName from Users")
                cbEUUsername.Items.Add("Select Username")
                cbDUUsername.Items.Add("Select Username")
                While dr.Read
                    cbEUUsername.Items.Add(dr(0))
                    cbDUUsername.Items.Add(dr(0))
                End While
                cbEUUsername.SelectedIndex = 0
                cbDUUsername.SelectedIndex = 0
                fill_dg()
            Else
                MessageBox.Show("Wrong Password!!!")
            End If
        Else
            MessageBox.Show("Please First Fill All Fields")
        End If
    End Sub
    Private Sub fill_dg()
        Query_FillDG("select First_Name as 'First Name',Last_Name as 'Last Name',UName as 'Username' from Users")
        DataGridView1.DataSource = dt
        da.Update(dt)
    End Sub
End Class