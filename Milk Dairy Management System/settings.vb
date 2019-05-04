Public Class settings

    Private Sub tabControl1_Click(sender As Object, e As EventArgs) Handles tabControl1.Click

    End Sub

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Query_Select("select Name from Cattle_Master")
        While dr.Read()
            cbCattle.Items.Add(dr(0))
        End While
        cbCattle.SelectedIndex = 0
        tbUsername.Text = user_id
    End Sub

    Private Sub cbCattle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCattle.SelectedIndexChanged
        Query_Select("select Fat_Rate from Cattle_Master where Name='" & cbCattle.SelectedItem.ToString & "'")
        If dr.Read Then
            tbCureentFatPrice.Text = dr(0)
        End If
    End Sub

    Private Sub btnSetPrice_Click(sender As Object, e As EventArgs) Handles btnSetPrice.Click
        If IsNumeric(tbNewFatPrice.Text) Then
            If Query_Inser_Update_Delete("update Cattle_Master set Fat_Rate=" & tbNewFatPrice.Text & " where Name='" & cbCattle.Text & "'") Then
                MessageBox.Show("Fat Rate Changed")
                tbNewFatPrice.Clear()
                Query_Select("select Fat_Rate from Cattle_Master where Name='" & cbCattle.SelectedItem.ToString & "'")
                If dr.Read Then
                    tbCureentFatPrice.Text = dr(0)
                End If
            End If
        Else
            MessageBox.Show("Please Enter Valid Rate Value")
            tbNewFatPrice.Clear()
        End If

    End Sub
    Private Sub tbNewFatPrice_Leave(sender As Object, e As EventArgs) Handles tbNewFatPrice.Leave
        If Not IsNumeric(tbNewFatPrice.Text) Then
            MessageBox.Show("Please Enter Valid Rate Value")
            tbNewFatPrice.Clear()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If tbUsername.Text <> "" And tbOldPassword.Text <> "" And tbNewPassword.Text <> "" And tbConfirmPassword.Text <> "" Then
            Query_Select("select * from Users where UName='" & tbUsername.Text & "' and PWord='" & tbOldPassword.Text & "'")
            If dr.Read Then
                If tbNewPassword.Text = tbConfirmPassword.Text Then
                    If Query_Inser_Update_Delete("update Users set PWord='" & tbNewPassword.Text & "' where UName='" & tbUsername.Text & "' and PWord='" & tbOldPassword.Text & "'") Then
                        MessageBox.Show("Password Changed")
                    Else
                        MessageBox.Show("Can't Update")
                    End If
                Else
                        MessageBox.Show("Password did not match!!!")
                End If
            Else
                MessageBox.Show("Wrong Password")
            End If
        Else
            MessageBox.Show("Please fill all ther fields first!!")
        End If
    End Sub
End Class